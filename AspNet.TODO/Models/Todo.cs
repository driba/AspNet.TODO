namespace AspNet.TODO.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Deadline { get; set; }
        public bool Status { get; set; }

    }
}
