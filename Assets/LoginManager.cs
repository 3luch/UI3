    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LoginManager : MonoBehaviour
{
    public InputField inputPassword;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void password()
        
    {
        if (inputPassword.text == "Hola")
        {
            Debug.Log("acces Graranted");
        }
        else
        {
            Debug.Log("Acces Denied");
        }
    }
}
