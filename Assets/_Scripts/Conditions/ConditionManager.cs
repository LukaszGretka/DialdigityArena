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
                IEnumerator conditionEffectRoutine = condition.EffectType == Enum.ConditionEffectType.EffectOverTime ?
                       ApplyConditionEffectOverTime(characterClass, condition as IConditionEffectOverTime, condition.ConditionImplementation.GetConditionImplementation())
                    :  ApplyConditionEffect(characterClass, condition as IConditionConstant, condition.ConditionImplementation.GetConditionImplementation());

                StartCoroutine(conditionEffectRoutine);
            }
        }

        internal void DispelConditionEffect(ICharacterClass characterClass, ICondition condition)
        {
            characterClass.RemoveConditionEffect(condition);
        }

        private IEnumerator ApplyConditionEffectOverTime(ICharacterClass characterClass, IConditionEffectOverTime condition, Action<ICharacterClass, ICondition> conditionAction)
        {
            characterClass.ApplyConditionEffect(condition);

            yield return new WaitForSeconds(condition.InitializationTime);

            for (float i = default(float); i < condition.ConditionIterations; i++)
            {
                conditionAction.Invoke(characterClass, condition);
                yield return new WaitForSeconds(condition.ConditionIntervalTime);
            }

            characterClass.RemoveConditionEffect(condition);
        }

        private IEnumerator ApplyConditionEffect(ICharacterClass characterClass, IConditionConstant condition, Action<ICharacterClass, ICondition> conditionAction)
        {
            characterClass.ApplyConditionEffect(condition);
            conditionAction.Invoke(characterClass, condition);

            yield return new WaitForSeconds(condition.DurationTime);
            characterClass.RemoveConditionEffect(condition);
        }
    }
}