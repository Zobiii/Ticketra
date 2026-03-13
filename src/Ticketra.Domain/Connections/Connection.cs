using Ticketra.Domain.Common;

namespace Ticketra.Domain.Connections;

/// <summary>
/// Represents a concrete train connection customers can book.
/// </summary>
public sealed class Connection : EntityBase
{
    /// <summary>
    /// Gets or sets the related rail line identifier.
    /// </summary>
    public Guid RailLineId { get; set; }

    /// <summary>
    /// Gets or sets the departure station identifier.
    /// </summary>
    public Guid DepartureStationId { get; set; }

    /// <summary>
    /// Gets or sets the arrival station identifier.
    /// </summary>
    public Guid ArrivalStationId { get; set; }

    /// <summary>
    /// Gets or sets the train number shown to customers.
    /// </summary>
    public string TrainNumber { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the departure timestamp in UTC.
    /// </summary>
    public DateTime DepartureTimeUtc { get; set; }

    /// <summary>
    /// Gets or sets the arrival timestamp in UTC.
    /// </summary>
    public DateTime ArrivalTimeUtc { get; set; }

    /// <summary>
    /// Gets or sets the base ticket price in EUR.
    /// </summary>
    public decimal BasePriceEur { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this connection can currently be booked.
    /// </summary>
    public bool IsActive { get; set; } = true;
}