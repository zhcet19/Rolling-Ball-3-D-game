
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Moveball : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public int ballspeed=0;
    public int jumpspeed=0;
    private bool istouching=true;
    private int counter;
    private int score;
    public AudioSource asource;
    public AudioClip aclip;
    public Text cointext;
    public Text scoretext;
    void Start()
    {
        rb=GetComponent<Rigidbody> ();
        counter=20;
        score=0;
        cointext.text="COINS LEFT : " + counter;
        scoretext.text="SCORE : "+ score;
        
    }

    // Update is called once per frame
    void Update()
    {
        float HMove=Input.GetAxis("Horizontal");

         float VMove=Input.GetAxis("Vertical");

         Vector3 ballmove = new Vector3 (HMove,0.0f,VMove);
         rb.AddForce (ballmove*ballspeed);
        if( (Input.GetKey(KeyCode.Space)) && istouching==true)
        {
            Vector3 balljump = new Vector3 (0.0f,6.0f,0.0f);
            rb.AddForce (balljump*jumpspeed);
        }
        istouching=false;

    }
        private void OnCollisionStay ()
        {
            istouching=true;
        }
     private void OnTriggerEnter(Collider other)
     {
         if(other.gameObject.CompareTag("Coinstag"))
         {
             other.gameObject.SetActive(false);
             counter = counter -1;
             score = score+10;
             cointext.text = "COINS LEFT : " + counter;
             scoretext.text="SCORE : " + score;
             asource.PlayOneShot(aclip);
             if(counter==0)
             {
                 SceneManager.LoadScene("EndScene");
                 
             }

         }
     }
}