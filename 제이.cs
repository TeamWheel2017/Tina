using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosersBasic
{
    class J:PlayableCharacter
    {
        public J(int startLevel):base("제이", "파이터", startLevel, 100, 0, 20, 20, 20, 0, 5, 100, 0, 5, 90, 8, 40, 30, 30, 20, 0, 5,5,3,0,1,0,0,1,2,2,5,5,5)
        {
            Console.WriteLine("클로저 제이(레벨"+this.Level()+") 영입");
        }

        public override void PhasePowerRelease()
        {
            base.PhasePowerRelease();
            this.AddHealth(30);
        }

        public override void Passive()
        {

        }

        public override void Skill1(Character opponent)
        {
            if ((opponent != null) && (opponent.Ally() == false))
            {
                float damageRate = 2.8f;
                int additionalCritRate = 40;
                int additionalCritDamage = 0;
                int additionalDefBreak = 0;
                int additionalAccuracy = 0;
                int additionalStunRate = 80;
                int additionalBurnRate = 0;
                int additionalElectroRate = 0;
                bool mark = false;
                int addPhasePower = 5;
                int cost = 5;

                if (CheckHealthCost(cost) == true)
                {
                    Console.WriteLine(this.Name() + "가 " + opponent.Name() + "에게 음이온 펀치를 시전하였습니다");

                    Battle(damageRate, additionalCritRate, additionalCritDamage, additionalDefBreak, additionalAccuracy,
                        additionalStunRate, additionalBurnRate, additionalElectroRate, mark, opponent, addPhasePower, cost);

                    this.AddSpeed(3);
                }
            }
            else if (opponent.Ally() == true)
            {
                Console.WriteLine("이 스킬은 아군에게는 시전할 수 없습니다.");
            }
        }
        public override void Skill2()
        {
        }
        public override void Skill3()
        {
        }
        public override void Skill4()
        {
            base.Skill4();
        }
        public override void Skill5()
        {
            base.Skill5();
        }
        public override void Skill6()
        {
            base.Skill6();
        }
        public override void Skill7()
        {
            base.Skill7();
        }
        public override void Skill8()
        {
            base.Skill8();
        }
        public override void Ult1()
        {
            base.Ult1();
        }
        public override void Ult2()
        {
            base.Ult2();
        }
    }
}
