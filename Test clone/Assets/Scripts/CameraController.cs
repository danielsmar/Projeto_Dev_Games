using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player; // referência para o jogador

    public float smoothSpeed = 0.125f; // velocidade de movimento da câmera
    public Vector3 offset; // distância da câmera em relação ao jogador
    public float minHeight = 1.0f; // altura mínima da câmera em relação ao jogador

    void FixedUpdate()
    {
        Vector3 desiredPosition = player.position + offset; // posição que a câmera deve estar

        if (player.position.y > minHeight) // se o jogador estiver no ar
        {
            desiredPosition.y = player.position.y + minHeight; // mantém a câmera a uma altura mínima em relação ao jogador
        }

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // suaviza o movimento da câmera
        transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, transform.position.z); // move a câmera
    }
}
