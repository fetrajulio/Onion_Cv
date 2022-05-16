using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Archi_Repository;
using Microsoft.AspNetCore.Mvc;

namespace Archi_Back.Controllers
{
    public class FinanceController : Controller
    {
        public IActionResult Index()
        {
            FinanceRepo financeRepo = new FinanceRepo();
            ViewBag.fin = financeRepo.GetAll();
            return View();
        }
    }
}