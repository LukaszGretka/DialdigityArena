using Assets._Scripts.Abilities.Abstract;
using Assets._Scripts.Characters;
using System;
using UnityEngine;

namespace Assets._Scripts.Abilities.WarriorAbilities.Logic
{
    class WarriorAbilitiesLogic : IAbilityImplementation
    {
        private static Warrior warrior = new Warrior();

        public Action FirstDefaultAbilityImplementation()
        {
            return () =>
            {
                Debug.LogError(ErrorMessages.FirstDefaultAbilityDebug);
            };
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
