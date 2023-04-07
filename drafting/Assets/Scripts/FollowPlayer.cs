using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new(0.0f, 1.0f, -5.0f);

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
