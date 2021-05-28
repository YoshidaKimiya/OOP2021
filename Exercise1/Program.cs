using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static Song[] songs = new Song[2];
        static void Main(string[] args) {
             
            songs[0] = new Song("あいみょん", "マリーゴールド", 240);
            songs[1] = new Song("星野源", "恋", 200);
            PrintSongs(songs);
        }
        private static void PrintSongs(Song[] songs) {
            foreach (var song in songs) {
                Console.WriteLine("{0},{1},{2}:{3}",song.Title,song.ArtistName,song.Length/60,song.Length%60);
            }
        }   
    }
}
