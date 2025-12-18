Add to program.cs

builder.Services.AddConcreteGoApiClient(builder.Configuration);

Add to appsettings.json

"ConcreteGoApi": {
  "Username": "user@domain.com.au",
  "Password": "password",
  "AppId": "appId",
  "AppKey": "appkey",
  "Slug": "slug"
}

Replace the values with your ConcreteGo credentials.

use DI to get an instance of the client

public class MyService
{
	private readonly IConcreteGoApiClient _concreteGoApiClient;
	public MyService(IConcreteGoApiClient concreteGoApiClient)
	{
		_concreteGoApiClient = concreteGoApiClient;
	}

	public async Task SomeMethodAsync()
	{
		var tickets = await _concreteGoApiClient.GetTicketsAsync(options =>
		{
		   options.FromOrderDate = ReportStart.AddDays(-1);
                    options.ToOrderDate = ReportEnd.AddDays(1);
                    options.IncludeRemovedTicket = true;
		});
		
	}
}