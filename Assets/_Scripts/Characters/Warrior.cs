using Assets._Scripts.Abilities;
using Assets._Scripts.Abilities.Abstract;
using Assets._Scripts.Abilities.Characters.WarriorAbilities;
using Assets._Scripts.Abilities.Characters.WarriorAbilities.Special;
using Assets._Scripts.Abilities.WarriorAbilities.Logic;
using Assets._Scripts.Characters.Abstract;
using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Player;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Scripts.Characters
{
    [RequireComponent(typeof(PlayerAbilitiesController))]
    internal class Warrior : MeleeCharacterClass, ICharacterClass
    {
        private void Awake()
        {
            base.SetMaximumHealth(inspectorHealth);
            base.SetMaximumMana(inspectorMana);
            base.SetMaximumStamina(inspectorStamina);
            base.SetAttackRange(inspectorAttackRange);
            base.SetHealthRegeneration(inspectorHealthRegeneration);
            base.SetManaRegeneration(inspectorManaRegeneration);
            base.SetCurrentSpeed(inspectorMovementSpeed);
            base.SetBasicStatistics();

            base.SetFirstDefaultAbility(new Swipe());
            base.SetSecondDefaultAbility(new Block());
            base.SetFirstSpecialAbility(new BrutalStrike());
            base.SetSecondSpecialAbility(new Leap());
            base.SetThirdSpecialAbility(new Bash());
        }

        public new void SetCurrentHealth(float changedHealth)
        {
            base.SetCurrentHealth(changedHealth);
        }

        public new void SetMovementSpeed(float movementSpeed)
        {
            base.SetMovementSpeed(movementSpeed);
        }

        //TODO set current mana and stamina

        public new List<IAbility> GetCharacterAbilitiesList()
        {
            return base.GetCharacterAbilitiesList();
        }

        public new IAbility GetFirstDefaultAbility()
        {
            return base.GetFirstDefaultAbility();
        }

        public new IAbility GetSecondDefaultAbility()
        {
            return base.GetSecondDefaultAbility();
        }

        public new IAbility GetFirstSpecialAbility()
        {
            return base.GetFirstSpecialAbility();
        }

        public new IAbility GetSecondSpecialAbility()
        {
            return base.GetSecondSpecialAbility();
        }

        public new IAbility GetThirdSpecialAbility()
        {
            return base.GetThirdSpecialAbility();
        }

        public float GetCurrentHealth()
        {
            return CurrentHealth;
        }

        public float GetCurrentMana()
        {
            return CurrentMana;
        }

        public float GetCurrentStamina()
        {
            return CurrentStamina;
        }

        public float GetHealthRegeneration()
        {
            return HealthRegeneration;
        }

        public float GetManaRegeneration()
        {
            return ManaRegeneration;
        }

        public float GetStaminaRegeneration()
        {
            return StaminaRegeneration;
        }

        public float GetAttackRange()
        {
            return DefaultAttackRange;
        }

        public float GetMovementSpeed()
        {
            return DefaultMovementSpeed;
        }

        public float GetMaximumHealth()
        {
            return MaximumHealth;
        }

        public float GetMaximumMana()
        {
            return MaximumMana;
        }

        public float GetMaximumStamina()
        {
            return MaximumStamina;
        }

        public void GetFirstDefaultAbilityImplementation()
        {
            GetAbilityImplementation().FirstDefaultAbilityImplementation();
        }

        public Action GetSecondDefaultAbilityImplementation()
        {
            return GetAbilityImplementation().SecondDefaultAbilityImplementation();
        }

        public Action GetFirstSpecialAbilityImplementation()
        {
            return GetAbilityImplementation().FirstSpecialAbilityImplementation();
        }

        public Action GetSecondSpecialAbilityImplementation()
        {
            return GetAbilityImplementation().SecondSpecialAbilityImplementation();
        }

        public Action GetThirdSpecialAbilityImplementation()
        {
            return GetAbilityImplementation().ThirdSpecialAbilityImplementation();
        }

        public IAbilityImplementation GetAbilityImplementation()
        {
            return new WarriorAbilitiesLogic(this);
        }
    }
}