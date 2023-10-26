using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderSpawn : MonoBehaviour
{
    public GameObject gradingTimmy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        gradingTimmy.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        gradingTimmy.SetActive(false);
    }
}
