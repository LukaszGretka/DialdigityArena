using Assets._Scripts.Characters.Abstract.Interfaces;
using System;

namespace Assets._Scripts.Conditions
{
    internal class Stun : IConditions
    {
        public string Name { get; private set; } = "Stun";

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
