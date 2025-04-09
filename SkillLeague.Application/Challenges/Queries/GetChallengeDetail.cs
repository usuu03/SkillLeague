using System;
using MediatR;
using SkillLeague.Domain;
using SkillLeague.Persistence;

namespace SkillLeague.Application.Queries;

public class GetChallengeDetail
{
    public class Query : IRequest<Challenge>
    {
        public required string Id { get; set; }
    }

    public class Handler(AppDbContext context) : IRequestHandler<Query, Challenge>
    {
        public async Task<Challenge> Handle(Query request, CancellationToken cancellationToken)
        {
            var challenge = await context.Challenges.FindAsync([request.Id], cancellationToken);
            if(challenge == null)
            {
                throw new Exception("Challenge not found");
            }

            return challenge;
        }
    }

}
