using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GetBetterAtSnooker {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
        }

        private void Play(object sender, EventArgs e) {
            Navigation.PushAsync(new GameSetupPage());
        }

        private void Game_Mode(object sender, EventArgs e) {
            Navigation.PushAsync(new GameModePage());
        }

        private void Game_History(object sender, EventArgs e) {
            Navigation.PushAsync(new GameHistoryPage());
        }

        private void My_Account(object sender, EventArgs e) {
            Navigation.PushAsync(new MyAccountPage());
        }

        private void Settings(object sender, EventArgs e) {
            Navigation.PushAsync(new SettingsPage());
        }

        private void Friends(object sender, EventArgs e) {
            Navigation.PushAsync(new FriendsPage());
        }

        private void Instructions(object sender, EventArgs e) {
            Navigation.PushAsync(new InstructionsPage());
        }
    }
}
