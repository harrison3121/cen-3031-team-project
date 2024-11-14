using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // set this in the Inspector 
    private float screenLeft;
    private float screenRight;

    void Start()
    {
        Camera mainCamera = Camera.main;
        screenLeft = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        screenRight = mainCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 position = transform.position;
        position.x += horizontal * moveSpeed * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, screenLeft, screenRight);
        transform.position = position;
    }
}
