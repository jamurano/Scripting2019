using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float coolDown;
    private float cool;
    public GameObject projectile;

    void Start()
    {
        cool = coolDown;
    }

    // Update is called once per frame
    void Update()
    {
        if (coolDown > 0)
        {
            coolDown -= Time.deltaTime;
        }
        else
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, Vector3.right, out hit, 15)
            {
                if (hit.transform.tag == "enemy")
                {

                }
                cool = coolDown;
                Instantiate(projectile, transform.position, Quaternion.identity);
            }
        }
    }
}
