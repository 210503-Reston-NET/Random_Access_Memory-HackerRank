using Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Data
{
    public class Database
    {
        private RamDBContext _context;

        public Database(RamDBContext context){
            _context = context;
        }
        public List<TaskItem> GetAllTasks() {
            try
            {
                return (from tItem in _context.TaskItems
                        select tItem).ToList();
            }
            catch (Exception e) {
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
                return null;
            }
        }
        public TaskItem UpdateTaskStatus(TaskItem tItem)
        {
            _context.TaskItems.Update(tItem);
            _context.SaveChanges();
            return tItem;
        }

    }
}
