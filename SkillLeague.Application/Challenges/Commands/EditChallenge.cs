using System;
using AutoMapper;
using MediatR;
using SkillLeague.Domain;
using SkillLeague.Persistence;

namespace SkillLeague.Application.Challenges.Commands;

public class EditChallenge
{
    public class Command : IRequest
    {
        public required Challenge Challenge { get; set; }
    }

    public class Handler(AppDbContext context, IMapper mapper): IRequestHandler<Command>
    {
        public async Task Handle(Command request, CancellationToken cancellationToken)
        {
            var challenge = await context.Challenges.FindAsync([request.Challenge.Id], cancellationToken) 
                ?? throw new Exception("Challenge not found");

            // Update the challenge properties
            mapper.Map(request.Challenge, challenge);

            // Save the changes to the database
            await context.SaveChangesAsync(cancellationToken);
        }
    }

}
