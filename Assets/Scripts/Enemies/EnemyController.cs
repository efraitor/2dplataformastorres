using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //Velocidad del enemigo
    public float moveSpeed;

    //Posiciones m�s a la izquierda y m�s a la derecha que se va a poder mover el enemigo
    public Transform leftPoint, rightPoint;

    //Variable para conocer la direcci�n de movimiento del enemigo
    private bool movingRight;

    //Referencia al RigidBody del enemigo
    private Rigidbody2D theRB;

    // Start is called before the first frame update
    void Start()
    {
        //Inicializamos el Rigidbody del enemigo
        theRB = GetComponent<Rigidbody2D>();

        //Sacamos el Leftpoint y el Rightpoint del objeto padre, para que no se muevan junto con este
        leftPoint.parent = null;//null es vac�o o no tiene en este caso
        rightPoint.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
