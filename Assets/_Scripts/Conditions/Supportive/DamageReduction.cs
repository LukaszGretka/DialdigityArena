using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Conditions.Abstract;
using Assets._Scripts.Conditions.Enum;
using Assets._Scripts.Conditions.Supportive.Logic;

namespace Assets._Scripts.Conditions
{
    internal class DamageReduction : IConditionConstant
    {
        public DamageReduction(float durationTime, float damageReductionValue)
        {
            DurationTime = durationTime;
            DamageReductionValue = damageReductionValue;
        }

        public string Name { get; private set; } = "Damage Reduction";

        public float DurationTime { get; private set; }

        public float DamageReductionValue { get; private set; }

        public ConditionEffectType EffectType { get; private set; } = ConditionEffectType.Constant;

        public IConditionImplementation ConditionImplementation { get; private set; } = new DamageReductionLogic();

    }
}