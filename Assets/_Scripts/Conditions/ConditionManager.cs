using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Conditions.Abstract;
using Assets._Scripts.Config;
using Assets._Scripts.OutputMessages;
using Assets._Scripts.Player;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace Assets._Scripts.Conditions
{
    internal class ConditionManager : NetworkBehaviour
    {
        internal void AddConditionsToTarget(ICharacterClass characterClass, List<ICondition> conditions)
        {
            foreach (ICondition condition in conditions)
            {

                //Implementation of states on player/target
                IEnumerator conditionEffectRoutine = 
                    condition.EffectType == Enum.ConditionEffectType.EffectOverTime ?
                    ApplyConditionEffectOverTime( () => { condition.ConditionImplementation.ApplyConditionEffect(characterClass); }, condition)
                    : ApplyConditionEffect( () => { condition.ConditionImplementation.ApplyConditionEffect(characterClass); });

                StartCoroutine(conditionEffectRoutine);
            }
        }

        internal void RemoveConditionFromTarget(ICharacterClass characterClass, ICondition condition)
        {
            throw new NotImplementedException();
        }

        private IEnumerator ApplyConditionEffectOverTime(Action conditionAction, ICondition condition, float initialDelay = ConfigValues.ConditionInitialDelayTime)
        {
            yield return new WaitForSeconds(initialDelay);

            for (float i = default(float); i < condition.DurationTime; i++)
            {
                conditionAction.Invoke();
                yield return new WaitForSeconds(ConfigValues.DefaultConditionIntervalTime);
            }
        }

        private IEnumerator ApplyConditionEffect(Action conditionAction)
        {
            //apply effect
            //yield return new WaitForSeconds(condition.DurationTime);
            //discard effect
            throw new NotImplementedException();
        }
    }
}