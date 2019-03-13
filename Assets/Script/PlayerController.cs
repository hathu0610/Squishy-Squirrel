using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private Rigidbody2D rb;

    [SerializeField]
    private GameObject aCorn, banana, broccoli;
    [SerializeField]
    private GameObject cake, eggplant ; 
    [SerializeField]
    private Animator squirrelAnim;

    [SerializeField]
    private GameMaster gameMaster;
    [SerializeField]
    private UIController uiController; 

    // Start is called before the first frame update
    void Start()
    {
        uiController = GameObject.Find("Canvas").GetComponent<UIController>();

        gameMaster = GameObject.Find("GameMaster").GetComponent<GameMaster>();

        rb = GetComponent<Rigidbody2D>();
        squirrelAnim = GetComponent<Animator>();
        squirrelAnim.SetBool("Isdead", false);
    }

    // Update is called once per frame
    void Update()
    {


      /*  float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        float squirrelX = (this.transform.position).x;
        float squirrelY = (this.transform.position).y;
        Vector2 squirrelPosition = new Vector2(this.transform.position.x, 0);

        */
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                if (touch.position.x < Screen.width/2 && transform.position.x > -2f)
                    transform.position = new Vector2(transform.position.x - 0.5f, transform.position.y);

                else if (touch.position.x > Screen.width / 2 && transform.position.x < 2f)
                    transform.position = new Vector2(transform.position.x + 0.5f, transform.position.y);
            }
        } 

       /*  if ((this.transform.position).x >= 1.8f && (moveHorizontal > 0))
         {
             moveHorizontal = 0;
         }
         else if ((this.transform.position).x <= -1.8f && (moveHorizontal < 0))
         {
             moveHorizontal = 0;
         }


         Vector3 movement = new Vector3(moveHorizontal, 0, 0);

        rb.velocity = new Vector2(moveHorizontal, 0) * speed;*/
         

    }
}
