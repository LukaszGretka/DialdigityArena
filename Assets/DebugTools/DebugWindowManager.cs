using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugWindowManager : MonoBehaviour
{
    private ICharacterClass selectedCharacterClass;

    [SerializeField] private Text selectedTargetText;
    [SerializeField] private GameObject ConditionPanelObject;


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
            if (rayHit.collider.tag == "Target" || rayHit.collider.tag == "Player")
            {
                selectedTargetText.text = rayHit.collider.name;
                selectedCharacterClass = rayHit.collider.GetComponent<ICharacterClass>();
            }
            else
            {

            }
        }
    }

    public void HealthButton_OnClick()
    {
        selectedCharacterClass.TakeHealing(selectedCharacterClass.GetMaximumHealth());
    }

    public void ManaButton_OnClick()
    {
        selectedCharacterClass.AddMana(selectedCharacterClass.GetMaximumMana());
    }

    public void StaminaButton_OnClick()
    {
        selectedCharacterClass.AddStamina(selectedCharacterClass.GetMaximumStamina());
    }

    public void KillButton_OnClick()
    {
        selectedCharacterClass.TakeDamage(selectedCharacterClass.GetMaximumHealth());
    }

    public void ConditionButton_OnClick()
    {
        if (ConditionPanelObject.activeInHierarchy)
        {

            ConditionPanelObject.SetActive(false);
        }
        else ConditionPanelObject.SetActive(true);
    }
    #region

    public void BleedingButton_OnClick()
    {
       

    }

    public void GetInputValue(string test)
    {

    }

    #endregion
}
