using Assets._Scripts.Abilities.Abstract;
using Assets._Scripts.Abilities.Logic;
using Assets._Scripts.Characters;
using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.OutputMessages;
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

        /// <summary>
        /// Swipe
        /// </summary>
        public List<AbilityLogicResult> FirstDefaultAbilityImplementation()
        {
            return UseAreaMeleeAbility(warriorClass, warriorClass.GetFirstDefaultAbility());
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
