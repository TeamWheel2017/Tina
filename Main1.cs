using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosersBasic
{
    class Main1
    {
        public void CheckTurns()
        {

        }

        static void Main(string[] args)
        {
            J jay = new J(3);
            //J jay2 = new J(1);
            Scavenger scavenger1 = new Scavenger(1);
            //Scavenger scavenger2 = new Scavenger(1);
            //Scavenger scavenger3 = new Scavenger(1);
            jay.Skill1(scavenger1);
            scavenger1.WriteHealth();
            jay.Stat();
            //jay.Skill1(jay2);
        }
    }
}
