using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{
    //Declaramos un array donde guardar los checkpoints de la escena
    private Checkpoint[] checkpoints;

    //Referencia a la posición del jugador
    public Vector3 spawnPoint;

    //Hacemos el Singleton de este script
    public static CheckpointController sharedInstance;

    private void Awake()
    {
        if (sharedInstance == null) sharedInstance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        //Buscamos todos los Game Objects que tengan el script asociado checkpoint y los guardamos en nuestro array
        checkpoints = GetComponentsInChildren<Checkpoint>();
        //Guardamos la posición inicial como punto de checkpoint si aún no hemos activado ninguno
        spawnPoint = PlayerController.sharedInstance.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
