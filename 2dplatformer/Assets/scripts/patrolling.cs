using UnityEngine;
using UnityEngine.SceneManagement;
public class patrolling : MonoBehaviour
{
   [SerializeField]
   private float moveSpeed;

   [SerializeField]
   private Vector3 startposition;

   [SerializeField]
   private Vector3 endposition;

   private Vector3 nextposition;



    void Start()
    {
        transform.position = startposition;
        nextposition = endposition;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, nextposition, moveSpeed * Time.deltaTime);

        if(transform.position == nextposition)
        {
            if (nextposition == startposition)
            { nextposition = endposition; }

            else
            {
                nextposition = startposition;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}

