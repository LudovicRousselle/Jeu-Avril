using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

        if ((Input.GetMouseButton(1)) && uiCapitale.capitalChose == gameObject.name)
        {
                Debug.Log("truc");
            SceneManager.LoadScene(2);
        }

    }
}
