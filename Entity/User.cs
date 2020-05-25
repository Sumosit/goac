using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace iitu.web.example.Entity
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }
        public String email { get; set; }
        public String username { get; set; }
        public String password { get; set; }
        public String passwordConfirm { get; set; }
        public String role { get; set; }
    }
}
