using Assets._Scripts.Abilities.Abstract;
using Assets._Scripts.Abilities.Logic.Results;
using Assets._Scripts.Characters.Abstract;
using Assets._Scripts.Characters.Abstract.Interfaces;
using UnityEngine;

internal class RangedAbilityObject : MonoBehaviour
{
    private RangedCharacterClass castingCharacter;
    private IAbilityWithGameEffect castedAbility;

    public TargetDetectionResult targetDetectionResult;

    //public delegate void ColliderHitHandler();
   // public  event ColliderHitHandler OnColliderHit;

    public void AddParams(RangedCharacterClass rangedCharacterClass, IAbilityWithGameEffect ability)
    {
        castingCharacter = rangedCharacterClass;
        castedAbility = ability;
    }

    public TargetDetectionResult GetHitColliderDetectionResult()
    {
        return targetDetectionResult;
    }

    private void OnTriggerEnter(Collider targetCollider)
    {
        targetDetectionResult = BuildHitColliderDetectionResult(targetCollider);
        Destroy(this.gameObject);
    }

    private void OnDestroy()
    {
        //todo send information about hit (trigger)
    }

    private TargetDetectionResult BuildHitColliderDetectionResult(Collider targetCollider)
    {
        float distanceToTarget = Vector3.Distance(castingCharacter.transform.position, targetCollider.transform.position);
        Vector3 direction = targetCollider.transform.position - castingCharacter.transform.position;
        float angleOfTarget = Vector3.Angle(direction, castingCharacter.transform.forward);

        TargetDetectionResult targetDetectionResult = TargetDetectionResult.BuildAbilityLogicResult(castedAbility, 
                                                                                                    targetCollider, 
                                                                                                    distanceToTarget);
        if (targetCollider.GetComponent<ICharacterClass>() != null)
        {
            targetDetectionResult = TargetDetectionResult.BuildAbilityLogicResult(targetCollider.GetComponent<ICharacterClass>(),
                                                          castedAbility,
                                                          castedAbility.BaseDamage,
                                                          distanceToTarget,
                                                          angleOfTarget);
        }

        return targetDetectionResult;
    }
}