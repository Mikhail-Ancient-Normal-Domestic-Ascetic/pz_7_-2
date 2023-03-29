using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_7__2
{
   public class Subscriber
    {
        private string name;

        public Subscriber(string name)
        {
            this.name = name;
        }
        public void Update(string discount)//получениe информации от издателя
        {
            Console.WriteLine("{0},новая новая скидка: {1}", name, discount);
        }
    }
}
