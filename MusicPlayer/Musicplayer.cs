using System;
using System.Collections.Generic;
using System.Text;

namespace MusicPlayer
{
    internal class Musicplayer
    {
        private int songCounter;
        Song song;
        public Musicplayer(string title, string path, int durationInSeconds, int songCounter)
        {
            this.songCounter = songCounter;
            song = new Song(title, path, durationInSeconds);
        }

        public bool AddSong(Song nwSong)
        {
          List<Song> playList = new List<Song>();
           playList.Add(nwSong);
        }

        public Song GetSong(int index)
        {
            return playList[index];

        }

        public Song[] getSongs()
        {

        }

        public Song[] getSongs(string title)
        {
            return title = Song.getTitle();
        }

        public Song[] getSongs(int durationMinSeconds, int durationMaxSeconds)
        {

        }
    }
}
