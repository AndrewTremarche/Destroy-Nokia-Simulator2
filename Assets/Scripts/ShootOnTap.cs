using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootOnTap : MonoBehaviour
{
    public int gunDamage = 1;
    public float fireRate = 0.25f;
    public float range = 100f;

    public Camera playerCamera;

    // Start is called before the first frame update
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
                    //If I hit something with a collider
                    if (hit.collider != null)
                    {
                        Debug.Log("Hit the Nokia");
                    }
                }

            }
        }
    }
}
