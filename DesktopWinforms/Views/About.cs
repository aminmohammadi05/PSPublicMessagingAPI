using PSPublicMessagingAPI.Desktop.Services;
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

namespace PSPublicMessagingAPI.Desktop.Views
{
    public partial class About : ViewBase
    {
        IFontService _fontService;
        IConfigurationManagerService _configurationManagerService;
        public About(IFontService fontService, IConfigurationManagerService configurationManagerService)
        {
            InitializeComponent();
            svgLogo.SvgImage = global::DesktopWinforms.Properties.Resources.LOGO;
            _fontService = fontService;
            _configurationManagerService = configurationManagerService;
            List<Control> allControls = GetAllControls(this);

            //lblUserName.Font = _fontService.font;
            allControls.ForEach(k => k.Font = new Font(_fontService.pfc.Families[0], k.Font.Size));

            lblAbout.Text = _configurationManagerService.AboutTitle;
            lblAboutText.Text = _configurationManagerService.AboutText;
            lblAbout.Font = new Font(_fontService.pfc.Families[0], 12);
            lblAbout.ForeColor = Color.Green;
            lblAboutText.Font = new Font(_fontService.pfc.Families[0], 10);

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
    }
}
