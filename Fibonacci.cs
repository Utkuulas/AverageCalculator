public class Fibonacci
{
    private int ElementCount {get;}
    private List<int> Sequence {get;}
    private double Average {get;}

    public Fibonacci(int count)
    {
        ElementCount = count;
        Sequence = GenerateSequence(count);
        Average = CalculateAverage(Sequence);
    }
    

    private List<int> GenerateSequence(int count)
    {
        
        List<int> sequence = new ();

        if(count > 0)
        {
            sequence.Add(1);
            int sequenceElement = 0;

            for(int i = 1; i <= count - 1; i++)
            {
                if(i != 1)
                {
                    sequenceElement = sequence.ElementAt(i-2);
                }
            
                sequence.Add(sequence.Last() + sequenceElement);   
            }
        }

        return sequence;
    }

    private double CalculateAverage(List<int> sequence)
    {
        int sumOfElements = 0;

        foreach(int item in sequence)
        {
            sumOfElements += item;
        }

        return (double) sumOfElements / sequence.Count();
    }

    public List<int> GetSequence()
    {
        return Sequence;
    }

    public double GetAverage()
    {
        return Average;
    }
}