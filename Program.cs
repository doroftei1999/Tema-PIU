using System;

namespace Tema
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            show BBT = new show("The Big Bang Theory, Comedie, 12, 279, 8.1, false");
            BBT.display();
        }
    }

    internal class show
    {
        public show() {}

        public show(string info)
        {
            string[] splittedInfo = info.Split(',');
            name = splittedInfo[0];
            genre = splittedInfo[1];
            numberOfSeasons = int.Parse(splittedInfo[2]);
            numberOfEpisodes = int.Parse(splittedInfo[3]);
            review = double.Parse(splittedInfo[4]) / 10;
            review = (review < 1) ? review * 10: review;
            onGoing = bool.Parse(splittedInfo[5]);
        }

        public void display()
        {
            Console.WriteLine("Nume: " + this.name);
            Console.WriteLine("Genul: " + this.genre);
            Console.WriteLine("Numar de sezoane: " + this.numberOfSeasons);
            Console.WriteLine("Numar de episoade: " + this.numberOfEpisodes);
            Console.WriteLine("Recenzie: " + this.review);
            if (onGoing)
                Console.WriteLine("Inca apar episoade.");
            else
                Console.WriteLine("Serialul s-a incheiat.");
        }

        public string name
        { get; set; }

        public string genre
        { get; set; }

        public int numberOfSeasons
        { get; set; }

        public int numberOfEpisodes
        { get; set; }

        public double review
        { get; set;}

        public bool onGoing
        { get; set; }
    }
}