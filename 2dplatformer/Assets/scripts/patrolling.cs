using UnityEngine;

public class patrolling : MonoBehaviour
{
   [SerialiseField]
   private float movespeed;

   [SerializeField]
   private vector3 startposition;

   [SerializeField]
   private vector3 endposition;

   private Vector3 nextposition;



    void Start()
    {
        transform.posuition = startposition;
        targetposition = endposition;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetposition, movespeed * Time.deltaTime);
    }
}

