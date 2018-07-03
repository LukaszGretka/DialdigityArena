using Assets._Scripts.Characters.Abstract.Interfaces;
using System;

namespace Assets._Scripts.Conditions.Abstract
{
    public interface IConditionImplementation
    {
        Action<ICharacterClass, ICondition> GetConditionImplementation();
    }
}
