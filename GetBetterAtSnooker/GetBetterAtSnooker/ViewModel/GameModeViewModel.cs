using GetBetterAtSnooker.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GetBetterAtSnooker.ViewModel {
    public class GameModeViewModel : INotifyPropertyChanged {

        public event PropertyChangedEventHandler PropertyChanged;

        private string gameMode;
        private GameMode gamemode;
        private INavigation _navigation;

        public GameModeViewModel(INavigation navigation) {
            _navigation = navigation;
        }

        public string GameMode {
            get {
                return gameMode;
            }
            set {
                if(gameMode != value) {
                    gameMode = value;
                    OnPropertyChanged("GameMode");
                }
            }
        }

        public Command Snooker {
            get {
                return new Command(async () => {

                    gamemode = new GameMode();
                    await gamemode.SetGameMode("snooker");
                    await _navigation.PushAsync(new MainPage());
                });
            }
        }

        public Command Six_red {
            get {
                return new Command(async () => {
                    gamemode = new GameMode();
                    await gamemode.SetGameMode("sixred");
                    await _navigation.PushAsync(new MainPage());
                });
            }
        }
        public Command Team_Snooker {
            get {
                return new Command(async () => {
                    gamemode = new GameMode();
                    await gamemode.SetGameMode("teamsnooker");
                    await _navigation.PushAsync(new MainPage());
                });
            }
        }
        public Command Pair_snooker {
            get {
                return new Command(async () => {
                    gamemode = new GameMode();
                    await gamemode.SetGameMode("pairsnooker");
                    await _navigation.PushAsync(new MainPage());
                });
            }
        }

        public void OnPropertyChanged(string name) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
