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

    internal abstract IDictionary<Type, IEventSourcingHandler<TId, EventSourcedAggregate<TId>, DomainEvent<TId>>> GetHandlers();

    internal abstract EventSourcedAggregate<TId> Initialize();
}
