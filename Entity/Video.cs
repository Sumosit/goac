using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace iitu.web.example.Entity
{
    public class Video
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }
        public int season { get; set; }
        public int start { get; set; }
        public int series { get; set; }
    }
}
