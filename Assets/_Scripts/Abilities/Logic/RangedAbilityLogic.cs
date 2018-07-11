using Assets._Scripts.Abilities.Abstract;
using Assets._Scripts.Abilities.Logic.Results;
using Assets._Scripts.Characters.Abstract;
using Assets._Scripts.OutputMessages;
using System;
using System.Linq;
using UnityEngine;

namespace Assets._Scripts.Abilities.Logic
{
    internal class RangedAbilityLogic : MonoBehaviour
    {
        internal static TargetDetectionResult CastSingleAbilityForward(RangedCharacterClass rangedClass, IAbilityWithGameEffect ability)
        {
            TargetDetectionResult targetDetectionResult = new TargetDetectionResult();

            if (ability.IsRanged)
            {
                Transform spellCastingSpotTransform = rangedClass.GetComponentsInChildren<Transform>()
                                                                 .Where(x => x.name == "SpellCastingSpot")
                                                                 .SingleOrDefault();

                if (spellCastingSpotTransform != null)
                {
                    var instantiatedObject = Instantiate(ability.AbilityGameModel, 
                                spellCastingSpotTransform.position, 
                                Quaternion.Euler(rangedClass.transform.eulerAngles.x, rangedClass.transform.eulerAngles.y, 0f));

                    instantiatedObject.GetComponent<Rigidbody>().AddForce(rangedClass.transform.forward * 20f, ForceMode.Impulse);
                }
                else
                {
                    Debug.LogError("There is no spawning point set in current character object");
                }
            }
            else
            {
                Debug.LogError(ErrorMessages.WrongTypeOfAbility);
                targetDetectionResult = TargetDetectionResult.BuildAbilityLogicResult(null, ability, 0f);
            }

            return targetDetectionResult;
        }

        internal static TargetDetectionResult CastAreaAbilityAtCurrentPossition(RangedCharacterClass rangedClass, IAbility ability)
        {
            throw new NotImplementedException();
        }

        internal static TargetDetectionResult CastSingleAbilityAtSelectedPossition(RangedCharacterClass rangedClass, IAbility ability, Vector3 possition)
        {
            throw new NotImplementedException();
        }

        internal static TargetDetectionResult CastAreaAbilityAtSelectedPossition(RangedCharacterClass rangedClass, IAbility ability, Vector3 possition)
        {
            throw new NotImplementedException();
        }
    }
}
