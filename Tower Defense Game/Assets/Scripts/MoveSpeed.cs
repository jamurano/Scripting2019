using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpeed : MonoBehaviour
{
    public float moveSpeed;

    void Update()
    {
        var speedVector = new Vector3(moveSpeed, 0, 0) * Time.deltaTime;
        transform.Translate(speedVector);
    }
}
