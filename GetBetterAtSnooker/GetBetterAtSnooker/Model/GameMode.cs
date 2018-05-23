using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GetBetterAtSnooker.Model {
    public class GameMode {

        public string GameName { get; set; }
        public string GameLevel { get; set; }

        HttpClient client = new HttpClient();

        public async Task SetGameMode(string gamemode) {

            try {
                string URL = "https://getbetteratsnookerapi.azurewebsites.net/gamemode/setgamemode";
                var obj = new GameMode { GameName = gamemode };
                var json = JsonConvert.SerializeObject(obj);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage res = await client.PostAsync(URL, content);

                if(res.IsSuccessStatusCode) {
                    Debug.WriteLine("Success");
                }
            } catch(Exception e) {
                Debug.WriteLine("Something went wrong " +  e.StackTrace);
            }
        }

        public async Task SetGameLevel(string gamelevel) {
            try {
                string URL = "https://getbetteratsnookerapi.azurewebsites.net/gamemode/setgamelevel";
                var obj = new GameMode { GameLevel = gamelevel };
                var json = JsonConvert.SerializeObject(obj);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage res = await client.PostAsync(URL, content);

                if(res.IsSuccessStatusCode) {
                    Debug.WriteLine("success");
                }

            } catch(Exception e) {
                Debug.WriteLine("Something went wrong " + e.StackTrace);
            }
        }

        public async Task GetGameMode() {

            try {
                var response = await client.GetAsync("https://getbetteratsnookerapi.azurewebsites.net/gamemode/getgamemode");
                if(response.IsSuccessStatusCode) {
                    var content = await response.Content.ReadAsStringAsync();
                    GameName = content;
                }
            } catch(Exception e) {
                Debug.WriteLine("Something went wrong " + e.StackTrace);
            }
        }

       
    }
}
