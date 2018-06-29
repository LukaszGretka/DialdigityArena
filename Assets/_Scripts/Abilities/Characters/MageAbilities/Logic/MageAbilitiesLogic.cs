using Assets._Scripts.Abilities.Abstract;
using Assets._Scripts.Abilities.Logic;
using Assets._Scripts.OutputMessages;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Scripts.Abilities.Characters.MageAbilities.Logic
{
    internal class MageAbilitiesLogic : IAbilityImplementation
    {
        public void FirstDefaultAbilityImplementation()
        {
            Debug.LogError(ErrorMessages.FirstDefaultAbilityDebug);
            throw new NotImplementedException();
        }

        public void FirstSpecialAbilityImplementation()
        {
            throw new NotImplementedException();
        }

        public void SecondDefaultAbilityImplementation()
        {
            throw new NotImplementedException();
        }

        public void SecondSpecialAbilityImplementation()
        {
            throw new NotImplementedException();
        }

        public void ThirdSpecialAbilityImplementation()
        {
            throw new NotImplementedException();
        }
    }
}
