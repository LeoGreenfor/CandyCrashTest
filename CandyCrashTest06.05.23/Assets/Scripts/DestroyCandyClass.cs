using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;

public static class DestroyCandyClass
{
    public static void Destroy3Horizontal(Image[,] candyImagesOnGrid,
                                        int row,
                                        int collumn)
    {
        candyImagesOnGrid[row, collumn].GetComponent<CandyBehaviour>().DestroyCandy();
        candyImagesOnGrid[row, collumn + 1].GetComponent<CandyBehaviour>().DestroyCandy();
        candyImagesOnGrid[row, collumn + 2].GetComponent<CandyBehaviour>().DestroyCandy();
    }

    public static void Destroy3Vertical(Image[,] candyImagesOnGrid,
                                        int row,
                                        int collumn)
    {
        candyImagesOnGrid[row, collumn].GetComponent<CandyBehaviour>().DestroyCandy();
        candyImagesOnGrid[row + 1, collumn].GetComponent<CandyBehaviour>().DestroyCandy();
        candyImagesOnGrid[row + 2, collumn].GetComponent<CandyBehaviour>().DestroyCandy();
    }

    public static void Destroy4Horizontal(Image[,] candyImagesOnGrid,
                                        int row,
                                        int collumn)
    {
        candyImagesOnGrid[row, collumn].GetComponent<CandyBehaviour>().DestroyCandy();
        candyImagesOnGrid[row, collumn + 1].GetComponent<CandyBehaviour>().DestroyCandy();
        candyImagesOnGrid[row, collumn + 2].GetComponent<CandyBehaviour>().DestroyCandy();
        candyImagesOnGrid[row, collumn + 3].GetComponent<CandyBehaviour>().DestroyCandy();
    }

    public static void Destroy4Vertical(Image[,] candyImagesOnGrid,
                                        int row,
                                        int collumn)
    {
        candyImagesOnGrid[row, collumn].GetComponent<CandyBehaviour>().DestroyCandy();
        candyImagesOnGrid[row + 1, collumn].GetComponent<CandyBehaviour>().DestroyCandy();
        candyImagesOnGrid[row + 2, collumn].GetComponent<CandyBehaviour>().DestroyCandy();
        candyImagesOnGrid[row + 3, collumn].GetComponent<CandyBehaviour>().DestroyCandy();
    }

    public static void Destroy5Horizontal(Image[,] candyImagesOnGrid,
                                        int row,
                                        int collumn)
    {
        candyImagesOnGrid[row, collumn].GetComponent<CandyBehaviour>().DestroyCandy();
        candyImagesOnGrid[row, collumn + 1].GetComponent<CandyBehaviour>().DestroyCandy();
        candyImagesOnGrid[row, collumn + 2].GetComponent<CandyBehaviour>().DestroyCandy();
        candyImagesOnGrid[row, collumn + 3].GetComponent<CandyBehaviour>().DestroyCandy();
        candyImagesOnGrid[row, collumn + 4].GetComponent<CandyBehaviour>().DestroyCandy();
    }

    public static void Destroy5Vertical(Image[,] candyImagesOnGrid,
                                        int row,
                                        int collumn)
    {
        candyImagesOnGrid[row, collumn].GetComponent<CandyBehaviour>().DestroyCandy();
        candyImagesOnGrid[row + 1, collumn].GetComponent<CandyBehaviour>().DestroyCandy();
        candyImagesOnGrid[row + 2, collumn].GetComponent<CandyBehaviour>().DestroyCandy();
        candyImagesOnGrid[row + 3, collumn].GetComponent<CandyBehaviour>().DestroyCandy();
        candyImagesOnGrid[row + 4, collumn].GetComponent<CandyBehaviour>().DestroyCandy();
    }
}
