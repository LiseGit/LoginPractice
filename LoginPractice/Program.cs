using LoginPractice.Exceptions;
using System;

namespace LoginPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string login, password, confermedPassword;
            do
            {
                Console.Write("Логин - ");
                login = Console.ReadLine();
                Console.Write("Пароль - ");
                password = Console.ReadLine();
                Console.Write("Подтвердите пароль - ");
                confermedPassword = Console.ReadLine();
            } while (!Validator.ValidatePassword(login, password, confermedPassword));
        }
    }
}
