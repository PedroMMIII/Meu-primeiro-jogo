using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirJogador : MonoBehaviour
{
    public PlayerControll playerControll;
    public Vector3 distanciaProJogador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerControll == null) 
        {
            return;
        } 
        this.transform.position = playerControll.transform.position + distanciaProJogador;
    }
}
