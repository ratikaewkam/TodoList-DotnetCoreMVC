using Microsoft.AspNetCore.Mvc;
using TodoList_DotnetCoreMVC.Data;
using TodoList_DotnetCoreMVC.Models;

namespace TodoList_DotnetCoreMVC.Controllers
{
    public class TodoController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TodoController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Todo> todoList = _db.Todos;
            return View(todoList);
        }

        public IActionResult CreateTask()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateTask(Todo obj)
        {
            if (ModelState.IsValid)
            {
                _db.Todos.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult EditTask(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var todoFromDB = _db.Todos.Find(id);

            if (todoFromDB == null)
            {
                return NotFound();
            }

            return View(todoFromDB);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditTask(Todo obj)
        {
            if (ModelState.IsValid)
            {
                _db.Todos.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult DeleteTask(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var todoFromDB = _db.Todos.Find(id);

            if (todoFromDB == null)
            {
                return NotFound();
            }

            return View(todoFromDB);
        }

        [HttpPost, /*ActionName("Delete")*/]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Todos.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            _db.Todos.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
