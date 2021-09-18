using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEnter : MonoBehaviour
{
    public string transitionAreaName;
    // Start is called before the first frame update
    void Start()
    {
        if (transitionAreaName == Player.instance.transitionName) // Checks for player transition name to match the area.
        {
            Player.instance.transform.position = transform.position; // If match then player transform position is areaEnter position
        }               
    }   

    // Update is called once per frame
    void Update()
    {
        
    }
}
