using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace iitu.web.example.Entity
{
    public class Anime
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }
        public int views { get; set; }
        public int season { get; set; }
        public String history { get; set; }
        public String links { get; set; }
        public String name { get; set; }
        public String image { get; set; }
        public String genre { get; set; }
        public String date { get; set; }
        public String producer { get; set; }
        public String address { get; set; }
        public String birth { get; set; }
    }
}
