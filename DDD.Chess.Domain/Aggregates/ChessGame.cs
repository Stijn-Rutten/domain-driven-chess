using DDD.Chess.Core;
using DDD.Chess.Domain.Events;
using DDD.Chess.Domain.Models;
using System.Security.Cryptography;

namespace DDD.Chess.Domain.Aggregates;

internal class ChessGame : EventSourcedAggregate<GameId>
{
    public ChessGame(GameId id) : base(id)
    {
    }

    private static Func<EventSourcedAggregate<GameId>, DomainEvent<GameId>, EventSourcedAggregate<GameId>> GameStarted()
    {
        return (aggregate, domainEvent) =>
        {
            // Handle Game state
            return aggregate;
        };
    }

    protected override IDictionary<Type, Func<EventSourcedAggregate<GameId>, DomainEvent<GameId>, EventSourcedAggregate<GameId>>> GetHandlers()
    {
        return new Dictionary<Type, Func<EventSourcedAggregate<GameId>, DomainEvent<GameId>, EventSourcedAggregate<GameId>>>()
        {
            { typeof(GameStarted), GameStarted() }
        };
    }

    protected override EventSourcedAggregate<GameId> Initialize()
    {
        return new ChessGame(Id);
    }
}
