using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player; // refer�ncia para o jogador

    public float smoothSpeed = 0.125f; // velocidade de movimento da c�mera
    public Vector3 offset; // dist�ncia da c�mera em rela��o ao jogador
    public float minHeight = 1.0f; // altura m�nima da c�mera em rela��o ao jogador

    void FixedUpdate()
    {
        Vector3 desiredPosition = player.position + offset; // posi��o que a c�mera deve estar

        if (player.position.y > minHeight) // se o jogador estiver no ar
        {
            desiredPosition.y = player.position.y + minHeight; // mant�m a c�mera a uma altura m�nima em rela��o ao jogador
        }

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // suaviza o movimento da c�mera
        transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, transform.position.z); // move a c�mera
    }
}
