using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using DG.Tweening;

public class PlataformaVertical : MonoBehaviour
{
    private Vector3 posicionInicial;

    public Vector3 posicionFinal;

    public float tiempoAnimacion = 2.0f;

    public float velocidad = 5.0f;

    public int direccion = 1;

    void Start()
    {
        posicionInicial = transform.position;
    }

    void Update() {
        transform.DOMove(posicionFinal + Vector3.up * direccion * velocidad * Time.deltaTime, tiempoAnimacion).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}
