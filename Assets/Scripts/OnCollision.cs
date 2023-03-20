using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision: MonoBehaviour
{
    public ParticleSystem effect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        effect.Play();
        Destroy(gameObject);
        //destroy(gameObject);
        //print("Detected collision between " + gameObject.name + " and" + collision.collider.name);
        //print("There are " + collision.contacts.Length + "point(s) of contact");
        //print("Their relative velocity is " + collision.relativeVelocity);
    }
}
