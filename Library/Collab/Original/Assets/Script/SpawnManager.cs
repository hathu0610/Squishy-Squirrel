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
            StartCoroutine(ObstacleSpawnRoutine());
        }
    }
    private IEnumerator FoodSpawnRoutine()
    {
        while (gameMaster.IsGameOn())
        {
            int randomIndex =Random.Range(0,7);
            float randomX = Random.Range(-2.0f, 2.0f);
            Instantiate(foodPrefabs[randomIndex], new Vector3(randomX, 5f, 0), Quaternion.identity);
            yield return new WaitForSeconds(2.0f);
        }
    }

    private IEnumerator ObstacleSpawnRoutine()
    {
        while (gameMaster.IsGameOn())
        {
            int randomIndex = Random.Range(0, 0);
            float randomX = Random.Range(-1.0f, 1.0f);
           // Instantiate(obstaclesPrefabs[randomIndex], new Vector3(randomX, 5f, 0), Quaternion.identity);
            yield return new WaitForSeconds(7.0f);
        }
    }
}
