using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Conditions.Abstract;
using System;
using Assets._Scripts.Player;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets._Scripts.Conditions.Harmful.Logic
{
    internal class PoisonLogic : IConditionImplementation
    {
        public Action<ICharacterClass, ICondition> GetConditionImplementation()
        {
            return (characterClass, condition) =>
            {
                Poison posion = condition as Poison;
                characterClass.TakeDamage(posion.DamagePerTick);
            };
        }
    }
}
