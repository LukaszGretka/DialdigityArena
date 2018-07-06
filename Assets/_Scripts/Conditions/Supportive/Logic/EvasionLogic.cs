using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Conditions.Abstract;
using System;

namespace Assets._Scripts.Conditions.Supportive.Logic
{
    internal class EvasionLogic : IConditionImplementation
    {
        public Action<ICharacterClass, ICondition> GetConditionImplementationApply()
        {
            return (characterClass, condition) =>
            {
                EvasionLogic evasionLogic = condition as EvasionLogic;
                throw new NotImplementedException();
            };
        }
    }
}
