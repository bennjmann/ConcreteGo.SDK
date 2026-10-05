using System.Text.Json;
using System.Text.Json.Serialization;

namespace DeliverGo.Api.Client.Models
{
    /// <summary>
    /// LoopBack style query filter accepted by the iSTRADA API <c>filter</c> query parameter.
    /// Several endpoints reject unfiltered queries, so supplying at least a
    /// <see cref="Where"/> or <see cref="Limit"/> clause is recommended.
    /// </summary>
    public sealed class DeliverGoFilter
    {
        /// <summary>
        /// Field name/value conditions, for example <c>{ ["truckId"] = "123" }</c>.
        /// Values may be nested dictionaries for operators such as <c>gt</c> or <c>between</c>.
        /// </summary>
        [JsonPropertyName("where")]
        public IDictionary<string, object?>? Where { get; set; }

        /// <summary>
        /// Fields to include (<see langword="true"/>) or exclude (<see langword="false"/>).
        /// </summary>
        [JsonPropertyName("fields")]
        public IDictionary<string, bool>? Fields { get; set; }

        /// <summary>
        /// Related models to eager load.
        /// </summary>
        [JsonPropertyName("include")]
        public IList<string>? Include { get; set; }

        /// <summary>
        /// Sort clauses, for example <c>"createdAt DESC"</c>.
        /// </summary>
        [JsonPropertyName("order")]
        public IList<string>? Order { get; set; }

        /// <summary>
        /// Number of records to skip.
        /// </summary>
        [JsonPropertyName("skip")]
        public int? Skip { get; set; }

        /// <summary>
        /// Maximum number of records to return.
        /// </summary>
        [JsonPropertyName("limit")]
        public int? Limit { get; set; }

        private static readonly JsonSerializerOptions SerializerOptions = new()
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        };

        /// <summary>
        /// Adds a <c>where</c> condition.
        /// </summary>
        public DeliverGoFilter WithWhere(string field, object? value)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(field);
            Where ??= new Dictionary<string, object?>(StringComparer.Ordinal);
            Where[field] = value;
            return this;
        }

        /// <summary>
        /// Adds a field projection entry.
        /// </summary>
        public DeliverGoFilter WithField(string field, bool include = true)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(field);
            Fields ??= new Dictionary<string, bool>(StringComparer.Ordinal);
            Fields[field] = include;
            return this;
        }

        /// <summary>
        /// Adds a related model to eager load.
        /// </summary>
        public DeliverGoFilter WithInclude(string relation)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(relation);
            Include ??= [];
            Include.Add(relation);
            return this;
        }

        /// <summary>
        /// Adds an order clause, for example <c>"createdAt DESC"</c>.
        /// </summary>
        public DeliverGoFilter WithOrder(string order)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(order);
            Order ??= [];
            Order.Add(order);
            return this;
        }

        /// <summary>
        /// Sets the maximum number of records returned.
        /// </summary>
        public DeliverGoFilter WithLimit(int limit)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(limit);
            Limit = limit;
            return this;
        }

        /// <summary>
        /// Sets the number of records to skip.
        /// </summary>
        public DeliverGoFilter WithSkip(int skip)
        {
            ArgumentOutOfRangeException.ThrowIfNegative(skip);
            Skip = skip;
            return this;
        }

        /// <summary>
        /// Indicates whether the filter carries any clause.
        /// </summary>
        public bool IsEmpty =>
            (Where is null || Where.Count == 0)
            && (Fields is null || Fields.Count == 0)
            && (Include is null || Include.Count == 0)
            && (Order is null || Order.Count == 0)
            && Skip is null
            && Limit is null;

        /// <summary>
        /// Serializes the filter to the JSON representation expected by the API.
        /// </summary>
        public string ToJson() => JsonSerializer.Serialize(this, SerializerOptions);

        /// <summary>
        /// Creates a shallow copy of this filter.
        /// </summary>
        public DeliverGoFilter Clone() => new()
        {
            Where = Where is null ? null : new Dictionary<string, object?>(Where, StringComparer.Ordinal),
            Fields = Fields is null ? null : new Dictionary<string, bool>(Fields, StringComparer.Ordinal),
            Include = Include is null ? null : [.. Include],
            Order = Order is null ? null : [.. Order],
            Skip = Skip,
            Limit = Limit,
        };
    }
}
