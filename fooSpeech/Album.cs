using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics.Contracts;

namespace fooSpeech
{
    class Album
    {
        private String name;
        /// <summary>
        /// Gets or Sets the Name
        /// </summary>
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private UInt32 numberOfTracks;
        /// <summary>
        /// Gets the number of Track
        /// </summary>
        public UInt32 NumberOfTracks
        {
            get { return numberOfTracks; }
            private set { numberOfTracks = value; }
        }

        private UInt32 duration;
        /// <summary>
        /// Gets the duration of Album in seconds
        /// </summary>
        public UInt32 Duration
        {
            get { return duration; }
        }

        private Artist artist;
        /// <summary>
        /// Gets or Sets the Artist of the Album
        /// </summary>
        internal Artist Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        private List<Music> musicList;
        /// <summary>
        /// Gets or Sets the Musics of this Album
        /// </summary>
        internal List<Music> MusicList
        {
            get { return musicList; }
            set { musicList = value; }
        }

        /// <summary>
        /// Creates a instance of Album
        /// </summary>
        /// <param name="name">Name of Album</param>
        /// <param name="artist">Instance of the Artist that Album</param>
        /// <param name="musicList">A list with the music that compose the Album. Optional</param>
        public Album(String name, Artist artist, List<Music> musicList = null)
        {
            this.Name = name;
            this.Artist = artist;
            if (musicList != null)
            {
                this.NumberOfTracks = (UInt32)musicList.Count;
                UInt32 duration = 0;
                foreach (Music music in musicList)
                    duration += music.Duration;
                this.MusicList = musicList;
            }
            else
            {
                this.MusicList = new List<Music>();
            }
        }

        public void addMusic(Music music)
        {
            Contract.Requires(music != null);
            Contract.Ensures(this.MusicList.Count == Contract.OldValue(this.MusicList.Count) + 1);
            this.MusicList.Add(music);
        }
        public void removeMusic(Music music)
        {
            Contract.Requires(music != null);
            Contract.Ensures(this.MusicList.Count == Contract.OldValue(this.MusicList.Count) - 1);
            this.MusicList.Remove(music);
        }
    }
}
