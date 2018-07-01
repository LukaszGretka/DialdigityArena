using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Conditions.Abstract;
using Assets._Scripts.Conditions.Enum;
using Assets._Scripts.Conditions.Harmful.Logic;
using System;

namespace Assets._Scripts.Conditions
{
    internal class Stun : IHarmfulCondition
    {
        public string Name { get; private set; } = "Stun";

        public float DamagePerTick { get; private set; } = 0f;

        public float DurationTime { get; set; }

        public float SlowStrength { get; private set; }

        public float DamageReductionValue { get; private set; } = default(float);

        public float AttackEvasionValue { get; private set; }

        public ConditionEffectType EffectType { get; private set; } = ConditionEffectType.Constant;

        public IConditionImplementation ConditionImplementation { get; private set; } = new StunLogic();
    }
}
