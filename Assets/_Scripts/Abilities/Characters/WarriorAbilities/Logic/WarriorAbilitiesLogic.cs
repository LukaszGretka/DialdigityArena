using Assets._Scripts.Abilities.Abstract;
using Assets._Scripts.Abilities.Logic;
using Assets._Scripts.Abilities.Logic.Results;
using Assets._Scripts.Characters;
using Assets._Scripts.Conditions;
using Assets._Scripts.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets._Scripts.Abilities.WarriorAbilities.Logic
{
    class WarriorAbilitiesLogic : MonoBehaviour, IAbilityImplementation
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
            List<TargetDetectionResult> abilityResultList = MeleeAbilityLogic.MeleeAttackInArea(warriorClass, warriorClass.GetFirstDefaultAbility());

            foreach (TargetDetectionResult result in abilityResultList) //hits multiple targets
            {
                result.TargetHitOnCast.TakeDamage(result.DealedDamage);
            }           
        }
        /// <summary> Implementation of first special warrior ability - Brutal Strike | Single target ability | </summary>
        public void FirstSpecialAbilityImplementation()
        {
            TargetDetectionResult targetDetectionResult = MeleeAbilityLogic.MeleeAttackAtSingleTarget(warriorClass, warriorClass.GetFirstSpecialAbility());

            if (targetDetectionResult.TargetHitOnCast != null)
            {
                targetDetectionResult.TargetHitOnCast.TakeDamage(targetDetectionResult.DealedDamage);
                conditionManager.AddConditionsToTarget(targetDetectionResult.TargetHitOnCast, targetDetectionResult.HitWithAbility.Conditions);               
            }           
        }

        /// <summary> Implementation of second default warrior ability - Block | Self Cast | </summary>
        public void SecondDefaultAbilityImplementation()
        {
            conditionManager.AddConditionsToTarget(warriorClass, warriorClass.GetSecondDefaultAbility().Conditions);
        }

        /// <summary> Implementation of second special warrior ability - Leap | Ground cast | </summary>
        public void SecondSpecialAbilityImplementation()
        {
            warriorClass.TranslatePossitionOnClick(warriorClass.GetSecondSpecialAbility());
        }

        /// <summary> Implementation of third special warrior ability - Bash | Single target ability | </summary>
        public void ThirdSpecialAbilityImplementation()
        {
            TargetDetectionResult targetDetectionResult = MeleeAbilityLogic.MeleeAttackAtSingleTarget(warriorClass, warriorClass.GetThirdSpecialAbility());

            if (targetDetectionResult.TargetHitOnCast != null)
            {
                conditionManager.AddConditionsToTarget(targetDetectionResult.TargetHitOnCast, targetDetectionResult.HitWithAbility.Conditions);
            }
        }
    }
}
