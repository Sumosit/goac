using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace iitu.web.example.Entity
{
    public class Bookmark
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }
        public User user { get; set; }
        public Anime anime { get; set; }
        public long id_anime { get; set; }
        public long id_season { get; set; }
        public long id_ep { get; set; }
    }
}
