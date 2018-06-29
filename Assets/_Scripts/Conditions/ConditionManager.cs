using Assets._Scripts.Characters.Abstract.Interfaces;
using System.Collections.Generic;

namespace Assets._Scripts.Conditions 
{
    internal class ConditionManager : ConditionEffectsRepository
    {
        internal void ApplyCondition(ICharacterClass characterClass, List<KeyValuePair<IConditions,float>> conditions)
        {
            foreach (KeyValuePair<IConditions, float> condition in conditions)
            {
                base.AddConditionToTarget(characterClass, condition.Key);
            }
        }

        internal void RemoveCondition(ICharacterClass characterClass, List<KeyValuePair<IConditions, float>> conditions)
        {
            foreach (KeyValuePair<IConditions, float> condition in conditions)
            {
                base.RemoveConditionFromTarget(characterClass, condition.Key);
            }
        }
    }
}
