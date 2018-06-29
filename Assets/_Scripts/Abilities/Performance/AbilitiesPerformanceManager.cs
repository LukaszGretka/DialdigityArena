using Assets._Scripts.Abilities.Abstract;
using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.OutputMessages;
using Assets._Scripts.Player;
using System;
using System.Collections;
using UnityEngine;

namespace Assets._Scripts.Abilities.Performance
{
    internal class AbilitiesPerformanceManager: MonoBehaviour ,IAbilityPerformance 
    {
        private IAbilityImplementation abilityImplementation;
        private ICharacterClass characterClass;

        private static IEnumerator castAbilityCoroutine;

        private void Awake()
        {
            characterClass = GetComponent<ICharacterClass>();
            abilityImplementation = characterClass.GetAbilityImplementation();
        }

        public void CastFirstDefaultAbility()
        {
            IAbility firstDefaultAbility = characterClass.GetFirstDefaultAbility();

            if (PerformAbilityValidation(characterClass, firstDefaultAbility).State == AbilityResultState.ReadyToCast)
            {
                castAbilityCoroutine = CastAbilityCoroutine(firstDefaultAbility,  () => { abilityImplementation.FirstDefaultAbilityImplementation(); });
                StartCoroutine(castAbilityCoroutine);
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

        private IEnumerator CastAbilityCoroutine(IAbility ability, Action abilityCastAction)
        {
            //TODO check if ability was interupter
            yield return new WaitForSeconds(ability.CastingTime);

            Debug.Log("End casting after " + ability.CastingTime + "seconds. Execute ability: " + ability.Name);
            abilityCastAction.Invoke();
        }

        /// <summary>
        /// Check is character is able to cast a ability
        /// </summary>
        /// <param name="characterClass">Character class (attached to gameobject)</param>
        /// <param name="ability">Ability which is going to be cast</param>
        /// <returns></returns>
        private AbilityCastResult PerformAbilityValidation(ICharacterClass characterClass, IAbility ability)
        {
            AbilityCastResult abilityCastResult = BuildAbilityCastResult(PlayerOutputMessages.AbilityCastSuccessful, ability, AbilityResultState.ReadyToCast);

            if (characterClass.GetCurrentMana() <= ability.ManaCost)
            {
                abilityCastResult = BuildAbilityCastResult(PlayerOutputMessages.NotEnoughMana, ability, AbilityResultState.NotEnoughMana);
            }

            if (characterClass.GetCurrentStamina() <= ability.StaminaCost)
            {
                abilityCastResult = BuildAbilityCastResult(PlayerOutputMessages.NotEnoughStamina, ability, AbilityResultState.NotEnoughStamina);
            }

            if (ability.OnCooldown)
            {
                abilityCastResult =  BuildAbilityCastResult(PlayerOutputMessages.AbilityOnCooldown, ability, AbilityResultState.OnCooldown);
            }

            return abilityCastResult;
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
