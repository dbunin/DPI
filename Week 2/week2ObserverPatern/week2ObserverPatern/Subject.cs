using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2ObserverPatern
{
    public class Subject
    {
        private List<ISubscriber> subscribers = new List<ISubscriber>();
        private List<string> Text = new List<string>();
        public void Subscribe(ISubscriber s)
        {
            subscribers.Add(s);
        }
        public void UnSubscribe(ISubscriber s)
        {
            subscribers.Remove(s);
        }
        public void Notify()
        {
            foreach (ISubscriber s in subscribers)
            {
                s.Update(this);
            }
        }
        public List<string> GetText()
        {
            return Text;
        }
        public void AddNews(string text)
        {
            Text.Add(text);
        }
    }
}
