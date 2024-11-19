using System.Security.Cryptography.X509Certificates;

public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }
    
    public Fraction(int wholeNumber)
    {
        _topNumber = wholeNumber;
        _bottomNumber = 1;
    }

    public Fraction(int top, int bottom)
    {
        _topNumber = top;
        _bottomNumber = bottom;
    }

    public int GetTop()
    {
        return _topNumber;
    }

    public void SetTop(int top)
    {
        _topNumber = top;
    }

    public int GetBottom()
    {
        return _bottomNumber;
    }

    public void SetBottom(int bottom)
    {
        _bottomNumber = bottom;
    }

    public string GetFractionString()
    {
        // int numerator = GetTop();
        // int denominator = GetBottom();
        // return $"{numerator}/{denominator}";
        string text = $"{_topNumber}/{_bottomNumber}";
        return text;
    }

    public double GetDecimalValue()
    {
        // int numerator = GetTop();
        // int denominator = GetBottom();
        // double decimalNumber = numerator / denominator;
        // return decimalNumber;
        return (double)_topNumber / (double)_bottomNumber;
    }
}