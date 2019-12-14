using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2;
    public bool isAnExamlple = false;
    public Color someColor;
    public AnimationCurve interpolation;
    public float dir;

    MeshRenderer mesh;

    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Edit > Project Settings > Input for control types
        // GetAxisRaw bypasses gravity and give direct 1 or -1 types instead of gradual
        dir = Input.GetAxis("Horizontal");

        transform.position += new Vector3(dir, 0, 0) * Time.deltaTime * speed; // 1 meter per second instead of per tick

        ////if(mesh != null) //above will return null if object has no mesh renderer and cause error
        ////{
        ////    mesh.material.color = Random.ColorHSV();
        ////}
    }
}
