using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace domain
{
    public class TextInfo
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string content;

        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        private DateTime create_time;

        public DateTime Create_time
        {
            get { return create_time; }
            set { create_time = value; }
        }

        ////额外属性
        //public int start { get; set; }
        //public int page_size { get; set; }
    }
}
