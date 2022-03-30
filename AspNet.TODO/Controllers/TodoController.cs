using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AspNet.TODO.Repository;
using AspNet.TODO.Models;

namespace AspNet.TODO.Controllers
{
    public class TodoController : Controller
    {
        // Repository object
        TodoRepository _todoRepo;

        // Constructor
        public TodoController()
        {
            _todoRepo = new TodoRepository();
        }
        // GET: TodoController
        public ActionResult Index()
        {
            List<Todo> model = _todoRepo.OrderListByImportance();
            
            return View(model);
        }

        // GET: TodoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TodoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TodoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Todo new_todo)
        {          
            try
            {
                new_todo.Id = _todoRepo.GetList().Max(t => t.Id) + 1;
                _todoRepo.CreateNewList(new_todo);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TodoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TodoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TodoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TodoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
