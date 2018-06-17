using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets._Scripts.Abilities.Characters.RangerAbilities.Special
{
    internal class PenetratingShot : IAbility
    {
        public string Name { get; private set; } = "Penetrating Shot";

        public float BaseDamage { get; private set; } = 6f;

        public int ManaCost { get; private set; } = 2;

        public int StaminaCost { get; private set; } = 0;

        public float Cooldown { get; private set; } = 1f;

        public float Range { get; private set; } = 10f;

        public bool IsRanged { get; private set; } = true;

        public float CastingTime { get; private set; } = 2.5f;

    }
}
