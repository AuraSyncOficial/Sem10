using GameJolt.UI;
using GameJolt.API;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Torreta : MonoBehaviour
{
    public float rangoDeVision = 10f;
    public Transform cabezaTorreta;
    public Transform balaPrefab;
    public Transform puntoDisparo;
    public float velocidadDisparo = 2f;
    public float frecuenciaDisparo = 1f; // Número de disparos por segundo
    public bool logro;
    private Transform enemigoObjetivo;
    private float tiempoUltimoDisparo;

    void Update()
    {
        BuscarEnemigo();
        Apuntar();
        IntentarDisparar();
    }

    void BuscarEnemigo()
    {
        Collider[] enemigosEnRango = Physics.OverlapSphere(transform.position, rangoDeVision);

        enemigoObjetivo = null;
        float distanciaMasCercana = Mathf.Infinity;

        foreach (Collider enemigo in enemigosEnRango)
        {
            if (enemigo.tag == "enemy")
            {
                float distanciaAlEnemigo = Vector3.Distance(transform.position, enemigo.transform.position);

                if (distanciaAlEnemigo < distanciaMasCercana)
                {
                    distanciaMasCercana = distanciaAlEnemigo;
                    enemigoObjetivo = enemigo.transform;
                }
            }
        }
    }

    void Apuntar()
    {
        if (enemigoObjetivo != null)
        {
            Vector3 direccion = enemigoObjetivo.position - cabezaTorreta.position;
            Quaternion rotacion = Quaternion.LookRotation(direccion);
            cabezaTorreta.rotation = Quaternion.Lerp(cabezaTorreta.rotation, rotacion, Time.deltaTime * 5f);
        }
    }

    void IntentarDisparar()
    {
        if (enemigoObjetivo != null)
        {
            if (Time.time - tiempoUltimoDisparo > 1f / frecuenciaDisparo)
            {
                Disparar();
                tiempoUltimoDisparo = Time.time;
            }
        }
    }

    void Disparar()
    {

        Transform bala = Instantiate(balaPrefab, puntoDisparo.position, puntoDisparo.rotation);
        bala.GetComponent<Rigidbody>().velocity = (enemigoObjetivo.position - puntoDisparo.position).normalized * velocidadDisparo;

        if (!logro)
        {
            Trophies.TryUnlock(216231);
            logro = true;
        }
    }
}

