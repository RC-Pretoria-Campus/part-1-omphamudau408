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

        Console.WriteLine("Let me assist you ");
        synth.Speak("let me assist you");



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
        static string GetResponse(string input)
        {
            switch (input)
            {
                case "how are you?":
                    return "I'm just a bot, but I'm here to help you with cybersecurity!";
                case "what is a CyberSecurity":
                    return "Cybersecurity is the practice of protecting systems, networks, and data from digital threats and unauthorized access.";
                case "what's your purpose?":
                    return "providing you with cybersecurity tips and awareness to keep you safe online.";
                case "what can i ask you about?":
                    return "You can ask me about password safety, phishing, and safe browsing.";
                case "tell me about password safety":
                    return "Use long, unique passwords and enable multi-factor authentication (MFA) when possible.";
                case "what is phishing?":
                    return "Phishing is a cyber attack where scammers trick you into revealing sensitive information via fake emails or websites.";
                case "how do i browse safely?":
                    return "Avoid suspicious links, keep your browser updated, and use a reliable security extension.";
                default:
                    return "I didn't quite understand that. Could you rephrase?";
            }
        }
    }
}




    





