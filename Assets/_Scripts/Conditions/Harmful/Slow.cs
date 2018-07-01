using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Conditions.Abstract;
using Assets._Scripts.Conditions.Enum;
using Assets._Scripts.Conditions.Harmful.Logic;

namespace Assets._Scripts.Conditions
{
    internal class Slow : ICondition
    {
        public string Name { get; private set; } = "Slow";

        public float DamagePerTick { get; private set; } = 0f;

        public float DurationTime { get; set; }

        public float SlowStrength { get; set; }

        public float DamageReductionValue { get; private set; }

        public float AttackEvasionValue { get; private set; }

        public ConditionEffectType EffectType { get; private set; } = ConditionEffectType.Constant;

        public IConditionImplementation ConditionImplementation { get; private set; } = new SlowLogic();
    }
}
