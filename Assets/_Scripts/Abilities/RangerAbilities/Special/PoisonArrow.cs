using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets._Scripts.Abilities.RangerAbilities.Special
{
    internal class PoisonArrow : IAbility
    {
        public string Name { get; private set; } = "Poison Arrow";

        public float BaseDamage { get; private set; } = 4f;

        public int ManaCost { get; private set; } = 2;

        public int StaminaCost { get; private set; } = 0;

        public float Cooldown { get; private set; } = 10f;

        public float Range { get; private set; } = 6f;

        public bool IsRanged { get; private set; } = true;

        public float CastingTime { get; private set; } = 0f;

        //TODO If enemy is shooted by poision arrow he gets poison condition. Make Enum to storage conditions
    }
}
