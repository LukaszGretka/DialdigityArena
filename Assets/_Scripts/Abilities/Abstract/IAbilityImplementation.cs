using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets._Scripts.Abilities.Abstract
{
    public interface IAbilityImplementation
    {
        void GetFirstDefaultAbilityImplementation();
        void GetSecondDefaultAbilityImplementation();

        void GetFirstSpecialAbilityImplementation();
        void GetSecondSpecialAbilityImplementation();
        void GetThirdSpecialAbilityImplementation();
    }
}
