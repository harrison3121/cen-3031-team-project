using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public GameObject trashPrefab;
    public GameObject rockPrefab;
    public float spawnRate = 2f;

    private Camera mainCamera;
    private float screenBottom;

    void Start()
    {
        mainCamera = Camera.main;
        screenBottom = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;

        InvokeRepeating("SpawnObjects", .1f, spawnRate);
    }

    void SpawnObjects()
    {
        
        float screenLeft = mainCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).x;
        float screenRight = mainCamera.ViewportToWorldPoint(new Vector3(1, 1, 0)).x;
        Vector2 spawnPosition = new Vector2(Random.Range(screenLeft, screenRight), mainCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y);

        GameObject spawnedObject = Instantiate(Random.value > 0.5f ? trashPrefab : rockPrefab, spawnPosition, Quaternion.identity);

        StartCoroutine(CheckAndDestroyWhenOffScreen(spawnedObject));
    }

    System.Collections.IEnumerator CheckAndDestroyWhenOffScreen(GameObject obj)
    {
        while (obj != null && obj.transform.position.y > screenBottom){
            yield return null;
        }
        if (obj != null){
            Destroy(obj);
        }
    }
}
