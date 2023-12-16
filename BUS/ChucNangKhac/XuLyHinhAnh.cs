using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.ChucNangKhac
{
    internal class XuLyHinhAnh
    {
        public static Image DieuChinhKichThuoc(Image image, int maxWidth, int maxHeight)
        {
            double ratioX = (double)maxWidth / image.Width;
            double ratioY = (double)maxHeight / image.Height;
            double ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(image.Width * ratio);
            int newHeight = (int)(image.Height * ratio);

            Bitmap newImage = new(newWidth, newHeight);
            using (Graphics graphics = Graphics.FromImage(newImage))
            {
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }
            return newImage;
        }

        public static byte[] AnhSangByte(Image image)
        {
            using MemoryStream memoryStream = new();
            try { image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg); }
            catch { image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png); }
            return memoryStream.ToArray();
        }

        public static Image? ByteSangAnh(byte[] imageData)
        {
            if (imageData != null && imageData.Length > 0)
            {
                using MemoryStream memoryStream = new(imageData);
                try
                {
                    Image image = Image.FromStream(memoryStream);
                    return image;
                }
                catch (ArgumentException ex)
                {
                    Debug.WriteLine("Lỗi: " + ex.Message);
                    return null;
                }
            }
            else
            {
                Debug.WriteLine("Dữ liệu hình ảnh không hợp lệ!");
                return null;
            }
        }
    }
}
