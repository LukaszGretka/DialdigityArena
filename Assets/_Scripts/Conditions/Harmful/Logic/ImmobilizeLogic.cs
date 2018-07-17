using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Conditions.Abstract;
using System;

namespace Assets._Scripts.Conditions.Harmful.Logic
{
    internal class ImmobilizeLogic : IConditionImplementationConstant
    {
        public Action<ICharacterClass, ICondition> GetConditionImplementationApply()
        {
            return (characterClass, condition) =>
            {
                Immobilize immobilize = condition as Immobilize;
                characterClass.SetCurrentMovementSpeed(0f);
            };
        }

        public Action<ICharacterClass, ICondition> GetConditionImplementationRemove()
        {
            return (characterClass, condition) =>
            {
                Immobilize immobilize = condition as Immobilize;
                characterClass.SetCurrentMovementSpeed(characterClass.GetBaseMovementSpeed());
            };
        }
    }
}
