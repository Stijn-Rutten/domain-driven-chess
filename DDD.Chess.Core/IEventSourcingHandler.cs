namespace DDD.Chess.Core;

public interface IEventSourcingHandler<TId, TAggregate, TDomainEvent>
    where TId: IAggregateIdentifier
    where TAggregate : EventSourcedAggregate<TId> 
    where TDomainEvent : DomainEvent<TId> 
{
    TAggregate Apply(TAggregate aggreagate, TDomainEvent domainEvent);
}