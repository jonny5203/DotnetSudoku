using DotnetSudoku.GameLogic;

namespace DotnetSudoku.Model;

public class Group
{
    private Cell[,] _group { get; set; }
    private int _groupNumber { get; }

    public Group(Cell[,] group, int groupNumber)
    {
        _group = group;
        _groupNumber = groupNumber;
    }
    
    public void ChangeCell(int value, int cellPositionX, int cellPositionY)
    {
        _group[cellPositionX, cellPositionY].Value = value;
        
    }
    
}