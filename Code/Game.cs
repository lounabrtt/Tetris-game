public class Game
{
    public GameGrid Grid { get; private set; }
    public Shape CurrentShape { get; private set; }
    public Shape NextShape { get; private set; }
    public int Score { get; private set; }

    public Game()
    {
        Grid = new GameGrid(10, 20); // Grille 10x20
        Score = 0;
    }

    public void StartGame()
    {
        CurrentShape = GenerateRandomShape();
        NextShape = GenerateRandomShape();
    }

    public void UpdateGame()
    {
        // Mettre à jour la logique du jeu
    }

    private Shape GenerateRandomShape()
    {
        // Logique pour générer une pièce aléatoire
        return new Shape("red", new int[,] { { 1, 1 }, { 1, 1 } });
    }
}
