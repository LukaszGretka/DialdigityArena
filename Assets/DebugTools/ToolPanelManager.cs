using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            }
            else DebugWindowGameObject.SetActive(true);
        }
    }
}
