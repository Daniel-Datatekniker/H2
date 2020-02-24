using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Game;
namespace OldMaid.Wrapper
{
    class ImageCardWrapper : System.Windows.Controls.Image
    {
        Card card;
        public event EventHandler MouseOverImage;
        public ImageCardWrapper(Card imageCard, int distance, double ScreenWidth)
        {
            card = imageCard;
            HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            Width = 100;
            Height = 100;
            Canvas.SetLeft(this, distance);
            Name = card.GetValue();
            Source = new BitmapImage(new Uri($"/Assets/{card.GetValue().ToLower()}.png", UriKind.Relative));
            MouseEnter += ImageCardWrapper_MouseEnter;
            MouseLeave += ImageCardWrapper_MouseLeave;
            MouseLeftButtonDown += ImageCardWrapper_MouseLeftButtonDown;
        }

        private void ImageCardWrapper_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            //Send ned til modellen og pair istedet for her.
            Image image = (Image)sender;
            if (Parent is Canvas && ((Canvas)Parent).Name == "PlayerCanvas")
            {


                Image[] ImageUp = new Image[1];
                foreach (Image item in ((Canvas)Parent).Children)
                {
                    if (item.Height == 120)
                    {
                        for (int i = 0; i < ImageUp.Length; i++)
                        {
                            if (ImageUp[i] == null && !ImageUp.Contains(item))
                            {
                                ImageUp[i] = item;
                            }

                        }
                    }

                }

                for (int i = 0; i < ImageUp.Length; i++)
                {
                    if (ImageUp[i] == null)
                    {
                        image.Height = 120;
                        Canvas.SetZIndex(this, 10);
                    }
                }

                if (this.Height == 120 && ImageUp.Contains(this))
                {
                    this.Height = 100;
                }

                if (ImageUp[0] != null && ImageUp[0] != this)
                {
                    if (ImageUp[0].Name == this.Name)
                    {
                        ((Canvas)this.Parent).Children.Remove(ImageUp[0]);
                        ((Canvas)this.Parent).Children.Remove(this);
                    }
                }


                //new CanvasUpdater(SystemParameters.PrimaryScreenWidth, ((Canvas)this.Parent));
            }
        }

        private void ImageCardWrapper_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {

            // this.Height = 100;
            if (this.Height == 100)
            {
                Canvas.SetZIndex(this, 0);
            }
        }

        private void ImageCardWrapper_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {

            if (Parent is Canvas && ((Canvas)Parent).Name == "PlayerCanvas")
            {
                // this.Height = 120;
                Canvas.SetZIndex(this, 10);
            }
        }
    }

}

