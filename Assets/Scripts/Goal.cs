using UnityEngine;
using TMPro;

public class Goal : MonoBehaviour
{
    private GameObject frogPlayer;
    private Vector3 playerInitialPos;

    public TextMeshProUGUI scoreText; 
    private int score;

    void Awake()
    {
        frogPlayer = GameObject.FindWithTag("Player");
        playerInitialPos = frogPlayer.transform.position;
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.CompareTag("Player"))
        {
            target.transform.position = playerInitialPos;

            score += 100;
            scoreText.text = score.ToString();
        }
    }
}
