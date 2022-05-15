using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextRotation : MonoBehaviour
{
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(player.transform.position);
        transform.LookAt(transform.position + player.transform.rotation * Vector3.forward,player.transform.rotation * Vector3.up);
    }
}
