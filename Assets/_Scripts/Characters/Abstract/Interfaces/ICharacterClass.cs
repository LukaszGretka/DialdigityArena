using Assets._Scripts.Abilities;
using Assets._Scripts.Abilities.Abstract;
using System;
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

        float GetHealthRegeneration();
        float GetManaRegeneration();
        //float GetStaminaRegeneration();

        IAbility GetFirstDefaultAbility();
        IAbility GetSecondDefaultAbility();
        IAbility GetFirstSpecialAbility();
        IAbility GetSecondSpecialAbility();
        IAbility GetThirdSpecialAbility();
        List<IAbility> GetCharacterAbilitiesList();

        IAbilityImplementation GetAbilityImplementation();

        void GetFirstDefaultAbilityImplementation();
        Action GetSecondDefaultAbilityImplementation();
        Action GetFirstSpecialAbilityImplementation();
        Action GetSecondSpecialAbilityImplementation();
        Action GetThirdSpecialAbilityImplementation();
    }
}
