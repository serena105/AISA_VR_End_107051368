using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text textScore;
    public int score;
    public int Scorein = 2;
    public AudioClip soundIn;

    private AudioSource aud;

    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "斧頭")
        {
            AddScore();
        }

        if (other.transform.root.name == "Player")
        {
            Scorein = 3;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.name == "Player")
        {
            Scorein = 2;
        }
    }

    private void AddScore()
    {
        score += Scorein;
        textScore.text = "Score" + score;
        aud.PlayOneShot(soundIn, Random.Range(1f, 2f));
    }

}
