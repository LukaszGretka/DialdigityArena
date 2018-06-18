
using UnityEngine;

public class CharacterSelection : MonoBehaviour
{
    public static GameObject SelectedCharacter { get; private set; }

    public void CharacterSelectionButtonClick(GameObject character)
    {
        SelectedCharacter = character;
        Debug.Log("Selected: " + SelectedCharacter.name);
    }

}
