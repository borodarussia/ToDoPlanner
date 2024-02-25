using System.Collections.Generic;
using System.Linq;

namespace ToDoPlanner.BL.Controller.DB
{
    public class DBDataSaver : IDataSaver
    {
        public List<T> Load<T>() where T : class
        {
            using (var db = new ApplicationContext())
            {
                var result = db.Set<T>().Where(t => true).ToList();
                return result;
            }
        }

        public void Save<T>(List<T> items) where T : class
        {
            using (var db = new ApplicationContext())
            {
                db.Set<T>().AddRange(items);
                db.SaveChanges();
            }
        }
    }
}
