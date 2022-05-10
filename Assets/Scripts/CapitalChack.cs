using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CapitalChack : MonoBehaviour
{
    [SerializeField] GameObject text;
    [SerializeField] AudioSource audioWin;
    [SerializeField] GameObject compareTo;

    void Start()
    {
        UiCapitale uiCapitale = text.GetComponent<UiCapitale>();

        Debug.Log(uiCapitale.capitalChose);
    }

    void Update()
    {
        UiCapitale uiCapitale = text.GetComponent<UiCapitale>();


            if ((uiCapitale.capitalChose == compareTo.tag) && (Input.GetMouseButton(1)))
            {
                Debug.Log("truc");
                SceneManager.LoadScene(2);
            }


    }
}
