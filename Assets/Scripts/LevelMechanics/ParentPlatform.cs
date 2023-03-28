using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentPlatform : MonoBehaviour
{

    //Método para conocer cuando el jugador entra en una platforma
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Emparentamos al jugador con la plataforma
            PlayerController.sharedInstance.transform.parent = transform;
        }
    }

    //Método para conocer cuando el jugador sale de una platforma
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Desemparentamos al jugador de la platforma
            PlayerController.sharedInstance.transform.parent = null;
        }
    }
}
