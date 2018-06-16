using Assets._Scripts.Characters.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

namespace Assets._Scripts.Player
{
    internal class PlayerAbilitiesController : NetworkBehaviour
    {
        private void Update()
        {
            GetMouseButtonClick();
        }

        private void GetMouseButtonClick()
        {
            if (Input.GetMouseButtonDown(0)) 
            {

            }

            if (Input.GetMouseButtonDown(1)) 
            {

            }
        }

        private void KeyboardInputHandler()
        {

        }

    }
}
