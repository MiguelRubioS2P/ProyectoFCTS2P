﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MenuOpciones : MonoBehaviour
{
    public AudioMixer mixer; // Contiene la pista de audio
    public Toggle pantallaCompleta, fps, wasd, arrows; // Checks de opciones

    public Dropdown resolucion;
    private OptionsManager optionsmanager;
    private TranscionMenus transcion;
    private void Awake()
    {
        transcion = FindObjectOfType<TranscionMenus>();
        UnityEngine.Cursor.visible = true;
        optionsmanager = FindObjectOfType<OptionsManager>();
    }
    public void ControlVoluemnGeneral(float sliderValue)
    {
        // Si modificamos el valor del slider, modificamos "Volume" del audio mixer
        mixer.SetFloat("Volumen", Mathf.Log10(sliderValue) * 20);
    }

    public void MenuPrincipal()
    {
        // Si volvemos atras 
        StartCoroutine(transcion.cambioEscena("Menu Principal"));
    }

    public void CambiarEstadoFPS()
    {
        // Condiciones para cambiar el estado de mostrar o no los fps
        if (fps.isOn)
        {
            //GameObject.FindObjectOfType<OptionsManager>().GetComponent<OptionsManager>().fpsText.gameObject.SetActive(true);
            optionsmanager.fpsText.gameObject.SetActive(true);
        }
        else
        {
            //GameObject.FindObjectOfType<OptionsManager>().GetComponent<OptionsManager>().fpsText.gameObject.SetActive(false);
            optionsmanager.fpsText.gameObject.SetActive(false);
        }

    }

    public void CambiarPantallaCompleata()
    {
        if (pantallaCompleta.isOn)
        {
            Screen.fullScreen = true;
        }
        else
        {
            Screen.fullScreen = false;
        }

    }

    public void CambiarResolucion(Dropdown medidas)
    {
        if (medidas.options[medidas.value].text == "1920 x 1080")
        {
            optionsmanager.cambiarResolucion(1920, 1080, pantallaCompleta.isOn);
        }
        else if (medidas.options[medidas.value].text == "1366 x 768")
        {
            optionsmanager.cambiarResolucion(1366, 768, pantallaCompleta.isOn);
        }else if (medidas.options[medidas.value].text == "1280 x 720")
        {
            optionsmanager.cambiarResolucion(1280, 720, pantallaCompleta.isOn);
        }else if (medidas.options[medidas.value].text == "1024 x 768")
        {
            optionsmanager.cambiarResolucion(1024, 768, pantallaCompleta.isOn);
        }else if (medidas.options[medidas.value].text == "800 x 600")
        {
            optionsmanager.cambiarResolucion(800, 600, pantallaCompleta.isOn);
        }
    }
}