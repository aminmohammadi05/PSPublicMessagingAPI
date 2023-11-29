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
using System.Windows.Forms;
using System.Windows.Shapes;
using PSPublicMessagingAPI.SharedToastMessage.Services;

namespace PSPublicMessagingAPI.SharedToastMessage
{
    /// <summary>
    /// Interaction logic for ToastMessageView.xaml
    /// </summary>
    public partial class ToastMessageView : Window
    {
        public ToastMessageView(IToastService toastService)
            : base()
        {
            this.InitializeComponent();
            DataContext = toastService;
            this.Closed += this.ToastWindowClosed;
        }

        public new void Show()
        {
            this.Topmost = true;
            base.Show();

            //this.Owner = System.Windows.Application.Current.MainWindow;
            this.Closed += this.ToastWindowClosed;
            var workingArea = Screen.PrimaryScreen.WorkingArea;

            this.Left = workingArea.Right - this.ActualWidth;
            double top = workingArea.Bottom - (this.ActualHeight + 100);



            this.Top = top;
        }
        private void ImageMouseUp(object sender,
            System.Windows.Input.MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void DoubleAnimationCompleted(object sender, EventArgs e)
        {
            if (!this.IsMouseOver)
            {
                this.Close();
            }
        }
        private void ToastWindowClosed(object sender, EventArgs e)
        {
            //foreach (Window window in System.Windows.Application.Current.Windows)
            //{
            //    string windowName = window.GetType().Name;

            //    if (windowName.Equals("ToastMessageView") && window != this)
            //    {
            //        // Adjust any windows that were above this one to drop down
            //        if (window.Top < this.Top)
            //        {
            //            window.Top = window.Top + (this.ActualHeight);
            //        }
            //    }
            //}
        }
    }
}
