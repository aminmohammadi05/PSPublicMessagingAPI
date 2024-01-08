using AutoMapper;
using PSPublicMessagingAPI.Desktop.Presenter;
using PSPublicMessagingAPI.Desktop.Services;
using PSPublicMessagingAPI.Desktop.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desktop.Views.Shared;
using PSPublicMessagingAPI.Domain.Notifications;

namespace PSPublicMessagingAPI.Desktop.Views
{
    public partial class Message : Form
    {
        public NotificationViewModel Notification { get; set; }
        IMapper _mapper;
        private readonly ICommunicationApplicationController _communicationService;
        private readonly IActiveDirectoryService _activeDirectoryService;
        IFontService _fontService;
        public Message(NotificationViewModel notification, ICommunicationApplicationController communicationService, IActiveDirectoryService activeDirectoryService, IMapper mapper, IFontService fontService)
        {

            this.Notification = notification;
            _communicationService = communicationService;
            _activeDirectoryService = activeDirectoryService;
            InitializeComponent();
            _fontService = fontService;
            List<Control> allControls = GetAllControls(this);
            allControls.ForEach(k => k.Font = new Font(_fontService.pfc.Families[0], k.Font.Size));
            _mapper = mapper;

        }

        private List<Control> GetAllControls(Control container, List<Control> list)
        {
            foreach (Control c in container.Controls)
            {

                if (c.Controls.Count > 0)
                    list = GetAllControls(c, list);
                else
                    list.Add(c);
            }

            return list;
        }
        private List<Control> GetAllControls(Control container)
        {
            return GetAllControls(container, new List<Control>());
        }


        private void NotificationBubble_Load(object sender, EventArgs e)
        {
            this.BringToFront();

            lblTitle.Text = Notification.NotificationTitle;

            lblDate.Text = Notification.NotificationDatePersian;
            lblTime.Text = Notification.NotificationTimePersian;
            lblStatus.Text = Notification.NotificationStatusText;
            lblPriority.Text = Notification.NotificationPriorityText;
            txtMessage.Text = Notification.NotificationText;
            svgPriority.SvgImage = DevExpress.Images.ImageResourceCache.Default.GetSvgImage(Notification.NotificationPriorityIcon.ToLower());

            if (Notification.PossibleActionModuleName == "پیام عمومی")
            {
                svgStstus.Visible = false;
                lblStatus.Visible = false;
                label2.Visible = false;
                lblSender.Text = "پیام عمومی";

            }
            else
            {
                svgStstus.Visible = true;
                lblStatus.Visible = true;
                label2.Visible = true;
                lblSender.Text = Notification.PossibleActionFormName;
                svgStstus.SvgImage = DevExpress.Images.ImageResourceCache.Default.GetSvgImage(Notification.NotificationStatusIcon.ToLower());

            }
        }
        private NotificationViewModel mapToViewModel(Notification notif)
        {
            return _mapper.Map<Notification, NotificationViewModel>(notif);

        }
    }
}
