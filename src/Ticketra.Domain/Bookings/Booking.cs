using Ticketra.Domain.Common;

namespace Ticketra.Domain.Bookings;

/// <summary>
/// Represents a customer booking for one connection.
/// </summary>
public sealed class Booking : EntityBase
{
    /// <summary>
    /// Gets or sets the public booking reference.
    /// </summary>
    public string BookingReference { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the selected connection identifier.
    /// </summary>
    public Guid ConnectionId { get; set; }

    /// <summary>
    /// Gets or sets the customer identifier.
    /// </summary>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// Gets or sets the booking creation timestamp in UTC.
    /// </summary>
    public DateTime BookedAtUtc { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Gets or sets a value indicating whether reservation surcharge is selected.
    /// </summary>
    public bool HasReservation { get; set; }

    /// <summary>
    /// Gets or sets the total booking amount in EUR.
    /// </summary>
    public decimal TotalPriceEur { get; set; }

    /// <summary>
    /// Gets or sets the current booking status.
    /// </summary>
    public BookingStatus Status { get; set; } = BookingStatus.PendingPayment;
}