using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiCapitale : MonoBehaviour
{

    [SerializeField] Text txt;
    [SerializeField] List<string> capitalList = new List<string>();


    // Start is called before the first frame update
    void Start()
    {
        string capitalChose = capitalList[Random.Range(0, capitalList.Count - 1)];
        txt = gameObject.GetComponent<Text>();
        txt.text = capitalChose;
    }

}
