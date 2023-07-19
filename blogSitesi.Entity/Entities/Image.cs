using blogSitesi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blogSitesi.Entity.Entities
{
    public class Image:EntityBase
    {
        public Guid Id { get; set; }
        public string fileName { get; set; }
        public string fileType { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
