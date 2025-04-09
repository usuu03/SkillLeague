using System;
using MediatR;
using SkillLeague.Domain;
using SkillLeague.Persistence;

namespace SkillLeague.Application.Challenges.Commands;

public class CreateChallenge
{
    public class Command : IRequest<String>
    {
        public required Challenge Challenge { get; set; }
    }

    public class Handler(AppDbContext context) : IRequestHandler<Command, String>
    {
        public async Task<String> Handle(Command request, CancellationToken cancellationToken)
        {
            //Add the challenge to the database
            context.Challenges.Add(request.Challenge);

            //Save the changes to the database
            await context.SaveChangesAsync(cancellationToken);

            //Return the id of the created challenge
            return request.Challenge.Id;
        }
    }

}
