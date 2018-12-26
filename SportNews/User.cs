using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNews
{
    public class User
    {
        //public User()
        //{
        //    Comments = new Comment();
        //}
        public int Id { get; set; }
        public string Login { get; set; }
        
        public ICollection<Comment> Comments { get; set; }
    }
}
