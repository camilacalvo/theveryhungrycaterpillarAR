using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int scoreNum;
    public Text scoreText;

    public static int scoreNumFast;
    public Text scoreTextFast;
    // Update is called once per frame
    void Update()
    {
        scoreText.text = scoreNum.ToString();
        scoreTextFast.text = scoreNumFast.ToString();
    }
}
