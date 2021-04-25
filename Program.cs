using System;

namespace Tema
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            show first = new show();
            first.name = "The Big Bang Theory";
            Console.WriteLine(first.name);
            first.review = 8.1;
        }
    }

    internal class show
    {
        public string name
        { get; set; }

        public string genre
        { get; set; }

        public int numberOfEpisodes
        { get; set; }

        public int numberOfSeasons
        { get; set; }

        public double review
        {
            get { return review; }
            set
            {
                if (value >= 0 && value <= 10)
                    review = value;
                else
                    review = -1;
            }
        }

        public bool onGoing
        { get; set; }
    }

    internal class show
    {
        public string name
        { get; set; }

        public string genre
        { get; set; }

        public int numberOfEpisodes
        { get; set; }

        public int numberOfSeasons
        { get; set; }

        public float review
        { get; set; }

        public bool onGoing
        { get; set; }
    }
}