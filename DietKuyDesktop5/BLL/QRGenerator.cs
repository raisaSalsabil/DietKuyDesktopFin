using QRCoder;
using System.Drawing;

namespace DietKuyDesktop5.BLL
{
    class QRGenerator
    {
        public static string GenerateInfo(string name, string phone, string address, string dayMenu, string nightMenu)
        {
            string result = "#" + name + "*" + phone + "*" + address + "*" + dayMenu + "*" + nightMenu;

            return result;
        }
        public static string GenerateInfo(string name, string phone, string address, string dayMenu, string nightMenu, out Bitmap QrBitmap)
        {
            string text = GenerateInfo(name, phone, address, dayMenu, nightMenu);

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qRCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qRCodeData);
            QrBitmap = qrCode.GetGraphic(20);

            return text;
        }
    }
}
