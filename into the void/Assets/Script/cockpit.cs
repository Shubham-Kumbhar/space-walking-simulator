using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cockpit : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject text1;
    public void OnTriggerEnter(Collider other)
    {
        text1.SetActive(false);
        Invoke("scene1", 4f);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void scene1()
    {
        SceneManager.LoadScene(2);
    }
}
