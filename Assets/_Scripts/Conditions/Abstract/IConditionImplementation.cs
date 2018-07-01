using Assets._Scripts.Characters.Abstract.Interfaces;
using System;

namespace Assets._Scripts.Conditions.Abstract
{
    public interface IConditionImplementation
    {
        void ApplyConditionEffect(ICharacterClass characterClass);
        void RemoveConditionEffect(ICharacterClass characterClass);
    }
}
