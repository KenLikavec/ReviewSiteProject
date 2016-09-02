using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCReviewSiteProject.Models
{
    public class Review
    {
        private string title;
        private string content;
        //private string publishDate;

        [Key]

        //this is the ID
        public int recordNum { get; set; }

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public string Content
        {
            get { return this.content; }
            set { this.content = value; }
        }

        //public string PublishDate
        //{
        //    get { return this.publishDate; }
        //    set { this.publishDate = value; }
        //}

        private DateTime? publishDate;
        public DateTime PublishDate
        {
            get { return publishDate ?? DateTime.Now; }
            set { publishDate = value; }
        }



        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }





    }
}