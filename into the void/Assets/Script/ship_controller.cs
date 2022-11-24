using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship_controller : MonoBehaviour
{

    public float fowardspeed = 25f, straspeed = 7.5f, hoverspeed = 5f;
    private float activefwordspeed, activestraspeed, activehoverspeed;
    private float fwordacc = 2f, strayacc= 2f, hoveracc= 2f;
    public float lookspeed = 90f;
    public Vector2 lookinput,screencenter,mousedistance;
    private float rollinput;
    public float rollspeeed=90f, rollacc = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        screencenter.x = Screen.width * 0.5f;
        screencenter.y = Screen.height * 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        rollinput = Mathf.Lerp(rollinput, Input.GetAxisRaw("roll"), rollacc * Time.deltaTime);


        lookinput.x = Input.mousePosition.x;
        lookinput.y = Input.mousePosition.y;
        mousedistance.x = (lookinput.x- screencenter.x )/screencenter.x;
        Debug.Log(mousedistance);
        mousedistance.y = (lookinput.y - screencenter.y) / screencenter.y;
        transform.Rotate(-mousedistance.y , mousedistance.x * lookspeed * Time.time, rollinput*rollspeeed, Space.Self);
        mousedistance = Vector2.ClampMagnitude(mousedistance, 0);*/

       

        activefwordspeed = Mathf.Lerp(activefwordspeed, Input.GetAxisRaw("Vertical") * fowardspeed,fwordacc*Time.deltaTime);
        activestraspeed = Mathf.Lerp(activestraspeed, Input.GetAxisRaw("Horizontal") * straspeed, strayacc* Time.deltaTime);
        activehoverspeed = Mathf.Lerp(activehoverspeed, Input.GetAxisRaw("Hover") * hoverspeed,hoveracc*Time.deltaTime);

        transform.position += transform.forward * activefwordspeed * Time.deltaTime;
        transform.position += transform.right * activestraspeed * Time.deltaTime;
        transform.position += transform.up * activehoverspeed * Time.deltaTime; 


    }
}
