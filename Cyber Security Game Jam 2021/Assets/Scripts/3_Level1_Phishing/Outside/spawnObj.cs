using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObj : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject asteroidPrefab;
    [SerializeField]
    private float respawnTime = 1.0f;
    private Vector2 screenBounds;

    private void Start() {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWave());
    }

    private void spawnEnemy()
    {
        GameObject a = Instantiate(asteroidPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-27.5f, 83.4f), screenBounds.y*2);

    }
    IEnumerator asteroidWave(){
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}
