using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSPublicMessagingAPI.Desktop.Services;

namespace Desktop.Views.Shared
{
    public partial class ToastMessageView : Form
    {
        private readonly IToastService _toastService;

        public ToastMessageView(IToastService toastService)
        {
            _toastService = toastService;
            InitializeComponent();
            
        }
        public new void Show()
        {
            this.TopMost = true;
            base.Show();

            //this.Owner = System.Windows.Application.Current.MainWindow;
           
            var workingArea = Screen.PrimaryScreen.WorkingArea;

            this.Left = workingArea.Right - this.Width;
            double top = workingArea.Bottom - (this.Height + 100);

            //foreach (Window window in System.Windows.Application.Current.Windows)
            //{
            //    string windowName = window.GetType().Name;

            //    if (windowName.Equals("ToastMessageView") && window != this)
            //    {
            //        window.Topmost = true;
            //        top = window.Top - (window.ActualHeight);
            //    }
            //}

            this.Top = (int)top;
        }
        private void ImageMouseUp(object sender, MouseEventArgs e)
        {
            this.Close();
        }

       
    }
}
