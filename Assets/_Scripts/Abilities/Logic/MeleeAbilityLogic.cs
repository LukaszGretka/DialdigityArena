using Assets._Scripts.Characters;
using Assets._Scripts.Characters.Abstract;
using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Characters.Abstract.PartialBaseCharacterClass;
using Assets._Scripts.OutputMessages;
using UnityEngine;

namespace Assets._Scripts.Abilities.Logic
{
    public class MeleeAbilityLogic
    {
        private float standardHitAngle = 90f;

        internal virtual void PerformSingleHit(MeleeCharacterClass meleeClass, IAbility ability)
        {
            if (ability.IsRanged)
            {
                Debug.LogError(ErrorMessages.WrongTypeOfAbility);
                return;
            }

            Collider[] detectedTargets = Physics.OverlapSphere(meleeClass.transform.position, ability.Range);

            if (detectedTargets.Length > 0)
            {
                foreach (Collider target in detectedTargets)
                {
                    if (target.CompareTag("Target"))
                    {
                        float distanceToTarget = Vector3.Distance(meleeClass.transform.position, target.transform.position);
                        float angleOfTarget = Vector3.Angle(meleeClass.transform.forward, target.transform.position);

                        //TODO IMPLEMENT ANGLE FOR HIT
                        Debug.Log("HIT ON: " + target.name + " distance: " + distanceToTarget + " angle: " + angleOfTarget);
                    }
                }
            }
        }

    }
}
