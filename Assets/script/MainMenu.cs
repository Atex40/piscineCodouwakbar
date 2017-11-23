using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button Playbtn;
    public Button Quitbtn;

    // Use this for initialization
    void Start()
    {
        Navigation navigation = Playbtn.navigation;

        navigation.mode = Navigation.Mode.Explicit;

        navigation.selectOnDown = Quitbtn;

        Playbtn.navigation = navigation;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayButton()
    {
        SceneManager.LoadScene("Scene Kevin");
    }

    public void QuitButton()
    {
        Application.Quit();
    }

}