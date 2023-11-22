using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gema : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision){

        if(collision.gameObject.tag == "John"){
            SceneManager.LoadScene(2);
        }
    }
}
