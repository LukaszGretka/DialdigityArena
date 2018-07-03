﻿using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Conditions.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets._Scripts.Conditions.Harmful.Logic
{
    internal class SlowLogic : IConditionImplementation
    {
        public Action<ICharacterClass, ICondition> GetConditionImplementation()
        {
            return (characterClass, condition) =>
            {
                Slow slow = condition as Slow;
                throw new NotImplementedException();
            };
        }
    }
}
