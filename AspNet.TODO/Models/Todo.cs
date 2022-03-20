using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AspNet.TODO.Models
{
    public class Todo
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Naziv zadatka")]
        public string Name { get; set; }

        [DisplayName("Rok zadatka")]
        //[DataType(DataType.Date)]
        public DateTime Deadline { get; set; }

        public string Status { get; set; }

    }
}
