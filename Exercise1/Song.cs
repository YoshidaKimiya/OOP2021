using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Song {
        private string title;
        private string artistName;
        private int length;

        public string Title { get => title; set => title = value; }
        public string ArtistName { get => artistName; set => artistName = value; }
        public int Length { get => length; set => length = value; }
    
        public Song(string title,string artistName,int length) {
            this.title = title;
            this.artistName = artistName;
            this.length = length;
        }
    }
}
