using System;

namespace ToDoPlanner.BL.Model
{
    public class User
    {
        #region свойства
        public string Name { get; }
        public int Id { get; }
        private string Password { get; } // TODO: Придумать шифрование
        #endregion

        public User(string name, string password)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Имя пользователя не может быть пустым.", nameof(name));

            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException("Поле \"пароль\" не может быть пустым", nameof(password));

            Name = name;
            Password = password;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
