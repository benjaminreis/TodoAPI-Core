using System;
using System.Collections.Generic;

namespace TodoAPI.Data
{
    internal static class TodoMockData
    {


        internal static List<Models.TodoItem> AllTodoData()
        {

            var todoItems = new List<Models.TodoItem>()
            {
              new Models.TodoItem(1, "Help with dishes", false),
              new Models.TodoItem(2, "mow yard", true),
                new Models.TodoItem(4, "sharpen pencils", false),
              new Models.TodoItem(10, "shuffle papers", false),
              new Models.TodoItem(11, "help kids with homework", false),
              new Models.TodoItem(12, "take nap", true),
              new Models.TodoItem(13, "play disc golf", false),
              new Models.TodoItem(20, "go for a run", true),
              new Models.TodoItem(21, "set coffee timer", true),
              new Models.TodoItem(22, "pick up floss from store", true)

            };

            return todoItems;
        }

    }
}
