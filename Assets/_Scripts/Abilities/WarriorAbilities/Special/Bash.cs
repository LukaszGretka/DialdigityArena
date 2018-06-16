using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets._Scripts.Abilities.WarriorAbilities.Special
{
    internal class Bash : IAbility
    {
        //add effects (contitions implementation)

        public string Name
        {
            get { return Name; }
            private set { value = "Bash"; }
        }

        public float BaseDamage
        {
            get { return BaseDamage; }
            private set { value = 10f; }
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
            private set { value = 15; }
        }

        public float Range
        {
            get { return Range; }
            private set { value = 1f; }
        }

        public bool IsRanged
        {
            get { return IsRanged; }
            private set { value = false; }
        }
    }
}
