using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int CategoryId {  get; set; }
    }

    public class ProductCreateDTO
    {
        public string? Name { get; set; }
        public int CategoryId { get; set; }
    }

    
}
