using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPART3
{
    class Task
    {
        
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime? ReminderDate { get; set; }
            public bool IsCompleted { get; set; }

            public override string ToString()
            {
                return $"{Title} - {(IsCompleted ? "Completed" : "Pending")}" +
                       (ReminderDate.HasValue ? $" (Reminder: {ReminderDate.Value.ToShortDateString()})" : "");
            }
        }

    }

