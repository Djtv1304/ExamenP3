using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionesUI : MonoBehaviour
{

    [SerializeField] private GameObject buttonJugar;
    [SerializeField] private GameObject buttonOpciones;
    [SerializeField] private GameObject buttonSalir;
    [SerializeField] private GameObject fotoTitulo;

    public void MoverBotones()
    {

        float duracion = 2f;
        float inicioLento = duracion * 0.3f;

        
        LeanTween.moveY(buttonJugar.GetComponent<RectTransform>(), -700, duracion)
            .setEase(LeanTweenType.easeOutQuad) 
            .setEase(LeanTweenType.easeInQuad) 
            .setDelay(inicioLento);

        LeanTween.moveY(buttonOpciones.GetComponent<RectTransform>(), -700, duracion)
            .setEase(LeanTweenType.easeOutQuad)
            .setEase(LeanTweenType.easeInQuad)
            .setDelay(inicioLento);

        LeanTween.moveY(buttonSalir.GetComponent<RectTransform>(), -700, duracion)
            .setEase(LeanTweenType.easeOutQuad)
            .setEase(LeanTweenType.easeInQuad)
            .setDelay(inicioLento);

        LeanTween.moveY(fotoTitulo.GetComponent<RectTransform>(), 800, duracion)
            .setEase(LeanTweenType.easeOutQuad)
            .setEase(LeanTweenType.easeInQuad)
            .setDelay(inicioLento);

    }



}
