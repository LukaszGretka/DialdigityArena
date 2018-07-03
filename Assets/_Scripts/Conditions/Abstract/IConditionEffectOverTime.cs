using Assets._Scripts.Characters.Abstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets._Scripts.Conditions.Abstract
{
    interface IConditionEffectOverTime : ICondition
    {
        int ConditionIterations { get; }          // How many effect will replay on target

        float ConditionIntervalTime { get; }      // Time between condition ticks

        float InitializationTime { get; }         // Delay before condition initialization (ex. bleeding after 1 second from attack)
    }
}
