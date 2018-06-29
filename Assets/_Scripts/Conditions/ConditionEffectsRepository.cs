using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Player;
using System;
using System.Collections;
using UnityEngine;

namespace Assets._Scripts.Conditions
{
    internal class ConditionEffectsRepository : MonoBehaviour
    {
        protected void AddConditionToTarget(ICharacterClass characterClass, IConditions condition)
        {
            IEnumerator conditionFunction = ConditionEffectPerTime(characterClass, condition);

            for (float i = 0f; i <= condition.DurationTime; i++)
            {
                StartCoroutine(conditionFunction);

                Debug.Log(condition.Name + " dealed " + condition.DamagePerTick + " damage to "
                    + characterClass.GetType().Name + "." + i.ToString() + "tick." +
                    (condition.DurationTime - i).ToString() + " ticks left");
            }
        }

        protected void RemoveConditionFromTarget(ICharacterClass characterClass, IConditions condition)
        {
            throw new NotImplementedException();
        }

        //TOOD implement constant value from condition tick
        private IEnumerator ConditionEffectPerTime(ICharacterClass characterClass, IConditions condition)
        {
            characterClass.TakeDamage(condition.DamagePerTick);
            yield return new WaitForSeconds(1f);
        }
    }
}
