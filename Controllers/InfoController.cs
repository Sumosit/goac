using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace iitu.web.example.Controllers
{
    public class InfoController : Controller
    {
        [BindProperty(SupportsGet = true)]
        public int id { get; set; }
        public IActionResult info()
        {
            string cs = @"server=localhost;userid=root;password=;database=goa_ss";

            var con = new MySqlConnection(cs);
            con.Open();

            string sql = "SELECT * FROM anime Where id = " + id;
            var cmd = new MySqlCommand(sql, con);

            MySqlDataReader rdr = cmd.ExecuteReader();

            Entity.Anime anime = new Entity.Anime();

            while (rdr.Read())
            {
                anime.id = rdr.GetInt32(0);
                anime.date = rdr.GetString(3);
                anime.genre = rdr.GetString(4);
                anime.history = rdr.GetString(5);
                anime.image = rdr.GetString(6);
                anime.name = rdr.GetString(8);
            }

            ViewData["name"] = anime.name;
            ViewData["history"] = anime.history;
            ViewData["date"] = anime.date;
            ViewData["genre"] = anime.genre;
            ViewData["image"] = anime.image;

            return View();
        }
    }
}
