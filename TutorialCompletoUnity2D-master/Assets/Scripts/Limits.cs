using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limits : MonoBehaviour
{
    public GameObject John;
    public Transform respawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.CompareTag("John")){
            John.transform.position = respawnPoint.position;
            GameManager.Instance.PerderVida();
        }
    }
}
