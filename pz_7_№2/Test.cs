using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_7__2
{
    class Test
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();//издатель
            Subscriber subscriber1 = new Subscriber("Олег Монгол");//достойный
            Subscriber subscriber2 = new Subscriber("Мурад Легенда");//легенда
            publisher.AddSubscriber(subscriber1);//плюс один
            publisher.AddSubscriber(subscriber2);//плюс ещё один
            publisher.Discount = "5% на б/у трусы не стираные"; // новая скидка
            publisher.Discount = "10% на любые яблоки"; // еще одна скидка
            publisher.Discount = "100% я предпочитаю не говорить на языке, которого не знаю, но иногда..."; // это не скидка
            Console.ReadKey();
        }
    }
}
