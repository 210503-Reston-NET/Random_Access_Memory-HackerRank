using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Models;
namespace RAMWebUI.Models
{
    public class TaskItemVM
    {
        public TaskItemVM() { 
        
        }
        public TaskItemVM(TaskItem tItem)
        {
            TaskID = tItem.TaskID;
            Title = tItem.Title;
            Description = tItem.Description;
            Created = tItem.Created;
            Finished = tItem.Finished;
            stage = tItem.stage;
            priority = tItem.priority;
        }
        public int TaskID { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z ]{4,}$", ErrorMessage = "Letters only please!")]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Finished { get; set; }
        public int stage { get; set; }
        [Required]
        public int priority { get; set; }

    }
}
