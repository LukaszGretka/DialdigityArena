using Assets._Scripts.Abilities;
using Assets._Scripts.Abilities.WarriorAbilities;
using Assets._Scripts.Abilities.WarriorAbilities.Special;
using Assets._Scripts.Characters.Abstract;
using Assets._Scripts.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets._Scripts.Characters
{
    [RequireComponent(typeof(PlayerAbilitiesController))]
    internal class Warrior : MeleeCharacterClass, ICharacterAbilities, ICharacterClass
    {
        //Those variable was made to allow user set stats from the unity inspector
        [SerializeField] private int Health;
        [SerializeField] private int Mana;
        [SerializeField] private int Stamina;
        [SerializeField] private int AttackRange;

        public IAbility FirstDefaultAbility
        {
            get { return FirstDefaultAbility; }
            private set { value = new Swipe(); }
        }

        public IAbility SecondDefaultAbility
        {
            get { return SecondDefaultAbility; }
            private set { value = new Block(); }
        }

        public IAbility FirstSpecialAbility
        {
            get { return FirstSpecialAbility; }
            private set { value = new BrutalStrike(); }
        }

        public IAbility SecondSpecialAbility
        {
            get { return SecondSpecialAbility; }
            private set { value = new Leap(); }
        }

        public IAbility ThirdSpecialAbility
        {
            get { return ThirdSpecialAbility; }
            private set { value = new Bash(); }
        }

        private void Start()
        {
            base.SetMaximumHealth(Health);
            base.SetMaximumMana(Mana);
            base.SetMaximumStamina(Stamina);
            base.SetAttackRange(AttackRange);

            base.SetBasicStatistics();
        }
    }
}
