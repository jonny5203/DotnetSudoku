using DotnetSudoku.GameLogic;

namespace DotnetSudoku.Model;

public class Board
{
    private readonly HorizontalGroups _horizontalGroups;
    private readonly VerticalGroups _verticalGroups;
    private Group[,] _board { get; set; }

    public Board(Group[,] board, HorizontalGroups horizontalGroups, VerticalGroups verticalGroups)
    {
        _board = board;
        _horizontalGroups = horizontalGroups;
        _verticalGroups = verticalGroups;
    }
    
    public Group GetGroupByPosition(VerticalGroups verticalGroups, HorizontalGroups horizontalGroups)
    {
        return _board[(int)verticalGroups, (int)horizontalGroups];
    }

    public bool legalPlacement(int innerArrayVertical, int innerArrayHorizontal, VerticalGroups verticalGroups, HorizontalGroups horizontalGroups)
    {
        Group[] relatedGroups = _board.GetLength((int) verticalGroups);

        for (int i = 0; i < 9; i++)
        {
            if ()
            {

            }
        }
    }
}