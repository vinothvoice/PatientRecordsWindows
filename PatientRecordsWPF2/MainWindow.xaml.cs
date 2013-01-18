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

namespace PatientRecordsWPF2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnViewPatientDetails_Click(object sender, RoutedEventArgs e)
        {
            var pv = new PatientVisits();
            pv.Owner = this;
            pv.ShowDialog();
        }
        private void btnAddNewPatient_Click(object sender, RoutedEventArgs e)
        {
            var pd = new PatientDetails();
            pd.Owner = this;
            pd.ShowDialog();
        }
    }
}
