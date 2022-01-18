using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    public class Posts
    {
        private int postId;
        private string title;
        private DateTime date;
        private string content;
        private int userId;

        public Posts(string title, DateTime date, string content, int userId)
        {
            this.title = title;
            this.date = date;
            this.content = content;
            this.userId = userId;
        }
        [Key]
        public int PostId { get => postId; set => postId = value; }
        public string Title { get => title; set => title = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Content { get => content; set => content = value; }
        public int UserId { get => userId; set => userId = value; }
    }
}
