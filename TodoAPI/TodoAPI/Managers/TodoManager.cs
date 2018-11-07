using System;
namespace TodoAPI.Managers
{
    internal class TodoManager
    {
        private Factory _Factory;
        internal TodoManager(Factory Factory)
        {
            _Factory = Factory;
        }

        private Data.TodoData TodoData = new Data.TodoData();

        internal Models.TodoItem GetTodoItem(int ID)
        {
            return TodoData.GetTodoItem(ID);
        }
    }
}
