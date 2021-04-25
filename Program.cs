using System;
using System.Collections.Generic;

namespace Tema
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            show BBT = new show("The Big Bang Theory, Comedie, 12, 279, 8.1, false");
            Console.WriteLine(BBT.convertToString());
            show SOA = new show("Sons of anarchy, Drama, 7, 92, 8.5, false");
            Console.WriteLine(SOA.convertToString());
            Console.WriteLine("Serialul mai bine cotat este: \n" + show.compare(BBT, SOA).convertToString());
            string[,] sortedWords = new string[30, 30];
            int k = 0;
            Array.Sort(args);
            for (int i = 0; i < 26; i++)
            {
                k = 0;
                for (int j = 0; j < args.Length; j++)
                    if (args[j][0] == i + 65 || args[j][0] == i + 97)
                    {
                        sortedWords[i, k++] = args[j];
                        //Array.Resize(ref sortedWords, k); Nu am reusit sa fac resize.
                    } ///Memoria e consumata degeaba.
            }
            for (int i = 0; i < sortedWords.GetLength(0); i++)
            {
                if (String.IsNullOrEmpty(sortedWords[i,0]) == false)
                {
                    Console.WriteLine();
                    for (int j = 0; j < sortedWords.GetLength(1); j++)
                        if (String.IsNullOrEmpty(sortedWords[i, j]) == false)
                            Console.Write(sortedWords[i, j] + ' ');
                }
            }
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
        public static show compare(show a, show b)
        {
            if (a.review >= b.review)
                return a;
            else
                return b;
        }

        public void display()
        {
            Console.WriteLine("Nume: " + this.name);
            Console.WriteLine("Genul: " + this.genre);
            Console.WriteLine("Numar de sezoane: " + this.numberOfSeasons);
            Console.WriteLine("Numar de episoade: " + this.numberOfEpisodes);
            Console.WriteLine("Recenzie: " + this.review);
            if (onGoing)
                Console.WriteLine("Inca apar episoade.\n");
            else
                Console.WriteLine("Serialul s-a incheiat.\n");
        }
        public string convertToString()
        {
            string onGoingString = (onGoing) ? "Inca apar episoade.\n" : "Serialul s-a incheiat.\n";
            return "Nume: " + this.name + "\nGenul: " + this.genre +
                "\nNumar de sezoane: " + this.numberOfSeasons.ToString() + "\nNumar de episoade: " + 
                this.numberOfEpisodes.ToString() + "\nRecenzie: " + this.review.ToString() + "\n" + onGoingString ;
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