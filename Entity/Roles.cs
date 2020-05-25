using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace iitu.web.example.Entity
{
    public class Roles
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }
        public String role { get; set; }
        public String description { get; set; }
    }
}
