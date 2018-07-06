using Assets._Scripts.Characters.Abstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets._Scripts.Conditions.Abstract
{
    public interface IConditionImplementationConstant : IConditionImplementation
    {
        Action<ICharacterClass, ICondition> GetConditionImplementationRemove();
    }
}
