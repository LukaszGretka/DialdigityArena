
using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Characters.Conditions;
using System.Collections.Generic;

namespace Assets._Scripts.Abilities.Characters.RangerAbilities.Special
{
    internal class PenetratingShot : IAbility
    {
        public string Name { get; private set; } = "Penetrating Shot";

        public float BaseDamage { get; private set; } = 6f;

        public int ManaCost { get; private set; } = 2;

        public int StaminaCost { get; private set; } = 0;

        public float CooldownTime { get; private set; } = 1f;

        public float Range { get; private set; } = 10f;

        public bool IsRanged { get; private set; } = true;

        public float CastingTime { get; private set; } = 2.5f;

        public float HitAngle { get; } = default(float);

        public bool OnCooldown { get; } = default(bool);

        public List<KeyValuePair<IConditions, float>> Conditions { get; } = new List<KeyValuePair<IConditions, float>>()
        {
            new KeyValuePair<IConditions, float>(new Bleeding(), 5f)
        };

    }
}
