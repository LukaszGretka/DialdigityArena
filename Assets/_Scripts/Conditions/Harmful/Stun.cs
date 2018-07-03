using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Conditions.Abstract;
using Assets._Scripts.Conditions.Enum;
using Assets._Scripts.Conditions.Harmful.Logic;
using System;

namespace Assets._Scripts.Conditions
{
    internal class Stun : IConditionConstant
    {
        public Stun(float durationTime)
        {
            DurationTime = DurationTime;
        }

        public string Name { get; private set; } = "Stun";

        public ConditionEffectType EffectType { get; private set; } = ConditionEffectType.Constant;

        public IConditionImplementation ConditionImplementation { get; private set; } = new StunLogic();

        public float DurationTime { get; private set; }
    }
}