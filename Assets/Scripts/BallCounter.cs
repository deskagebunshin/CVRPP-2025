using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BallCounter : MonoBehaviour
{
    // Start is called before the first frame update
    public int count;
    public UnityEvent OnAllBallsEntered;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Balls")
        {
            count = count + 1;
        }

        if(count >= 5)
        {
            if(OnAllBallsEntered != null)
            {
                OnAllBallsEntered.Invoke();
            }
        }
    }

}
