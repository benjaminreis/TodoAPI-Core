using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TodoAPI.Models;


namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {

        private TodoAPI.Factory _Factory = new TodoAPI.Factory();
        //private readonly TodoContext _context;

        public TodoController()
        {
            //_context = context;

            //if (_context.TodoItems.Count() == 0)
            //{
            //    // Create a new TodoItem if collection is empty,
            //    // which means you can't delete all TodoItems.
            //    _context.TodoItems.Add(new TodoItem { Name = "Item1" });
            //    _context.SaveChanges();
            //}
        }


        [HttpGet("GetAll")]
        public List<TodoItem> GetAll()
        {

            return _Factory.TodoManager.GetAllTodoItems();
        }

        [HttpGet("{id}")]
        public ActionResult<TodoItem> GetById(int id)
        {
            var temp = new TodoItem(id, "test ben5000", true);
            return temp;
        }


        [HttpPost]
        public TodoItem Save(TodoItem todoItem)
        {
            return new TodoItem(999, "", true);
        }


        //TODO BEN
        //For more complex API's with larger datasets, id implement some searching functionality.
        //For larger data sets, a 'getall" would break everything.
        //we need a search to narrow down.
    }
}