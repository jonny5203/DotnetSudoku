using DotnetSudoku.GameLogic;

namespace DotnetSudoku.Model;

public class Board
{
    private readonly Group[,] _board;

    public Board()
    {
        _board = new Group[3, 3];
        
        //Create groups and put it into the board
        for (int i = 0; i < _board.GetLength(0); i++)
        {
            for (int j = 0; j < _board.GetLength(1); j++)
            {
                Group groupToBeAdded = new Group(i, j);
                
                //Create cells and put it into the groups
                for (int celli = 0; celli < _board.GetLength(0); celli++)
                {
                    for (int cellj = 0; cellj < _board.GetLength(1); cellj++)
                    {
                        var randomConditionMet = false;
                        Random random = new Random();
                        int lastRandomNumber = 0;
                        while (randomConditionMet == false)
                        {
                            // Generate a random integer between 1 and 9 (inclusive)
                            int randomNumber = random.Next(1, 10);
                            if (randomNumber == lastRandomNumber) continue;


                            if(LegalPlacement(randomNumber, celli, cellj, i, j))
                            {
                                randomConditionMet = true;
                            }

                            lastRandomNumber = randomNumber;
                        }

                        groupToBeAdded.AddCellToGroup(new Cell(lastRandomNumber, celli, cellj), celli, cellj);
                    }
                }

                _board[i, j] = groupToBeAdded;
            }
        }
    }
    
    public Group GetGroupByPosition(int verticalGroups, int horizontalGroups)
    {
        return _board[horizontalGroups, verticalGroups];
    }

    public bool LegalPlacement(int value, int innerArrayVertical, int innerArrayHorizontal, int verticalGroups, int horizontalGroups)
    {
        if (_board[horizontalGroups, verticalGroups].CheckCellsValues(value, innerArrayVertical, innerArrayHorizontal))
        {
            return false;
        }
        for (int i = 0; i < 3; i++)
        {
            if (_board[i, verticalGroups] == null!)
            {
                continue;
            }
            if (_board[i, verticalGroups].CheckCellsValues(value, innerArrayHorizontal, innerArrayVertical)
                && i != horizontalGroups)
            {
                return false;
            }
            
            if (_board[horizontalGroups, i] == null!)
            {
                continue;
            }
            if (_board[horizontalGroups, i].CheckCellsValues(value, innerArrayHorizontal, innerArrayVertical)
                && i != verticalGroups)
            { 
                return false;
            }
        }
        
        return true;
    }

    public void AddGroupToBoard(Group group, int verticalPosition, int horizontalPosition)
    {
        _board[horizontalPosition, verticalPosition] = group;
    }
}