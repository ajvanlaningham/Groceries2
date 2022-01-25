using Groceries2.Data;
using Groceries2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Groceries2.Controllers
{
    public class MeasurementController : Controller
    {
        private readonly ApplicationDbContext _db;

        public MeasurementController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Measurement> measurements = _db.Measurements.ToList();
            return View(measurements);
        }
    }
}
