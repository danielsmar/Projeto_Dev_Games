using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public float maxHeight = 5f; // altura máxima da plataforma
    public float minHeight = 0f; // altura mínima da plataforma
    public float speed = 1f; // velocidade de movimento da plataforma
    private float currentHeight = 0f; // altura atual da plataforma

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // calcula o deslocamento da plataforma
        float offset = Mathf.Sin(Time.time * speed) * 0.5f + 0.5f;
        currentHeight = Mathf.Lerp(minHeight, maxHeight, offset);

        // atualiza a posição da plataforma
        Vector3 position = transform.position;
        position.y = currentHeight;
        transform.position = position;

    }
}
