using Ticketra.Domain.Common;

namespace Ticketra.Domain.Stations;

/// <summary>
/// Represents a railway station.
/// </summary>
public sealed class Station : EntityBase
{
    /// <summary>
    /// Gets or sets the short station code used in timetables.
    /// </summary>
    public string Code { get; set; } = string.Empty;
    
    /// <summary>
    /// Gets or sets the station display name.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the ISO country code of the station.
    /// </summary>
    public string CountryCode { get; set; } = "AT";
}