using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NiquiManager : MonoBehaviour
{
    [SerializeField] GameObject[] niquiInteraction;
    [SerializeField] GameObject[] changeBGButtons;
    public static NiquiManager instance;

    [SerializeField] GameObject[] backgrounds;

    [SerializeField] Button[] allButtons;
    int currentBackground = 0;

    public bool isMenuScene = false;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        if(changeBGButtons[0] != null)
        {
            changeBGButtons[0].GetComponent<Button>().onClick.AddListener(ChangeBackgroundRight);
            changeBGButtons[1].GetComponent<Button>().onClick.AddListener(ChangeBackgroundLeft);
        }
        
        foreach(Button button in allButtons)
        {
            button.onClick.AddListener(AudioManager.instance.PlayButton);
        }
    }

    public void ChangeBackgroundRight()
    {
        if (currentBackground < 2)
        {
            currentBackground++;

        } else
        {
            currentBackground = 0;
        }

        foreach (var image in backgrounds)
        {
            image.SetActive(false);
        }

        backgrounds[currentBackground].SetActive(true);
    }

    public void ChangeBackgroundLeft()
    {
        if (currentBackground > 0)
        {
            currentBackground--;

        }
        else
        {
            currentBackground = 2;
        }

        foreach (var image in backgrounds)
        {
            image.SetActive(false);
        }

        backgrounds[currentBackground].SetActive(true);
    }

    public void DeactivateNiqui()
    {
        foreach(GameObject niquiObject in niquiInteraction)
        {
            niquiObject.SetActive(false);
        }

        if(changeBGButtons[0] != null)
        {
            foreach (GameObject button in changeBGButtons)
            {
                button.SetActive(true);
            }
        }
        
    }

    public void ActivateNiqui()
    {
        if(isMenuScene && ProgressionManager.instance.hasSeenMenuSceneBefore)
        {
            DeactivateNiqui();
        } else
        {
            foreach (GameObject niquiObject in niquiInteraction)
            {
                niquiObject.SetActive(true);
            }

            if (changeBGButtons[0] != null)
            {
                foreach (GameObject button in changeBGButtons)
                {
                    button.SetActive(false);
                }
            }
        }
        
    }

    public void ReturnToRoomSelector()
    {
        if (ProgressionManager.instance.canSeeEnding)
        {
            SceneManager.LoadScene("Ending");
        }
        else
        {
            SceneManager.LoadScene("Inicio");
        }
        
    }

    public void LoadMigracion()
    {
        SceneManager.LoadScene("Migracion");
        ProgressionManager.instance.hasSeenMenuSceneBefore = true;
        ProgressionManager.instance.hasSeenMigration = true;
    }

    public void LoadInclusion()
    {
        SceneManager.LoadScene("Inclusion");
        ProgressionManager.instance.hasSeenMenuSceneBefore = true;
        ProgressionManager.instance.hasSeenInclusion = true;
    }

    public void LoadDiversidad()
    {
        SceneManager.LoadScene("Diversidad");
        ProgressionManager.instance.hasSeenMenuSceneBefore = true;
        ProgressionManager.instance.hasSeenDiversity = true;
    }

    public void LoadMovilidad()
    {
        SceneManager.LoadScene("Movilidad");
        ProgressionManager.instance.hasSeenMenuSceneBefore = true;
        ProgressionManager.instance.hasSeenMovility = true;
    }
}
