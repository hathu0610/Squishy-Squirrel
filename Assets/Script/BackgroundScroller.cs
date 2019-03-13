using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    Material material;
    Vector2 offset;
    private void Awake()
    {
        material = GetComponent<Renderer>().material;
    }
    // Start is called before the first frame update
    private Vector3 startPosition;
   
    public float xVelocity, yVelocity;

    private UIController uiController;

    void Start()
    {
        offset = new Vector2(xVelocity, yVelocity);
        uiController = GameObject.Find("Canvas").GetComponent<UIController>();
    }

    void Update()
    {
        if (uiController.curAcorn >= 30 && uiController.curAcorn <= 50)
        {
            offset = new Vector2(xVelocity, 0.3f);
           // yVelocity = 2f;
        }
        else if(Mathf.RoundToInt(uiController.curAcorn) <= 30)
        {
            offset = new Vector2(xVelocity, 0.5f);
            //yVelocity = 0.7f;
        }

        material.mainTextureOffset += offset * Time.deltaTime;
    }
}
