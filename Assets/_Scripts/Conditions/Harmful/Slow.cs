using Assets._Scripts.Conditions.Abstract;
using Assets._Scripts.Conditions.Enum;
using Assets._Scripts.Conditions.Harmful.Logic;

namespace Assets._Scripts.Conditions
{
    internal class Slow : IConditionConstant
    {
        public Slow(float durationTime, float slowStrength)
        {
            DurationTime = durationTime;
            SlowStrength = slowStrength;
        }

        public string Name { get; private set; } = "Slow";

        public float DurationTime { get; private set; }

        public float SlowStrength { get; private set; }

        public ConditionEffectType EffectType { get; private set; } = ConditionEffectType.Constant;

        public IConditionImplementation ConditionImplementation { get; private set; } = new SlowLogic();
    }
}
