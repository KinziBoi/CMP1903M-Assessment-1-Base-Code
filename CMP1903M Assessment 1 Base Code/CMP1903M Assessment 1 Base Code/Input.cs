using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        public string text = "Nothing";


        public void userInput()
        {
            Console.WriteLine("Type '1' for manual entry or '2' for file import");
            String Mode = Console.ReadLine();
            if(Mode == "1")
            {
                manualTextInput();
            }

            else if (Mode == "2")
            {
                fileTextInput("");
            }
        }
        
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public void manualTextInput()
        {
            Console.WriteLine("Input data via the Keyboard for manual entry:");

            text = Console.ReadLine();

             if(text == null)
            {
                 text = "";
            }

            Console.Write(text);
            
            
        }
        

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public void fileTextInput(string fileName)
        {
            //specifying file location input 
            Console.WriteLine("Specify file location below: " + " e.g. " + @"D:\User\Modules\OOP\Assignment1\Examplefile.txt");
            fileName = Console.ReadLine();
            //input validation for file location
            Console.WriteLine($"You entered {fileName}, Is This Correct? (y/n)");
            String confirm = Console.ReadLine();
            if(confirm == "y")
            {
                    text = System.IO.File.ReadAllText(@fileName);
            }
            else if (confirm == "n")
            {
                fileTextInput("");
            }
            
            
        }

    }
}
