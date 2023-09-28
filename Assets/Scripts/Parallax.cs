using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    Transform cameratarnsform;
    Vector3 lastcameraposition;
    [SerializeField] private float parallaxmultiplier;
    private void Start()
    {
        cameratarnsform = Camera.main.transform;
        lastcameraposition = cameratarnsform.position;
    }
    private void LateUpdate()
    {
        Vector3 deltamovement = cameratarnsform.position - lastcameraposition;
        transform.position += deltamovement * parallaxmultiplier;
        lastcameraposition = cameratarnsform.position;
    }
}
