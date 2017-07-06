using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosersBasic
{
    class EnemyCharacter : Character
    {
        public EnemyCharacter(string name, string type, int level, int maxHealth, int maxMana, int adDef, int apDef, int ad, int ap, int critRate, int critDamage, int defBreak,
            int speed, int accuracy, int dodge, int stunResist, int burnResist, int electroResist, int maxHealthPerLevel, int maxManaPerLevel, int adDefPerLevel,
            int apDefPerLevel, int adPerLevel, int apPerLevel, int critRatePerLevel, int critDamagePerLevel, int defBreakPerLevel, int speedPerLevel,
            int accuracyPerLevel, int dodgePerLevel, int stunResistPerLevel, int burnResistPerLevel, int electroResistPerLevel) : base(name, type, level, maxHealth, maxMana,
            adDef, apDef, ad, ap, critRate, critDamage, defBreak, speed, accuracy, dodge, stunResist, burnResist, electroResist, maxHealthPerLevel, maxManaPerLevel,
            adDefPerLevel, apDefPerLevel, adPerLevel, apPerLevel, critRatePerLevel, critDamagePerLevel, defBreakPerLevel, speedPerLevel, accuracyPerLevel,
            dodgePerLevel, stunResistPerLevel, burnResistPerLevel, electroResistPerLevel)
        {
            this.SetAlly(false);
        }

    }
}
