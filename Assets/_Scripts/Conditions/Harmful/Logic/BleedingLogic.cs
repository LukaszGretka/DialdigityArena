using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Characters.Conditions;
using Assets._Scripts.Conditions.Abstract;
using Assets._Scripts.Player;
using System;


namespace Assets._Scripts.Conditions.Harmful.Logic
{
    internal class BleedingLogic: Bleeding, IConditionImplementation
    {
        public void ApplyConditionEffect(ICharacterClass characterClass)
        {
            // that sucks, because there is no possibility to remove condition || need to implement this kind of solution as "condition state" which can be 
            // added to Character Class 
            characterClass.TakeDamage(base.DamagePerTick);
        }

        public void RemoveConditionEffect(ICharacterClass characterClass)
        {
            throw new NotImplementedException();
        }
    }
}
