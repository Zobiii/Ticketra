namespace Ticketra.Domain.Common;

/// <summary>
/// Represents the base type for all domain entities with a unique identifier.
/// </summary>
public abstract class EntityBase
{
    /// <summary>
    /// Gets or sets the unique identifier of the entity.
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();
}