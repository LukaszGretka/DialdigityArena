using Assets._Scripts.Characters.Abstract.Interfaces;
using System;

namespace Assets._Scripts.Conditions
{
    internal class DamageReduction : IConditions
    {
        public string Name { get; private set; } = "Damage Reduction";

        public float DamagePerTick { get; private set; } = default(float);

        public float DurationTime { get; set; } = default(float);

        public float SlowStrength { get; private set; } = default(float);

        public float DamageReductionValue { get;  set; }

        public float AttackEvasionValue { get; private set; }
    }
}
