using Assets._Scripts.Abilities.Abstract;
using Assets._Scripts.Abilities.Logic;
using Assets._Scripts.Abilities.Logic.Results;
using Assets._Scripts.Characters;
using Assets._Scripts.Conditions;
using Assets._Scripts.Player;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets._Scripts.Abilities.WarriorAbilities.Logic
{
    class WarriorAbilitiesLogic : MonoBehaviour, IAbilityImplementation
    {
        private Warrior warriorClass;
        private ConditionManager conditionManager;
        private MeleeAbilityLogic meleeAbilityLogic;
        private SpecialMovementAbilityLogic movementAbilityLogic;

        private void Awake()
        {
            warriorClass = gameObject.GetComponent<Warrior>();
            conditionManager = gameObject.AddComponent<ConditionManager>();
            meleeAbilityLogic = gameObject.AddComponent<MeleeAbilityLogic>();
            movementAbilityLogic = gameObject.AddComponent<SpecialMovementAbilityLogic>();
        }

        /// <summary> Implementation of first warrior ability - Swipe | Multitarget ability | </summary>
        public IEnumerator FirstDefaultAbilityImplementation()
        {
            List<TargetDetectionResult> abilityResultList = meleeAbilityLogic.MeleeAttackInArea(warriorClass, warriorClass.GetFirstDefaultAbility());

            foreach (TargetDetectionResult result in abilityResultList) //hits multiple targets
            {
                result.TargetHitOnCast.TakeDamage(result.DealedDamage);
            }

            yield return new WaitForFixedUpdate();
        }
        /// <summary> Implementation of first special warrior ability - Brutal Strike | Single target ability | </summary>
        public IEnumerator FirstSpecialAbilityImplementation()
        {

            TargetDetectionResult targetDetectionResult = meleeAbilityLogic.MeleeAttackAtSingleTarget(warriorClass, warriorClass.GetFirstSpecialAbility());

            if (targetDetectionResult.TargetHitOnCast != null)
            {
                targetDetectionResult.TargetHitOnCast.TakeDamage(targetDetectionResult.DealedDamage);
                conditionManager.AddConditionsToTarget(targetDetectionResult.TargetHitOnCast, targetDetectionResult.HitWithAbility.Conditions);               
            }

            yield return new WaitForFixedUpdate();
        }

        /// <summary> Implementation of second default warrior ability - Block | Self Cast | </summary>
        public IEnumerator SecondDefaultAbilityImplementation()
        {
            conditionManager.AddConditionsToTarget(warriorClass, warriorClass.GetSecondDefaultAbility().Conditions);

            yield return new WaitForFixedUpdate();
        }

        /// <summary> Implementation of second special warrior ability - Leap | Ground cast | </summary>
        public IEnumerator SecondSpecialAbilityImplementation()
        {
            movementAbilityLogic.TranslatePossitionOnClick(warriorClass, warriorClass.GetSecondSpecialAbility());

            yield return new WaitForFixedUpdate();
        }

        /// <summary> Implementation of third special warrior ability - Bash | Single target ability | </summary>
        public IEnumerator ThirdSpecialAbilityImplementation()
        {
            TargetDetectionResult targetDetectionResult = meleeAbilityLogic.MeleeAttackAtSingleTarget(warriorClass, warriorClass.GetThirdSpecialAbility());

            if (targetDetectionResult.TargetHitOnCast != null)
            {
                conditionManager.AddConditionsToTarget(targetDetectionResult.TargetHitOnCast, targetDetectionResult.HitWithAbility.Conditions);
            }

            yield return new WaitForFixedUpdate();
        }
    }
}
