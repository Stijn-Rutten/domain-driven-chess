using DDD.Chess.Core;
using DDD.Chess.Domain.Models;

namespace DDD.Chess.Domain.Events
{
    internal record GameStarted : DomainEvent<GameId>
    {
        public GameStarted(GameId Id) : base(Id)
        {
        }
    }
}
