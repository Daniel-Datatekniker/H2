using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace OldMaid
{
    class CanvasUpdater
    {

        public CanvasUpdater(double width, Canvas canvas)
        {

            List<Image> images = new List<Image>();
            foreach (var item in canvas.Children)
            {
                images.Add((Image)item);
            }



            canvas.Children.RemoveRange(0, images.Count);
            double count = width / images.Count;

            foreach (var item in images)
            {
                count = Math.Floor(count);
                Canvas.SetLeft(item, count);
                canvas.Children.Add(item);

                count += (width - item.Width - 30) / images.Count;
            }

        }
    }
}
