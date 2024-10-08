namespace Application.Commands.Domain;

/// <summary>
///     Represents a command to retrieve domain entities within a specified date range.
/// </summary>
/// <remarks>
///     Initializes a new instance of the <see cref="GetDomainEntityByDateRangeCommand" /> class.
/// </remarks>
/// <param name="startDate">The start date of the date range.</param>
/// <param name="endDate">The end date of the date range. Can be null if only the start date is considered.</param>
[method: JsonConstructor]
public sealed class GetDomainEntityByDateRangeCommand(DateTime startDate, DateTime? endDate) : ICommand<IEnumerable<DomainEntity>>
{

    /// <summary>
    ///     Gets or sets the start date of the date range.
    /// </summary>
    [JsonPropertyName("startDate")]
    public DateTime StartDate { get; init; } = startDate;

    /// <summary>
    ///     Gets or sets the end date of the date range. Can be null if only the start date is considered.
    /// </summary>
    [JsonPropertyName("endDate")]
    public DateTime? EndDate { get; init; } = endDate;
}