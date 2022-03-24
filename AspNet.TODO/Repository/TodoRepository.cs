using AspNet.TODO.Models; 

namespace AspNet.TODO.Repository
{
    public class TodoRepository
    {
        private List<Todo> todo_list;

        public TodoRepository()
        {
            if (todo_list == null)
            {
                todo_list = new List<Todo>();
                SimulateData();
            }
        }

        public List<Todo> GetList()
        {
            return todo_list;
        }

        public List<Todo> OrderListByImportance()
        {
            var sorted_list = todo_list.OrderBy(a => (a.Deadline - DateTime.Now).TotalDays).OrderBy(a => a.IsDone).ToList();
            return sorted_list;
        }

        private void SimulateData()
        {
            Todo task1 = new Todo()
            {
                Id = 1,
                Name = "Planiraj tjedni šoping",
                Deadline = DateTime.Now
            };

            Todo task2 = new Todo()
            {
                Id = 2,
                Name = "Traži posao u IT-u",
                Deadline = new DateTime(2022, 6, 1),
                IsDone = false
            };

            Todo task3 = new Todo()
            {
                Id = 3,
                Name = "Provjeri za sistematski na RTL-u",
                Deadline = new DateTime(2022, 4, 5),
                IsDone = false
            };

            Todo task4 = new Todo()
            {
                Id = 5,
                Name = "Napiši diplomski.. barem nešto",
                Deadline = new DateTime(2022, 4, 15),
                IsDone = false
            };

            Todo task5 = new Todo()
            {
                Id = 8,
                Name = "Pazi! Aprililili... ne vjeruj nikome",
                Deadline = new DateTime(2022, 4, 1)
            };

            Todo task6 = new Todo()
            {
                Id = 9,
                Name = "Predaj ispit za modul 8",
                Deadline = new DateTime(2022, 3, 21),
                IsDone = true
            };

            todo_list.Add(task1);
            todo_list.Add(task2);
            todo_list.Add(task3);
            todo_list.Add(task4);
            todo_list.Add(task5);
            todo_list.Add(task6);
        }
    }
}
