using Godot;
using System;

public class Main : Node2D
{
    private RandomNumberGenerator Rnd;          // Random number generator
    private Sprite IconSprite;                  // The Icon sprite

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        Rnd = new RandomNumberGenerator();      // Create a new random number generator
        Rnd.Randomize();                        // Randomize the start seed
        IconSprite = GetNode<Sprite>("Icon");   // Get the icon sprite from the main scene
    }
    private void RandomizeIconSpritePosition()
    {
        // Randomize a position on the screen where the sprite will move to
        var x = Rnd.RandiRange(0, (int)OS.WindowSize.x);
        var y = Rnd.RandiRange(0, (int)OS.WindowSize.y);

        // set the icon to the randomized position
        IconSprite.Position = new Vector2(x, y);
    }
    private void OnTimerTimeout()
    {
        RandomizeIconSpritePosition();      // Randomize the icon sprite position
    }
//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//
//  }
}
