namespace Ticketra.Domain.Bookings;

/// <summary>
/// Represents the lifecycle state of a booking.
/// </summary>
public enum BookingStatus
{
    /// <summary>
    /// Booking was created but payment is not completed yet.
    /// </summary>
    PendingPayment = 1,
    
    /// <summary>
    /// Booking is paid and confirmed.
    /// </summary>
    Confirmed = 2,
    
    /// <summary>
    /// Booking is cancelled.
    /// </summary>
    Cancelled = 3
}