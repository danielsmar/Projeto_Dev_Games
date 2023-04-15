using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float moveDistance = 10f;
    private Vector3 startPosition;
    private Vector3 endPosition;
    private bool movingToEnd = true;

    void Start()
    {
        // define a posi��o inicial e final da plataforma
        startPosition = transform.position;
        endPosition = transform.position + Vector3.right * moveDistance;
    }

    void Update()
    {
        // verifica se a plataforma chegou ao final do seu percurso e muda a dire��o
        if (movingToEnd && Vector3.Distance(transform.position, endPosition) < 0.1f)
        {
            movingToEnd = false;
        }
        else if (!movingToEnd && Vector3.Distance(transform.position, startPosition) < 0.1f)
        {
            movingToEnd = true;
        }

        // move a plataforma para a esquerda ou para a direita, dependendo da dire��o atual
        Vector3 targetPosition = movingToEnd ? endPosition : startPosition;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
    }
}
