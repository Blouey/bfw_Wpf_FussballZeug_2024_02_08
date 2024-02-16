using System.Text.Json.Serialization;

namespace Wpf_FussballZeug_2024_02_08;

public class Team
{
    public int? TeamId { get;  set; }
    public string? TeamName { get; set; }
    public string? ShortName { get; set; }
    public string? TeamIconUrl { get; set; }
    public string? TeamGroupName { get; set; }

    public Team()
    {
    }

    

    
    [JsonConstructor]
    public Team(int? teamId, string? teamName, string? shortName, string? teamIconUrl, string? teamGroupName) =>
           (TeamId, TeamName, ShortName, TeamIconUrl, TeamGroupName) = (teamId, teamName, shortName, teamIconUrl, teamGroupName);
}