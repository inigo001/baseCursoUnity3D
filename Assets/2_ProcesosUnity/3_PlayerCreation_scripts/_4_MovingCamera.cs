using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _4_MovingCamera : MonoBehaviour {

    // Recordar introducir el tag PLAYER

    public int verticalSpeed = 3;
    public int horizontalSpeed = 2;

    public Transform limiteSuperior;
    public Transform limiteInferior;

    private Vector3 cameraOffset;

    // Use this for initialization
    void Start () 
    {
        cameraOffset = Camera.main.transform.position - this.transform.position;
    }

    // Update is called once per frame
    void Update () 
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector2.up * verticalSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(-Vector2.up * verticalSpeed * Time.deltaTime);
        }

        this.transform.Translate(Vector2.right * horizontalSpeed * Time.deltaTime);

        if (this.transform.position.y >= limiteSuperior.position.y)
        {
            this.transform.position = new Vector2(this.transform.position.x, this.limiteSuperior.position.y);
        }

        if (this.transform.position.y <= limiteInferior.position.y)
        {
            this.transform.position = new Vector2(this.transform.position.x, this.limiteInferior.position.y);
        }


        Camera.main.transform.position = this.transform.position + cameraOffset;
    }

}
