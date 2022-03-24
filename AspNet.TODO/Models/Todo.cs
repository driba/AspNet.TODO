using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AspNet.TODO.Models
{
    public class Todo
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Task name")]
        public string Name { get; set; }

        [DisplayName("Deadline")]
        [DataType(DataType.Date)]
        public DateTime Deadline { get; set; }

        public bool IsDone { get; set; } = false;
        public string ColorByImportance()
        {
            if (IsDone == true)
            {
                return "#93c47d";  // green for done
            }
            else if ((Deadline - DateTime.Now).TotalDays < 2)
            {
                return "#e5a7a7"; // red for under 2 days or past deadline
            }
            else if ((Deadline - DateTime.Now).TotalDays < 7)
            {
                return "#e5e5a7"; // yellow for under 7 days
            }
            else
            {
                return "";
            }
        }
    }
}
