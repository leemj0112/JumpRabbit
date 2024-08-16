using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public void Active( Vector2 pos)
    {
        transform.position = pos;
        Debug.Log($"Name: {gameObject.name}, Active position : {transform.position}, pos: {pos}");
    }
}
