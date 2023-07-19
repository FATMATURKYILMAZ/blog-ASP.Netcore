﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blogSitesi.Entity.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}