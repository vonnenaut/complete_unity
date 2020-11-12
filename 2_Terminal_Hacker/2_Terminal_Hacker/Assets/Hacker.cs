using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string greeting = "Hello, Dan.";
        ShowMainMenu(greeting);
    }

    void ShowMainMenu(string greeting) {
        Terminal.ClearScreen();
        Terminal.WriteLine(greeting);
        Terminal.WriteLine(
            "What would you like to hack into?\n\n" +
            "Press 1 for the Park Service\n" +
            "Press 2 for the City Government\n" +
            "Press 3 for the University Computer Science Labs"
            );
    }

    void OnUserInput(string input) {
        if (input == "1")
        {
            print("1");
        } else if (input == "2")
        {
            print("2");
        } else if (input == "3")
        {
            print("3");
        } else if (input == "007") 
        {
            Terminal.WriteLine("Please select a level, Mr. Bond!");
        } else if (input == "menu") 
        {
            ShowMainMenu("");
        } else
        {
            Terminal.WriteLine("Please choose a valid level.");    
        }
    }
}
