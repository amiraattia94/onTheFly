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

namespace OnTheFlyWPFC.View
{
    /// <summary>
    /// Interaction logic for POSAddReceiptUC.xaml
    /// </summary>
    public partial class POSAddReceiptUC : UserControl
    {
        public POSAddReceiptUC()
        {
            InitializeComponent();
        }

        private void ADDService_Click(object sender, RoutedEventArgs e) {
            var tempW = new POSAddServiceMiniWindow();
            tempW.ShowDialog();

        }
    }
}
