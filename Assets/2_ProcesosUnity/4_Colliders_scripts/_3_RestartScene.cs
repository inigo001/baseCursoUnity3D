using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _3_RestartScene : MonoBehaviour {

    /* - VARIABLES - */


    // VELOCIDADES
    public int verticalSpeed = 3;       // velocidad vertical (control del jugador)
    public int horizontalSpeed = 2;     // velocidad horizontal (automatica)
    public int extraSpeed = 1;          // aumento de velocidad al llegar al final

    // LIMITES
    public Transform limiteSuperior;
    public Transform limiteInferior;
    public Transform limiteFinal;

    // INICIALES
    private float xOffset;              // Distancia entre la camara y el Player al iniciar el juego
    private Vector3 initialPosition;    // Posicion del Player al iniciar el juego


    /* ------------- */


    void Start () 
    {
        // guardamos la distancia entre la camara y el player
        xOffset = Camera.main.transform.position.x - this.transform.position.x;

        // guardamos la posicion inicial del Player
        initialPosition = this.transform.position;
    }



    void Update () 
    {

        movePlayer();
        checkVerticalLimits();
        checkFinalLimit();
        moveCamera();

    }


    // FUNCION MOVEPLAYER
    // 1. Se encarga de controlar las pulsaciones de teclas y en base a ello mueve al personaje
    // 2. Se encarga de mover el Player horizontalmente respecto de la pantall
    private void movePlayer()
    { 
        // 1.
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector2.up * verticalSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(-Vector2.up * verticalSpeed * Time.deltaTime);
        }

        // 2.
        this.transform.Translate(Vector2.right * horizontalSpeed * Time.deltaTime);
    }

    // FUNCION CHECKVERTICALLIMITS
    // Se encarga de comprobar si el Player ha superado los límites superiores e inferiores
    // y, en caso de que ocurra, lo devuelve a la posición del límite  
    private void checkVerticalLimits()
    {
        if (this.transform.position.y >= limiteSuperior.position.y)
        {
            this.transform.position = new Vector2(this.transform.position.x, this.limiteSuperior.position.y);
        }

        if (this.transform.position.y <= limiteInferior.position.y)
        {
            this.transform.position = new Vector2(this.transform.position.x, this.limiteInferior.position.y);
        }
    }

    // FUNCION CHECKFINALLIMIT
    // Se encarga de comprobar si el Player ha llegado el final de la pantalla
    // En caso de hacerlo, lo devuelve al principio aumentando la velocidad.
    private void checkFinalLimit()
    {

        if ( this.transform.position.x >= limiteFinal.position.x)
        {
            this.transform.position = this.initialPosition;
            horizontalSpeed = horizontalSpeed + extraSpeed;
        }

    }

    // FUNCION MOVECAMERA
    // Se encarga de mover la camara horizontalmente
    private void moveCamera()
    {
        Transform cam = Camera.main.transform;

        cam.position = new Vector3(this.transform.position.x + xOffset, cam.position.y , cam.position.z);
    }


    // REINICIO DE ESCENA
    void OnCollisionEnter2D(Collision2D coll) 
    {

        // RECORDAR LA LIBRERÍA SCENE MANAGEMENT

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
