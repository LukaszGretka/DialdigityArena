using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets._Scripts.OutputMessages
{
    internal static class PlayerOutputMessages
    {
        //Abilities cast messages:
        public const string AbilityCastSuccessful = "Ability Cast Successful";
        public const string NotEnoughMana = "Not enough mana to cast that ability";
        public const string NotEnoughStamina = "Not enough stamina to cast that ability";
        public const string AbilityOnCooldown = "This ability is still on cooldown";
    }
}