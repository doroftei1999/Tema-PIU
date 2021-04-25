using System;

namespace Tema
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            show a = new show();
            a.name = "dfdfd";
            Console.WriteLine(a.name);
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

        public float review
        { get; set; }

        public bool onGoing
        { get; set; }
    }
}