using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CMS2019.Models;
using CMS2019.Data;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace CMS2019.Controllers
{

    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Posts.ToListAsync());
        }



        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var post = await _context.Posts
                .Include(p => p.Category)
                .Include(p => p.User)
                .SingleOrDefaultAsync(m => m.Id == id);


            var con = _context.Database.GetDbConnection();
            con.Open();
            var comm = con.CreateCommand();
            comm.CommandText = "IncreaseReaders"; //Stored procedure name
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.Parameters.Add(new SqlParameter("Id", id));
            comm.ExecuteNonQuery();


            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }
    }
}
