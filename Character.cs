using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosersBasic
{
    abstract class Character
    {
        bool ally;//true면 아군
        bool stun = false;//기절 상태
        bool burn = false;//화염피해받는중
        bool electro = false;//전기피해받는중
        bool marked = false;//표식 찍힘
        
        string name = null;//이름
        string type;//타입
        int level=1;//초기 레벨
        int exp;//경험치
        int maxHealth;//최대체력
        int health;//현재체력
        int maxMana;//최대마나
        int mana;//현재마나
        int phasePower = 0;//위상력
        int adDef;//물방
        int apDef;//마방
        int ad;//물공
        int ap;//마공
        int critRate;//치명타 확률
        int critDamage = 100;//치명타 피해
        int defBreak = 0;//방어 무시
        int speed;//속도
        int accuracy;//명중률
        int dodge;//회피율
        int stunResist;//기절저항
        int burnResist;//화염피해저항
        int electroResist;//전기피해저항
        int stunRate = 0;//적을 기절시킬 기본 확률
        int burnRate = 0;
        int electroRate = 0;

        //레벨업 당 스텟 증가량
        int maxHealthPerLevel;
        int maxManaPerLevel;
        int adDefPerLevel;
        int apDefPerLevel;
        int adPerLevel;
        int apPerLevel;
        int critRatePerLevel;
        int critDamagePerLevel;
        int defBreakPerLevel;
        int speedPerLevel;
        int accuracyPerLevel;
        int dodgePerLevel;
        int stunResistPerLevel;
        int burnResistPerLevel;
        int electroResistPerLevel;

        public Character(string name, string type, int level, int maxHealth, int maxMana, int adDef, int apDef, int ad, int ap, int critRate, int critDamage, int defBreak,
            int speed, int accuracy, int dodge, int stunResist, int burnResist, int electroResist, int maxHealthPerLevel, int maxManaPerLevel, int adDefPerLevel,
            int apDefPerLevel, int adPerLevel, int apPerLevel, int critRatePerLevel, int critDamagePerLevel, int defBreakPerLevel, int speedPerLevel,
            int accuracyPerLevel, int dodgePerLevel, int stunResistPerLevel, int burnResistPerLevel, int electroResistPerLevel)
        {
            //기본 스텟
            this.name = name;
            this.type = type;
            this.exp = 0;
            this.maxHealth = maxHealth;
            this.health = maxHealth;
            this.maxMana = maxMana;
            this.mana = maxMana;
            this.adDef = adDef;
            this.apDef = apDef;
            this.ad = ad;
            this.ap = ap;
            this.critRate = critRate;
            this.critDamage = critDamage;
            this.defBreak = defBreak;
            this.speed = speed;
            this.accuracy = accuracy;
            this.dodge = dodge;
            this.stunResist = stunResist;
            this.burnResist = burnResist;
            this.electroResist = electroResist;

            //레벨업 당 스텟 증가량
            this.maxHealthPerLevel = maxHealthPerLevel;
            this.maxManaPerLevel = maxManaPerLevel;
            this.adDefPerLevel = adDefPerLevel;
            this.apDefPerLevel = apDefPerLevel;
            this.adPerLevel = adPerLevel;
            this.apPerLevel = apPerLevel;
            this.critRatePerLevel = critRatePerLevel;
            this.critDamagePerLevel = critDamagePerLevel;
            this.defBreakPerLevel = defBreakPerLevel;
            this.speedPerLevel = speedPerLevel;
            this.accuracyPerLevel = accuracyPerLevel;
            this.dodgePerLevel = dodgePerLevel;
            this.stunResistPerLevel = stunResistPerLevel;
            this.burnResistPerLevel = burnResistPerLevel;
            this.electroResistPerLevel = electroResistPerLevel;

            if(level>1)//인스턴스 생성 레벨이 1보다 높을 경우 스탯값 보정
            {
                this.SetLevel(level);
            }
        }

        //레벨업 함수
        public void LevelUp()
        {
            this.level += 1;
            Console.WriteLine(this.name + "가 " + this.level + "레벨로 레벨업했습니다!");
            this.SubExp(100);
            this.AddMaxHealth(maxHealthPerLevel);
            this.SetHealth(maxHealth);
            this.AddMaxMana(maxManaPerLevel);
            this.SetMana(maxMana);
            this.AddAdDef(adDefPerLevel);
            this.AddApDef(apDefPerLevel);
            this.AddAd(adPerLevel);
            this.AddAp(apPerLevel);
            this.AddCritRate(critRatePerLevel);
            this.AddCritDamage(critDamagePerLevel);
            this.AddDefBreak(defBreakPerLevel);
            this.AddSpeed(speedPerLevel);
            this.AddAccuracy(accuracyPerLevel);
            this.AddDodge(dodgePerLevel);
            this.AddStunResist(stunResistPerLevel);
            this.AddBurnResist(burnResistPerLevel);
            this.AddElectroResist(electroResistPerLevel);
        }

        //스탯 변경 함수
        public void AddExp(int exp)
        {
            this.exp += exp;
        }
        public void AddMaxHealth(int maxHealth)
        {
            this.maxHealth += maxHealth;
        }
        public void AddHealth(int health)
        {
            this.health += health;
            if (this.health > maxHealth)
            {
                this.health = maxHealth;
            }
        }
        public void AddMaxMana(int maxMana)
        {
            this.maxMana += maxMana;
        }
        public void AddMana(int mana)
        {
            this.mana += mana;
            if (this.mana > maxMana)
            {
                this.mana = maxMana;
            }
        }
        public void AddPhasePower(int phasePower)
        {
            this.phasePower += phasePower;
            if (this.phasePower > 100)
            {
                this.phasePower = 100;
            }
        }
        public void AddAdDef(int adDef)
        {
            this.adDef += adDef;
        }
        public void AddApDef(int apDef)
        {
            this.apDef += apDef;
        }
        public void AddAd(int ad)
        {
            this.ad += ad;
        }
        public void AddAp(int ap)
        {
            this.ap += ap;
        }
        public void AddCritRate(int critRate)
        {
            this.critRate += critRate;
            if (this.critRate > 100)
            {
                this.critRate = 100;
            }
        }
        public void AddCritDamage(int critDamage)
        {
            this.critDamage += critDamage;
        }
        public void AddDefBreak(int defBreak)
        {
            this.defBreak += defBreak;
        }
        public void AddSpeed(int speed)
        {
            this.speed += speed;
        }
        public void AddAccuracy(int accuracy)
        {
            this.accuracy += accuracy;
        }
        public void AddDodge(int dodge)
        {
            this.dodge += dodge;
        }
        public void AddStunResist(int stunResist)
        {
            this.stunResist += stunResist;
        }
        public void AddBurnResist(int burnResist)
        {
            this.burnResist += burnResist;
        }
        public void AddElectroResist(int electroResist)
        {
            this.electroResist += electroResist;
        }
        public void AddStunRate(int stunRate)
        {
            this.stunRate += stunRate;
        }
        public void AddBurnRate(int burnRate)
        {
            this.burnRate += burnRate;
        }
        public void AddElectroRate(int electroRate)
        {
            this.electroRate += electroRate;
        }

        public void SubExp(int exp)
        {
            this.exp -= exp;
            if(this.exp<0)
            {
                this.exp = 0;
            }
        }
        public void SubMaxHealth(int maxHealth)
        {
            this.maxHealth -= maxHealth;
            if (this.maxHealth < health)
            {
                this.health = maxHealth;
            }
        }
        public void SubHealth(int health)
        {
            this.health -= health;
            if (this.health < 0)
            {
                this.health = 0;
            }
        }
        public void SubMaxMana(int maxMana)
        {
            this.maxMana -= maxMana;
            if (this.maxMana < mana)
            {
                this.mana = maxMana;
            }
        }
        public void SubMana(int mana)
        {
            this.mana -= mana;
            if (this.mana < 0)
            {
                this.mana = 0;
            }
        }
        public void SubPhasePower(int phasePower)
        {
            this.phasePower -= phasePower;
            if (this.phasePower < 0)
            {
                this.phasePower = 0;
            }
        }
        public void SubAdDef(int adDef)
        {
            this.adDef -= adDef;
            if (this.adDef < 0)
            {
                this.adDef = 0;
            }
        }
        public void SubApDef(int apDef)
        {
            this.apDef -= apDef;
            if (this.apDef < 0)
            {
                this.apDef = 0;
            }
        }
        public void SubAd(int ad)
        {
            this.ad -= ad;
            if (this.ad < 0)
            {
                this.ad = 0;
            }
        }
        public void SubAp(int ap)
        {
            this.ap -= ap;
            if (this.ap < 0)
            {
                this.ap = 0;
            }
        }
        public void SubCritRate(int critRate)
        {
            this.critRate -= critRate;
            if (this.critRate < 0)
            {
                this.critRate = 0;
            }
        }
        public void SubCritDamage(int critDamage)
        {
            this.critDamage -= critDamage;
            if (this.critDamage < 0)
            {
                this.critDamage = 0;
            }
        }
        public void SubDefBreak(int defBreak)
        {
            this.defBreak -= defBreak;
            if (this.defBreak < 0)
            {
                this.defBreak = 0;
            }
        }
        public void SubSpeed(int speed)
        {
            this.speed -= speed;
            if (this.speed < 0)
            {
                this.speed = 0;
            }
        }
        public void SubAccuracy(int accuracy)
        {
            this.accuracy -= accuracy;
            if (this.accuracy < 0)
            {
                this.accuracy = 0;
            }
        }
        public void SubDodge(int dodge)
        {
            this.dodge -= dodge;
            if (this.dodge < 0)
            {
                this.dodge = 0;
            }
        }
        public void SubStunResist(int stunResist)
        {
            this.stunResist -= stunResist;
            if (this.stunResist < 0)
            {
                this.stunResist = 0;
            }
        }
        public void SubBurnResist(int burnResist)
        {
            this.burnResist -= burnResist;
            if (this.burnResist < 0)
            {
                this.burnResist = 0;
            }
        }
        public void SubElectroResist(int electroResist)
        {
            this.electroResist -= electroResist;
            if (this.electroResist < 0)
            {
                this.electroResist = 0;
            }
        }
        public void SubStunRate(int stunRate)
        {
            this.stunRate -= stunRate;
            if (this.stunRate < 0)
            {
                this.stunRate = 0;
            }
        }
        public void SubBurnRate(int burnRate)
        {
            this.burnRate -= burnRate;
            if (this.burnRate < 0)
            {
                this.burnRate = 0;
            }
        }
        public void SubElectroRate(int electroRate)
        {
            this.electroRate -= electroRate;
            if (this.electroRate < 0)
            {
                this.electroRate = 0;
            }
        }

        public void AddMaxHealthByPercentage(int percent)
        {
            this.maxHealth += maxHealth * percent / 100;
        }
        public void AddHealthByPercentage(int percent)
        {
            this.health += maxHealth * percent / 100;
            if (maxHealth < health)
            {
                this.health = maxHealth;
            }
        }
        public void AddMaxManaByPercentage(int percent)
        {
            this.maxMana += maxMana * percent / 100;
        }
        public void AddManaByPercentage(int percent)
        {
            this.mana += maxMana * percent / 100;
            if (maxMana < mana)
            {
                this.mana = maxMana;
            }
        }
        public void AddAdDefByPercentage(int percent)
        {
            this.adDef += adDef * percent / 100;
        }
        public void AddApDefByPercentage(int percent)
        {
            this.apDef += apDef * percent / 100;
        }
        public void AddAdByPercentage(int percent)
        {
            this.ad += ad * percent / 100;
        }
        public void AddApByPercentage(int percent)
        {
            this.ap += ap * percent / 100;
        }
        public void AddSpeedByPercentage(int percent)
        {
            this.speed += speed * percent / 100;
        }
        public void AddAccuracyByPercentage(int percent)
        {
            this.accuracy += accuracy * percent / 100;
        }
        public void AddDodgeByPercentage(int percent)
        {
            this.dodge += dodge * percent / 100;
        }
        public void AddStunResistByPercentage(int percent)
        {
            this.stunResist += stunResist * percent / 100;
        }
        public void AddBurnResistByPercentage(int percent)
        {
            this.burnResist += burnResist * percent / 100;
        }
        public void AddElectroResistByPercentage(int percent)
        {
            this.electroResist += electroResist * percent / 100;
        }
        public void AddStunRateByPercentage(int percent)
        {
            this.stunRate += stunRate * percent / 100;
        }
        public void AddBurnRateByPercentage(int percent)
        {
            this.burnRate += burnRate * percent / 100;
        }
        public void AddElectroRateByPercentage(int percent)
        {
            this.electroRate += electroRate * percent / 100;
        }

        public void SubMaxHealthByPercentage(int percent)
        {
            this.maxHealth -= maxHealth * percent / 100;
            if (this.health > maxHealth)
            {
                this.health = maxHealth;
            }
        }
        public void SubHealthByPercentage(int percent)
        {
            this.health -= maxHealth * percent / 100;
        }
        public void SubMaxManaByPercentage(int percent)
        {
            this.maxMana -= maxMana * percent / 100;
            if (this.mana > maxMana)
            {
                this.mana = maxMana;
            }
        }
        public void SubManaByPercentage(int percent)
        {
            this.mana -= maxMana * percent / 100;
            if (this.mana < 0)
            {
                this.mana = 0;
            }
        }
        public void SubAdDefByPercentage(int percent)
        {
            this.adDef -= adDef * percent / 100;
            if (this.adDef < 0)
            {
                this.adDef = 0;
            }
        }
        public void SubApDefByPercentage(int percent)
        {
            this.apDef -= apDef * percent / 100;
            if (this.apDef < 0)
            {
                this.apDef = 0;
            }
        }
        public void SubAdByPercentage(int percent)
        {
            this.ad -= ad * percent / 100;
            if (this.ad < 0)
            {
                this.ad = 0;
            }
        }
        public void SubApByPercentage(int percent)
        {
            this.ap -= ap * percent / 100;
            if (this.ap < 0)
            {
                this.ap = 0;
            }
        }
        public void SubSpeedByPercentage(int percent)
        {
            this.speed -= speed * percent / 100;
            if (this.speed < 0)
            {
                this.speed = 0;
            }
        }
        public void SubAccuracyByPercentage(int percent)
        {
            this.accuracy -= accuracy * percent / 100;
            if (this.accuracy < 0)
            {
                this.accuracy = 0;
            }
        }
        public void SubDodgeByPercentage(int percent)
        {
            this.dodge -= dodge * percent / 100;
            if (this.dodge < 0)
            {
                this.dodge = 0;
            }
        }
        public void SubStunResistByPercentage(int percent)
        {
            this.stunResist -= stunResist * percent / 100;
            if (this.stunResist < 0)
            {
                this.stunResist = 0;
            }
        }
        public void SubBurnResistByPercentage(int percent)
        {
            this.burnResist -= burnResist * percent / 100;
            if (this.burnResist < 0)
            {
                this.burnResist = 0;
            }
        }
        public void SubElectroResistByPercentage(int percent)
        {
            this.electroResist -= electroResist * percent / 100;
            if (this.electroResist < 0)
            {
                this.electroResist = 0;
            }
        }
        public void SubStunRateByPercentage(int percent)
        {
            this.stunRate -= stunRate * percent / 100;
            if (this.stunRate < 0)
            {
                this.stunRate = 0;
            }
        }
        public void SubBurnRateByPercentage(int percent)
        {
            this.burnRate -= burnRate * percent / 100;
            if (this.burnRate < 0)
            {
                this.burnRate = 0;
            }
        }
        public void SubElectroRateByPercentage(int percent)
        {
            this.electroRate -= electroRate * percent / 100;
            if (this.electroRate < 0)
            {
                this.electroRate = 0;
            }
        }

        public void SetName(string newName)
        {
            this.name = newName;
        }
        public void SetType(string newType)
        {
            this.type = newType;
        }
        public void SetAlly(bool allyOrNot)
        {
            this.ally = allyOrNot;
        }
        public void SetLevel(int level)
        {
            this.level = level;
            this.AddMaxHealth(maxHealthPerLevel * (level-1));
            this.SetHealth(maxHealth * (level - 1));
            this.AddMaxMana(maxManaPerLevel * (level - 1));
            this.SetMana(maxMana * (level - 1));
            this.AddAdDef(adDefPerLevel * (level - 1));
            this.AddApDef(apDefPerLevel * (level - 1));
            this.AddAd(adPerLevel * (level - 1));
            this.AddAp(apPerLevel * (level - 1));
            this.AddCritRate(critRatePerLevel * (level - 1));
            this.AddCritDamage(critDamagePerLevel * (level - 1));
            this.AddDefBreak(defBreakPerLevel * (level - 1));
            this.AddSpeed(speedPerLevel * (level - 1));
            this.AddAccuracy(accuracyPerLevel * (level - 1));
            this.AddDodge(dodgePerLevel * (level - 1));
            this.AddStunResist(stunResistPerLevel * (level - 1));
            this.AddBurnResist(burnResistPerLevel * (level - 1));
            this.AddElectroResist(electroResistPerLevel * (level - 1));
        }
        public void SetExp(int exp)
        {
            this.exp = exp;
        }
        public void SetMaxHealth(int maxHealth)
        {
            this.maxHealth = maxHealth;
            if (this.maxHealth < health)
            {
                this.health = this.maxHealth;
            }
        }
        public void SetHealth(int health)
        {
            this.health = health;
            if (this.health > maxHealth)
            {
                this.health = maxHealth;
            }
        }
        public void SetMaxMana(int maxMana)
        {
            this.maxMana = maxMana;
            if (this.maxMana < mana)
            {
                this.mana = this.maxMana;
            }
        }
        public void SetMana(int mana)
        {
            this.mana = mana;
            if (this.mana > maxMana)
            {
                this.mana = maxMana;
            }
        }
        public void SetPhasePower(int phasePower)
        {
            this.phasePower = phasePower;
            if (this.phasePower < 0)
            {
                this.phasePower = 0;
            }
            if (this.phasePower > 100)
            {
                this.phasePower = 100;
            }
        }
        public void SetAdDef(int adDef)
        {
            this.adDef = adDef;
            if (this.adDef < 0)
            {
                this.adDef = 0;
            }
        }
        public void SetApDef(int apDef)
        {
            this.apDef = apDef;
            if (this.apDef < 0)
            {
                this.apDef = 0;
            }
        }
        public void SetAd(int ad)
        {
            this.ad = ad;
            if (this.ad < 0)
            {
                this.ad = 0;
            }
        }
        public void SetAp(int ap)
        {
            this.ap = ap;
            if (this.ap < 0)
            {
                this.ap = 0;
            }
        }
        public void SetCritRate(int critRate)
        {
            this.critRate = critRate;
            if (this.critRate < 0)
            {
                this.critRate = 0;
            }
        }
        public void SetCritDamage(int critDamage)
        {
            this.critDamage = critDamage;
            if (this.critDamage < 0)
            {
                this.critDamage = 0;
            }
        }
        public void SetDefBreak(int defBreak)
        {
            this.defBreak = defBreak;
            if (this.defBreak < 0)
            {
                this.defBreak = 0;
            }
        }
        public void SetSpeed(int speed)
        {
            this.speed = speed;
            if (this.speed < 0)
            {
                this.speed = 0;
            }
        }
        public void SetAccuracy(int accuracy)
        {
            this.accuracy = accuracy;
            if (this.accuracy < 0)
            {
                this.accuracy = 0;
            }
        }
        public void SetDodge(int dodge)
        {
            this.dodge = dodge;
            if (this.dodge < 0)
            {
                this.dodge = 0;
            }
        }
        public void SetStunResist(int stunResist)
        {
            this.stunResist = stunResist;
            if (this.stunResist < 0)
            {
                this.stunResist = 0;
            }
        }
        public void SetBurnResist(int burnResist)
        {
            this.burnResist = burnResist;
            if (this.burnResist < 0)
            {
                this.burnResist = 0;
            }
        }
        public void SetElectroResist(int electroResist)
        {
            this.electroResist = electroResist;
            if (this.electroResist < 0)
            {
                this.electroResist = 0;
            }
        }
        public void SetStunRate(int stunRate)
        {
            this.stunRate = stunRate;
            if (this.stunRate < 0)
            {
                this.stunRate = 0;
            }
        }
        public void SetBurnRate(int burnRate)
        {
            this.burnRate = burnRate;
            if (this.burnRate < 0)
            {
                this.burnRate = 0;
            }
        }
        public void SetElectroRate(int electroRate)
        {
            this.electroRate = electroRate;
            if (this.electroRate < 0)
            {
                this.electroRate = 0;
            }
        }

        //상태값 설정함수
        public void SetStunTrue()
        {
            this.stun = true;
        }
        public void SetBurnTrue()
        {
            this.burn = true;
        }
        public void SetElectroTrue()
        {
            this.electro = true;
        }
        public void SetMarkedTrue()
        {
            this.marked = true;
        }
        public void SetStunFalse()
        {
            this.stun = false;
        }
        public void SetBurnFalse()
        {
            this.burn = false;
        }
        public void SetElectroFalse()
        {
            this.electro = false;
        }
        public void SetMarkedFalse()
        {
            this.marked = false;
        }

        //스킬 코스트 확인 함수
        public bool CheckHealthCost(int cost)
        {
            if (this.health <= cost)
            {
                Console.WriteLine("체력이 부족하여 스킬을 시전할 수 없습니다.");
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool CheckManaCost(int cost)
        {
            if (this.mana < cost)
            {
                Console.WriteLine("마나가 부족하여 스킬을 시전할 수 없습니다.");
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool CheckPhasePowerCost(int cost)
        {
            if (this.phasePower < cost)
            {
                Console.WriteLine("위상력이 부족하여 스킬을 시전할 수 없습니다.");
                return false;
            }
            else
            {
                return true;
            }
        }

        //스탯 확인 함수
        //출력
        public void Stat()
        {
            this.WriteName();
            this.WriteType();
            this.WriteLevel();
            this.WriteExp();
            this.WriteHealth();
            if (this.maxMana!=0)
            {
                this.WriteMana();
            }
            if(this.ally==true)
            {
                this.WritePhasePower();
            }
            if(this.ad!=0)
            {
                this.WriteAd();
            }
            if(this.ap!=0)
            {
                this.WriteAp();
            }
            this.WriteAdDef();
            this.WriteApDef();
            this.WriteCritRate();
            this.WriteCritDamage();
            this.WriteSpeed();
            this.WriteAccuracy();
            this.WriteDodge();
            this.WriteStunResist();
            this.WriteBurnResist();
            this.WriteElectroResist();
            Console.WriteLine();
        }
        public void WriteName()
        {
            Console.WriteLine(this.name);
        }
        public void WriteType()
        {
            Console.WriteLine("타입:"+this.type);
        }
        public void WriteAlly()
        {
            if(this.ally==true)
            {
                Console.WriteLine(this.name + "은 아군입니다.");
            }
            else
            {
                Console.WriteLine(this.name + "은 적입니다.");
            }
        }
        public void WriteLevel()
        {
            Console.WriteLine("레벨:" + this.level);
        }
        public void WriteExp()
        {
            Console.WriteLine("경험치:"+this.exp + "/100");
        }
        public void WriteHealth()
        {
            Console.WriteLine("체력:" + this.health + "/" + this.maxHealth);
        }
        public void WriteMana()
        {
            Console.WriteLine("마나:" + this.mana + "/" + this.maxMana);
        }
        public void WritePhasePower()
        {
            Console.WriteLine("위상력:" + this.phasePower+"/100");
        }
        public void WriteAdDef()
        {
            Console.WriteLine("물리 방어력:" + this.adDef);
        }
        public void WriteApDef()
        {
            Console.WriteLine("마법 방어력:" + this.apDef);
        }
        public void WriteAd()
        {
            Console.WriteLine("물리 공격력:" + this.ad);
        }
        public void WriteAp()
        {
            Console.WriteLine("마법 공격력:" + this.ap);
        }
        public void WriteCritRate()
        {
            Console.WriteLine("치명타 확률:" + this.critRate);
        }
        public void WriteCritDamage()
        {
            Console.WriteLine("치명타 피해량:" + this.critDamage);
        }
        public void WriteDefBreak()
        {
            Console.WriteLine("방어력 관통:" + this.defBreak);
        }
        public void WriteSpeed()
        {
            Console.WriteLine("속도:" + this.speed);
        }
        public void WriteAccuracy()
        {
            Console.WriteLine("명중률:" + this.accuracy);
        }
        public void WriteDodge()
        {
            Console.WriteLine("회피율:" + this.dodge);
        }
        public void WriteStunResist()
        {
            Console.WriteLine("기절 저항력:" + this.stunResist);
        }
        public void WriteBurnResist()
        {
            Console.WriteLine("화염 저항력:" + this.burnResist);
        }
        public void WriteElectroResist()
        {
            Console.WriteLine("전기 저항력:" + this.electroResist);
        }
        public void WriteStun()
        {
            if (this.stun == true)
            {
                Console.WriteLine(this.name + "는 기절상태입니다.");
            }
        }
        public void WriteBurn()
        {
            if(this.burn==true)
            {
                Console.WriteLine(this.name + "는 화염피해상태입니다.");
            }
        }
        public void WriteElectro()
        {
            if(this.electro==true)
            {
                Console.WriteLine(this.name + "는 전기피해상태입니다.");
            }
        }
        public void WriteMarked()
        {
            if(this.marked==true)
            {
                Console.WriteLine(this.name + "는 표식에 찍힌 상태입니다.");
            }
        }
        //값 반환
        public string Name()
        {
            return name;
        }
        public string Type()
        {
            return type;
        }
        public bool Ally()
        {
            return ally;
        }
        public int Level()
        {
            return level;
        }
        public int Exp()
        {
            return exp;
        }
        public int MaxHealth()
        {
            return maxHealth;
        }
        public int Health()
        {
            return health;
        }
        public int MaxMana()
        {
            return maxMana;
        }
        public int Mana()
        {
            return mana;
        }
        public int PhasePower()
        {
            return phasePower;
        }
        public int AdDef()
        {
            return adDef;
        }
        public int ApDef()
        {
            return apDef;
        }
        public int Ad()
        {
            return ad;
        }
        public int Ap()
        {
            return ap;
        }
        public int CritRate()
        {
            return critRate;
        }
        public int CritDamage()
        {
            return critDamage;
        }
        public int DefBreak()
        {
            return defBreak;
        }
        public int Speed()
        {
            return speed;
        }
        public int Accuracy()
        {
            return accuracy;
        }
        public int Dodge()
        {
            return dodge;
        }
        public int StunResist()
        {
            return stunResist;
        }
        public int BurnResist()
        {
            return burnResist;
        }
        public int ElectroResist()
        {
            return electroResist;
        }
        public bool Stun()
        {
            return stun;
        }
        public bool Burn()
        {
            return burn;
        }
        public bool Electro()
        {
            return electro;
        }
        public bool Marked()
        {
            return marked;
        }

        //전투 함수들
        public void Battle(float damageRate, int critRate, int critDamage, int defBreak, int accuracy, int stunRate,
            int burnRate, int electroRate, bool mark, Character opponent, int phasePower, int cost)//전투할때는 이거 쓰면 됨
        {
            if (this.type == "파이터")//제이는 체력소모
            {
                this.SubHealth(cost);
            }
            else//나머지는 마나소모
            {
                this.SubMana(cost);
            }

            //명중확률 뺑뺑이
            Random random = new Random();
            int hit = random.Next(1, 100);
            if (this.accuracy + accuracy - opponent.dodge >= hit)//명중했으면
            {
                BattleDamageCalc(damageRate, critRate, critDamage, defBreak, stunRate, burnRate, electroRate, opponent, phasePower);//데미지 계산

                if (mark == true)//표식을 찍는 스킬이면 무조건 표식을 찍음
                {
                    opponent.SetMarkedTrue();
                }

            }
            else//아니면 빗나감
            {
                Console.WriteLine("공격이 빗나갔습니다!");
            }
        }

        public void BattleDamageCalc(float damageRate, int critRate, int critDamage, int defBreak, int stunRate,
            int burnRate, int electroRate, Character opponent, int phasePower)//데미지 계산
        {
            //상대의 방어력과 자신의 공격력, 스킬계수, 방어 관통력을 사용해 데미지 계산
            int adDamage = (int)((this.ad * damageRate) * (100 / (float)(opponent.adDef + 100 - this.defBreak - defBreak)));
            int apDamage = (int)((this.ap * damageRate) * (100 / (float)(opponent.apDef + 100 - this.defBreak - defBreak)));
            int totalDamage = adDamage + apDamage;

            //치명타 데미지
            int fatalBlow = (100 + this.critDamage + critDamage) * totalDamage / 100;

            //크리확률 뺑뺑이
            Random random = new Random();
            int crit = random.Next(1, 100);
            if(this.critRate+critRate>=crit)//크리 터지면
            {
                Console.WriteLine("치명적인 일격!");
                opponent.SubHealth(fatalBlow);//치명타 데미지
                if (this.ally == true)//아군은 위상력이 평소의 2배로 증가
                {
                    this.AddPhasePower(phasePower*2);
                }
            }
            else//아니면
            {
                Console.WriteLine("공격이 적중했습니다!");
                opponent.SubHealth(totalDamage);//총합 데미지
                if (this.ally == true)//원래 올라가는 만큼 위상력 증가
                {
                    this.AddPhasePower(phasePower);
                }
            }

            if (opponent.health == 0)//만약 이 공격으로 적의 체력이 0이 된다면
            {
                Console.WriteLine(opponent.name + "이 쓰러졌습니다!");
                this.AddExp(opponent.exp);//적 경험치량만큼 경험치 증가
                while(this.exp>=100)//경험치가 100을 넘기면 레벨업
                {
                    LevelUp();
                }
            }
            else//적이 살아있다면 상태이상에 걸릴 확률 결정
            {
                BattleStunCalc(stunRate, opponent);
                BattleBurnCalc(burnRate, opponent);
                BattleElectroCalc(electroRate, opponent);
            }
        }
        public void BattleStunCalc(int stunRate,Character opponent)//스턴
        {
            int stunPossible = this.stunRate + stunRate - opponent.stunResist;
            Random random = new Random();
            int stun = random.Next(1, 100);
            if(stunPossible>=stun)
            {
                opponent.SetStunTrue();
                opponent.WriteStun();
            }
        }
        public void BattleBurnCalc(int burnRate, Character opponent)//화염
        {
            int burnPossible = this.burnRate + burnRate - opponent.burnResist;
            Random random = new Random();
            int burn = random.Next(1, 100);
            if (burnPossible >= burn)
            {
                opponent.SetBurnTrue();
                opponent.WriteBurn();
            }
        }
        public void BattleElectroCalc(int electroRate, Character opponent)//전기
        {
            int electroPossible = this.electroRate + electroRate - opponent.electroResist;
            Random random = new Random();
            int electro = random.Next(1, 100);
            if (electroPossible >= electro)
            {
                opponent.SetElectroTrue();
                opponent.WriteElectro();
            }
        }

        public void StunEffect()//스턴상태시 효과
        {
            if(this.stun==true)
            {

            }
        }
        public void BurnEffect()//화염피해시 효과
        {
            if(this.burn==true)
            {

            }
        }
        public void ElectroEffect()//전기피해시 효과
        {
            if(this.electro==true)
            {

            }
        }
        public void MarkedEffect()//표식상태시 효과
        {
            if(this.marked==true)
            {

            }
        }
    }
}
