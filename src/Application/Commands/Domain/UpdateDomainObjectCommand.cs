/// <summary>
/// Initializes a new instance of the <see cref="UpdateDomainObjectCommand"/> class.
/// </summary>
/// <param name="capabilityIdentifier">The capability identifier.</param>
/// <param name="label">The label.</param>
/// <param name="value">The value.</param>
/// <param name="entityId">The entity identifier.</param>
namespace Application.Commands.Domain;

[method: JsonConstructor]
public sealed class UpdateDomainObjectCommand(string capabilityIdentifier, string label, string value, Guid entityId) : ICommand<DomainObject>
{
    /// <summary>
    /// Gets or sets the capability identifier.
    /// </summary>
    [JsonPropertyName("capabilityIdentifier")]
    public string CapabilityIdentifier { get; init; } = capabilityIdentifier;

    /// <summary>
    /// Gets or sets the entity ID.
    /// </summary>
    [JsonPropertyName("entityId")]
    public Guid EntityId { get; init; } = entityId;

    /// <summary>
    /// Gets or sets the label.
    /// </summary>
    [JsonPropertyName("label")]
    public string Label { get; init; } = label;

    /// <summary>
    /// Gets or sets the value.
    /// </summary>
    [JsonPropertyName("value")]
    public string Value { get; init; } = value;
}