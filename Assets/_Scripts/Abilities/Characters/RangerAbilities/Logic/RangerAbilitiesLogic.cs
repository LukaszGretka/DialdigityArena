using Assets._Scripts.Abilities.Abstract;
using Assets._Scripts.Abilities.Logic;
using Assets._Scripts.OutputMessages;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Scripts.Abilities.Characters.RangerAbilities.Logic
{
    internal class RangerAbilitiesLogic : IAbilityImplementation
    {
        public List<AbilityLogicResult> FirstDefaultAbilityImplementation()
        {
            Debug.LogError(ErrorMessages.FirstDefaultAbilityDebug);
            throw new NotImplementedException();
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
