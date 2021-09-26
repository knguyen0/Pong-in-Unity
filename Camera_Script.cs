using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Script : MonoBehaviour
{
    Color bgcolor; Color current; public Camera camera1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Change_color", 0.0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Change_color()
    {
        current = new Color(Random.value, Random.value, Random.value);
        bgcolor = new Color(Random.value, Random.value, Random.value);
        camera1.backgroundColor = Color.Lerp(current, bgcolor, 5.0f);
    }
}
