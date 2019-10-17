
using Xamarin.Forms;
using System.Collections.ObjectModel;
using Xamarin.Forms.Xaml;

namespace PageListViewHoa
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        ObservableCollection<hoa> Hoas = new ObservableCollection<hoa>();
        public MainPage()
        {
            InitializeComponent();
            Hoas.Add(new hoa { TenHoa = "Đón xuân", Gia = 50000, Hinh = "cuc1.jpg", Mota = "Hoa cúc các màu: trắng, vàng, cam" });
            Hoas.Add(new hoa { TenHoa = "Hồn nhiên", Gia = 60000, Hinh = "honnhien1.jpg", Mota = "Hoa cúc vàng, cam. lá măng" });
            Hoas.Add(new hoa { TenHoa = "Tím thủy chung", Gia = 45000, Hinh = "cuctim.jpg", Mota = "Hoa cúc tím" });
            lsvHoa.ItemsSource = Hoas;
        }
    }
}
