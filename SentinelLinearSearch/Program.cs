void SentinelSearch(int[] arr, int n, int key)
{
    int last = arr[n - 1];
    arr[n - 1] = key;
    int i = 0;
    while (arr[i] != key)
        i++;
    arr[n - 1] = last;
    if ((i < n - 1) || (arr[n - 1] == key))
    {
        Console.WriteLine(key + " присутствует в индексе " + i);
    }
    else
        Console.WriteLine("Элемент не найден");
}

int[] arr = {12,60,50,76,63,10,138,190,791};
int n = arr.Length;
int key = 60;

SentinelSearch(arr,n,key);