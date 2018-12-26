using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNews
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new NewsContext())
            {
                //var user = new User() { Id = 1, Login = "Dias" };
                // var comm
                var user2 = new User() { Id = 2, Login = "Dias", Comments = new List<Comment> { new Comment { Id = 1, CommentBody = "comment" } } };
                var news = new News() { Id = 1, Headline = "Something", Lead = "Som", Body = "dhdhfghfghdfhfdhf", Comments = user2.Comments};

                
                ctx.Users.Add(user2);
                ctx.News.Add(news);
                ctx.SaveChanges();
            }
        }
    }
}
