
using Assets._Scripts.Characters.Abstract.Interfaces;
using System.Collections.Generic;

namespace Assets._Scripts.Abilities.Characters.RangerAbilities.Special
{
    internal class Barrage : IAbility
    {
        public string Name { get; private set; } = "Barrage";

        public float BaseDamage { get; private set; } = 10f;

        public int ManaCost { get; private set; } = 2;

        public int StaminaCost { get; private set; } = 0;

        public float CooldownTime { get; private set; } = 15f;

        public float Range { get; private set; } = 8f;

        public bool IsRanged { get; private set; } = true;
 
        public float CastingTime { get; private set; } = 1.5f;

        public float HitAngle { get; } = 90f;

        public bool OnCooldown { get; } = default(bool);

        public List<KeyValuePair<IConditions, float>> Conditions { get; } = new List<KeyValuePair<IConditions, float>>()
        {

        };

    }
}
