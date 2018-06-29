using Assets._Scripts.Abilities;
using Assets._Scripts.Abilities.Abstract;
using System;
using System.Collections.Generic;

namespace Assets._Scripts.Characters.Abstract.Interfaces
{
    public interface ICharacterClass
    {
        float GetCurrentHealth();
        float GetCurrentMana();
        float GetCurrentStamina();

        float GetAttackRange();
        float GetMovementSpeed();

        float GetMaximumHealth();
        float GetMaximumMana();
        float GetMaximumStamina();

        void SetCurrentHealth(float changedHealth);
        void SetMovementSpeed(float movementSpeed);

        float GetHealthRegeneration();
        float GetManaRegeneration();
        float GetStaminaRegeneration();

        IAbility GetFirstDefaultAbility();
        IAbility GetSecondDefaultAbility();
        IAbility GetFirstSpecialAbility();
        IAbility GetSecondSpecialAbility();
        IAbility GetThirdSpecialAbility();
        List<IAbility> GetCharacterAbilitiesList();

        IAbilityImplementation GetAbilityImplementation();
    }
}
