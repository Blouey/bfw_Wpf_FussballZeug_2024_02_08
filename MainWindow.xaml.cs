using System.Net.Http;
using System.Text.Json;
using System.Windows;

namespace Wpf_FussballZeug_2024_02_08;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }


    private void BtnApiCall_OnClick(object sender, RoutedEventArgs e)
    {
        if(Panel.Children.Count != 0)
            Panel.Children.Clear();
            
        string league = txtLeague.Text;
        string season = txtSeason.Text;
        string url = $"https://api.openligadb.de/getavailableteams/{league}/{season}";
        
        HttpClient client = new HttpClient();
        HttpResponseMessage response =  client.GetAsync(url).Result;
        
        if (response.IsSuccessStatusCode)
        {
            string json = response.Content.ReadAsStringAsync().Result;
            List<Team> teams = new List<Team>(); 
            teams = JsonSerializer.Deserialize<List<Team>>(json, new JsonSerializerOptions(JsonSerializerDefaults.Web));
            foreach (var team in teams)
            {
                TeamCard card = new TeamCard(team);
                TeamControl control = card.Show();
                Panel.Children.Add(card.Show());
            }
        }
    }
}