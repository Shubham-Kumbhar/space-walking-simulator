using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class blackhole : MonoBehaviour
{
    public GameObject blackwhole,text;
    public Transform spawnpoint;
    private void OnTriggerEnter(Collider other)
    {
        Instantiate(blackwhole, spawnpoint.position, spawnpoint.rotation);
        Debug.Log("enter");
        Invoke("scenechanger", 5f);
        text.SetActive(false);
    }
    void scenechanger()
    {
        SceneManager.LoadScene(3);
    }
}
