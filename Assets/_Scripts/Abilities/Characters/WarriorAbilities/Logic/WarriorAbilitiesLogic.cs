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
                Debug.Log("im in the first default ability implementation");
            };
        }

        public Action FirstSpecialAbilityImplementation()
        {
            return () =>
            {
                Debug.Log("im in the first special ability implementation");
            };
        }

        public Action SecondDefaultAbilityImplementation()
        {
            return () =>
            {
                Debug.Log("im in the second default ability implementation");
            };
        }

        public Action SecondSpecialAbilityImplementation()
        {
            return () =>
            {
                Debug.Log("im in the second special ability implementation");
            };
        }

        public Action ThirdSpecialAbilityImplementation()
        {
            return () =>
            {
                Debug.Log("im in the third special ability implementation");
            };
        }
    }
}
