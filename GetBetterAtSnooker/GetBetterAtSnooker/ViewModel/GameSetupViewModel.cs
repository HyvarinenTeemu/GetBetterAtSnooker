using GetBetterAtSnooker.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GetBetterAtSnooker.ViewModel
{
    public class GameSetupViewModel : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        private INavigation _navigation;       

        private string selectedGameMode;
        private string selectedGameLevel;

        public GameSetupViewModel(INavigation navigation) {
            Task.Run(async () => {
                GameMode gamemode = new GameMode();
                await gamemode.GetGameMode();
                SelectedGameMode = gamemode.GameName;
                selectedGameLevel = gamemode.GameLevel;
            });
            _navigation = navigation;
        }

        public string SelectedGameMode {
            get {
                return selectedGameMode;
            } 

            set {
                if(selectedGameMode != value) {
                    selectedGameMode = value;
                    OnPropertyChanged("SelectedGameMode");
                }
            }
        }

        public string SelectedGameLevel {
            get {
                return selectedGameLevel;
            }

            set {
                if(selectedGameLevel != value) {
                    selectedGameLevel = value;
                    OnPropertyChanged("SelectedGameLevel");
                }
            }
        }

        public void OnPropertyChanged(string name) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
