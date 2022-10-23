

void BinarySearch(int[] arr, int n, int x)
{
    int left = 0;
    int right = n;
    while (left <= right)
    {
        int q = (left + right) / 2;
        if (arr[q] == x)
        {
            Console.WriteLine(q);
            break;
        }
        else if (arr[q] != x && arr[q] > x)
        {
            right = q - 1;
        }
        else if (arr[q] != x && arr[q] < x)
        {
            left = q + 1;
        }

    }
}

int[] massiv = { 23, 34, 37, 41, 52, 65, 76, 79, 87, 90 };
int number = 87;
BinarySearch(massiv, massiv.Length, number);

// Только для упорядоченных массивов!
// Доработать ввод вывод, поменять void на int