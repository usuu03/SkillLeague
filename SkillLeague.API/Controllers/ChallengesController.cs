using System;
using API.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SkillLeague.Domain;
using SkillLeague.Persistence;

namespace SkillLeague.API.Controllers;

public class ChallengesController(AppDbContext context) : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<List<Challenge>>> GetChallenges()
    {
       return await context.Challenges.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Challenge>> GetChallenge(string id)
    {
        var challenge = await context.Challenges.FindAsync(id);

        if (challenge == null)
        {
            return NotFound();
        }

        return challenge;

    }

}
