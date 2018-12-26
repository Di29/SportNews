using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNews
{
    public class Comment
    {
        public Comment()
        {

        }
        public int Id {get;set;}
        public string Login { get; set; }
        public string CommentBody { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
