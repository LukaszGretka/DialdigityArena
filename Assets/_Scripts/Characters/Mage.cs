using Assets._Scripts.Abilities;
using Assets._Scripts.Abilities.Abstract;
using Assets._Scripts.Abilities.Characters.MageAbilities;
using Assets._Scripts.Abilities.Characters.MageAbilities.Logic;
using Assets._Scripts.Abilities.Characters.MageAbilities.Special;
using Assets._Scripts.Characters.Abstract;
using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Player;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Scripts.Characters
{
    [RequireComponent(typeof(PlayerAbilitiesController))]
    internal class Mage : RangedCharacterClass, ICharacterClass
    {
        private void Awake()
        {
            base.SetMaximumHealth(inspectorHealth);
            base.SetMaximumMana(inspectorMana);
            base.SetMaximumStamina(inspectorStamina);
            base.SetAttackRange(inspectorAttackRange);

            base.SetBasicStatistics();

            base.SetFirstDefaultAbility(new IceArmor());
            base.SetSecondDefaultAbility(new MagicMissile());
            base.SetFirstSpecialAbility(new LightingLeap());
            base.SetSecondSpecialAbility(new MagneticWave());
            base.SetThirdSpecialAbility(new Meteor());
        }

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

        int ICharacterClass.GetCurrentHealth()
        {
            return CurrentHealth;
        }

        int ICharacterClass.GetCurrentMana()
        {
            return CurrentMana;
        }

        int ICharacterClass.GetCurrentStamina()
        {
            return CurrentStamina;
        }

        float ICharacterClass.GetHealthRegeneration()
        {
            return HealthRegeneration;
        }

        float ICharacterClass.GetManaRegeneration()
        {
            return ManaRegeneration;
        }

        public float GetAttackRange()
        {
            return DefaultAttackRange;
        }

        public int GetMaximumHealth()
        {
            return MaximumHealth;
        }

        public int GetMaximumMana()
        {
            return MaximumMana;
        }

        public int GetMaximumStamina()
        {
            return MaximumStamina;
        }

        public void GetFirstDefaultAbilityImplementation()
        {
            throw new System.NotImplementedException();
        }

        public Action GetSecondDefaultAbilityImplementation()
        {
            throw new System.NotImplementedException();
        }

        public Action GetFirstSpecialAbilityImplementation()
        {
            throw new System.NotImplementedException();
        }

        public Action GetSecondSpecialAbilityImplementation()
        {
            throw new System.NotImplementedException();
        }

        public Action GetThirdSpecialAbilityImplementation()
        {
            throw new System.NotImplementedException();
        }

        public IAbilityImplementation GetAbilityImplementation()
        {
            return new MageAbilitiesLogic();
        }
    }
}
