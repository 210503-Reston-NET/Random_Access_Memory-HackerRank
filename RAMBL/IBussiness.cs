using System;
using System.Collections.Generic;
using Data;
using Models;

namespace RAMBL
{
    public interface IBussiness
    {
        TaskItem GetTask(int id);
        TaskItem AddTask(TaskItem task);
        TaskItem RemoveTask(TaskItem task);
        TaskItem UpdateTask(TaskItem task);
        List<TaskItem> GetAllTasks();
    }
}
