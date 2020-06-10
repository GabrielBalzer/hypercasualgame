using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : Singleton<MenuController>
{
    public void startgame()
    {
        SceneManager.LoadScene("MainScene");
    }
  public void startsettings()
    {
        SceneManager.LoadScene("SettingsScene");
    }
  public void mainmenu()
    {
        SceneManager.LoadScene("StartScene");
    }
  public void aboutus()
    {
        Application.OpenURL("https://hypercasual.wordpress.com/");
    }
  public void storyscreen()
    {
        SceneManager.LoadScene("StorySettings");
    }

    public static void pausemenu()
    {
        SceneManager.LoadScene("PauseScene");
    }

    public void pauseaudio()
    {
        audioplayer.instance.PauseAudio();
    }

}
