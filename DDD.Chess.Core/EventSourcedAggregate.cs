namespace DDD.Chess.Core;

public abstract class EventSourcedAggregate<TId> : Entity<TId> where TId : IAggregateIdentifier
{
    protected EventSourcedAggregate(TId id) : base(id)
    {
    }

    public EventSourcedAggregate<TId> Build(IEnumerable<DomainEvent<TId>> events)
    {
        return EventSourcingFactory.Build(events, this);
    }

    protected internal abstract IDictionary<Type, Func<EventSourcedAggregate<TId>, DomainEvent<TId>, EventSourcedAggregate<TId>>> GetHandlers();

    protected internal abstract EventSourcedAggregate<TId> Initialize();
}
