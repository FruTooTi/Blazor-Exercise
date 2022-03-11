using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TangyWeb_Models
{
    public class Car
    {
        public int id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime Date { get; set; }
    }

    public static class CarList
    {
        public static List<Car> Cars { get; set; } = new List<Car>
        {
            new Car{id = 1, Brand="BMW", Model="M3", Date=new DateTime(2005, 04, 16)},
            new Car{id = 2, Brand="Nissan", Model="350Z", Date=new DateTime(2002, 03, 22)},
            new Car{id = 3, Brand="Chevrolet", Model="Camaro", Date=new DateTime(2008, 11, 08)}
        };
    }
}
