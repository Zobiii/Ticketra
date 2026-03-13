using Ticketra.Domain.Common;

namespace Ticketra.Domain.Routes;

/// <summary>
/// Represents a named rail line between two endpoint stations.
/// </summary>
public sealed class RailLine : EntityBase
{
    /// <summary>
    /// Gets or sets the business line code.
    /// </summary>
    public string Code { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the display name of the line.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the origin station identifier.
    /// </summary>
    public Guid OriginStationId { get; set; }

    /// <summary>
    /// Gets or sets the destination station identifier.
    /// </summary>
    public Guid DestinationStationId { get; set; }
}