using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDucks : MonoBehaviour
{
    // Start is called before the first frame update
    public Duck prefab;
    float time;
    public float interval;
    int count;

    private void Start()
    {
        // this starts the invocation after interval seconds 
        InvokeRepeating("SpawnDuck", interval, interval);
    }
    void SpawnDuck()
    {
        Duck duck = Instantiate(prefab, transform);
        duck.Quack();
        Debug.Log("created a duck!!!!");
    }

    // Update is called once per frame
    void Update()
    {
        //time += Time.deltaTime;
        //if (time > interval)
        //{
        //    SpawnDuck();
        //    time = 0;
        //}

        
    }


}
