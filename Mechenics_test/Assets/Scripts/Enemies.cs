using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    [SerializeField] EnemyWalking olivia;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.value < 0.001)
        {
            EnemyWalking newOlivia = Instantiate(olivia);
        }
    }
}
