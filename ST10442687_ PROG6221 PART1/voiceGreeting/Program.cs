using System;
using System.Speech.Synthesis;

class Program
{
    static void Main()
    {
        // initialising the SpeechSynthesizer
        SpeechSynthesizer synth = new SpeechSynthesizer();
        synth.Volume = 100;
        synth.Rate = 0;


        Console.WriteLine("Hello! Welcome to the Chatbot, How can I assist you today?");
        synth.Speak("Hello! Welcome to the Chatbot, How can I assist you today?");


        //User interaction
        Console.WriteLine("You can ask anything.");
        String userText = Console.ReadLine();
        synth.Speak(userText);

        Console.WriteLine("Goodbye");
        synth.Speak("Goodbye!");

    }
}







