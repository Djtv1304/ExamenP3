using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{

    public void EmpezarJuego()
    {

        Debug.Log("Empezando el juego");

    }

    public void Salir() {

        Debug.Log("Saliendo del juego");

        Application.Quit();

    }

}
