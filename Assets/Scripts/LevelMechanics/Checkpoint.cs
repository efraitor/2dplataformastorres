using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    //Referencia al SpriteRenderer del checkpoint
    private SpriteRenderer theSR;

    //Los sprites que se ir�n alternando al activar o desactivar los checkpoints
    public Sprite cpOn, cpOff;

    // Start is called before the first frame update
    void Start()
    {
        //Inicializamos la referencia al SpriteRenderer
        theSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //M�todo para conocer cuando el jugador entra en la zona de checkpoint
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Si es el jugador el que ha entrado en la zona de Checkpoint y el Checkpoint estaba inactivo
        if (collision.CompareTag("Player"))
        {

        }
    }
}
