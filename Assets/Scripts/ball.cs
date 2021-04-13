using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    [SerializeField]
    float velocity = 5f;

    bool ballLaunched = false;

    [SerializeField]
    float waitingTime = 2f;

    float timePassed = 0f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(ballLaunched == false)
        {
            timePassed += Time.deltaTime;
            if(timePassed >= waitingTime)
            {
                GetComponent<Rigidbody2D>().velocity = velocity * Random.onUnitSphere;
                ballLaunched = true;
            }
           
        }
    }
}
