using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Endscript : MonoBehaviour
{
    public void restartgame()
    {
         SceneManager.LoadScene("SampleScene");
    
    }
    public void exitgame()
        {
            Debug.Log("Exit pressed");
             Application.Quit();
        }
    
}
