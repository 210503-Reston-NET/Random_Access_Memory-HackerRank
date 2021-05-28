using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RAMWebUI.Models;
using RAMBL;
using Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace RAMWebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IBussiness _BL;

        public HomeController(ILogger<HomeController> logger, IBussiness BussinessLayer)
        {
            _logger = logger;
            _BL = BussinessLayer;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // GET: ../Home/Delete
        public IActionResult Delete()
        {
            return View();
        }

        // POST: ../Home/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(TaskItemVM task)
        {
            try
            {
                _BL.RemoveTask(new TaskItem()
                {
                    TaskID = task.TaskID,
                    Title = task.Title,
                    Created = task.Created,
                    Description = task.Description,
                    Finished = task.Finished,
                    priority = task.priority,
                    stage = task.stage
                });
                return RedirectToAction(nameof(Index));
            } catch (Exception e)
            {
                _logger.LogError(e.Message);
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
