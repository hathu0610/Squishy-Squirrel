using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
   // [SerializeField]
   // private GameObject playerSquirrel;
    [SerializeField]
    private GameObject[] foodPrefabs;
    [SerializeField]
    private GameMaster gameMaster;
    [SerializeField]
    private GameObject[] obstaclesPrefabs;

    // Start is called before the first frame update


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartSpawn()
    {
        gameMaster = GameObject.Find("GameMaster").GetComponent<GameMaster>();

        if (gameMaster != null)
        {
            StartCoroutine(FoodSpawnRoutine());
        }
    }
    private IEnumerator FoodSpawnRoutine()
    {
        yield return new WaitForSeconds(3f);
        GameObject obstacleInstance = null;
        GameObject foodInstance = null;
        while (gameMaster.IsGameOn())
        {
            float randomTimeObstacle = Random.Range(1.5f, 2.0f);
            float randomTimeFood= Random.Range(0.5f, 1.5f);
            float randomX2 = Random.Range(-1.8f, 1.8f);
            float randomX = Random.Range(-1.8f, 1.8f);
            int randomIndex = Random.Range(0, 7);
            int randomIndex2 = Random.Range(0, 2);
            foodInstance = Instantiate(foodPrefabs[randomIndex], new Vector3(randomX, 5f, 0), Quaternion.identity);
            yield return new WaitForSeconds(randomTimeFood);
            obstacleInstance = Instantiate(obstaclesPrefabs[randomIndex2], new Vector3(randomX2, 5f, 0), Quaternion.identity);
            yield return new WaitForSeconds(randomTimeObstacle);

        }
       
    }

    
}
