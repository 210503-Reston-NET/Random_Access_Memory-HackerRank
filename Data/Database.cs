using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Serilog;


namespace Data
{
    public class Database
    {
        private RamDBContext _context;

        public Database(RamDBContext context){
            _context = context;

            // Initialize Serilogger
            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.File("../logs/StoreApp.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();
        }
        public List<TaskItem> GetAllTasks() {
            try
            {
                return (from tItem in _context.TaskItems
                        select tItem).ToList();
            }
            catch (Exception e) {
                Log.Error(e.Message, "Failed to retrieve all Tasks from database.");
                return null;
            }
        }
        public TaskItem GetTaskById(int id) {
            try
            {
                return (from tItem in _context.TaskItems
                        where tItem.TaskID == id
                        select tItem).Single();
            }
            catch(Exception e)
            {
                Log.Error(e.Message, "Failed to retrieve Task with ID: " + id + ".");
                return null;
            }
        }
        public TaskItem AddTask(TaskItem tItem)
        {
            try
            {
                _context.TaskItems.Add(tItem);
                _context.SaveChanges();
                return tItem;
            }
            catch(Exception e)
            {
                Log.Error(e.Message, "Failed to add Task with ID: " + tItem.TaskID + " database.");
                return null;
            }
        }
        public TaskItem UpdateTaskStatus(TaskItem tItem)
        {
            try
            {
                _context.TaskItems.Update(tItem);
                _context.SaveChanges();
                return tItem;
            } catch (Exception e)
            {
                Log.Error(e.Message, "Failed to update Task with ID: " + tItem.TaskID + " from database.");
                return null;
            }
        }
        public TaskItem RemoveTask(TaskItem tItem)
        {
            try
            {
                _context.TaskItems.Remove(tItem);
                _context.SaveChanges();
                return tItem;
            } catch (Exception e)
            {
                Log.Error(e.Message, "Failed to remove Task with ID: " + tItem.TaskID + " from database.");
                return null;
            }
        }

    }
}
