using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets._Scripts.Abilities.MageAbilities.Special
{
    internal class LightingLeap : IAbility
    {
        public string Name { get; private set; } = "Lighting Leap";

        public float BaseDamage { get; private set; } = 3f;

        public int ManaCost { get; private set; } = 10;

        public int StaminaCost { get; private set; } = 0;

        public float Cooldown { get; private set; } = 12f;

        public float Range { get; private set; } = 0f;

        public bool IsRanged { get; private set; } = false;

        public float CastingTime { get; private set; } = 0f;
    }
}
