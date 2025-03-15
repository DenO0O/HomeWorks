using System;
using System.Text.RegularExpressions;

namespace Task6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Составить регулярное выражение для проверки корректности пароля. Пароль должен состоять минимум из 14 символов
            //и иметь в составе минимум одну цифру, заглавную букву, строчную букву и специальный символ из набора !#;%:?*.
            //Запрашивать у пользователя пароль до тех пор, пока он не введет пароль, удовлетворяющий регулярному выражению.

            string pass = "";
            bool isPassIncorrect = true;
            //Т.к. по заданию требуется одно выражение, то выражение такое:
            Regex regex = new Regex(@"^((?=.[0-9])(?=.[a-zа-я])(?=.[A-ZА-Я])(?=.[!#;%:\?*])){14,}$");

            //Если не выходить за рамки информации данной на занятии, то потребуется несколько отдельных проверок как ниже:
            Regex regexNum = new Regex(@"^.*[0-9].*$"); //наличие цифр
            Regex regexBigLetter = new Regex(@"^.*[A-ZА-Я].*$"); //наличие заглавных букв
            Regex regexSmlLetter = new Regex(@"^.*[a-zа-я].*$"); //наличие строчных букв
            Regex regexSimbols = new Regex(@"^.*[!#;%:\?*].*$"); //наличие символов
            Regex regexLenght = new Regex(@"^.{14,}$"); //длина не менее 14 символов

            while (isPassIncorrect)
            {
                Console.Write("Пароль: ");
                pass = Console.ReadLine();

                //Проверяем совпадение со всеми
                if (regexNum.IsMatch(pass) &&
                    regexBigLetter.IsMatch(pass) &&
                    regexSmlLetter.IsMatch(pass) &&
                    regexSimbols.IsMatch(pass) &&
                    regexLenght.IsMatch(pass)) break;
            }
            Console.WriteLine("Пароль корректен");
            Console.ReadKey();
        }
    }
}
