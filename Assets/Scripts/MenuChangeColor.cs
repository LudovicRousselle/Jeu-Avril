using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuChangeColor : MonoBehaviour
{
    Color m_MouseOverColor = Color.red;
    Color m_OriginalColor;
    Text m_Renderer;

    private bool audioTg;

    [SerializeField] AudioSource audioMouseOver;



    void Start()
    {
        audioTg = true;

        m_Renderer = GetComponent<Text>();
        m_OriginalColor = m_Renderer.material.color;
    }


    void OnMouseOver()
    {

        Debug.Log("yeah");

        if (audioTg)
        {
            audioMouseOver.Play();
            audioTg = false;
        }

        m_Renderer.color = m_MouseOverColor;

    }

    void OnMouseExit()
    {
        audioTg = true;
        m_Renderer.color = m_OriginalColor;
    }

}
