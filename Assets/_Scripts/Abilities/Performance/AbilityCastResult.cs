using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets._Scripts.Abilities.Performance
{
    internal class AbilityCastResult
    {
        public string Message { get; set; }
        public AbilityResultState State { get; set; }
        public IAbility Ability { get; set; }
    }
}
