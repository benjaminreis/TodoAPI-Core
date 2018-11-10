using System;
using System.Collections.Generic;

namespace TodoAPI.Managers
{
    internal class TodoManager
    {
        private Factory _Factory;
        internal TodoManager(Factory Factory)
        {
            _Factory = Factory;
        }


        internal Models.TodoItem GetTodoItem(int ID)
        {
            return _Factory.TodoData.GetTodoItem(ID);
        }

        internal List<Models.TodoItem> GetAllTodoItems()
        {
            return _Factory.TodoData.GetAllTodoItems();
        }

        internal Models.TodoItem SaveTodoItem(Models.TodoItem todoItem)
        {
            if (!_Factory.TodoEngine.ValidateTodoItem(todoItem))
            {
                todoItem.Success = false;
                return todoItem;
            }




            return todoItem;
        }



    }
}
