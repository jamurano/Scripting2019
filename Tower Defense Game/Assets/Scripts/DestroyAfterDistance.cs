using UnityEngine;

public class DestroyAfterDistance : MonoBehaviour
{
    public GameObject projectile;

    public void Update()
    {
        if(Vector3.Distance(transform.position, projectile.transform.position) > 20)
            Destroy(projectile);
    }
}
