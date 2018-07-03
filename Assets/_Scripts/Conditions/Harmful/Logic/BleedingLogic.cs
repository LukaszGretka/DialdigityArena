using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Characters.Conditions;
using Assets._Scripts.Conditions.Abstract;
using Assets._Scripts.Player;
using System;

namespace Assets._Scripts.Conditions.Harmful.Logic
{
    internal class BleedingLogic: IConditionImplementation
    {
        public Action<ICharacterClass, ICondition> GetConditionImplementation()
        {
            return (characterClass, condition) =>
            {
                Bleeding bleeding = condition as Bleeding;
                characterClass.TakeDamage(bleeding.DamagePerTick);
            };
        }
    }
}
