// Task: Palindrom yoxlayan method, string daxil edirsiniz
Console.Write("Enter a text: ");
IsPalindrome(Console.ReadLine());
static void IsPalindrome(string text)
{
    string PalindromeText = "";
    for(int i=text.Length-1; i>=0; i--)
    {
        PalindromeText += text[i];
    };
    if(text == PalindromeText)
    {
        Console.WriteLine("Text is Palindrome");
    }
    else
    {
        Console.WriteLine("Text is not a Palindrome text");
    };
};
