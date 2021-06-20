using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace PlayerConceptDesign.ViewModel
{
    public static class InvertImage
    {
        public static ImageSource Invert(BitmapSource source, bool invert)
        {
            if (!invert) return source;
            int stride = (source.PixelWidth * source.Format.BitsPerPixel + 7) / 8;
            int length = stride * source.PixelHeight;
            byte[] data = new byte[length];
            source.CopyPixels(data, stride, 0);
            for (int i = 0; i < length; i += 4)
            {
                data[i] = (byte)(255 - data[i]);
                data[i + 1] = (byte)(255 - data[i + 1]);
                data[i + 2] = (byte)(255 - data[i + 2]);
            }
            return  BitmapSource.Create(source.PixelWidth, source.PixelHeight, 
                source.DpiX, source.DpiY, source.Format, null, data, stride);
        }

     
    }
}
