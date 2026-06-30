using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deezer
{
    internal class Models
    {
        public class DeezerArtistResponse
        {
            public List<Artist> Data { get; set; }
        }

        public class Artist
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Picture { get; set; }
            public string Picture_Small { get; set; }
            public string Picture_Medium { get; set; }
            public string Picture_Big { get; set; }
            public int Nb_Album { get; set; }
            public int Nb_Fan { get; set; }
            public bool Radio { get; set; }
            public string Tracklist { get; set; }
            public string Type { get; set; }
            public string Fans
            {
                get { return Nb_Fan.ToString("N0"); }
            }
        }

        public class DeezerAlbumResponse
        {
            public List<Album> Data { get; set; }
        }

        public class Album
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Link { get; set; }
            public string Cover { get; set; }
            public string Cover_Small { get; set; }
            public string Cover_Medium { get; set; }
            public string Cover_Big { get; set; }
            public string Cover_XL { get; set; }
            public string MD5_Image { get; set; }
            public int GenreID { get; set; }
            public int Nb_Tracks { get; set; }
            public string Record_Type { get; set; }
            public string Tracklist { get; set; }
            public bool Explicit_Lyrics { get; set; }
            public Artist Artist { get; set; }
            public string Type { get; set; }
        }

        public class DeezerTrackResponse
        {
            public List<Track> Data { get; set; }
        }

        public class Track
        {
            public long Id { get; set; }
            public bool Readable { get; set; }
            public string Title { get; set; }
            public string Title_Short { get; set; }
            public string Title_Version { get; set; }
            public string ISRC { get; set; }
            public string Link { get; set; }
            public int Duration { get; set; }
            public int Rank { get; set; }
            public bool Explicit_Lyrics { get; set; }
            public int Explicit_Content_Lyrics { get; set; }
            public int Explicit_Content_Cover { get; set; }
            public string Preview { get; set; }
            public string MD5_Image { get; set; }
            public Artist Artist { get; set; }
            public Album Album { get; set; }
            public string Type { get; set; }
            public string MinuteDuration
            {
                get { return TimeSpan.FromSeconds(Duration).ToString(@"m\:ss"); }
            }

            public override string ToString()
            {
                return $"{Title}, длина: {MinuteDuration}";
            }
        }
    }
}
