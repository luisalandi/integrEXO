using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ferma : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      Vector3 pos= new Vector3(0f,0.2f,-0.5f);
	transform.position=pos;
    }
}
