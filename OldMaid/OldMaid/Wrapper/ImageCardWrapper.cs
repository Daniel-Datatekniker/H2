using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Game;
namespace OldMaid.Wrapper
{
    class ImageCardWrapper : System.Windows.Controls.Image
    {
        Card ImageCardShow;
        public ImageCardWrapper(Card imageCard, int distance)
        {
            ImageCardShow = imageCard;
            Canvas.SetLeft(this, distance);
            HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            Width = 100;
            Height = 100;
            Name = "Test";
            Source = new BitmapImage(new Uri($"/Assets/{ImageCardShow.GetValue().ToLower()}.png", UriKind.Relative));
        }
    }

}

