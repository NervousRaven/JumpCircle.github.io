using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(RandomSpawner.shopPoint==true){
            if(transform.position.y <= -3f){
            transform.position = new Vector2(transform.position.x,transform.position.y+0.1f);
            }
        }
    }
}
