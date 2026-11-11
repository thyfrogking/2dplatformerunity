using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class collectable : MonoBehaviour
{

    public int Score = 0;
    public int value = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Score = Score + value;
           
        }
    }
}
