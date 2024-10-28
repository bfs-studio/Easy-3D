using System;
using UnityEngine;

public class Rune : MonoBehaviour
{
    public Player player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("FirstPersonController").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "FirstPersonController")
        {
            if(player != null  && player.orbs >= 3) {

                Debug.Log("It works");
             
            }
        }
    }
}
