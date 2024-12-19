using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEducation301.EntityLayer.Concrete
{
    public class Customer
    {
        /*
          * SOLID Prensipleri
          *  SOLID, yazılım geliştirmede esnek, sürdürülebilir ve bakım dostu kod yazmayı sağlayan
          *  beş temel prensibi ifade eder. Bu prensipler, nesne yönelimli programlama (OOP)
          *  uygulamalarında kaliteli kod yazmak için rehberlik eder.
          *  Her harf, bir prensibi temsil eder:
          *  
          *  S - Single Responsibility Principle (SRP): Tek Sorumluluk İlkesi
          *  O - Open/Closed Principle (OCP): Açık/Kapalı İlkesi
          *  L - Liskov Substitution Principle (LSP): Liskov Yerine Geçme İlkesi
          *  I - Interface Segregation Principle (ISP): Arayüz Ayrımı İlkesi
          *  D - Dependency Inversion Principle (DIP): Bağımlılıkların Tersine Çevrilmesi İlkesi
         */

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerDistrict { get; set; }
        public string CustomerCity { get; set; }
        public List<Order> Orders { get; set; }
    }
}
