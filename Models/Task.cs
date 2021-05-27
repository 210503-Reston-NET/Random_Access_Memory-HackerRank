using System;

namespace Models
{
    public class TaskItem
    {
        public TaskItem(){
            
        }

            public int TaskID { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime Created { get; set; }          
            public DateTime Finished { get; set; }
            public int stage { get; set; }
            public int priority { get; set; }


        


    }
}
