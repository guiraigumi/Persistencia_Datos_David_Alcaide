using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
   
    private SaveManager saveManager;
    
    // Start is called before the first frame update
    void Start()
    {
        saveManager = GameObject.Find("Player").GetComponent<SaveManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Checkpoint"))
        {
            saveManager.CheckZone();
        }
    }
}
