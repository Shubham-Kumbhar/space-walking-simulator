using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deactivate : MonoBehaviour
{
    public GameObject text,text2;
    int flag=0;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("deactivate1", 5.5f);
    }
    private void Update()
    {
        if( flag==1)
        {
            text2.SetActive(true);
        }
    }
    void deactivate1()
    {
        flag = 1;
        text.SetActive(false);

    }

}
