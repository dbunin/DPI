using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2ObserverPatern
{
    public interface ISubscriber
    {
        void Update(Subject a);
    }
}
