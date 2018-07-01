using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Conditions.Abstract;
using Assets._Scripts.Conditions.Enum;
using Assets._Scripts.Conditions.Supportive.Logic;

namespace Assets._Scripts.Conditions.Harmful
{
    internal class Evasion : ISupportiveCondition
    {
        public string Name { get; private set; } = "Evasion";

        public float DurationTime { get; set; }

        public float DamageReductionValue { get; private set; } = default(float);

        public float AttackEvasionValue { get; set; }

        public ConditionEffectType EffectType { get; private set; } = ConditionEffectType.Constant;

        public float HealingPerTick { get; private set; } = default(float);

        public IConditionImplementation ConditionImplementation { get; private set; } = new EvasionLogic();
    }
}
