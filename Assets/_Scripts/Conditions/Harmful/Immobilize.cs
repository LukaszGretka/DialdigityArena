using Assets._Scripts.Conditions.Abstract;
using Assets._Scripts.Conditions.Enum;
using Assets._Scripts.Conditions.Harmful.Logic;

namespace Assets._Scripts.Conditions.Harmful
{
    class Immobilize : IConditionConstant
    {
        public Immobilize(float durationTime)
        {
            DurationTime = durationTime;
        }

        public string Name { get; private set; } = "Immobilize";

        public ConditionEffectType EffectType { get; private set; } = ConditionEffectType.Constant;

        public IConditionImplementation ConditionImplementation { get; private set; } = new ImmobilizeLogic();

        public float DurationTime { get; private set; }
    }
}
