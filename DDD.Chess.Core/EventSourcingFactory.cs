namespace DDD.Chess.Core;

internal class EventSourcingFactory
{
    internal static EventSourcedAggregate<TId> Build<TId>(IEnumerable<DomainEvent<TId>> events, EventSourcedAggregate<TId> sourceAggregate) where TId : IAggregateIdentifier
    {
        var copyAggregate = sourceAggregate.Initialize();
        var handlers = copyAggregate.GetHandlers();

        foreach (var domainEvent in events) {
            if (handlers.TryGetValue(domainEvent.GetType(), out var apply))
            {
                copyAggregate = apply(copyAggregate, domainEvent);
            } else
            {
                // TODO: Handle not finding the correct Handler
            }
        }

        return copyAggregate;
    }
}
