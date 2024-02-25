using System;
using System.Collections.Generic;
using System.Linq;
using ToDoPlanner.BL.Model;

namespace ToDoPlanner.BL.Controller
{
    public class UserController : ControllerBase
    {
        public User CurrentUser { get; set; }

        private List<User> Users { get; }

        public UserController(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName))
                throw new ArgumentNullException("Имя пользователя не может быть пустым", nameof(userName));

            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException("Пароль не может быть пустым", nameof(password));

            Users = GetListUsers();

            CurrentUser = Users.SingleOrDefault(u =>
            u.Name == userName && u.Password == password);
        }

        private List<User> GetListUsers()
        {
            return Load<User>() ?? new List<User>();
        }
    }
}
