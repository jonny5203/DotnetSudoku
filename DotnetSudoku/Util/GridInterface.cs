using DotnetSudoku.Model;

namespace DotnetSudoku.GameLogic;

public static class GridInterface
{
    public static int GetAllNabouringGroups(HorizontalGroups horizontalGroups)
    {
        int groupNum =  (int) horizontalGroups;
        return groupNum;
    }

    public static int GetRowAcrossGroups(ref Board board, HorizontalGroups horizontalGroups, VerticalGroups verticalGroups)
    {
        
    }
}

public enum HorizontalGroups : ushort
{
    Group1 = 0,
    Group2 = 1,
    Group3 = 2,
}

public enum VerticalGroups : ushort
{
    Group1 = 0,
    Group2 = 1,
    Group3 = 2,
}
