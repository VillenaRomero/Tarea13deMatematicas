using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemigoSeguidor : MonoBehaviour
{
    public Transform jugador;

    public float velocidad = 5.0f;

    public float distanciaMinima = 1.0f;

    private Transform enemigo;

    private Vector3[] camino;

    void Start()
    {
        enemigo = transform;
        camino = new Vector3[] { enemigo.position, jugador.position };
    }

    void Update()
    {
        if (Vector3.Distance(enemigo.position, jugador.position) > distanciaMinima)
        {
            camino[1] = jugador.position;

            enemigo.DOMove(camino[1], velocidad).SetEase(Ease.Linear);

            enemigo.DOLookAt(jugador.position, 0.5f).SetEase(Ease.InOutSine);
        }
    }
}