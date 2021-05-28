﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RAMWebUI.Models;
using RAMBL;
using Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace RAMWebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IBussiness _bussinessLayer;
        public HomeController(ILogger<HomeController> logger, IBussiness BussinessLayer)
        {
            
            _logger = logger;
             _bussinessLayer = BussinessLayer;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult HomeHome()
        {
            List<TaskItemVM> taskItemVMs = _bussinessLayer.GetAllTasks().Select(taskItem => new TaskItemVM(taskItem))
                .ToList();
            return View(taskItemVMs);
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
<<<<<<< HEAD
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
=======
                _bussinessLayer.RemoveTask(new TaskItem() );
>>>>>>> 2f41f6b7111986dee09b470c30f84c4ac1877a3c
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
