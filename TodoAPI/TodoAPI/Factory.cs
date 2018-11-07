using System;
namespace TodoAPI
{
    internal class Factory
    {
        internal Factory()
        {
        }



        private Managers.TodoManager _TodoManager;

    internal Managers.TodoManager TodoManager
        {
            get {
                if (_TodoManager == null)
                {
                    _TodoManager = new Managers.TodoManager();
                }
                return _TodoManager;
            }
            set
            {
                _TodoManager = value;
            }
                
        }





    }
}
