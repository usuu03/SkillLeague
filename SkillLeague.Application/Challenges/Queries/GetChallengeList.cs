using System;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SkillLeague.Domain;
using SkillLeague.Persistence;

namespace SkillLeague.Application.Queries;

public class GetChallengeList
{
    public class Query : IRequest<List<Challenge>> {}

    public class Handler(AppDbContext context) : IRequestHandler<Query, List<Challenge>>
    {
        public async Task<List<Challenge>> Handle(Query request, CancellationToken cancellationToken)
        {
            return await context.Challenges.ToListAsync(cancellationToken);
        }
    }

}
