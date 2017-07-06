using System;

namespace ClosersBasic
{
    class J:PlayableCharacter
    {
        public J():base("제이",1, 100, 0, 20, 20, 20, 0, 5, 100, 0, 5, 90, 8, 40, 30, 30, 20, 0, 5,5,3,0,1,0,0,1,2,2,5,5,5)
        {
            Console.WriteLine("클로저 제이 영입");
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
            if ((opponent != null) && (opponent.ally == false))
            {
                float damageRate = 0.8f;
                int cost = 5;
                int additionalCritRate = 0;
                int additionalCritDamage = 0;
                int additionalDefBreak = 0;
                int additionalAccuracy = 0;
                int additionalStunRate = 0;
                int additionalBurnRate = 0;
                int additionalElectroRate = 0;
                bool mark = false;
                int addPhasePower = 5;

                if(CheckHealthCost(cost)==true)
                {
                    Console.WriteLine(this.Name()+"가 " + opponent.Name() + "에게 음이온 펀치를 시전하였습니다");

                    Battle(damageRate, additionalCritRate, additionalCritDamage, additionalDefBreak, additionalAccuracy, 
                        additionalStunRate, additionalBurnRate, additionalElectroRate, mark, opponent, addPhasePower, cost);
                
                    this.AddSpeed(3);
                }
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
