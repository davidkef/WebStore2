using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;


namespace WebStore.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}