using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelAndSceneManager : MonoBehaviour
{
    public GameObject Panel;
    public string SceneName;
    [SerializeField]
    private GameObject behindPanel;
    // Start is called before the first frame update
    public void OpenPanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
            behindPanel.SetActive(true);
        }

    }
    public void ClosePanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(false);
            behindPanel.SetActive(false);
        }

    }
    public void ChangeScene()
    {
        if (SceneName != null)
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}
