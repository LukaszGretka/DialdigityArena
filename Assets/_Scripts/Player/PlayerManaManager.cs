using Assets._Scripts.Characters.Abstract.Interfaces;
using UnityEngine;
using System.Collections;

namespace Assets._Scripts.Player
{
    public static class PlayerManaManager
    {
        public static float AddMana(this ICharacterClass characterClass, float manaPointsToAdd)
        {
            if (characterClass.GetCurrentMana() + manaPointsToAdd > characterClass.GetMaximumMana())
            {
                return characterClass.GetMaximumMana();
            }
            else
            {
                return characterClass.GetCurrentMana() + manaPointsToAdd;
            }
        }

        public static bool CheckIfEnoughMana(this ICharacterClass characterClass)
        {
            return characterClass.GetCurrentMana() <= default(float) ? true : false;
        }

        public static float SubstractMana(this ICharacterClass characterClass, float manaPointsToSubstract)
        {
            return characterClass.GetCurrentMana() - manaPointsToSubstract;
        }

        public static IEnumerator ManaRegeneration(this ICharacterClass characterClass)
        {
            AddMana(characterClass, characterClass.GetManaRegeneration());
            yield return new WaitForSeconds(1f);
        }
    }
}
