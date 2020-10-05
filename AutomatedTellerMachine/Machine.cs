using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTellerMachine
{
    public class Machine
    {
        private CreditCard card;

        public CreditCard Card
        {
            get { return card; }
            set { card = value; }
        }

        public double Withdraw(CreditCard card, double amount)
        {
            if (card.Credit != 0 && amount <= card.Credit)
            {
                card.Credit = card.Credit - amount;
            }
            else
            {
                throw new ArgumentException("Amount Above Credits On Card", "Credit");
            }

            return card.Credit;
        }

        public double Deposit (CreditCard card, double amount)
        {

            if((card.Credit + amount) < card.MaxCredit)
            {
                card.Credit = card.Credit + amount;
            }
            else
            {
                throw new ArgumentException("Amount above maximum threshold", "Credit");
            }

            return card.Credit;
        }


    }
}
