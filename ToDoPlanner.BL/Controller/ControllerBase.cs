using System.Collections.Generic;
using ToDoPlanner.BL.Controller.DB;

namespace ToDoPlanner.BL.Controller
{
    public abstract class ControllerBase
    {
        private readonly IDataSaver _dataSaver = new DBDataSaver();

        protected void Save<T>(List<T> items) where T : class
        {
            _dataSaver.Save(items);
        }

        protected List<T> Load<T>() where T : class
        {
            return _dataSaver.Load<T>();
        }
    }
}
