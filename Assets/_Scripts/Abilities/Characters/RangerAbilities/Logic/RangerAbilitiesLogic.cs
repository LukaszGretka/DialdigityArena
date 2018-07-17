using Assets._Scripts.Abilities.Abstract;
using Assets._Scripts.Abilities.Logic;
using Assets._Scripts.Abilities.Logic.Results;
using Assets._Scripts.Characters;
using Assets._Scripts.Conditions;
using Assets._Scripts.OutputMessages;
using Assets._Scripts.Player;
using System;
using System.Collections;
using UnityEngine;

namespace Assets._Scripts.Abilities.Characters.RangerAbilities.Logic
{
    internal class RangerAbilitiesLogic : MonoBehaviour, IAbilityImplementation
    {
        private Ranger rangerClass;
        private ConditionManager conditionManager;
        private RangedAbilityLogic rangedAbilityLogic;

        private void Awake()
        {
            rangerClass = gameObject.GetComponent<Ranger>();
            conditionManager = gameObject.AddComponent<ConditionManager>();
            rangedAbilityLogic = gameObject.AddComponent<RangedAbilityLogic>();
        }

        public IEnumerator FirstDefaultAbilityImplementation()
        {
            rangedAbilityLogic.PerformCastForwardWithInstantiate(rangerClass, rangerClass.GetFirstDefaultAbility() as IAbilityWithGameEffect);

            yield return new WaitUntil(() => RangedAbilityObject.targetDetectionResult != null);

            TargetDetectionResult result = RangedAbilityObject.GetHitColliderDetectionResult();
            RangedAbilityObject.targetDetectionResult = null;

            result.TargetHitOnCast.TakeDamage(result.HitWithAbility.BaseDamage);
        }

        public IEnumerator FirstSpecialAbilityImplementation()
        {
            throw new NotImplementedException();
        }

        public IEnumerator SecondDefaultAbilityImplementation()
        {
            throw new NotImplementedException();
        }

        public IEnumerator SecondSpecialAbilityImplementation()
        {
            throw new NotImplementedException();
        }

        public IEnumerator ThirdSpecialAbilityImplementation()
        {
            throw new NotImplementedException();
        }
    }
}
