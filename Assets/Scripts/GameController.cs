using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static int pontos = 0;
    public Text txt;
    public GameObject painel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = pontos.ToString();

        if (Player.qst)
        {
            painel.gameObject.SetActive(true);
        }
    }
}
