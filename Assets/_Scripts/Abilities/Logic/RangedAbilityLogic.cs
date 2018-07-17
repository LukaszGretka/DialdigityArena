using Assets._Scripts.Abilities.Abstract;
using Assets._Scripts.Characters.Abstract;
using Assets._Scripts.OutputMessages;
using System;
using System.Linq;
using UnityEngine;

namespace Assets._Scripts.Abilities.Logic
{
    internal class RangedAbilityLogic : MonoBehaviour
    {
        public void PerformCastForwardWithInstantiate(RangedCharacterClass rangedClass, IAbilityWithGameEffect ability)
        {
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

                    instantiatedObject.AddComponent<RangedAbilityObject>().AddParams(rangedClass, ability);
                }
                else
                {
                    Debug.LogError(ErrorMessages.SpawnPointNotSet);
                }
            }
            else
            {
                Debug.LogError(ErrorMessages.WrongTypeOfAbility);
            }
        }

        internal void CastAreaAbilityAtCurrentPossition(RangedCharacterClass rangedClass, IAbility ability)
        {
            throw new NotImplementedException();
        }

        internal void CastSingleAbilityAtSelectedPossition(RangedCharacterClass rangedClass, IAbility ability, Vector3 possition)
        {
            throw new NotImplementedException();
        }

        internal void CastAreaAbilityAtSelectedPossition(RangedCharacterClass rangedClass, IAbility ability, Vector3 possition)
        {
            throw new NotImplementedException();
        }
    }
}