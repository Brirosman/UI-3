using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    public string Contraseña = "prit";
    public InputField IngresarContraseña;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Contra()
    {
        if (IngresarContraseña = Contraseña)
        {
            Debug.Log("Access garanted");
        }
        else
        {
            Debug.Log("Access denied");
        }
}
}
