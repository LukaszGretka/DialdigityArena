
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets._Scripts.GUI
{
    public class ErrorMessageWindow : MonoBehaviour
    {
        private static Text errorMessageText;

        private void Awake()
        {
            errorMessageText = GetComponentInChildren<Text>();
        }

        public void DisplayTextOnScreen(string textToDisplay)
        {
            errorMessageText.text = textToDisplay;
            StartCoroutine(ClearErrorWindow());
        }

        public IEnumerator ClearErrorWindow()
        {
            yield return new WaitForSecondsRealtime(3);
            errorMessageText.text = "";
        }
    }
}