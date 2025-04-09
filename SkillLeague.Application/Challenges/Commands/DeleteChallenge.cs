using System;
using MediatR;
using SkillLeague.Persistence;

namespace SkillLeague.Application.Challenges.Commands;

public class DeleteChallenge
{
    public class Command : IRequest
    {
        public required string Id { get; set; }
    }


    public class Handler(AppDbContext context) : IRequestHandler<Command>
    {
        public async Task Handle(Command request, CancellationToken cancellationToken)
        {
            var challenge = await context.Challenges.FindAsync([request.Id], cancellationToken) ??
                throw new Exception("Challenge not found");

            context.Remove(challenge);

            await context.SaveChangesAsync(cancellationToken);
        }
    }

}
