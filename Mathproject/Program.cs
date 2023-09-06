// See https://aka.ms/new-console-template for more information


for(int a = 0; a < 10; a++)
{
    for(int b = 0; b < 10; b++)
    {
        for(int c = 0; c < 10; c++)
        {
            for(int d = 0; d < 10; d++)
            {
                for(int e = 0; e < 10; e++)
                {
                    if (GetAnswer(a, b, c, d, e))
                    {
                        Console.WriteLine($"{a}{b}{c}{d}{e}");
                    }
                }
            }
        }
    }
}

bool GetAnswer(int tenThousands, int thousands, int hundreds, int tens, int ones){

    // all digits are different
    if (tenThousands == thousands) return false;
    if(tenThousands == hundreds) return false;
    if (tenThousands == tens) return false;
    if (tenThousands == ones) return false;
    if (thousands == hundreds) return false;
    if (thousands == tens) return false;
    if (thousands == ones) return false;
    if (hundreds == tens) return false;
    if (tens == ones) return false;

    // thousands digit is 7 more than tens
    if(thousands - 7 != tens) return false;

    // all digits add up to 24
    if (tenThousands + thousands + hundreds + tens + ones != 24) return false;

    // hundreds is equal to sum of thouands plus ones
    if (hundreds != thousands + ones) return false;

    else return true;
}
