using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreData.Entyties
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(2000)]
        public string NameProduct { get; set; }
        public double Price { get; set; }
    }
}
