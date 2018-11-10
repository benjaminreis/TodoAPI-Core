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
            get 
            {
                if (_TodoManager == null)
                {
                    _TodoManager = new Managers.TodoManager(this);
                }
                return _TodoManager;
            }
            //set
            //{
            //    _TodoManager = value;
            //}
                
        }


        private Data.TodoData _TodoData;
        internal Data.TodoData TodoData
        {
            get 
            {
                if (_TodoData == null)
                {
                    _TodoData = new Data.TodoData(this);
                }
                return _TodoData;
            }
            //set
            //{
            //    _TodoData = value;
            //}
        }

        private Engines.TodoEngine _TodoEngine;
        internal Engines.TodoEngine TodoEngine
        {
            get
            {
                if (_TodoEngine == null)
                {
                    _TodoEngine = new Engines.TodoEngine(this);

                }
                return _TodoEngine;
            }
            //set
            //{
            //    _TodoEngine = value;
            //}
        }


    }
}
