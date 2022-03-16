using SkiaSharp;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;

namespace FCGG
{
    public class Channel
    {
        private SKImageInfo _imageInfo;

        private SKSurface _surface;

        private Timer _timer;

        public Bitmap PreviewBitmap { get; set; }

        public uint Number { get; private set; }

        public Channel(uint number, uint width = 1280, uint height = 720)
        {
            Number = number;

            _imageInfo = new SKImageInfo((int)width, (int)height, SKColorType.Bgra8888, SKAlphaType.Unpremul);

            PreviewBitmap = new Bitmap((int)width, (int)height, PixelFormat.Format32bppArgb);

            _surface = SKSurface.Create(_imageInfo);

            _surface.Canvas.Clear(SKColors.Red);

            using var paint = new SKPaint
            {
                TextSize = 250.0f,
                IsAntialias = true,
                Color = SKColors.Black,
                IsStroke = false
            };

            _surface.Canvas.DrawText($"CH: {Number}", 0, 256.0f, paint);

            _timer = new Timer(Tick, null, 0, 100);
        }

        ~Channel()
        {
            _surface.Dispose();
        }

        private void Tick(object state)
        {
            _surface.Canvas.Clear(SKColors.Red);

            using var paint = new SKPaint
            {
                TextSize = 250.0f,
                IsAntialias = true,
                Color = SKColors.Black,
                IsStroke = false
            };

            _surface.Canvas.DrawText($"CH: {Number}", 0, 256.0f, paint);

            paint.TextSize = 120.0f;

            _surface.Canvas.DrawText(DateTime.UtcNow.ToString("O"), 0, 512.0f, paint);
        }

        public void GetPreview()
        {
            var bmpData = PreviewBitmap.LockBits(new Rectangle(0, 0, PreviewBitmap.Width, PreviewBitmap.Height), ImageLockMode.WriteOnly, PreviewBitmap.PixelFormat);

            _surface.ReadPixels(_imageInfo, bmpData.Scan0, bmpData.Stride, 0, 0);

            PreviewBitmap.UnlockBits(bmpData);
        }
    }
}
