using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AspNet.TODO.Models
{
    public class Todo
    {
        [Key]
        [DisplayName("ID")]
        public int Id { get; set; }
        
        [Required]
        [DisplayName("Task")]
        public string Name { get; set; }

        [DisplayName("Deadline")]
        [DataType(DataType.Date)]
        public DateTime Deadline { get; set; }

        [DisplayName("Completion status")]
        public bool IsDone { get; set; } = false;
        public string ColorByImportance()
        {
            if (IsDone == true)
            {
                return "#5cb85c";  // success - green for done
            }
            else if ((Deadline - DateTime.Now).TotalDays < 2)
            {
                return "#d9534f"; // danger - red for under 2 days or past deadline
            }
            else if ((Deadline - DateTime.Now).TotalDays < 7)
            {
                return "#ffc107"; // warning - yellow for under 7 days
            }
            else
            {
                return "";
            }
        }
    }
}
