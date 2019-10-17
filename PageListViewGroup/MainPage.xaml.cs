using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PageListViewGroup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage

    {
        public MainPage()
        {
            InitializeComponent();
            LoaiHoa l = new LoaiHoa();
            lsthoa.ItemsSource = l.Loaihoas;
        }

    }
}
