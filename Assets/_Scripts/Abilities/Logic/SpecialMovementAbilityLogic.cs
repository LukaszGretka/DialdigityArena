using Assets._Scripts.Characters.Abstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


namespace Assets._Scripts.Abilities.Logic
{
    internal static class SpecialMovementAbilityLogic
    {
        private static LayerMask abilityMovementMask = LayerMask.GetMask("Ground");

        internal static void TranslatePossitionOnClick(this ICharacterClass characterClass, IAbility ability)
        {
            Ray rayFromCam = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit rayHit;

            if (Physics.Raycast(rayFromCam, out rayHit, Camera.main.farClipPlane, abilityMovementMask))
            {
                Vector3 translatePossition = rayHit.point;

                // TODO add translation prop to IAbility ability.TranslationTime
                // TODO add range to translation effect

                characterClass.SetCurrentPossition(Vector3.Slerp(characterClass.GetCurrentPossition(), translatePossition, 3f));
            }
        }

        internal static void TranslatePossitionWithEffect(ICharacterClass characterClass, IAbility ability)
        {
            throw new NotImplementedException();
        }
    }
}
