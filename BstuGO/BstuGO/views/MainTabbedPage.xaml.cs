using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BstuGO.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage ()
        {
            InitializeComponent();
            
            
            NavigationPage mapsPage = new NavigationPage(new Maps());
            NavigationPage schedulesPage = new NavigationPage(new Schedule());
            NavigationPage newsPage = new NavigationPage(new NewsPage());
            NavigationPage profilesPage = new NavigationPage(new ProfilePage());
            ToolbarItem item = new ToolbarItem
            {
                Text = "BSTU",
                IconImageSource = ImageSource.FromFile("logobstu.png"),
                
                Order = ToolbarItemOrder.Primary,
                Priority = 0
            };

            // "this" refers to a Page object
            

            mapsPage.Title = "Карты";
            schedulesPage.Title = "Расписание";
            newsPage.Title = "Новости";
            profilesPage.Title = "Личный кабинет";

            Children.Add(schedulesPage);
            Children.Add(newsPage);
            Children.Add(mapsPage);
            Children.Add(profilesPage);
            this.ToolbarItems.Add(item);


        }
    }
}