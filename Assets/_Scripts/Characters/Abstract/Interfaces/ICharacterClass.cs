using Assets._Scripts.Abilities;
using System.Collections.Generic;

namespace Assets._Scripts.Characters.Abstract.Interfaces
{
    public interface ICharacterClass
    {
        int GetCurrentHealth();
        int GetCurrentMana();
        int GetCurrentStamina();

        float GetAttackRange();

        int GetMaximumHealth();
        int GetMaximumMana();
        int GetMaximumStamina();

        IAbility GetFirstDefaultAbility();
        IAbility GetSecondDefaultAbility();
        IAbility GetFirstSpecialAbility();
        IAbility GetSecondSpecialAbility();
        IAbility GetThirdSpecialAbility();
        List<IAbility> GetCharacterAbilitiesList();
    }
}
