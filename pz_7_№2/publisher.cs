using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_7__2
{
    public class Publisher
    {
        private List<Subscriber> subscribers = new List<Subscriber>();
        private string discount;

        public string Discount
        {
            get { return discount; }
            set
            {
                if (value != discount)
                {
                    discount = value;
                    OpovescheniyeSubscribers();
                }
            }
        }
        public void AddSubscriber(Subscriber subscriber)
        {
            subscribers.Add(subscriber);
        }
        public void RemoveSubscriber(Subscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }
        private void OpovescheniyeSubscribers()
        {
            foreach (Subscriber subscriber in subscribers)
            {
                subscriber.Update(Discount);
            }
        }
    }
}
