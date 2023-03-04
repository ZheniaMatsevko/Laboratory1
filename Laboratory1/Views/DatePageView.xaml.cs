﻿using Laboratory1.ViewModels;
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

namespace Laboratory1.Views
{
    /// <summary>
    /// Interaction logic for DatePageView.xaml
    /// </summary>
    public partial class DatePageView : UserControl
    {
        public DatePageView()
        {
            InitializeComponent();
            DataContext = new DatePageViewModel();
        }
    }
}
