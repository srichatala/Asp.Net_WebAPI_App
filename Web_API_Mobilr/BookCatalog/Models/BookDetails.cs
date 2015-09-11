using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCatalog.Models
{
    public class BookDetails
    {
        public String Id { get; set; }
        public String Title { get; set; }
        public String Author { get; set; }
        public String Genre { get; set; }
        public Decimal Price { get; set; }
        public DateTime PublishDate { get; set; }
        public String Description { get; set; }
    }
}
