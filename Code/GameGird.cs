public class GameGrid
{
    public int Width { get; private set; }
    public int Height { get; private set; }
    public int[,] Grid { get; private set; }

    public GameGrid(int width, int height)
    {
        Width = width;
        Height = height;
        Grid = new int[height, width];
    }

    public bool CheckCollision(Shape shape)  
    {
       
        return false;
    }

    public void ClearLines() // delet a line when shes full
    {
        
    }
}
