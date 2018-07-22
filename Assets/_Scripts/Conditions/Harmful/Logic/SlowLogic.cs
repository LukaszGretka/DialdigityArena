using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Conditions.Abstract;
using System;

namespace Assets._Scripts.Conditions.Harmful.Logic
{
    internal class SlowLogic : IConditionImplementationConstant
    {
        public Action<ICharacterClass, ICondition> GetConditionImplementationApply()
        {
            return (characterClass, condition) =>
            {
                Slow slow = condition as Slow;
                characterClass.SetCurrentMovementSpeed(characterClass.GetCurrentMovementSpeed() - slow.SlowStrength);
            };
        }

        public Action<ICharacterClass, ICondition> GetConditionImplementationRemove()
        {
            return (characterClass, condition) =>
            {
                characterClass.SetCurrentMovementSpeed(characterClass.GetBaseMovementSpeed());
            };
        }
    }
}
