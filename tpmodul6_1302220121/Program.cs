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
            if (string.IsNullOrEmpty(title) || title.Length > 100)
            {
                throw new ArgumentException("Judul video tidak valid.");
            }

            if (count < 0 || count > 10000000)
            {
                throw new ArgumentException("Jumlah penambahan play count tidak valid.");
            }

            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Terjadi overflow: " + ex.Message);
            }
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

        try
        {
            myVideo.IncreasePlayCount(100000000);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("ArgumentException: " + ex.Message);
        }

        for (int i = 0; i < 5; i++)
        {
            myVideo.IncreasePlayCount(2000000);
        }

        myVideo.PrintVideoDetails();
    }
}