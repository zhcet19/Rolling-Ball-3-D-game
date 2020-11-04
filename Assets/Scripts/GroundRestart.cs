
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GroundRestart : MonoBehaviour
{
    public AudioSource watersource;
    public AudioClip waterclip;
    void OnTriggerEnter()
    {
        watersource.PlayOneShot(waterclip);
        SceneManager.LoadScene("SampleScene");
    }
}
