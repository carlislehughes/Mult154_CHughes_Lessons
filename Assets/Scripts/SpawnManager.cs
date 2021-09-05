using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] lilypadObjs = null;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnLilyPad", 2.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnLilyPad()
    {
        foreach(GameObject lilypad in lilypadObjs)
        {

            Instantiate(lilypad);
        }

        
    }
}
