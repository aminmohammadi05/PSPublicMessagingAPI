
using PSPublicMessagingAPI.Desktop.Models;
using PSPublicMessagingAPI.Desktop.Presenter.Presenter.Shared;
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
using DevExpress.XtraEditors;
using PSPublicMessagingAPI.DesktopWinforms.Properties;
using PSPublicMessagingAPI.SharedToastMessage;
using PSPublicMessagingAPI.SharedToastMessage.Models;
using PSPublicMessagingAPI.SharedToastMessage.Services;
using System.Threading;
using DevExpress.Data;

namespace Desktop.Views.Shared
{
    public partial class ViewBase : XtraForm
    {
        private IViewBasePresenter _presenter;
        public IViewBasePresenter Presenter
        {
            get
            {
                return _presenter;
            }
            set
            {
                if (_presenter == null)
                {
                    _presenter = value;
                }
            }
        }
        IToastService _toastService;
        public void Run()
        {

        }
        
        protected virtual void ShowMessage(string message, ToastType toastType)
        {
            
            
        }
        public ViewBase()
        {

        }
        public ViewBase(IToastService toastService)
        {
            _toastService = toastService;
            InitializeComponent();
            
            this.Icon = Resources.New_Project;
        }
    }
}
