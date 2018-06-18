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
                Debug.Log("im in the first degault ability impelemntation");
            };
        }

        public Action FirstSpecialAbilityImplementation()
        {
            // TODO Kamil implement anoymous function for each abilities in every class just like up ^
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
