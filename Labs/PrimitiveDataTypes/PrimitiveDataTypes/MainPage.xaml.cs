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

namespace PrimitiveDataTypes
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

        private void typeSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem selectedType = (type.SelectedItem as ListBoxItem);
            switch (selectedType.Content.ToString())
            {
                case "int":
                    showIntValue();
                    break;
                case "long":
                    showLongValue();
                    break;
                case "float":
                    showFloatValue();
                    break;
                case "double":
                    showDoubleValue();
                    break;
                case "decimal":
                    showDecimalValue();
                    break;
                case "string":
                    showStringValue();
                    break;
                case "char":
                    showCharValue();
                    break;
                case "bool":
                    showBoolValue();
                    break;
            }
        }

        private void showIntValue()
        {
            int intvar = 42;
            value.Text = intvar.ToString();
        }

        private void showLongValue()
        {
            long longVar = 42L;
            value.Text = longVar.ToString();
        }

        private void showFloatValue()
        {
            float floatVar = 0.42F;
            value.Text = floatVar.ToString();
        }

        private void showDoubleValue()
        {
            double doublevar = 0.42;
            value.Text = doublevar.ToString();
        }

        private void showDecimalValue()
        {
            decimal decimalVar = 0.42M;
            value.Text = decimalVar.ToString();
        }

        private void showStringValue()
        {
            string stringVar = "forty two";
            value.Text = stringVar; // ToString not needed
        }

        private void showCharValue()
        {
            char charVar = 'x';
            value.Text = charVar.ToString();
        }

        private void showBoolValue()
        {
            bool boolvar = true;
            value.Text = boolvar.ToString();
        }
    }
}
