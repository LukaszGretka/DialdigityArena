using Assets._Scripts.Abilities;
using Assets._Scripts.Abilities.Performance;
using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Conditions.Abstract;
using System;

namespace Assets._Scripts.Conditions.Harmful.Logic
{
    internal class StunLogic : IConditionImplementation
    {
        public Action<ICharacterClass, ICondition> GetConditionImplementationApply()
        {
            return (characterClass, condition) =>
            {

                characterClass.SetCurrentMovementSpeed(0f);
                //TODO
                //1. Set movement speed and mouse rotation to 0 (player can't move)
                //2. Set cooldown of spells (duration of stun)
            };
        }


            public Action<ICharacterClass, ICondition> GetConditionImplementationRemove()
            {
                return (characterClass, condition) =>
                {
                    characterClass.SetCurrentMovementSpeed(characterClass.GetBaseMovementSpeed());
                };
            }
        }
    }
