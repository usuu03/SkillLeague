using System;
using API.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SkillLeague.Application.Queries;
using SkillLeague.Domain;
using SkillLeague.Persistence;

namespace SkillLeague.API.Controllers;

public class ChallengesController: BaseApiController
{
    [HttpGet]
    // Method to get a list of challenges
    // GET api/challenges
    public async Task<ActionResult<List<Challenge>>> GetChallenges()
    {
       return await Mediator.Send(new GetChallengeList.Query());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Challenge>> GetChallenge(string id)
    {
        return await Mediator.Send(new GetChallengeDetail.Query { Id = id });

    }

}
