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
using Windows.UI;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Drawing
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DrawingPad : Page
    {
        public DrawingPad()
        {
            this.InitializeComponent();
        }

        private void drawingCanvas_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Point mouseLocation = e.GetPosition(this.drawingCanvas);
            Square mySquare = new Square(100);

            if (mySquare is IDraw)
            {
                IDraw drawSquare = mySquare;
                //drawSquare.SetLocation((int)mouseLocation.X, (int)mouseLocation.Y);
                drawSquare.X = (int)mouseLocation.X;
                drawSquare.Y = (int)mouseLocation.Y;
                drawSquare.Draw(drawingCanvas);
            }

            if (mySquare is IColor)
            {
                IColor colorSquare = mySquare;
                //colorSquare.SetColor(Colors.BlueViolet);
                colorSquare.Color = Colors.BlueViolet;
            }
        }

        private void drawingCanvas_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            Point mouseLocation = e.GetPosition(this.drawingCanvas);
            Circle myCircle = new Circle(100);

            if (myCircle is IDraw)
            {
                IDraw drawCircle = myCircle;
                //drawCircle.SetLocation((int)mouseLocation.X, (int)mouseLocation.Y);
                drawCircle.X = (int)mouseLocation.X;
                drawCircle.Y = (int)mouseLocation.Y;
                drawCircle.Draw(drawingCanvas);
            }

            if (myCircle is IColor)
            {
                IColor colorCircle = myCircle;
                //colorCircle.SetColor(Colors.HotPink);
                colorCircle.Color = Colors.HotPink;
            }
        }
    }
}
