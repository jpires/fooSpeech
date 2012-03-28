using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace httpFoo
{
    class Music
    {
        private UInt32 trackNumber;
        /// <summary>
        /// Gets or Set the Track Number
        /// </summary>
        public UInt32 TrackNumber
        {
            get { return trackNumber; }
            set { trackNumber = value; }
        }
        private String title;
        /// <summary>
        /// Gets or Set the Title
        /// </summary>
        public String Title
        {
            get { return title; }
            set { title = value; }
        }
        private UInt32 duration;
        /// <summary>
        /// Gets or Set the duration in seconds
        /// </summary>
        public UInt32 Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        private Artist artist;
        /// <summary>
        /// Gets or Sets the Artist
        /// </summary>
        internal Artist Artist
        {
            get { return artist; }
            set { artist = value; }
        }
        private Album album;
        /// <summary>
        /// Gets or Set the Album
        /// </summary>
        internal Album Album
        {
            get { return album; }
            set { album = value; }
        }
        /// <summary>
        /// Creates a instance of Music
        /// </summary>
        /// <param name="title">Title of the music</param>
        /// <param name="duration">Duration in seconds of the music</param>
        /// <param name="album">A instance of the album that contains this music. Optional</param>
        /// <param name="artist">A instance of the Artist that creates this music. Optional</param>
        /// <param name="track">The Tack number of this music. Optional.</param>
        private Music(String title, UInt32 duration, Album album=null, Artist artist=null, UInt32 track = 0)
        {
            this.Title = title;
            this.Duration = duration;
            this.Album = album;
            this.Artist = artist;
            this.TrackNumber = track;
        }

        //partial public Music init(String title, UInt32 duration, Album album=null, Artist artist=null, UInt32 track = 0);
    }
}
