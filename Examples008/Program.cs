int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}


int a1 = 65;
int b1 = 66;
int c1 = 99;
int a2 = 2;
int b2 = 43;
int c2 = 21;
int a3 = 1;
int b3 = 3;
int c3 = 0;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int result = Max(max1, max2, max3);

System.Console.Write(result);
