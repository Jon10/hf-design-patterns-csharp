using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Threading;

namespace CDCover
{
    class ImageProxy
    {
        private bool done;
        private Timer timer;

        public ImageProxy()
        {
            timer = new Timer(
                new TimerCallback (TimerCall), this, 5000, 0);
        }

        private void TimerCall(object obj)
        {
            done = true;
            timer.Dispose();
        }

        public Image GetImage()
        {
            IImager img;
            if (done)
                img = new FinalImage();
            else
                img = new QuickImage();
            return img.GetImage();
        }
    }

    public class QuickImage : IImager
    {
        public QuickImage() { }
        public Image GetImage()
        {
            return new Bitmap(@"..\..\loading.gif");
        }
    }
        
    public class FinalImage : IImager
    {
        public FinalImage() { }
        public Image GetImage()
        {
            return new Bitmap(@"..\..\helloworld.png");
        }
    }
}
