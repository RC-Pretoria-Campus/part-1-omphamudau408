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
        StartChat();



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
    static void StartChat()
    {
        while (true)
        {
            Console.Write("\nYou: ");
            string input = Console.ReadLine()?.Trim().ToLower();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("[Please enter a valid question.]");
                continue;
            }

            if (input == "exit" || input == "quit")
            {
                Console.WriteLine("Goodbye! Stay safe online.");
                break;
            }

            string response = GetResponse(input);
            foreach (char c in response)
            {
                Console.Write(c);
                Thread.Sleep(30); // Simulating the typing effect
            }
            Console.WriteLine();
        }
    }
}





    





