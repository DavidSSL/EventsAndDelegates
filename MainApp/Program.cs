namespace MainApp
{
    class Program
    {
        static void Main()
        {
            var video = new Video();

            var videoEncoder = new VideoEncoder();

            var mailService = new MailService();

            videoEncoder.VideoEncoded += mailService.VideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
