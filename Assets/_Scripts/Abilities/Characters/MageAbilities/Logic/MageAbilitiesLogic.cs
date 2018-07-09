using Assets._Scripts.Abilities.Abstract;
using Assets._Scripts.Abilities.Logic;
using Assets._Scripts.Abilities.Logic.Results;
using Assets._Scripts.Characters;
using Assets._Scripts.Conditions;
using Assets._Scripts.OutputMessages;
using Assets._Scripts.Player;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Scripts.Abilities.Characters.MageAbilities.Logic
{
    internal class MageAbilitiesLogic : MonoBehaviour, IAbilityImplementation
    {
        private Mage mageClass;
        private ConditionManager conditionManager;

        private void Awake()
        {
            mageClass = gameObject.GetComponent<Mage>();
            conditionManager = gameObject.AddComponent<ConditionManager>();
        }

        public void FirstDefaultAbilityImplementation()
        {
            TargetDetectionResult targetDetectionResult = RangedAbilityLogic.CastSingleAbilityForward(mageClass, mageClass.GetFirstDefaultAbility() as IAbilityWithGameEffect);

            if (targetDetectionResult.TargetHitOnCast != null)
            {
                targetDetectionResult.TargetHitOnCast.TakeDamage(targetDetectionResult.DealedDamage);
            }
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
