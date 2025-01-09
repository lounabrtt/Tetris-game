public class Shape
{
    public string Color { get; set; }
    public int[,] Matrix { get; set; }
    public (int X, int Y) Position { get; set; }

    public Shape(string color, int[,] matrix)
    {
        Color = color;
        Matrix = matrix;
        Position = (0, 0); // Par défaut en haut de la grille
    }

    public void Rotate()
    {
        // Logique pour pivoter la matrice
    }

    public void Move(string direction)
    {
        // Logique pour changer la position
    }
}
