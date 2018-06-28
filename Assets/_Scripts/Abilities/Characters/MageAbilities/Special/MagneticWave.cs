
using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Characters.Conditions;
using Assets._Scripts.Conditions;
using System.Collections.Generic;

namespace Assets._Scripts.Abilities.Characters.MageAbilities.Special
{
    internal class MagneticWave : IAbility
    {
        public string Name { get; private set; } = "Magnetic Wave";

        public float BaseDamage { get; private set; } = 0f;

        public int ManaCost { get; private set; } = 5;

        public int StaminaCost { get; private set; } = 0;

        public float CooldownTime { get; private set; } = 15f;

        public float Range { get; private set; } = 10f;

        public bool IsRanged { get; private set; } = true;

        public float CastingTime { get; private set; } = 0f;

        public float HitAngle { get; } = default(float);

        public bool OnCooldown { get; } = default(bool);

        public List<KeyValuePair<IConditions, float>> Conditions { get; } = new List<KeyValuePair<IConditions, float>>()
                                                        {
                                                            new KeyValuePair<IConditions, float>(new Slow(), 5f)
                                                        };
    }
}
