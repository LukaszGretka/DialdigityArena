using Assets._Scripts.Conditions.Abstract;
using Assets._Scripts.Conditions.Enum;
using Assets._Scripts.Conditions.Harmful.Logic;

namespace Assets._Scripts.Characters.Conditions
{
    internal class Bleeding : IHarmfulCondition
    {
        public string Name { get; private set; } = "Bleeding";

        public float DamagePerTick { get; private set; } = 5f;

        public float DurationTime { get; set; }

        public float SlowStrength { get; private set; } = default(float);

        public float DamageReductionValue { get; private set; } = 0f;

        public float AttackEvasionValue { get; private set; }

        public IConditionImplementation ConditionImplementation { get; private set; } = new BleedingLogic();

        public ConditionEffectType EffectType { get; private set; } = ConditionEffectType.EffectOverTime;
    }
}
