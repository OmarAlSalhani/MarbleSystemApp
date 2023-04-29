using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows;
using System.Windows.Forms;

namespace MarbleSystemApp
{
    /// <summary>
    /// this class is used for convert operations
    /// like convert image to byte
    /// </summary>
    class convert_class
    {
        // method used to convert image to byte , to stored it in database
        // it`s take one parameter the image we want to save it
        public static byte[] image_to_byte(System.Drawing.Image image)
        {
            try
            {
                
                byte[] image_byte;
                if (image is null)
                {
                    return image_byte=new byte[] { };
                }
                MemoryStream memoryStream = new MemoryStream();
                image.Save(memoryStream, ImageFormat.Png);
                image_byte = new byte[memoryStream.Length];
                memoryStream.Position = 0;
                memoryStream.Read(image_byte, 0, image_byte.Length);
                return image_byte;
            }
            catch (Exception ex)
            {
                OmarNotifications.Alert.ShowInformation(ex.Message);
                return null;
            }
        }

        public static System.Drawing.Image byte_to_image(object table_row)
        {
            byte[] photo_aray = (byte[])table_row;
            if(photo_aray.Length==0)
            {
                return null;
            }
            MemoryStream ms = new MemoryStream(photo_aray);
            return System.Drawing.Image.FromStream(ms);
        }

    }
}
