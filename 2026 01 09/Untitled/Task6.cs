// TASK: "VisionAcademy" sozunu hazir metod isletmeden tersine cevirib ekrana yazdirin
static void ReverseText(string text)
{
    string ReversedInput = "";
    for(int i=text.Length-1; i>=0; i--)
    {
        ReversedInput += text[i];
    };
    Console.WriteLine(ReversedInput);
}

Console.Write("Metni daxil edin: ");
string input = Console.ReadLine();
ReverseText(input);
