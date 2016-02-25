using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picsi
{
    public class PicManager
    {
        public Pic GetInfos(string path)
        {
            // Pour décoder les propriétés de l'image
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();

            var pic = new Pic
            {
                Path = path,
                Name = path.Substring(path.LastIndexOf(@"\") + 1),
                Extension = path.Substring(path.LastIndexOf(@".") + 1)
            };

            
            using (Image image = new Bitmap(pic.Path))
            {
                pic.Width = image.Width;
                pic.Height = image.Height;
                if (image.Tag != null)
                    pic.Tag = image.Tag.ToString();
                pic.Manufacturer = encoding.GetString(image.GetPropertyItem(271).Value).Replace("\0", "");
                pic.Model = encoding.GetString(image.GetPropertyItem(272).Value).Replace("\0", "");
                var date = encoding.GetString(image.GetPropertyItem(306).Value).Replace("\0", "");
                pic.ShotDate = DateTime.ParseExact(date, "yyyy:MM:dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

                image.Dispose();
            }
            return pic;
        }


    }
}
