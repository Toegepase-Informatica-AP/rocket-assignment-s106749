using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public Transform[] positions;
    public float objectSpeed;

    int nextPositionIndex;
    Transform nextPosition;

    private void Start()
    {
        nextPosition = positions[0];
    }

    private void Update()
    {
        MoveGameObject();
    }

    private void MoveGameObject()
    {
        if (transform.position == nextPosition.position)
        {
            nextPositionIndex++;
            if (nextPositionIndex >= positions.Length)
            {
                nextPositionIndex = 0;
            }
            nextPosition = positions[nextPositionIndex];
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, nextPosition.position, objectSpeed * Time.deltaTime);
        }
    }
}
