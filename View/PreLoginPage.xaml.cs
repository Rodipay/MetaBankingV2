using MetaBanking.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaBanking.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PreLoginPage : ContentPage
    {
        public PreLoginPage()
        {
            InitializeComponent();
            this.BindingContext = new PreLoginViewModel();
        }
    }
}