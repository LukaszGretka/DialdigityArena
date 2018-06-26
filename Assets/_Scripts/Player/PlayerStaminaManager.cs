using Assets._Scripts.Characters.Abstract.Interfaces;
using System.Collections;
using UnityEngine;

namespace Assets._Scripts.Player
{
    public static class PlayerStaminaManager
    {
        public static float AddStamina(this ICharacterClass characterClass, float staminaPointsToAdd)
        {
            if (characterClass.GetCurrentStamina() + staminaPointsToAdd > characterClass.GetMaximumStamina())
            {
                return characterClass.GetMaximumStamina();
            }
            else
            {
                return characterClass.GetCurrentStamina() + staminaPointsToAdd;
            }
        }

        public static bool CheckIfEnoughStamina(this ICharacterClass characterClass)
        {
            return characterClass.GetCurrentStamina() <= default(float) ? true : false;
        }

        public static float SubstractStamina(this ICharacterClass characterClass, float staminaPointsToSubstract)
        {
            return characterClass.GetCurrentStamina() - staminaPointsToSubstract;
        }

        public static IEnumerator StaminaRegeneration(this ICharacterClass characterClass)
        {
            AddStamina(characterClass, characterClass.GetStaminaRegeneration());
            yield return new WaitForSeconds(1f);
        }
    }
}

