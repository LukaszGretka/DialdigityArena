using Assets._Scripts.Characters;
using Assets._Scripts.Characters.Abstract;
using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Characters.Abstract.PartialBaseCharacterClass;
using Assets._Scripts.OutputMessages;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Scripts.Abilities.Logic
{
    public class MeleeAbilityLogic
    {
        internal List<AbilityLogicResult> UseAreaMeleeAbility(MeleeCharacterClass meleeClass, IAbility ability)
        {
            List<AbilityLogicResult> AbilityLogicResultList = new List<AbilityLogicResult>();

            if (ability.IsRanged)
            {
                Debug.LogError(ErrorMessages.WrongTypeOfAbility);
                AbilityLogicResultList.Add(AbilityLogicResult.BuildAbilityLogicResult(null, ability, 0f));

                return AbilityLogicResultList;
            }

            Collider[] detectedTargets = Physics.OverlapSphere(meleeClass.transform.position, ability.Range);

            if (detectedTargets.Length > 0)
            {
                foreach (Collider targetCollider in detectedTargets)
                {
                    if (targetCollider.CompareTag("Target"))
                    {
                        float distanceToTarget = Vector3.Distance(meleeClass.transform.position, targetCollider.transform.position);
                        Vector3 direction = targetCollider.transform.position - meleeClass.transform.position;
                        float angleOfTarget = Vector3.Angle(direction, meleeClass.transform.forward);

                        if (angleOfTarget <= (ability.HitAngle * 0.5f))
                        {
                            AbilityLogicResultList.Add(AbilityLogicResult.BuildAbilityLogicResult( targetCollider.GetComponent<ICharacterClass>(), 
                                                                                                   ability,
                                                                                                   ability.BaseDamage,
                                                                                                   distanceToTarget,
                                                                                                   angleOfTarget));
                        }
                    }
                }
            }

            return AbilityLogicResultList;
        }
    }
}
