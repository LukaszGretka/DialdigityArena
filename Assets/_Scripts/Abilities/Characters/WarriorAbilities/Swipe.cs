﻿using System.Collections.Generic;
using Assets._Scripts.Characters.Abstract.Interfaces;
using UnityEngine;

namespace Assets._Scripts.Abilities.Characters.WarriorAbilities
{
    internal class Swipe : IAbility
    {
        public string Name { get; private set; } = "Swipe";

        public float BaseDamage { get; private set; } = 10f;

        public int ManaCost { get; private set; } = 0;

        public int StaminaCost { get; private set; } = 0;

        public int OrderInSpellbar { get; private set; } = 1;

        public float CooldownTime { get; private set; } = 1f;

        public float Range { get; private set; } = 2f;

        public bool IsRanged { get; private set; } = false;

        public float CastingTime { get; private set; } = 0f;

        public float HitAngle { get; private set; } = 120f;

        public bool OnCooldown { get; set; } = default(bool);

        public List<ICondition> Conditions { get; } = new List<ICondition>();
    }
}
