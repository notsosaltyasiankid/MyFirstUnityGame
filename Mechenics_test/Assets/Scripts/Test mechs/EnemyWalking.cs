using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

using UnityEngine;

public class EnemyWalking : MonoBehaviour
{
    [SerializeField] Transform A;
    [SerializeField] Transform B;
    float speed = 1f;
    float distance;

    void Start()
    {
        transform.position = A.position;
        transform.LookAt(B.position);
        distance = Vector3.Distance(A.position, B.position); // Calculate the distance between A and B
    }

    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, B.position, step);

        // Calculate the remaining distance to B
        float remainingDistance = Vector3.Distance(transform.position, B.position);

        // If the remaining distance is very small (almost reached B), destroy the object
        if (remainingDistance < 0.01f)
        {
            Destroy(gameObject);
        }
    }
}