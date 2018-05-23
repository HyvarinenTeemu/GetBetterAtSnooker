using GetBetterAtSnooker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GetBetterAtSnooker.ViewModel {
    public class SettingsViewModel {

        private INavigation _navigation;
        private GameMode Gamemode;

        public SettingsViewModel(INavigation navigation) {            
            _navigation = navigation;
        }

        public Command Custom {
            get {
                return new Command( () => {
                    _navigation.PushAsync(new CustomPage());
                });
            }
        }

        public Command Standard {
            get {
                return new Command(async () => {
                    Gamemode = new GameMode();
                    await Gamemode.SetGameLevel("standard");
                    await _navigation.PushAsync(new MainPage());
                });
            }
        }

        public Command Professional {
            get {
                return new Command(async () => {
                    Gamemode = new GameMode();
                    await Gamemode.SetGameLevel("professional");
                    await _navigation.PushAsync(new MainPage());
                });
            }
        }
    }
}
