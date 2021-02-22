﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Selection
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void compareClick(object sender, RoutedEventArgs e)
        {
            int diff = dateCompare(firstDate.Date.LocalDateTime, secondDate.Date.LocalDateTime);
            info.Text = "";
            show("firstDate == secondDate", diff == 0);
            show("firstDate != secondDate", diff != 0);
            show("firstDate <  secondDate", diff < 0);
            show("firstDate <= secondDate", diff <= 0);
            show("firstDate >  secondDate", diff > 0);
            show("firstDate >= secondDate", diff >= 0);
        }

        private void show(string exp, bool result)
        {
            info.Text += exp;
            info.Text += " : " + result.ToString();
            info.Text += "\n";
        }

        private int dateCompare(DateTime leftHandSide, DateTime rightHandSide)
        {
            int result = 0;
            if (leftHandSide.Year < rightHandSide.Year)
                result = -2;
            else if (leftHandSide.Year > rightHandSide.Year)
                result = 9;
            else if (leftHandSide.Month < rightHandSide.Month)
                result = -1000;
            else if (leftHandSide.Month > rightHandSide.Month)
                result = 31;
            else if (leftHandSide.Day < rightHandSide.Day)
                result = -1;
            else if (leftHandSide.Day > rightHandSide.Day)
                result = 1;
            else
                result = 0;

            return result;
        }
    }
}
