using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class TextMovement : MonoBehaviour
{

    //Скрипт для движения правильно ответа по дуге к X
    public Transform p0, p1, p2, p3;
    [Range(0, 1)]
    public float t;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = bezier.GetPoint(p0.position, p1.position, p2.position, p3.position, t);
    }
}
