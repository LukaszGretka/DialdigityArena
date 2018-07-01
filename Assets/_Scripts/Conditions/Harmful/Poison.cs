using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Conditions.Abstract;
using Assets._Scripts.Conditions.Enum;
using Assets._Scripts.Conditions.Harmful.Logic;

namespace Assets._Scripts.Conditions.Harmful
{
    internal class Poison : IHarmfulCondition
    {
        public string Name { get; private set; } = "Poison";

        public float DamagePerTick { get; private set; } = 5f;

        public float DurationTime { get; set; } = default(float);

        public float SlowStrength { get; private set; } = default(float);

        public float DamageReductionValue { get; private set; } = default(float);

        public float AttackEvasionValue { get; private set; }

        public ConditionEffectType EffectType { get; private set; } = ConditionEffectType.EffectOverTime;

        public IConditionImplementation ConditionImplementation { get; private set; } = new PosionLogic();
    }
}
