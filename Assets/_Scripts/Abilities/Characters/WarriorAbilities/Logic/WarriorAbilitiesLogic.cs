using Assets._Scripts.Abilities.Abstract;
using Assets._Scripts.Abilities.Logic;
using Assets._Scripts.Characters;
using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.OutputMessages;
using Assets._Scripts.Player;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Scripts.Abilities.WarriorAbilities.Logic
{
    class WarriorAbilitiesLogic : MeleeAbilityLogic, IAbilityImplementation
    {
        private Warrior warriorClass;

        public WarriorAbilitiesLogic(Warrior characterClass)
        {
            warriorClass = characterClass;
        }

        /// <summary> Implementation of first warrior ability - Swipe </summary>
        public void FirstDefaultAbilityImplementation()
        {
            var abilityResultList = UseAreaMeleeAbility(warriorClass, warriorClass.GetFirstDefaultAbility());

            //hit multiple targets
            foreach (AbilityLogicResult result in abilityResultList)
            {
                result.TargetHitOnCast.TakeDamage(result.DealedDamage);
                Debug.Log(result.TargetHitOnCast.GetCurrentHealth());
            }
        }

        public Action FirstSpecialAbilityImplementation()
        {
            return () =>
            {
                Debug.LogError(ErrorMessages.FirstSpecialAbilityDebug);
            };
        }

        public Action SecondDefaultAbilityImplementation()
        {
            return () =>
            {
                Debug.LogError(ErrorMessages.SecondDefaultAbilityDebug);
            };
        }

        public Action SecondSpecialAbilityImplementation()
        {
            return () =>
            {
                Debug.LogError(ErrorMessages.SecondSpecialAbilityDebug);
            };
        }

        public Action ThirdSpecialAbilityImplementation()
        {
            return () =>
            {
                Debug.LogError(ErrorMessages.ThirdSpecialAbilityDebug);
            };
        }
    }
}
