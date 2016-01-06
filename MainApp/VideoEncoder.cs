using System;

namespace MainApp
{
    internal class VideoEncoder
    {
        // 1 Declare delegate that matches event handler
        public delegate void VideoEncodedEventHandler(object source, EventArgs eventArgs);
        // 2 declare event that uses the delegate
        public event VideoEncodedEventHandler VideoEncoded;



        public void Encode(Video video)
        {
            // Do encoding

            // Invoke event
            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            // 3 Publish event
            if (VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);
        }
    }
}