using SkillLeague.Domain;

namespace SkillLeague.Persistence;

public class DbInitializer
{
    public static async Task SeedData(AppDbContext context)
    {
        if (context.Challenges.Any()) return;

        var challenges = new List<Challenge>
        {
            new()
            {
                Title = "Code 30 Minutes a Day",
                Description = "Join this 30-day challenge to code for at least 30 minutes daily.",
                Category = "coding",
                StartDate = DateTime.UtcNow.AddDays(1),
                EndDate = DateTime.UtcNow.AddDays(31),
                ImageUrl = "https://cdn.skillleague.io/images/challenges/code-daily.jpg"
            },
            new()
            {
                Title = "100 Pushups a Day",
                Description = "Build discipline and upper body strength with 100 pushups every day for a month.",
                Category = "fitness",
                StartDate = DateTime.UtcNow.AddDays(2),
                EndDate = DateTime.UtcNow.AddDays(32),
                ImageUrl = "https://cdn.skillleague.io/images/challenges/pushups.jpg"
            },
            new()
            {
                Title = "Read 5 Pages Daily",
                Description = "Take time for personal growth by reading 5+ pages of a book every day.",
                Category = "habits",
                StartDate = DateTime.UtcNow.AddDays(3),
                EndDate = DateTime.UtcNow.AddDays(33),
                ImageUrl = "https://cdn.skillleague.io/images/challenges/read-daily.jpg"
            },
            new()
            {
                Title = "Design Something Every Week",
                Description = "A 6-week challenge to create one design every week — landing pages, UI kits, or logos.",
                Category = "design",
                StartDate = DateTime.UtcNow.AddDays(1),
                EndDate = DateTime.UtcNow.AddDays(42),
                ImageUrl = "https://cdn.skillleague.io/images/challenges/design-weekly.jpg"
            },
            new()
            {
                Title = "Post Your Gym Progress",
                Description = "Log your gym sessions for 21 days straight — with a quick summary or pic every day.",
                Category = "fitness",
                StartDate = DateTime.UtcNow.AddDays(2),
                EndDate = DateTime.UtcNow.AddDays(23),
                ImageUrl = "https://cdn.skillleague.io/images/challenges/gym-progress.jpg"
            },
            new()
            {
                Title = "Build Your First SaaS MVP",
                Description = "Sprint for 4 weeks to build and ship a minimum viable SaaS project. Share daily updates.",
                Category = "startup",
                StartDate = DateTime.UtcNow.AddDays(5),
                EndDate = DateTime.UtcNow.AddDays(35),
                ImageUrl = "https://cdn.skillleague.io/images/challenges/saas-mvp.jpg"
            },
            new()
            {
                Title = "Create a 5-Minute Beat Daily",
                Description = "Music producers, unite! Drop one 5-minute beat every day for 10 days.",
                Category = "music",
                StartDate = DateTime.UtcNow.AddDays(1),
                EndDate = DateTime.UtcNow.AddDays(11),
                ImageUrl = "https://cdn.skillleague.io/images/challenges/daily-beats.jpg"
            },
            new()
            {
                Title = "Tech Twitter Grind",
                Description = "Tweet something valuable about tech every day for 14 days. Build in public.",
                Category = "content",
                StartDate = DateTime.UtcNow.AddDays(3),
                EndDate = DateTime.UtcNow.AddDays(17),
                ImageUrl = "https://cdn.skillleague.io/images/challenges/tech-twitter.jpg"
            }
        };

        context.Challenges.AddRange(challenges);
        await context.SaveChangesAsync();
    }
}
