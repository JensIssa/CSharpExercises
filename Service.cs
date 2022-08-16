using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace ClassLibrary1;

public class Service: IService
{
    public object FindElement(IEnumerable<object> data, int index)
    {
        return data.ElementAt(index);
    }

    public bool AreTheseStringsEqual(string str1, string str2)
    {
        return str1.Equals(str2);
    }

    public int Factorial(int n)
    {
        int number = n;
        for (int i = number - 1; i >=1; i-- )
        {
            n = n * i;
        }

        return n;
    }

    public int Fibonacci(int n)
    {
        if (n < 2)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    public IEnumerable<int> FindValuesGreaterThan(IEnumerable<int> data, int value)
    {
        IEnumerable<int> data2 = null;
        for (int i = 0; i > value; i++)
        {
            data2.ToList().Add(i);
        }
        return data2;
    }

    public double FindAverage(IEnumerable<int> data)
    {
        return data.Average();
    }

    public string SwapCharacters(string testString, char swapA, char swapB)
    {
        return new string(testString.Select( ch => (ch == swapA) ? swapB :(ch == swapB) ? swapA : ch).ToArray());
    }

    public int ConvertStringToIntIfValidIntegerValue(string testString)
    {
        int x = Int32.Parse(testString);
        return x;
    }

    class Proper
    {
        public int field;

        public int Property
        {
            get
            {
                return field * 2;
            }
            set
            {
                field = value;
            }
        }
    }

    public object CreateObjectWithPropretyWhichHasAccessors()
    {
        return new Proper();
    }

    public IEnumerable<object> CreateListWithObjectsContainingIntAndItsSquare(IEnumerable<int> data)
    {
        throw new NotImplementedException();
    }

    public Dictionary<int, int> CreateDictionrayWithIntsAndTheirFrequency(IEnumerable<int> data)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<int> CreateListOfHighestFiveNumbers(IEnumerable<int> data)
    {
        return data.OrderByDescending(x => x).Take(5);
    }

    public bool IsDateEarlierThanToday(DateTime date)
    {
        if (date < DateTime.Now)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public DateTime CreateDateFromNumberOfMillisecondsSinceUnixEpoch(long milliseconds)
    {
        DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeMilliseconds(milliseconds);
        return dateTimeOffset.Date;
    }

    public List<DateTime> CreateListOfLatestTwoDates(IEnumerable<DateTime> dates)
    {
        return dates.OrderByDescending(x => x).Take(2).ToList();

    }

    public IEnumerable<string> PerformInMemoryInnerJoin(IEnumerable<string> left, IEnumerable<string> right)
    {
      return left.Concat(right);
    }

    public List<int> EvilNumbers(List<int> data)
    {
        throw new NotImplementedException();
    }

    public List<int> AbundantNumbers(IEnumerable<int> data)
    {
        throw new NotImplementedException();
    }
}