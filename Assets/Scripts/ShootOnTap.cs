using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootOnTap : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem nokiaEplosionEffect;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            
            //Has the first touch just started?
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit)) //out is a keyword that means after this runs there will be a value coming OUT of the hit
                {
                    Nokia nokia = hit.transform.GetComponent<Nokia>();
                    //If I hit something with a collider
                    if (nokia != null)
                    {
                        nokiaEplosionEffect.Play();
                        Debug.Log("Hit the Nokia");
                    }
                }

            }
        }
    }
}
