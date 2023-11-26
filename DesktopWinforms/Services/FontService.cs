using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using DevExpress.XtraRichEdit.Model;

namespace PSPublicMessagingAPI.Desktop.Services;

public class FontService : IFontService
{
    [DllImport("gdi32.dll")]
    private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [In] ref uint pcFonts);
    public PrivateFontCollection pfc { get; set; } = new PrivateFontCollection();
    public Font font { get; set; }
    public FontService()
    {
        font = InitializeResourceFont(DesktopWinforms.Properties.Resources.iranyekanwebregular);
    }

    public Font InitializeResourceFont(byte[] resourceFont)
    {
        byte[] fontData = resourceFont;
        IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
        Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
        uint dummy = 0;
        pfc.AddMemoryFont(fontPtr, resourceFont.Length);
        AddFontMemResourceEx(fontPtr, (uint)resourceFont.Length, IntPtr.Zero, ref dummy);
        Marshal.FreeCoTaskMem(fontPtr);

        return new Font(pfc.Families[0], 8.25F);
    }
}