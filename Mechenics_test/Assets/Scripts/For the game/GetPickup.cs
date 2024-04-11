using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPickup : MonoBehaviour
{
    private Rigidbody r;
    private AudioSource source;
    private ParticleSystem ps;
    private KeepScore scoreScript;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();
        source = GetComponent<AudioSource>();
        ps = GetComponent<ParticleSystem>();
        scoreScript = FindObjectOfType<KeepScore>();
        ps.Stop();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            GameObject.Destroy(gameObject, 0.5f);
            source.Play();
            ps.Play();
            scoreScript.AddScore(5);
        }
    }
}
