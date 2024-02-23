using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.PD4
{
    internal class Stats
    {
        public int SkillName;
        public int Damage;
        public string Description;
        public int Penetration;
        public int Cost;
        public int? Heal;

        public Stats(int Damage, int Penetration, int Heal, int Cost, string Description)
        {
            this.Damage = Damage;
            this.Penetration = Penetration;
            this.Heal = Heal;
            this.Cost = Cost;
            this.Description = Description;
        }
    }
    internal class Player
    {
        public int HP;
        public int MaxHP;
        public int Energy;
        public int MaxEnergy;
        public int Armor;
        public string Name;
        public Stats SkillStats;
        public Player(string Name, int Health, int Energy, int Armor)
        {
            this.Name = Name;
            this.HP = Health;
            this.MaxHP = Health;
            this.Energy = Energy;
            this.MaxEnergy = Energy;
            this.Armor = Armor;
        }
        public bool SetHealth(int NewHealth)
        {
            if (NewHealth >= 0 && NewHealth <= MaxHP)
            {
                this.HP = NewHealth;
                return true;
            }
            return false;
        }
        public bool SetEnergy(int NewEnergy)
        {
            if (NewEnergy >= 0 && NewEnergy <= MaxEnergy)
            {
                this.Energy = NewEnergy;
                return true;
            }
            return false;
        }
        public bool SetArmor(int newArmor)
        {
            if (newArmor >= 0)
            {
                this.Armor = newArmor;
                return true;
            }
            return false;
        }
        public bool SetName(string Name)
        {
            if (Name.Length == 0) return false;
            this.Name = Name;
            return true;
        }
        public void LearnSkill(Stats SkillStats)
        {
            this.SkillStats = SkillStats;
        }
        public string Attack(Player OtherPlayer)
        {
            if (this.Energy < SkillStats.Cost)
            {
                return $"Player Attempted to use {SkillStats.SkillName}, but didn't have enough energy!";
            }
            else
            {
                this.Energy -= SkillStats.Cost;
            }

            if (this.SkillStats.Heal != null)
            {
                return $"\n{OtherPlayer.Name} healed for {this.SkillStats.Heal} health!";;
            }

            int EffectiveAmor = Math.Abs(OtherPlayer.SkillStats.Penetration - this.SkillStats.Penetration);
            OtherPlayer.Armor -= EffectiveAmor;

            int damage = SkillStats.Damage * ((this.Armor - EffectiveAmor)/100);
            bool otherPlayerDidntDie = OtherPlayer.SetHealth(OtherPlayer.HP - damage);

            string msg = $"{this.Name} used {SkillStats.SkillName}, {SkillStats.Description}, against {OtherPlayer.Name} doing {damage} damage!";

            if (!otherPlayerDidntDie)
            {
                msg += $"\n{OtherPlayer.Name} died!";
            }
            else
            {
                msg += $"\n{OtherPlayer.Name} is at {OtherPlayer.HP} health!";
            }
            return msg;
        }
    }
}
