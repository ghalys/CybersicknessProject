using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_color : MonoBehaviour
{
    public Renderer r;
    public float timer = 0.0f;

    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if(timer >=1.0f){
            r.material.color = new Color(Random.value, Random.value,Random.value,1.0f);
            timer = 0;
        }
    }
    // Start is called before the first frame update
  
}
