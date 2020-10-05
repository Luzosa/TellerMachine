using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTellerMachine
{
    public class Bank
    {
        private string name;
        private Machine bankMachine;
        private int machineID;

        public int MachineID
        {
            get { return machineID; }
            set { machineID = value; }
        }


        public Machine BankMachine
        {
            get { return bankMachine; }
            set { bankMachine = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Bank()
        {
            
        }

        public string InitBank(string name)
        {
            if(name != null && name != "")
            {
                Name = name;
                return Name;
            }
            else
            {
                throw new ArgumentException("Pls write a name", "Name");
            }
            
        }

        public Machine GetMachine(Machine machine, int id)
        {
            BankMachine = machine;
            MachineID = id;
            return BankMachine;
        }
    }
}
