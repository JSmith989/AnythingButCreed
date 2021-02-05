using System;
using System.Collections.Generic;
using System.Linq;

namespace AnythingButCreed
{
    class Program
    {
        static void Main(string[] args)
        {
            var goodSongs = new List<Song>();
            var allSongs = new List<Song>
            {
                new Song("Built To Spill", "Carry The Zero"),
                new Song("Creed", "Higher"),
                new Song("Hum", "Waves"),
                new Song("DIIV", "Skin Game"),
                new Song("Dead Soft", "I Believe You"),
                new Song("Bandit", "Losing In A Sense"),
                new Song("Horse Jumper Of Love", "Ugly Brunette"),
                new Song("Creed", "Arms Wide Open"),
                new Song("The Marias", "Only In My Dreams"),
                new Song("Donovan Wolfington", "Ollie North"),
                new Song("Narrow Head", "Necrosis"),
                new Song("Stage Bottles", "Sometimes Antisocial. Always Antifascist")
                
            };
            goodSongs.AddRange(allSongs.Where(song => song.Artist != "Creed"));

            foreach (var song in goodSongs)
            {
                Console.WriteLine($"{song.Artist} {song.Name}");
            }
        }
    }
}
