
Console.WriteLine(Palindrome(1221));
Console.WriteLine(Palindrome(3443));
Console.WriteLine(Palindrome(7854)); 
static bool Palindrome(int number)
{
    string string_number = number.ToString();

    int left = 0;
    int right = string_number.Length - 1;

    while (left < right)
    {
        if (string_number[left] != string_number[right])
        {
            return false;
        }

        left++;
        right--;
    }
    return true;
}