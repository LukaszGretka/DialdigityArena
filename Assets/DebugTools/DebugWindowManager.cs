using Assets._Scripts.Characters.Abstract.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugWindowManager : MonoBehaviour
{
    private ICharacterClass selectedCharacterClass;

    [SerializeField] private Text selectedTargetText;
    [SerializeField] private Button addHealthButton;


    void Start ()
    {

	}
	
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SelectTargetFromScreen();
        }
    }

    private void SelectTargetFromScreen()
    {
        Ray rayFromCam = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit rayHit;

        if (Physics.Raycast(rayFromCam, out rayHit, Camera.main.farClipPlane))
        {
            selectedTargetText.text = rayHit.collider.name;
            selectedCharacterClass = rayHit.collider.GetComponent<ICharacterClass>();
        }
    }
}
