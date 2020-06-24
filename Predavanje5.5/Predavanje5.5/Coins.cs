using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje5._5
{
    
    public class Coins
    {
        private IUpdatableView frmView;
        public int NumCoins { get; private set; }
        public Coins() { }
        public Coins(IUpdatableView view, int n = 1)
        {
            frmView = view;
            if(n>=0)
            {
                NumCoins = n;
            }
        }

        public void addOne()
        {
            NumCoins++;
            frmView.UpdateView();
        }

        public void addTwo()
        {
            NumCoins += 2;
            frmView.UpdateView();
        }

        public void removeOne()
        {
            if(NumCoins>0)
            {
                NumCoins--;
                frmView.UpdateView();   
            }
        }

    }
}
