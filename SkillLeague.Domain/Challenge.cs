using System;

namespace SkillLeague.Domain;

public class Challenge
{
    public string Id { get; set;} = Guid.NewGuid().ToString();
    public required string Title { get; set;}
    public required string Description {get; set;}
    public required string Category { get; set;}
    public string? ImageUrl { get; set;}

    public DateTime StartDate { get; set;}
    public DateTime EndDate { get; set;}


    // public required string CreatorId { get; set; }
    // public User? Creator { get; set; }

    // public ICollection<UserChallenge> Participants { get; set; }
    // public ICollection<Comment> Comments { get; set; }
    // public ICollection<ChatMessage> ChatMessages { get; set; }


}
