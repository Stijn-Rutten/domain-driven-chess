namespace DDD.Chess.Core;

public abstract class Entity<TId> where TId : IAggregateIdentifier
{
    public TId Id { get; }
    public Entity(TId id)
    {
        Id = id;
    }
}
