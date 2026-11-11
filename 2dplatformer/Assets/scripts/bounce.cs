using UnityEngine;

public class bounce : MonoBehaviour
{
    private float bouncespeed = 40f;

        private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bouncespeed, ForceMode2D.Impulse);
        }
    }



}
