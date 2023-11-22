using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TouristsGo.DB;

namespace TouristsGo.Pages
{
    /// <summary>
    /// Логика взаимодействия для EngineerHomePage.xaml
    /// </summary>
   
    public partial class EngineerHomePage : Page
    {
        public static List<Employee> employees {  get; set; }
        public static List<Post> posts { get; set; }
        public EngineerHomePage()
        {
            InitializeComponent();
            employees = new List<Employee>(DBConnection.TouristsGo.Employee.ToList());

            this.DataContext = this;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationPage());
        }
    }
}
