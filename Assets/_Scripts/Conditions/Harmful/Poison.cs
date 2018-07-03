﻿using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Conditions.Abstract;
using Assets._Scripts.Conditions.Enum;
using Assets._Scripts.Conditions.Harmful.Logic;

namespace Assets._Scripts.Conditions.Harmful
{
    internal class Poison : IConditionEffectOverTime
    {
        public Poison(float damagePerTick, int conditionIterations, float conditionIntervalTime, float initializationTime = Config.ConfigValues.DefaultConditionIntervalTime)
        {
            DamagePerTick = damagePerTick;
            ConditionIterations = conditionIterations;
            ConditionIntervalTime = conditionIntervalTime;
            InitializationTime = initializationTime;
        }

        public string Name { get; private set; } = "Poison";

        public int ConditionIterations { get; private set; }

        public float DamagePerTick { get; private set; }

        public float ConditionIntervalTime { get; private set; }

        public float InitializationTime { get; private set; }

        public ConditionEffectType EffectType { get; private set; } = ConditionEffectType.EffectOverTime;

        public IConditionImplementation ConditionImplementation { get; private set; } = new PoisonLogic();
    }
}