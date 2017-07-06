using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosersBasic
{
    class Scavenger:EnemyCharacter
    {
        static int count = 1;

        public Scavenger(int startLevel):base("스캐빈저","소형",startLevel,40,0,10,10,10, 0,5,100,0,5,85,10,20,20,20,10,0,3,3,3,0,1,0,0,1,2,2,4,4,4)
        {
            //스캐빈저 수 카운트
            if (this.Ally() == false)
            {
                string newName = this.Name() + count.ToString();
                this.SetName(newName);
                Console.WriteLine(newName +"(레벨"+this.Level()+") 등장!");
                count++;
            }

            this.SetExp(250);
        }
        
    }
}
