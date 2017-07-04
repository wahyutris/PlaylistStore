using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlaylistStore.Models
{
    public class SongModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Singer { get; set; }
        public string Writer { get; set; }
        public string Year { get; set; }

        [DisplayName("Genre")]
        public int GenreID { get; set; }
        public string GenreName { get; set; }

        // Buat dropdown list yang akan dipake di controller dan view
        public IEnumerable<SelectListItem> Genres { get; set; }
        public SongModel()
        {
            Genres = new List<SelectListItem>();
        }
    }
}