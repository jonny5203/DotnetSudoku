using DotnetSudoku.GameLogic;

namespace DotnetSudoku.Model;

public class Group
{
    private Cell[,] _group;
    private VerticalGroups _verticalGroup;
    private HorizontalGroups _horizontalGroup;

    public Group(Cell[,] group, VerticalGroups verticalGroup, HorizontalGroups horizontalGroups)
    {
        _group = group;
        _verticalGroup = verticalGroup;
        _horizontalGroup = horizontalGroups;
    }

    public void ChangeCell(int value, int cellPositionX, int cellPositionY)
    {
        _group[cellPositionX, cellPositionY].Value = value;
    }
    

}