using UnityEngine;

public class DestroyOutOfView : MonoBehaviour
{
    private Camera mainCamera;
    private float screenBottom;

    void Start()
    {

        mainCamera = Camera.main;
        screenBottom = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;
    }

    void Update()
    {
        
        if (transform.position.y < screenBottom)
        {
            Destroy(gameObject); 
        }
    }
}
