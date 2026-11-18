using UnityEngine;

public class checkpoint : MonoBehaviour
{
    public static Vector2 savedPosition = Vector2.zero;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            savedPosition = collision.transform.position;
        }
    }
}