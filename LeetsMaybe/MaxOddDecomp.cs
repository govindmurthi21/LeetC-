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
    
    public int[] FasterDecompose(int N)
    {
        if (N is <= 0 or 2)
        {
            return Array.Empty<int>();
        }

        var arr = new List<int>();
        var oddNumb = 1;
        var total = 0;

        while (true)
        {
            total += oddNumb;
            if (total > N) break;
            arr.Add(oddNumb);
            oddNumb += 2;
        }
        
        if (total == N) return arr.ToArray();

        var len = arr.Count;

        if (len == 1)
        {
            return N % 2 == 0 ? Array.Empty<int>() : new int[1] { N };
        }

        if (arr.Sum() == N) return arr.ToArray();

        var calculate = (int total, int oddElem) =>
        {
            while (total < N)
            {
                total += 2;
                oddElem += 2;
            }

            return total == N ? oddElem : -1;
        };

        while (len > 0)
        {
            arr = arr.Take(len).ToList();
            var val = calculate(arr.Sum(), arr[len - 1]);
            if (val > -1)
            {
                arr[len - 1] = val;
                break;
            }

            len += val;
        }
        return arr.ToArray();
    }
}