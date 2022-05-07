using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapitalChack : MonoBehaviour
{
    [SerializeField] GameObject text;
    [SerializeField] AudioSource audioWin;

    void Start()
    {

    }

    void Update()
    {
        UiCapitale uiCapitale = text.GetComponent<UiCapitale>();

        if (Input.GetMouseButton(0))
        {
            Debug.Log("click");


            if (uiCapitale.capitalChose == gameObject.name)
            {
                Debug.Log("truc");
            }
        }



    }
}
