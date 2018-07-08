using Assets._Scripts.Abilities.Logic.Results;
using Assets._Scripts.Characters.Abstract;
using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.OutputMessages;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets._Scripts.Abilities.Logic
{
    internal class MeleeAbilityLogic : MonoBehaviour
    {
        /// <summary> Detects and attack one nearest game objects tagged as "Target" on ability's range value area (include skill hit angle). </summary>
        internal static TargetDetectionResult MeleeAttackAtSingleTarget(MeleeCharacterClass meleeClass, IAbility ability)
        {
            List<TargetDetectionResult> result = MeleeAttackInArea(meleeClass, ability);
            result.OrderByDescending(x => x.HitDistance);

            return result.Any() ? result.First() : TargetDetectionResult.BuildAbilityLogicResult(null, ability, 0f);
        }

        /// <summary> Detects all game objects tagged as "Target" on ability's range value area (include skill hit angle). </summary>
        internal static List<TargetDetectionResult> MeleeAttackInArea(MeleeCharacterClass meleeClass, IAbility ability)
        {
            List<TargetDetectionResult> AbilityLogicResultList = new List<TargetDetectionResult>();

            // If ability is type of ranged, return default result and print error in unity's console.
            if (ability.IsRanged)
            {
                Debug.LogError(ErrorMessages.WrongTypeOfAbility);
                AbilityLogicResultList.Add(TargetDetectionResult.BuildAbilityLogicResult(null, ability, 0f));

                return AbilityLogicResultList;
            }

            // Detect all colliders in "ability.Range" radius value.
            Collider[] detectedTargets = Physics.OverlapSphere(meleeClass.transform.position, ability.Range);

            // If any collider has been detected - proceed.
            if (detectedTargets.Length > 0)
            {
                // For each collider, which has been found - execute operations in the loop.
                foreach (Collider targetCollider in detectedTargets)
                {
                    // Check if collider is makred as Target (if the tag was set on the game object).
                    if (targetCollider.CompareTag("Target"))
                    {
                        float distanceToTarget = Vector3.Distance(meleeClass.transform.position, targetCollider.transform.position);
                        Vector3 direction = targetCollider.transform.position - meleeClass.transform.position;
                        float angleOfTarget = Vector3.Angle(direction, meleeClass.transform.forward);

                        // Check if current target is in the "Hit angle" of used skill.
                        if (angleOfTarget <= (ability.HitAngle * 0.5f))
                        {
                            AbilityLogicResultList.Add(TargetDetectionResult.BuildAbilityLogicResult(targetCollider.GetComponent<ICharacterClass>(),
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
