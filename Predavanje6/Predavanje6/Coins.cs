using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje6
{
    [Serializable()]
    public class Coins
    {
        public int numCoins { get; set; }
        public Coins(int n=1)
        {
            if(n>0)
            {
                numCoins = n;
            }
        }
        public void addOne()
        {
            numCoins++;
        }
        public void removeOne()
        {
            if(numCoins>0)
            {
                numCoins--;
            }
        }
        public Coins(SerializationInfo info, StreamingContext ctxt)
        {
            numCoins = (int)info.GetValue("#Coins", typeof(int));
        }
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("#Coins", numCoins);
        }
    }
}
