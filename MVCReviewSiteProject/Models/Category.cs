using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCReviewSiteProject.Models
{
    public class Category
    {

        private string id;

        [Key]
        public int recordNum { get; set; }

        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }


        public virtual ICollection<Review> Reviews { get; set; }
        public string Name { get; set; }








    }
}