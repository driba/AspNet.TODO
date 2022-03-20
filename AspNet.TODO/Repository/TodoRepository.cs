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
            }
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
                Name = "Pošalji mail",
                Deadline = DateTime.Now
            };

            Todo task3 = new Todo()
            {
                Id = 3,
                Name = "Kupi poklon mami",
                Deadline = DateTime.Now
            };

            Todo task4 = new Todo()
            {
                Id = 5,
                Name = "Predaj ispit modula 8 u ponedjeljak do 15h",
                Deadline = new DateTime(2022, 3, 21)
            };

            Todo task5 = new Todo()
            {
                Id = 8,
                Name = "Godišnji!",
                Deadline = new DateTime(2022, 7, 1)
            };

            todo_list.Add(task1);
            todo_list.Add(task2);
            todo_list.Add(task3);
            todo_list.Add(task4);
            todo_list.Add(task5);
        }
    }
}
