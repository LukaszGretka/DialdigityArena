﻿using Assets._Scripts.Abilities;
using Assets._Scripts.Abilities.Abstract;
using Assets._Scripts.Player;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Scripts.Characters.Abstract.Interfaces
{
    public interface ICharacterClass
    {
        PlayerClassManager PlayerClassManager { get; }
        IAbilityImplementation PlayerClassAbilityImplementation { get; }

        float GetCurrentHealth();
        float GetCurrentMana();
        float GetCurrentStamina();

        float GetAttackRange();
        float GetCurrentMovementSpeed();
        float GetBaseMovementSpeed();

        float GetMaximumHealth();
        float GetMaximumMana();
        float GetMaximumStamina();

        void SetCurrentHealth(float health);
        void SetCurrentMana(float mana);
        void SetCurrentMovementSpeed(float movementSpeed);
        void SetCurrentStamina(float stamina);

        Vector3 GetCurrentPossition();
        void SetCurrentPossition(Vector3 possition);

        StatusBarManager GetStatusBarManager();

        void ApplyConditionEffect(ICondition condition);
        void RemoveConditionEffect(ICondition condition);
        void RemoveLastConditionEffect();
        bool CheckIfContainsCondition<T>() where T : ICondition;

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
