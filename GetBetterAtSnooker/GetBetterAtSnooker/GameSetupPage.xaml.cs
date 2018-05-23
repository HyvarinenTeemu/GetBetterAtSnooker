using GetBetterAtSnooker.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GetBetterAtSnooker {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GameSetupPage : ContentPage {
        public GameSetupPage()
        {
            InitializeComponent();
            BindingContext = new GameSetupViewModel(this.Navigation);
        }
    }
}