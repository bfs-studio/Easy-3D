using System.Collections;
using UnityEngine;

public class Orb : MonoBehaviour
{
    public Player player;
    public AudioClip collectSound;
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
            player.orbs += 1;
            player.playerSounds.PlayOneShot(collectSound);
            Destroy(gameObject);
        }
    }
}
