using System;
using System.Collections.Generic;
using System.Text;

namespace MusicPlayer
{
    internal class Song
    {
        private string title;
        private string singer;
        private string path;
        private int durationInSeconds;

        public Song(string title, string singer, string path, int durationInSeconds)
        {
            this.title = title;
            this.singer = singer;
            this.path = path;
            this.durationInSeconds = durationInSeconds;
        }

        public Song(string title, string path, int durationInSeconds)
        {
            this.title = title;
            this.path = path;
            this.durationInSeconds=durationInSeconds;
            this.singer = "Unknown";
        }

        public void Play()
        {
            System.Media.SoundPlayer myPlayer = new System.Media.SoundPlayer();
            myPlayer.SoundLocation = path;
            myPlayer.Play();
        }

        public string getTitle()
        {
            return title;
        }

        public string getInfo()
        {
            return $"{title} - {singer} ({durationMinSeconds}:{durationInSeconds}s.)";
;       }

        public int getDuration()
        {
            return durationInSeconds;
        }
    }
}
