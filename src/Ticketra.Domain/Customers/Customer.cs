using Ticketra.Domain.Common;

namespace Ticketra.Domain.Customers;

/// <summary>
/// Represents a customer who books train tickets.
/// </summary>
public sealed class Customer : EntityBase
{
    /// <summary>
    /// Gets or sets the customer's first name.
    /// </summary>
    public string FirstName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the customer's last name.
    /// </summary>
    public string LastName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the customer's email address.
    /// </summary>
    public string EmailAddress { get; set; } = string.Empty;
}