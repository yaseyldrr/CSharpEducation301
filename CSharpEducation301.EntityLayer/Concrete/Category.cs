using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEducation301.EntityLayer.Concrete
{
    public class Category
    {
        // Code-First Yaklaşımı,
        // Entity Framework (EF) gibi ORM (Object Relational Mapping)
        // araçlarında kullanılan bir geliştirme modelidir.

        /*
         * Field, Variable, Property 
         * 
         * int x; Field // doğrudan veri tutarlar
         * 
         * public int y {  get; set; } Property // kontrollü okuma, yazma
         * 
         * void Test()
        {
            int z; Variable // geçici verile
        }
         */

        // Primary Key olduğunu bu şekilde belirtiriz, isim aynı ve sonda Id kelimesi var.
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }

        public List<Product> Products { get; set; }
    }
}
