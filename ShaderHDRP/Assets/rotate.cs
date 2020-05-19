using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    void Update()
    {
        this.transform.Rotate(0, 0.5f, 0, Space.Self);
    }
}
