using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Product
    {
        //code first yapı entity katmanında class oluşturdum.
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
    }
}
