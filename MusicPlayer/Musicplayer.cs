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
        public Musicplayer(string title, string singer, string path, int durationInSeconds, int songCounter)
        {
            this.songCounter = songCounter;
            song = new Song(title,singer, path, durationInSeconds);
        }

        public bool AddSong(Song nwSong)
        {
          List<Song> playList = new List<Song>(20);
          playList.Add(nwSong);
            return true;
        }

        public Song GetSong(int index)
        {
            Song[] songs = new Song[index];
            this.songCounter = index;
            songs[songCounter] = song;
            return song;

        }

        public Song[] getSongs()
        {
            return 
        }

        public Song[] getSongs(string title)
        {
            Song[] songs = new Song[20];
            return song.getTitle();
        }

        public Song[] getSongs(int durationMinSeconds, int durationMaxSeconds)
        {
            return int durationMinSeconds = song.getDuration();
        }
    }
}
