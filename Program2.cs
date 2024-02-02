
Square(7, '*');
static void Square(int length, char symbol)
{
    if(length <= 0) {
        return;
    }

    for(int i = 0; i < length; i++) {
        for (int j = 0; j < length; j++) {
            Console.Write(symbol + " ");
        }
        Console.WriteLine();
    }
}