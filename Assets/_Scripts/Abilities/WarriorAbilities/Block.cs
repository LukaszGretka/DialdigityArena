using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets._Scripts.Abilities.WarriorAbilities
{
    internal class Block : IAbility
    {
        public string Name
        {
            get { return Name; }
            private set { value = "Block"; }
        }

        public float BaseDamage
        {
            get { return BaseDamage; }
            private set { value = 0f; }
        }

        public int ManaCost
        {
            get { return ManaCost; }
            private set { value = 0; }
        }

        public int StaminaCost
        {
            get { return StaminaCost; }
            private set { value = 1; }
        }

        public float Cooldown
        {
            get { return Cooldown; }
            private set { value = 8; }
        }

        public float Range
        {
            get { return Range; }
            private set { value = 0f; }
        }

        public bool IsRanged
        {
            get { return IsRanged; }
            private set { value = false; }
        }
    }
}
