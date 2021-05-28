using System;
using System.Collections.Generic;
using Models;
using Data;

namespace RAMBL
{
    public class BussinessLayer : IBussiness
    {
        Database _repo;
        public BussinessLayer(Database repo)
        {
            _repo = repo;
        }

        public TaskItem AddTask(TaskItem task)
        {
            return _repo.AddTask(task);
        }

        public List<TaskItem> GetAllTasks()
        {
            return _repo.GetAllTasks();
        }

        public TaskItem GetTask(int id)
        {
            return _repo.GetTaskById(id);
        }

        public TaskItem RemoveTask(TaskItem task)
        {
            return _repo.RemoveTask(task);
        }

        public TaskItem UpdateTask(TaskItem task)
        {
            return _repo.UpdateTaskStatus(task);
        }
    }
}
