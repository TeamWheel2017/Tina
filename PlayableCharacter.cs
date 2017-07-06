using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosersBasic
{
    abstract class PlayableCharacter:Character
    {
        public PlayableCharacter(string name, int level, int maxHealth, int maxMana, int adDef, int apDef, int ad, int ap, int critRate, int critDamage, int defBreak,
            int speed, int accuracy, int dodge, int stunResist, int burnResist, int electroResist, int maxHealthPerLevel, int maxManaPerLevel, int adDefPerLevel,
            int apDefPerLevel, int adPerLevel, int apPerLevel, int critRatePerLevel, int critDamagePerLevel, int defBreakPerLevel, int speedPerLevel,
            int accuracyPerLevel, int dodgePerLevel, int stunResistPerLevel, int burnResistPerLevel, int electroResistPerLevel) : base(name, null,level, maxHealth, maxMana,
            adDef, apDef, ad, ap, critRate, critDamage, defBreak, speed, accuracy, dodge, stunResist, burnResist, electroResist, maxHealthPerLevel, maxManaPerLevel,
            adDefPerLevel, apDefPerLevel, adPerLevel, apPerLevel, critRatePerLevel, critDamagePerLevel, defBreakPerLevel, speedPerLevel, accuracyPerLevel, 
            dodgePerLevel, stunResistPerLevel, burnResistPerLevel, electroResistPerLevel)
        {
            this.ally = true;
        }

        //위상력 개방
        public virtual void PhasePowerRelease()
        {
            this.AddAdByPercentage(0);
            this.AddApByPercentage(0);
            this.AddManaByPercentage(30);
        }

        //긴급 회피
        public void Evade()
        {
            this.StunFalse();
            this.BurnFalse();
            this.ElectroFalse();
        }

        public abstract void Passive();

        public abstract void Skill1(Character opponent);

        public abstract void Skill2();

        public abstract void Skill3();

        public virtual void Skill4()
        {

        }
        public virtual void Skill5()
        {

        }
        public virtual void Skill6()
        {

        }
        public virtual void Skill7()
        {

        }
        public virtual void Skill8()
        {

        }
        public virtual void Ult1()
        {

        }
        public virtual void Ult2()
        {

        }

    }
}
