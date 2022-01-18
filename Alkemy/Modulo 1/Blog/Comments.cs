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
        private int commentId;
        private DateTime date;
        private string comment;
        private int userId;

        public Comments (DateTime date, string comment, int userId)
        {
            this.date = date;
            this.comment = comment;
            this.userId = userId;
        }
        [Key]
        public int CommentId { get => commentId; set => commentId = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Comment { get => comment; set => comment = value; }
        public int UserId { get => userId; set => userId = value; }
    }
}
