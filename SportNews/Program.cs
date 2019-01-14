using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SportNews
{
    class Program
    {
        static public int LogInPage()
        {
            Clear();
            WriteLine(@"1. Вход
                        2. Регистрация");

            string menu = ReadLine();
            return Convert.ToInt32(menu);
        }

        static public int LogUpPage()
        {
            Clear();
            WriteLine(@"1. Логин
                        2. Пароль");

            string menu = ReadLine();
            return Convert.ToInt32(menu);
        }

        static public int MainPage()
        {
            Clear();
            WriteLine(@"1. Создать новость
                        2. Показать все новости");

            string menu = ReadLine();
            return Convert.ToInt32(menu);
        }
        
        static void Main(string[] args)
        {
            string ReadPassword()
            {
                string password = "";
                ConsoleKeyInfo info = ReadKey(true);
                while (info.Key != ConsoleKey.Enter)
                {
                    if (info.Key != ConsoleKey.Backspace)
                    {
                        Write("*");
                        password += info.KeyChar;
                    }
                    else if (info.Key == ConsoleKey.Backspace)
                    {
                        if (!string.IsNullOrEmpty(password))
                        {
                            password = password.Substring(0, password.Length - 1);
                            int pos = CursorLeft;
                            SetCursorPosition(pos - 1, CursorTop);
                            Write(" ");
                            SetCursorPosition(pos - 1, CursorTop);
                        }
                    }
                    info = ReadKey(true);
                }
                WriteLine();
                return password;
            }

            using (var ctx = new NewsContext())
            {
                //var user = new User() { Id = 1, Login = "Dias" };
                // var comm

                //var news = new News() { Id = 1, Headline = "Something", Lead = "Som", Body = "dhdhfghfghdfhfdhf" };
                //var user2 = new User() { Id = 2, Login = "Dias", Comments = new List<Comment> { new Comment { Id = 1, CommentBody = "comment", Login = "Madi" } }, News = new List<News> { news } };
                //var comment = new Comment() { Id = 1, Users = new List<User> { user2 }, Login = user2.Login, CommentBody = "commentBody"  };

                //var user = new User() { Id = 1, Login = "Dika", };
                

                
                //ctx.Users.Add(user2);
                //ctx.News.Add(news);
                //ctx.Comments.Add(comment);


                
                ctx.SaveChanges();
            }
        }
    }
}
