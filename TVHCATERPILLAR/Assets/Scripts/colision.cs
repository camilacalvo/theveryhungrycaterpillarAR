
using UnityEngine;
using UnityEngine.UI;

public class colision : MonoBehaviour
{
    public AudioSource collisionSound;
    public AudioSource finalfelizaudio;
   

    void Start (){
        collisionSound = GetComponent<AudioSource> ();
        finalfelizaudio = GetComponent<AudioSource>();
    }
    
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        //other.renderer.enabled = false;

        if(other.gameObject.CompareTag("frutas"))
        {
           score.scoreNum++;
            collisionSound.Play ();
            Destroy(other.gameObject);


        }

        if(other.gameObject.CompareTag("fast"))
        {
            score.scoreNumFast++;
            collisionSound.Play ();
            Destroy(other.gameObject);
        }

        
        
    }
}
