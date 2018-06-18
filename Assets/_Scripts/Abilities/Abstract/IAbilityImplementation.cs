using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets._Scripts.Abilities.Abstract
{
    public interface IAbilityImplementation
    {
        Action FirstDefaultAbilityImplementation();
        Action SecondDefaultAbilityImplementation();

        Action FirstSpecialAbilityImplementation();
        Action SecondSpecialAbilityImplementation();
        Action ThirdSpecialAbilityImplementation();
    }
}
