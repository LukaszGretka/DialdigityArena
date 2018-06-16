using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets._Scripts.Abilities.WarriorAbilities.Special
{
    internal class Leap : IAbility
    {
        public string Name
        {
            get { return Name; }
            private set { value = "Leap"; }
        }

        public float BaseDamage
        {
            get { return BaseDamage; }
            private set { value = 5f; }
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
            private set { value = 5f; }
        }

        public bool IsRanged
        {
            get { return IsRanged; }
            private set { value = true; }
        }
    }
}
