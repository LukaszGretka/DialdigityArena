using Assets._Scripts.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[RequireComponent(typeof(PlayerAbilitiesController))]

internal class PlayerMovement : NetworkBehaviour
{
    protected float MovementSpeed = 5f;
    protected float RotationSpeed = 100f;

    private Rigidbody playerRigidbody;
    private Vector3 playerMovementVector;
    private LayerMask groundLayerMask;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        groundLayerMask = LayerMask.GetMask("Ground");
    }

    private void FixedUpdate ()
    {
        if (!isLocalPlayer)
        {
            return;
        }

        playerMovementVector = GetUserRawInputNormalized() * Time.deltaTime * MovementSpeed;
        playerRigidbody.MovePosition(this.transform.position + playerMovementVector);
        playerRigidbody.MoveRotation(GetPlayerRotationByMousePoint());
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
