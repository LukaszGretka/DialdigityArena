
using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Conditions.Harmful;
using System.Collections.Generic;

namespace Assets._Scripts.Abilities.Characters.RangerAbilities
{
    class Dodge : IAbility
    {
        public string Name { get; private set; } = "Dodge";

        public float BaseDamage { get; private set; } = 0f;

        public int ManaCost { get; private set; } = 0;

        public int StaminaCost { get; private set; } = 1;

        public float CooldownTime { get; private set; } = 0f;

        public float Range { get; private set; } = 0f;

        public bool IsRanged { get; private set; } = false;

        public float CastingTime { get; private set; } = 0f;

        public float HitAngle { get; private set; } = default(float);

        public bool OnCooldown { get; private set; } = default(bool);

        public List<IConditions> Conditions { get; private set; } = new List<IConditions> { new Evasion() { DurationTime = 10f, AttackEvasionValue = 70f} };
    }
}
