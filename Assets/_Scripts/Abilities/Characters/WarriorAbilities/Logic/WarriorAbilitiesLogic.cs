using Assets._Scripts.Abilities.Abstract;
using Assets._Scripts.Abilities.Logic;
using Assets._Scripts.Characters;
using Assets._Scripts.Conditions;
using Assets._Scripts.OutputMessages;
using Assets._Scripts.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets._Scripts.Abilities.WarriorAbilities.Logic
{
    class WarriorAbilitiesLogic : MeleeAbilityLogic, IAbilityImplementation
    {
        private Warrior warriorClass;
        private ConditionManager conditionManager;

        private void Awake()
        {
            warriorClass = gameObject.GetComponent<Warrior>();
            conditionManager = gameObject.AddComponent<ConditionManager>();
        }

        /// <summary> Implementation of first warrior ability - Swipe | Multitarget ability | </summary>
        public void FirstDefaultAbilityImplementation()
        {
            List<AbilityLogicResult> abilityResultList = UseAreaMeleeAbility(warriorClass, warriorClass.GetFirstDefaultAbility());

            foreach (AbilityLogicResult result in abilityResultList) //hit multiple targets
            {
                result.TargetHitOnCast.TakeDamage(result.DealedDamage);
            }
        }
        /// <summary> Implementation of first special warrior ability - Brutal Strike | Single target ability | </summary>
        public void FirstSpecialAbilityImplementation()
        {
            List<AbilityLogicResult> abilityResultList = UseAreaMeleeAbility(warriorClass, warriorClass.GetFirstSpecialAbility());
            AbilityLogicResult result = abilityResultList.First();

            result.TargetHitOnCast.TakeDamage(result.DealedDamage);
            conditionManager.AddConditionToTarget(result.TargetHitOnCast, result.HitWithAbility.Conditions);
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
