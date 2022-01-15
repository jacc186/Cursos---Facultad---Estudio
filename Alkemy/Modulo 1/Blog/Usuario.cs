using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    public  class Usuario
    {
        [Key]
        private int id;
        private string name;
        private string password;
        private string email;
        private ICollection<Posts> posts;
        private ICollection<Comments> comments;

        public Usuario(int id, string name, string password, string email)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.email = email;
        }

        public int Id { get => id;}
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public ICollection<Posts> Posts { get => posts; set => posts = value; }
        public ICollection<Comments> Comments { get => comments; set => comments = value; }
    }
}
