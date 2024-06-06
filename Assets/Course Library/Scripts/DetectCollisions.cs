using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    // When Triggered, destroy the gameObject
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
