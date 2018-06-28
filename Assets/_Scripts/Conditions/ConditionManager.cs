
using Assets._Scripts.Characters.Abstract.Interfaces;
using System.Collections.Generic;

namespace Assets._Scripts.Conditions 
{
    static class ConditionManager
    {
        internal static void ApplyCondition(this ICharacterClass characterClass, List<KeyValuePair<IConditions,float>> conditions)
        {
            foreach (KeyValuePair<IConditions, float> condition in conditions)
            {
                condition.Key.AddConditionToTarget(characterClass,condition.Value);
            }
        }

        internal static void RemoveCondition(this ICharacterClass characterClass, List<KeyValuePair<IConditions, float>> conditions)
        {
            foreach (KeyValuePair<IConditions, float> condition in conditions)
            {
                condition.Key.RemoveConditionFromTarget(characterClass);
            }
        }
    }
}
