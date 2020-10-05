using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTellerMachine
{
    public class CreditCard
    {
        private double credit;
        private double initCredit = 10000;

        public double InitCredit
        {
            get { return initCredit; }
            set { initCredit = value; }
        }


        public double Credit
        {
            get { return credit; }
            set { credit = value; }
        }


        private double maxCredit = 100000;

        public double MaxCredit
        {
            get { return maxCredit; }
            set { maxCredit = value; }
        }


        public CreditCard()
        {
            Credit = initCredit;

        }
    }


    
}
