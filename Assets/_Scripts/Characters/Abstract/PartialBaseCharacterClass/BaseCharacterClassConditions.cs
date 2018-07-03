using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Conditions;
using Assets._Scripts.OutputMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets._Scripts.Characters.Abstract.PartialBaseCharacterClass
{
    abstract partial class BaseCharacterClass
    {
        protected void ApplyConditionEffect(ICondition condition)
        {
            var conditionToApply = new PlayerConditionState() { ActiveCondition = condition };

            if (!PlayerConditionState.Contains(conditionToApply))
            {
                PlayerConditionState.Add(conditionToApply);
            }
        }

        protected void RemoveLastConditionEffect()
        {
            if (PlayerConditionState.Any())
            {
                PlayerConditionState.Remove(PlayerConditionState.ElementAt(PlayerConditionState.Count - 1));
            }
        }

        protected void RemoveConditionEffect(ICondition condition)
        {
            if (!PlayerConditionState.Any())
            {
                Debug.Log(ErrorMessages.NoConditionToRemove);
                return;
            }

            var conditionToRemove = PlayerConditionState.ToList().SingleOrDefault(x => x.ActiveCondition == condition);

            if (conditionToRemove != default(PlayerConditionState))
            {
                PlayerConditionState.Remove(conditionToRemove);
            }
        }
    }
}
