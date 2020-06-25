using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje6
{
    [Serializable]
    public class Bills
    {
        public int numBills { get; set; }
        public Bills(int n = 1)
        {
            if (n > 0)
            {
                numBills = n;
            }
        }
        public void addOne()
        {
            numBills++;
        }
        public void removeOne()
        {
            if (numBills > 0)
            {
                numBills--;
            }
        }
        public Bills(SerializationInfo info, StreamingContext ctxt)
        {
            numBills = (int)info.GetValue("#Bills", typeof(int));
        }
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("#Bills", numBills);
        }
    }
}
