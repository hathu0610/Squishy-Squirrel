using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public AudioClip clip1;
    public Animator transitionAnim;


    [SerializeField]
    private Slider healthBar;
    [SerializeField]
    private Text healthtext;
    [SerializeField]
    private float maxHealth = 100f;

    public float curHealth;

    [SerializeField]
    private Slider acornBar;
    [SerializeField]
    private Text acorntext;

    private float maxacorn = 100f;

    public float curAcorn;

    [SerializeField]
    private GameObject panelGameover, panelPaused, panelGamePlay, panelGamewin, panelFeedme, panelTutorial, panelTutorial1, panelTutorial2, panelBehind, imageHandTap1, imageHandTap2
    ;

    public int timeLeft = 80;
    public Text countdown;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("LoseTime");
        Time.timeScale = 0.000f;

        healthBar.value = maxHealth;
        curHealth = healthBar.value;

        acornBar.value = maxacorn;
        curAcorn = acornBar.value;
    }

    // Update is called once per frame
    void Update()
    {
        countdown.text = ("" + timeLeft);
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
            if (timeLeft < 0)
            {
                timeLeft = 0;
            }
        }
    }

    public void ShowTutorialPanel1()
    {
        //Time.timeScale = 0.0001f;
        panelTutorial1.SetActive(true);
        panelTutorial.SetActive(true);
    }
    public void CloseTutorialPanel1()
    {
        //Time.timeScale = 1f;
        panelTutorial1.SetActive(false);
        panelTutorial2.SetActive(true);
        imageHandTap1.SetActive(true);
        imageHandTap2.SetActive(true);
    }

    public void CloseTutorialPanel2()
    {
        Time.timeScale = 1f;
        panelTutorial2.SetActive(false);
        panelTutorial.SetActive(false);
        imageHandTap1.SetActive(false);
        imageHandTap2.SetActive(false);
    }

    public void DecreaseHealth()
    {
        healthBar.value -= 20f;
        curHealth = healthBar.value;
        healthtext.text = curHealth.ToString() + "%";
        transitionAnim.SetTrigger("end");
        AudioSource.PlayClipAtPoint(clip1, new Vector3(5, 1, 2));

    }
    public void HitRock()
    {
        healthBar.value -= 10f;
        curHealth = healthBar.value;
        healthtext.text = curHealth.ToString() + "%";
        transitionAnim.SetTrigger("end");
        AudioSource.PlayClipAtPoint(clip1, new Vector3(5, 1, 2));
    }

    public void IncreaseHealth()
    {
        transitionAnim.SetTrigger("loveicon");
        healthBar.value += 10f;
        curHealth = healthBar.value;
        healthtext.text = curHealth.ToString() + "%"; if (curHealth <= 50f)
        if (curHealth >50f)
        {
            healthtext.color = Color.white;
        }
    }


    public void UpdateAcorn()
    {
        acornBar.value -= 10f;
        curAcorn = acornBar.value;
        transitionAnim.SetTrigger("loveicon");
    }

    public void LoadMenuscene()
    {
        Debug.Log("scene to load" + "Menu");
        SceneManager.LoadScene("Menu");
        panelGameover.SetActive(false);
    }

    public void LoadFeedMePanel()
    {
        Time.timeScale = 0.0001f;
        panelFeedme.SetActive(true);
        panelBehind.SetActive(true);
        panelTutorial1.SetActive(false);
    }

    public void CloseFeedMePanel()
    {
        panelBehind.SetActive(false);
        panelFeedme.SetActive(false);
        Time.timeScale = 1f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ResumeGame()
    {
       /*if (panelTutorial1 == true && panelTutorial2 ==false)
        {
            panelPaused.SetActive(false);
            panelBehind.SetActive(false);
            Time.timeScale = 0.000f;
            panelTutorial1.SetActive(true);
        }
       if (panelTutorial2 == true && panelTutorial1 ==false)
        {
            panelPaused.SetActive(false);
            panelBehind.SetActive(false);
            Time.timeScale = 0.000f;
            panelTutorial2.SetActive(true);
        }
        else if (panelTutorial1 ==false && panelTutorial2 == false)
        { */
            panelPaused.SetActive(false);
            //panelGamePlay.SetActive(true);
            panelBehind.SetActive(false);
            Time.timeScale = 1f;
        //}
    }

    public void PausedGame(){
        Time.timeScale = 0.0001f;
        panelPaused.SetActive(true);
        panelBehind.SetActive(true);
        panelTutorial1.SetActive(false);
        panelTutorial2.SetActive(false);
    }

    public void GameWin()
    {
        Time.timeScale = 0.0001f;
        panelGamewin.SetActive(true);
        panelBehind.SetActive(true);
    }
    public void GameOver()
    {
        Time.timeScale = 0.0001f;
        panelGameover.SetActive(true);
        panelBehind.SetActive(true);
    }
}
