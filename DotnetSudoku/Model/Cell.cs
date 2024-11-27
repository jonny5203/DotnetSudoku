﻿namespace DotnetSudoku.Model;

public class Cell
{
    private readonly int _row;
    private readonly int _column;
    private int _value;
    
    public Cell(int row, int column, int value)
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
}