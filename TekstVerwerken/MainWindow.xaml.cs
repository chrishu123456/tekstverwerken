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

namespace TekstVerwerken
{
    /// <summary>
    /// Interaction logic for TekstVerwerken.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBlockAanmelding.TextWrapping = TextWrapping.Wrap;
            textBlockAanmelding.Text = "Je probeerde aan te melden met userid: " + invuluserid.Text + " en paswoord: " + invulpassword.Password;
        }
    }
}
