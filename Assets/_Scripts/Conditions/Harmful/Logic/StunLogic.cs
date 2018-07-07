using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Conditions.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets._Scripts.Conditions.Harmful.Logic
{
    internal class StunLogic : IConditionImplementation
    {
        public Action<ICharacterClass, ICondition> GetConditionImplementationApply()
        {
            return (characterClass, condition) =>
            {
                Stun stun = condition as Stun;
                throw new NotImplementedException();
                //TODO
                //1. Set movement speed and mouse rotation to 0 (player can't move)
                //2. Set cooldown of spells (duration of stun)
            };
        }
    }
}
