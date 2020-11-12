using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu() {
        string greeting = "Hello, Dan.";

        Terminal.ClearScreen();
        Terminal.WriteLine(greeting);
        Terminal.WriteLine(
            "What would you like to hack into?\n\n" +
            "Press 1 for the Park Service\n" +
            "Press 2 for the City Government\n" +
            "Press 3 for the University Computer Science Labs"
            );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
