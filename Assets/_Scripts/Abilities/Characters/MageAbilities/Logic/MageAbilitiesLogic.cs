using Assets._Scripts.Abilities.Abstract;
using Assets._Scripts.Abilities.Logic;
using Assets._Scripts.Abilities.Logic.Results;
using Assets._Scripts.Characters;
using Assets._Scripts.Characters.Abstract;
using Assets._Scripts.Conditions;
using Assets._Scripts.Player;
using System;
using System.Collections;
using System.Linq;
using UnityEngine;

namespace Assets._Scripts.Abilities.Characters.MageAbilities.Logic
{
    internal class MageAbilitiesLogic : MonoBehaviour, IAbilityImplementation
    {
        private Mage mageClass;
        private ConditionManager conditionManager;
        private RangedAbilityLogic rangedAbilityLogic;

        private void Awake()
        {
            mageClass = gameObject.GetComponent<Mage>();
            conditionManager = gameObject.AddComponent<ConditionManager>();
            rangedAbilityLogic = gameObject.AddComponent<RangedAbilityLogic>();
        }
        /// <summary> Implementation of first mage ability - MagicMissile | Single target ability | </summary>
        public IEnumerator FirstDefaultAbilityImplementation()
        {
            var abilityGameObjectInst = rangedAbilityLogic.PerformCastForwardWithInstantiate(mageClass, mageClass.GetFirstDefaultAbility() as IAbilityWithGameEffect);

            yield return new WaitUntil(() => abilityGameObjectInst.targetDetectionResult != null);
            TargetDetectionResult result = abilityGameObjectInst.GetHitColliderDetectionResult();
            result.TargetHitOnCast.TakeDamage(result.HitWithAbility.BaseDamage);
        }

        public IEnumerator FirstSpecialAbilityImplementation()
        {
            throw new NotImplementedException();
        }

        public IEnumerator SecondDefaultAbilityImplementation()
        {
            //Self buff with damage reduction
            conditionManager.AddConditionsToTarget(mageClass, mageClass.GetSecondDefaultAbility().Conditions.Where(x => x.GetType() == typeof(DamageReduction)).ToList());
            yield return new WaitForEndOfFrame();
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