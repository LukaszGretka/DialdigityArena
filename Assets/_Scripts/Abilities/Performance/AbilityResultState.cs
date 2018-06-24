using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets._Scripts.Abilities.Performance
{
    public enum AbilityResultState
    {
        Successful,
        Interupted,
        Canceled,
        ReadyToCast,
        OnCooldown,
        NotEnoughMana,
        NotEnoughStamina,
    }
}
