using System;
using System.Collections.Generic;
using ToDoPlanner.BL.Model;

namespace ToDoPlanner.BL.Controller
{
    public class UserController
    {
        public UserController CurrentUser { get; set; }

        private List<User> Users { get; }
        public UserController(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName))
                throw new ArgumentNullException("Имя пользователя не может быть пустым", nameof(userName));

            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException("Пароль не может быть пустым", nameof(password));

            Users = GetListUsers();
        }

        private List<User> GetListUsers()
        {
            return new List<User>();
        }
    }
}
