using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTest
{
    public class TestClass
    {
        public static bool Validate(string FirstName, string LastName,  string Passport, string Phone, string Mail, string Login, string Password)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(FirstName))
            {
                errors.AppendLine("\nНаименование - Поле не заполнено");
            }

            if (FirstName.Length > 50)
            {
                errors.AppendLine("\nНаименование - Кол-во символов превышает допустимое");
            }

            if (string.IsNullOrWhiteSpace(LastName))
            {
                errors.AppendLine("\nНаименование - Поле не заполнено");
            }

            if (LastName.Length > 50)
            {
                errors.AppendLine("\nНаименование - Кол-во символов превышает допустимое");
            }

            

            //Passport
            if (Passport.Length != 10)
            {
                errors.AppendLine("\nНомер паспорта -Номер паспорта введен неправильно");
            }

            //Phone
            if (string.IsNullOrWhiteSpace(Phone))
            {
                errors.AppendLine("\nНомер телефона - Поле не заполнено");
            }

            if (Phone.Intersect("\n+").Count() == 0)
            {
                if (Phone.Length != 11)
                {
                    errors.AppendLine("\nНомер телефона - Номер телефона введен неправильно");
                }
            }
            else
            {
                if (Phone.Length != 12)
                {
                    errors.AppendLine("\nНомер телефона -Номер телефона введен неправильно");
                }
            }

            //Mail
            

            if (string.IsNullOrWhiteSpace(Mail))
            {
                errors.AppendLine("\nПочта - Поле не заполнено");
            }
            if (Mail.Length > 55)
            {
                errors.AppendLine("\nПочта - Кол-во знаков превышает допустимое");
            }

            if (Mail.Intersect("\n@").Count() == 0)
            {
                errors.AppendLine("\nПочта - Укажите точный адрес эл. почты");
            }

            //Login
            if (string.IsNullOrWhiteSpace(Login))
            {
                errors.AppendLine("\nНаименование - Поле не заполнено");
            }

            if (Login.Length > 50)
            {
                errors.AppendLine("\nНаименование - Кол-во символов превышает допустимое");
            }

            //Passport
            if (string.IsNullOrWhiteSpace(Password))
            {
                errors.AppendLine("\nНаименование - Поле не заполнено");
            }

            if (Password.Length > 50)
            {
                errors.AppendLine("\nНаименование - Кол-во символов превышает допустимое");
            }

            //finish
            if (errors.Length > 0)
            {
                Errors = errors.ToString();
                return false;
            }

            return true;
        }
        public static string Errors { get; set; }
    }
}
