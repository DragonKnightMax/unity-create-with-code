using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(20, 0, 10);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Calls after Update(), for moving camera or track objects that changes during Update
    void LateUpdate()
    {
        transform.position = plane.transform.position + offset;
    }
}
