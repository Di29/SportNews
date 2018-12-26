using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNews
{
    public class News
    {
        //public News()
        //{
        //    Authors = new List<User>();
        //}

        public int Id { get; set; }
        public string Headline { get; set; }
        public string Lead { get; set; }
        public string Body { get; set; }
        //public string Author { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public ICollection<User> Authors { get; set; }
    }
}
