using UnityEngine;

public class DestroyAfterDistance : MonoBehaviour
{
    public GameObject movingObj;

    public void Update()
    {
        if(Vector3.Distance(transform.position, movingObj.transform.position) > 20)
            Destroy(movingObj);
    }
}
