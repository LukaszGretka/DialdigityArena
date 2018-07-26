using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets._Scripts.GUI
{
    public class SpellBar : MonoBehaviour
    {
        public Text firstAbilityCooldownTimer;
        public Text secondAbilityCooldownTimer;
        public Text firstSpecialAbilityCooldownTimer;
        public Text secondSpecialAbilityCooldownTimer;
        public Text thirdSpecialAbilityCooldownTimer;

        public IEnumerator SetCooldownTimer(float abilityCooldown, int orderInSpellbar)
        {
            for (float number = abilityCooldown; number > 0; number--)
            {
                if (orderInSpellbar == 1)
                {
                    firstAbilityCooldownTimer.text = number.ToString();
                    yield return new WaitForSecondsRealtime(1);
                    firstAbilityCooldownTimer.text = "";
                }
                if (orderInSpellbar == 2)
                {
                    secondAbilityCooldownTimer.text = number.ToString();
                    yield return new WaitForSecondsRealtime(1);
                    secondAbilityCooldownTimer.text = "";
                }

                if (orderInSpellbar == 3)
                {
                    firstSpecialAbilityCooldownTimer.text = number.ToString();
                    yield return new WaitForSecondsRealtime(1);
                    firstSpecialAbilityCooldownTimer.text = "";
                }

                if (orderInSpellbar == 4)
                {
                    secondSpecialAbilityCooldownTimer.text = number.ToString();
                    yield return new WaitForSecondsRealtime(1);
                    secondSpecialAbilityCooldownTimer.text = "";
                }

                if (orderInSpellbar == 5)
                {
                    thirdSpecialAbilityCooldownTimer.text = number.ToString();
                    yield return new WaitForSecondsRealtime(1);
                    thirdSpecialAbilityCooldownTimer.text = "";
                }
            }
        }
    }
}