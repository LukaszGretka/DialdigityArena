using Assets._Scripts.Player;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.DebugTools
{
    class ToolPanelManager : MonoBehaviour
    {
        public Button DebugWindowButton;
        public GameObject DebugWindowGameObject;
        public GameObject ConditionPanelObject;

        private void Start()
        {
            DebugWindowGameObject.SetActive(false);
            ConditionPanelObject.SetActive(false);
        }

        public void DebugWindowButton_OnClick()
        {
            if (DebugWindowGameObject.activeInHierarchy)
            {
                DebugWindowGameObject.SetActive(false);
                ConditionPanelObject.SetActive(false);
                PlayerControl(true);
            }
            else
            {
                DebugWindowGameObject.SetActive(true);
                PlayerControl(false);
            }
        }

        private void PlayerControl(bool state)
        {
            GameObject playerGameObject = GameObject.FindGameObjectWithTag("Player");

            if (playerGameObject != null)
            {
                playerGameObject.GetComponent<PlayerMovement>().enabled = state;
                playerGameObject.GetComponent<PlayerAbilitiesController>().enabled = state;
            }
        }
    }
}
