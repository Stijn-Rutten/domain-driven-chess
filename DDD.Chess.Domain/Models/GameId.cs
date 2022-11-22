using DDD.Chess.Core;

namespace DDD.Chess.Domain.Models;

internal record GameId(Guid Id) : IAggregateIdentifier;