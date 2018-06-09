using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    public static GameObject SelectedCharacter { get; private set; }

    public void CharacterSelectionButtonClick(GameObject character)
    {
        SelectedCharacter = character;
        Debug.Log("Selected: " + SelectedCharacter.name);
    }

}
