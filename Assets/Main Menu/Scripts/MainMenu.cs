using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator fade;
    public GameObject FadePanel;
void Start()
{
    FadePanel.SetActive(false);
    fade.StopPlayback();
}
public void Fade()
{
    SceneManager.LoadScene(1);
}

public void StartButton()
{
    FadePanel.SetActive(true);
    fade.Play("Fade");
}
public void Options()
{

}
public void Exit()
{
    Application.Quit();
}
}
