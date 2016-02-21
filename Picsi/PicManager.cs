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
            var pic = new Pic
            {
                Path = path,
                Name = path.Substring(path.LastIndexOf(@"\") + 1),
                Extension = path.Substring(path.LastIndexOf(@".") + 1)
            };

            try
            {
                // Create an Image object. 
                Image theImage = new Bitmap(path);

                // Get the PropertyItems property from image.
                PropertyItem[] propItems = theImage.PropertyItems;

                // Set up the display.
                Font font1 = new Font("Arial", 10);
                SolidBrush blackBrush = new SolidBrush(Color.Black);
                int X = 0;
                int Y = 0;

                // For each PropertyItem in the array, display the id, 
                // type, and length.
                int count = 0;
                foreach (PropertyItem propItem in propItems)
                {
                    e.Graphics.DrawString("Property Item " +
                        count.ToString(), font1, blackBrush, X, Y);
                    Y += font1.Height;

                    e.Graphics.DrawString("   ID: 0x" +
                        propItem.Id.ToString("x"), font1, blackBrush, X, Y);
                    Y += font1.Height;

                    e.Graphics.DrawString("   type: " +
                        propItem.Type.ToString(), font1, blackBrush, X, Y);
                    Y += font1.Height;

                    e.Graphics.DrawString("   length: " +
                        propItem.Len.ToString() +
                        " bytes", font1, blackBrush, X, Y);
                    Y += font1.Height;
                    count += 1;
                }
                font1.Dispose();
            }
            catch (Exception)
            {

            }
            return pic;
        }


    }
}
