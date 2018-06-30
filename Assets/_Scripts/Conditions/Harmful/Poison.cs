﻿using Assets._Scripts.Characters.Abstract.Interfaces;

namespace Assets._Scripts.Conditions.Harmful
{
    internal class Poison : IConditions
    {
        public string Name { get; private set; } = "Poison";

        public float DamagePerTick { get; private set; } = 5f;

        public float DurationTime { get;  set; } = default(float);

        public float SlowStrength { get; private set; } = default(float);

        public float DamageReductionValue { get; private set; } = default(float);

        public float AttackEvasionValue { get; private set; }
    }
}