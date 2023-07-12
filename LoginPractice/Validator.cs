using LoginPractice.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPractice
{
    public static class Validator
    {
        public static bool ValidatePassword(string login, string password, string confermedPassword)
        {
            try
            {
                if (login.Length >= 20)
                {
                    throw new WrongLoginException("Логин должен быть меньше 20 символов");
                }
                if (login.Contains(" "))
                {
                    throw new WrongLoginException("Логин не должен содержать пробелы");
                }
                if (password.Length >= 20)
                {
                    throw new WrongPasswordException("Пароль должен быть меньше 20 символов");
                }
                if (password.Contains(" "))
                {
                    throw new WrongPasswordException("Пароль не должен содержать пробелы");
                }
                if (!password.Any(char.IsDigit))
                {
                    throw new WrongPasswordException("Пароль должен содержать хотябы одну цифру");
                }
                if (password != confermedPassword)
                {
                    throw new WrongPasswordException("Пароль не совпадает");
                }
            }
            catch (WrongLoginException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            catch (WrongPasswordException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }
    }
}
