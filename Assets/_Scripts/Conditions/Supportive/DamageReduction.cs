using Assets._Scripts.Conditions.Abstract;
using Assets._Scripts.Conditions.Enum;
using Assets._Scripts.Conditions.Supportive.Logic;

namespace Assets._Scripts.Conditions
{
    internal class DamageReduction : ISupportiveCondition
    {
        public string Name { get; private set; } = "Damage Reduction";

        public float DurationTime { get; set; }

        public float DamageReductionValue { get; set; }

        public float AttackEvasionValue { get; private set; }

        public float HealingPerTick { get; private set; }

        public ConditionEffectType EffectType { get; private set; } = ConditionEffectType.Constant;

        public IConditionImplementation ConditionImplementation { get; private set; } = new DamageReductionLogic();
    }
}
