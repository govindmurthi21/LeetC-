namespace LeetsMaybe;

public struct MaxOddDecomp
{
    public int[] Decompose(int N)
    {
        if (N is <= 0 or 2)
        {
            return Array.Empty<int>();
        }

        int oddNumb = 1;
        var decompDict = new Dictionary<int, int>();
        int remainder = N;
        
        while (true)
        {
            remainder -= oddNumb;
            if (remainder <= 0) break;
            decompDict.Add(oddNumb, remainder);
            oddNumb += 2;
        }

        if (decompDict.Count == 0)
        {
            return N % 2 == 0 ? Array.Empty<int>() : new int[1] { N };
        }

        int runningSum = 0;
        var result = new List<int>();

        foreach (var item in decompDict)
        {
            (int key, int val) = item;
            runningSum += key;
            result.Add(key);
            
            if (val % 2 == 0) continue;

            if (key + val == N)
            {
                result.Add(val);
                break;
            }
            
            if (val <= key || runningSum + val != N) continue;
            result.Add(val);
            break;
        }

        return result.Sum() == N ? result.ToArray() : new int[1] {N};
    }
    
    /// <summary>
    /// TODO: Check lowered code in SharpLabIO.
    /// </summary>
    /// <param name="N"></param>
    /// <returns></returns>
    public int[] DecomposeWithJaggedArray(int N) //Somehow more memory is allocated. Strange. Might have to
    {
        if (N is <= 0 or 2)
        {
            return Array.Empty<int>();
        }

        int oddNumb = 1;
        var decompDict = new int[N/2][];
        int remainder = N;
        int jaggedCount = 0;
        
        while (true)
        {
            remainder -= oddNumb;
            if (remainder <= 0) break;
            decompDict[jaggedCount++] = new[] {oddNumb, remainder};
            oddNumb += 2;
        }

        if (decompDict.Length == 0)
        {
            return N % 2 == 0 ? Array.Empty<int>() : new int[1] { N };
        }

        int runningSum = 0;
        var result = new List<int>();

        foreach (var item in decompDict)
        {
            var key = item[0];
            var val = item[1];
            runningSum += key;
            result.Add(key);
            
            if (val % 2 == 0) continue;

            if (key + val == N)
            {
                result.Add(val);
                break;
            }
            
            if (val <= key || runningSum + val != N) continue;
            result.Add(val);
            break;
        }

        return result.Sum() == N ? result.ToArray() : new int[1] {N};
    }
}