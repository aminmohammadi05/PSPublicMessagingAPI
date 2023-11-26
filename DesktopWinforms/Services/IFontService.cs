using System.Drawing;
using System.Drawing.Text;

namespace PSPublicMessagingAPI.Desktop.Services;

public interface IFontService
{
    PrivateFontCollection pfc { get; set; }
    Font font { get; set; }
}