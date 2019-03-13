using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    [SerializeField]
    private bool gameOn;

    [SerializeField]
    private SpawnManager spawnManager;
   //[SerializeField]
    private UIController uiController; 
    // Start is called before the first frame update
    void Start()
    {
        spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        uiController = GameObject.Find("Canvas").GetComponent<UIController>(); 
     
        if (spawnManager != null)
        {
            spawnManager.StartSpawn();
        }
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfGameWon();
    }

    public bool IsGameOn()
    {
        return gameOn;
    }

    public void CheckIfGameWon()
    {
        if (uiController.timeLeft == 0)
        {
            uiController.GameOver();
        }
        if (Mathf.RoundToInt(uiController.curHealth) == 0)
        {
            uiController.GameOver();
        }
        if (Mathf.RoundToInt(uiController.curAcorn) == 0)
        {
            Debug.Log("checkgamewin" + uiController.curAcorn);
            uiController.GameWin();
        }

    }

    public void EndsCurrentGame()
    {
        //if (uiController.timeLeft == 0)
        //{
            gameOn = false;
       // }
    }

}
