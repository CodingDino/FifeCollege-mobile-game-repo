// HelloWorld
// Author: Sarah Herzog
// Date: 10/03/2022
// Purpose: Learn the basics of a Unity script!


// ----------------------------------------------------------
// Libraries used
// ----------------------------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ----------------------------------------------------------



// ----------------------------------------------------------
// Class HelloWorld
// ----------------------------------------------------------
// Class contains everything in the script
public class HelloWorld : MonoBehaviour
{


    // ------------------------------------------------------
    // Start is called before the first frame update
    // Called automatically by Unity
    void Start()
    {
        Debug.LogWarning("Hello hello hello!");
    }
    // ------------------------------------------------------


    // ------------------------------------------------------
    // Update is called once per frame
    // Called automatically by Unity
    void Update()
    {
        Debug.LogError("Goodbye Goodbye Goodbye!");
    }
    // ------------------------------------------------------

}
// Closing curly bracket, ends the script
// ----------------------------------------------------------
