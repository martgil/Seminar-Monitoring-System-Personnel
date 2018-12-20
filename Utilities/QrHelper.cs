using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using ZXing.QrCode;
using ZXing.Rendering;
using System.Drawing;

namespace Capstone.Personnel.Utilities
{
    public class QrHelper
    {
        int qrHeight;
        int qrWidth;
        int qrMargin;
        string Data;
        BarcodeWriter qrWriter;
        Bitmap GeneratedQR;

        public QrHelper(int height,int width, int margin,string data)
        {
            qrHeight = height;
            qrWidth = width;
            qrMargin = margin;
            Data = data;
        }

        public Bitmap GetQRCode()
        {
            qrWriter = new BarcodeWriter();
            qrWriter.Format = BarcodeFormat.QR_CODE;
            qrWriter.Renderer = new BitmapRenderer();
            qrWriter.Options = new ZXing.Common.EncodingOptions
            {
                Width = qrWidth,
                Height = qrHeight,
                Margin = qrMargin
            };
            GeneratedQR = qrWriter.Write(Data);
            return GeneratedQR;
        }
    }
}
