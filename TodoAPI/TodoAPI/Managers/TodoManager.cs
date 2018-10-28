using System;
namespace TodoAPI.Managers
{
    internal class TodoManager
    {
        internal TodoManager()
        {
        }

        private Data.TodoData TodoData = new Data.TodoData();

        internal Models.TodoItem GetTodoItem(int ID)
        {
            return TodoData.GetTodoItem(ID);
        }
    }
}
