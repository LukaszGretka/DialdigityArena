using Assets._Scripts.Characters.Abstract.Interfaces;
using System;

namespace Assets._Scripts.Conditions
{
    internal class Stun : IConditions
    {
        public string Name { get; private set; } = "Stun";

        public float DamagePerTick { get; private set; } = 0f;

        public float DurationTime { get; set; }

        public float SlowStrength { get; private set; }

        public float DamageReductionValue { get; private set; } = default(float);

        public float AttackEvasionValue { get; private set; }
    }
}
