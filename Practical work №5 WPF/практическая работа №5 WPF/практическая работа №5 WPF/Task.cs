using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практическая_работа__5_WPF
{
    public class Task
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public string Priority { get; set; }
        public Task(string title, string category, string priority)
        {
            Title = title;
            Category = category;
            Priority = priority;
        }
       
    }
}
