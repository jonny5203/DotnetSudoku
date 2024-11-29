using DotnetSudoku.GameLogic;

namespace DotnetSudoku.Model;

public class Group
{
    private readonly Cell[,] _cells;
    private int _verticalGroup;
    private int _horizontalGroup;

    public Group(int verticalGroup, int horizontalGroups)
    {
        _cells = new Cell[3, 3];
        _verticalGroup = verticalGroup;
        _horizontalGroup = horizontalGroups;
    }

    public void AddCellToGroup(Cell cell, int cellPositionX, int cellPositionY)
    {
        _cells[cellPositionX, cellPositionY] = cell;
    }

    public void ChangeCell(int value, int cellPositionX, int cellPositionY)
    {
        _cells[cellPositionX, cellPositionY].Value = value;
    }

    public bool CheckCellsValues(int value, int cellPositionX, int cellPositionY)
    {
        for (int i = 0; i < 3; i++)
        {
            if (_cells[i, cellPositionY].ValidValue(value) && _cells[cellPositionY, i].ValidValue(value))
            {
                return false;
            }
        }
        return true;
    }
}