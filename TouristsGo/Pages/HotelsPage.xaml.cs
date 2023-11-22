﻿using System;
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
    /// Логика взаимодействия для HotelsPage.xaml
    /// </summary>
    public partial class HotelsPage : Page
    {
        public static List<Hotel> hotels {  get; set; }
        public static List<City> cities { get; set; }
        public HotelsPage()
        {
            InitializeComponent();
            hotels = new List<Hotel>(DBConnection.TouristsGo.Hotel.ToList());
            cities = new List<City>(DBConnection.TouristsGo.City.ToList());

            this.DataContext = this;
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void delBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
