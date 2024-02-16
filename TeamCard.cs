using System.Net.Mime;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Wpf_FussballZeug_2024_02_08;

public class TeamCard
{
    string? Logosource { get; set; }
    string? TeamName { get; set; }
    
    public TeamCard(string logosource, string teamName)
    {
        Logosource = logosource;
        TeamName = teamName;
    }
    
    public TeamCard(Team team)
    {
        Logosource = team.TeamIconUrl;
        TeamName = team.TeamName;
    }
    
    public TeamControl Show()
    {
        TeamControl card = new TeamControl();
        card.logo.Source = new BitmapImage(new Uri(Logosource));
        card.lbl.Text = TeamName;
        return card;
    }
}