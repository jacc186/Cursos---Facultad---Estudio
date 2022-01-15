using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    public class Comments
    {
        [Key]
        private int commentId;
        private DateTime date;
        private string comment;
        private Usuario user;

        public Comments (DateTime date, string comment, Usuario user)
        {
            this.date = date;
            this.comment = comment;
            this.user = user;
        }

        public int Id { get => commentId;}
        public DateTime Date { get => date; set => date = value; }
        public string Comment { get => comment; set => comment = value; }
        internal Usuario User { get => user; set => user = value; }
    }
}
