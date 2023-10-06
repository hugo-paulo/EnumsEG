using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEnuma
{
    internal class MusicCollection: IEnumerable<MusicAlbum>
    {
        public List<MusicAlbum> albums;
        public MusicCollection()
        {
            albums = new List<MusicAlbum>() 
            {
                new MusicAlbum("Ride the Lightning", "1984"),
                new MusicAlbum("Playing the Angel", "2005"),
                new MusicAlbum("Hunting High and Low", "1985"),
                new MusicAlbum("nevermind", "1991"),
                new MusicAlbum("Thriller", "1982"),
            };
            
        }

        public IEnumerator<MusicAlbum> GetEnumerator()
        {
            //Return all albums in the list
            //return albums.GetEnumerator();
            
            //Using the enumarator to only return albums where the name is up 8 chars
            return albums.Where(a=> a.Name.Length <= 8).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
