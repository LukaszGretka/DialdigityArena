using Assets._Scripts.Characters.Abstract.Interfaces;
using System;

namespace Assets._Scripts.Conditions
{
    internal class DamageReduction : IConditions
    {
        public string Name { get; private set; } = "Damage Reduction";

        public float DamagePerTick { get; private set; } = 0f;

        public float DurationTime { get; set; }

        public float SlowStrength { get; set; }

        public void AddConditionToTarget(ICharacterClass characterClass, float DurationTime)
        {
            throw new NotImplementedException();
        }

        public void RemoveConditionFromTarget(ICharacterClass characterClass)
        {
            throw new NotImplementedException();
        }
    }
}
