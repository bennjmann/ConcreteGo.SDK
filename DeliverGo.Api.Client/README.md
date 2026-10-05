# DeliverGo.Api.Client

A small .NET library for talking to the DeliverGo / iSTRADA.net API. It handles the
OAuth 2.0 client-credentials flow against Sysdyne ID (token caching and refresh) and
exposes typed read access to snail trails, tickets and trucks, plus full CRUD for
orders.

## Configuration

```json
{
  "DeliverGo": {
	"ClientId": "<client id>",
	"ClientSecret": "<client secret>",
	"Scopes": [ "snailtrail:read", "ticket:read", "truck:read", "order:read", "order:write" ],
	"BaseAddress": "https://api.istrada.net/api/",
	"TokenEndpoint": "https://id.sysdyne.cloud/token",
	"DefaultLimit": 100
  }
}
```

`Resource` defaults to `BaseAddress` without its trailing slash, which matches the
`resource=https://api.istrada.net/api` value expected by Sysdyne ID.

## Registration

```csharp
builder.Services.AddDeliverGoApiClient(
	builder.Configuration.GetSection(DeliverGoOptions.SectionName));
```

Or configure in code:

```csharp
builder.Services.AddDeliverGoApiClient(options =>
{
	options.ClientId = "...";
	options.ClientSecret = "...";
	options.Scopes = ["ticket:read", "truck:read", "order:read", "order:write"];
});
```

## Usage

```csharp
public sealed class DispatchService(IDeliverGoApiClient client)
{
	public async Task<IReadOnlyList<Ticket>> GetTodaysTicketsAsync(string plantNumber, CancellationToken ct)
	{
		var filter = new DeliverGoFilter()
			.WithWhere("plantNumber", plantNumber)
			.WithWhere("ticketDate", new Dictionary<string, object?>
			{
				["gte"] = DateTimeOffset.UtcNow.Date
			})
			.WithOrder("ticketDate DESC")
			.WithLimit(200);

		return await client.GetTicketsAsync(filter, ct);
	}
}
```

Single records are fetched by id and return `null` when not found:

```csharp
Truck? truck = await client.GetTruckAsync(truckId, cancellationToken: ct);
```

### Orders

Orders support the full create/read/update/delete surface:

```csharp
var filter = new DeliverGoFilter()
	.WithWhere("status", "open")
	.WithWhere("orderDate", new Dictionary<string, object?>
	{
		["gte"] = DateTimeOffset.UtcNow.Date
	})
	.WithOrder("orderDate DESC")
	.WithLimit(100);

IReadOnlyList<Order> orders = await client.GetOrdersAsync(filter, ct);

Order? order = await client.GetOrderAsync(orderId, cancellationToken: ct);

Order created = await client.CreateOrderAsync(
	new Order
	{
		Number = "SO-1001",
		OrderDate = DateTimeOffset.UtcNow,
		DeliveryAddress = "123 Main St",
	},
	ct);

Order updated = await client.UpdateOrderAsync(
	created.Id!,
	new Order { Status = "closed" },
	ct);

await client.DeleteOrderAsync(created.Id!, ct);
```

`Order` maps the stable scalar fields explicitly (`Number`, `OrderDate`,
`DeliveryAddress`, `Status`, `Taxable`, `TaxRate`, `CompanyId`, `CustomerId`,
`ProjectId`, timestamps, ...) and exposes `Location` as a `GeoPoint`. The volatile
nested structures (`Region`, `Original`, `Routes`) stay as raw `JsonElement?`, and
anything else the API returns lands in `AdditionalData` - the same convention used
by `Ticket`.

## Notes

- Several endpoints reject unfiltered queries, so supply a `DeliverGoFilter`.
  When no `limit` is provided, `DefaultLimit` from the options is applied.
- The API has no rate limiting; large queries degrade the iSTRADA site, so keep
  result sets bounded.
- Non-success responses throw `DeliverGoApiException` with the status code,
  request URI and raw response body.
- Writes map to `POST /orders`, `PATCH /orders/{id}` and `DELETE /orders/{id}`.
  Request bodies are serialized with camelCase property names.
- A `404` is translated to `null` for reads only; write operations throw
  `DeliverGoApiException` so a missing record is never mistaken for success.
- Empty and `204 No Content` responses are handled and yield no payload.
- A `401` triggers one automatic token refresh and retry.
