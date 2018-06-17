using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets._Scripts.Abilities.MageAbilities
{
    internal class IceArmor : IAbility
    {
        public string Name { get; private set; } = "Ice Armor";

        public float BaseDamage { get; private set; } = 0f;

        public int ManaCost { get; private set; } = 4;

        public int StaminaCost { get; private set; } = 0;

        public float Cooldown { get; private set; } = 30f;

        public float Range { get; private set; } = 0f;

        public bool IsRanged { get; private set; } = false;

        public float CastingTime { get; private set; } = 0f;
    }
}
