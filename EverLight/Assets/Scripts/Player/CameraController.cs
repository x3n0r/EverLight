using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class CameraController : MonoBehaviour
{
    public float PlayerCameraDistance { get; set; }
    public Transform cameraTarget;

    Camera playerCamera;
    float zoomSpeed = 35f;

    void Start()
    {
        PlayerCameraDistance = 10f;
        playerCamera = GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.GetAxisRaw("Mouse ScrollWheel") != 0)
        {
            float scroll = Input.GetAxis("Mouse ScrollWheel");
            playerCamera.fieldOfView -= scroll * zoomSpeed;
            if (playerCamera.fieldOfView > 80f)
                playerCamera.fieldOfView = 80f;
            if (playerCamera.fieldOfView < 45f)
                playerCamera.fieldOfView = 45f;
            playerCamera.fieldOfView = Mathf.Clamp(playerCamera.fieldOfView, 0, 180);
        }
    }
}
