using System;
namespace TodoAPI.Engines
{
    internal class TodoEngine
    {
        private Factory _Factory;
        internal TodoEngine(Factory factory)
        {
            _Factory = factory;
        }




        internal bool ValidateTodoItem(Models.TodoItem todoItem)
        {
            var IsValid = true;


            if (string.IsNullOrWhiteSpace(todoItem.Name))
            {
                IsValid = false;
            }

            //Add any other validation here.

            return IsValid;
        }

    }
}
