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
    /// Логика взаимодействия для CouintriesPage.xaml
    /// </summary>
    public partial class CouintriesPage : Page
    {
        public static List<Country> countries {  get; set; }
        public CouintriesPage()
        {
            InitializeComponent();
            countries = new List<Country>(DBConnection.TouristsGo.Country.ToList());
            this.DataContext = this;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void delBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
