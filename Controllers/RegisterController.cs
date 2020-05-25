using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace iitu.web.example.Controllers
{
    public class RegisterController : Controller
    {
        [BindProperty(SupportsGet = true)]
        public String email { get; set; }
        [BindProperty(SupportsGet = true)]
        public String username { get; set; }
        [BindProperty(SupportsGet = true)]
        public String password { get; set; }
        [BindProperty(SupportsGet = true)]
        public String passwordConfirm { get; set; }
        public IActionResult register()
        {
            string cs = @"server=localhost;userid=root;password=;database=goa_ss";

            var con = new MySqlConnection(cs);
            con.Open();

            string sql = "SELECT * FROM anime";
            var cmd = new MySqlCommand(sql, con);

            MySqlDataReader rdr = cmd.ExecuteReader();

            int i = 0;
            List<Entity.Anime> anime = new List<Entity.Anime>();

            while (rdr.Read())
            {
                Entity.Anime a = new Entity.Anime();
                a.id = rdr.GetInt32(0);
                a.history = rdr.GetString(5);
                a.image = rdr.GetString(6);
                a.name = rdr.GetString(8);
                anime.Add(a);
            }

            return View(anime);
        }
    }
}