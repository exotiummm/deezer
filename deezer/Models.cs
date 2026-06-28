using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deezer
{
    internal class Models
    {
        public class DeezerResponse
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
    }
}
