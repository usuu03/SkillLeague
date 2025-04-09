using System;
using API.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SkillLeague.Application.Challenges.Commands;
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
    // Method to get a specific challenge by ID
    // GET api/challenges/{id}
    public async Task<ActionResult<Challenge>> GetChallenge(string id)
    {
        return await Mediator.Send(new GetChallengeDetail.Query { Id = id });
    }

    [HttpPost]
    // Method to create a new challenge
    // POST api/challenges
    public async Task<ActionResult<string>> CreateChallenge(Challenge challenge)
    {
        return await Mediator.Send(new CreateChallenge.Command { Challenge = challenge });
    }

    [HttpPut("{id}")]
    // Method to update an existing challenge
    // PUT api/challenges/{id}
    public async Task<ActionResult<string>> UpdateChallenge(Challenge challenge)
    {
        await Mediator.Send(new EditChallenge.Command { Challenge = challenge });
        return NoContent();
    }

    [HttpDelete("{id}")]
    // Method to delete a challenge
    // DELETE api/challenges/{id}
    public async Task<ActionResult> DeleteChallenge(string id)
    {
        await Mediator.Send(new DeleteChallenge.Command { Id = id });
        return Ok();
    }

}
