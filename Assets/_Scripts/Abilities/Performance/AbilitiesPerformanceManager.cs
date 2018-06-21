using Assets._Scripts.Abilities.Abstract;
using Assets._Scripts.Characters.Abstract.Interfaces;
using System;

namespace Assets._Scripts.Abilities.Performance
{
    internal class AbilitiesPerformanceManager : IAbilityPerformance 
    {
        private IAbilityImplementation abilityImplementation;

        public AbilitiesPerformanceManager(ICharacterClass characterClass)
        {
            abilityImplementation = characterClass.GetAbilityImplementation();
        }

        public void CastFirstDefaultAbility()
        {
            abilityImplementation.FirstDefaultAbilityImplementation();
        }

        public void CastSecondDefaultAbility()
        {
            abilityImplementation.SecondDefaultAbilityImplementation().Invoke();
        }

        public void CastFirstSpecialAbility()
        {
            abilityImplementation.FirstSpecialAbilityImplementation().Invoke();
        }

        public void CastSecondSpecialAbility()
        {
            abilityImplementation.SecondSpecialAbilityImplementation().Invoke();
        }

        public void CastThirdSpecialAbility()
        {
            abilityImplementation.ThirdSpecialAbilityImplementation().Invoke();
        }
    }
}
