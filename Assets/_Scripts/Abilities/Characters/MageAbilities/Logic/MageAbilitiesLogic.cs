using Assets._Scripts.Abilities.Abstract;
using System;
using UnityEngine;

namespace Assets._Scripts.Abilities.Characters.MageAbilities.Logic
{
    internal class MageAbilitiesLogic : IAbilityImplementation
    {
        public Action FirstDefaultAbilityImplementation()
        {
            return () =>
            {
                Debug.Log("Im mage first default ability implementation method!");
            };
        }

        public Action FirstSpecialAbilityImplementation()
        {
            throw new NotImplementedException();
        }

        public Action SecondDefaultAbilityImplementation()
        {
            throw new NotImplementedException();
        }

        public Action SecondSpecialAbilityImplementation()
        {
            throw new NotImplementedException();
        }

        public Action ThirdSpecialAbilityImplementation()
        {
            throw new NotImplementedException();
        }
    }
}
