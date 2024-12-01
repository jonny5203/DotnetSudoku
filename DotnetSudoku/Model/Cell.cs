namespace DotnetSudoku.Model;

public class Cell
{
    private readonly int _row;
    private readonly int _column;
    private int _value;
    
    public Cell(int value, int row, int column)
    {
        _row = row;
        _column = column;
        _value = value;
    }
    
    public int Value 
    { 
        get { return _value; } 
        set { _value = value; } 
    }

    public bool ValidValue(int value)
    {
        if (value == _value)
        {
            return false;
        }
        return true;
    }
}