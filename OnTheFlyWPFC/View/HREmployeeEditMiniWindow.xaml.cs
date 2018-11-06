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
using System.Windows.Shapes;

namespace OnTheFlyWPFC.View
{
    /// <summary>
    /// Interaction logic for HREmployeeEditMiniWindow.xaml
    /// </summary>
    public partial class HREmployeeEditMiniWindow : Window
    {
        public HREmployeeEditMiniWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e) {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void btnCloseForm_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }
    }
}
