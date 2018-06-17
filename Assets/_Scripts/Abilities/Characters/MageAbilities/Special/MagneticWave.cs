using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets._Scripts.Abilities.Characters.MageAbilities.Special
{
    internal class MagneticWave : IAbility
    {
        public string Name { get; private set; } = "Magnetic Wave";

        public float BaseDamage { get; private set; } = 0f;

        public int ManaCost { get; private set; } = 5;

        public int StaminaCost { get; private set; } = 0;

        public float Cooldown { get; private set; } = 15f;

        public float Range { get; private set; } = 10f;

        public bool IsRanged { get; private set; } = true;

        public float CastingTime { get; private set; } = 0f;

        //TODO Enum, condition - slow

    }
}
