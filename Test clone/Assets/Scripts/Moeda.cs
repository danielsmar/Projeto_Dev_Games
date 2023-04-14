using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moeda : MonoBehaviour
{
    public float amplitude = 0.5f; // amplitude da curva senoidal
    public float speed = 1f; // velocidade da flutuação

    private float startY; // posição inicial em y da moeda

    // Start is called before the first frame update
    void Start()
    {
        startY = transform.position.y; // obtem a posição inicial em y da moeda
    }

    // Update is called once per frame
    void Update()
    {
        // atualiza a posição y da moeda usando a curva senoidal
        transform.position = new Vector3(transform.position.x, startY + amplitude * Mathf.Sin(Time.time * speed), transform.position.z);

        // adiciona uma rotação lenta na moeda em seu próprio eixo
        transform.Rotate(Vector3.up, Time.deltaTime * 50f);
    }
}