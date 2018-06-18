using Assets._Scripts.Abilities.Abstract;
using Assets._Scripts.Characters.Abstract.Interfaces;
using System;
using UnityEngine;
using UnityEngine.Networking;

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
            abilityImplementation.FirstDefaultAbilityImplementation().Invoke();
        }

        public void CastSecondDefaultAbility()
        {
            throw new NotImplementedException();
        }

        public void CastFirstSpecialAbility()
        {
            throw new NotImplementedException();
        }

        public void CastSecondSpecialAbility()
        {
            throw new NotImplementedException();
        }

        public void CastThirdSpecialAbility()
        {
            throw new NotImplementedException();
        }
    }
}
