﻿using OnTheFlyWPFC.Model.DTO;
using OnTheFlyWPFC.ViewModel;
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

namespace OnTheFlyWPFC.View
{
    /// <summary>
    /// Interaction logic for BranchAddUC.xaml
    /// </summary>
    public partial class BranchAddUC : UserControl
    {
        CityViewModel _cityViewModel;
        public BranchAddUC()
        {
            InitializeComponent();
            _cityViewModel = new CityViewModel();

        }

        private void cmbBranchCities_Loaded(object sender, RoutedEventArgs e) {
            _cityViewModel.GetAllCities();
            //cmbBranchCities.DataContext = _cityViewModel;
            cmbBranchCities.ItemsSource = _cityViewModel.CityName;
            cmbBranchCities.DisplayMemberPath = "name";


            
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            var a = (CityDTO)cmbBranchCities.SelectedValue;
            MessageBox.Show("hi " + a.cityCode);
        }
    }
}
