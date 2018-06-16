using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets._Scripts.Abilities.WarriorAbilities.Special
{
    internal class Bash : IAbility
    {
        //add effects (contitions implementation)
        public string Name { get; private set; } = "Bash";

        public float BaseDamage { get; private set; } = 10f;

        public int ManaCost { get; private set; } = 0;

        public int StaminaCost { get; private set; } = 1;

        public float Cooldown { get; private set; } = 15f;

        public float Range { get; private set; } = 1f;

        public bool IsRanged { get; private set; } = false;
    }
}
