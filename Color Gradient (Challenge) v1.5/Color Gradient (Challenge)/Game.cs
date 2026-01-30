// CHALLENGE: have the background color change based on the
//            mouse's position.
// Hint: translate position into color.

// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            // Set up window
            Window.SetTitle("Color Gradient");
            Window.SetSize(400, 400);
        }
        
        //System.Drawing.Point cursorPos = System.Windows.Forms.Cursor.Position;
        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Calculate red and green.
            float r = Input.GetMouseX()/400; // 1 = 100% light (red channel)
            float g = Input.GetMouseY()/400; // 0 =   0% light (green channel)
            // This challenge does not expect you to set the B color channel.
            float b = 0f;

            // Combine the 3 color components we defined above
            ColorF bgColor = new ColorF(r, g, b);

            // Clear the background with this color
            Window.ClearBackground(bgColor);
        }
    }
}
