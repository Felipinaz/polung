using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravidade : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 grv; 
    void Start()
    {
        grv = new Vector3 (0,0,0);
        Physics.gravity = grv;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
