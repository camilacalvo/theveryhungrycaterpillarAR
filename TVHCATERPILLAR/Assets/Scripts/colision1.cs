
using UnityEngine;
using UnityEngine.UI;

public class colision1 : MonoBehaviour
{
    //public AudioSource collisionSound;
    public AudioSource finalfelizaudio;
    public AudioSource finaltristeaudio;

    [SerializeField] private Image finalFeliz;
    [SerializeField] private Image finalMedio;
    [SerializeField] private Image finalTriste;

    void Start (){
        //collisionSound = GetComponent<AudioSource> ();
        finalfelizaudio = GetComponent<AudioSource>();
        finaltristeaudio = GetComponent<AudioSource>();
    }
    
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        //other.renderer.enabled = false;

        if(other.gameObject.CompareTag("trigger")){
            if (score.scoreNum > score.scoreNumFast)
            {
                finalFeliz.enabled = true;
            finalfelizaudio.Play();
            }
            if (score.scoreNum < score.scoreNumFast)
            {
                finalTriste.enabled = true;
                finaltristeaudio.Play();
            }
            if (score.scoreNum == score.scoreNumFast)
            {
                finalMedio.enabled = true;
                finaltristeaudio.Play();
            }

        }
        
    }
}
