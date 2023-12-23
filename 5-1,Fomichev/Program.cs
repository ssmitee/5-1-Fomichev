
char[] characters = { 'h', 'e', 'l', 'l', 'o', ' ', 'w', 'o', 'r', 'l', 'd', ' ', 't', 'e' };
string text = new string(characters);
string[] words = text.Split(' ');
string longestWord = "";
    foreach (string word in words)
    {
        if (word.Length > longestWord.Length)
        {
            longestWord = word;
        }
    } 
Console.WriteLine("Самое длинное слово: " + longestWord);
Console.WriteLine("Его длина: " + longestWord.Length);
