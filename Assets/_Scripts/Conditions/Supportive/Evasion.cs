using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Conditions.Abstract;
using Assets._Scripts.Conditions.Enum;
using Assets._Scripts.Conditions.Supportive.Logic;

namespace Assets._Scripts.Conditions.Harmful
{
    internal class Evasion : IConditionConstant
    {
        public Evasion(float durationTime, float evasionValue)
        {
            DurationTime = durationTime;
            EvasionValue = evasionValue;
        }

        public string Name { get; private set; } = "Evasion";

        public ConditionEffectType EffectType { get; private set; } = ConditionEffectType.Constant;

        public IConditionImplementation ConditionImplementation { get; private set; } = new EvasionLogic();

        public float DurationTime { get; private set; }

        public float EvasionValue { get; private set; }
    }
}