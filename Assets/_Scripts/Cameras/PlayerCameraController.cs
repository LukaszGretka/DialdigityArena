using UnityEngine;
using UnityEngine.Networking;

public class PlayerCameraController : NetworkBehaviour
{
    public float CameraSmoothness = 2f;

    private Camera mainCamera;
    private Transform playerTransform;
    private Vector3 cameraOffset;

    private void Awake ()
    {
        playerTransform = GetComponent<Transform>();
        mainCamera = Camera.main;
    }

    private void Start()
    {
        cameraOffset = playerTransform.transform.position - mainCamera.transform.position;
    }

    private void Update ()
    {
        if (isLocalPlayer)
        {
            mainCamera.transform.position = CalculateCameraPossition();
        }
    }

    private Vector3 CalculateCameraPossition(bool lerping = true)
    {
        return lerping ? Vector3.Lerp(mainCamera.transform.position, transform.position - cameraOffset, CameraSmoothness * Time.deltaTime)
                       : transform.position - cameraOffset;
    }
}