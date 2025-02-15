﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoNivel2 : MonoBehaviour
{

    public GameObject iconoActivar; // icono indicador de activar plataformas
    public GameObject coco; // Nuestro asistente de controles
    public GameObject mensajeCoco; // el mensaje que mostramos
    // Temporizadores para los Invoke
    public float temporizadorIcono = 1f;
    public float temporizadorCoco = 3f;
    public float temporizadorAdios = 6f;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Player")
        {
            Invoke("Icono", temporizadorIcono);
            Invoke("CocoDialogo",temporizadorIcono);
            //Invoke("CocoDialogoAdios", temporizadorAdios + temporizadorCoco + temporizadorIcono);
            //Invoke("Autodestruccion", temporizadorAdios + temporizadorCoco + temporizadorIcono + 4f);
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            Invoke("CocoDialogoAdios",0f);
            Invoke("Autodestruccion",0f);
        }
    }

    private void Icono()
    {
        iconoActivar.SetActive(true);
    }

    private void CocoDialogo()
    {
        coco.SetActive(true);
        mensajeCoco.SetActive(true);
    }

    private void CocoDialogoAdios()
    {
        coco.SetActive(false);
        mensajeCoco.SetActive(false);
    }

    private void Autodestruccion()
    {
        Destroy(gameObject);
    }
}
