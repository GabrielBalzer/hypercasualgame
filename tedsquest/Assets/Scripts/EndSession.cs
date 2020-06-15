using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSession : MonoBehaviour
{
    public float delay;
    bool loadingStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadLevelAfterDelay(delay));
    }



    IEnumerator LoadLevelAfterDelay(float delayed)
    {
        delay = delayed;
        loadingStarted = true;
        do
        {
            yield return new WaitForSeconds(1);
            
        }
        while (--delay > 0);

        SceneManager.LoadScene("StartScene");
    }

    private void OnGUI()
    {
        if (loadingStarted)
        {
            GUIStyle style = new GUIStyle(); 
            style.fontSize = 30;
            style.alignment = TextAnchor.MiddleCenter; 
            GUI.Label(new Rect(Screen.width/2, 0, 100, 100), "Remaining Time: "+delay.ToString(), style);
        }
    }
}
