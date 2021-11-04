using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodichka
{
    class Song
    {
        private string name;
        private string author;
        private Song prev;
        public Song(string name, string author, Song prev)
        {
            this.name = name;
            this.author = author;
            this.prev = prev;
        }
        public Song(string name, string author)
        {
            this.name = name;
            this.author = author;
            prev = null;
        }
        public Song()
        {
            name = "Неизестная песня";
            author = "Неизвестный исполнитель";
            prev = null;
        }
        public string Title()
        {
            return name + " - " + author;
        }
        public override bool Equals(object d)
        {
            return d != null &&
                name.Equals((d as Song).name) &&
                author.Equals((d as Song).author);
        }
    }
}
