using Assets._Scripts.Characters.Abstract;
using Assets._Scripts.Characters.Abstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

namespace Assets._Scripts.Player
{
    [RequireComponent(typeof(PlayerClassManager))]
    [RequireComponent(typeof(ICharacterClass))]
    internal class PlayerAbilitiesController : NetworkBehaviour
    {
        public delegate void OnMouseButtonClick();
        public static event OnMouseButtonClick MouseButtonClickHandler; //TODO subscripe this event to get information about Mouse clicks

        private void Update()
        {
            GetMouseButtonClick();
        }

        private void GetMouseButtonClick()
        {
            if (Input.GetMouseButtonDown(0)) 
            {
                MouseButtonClickHandler.Invoke();
            }

            if (Input.GetMouseButtonDown(1)) 
            {
                MouseButtonClickHandler.Invoke();
            }
        }

        private void KeyboardInputHandler()
        {

        }

    }
}
