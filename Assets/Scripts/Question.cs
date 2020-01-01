using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour
{
    public Image[] img = new Image[3];
    int select = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        selection();
       if( Input.GetKeyDown(KeyCode.RightArrow) && select < 3)
        {
            select += 1;
        } if(Input.GetKeyDown(KeyCode.LeftArrow) && select > 1)
        {
            select -= 1;
        }
    }

    void selection(){

        switch (select)
        {
            case 1:
                img[0].gameObject.SetActive(true);
                img[1].gameObject.SetActive(false);
                img[2].gameObject.SetActive(false);
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Debug.Log("Errou");
                }
                break;
            case 2:
                img[0].gameObject.SetActive(false);
                img[1].gameObject.SetActive(true);
                img[2].gameObject.SetActive(false);
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Debug.Log("Acertou");
                }
                break;
            case 3:
                img[0].gameObject.SetActive(false);
                img[1].gameObject.SetActive(false);
                img[2].gameObject.SetActive(true);
                if (Input.GetKeyDown(KeyCode.Space)) {
                    Debug.Log("Errou");
                }
                break;

        }
    }
}
