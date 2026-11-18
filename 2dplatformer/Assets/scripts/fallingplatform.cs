using System.Collections;
using UnityEngine;

public class fallingplatform : MonoBehaviour
{
    public float fallWait = 0.5f;
    public float destroyWait = 1.0f;

    bool isFalling;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(!isFalling && collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Fall());
        }

       
    }


    private IEnumerator Fall()
    {
        isFalling = true;
        yield return new WaitForSeconds(fallWait);
        rb.bodyType = RigidbodyType2D.Dynamic;
        Destroy(gameObject, destroyWait);
    }


}
