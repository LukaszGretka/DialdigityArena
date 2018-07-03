using Assets._Scripts.Characters.Abstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets._Scripts.Conditions
{
    internal class PlayerConditionState
    {
        public ICondition ActiveCondition { get; set; }

        public float ConditionTimeLeft { get; set; }
    }
}
