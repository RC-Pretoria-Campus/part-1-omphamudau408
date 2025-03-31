using System;
using System.Speech.Synthesis;
using System.Threading;


class Program
{
    static void Main()
    {
        PlayVoiceGreeting();
        DisplayAsciiArt();
        GreetUser();
        


    }
    static void PlayVoiceGreeting()
    {

        // initialising the SpeechSynthesizer
        SpeechSynthesizer synth = new SpeechSynthesizer();
        synth.Volume = 100;
        synth.Rate = 0;


        Console.WriteLine("Hello! Welcome to the CyberGuardBot, How can I assist you today?");
        synth.Speak("Hello! Welcome to the CyberGuardBot, How can I assist you today?");


        //User interaction
        Console.WriteLine("You can ask anything.");
        String userText = Console.ReadLine();
        synth.Speak(userText);

        Console.WriteLine("Goodbye");
        synth.Speak("Goodbye!");



    }

    static void DisplayAsciiArt()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(@"
         ██████╗ ██╗   ██╗███████╗██████╗  ██████╗  █████╗ ██████╗ 
        ██╔═══██╗██║   ██║██╔════╝██╔══██╗██╔═══██╗██╔══██╗██╔══██╗
        ██║   ██║██║   ██║█████╗  ██████╔╝██║   ██║███████║██████╔╝
        ██║▄▄ ██║██║   ██║██╔══╝  ██╔══██╗██║   ██║██╔══██║██╔══██╗
        ╚██████╔╝╚██████╔╝███████╗██║  ██║╚██████╔╝██║  ██║██║  ██║
         ╚══▀▀═╝  ╚═════╝ ╚══════╝╚═╝  ╚═╝ ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝
        ===========================================================
                        CYBERSECURITY AWARENESS BOT
        ===========================================================
        
    ");
        Console.ResetColor();
    }

    static void GreetUser()
    {
        Console.Write("Hello! What is your name? ");
        string name = Console.ReadLine()?.Trim();

        if (string.IsNullOrEmpty(name))
        {
            name = "User";
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Welcome, {name}! How can I assist you today?");
        Console.ResetColor();
    }

    

            
        }
 



