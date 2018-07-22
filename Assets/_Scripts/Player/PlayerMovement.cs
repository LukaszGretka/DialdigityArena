using Assets._Scripts.Characters.Abstract.Interfaces;
using Assets._Scripts.Player;
using UnityEngine;
using UnityEngine.Networking;

[RequireComponent(typeof(PlayerAbilitiesController))]
internal class PlayerMovement : NetworkBehaviour
{
    protected float RotationSpeed = 0.1f; // TODO add rotation speed

    private Rigidbody playerRigidbody;
    private Vector3 playerMovementVector;
    private LayerMask groundLayerMask;
    private ICharacterClass characterClass;

    private bool disablePlayerMovement = false;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        characterClass = GetComponent<ICharacterClass>();
        groundLayerMask = LayerMask.GetMask("Ground");
    }

    private void FixedUpdate ()
    {
        if (isLocalPlayer && disablePlayerMovement == false)
        {
            playerMovementVector = GetUserRawInputNormalized() * Time.deltaTime * characterClass.GetCurrentMovementSpeed();
            playerRigidbody.MovePosition(this.transform.position + playerMovementVector);
            playerRigidbody.MoveRotation(GetPlayerRotationByMousePoint());
        }
    }

    private Vector3 GetUserRawInputNormalized()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        playerMovementVector.Set(horizontalInput, 0f, verticalInput);
        return playerMovementVector.normalized;
    }

    private Quaternion GetPlayerRotationByMousePoint()
    {
        Ray rayFromCam = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit rayHit;

        if (Physics.Raycast(rayFromCam, out rayHit, Camera.main.farClipPlane, groundLayerMask))
        {
            Vector3 rotationVector = rayHit.point - transform.position;
            rotationVector.y = default(float);
            return Quaternion.LookRotation(rotationVector);
        }

        return this.transform.rotation;
    }
}
