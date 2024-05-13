using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private GameManager gameManager;
    private Camera mainCamera;
    private Transform playerTrans;
    private float cameraDistance = 10f;

    private void Awake()
    {
        mainCamera = GetComponent<Camera>();
    }

    private void Start()
    {
        gameManager = GameManager.Instance;
        playerTrans = gameManager.Player;
    }


    private void LateUpdate()
    {
        CameraFollow();
    }

    private void CameraFollow()
    {
        Transform cameraTrans = mainCamera.transform;

        cameraTrans.position = playerTrans.position + Vector3.back * cameraDistance;
    }
}
