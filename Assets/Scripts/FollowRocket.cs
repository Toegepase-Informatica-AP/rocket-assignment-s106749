using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowRocket : MonoBehaviour
{
    public Transform target;

    private void Update()
    {
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(target.position.y, 0f, 300f), transform.position.z);
    }
}
