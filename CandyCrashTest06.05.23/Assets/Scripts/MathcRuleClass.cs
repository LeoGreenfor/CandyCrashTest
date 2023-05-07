using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;

public static class MathcRuleClass
{
    public static bool Match3Horizontal(Image[,] candyImagesOnGrid, 
                                        int row, 
                                        int collumn, 
                                        int numberOfColumns)
    {
        return (collumn < numberOfColumns - 2) &&
                    (collumn + 2 < numberOfColumns) &&
                    (candyImagesOnGrid[row, collumn + 1].sprite == candyImagesOnGrid[row, collumn].sprite &&
                    candyImagesOnGrid[row, collumn + 2].sprite == candyImagesOnGrid[row, collumn].sprite);
    }

    public static bool Match3Vertical(Image[,] candyImagesOnGrid,
                                        int row,
                                        int collumn,
                                        int numberOfRows)
    {
        return (row < numberOfRows - 2) &&
                    (row + 2 < numberOfRows) &&
                    (candyImagesOnGrid[row + 1, collumn].sprite == candyImagesOnGrid[row, collumn].sprite &&
                    candyImagesOnGrid[row + 2, collumn].sprite == candyImagesOnGrid[row, collumn].sprite);
    }

    public static bool Match4Horizontal(Image[,] candyImagesOnGrid,
                                        int row,
                                        int collumn,
                                        int numberOfColumns)
    {
        return (collumn < numberOfColumns - 3) &&
                    (collumn + 3 < numberOfColumns) &&
                    (candyImagesOnGrid[row, collumn + 1].sprite == candyImagesOnGrid[row, collumn].sprite &&
                    candyImagesOnGrid[row, collumn + 2].sprite == candyImagesOnGrid[row, collumn].sprite &&
                    candyImagesOnGrid[row, collumn + 3].sprite == candyImagesOnGrid[row, collumn].sprite);
    }

    public static bool Match4Vertical(Image[,] candyImagesOnGrid,
                                        int row,
                                        int collumn,
                                        int numberOfRows)
    {
        return (row < numberOfRows - 3) &&
                    (row + 3 < numberOfRows) &&
                    (candyImagesOnGrid[row + 1, collumn].sprite == candyImagesOnGrid[row, collumn].sprite &&
                    candyImagesOnGrid[row + 2, collumn].sprite == candyImagesOnGrid[row, collumn].sprite &&
                    candyImagesOnGrid[row + 3, collumn].sprite == candyImagesOnGrid[row, collumn].sprite);
    }

    public static bool Match5Horizontal(Image[,] candyImagesOnGrid,
                                        int row,
                                        int collumn,
                                        int numberOfColumns)
    {
        return (collumn < numberOfColumns - 4) &&
                    (collumn + 4 < numberOfColumns) &&
                    (candyImagesOnGrid[row, collumn + 1].sprite == candyImagesOnGrid[row, collumn].sprite &&
                    candyImagesOnGrid[row, collumn + 2].sprite == candyImagesOnGrid[row, collumn].sprite &&
                    candyImagesOnGrid[row, collumn + 3].sprite == candyImagesOnGrid[row, collumn].sprite &&
                    candyImagesOnGrid[row, collumn + 4].sprite == candyImagesOnGrid[row, collumn].sprite);
    }

    public static bool Match5Vertical(Image[,] candyImagesOnGrid,
                                        int row,
                                        int collumn,
                                        int numberOfRows)
    {
        return (row < numberOfRows - 4) &&
                    (row + 4 < numberOfRows) &&
                    (candyImagesOnGrid[row + 1, collumn].sprite == candyImagesOnGrid[row, collumn].sprite &&
                    candyImagesOnGrid[row + 2, collumn].sprite == candyImagesOnGrid[row, collumn].sprite &&
                    candyImagesOnGrid[row + 3, collumn].sprite == candyImagesOnGrid[row, collumn].sprite &&
                    candyImagesOnGrid[row + 4, collumn].sprite == candyImagesOnGrid[row, collumn].sprite);
    }
}
