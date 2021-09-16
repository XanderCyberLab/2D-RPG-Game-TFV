using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEnter : MonoBehaviour
{
    [SerializeField] string transformAreaName;
    // Start is called before the first frame update
    void Start()
    {
        if (transformAreaName == Player.instance.transformPosition)
        {
            Player.instance.transform.position = transform.position;
        }

               
    }   

    // Update is called once per frame
    void Update()
    {
        
    }
}
