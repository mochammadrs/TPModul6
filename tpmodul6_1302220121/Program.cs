internal class Program
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;
        public SayaTubeVideo(string title)
        {
            Random rnd = new Random();
            this.id = rnd.Next(10000, 100000);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Video Details:");
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("TItle: " + this.title);
            Console.WriteLine("Play Count: " + this.playCount);
        }
    }
    static void Main(string[] args)
    {
        string videoTitle = "Tutorial Design By Contract - Rizky Septian";
        SayaTubeVideo myVideo = new SayaTubeVideo(videoTitle);

        myVideo.IncreasePlayCount(1);

        myVideo.PrintVideoDetails();
    }
}