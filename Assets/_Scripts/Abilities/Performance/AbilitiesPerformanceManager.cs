using Assets._Scripts.Abilities.Abstract;
using Assets._Scripts.Abilities.Logic;
using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.OutputMessages;
using Assets._Scripts.Player;
using System;
using UnityEngine;

namespace Assets._Scripts.Abilities.Performance
{
    internal class AbilitiesPerformanceManager : IAbilityPerformance 
    {
        private IAbilityImplementation abilityImplementation;
        private ICharacterClass characterClass;

        public AbilitiesPerformanceManager(ICharacterClass characterClass)
        {
            this.characterClass = characterClass;
            abilityImplementation = this.characterClass.GetAbilityImplementation();
        }

        public void CastFirstDefaultAbility()
        {
            if (PerformAbilityValidation(characterClass, characterClass.GetFirstDefaultAbility()).State == AbilityResultState.ReadyToCast)
            {
                var abilityResultList = abilityImplementation.FirstDefaultAbilityImplementation();

                foreach (AbilityLogicResult result in abilityResultList)
                {
                    result.TargetHitOnCast.TakeDamage(result.DealedDamage);
                    Debug.Log(result.TargetHitOnCast.GetCurrentHealth());
                }

            }

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

        private AbilityCastResult PerformAbilityValidation(ICharacterClass characterClass, IAbility ability)
        {
            if (characterClass.GetCurrentMana() <= ability.ManaCost)
            {
                return BuildAbilityCastResult(PlayerOutputMessages.NotEnoughMana, ability, AbilityResultState.NotEnoughMana);
            }

            if (characterClass.GetCurrentStamina() <= ability.StaminaCost)
            {
                return BuildAbilityCastResult(PlayerOutputMessages.NotEnoughStamina, ability, AbilityResultState.NotEnoughStamina);
            }

            if (ability.OnCooldown)
            {
                return BuildAbilityCastResult(PlayerOutputMessages.AbilityOnCooldown, ability, AbilityResultState.OnCooldown);
            }

            return BuildAbilityCastResult(PlayerOutputMessages.AbilityCastSuccessful, ability, AbilityResultState.ReadyToCast);
        }

        private AbilityCastResult BuildAbilityCastResult(string message, IAbility ability, AbilityResultState state)
        {
            return new AbilityCastResult()
            {
                Ability = ability,
                Message = message,
                State = state,
            };
        }
    }
}
