﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TranscionMenus : MonoBehaviour
{
    public Animator animator;
    public CargaNivel cargarNivel;


    public IEnumerator cambioEscena(string escena)
    {
        animator.SetTrigger("start");
        yield return new WaitForSeconds(0.15f);
        SceneManager.LoadScene(escena);
    }

    public void cargarNivelEscena(string escena)
    {
        cargarNivel.SetEscena(escena);
        SceneManager.LoadScene("CargarNivel");
    }
}
