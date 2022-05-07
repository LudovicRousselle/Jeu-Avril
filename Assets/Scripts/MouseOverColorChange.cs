using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverColorChange : MonoBehaviour
{

    Color m_MouseOverColor = Color.red;
    Color m_OriginalColor;
    MeshRenderer m_Renderer;

    private bool audioTg;

    [SerializeField] AudioSource audioMouseOver;

    void Start()
    {
        audioTg = true;

        m_Renderer = GetComponent<MeshRenderer>();
        m_OriginalColor = m_Renderer.material.color;
    }

    void OnMouseOver()
    {
        if (audioTg)
        {
            audioMouseOver.Play();
            audioTg = false;
        }

        m_Renderer.material.color = m_MouseOverColor;
    }

    void OnMouseExit()
    {
        audioTg = true;
        m_Renderer.material.color = m_OriginalColor;
    }
}
