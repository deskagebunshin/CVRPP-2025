using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public AudioClip clip;
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //move forward
        transform.position += Vector3.forward * speed * Time.deltaTime;
    }

    public void Quack()
    {
        AudioSource.PlayClipAtPoint(clip, transform.position);

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }
}
