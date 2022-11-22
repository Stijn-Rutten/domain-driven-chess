namespace DDD.Chess.Core;

public record DomainEvent<TId>(TId Id) where TId : IAggregateIdentifier;
