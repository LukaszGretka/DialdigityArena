using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Config;
using Assets._Scripts.Player;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Scripts.Conditions
{
    internal class ConditionManager : MonoBehaviour
    {
        internal void AddConditionToTarget(ICharacterClass characterClass, List<IConditions> conditions)
        {
            foreach (IConditions condition in conditions)
            {
                IEnumerator conditionFunction = ConditionEffectPerTime(characterClass, condition, ConfigValues.ConditionInitialDelayTime);
                StartCoroutine(conditionFunction);
            }
        }

        internal void RemoveConditionFromTarget(ICharacterClass characterClass, IConditions condition)
        {
            throw new NotImplementedException();
        }

        //TOOD implement constant value from condition tick
        private IEnumerator ConditionEffectPerTime(ICharacterClass characterClass, IConditions condition, float initialDelay)
        {
            yield return new WaitForSeconds(initialDelay);

            for (float i = default(float); i < condition.DurationTime; i++)
            {
                characterClass.TakeDamage(condition.DamagePerTick);

                Debug.Log(condition.Name + " dealed " + condition.DamagePerTick + " damage to "
                    + characterClass.GetType().Name + "." + i.ToString() + " tick |" +
                    (condition.DurationTime - i).ToString() + " ticks left. " + characterClass.GetCurrentHealth() + " HP left");

                yield return new WaitForSeconds(ConfigValues.DefaultConditionIntervalTime);
            }
        }
    }
}