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
        [Key]
        private int postId;
        private string title;
        private DateTime date;
        private string content;
        private Usuario user;

        public Posts(string title, DateTime date, string content, Usuario user)
        {
            this.title = title;
            this.date = date;
            this.content = content;
            this.user = user;
        }

        public int PostId { get => postId;}
        public string Title { get => title; set => title = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Content { get => content; set => content = value; }
        internal Usuario User { get => user; set => user = value; }
    }
}
