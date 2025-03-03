using System;

namespace ChiayinYang_Assignment2
{

    public partial class PlatformGame : Form
    {
        bool isGoingRight = false;
        bool isGoingLeft = false;
        bool isJumping = false;
        int jumpHeight = 18;
        int gravity = 1;
        int groundHeight;

        int totalScore;

        Boolean[] isCoinCaptured = { false, false, false, false };


        bool enemy1GoingRight = true;
        bool enemy1GoingLeft = false;

        bool enemy2GoingRight = true;
        bool enemy2GoingLeft = false;
        int enemySpeed = 5;


        // Boundaries for enemy movement
        int enemy1MinX;
        int enemy1MaxX;

        int enemy2MinX; // Left boundary for enemy2
        int enemy2MaxX; // Right boundary for enemy2

        private DateTime startTime;
        public PlatformGame()
        {
            InitializeComponent();
            groundHeight = this.ClientSize.Height - player.Height; // Set ground height based on form size
            //  Example:
            //  if the window height is 600 pixels and the player height is 100 pixels,
            //  groundHeight would be 500 pixels (600 - 100 = 500).
            //  This means the ground would be positioned 500 pixels from the top of the window

            timer.Start();
            startTime = DateTime.Now;


            // Initialize enemy boundaries
            enemy1MinX = enemy1.Location.X; // Set minimum X for enemy1
            enemy1MaxX = enemy1MinX + 420;  // Set maximum X for enemy1

            enemy2MinX = enemy2.Location.X;  // Set minimum X for enemy2
            enemy2MaxX = enemy2MinX + 800;   // Set maximum X for enemy2

        }

        private void PlatformGame_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the space key is pressed for jumping
            if (e.KeyCode == Keys.Space && !isJumping)
            {
                isJumping = true; // Start jumping
            }

            // Check if the right arrow key is pressed
            if (e.KeyCode == Keys.Right && !isGoingRight)
            {
                isGoingRight = true; // Start moving right
            }

            // Check if the left arrow key is pressed
            if (e.KeyCode == Keys.Left && !isGoingLeft)
            {
                isGoingLeft = true; // Start moving left
            }
        }
        private void PlatformGame_KeyUp(object sender, KeyEventArgs e)
        {
            // Stop moving right if the right arrow key is released
            if (e.KeyCode == Keys.Right)
            {
                isGoingRight = false; // Stop moving right
            }

            // Stop moving left if the left arrow key is released
            if (e.KeyCode == Keys.Left)
            {
                isGoingLeft = false; // Stop moving left
            }
        }
        // timer_tick is for updating the game state and triggering any different actions
        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;
            labelScoreAndTime.Text = "Time Elapsed: " + elapsedTime.Seconds + "\nTotal Score: " + totalScore;

            // Enemy1 movement logic
            if (enemy1GoingLeft && enemy1.Location.X > enemy1MinX)
            {
                enemy1.Left -= enemySpeed;  // Move enemy1 left
            }
            else
            {
                enemy1GoingLeft = false;  // Change direction to right
                enemy1GoingRight = true;
            }

            if (enemy1GoingRight && enemy1.Location.X < enemy1MaxX)
            {
                enemy1.Left += enemySpeed;  // Move enemy1 right
            }
            else
            {
                enemy1GoingRight = false;  // Change direction to left
                enemy1GoingLeft = true;
            }

            // Enemy2 movement logic
            if (enemy2GoingLeft && enemy2.Location.X > enemy2MinX)
            {
                enemy2.Left -= enemySpeed;  // Move enemy2 left
            }
            else
            {
                enemy2GoingLeft = false;  // Change direction to right
                enemy2GoingRight = true;
            }

            if (enemy2GoingRight && enemy2.Location.X < enemy2MaxX)
            {
                enemy2.Left += enemySpeed;  // Move enemy2 right
            }
            else
            {
                enemy2GoingRight = false;  // Change direction to left
                enemy2GoingLeft = true;
            }

            // Player jumping logic
            if (isJumping)
            {
                player.Top = player.Top - jumpHeight; // Move player up
                jumpHeight = jumpHeight - gravity; // Decrease jump height for gravity effect

                // Reset jump if player lands on ground
                if (player.Top >= groundHeight)
                {
                    player.Top = groundHeight; // Align player with ground
                    isJumping = false; // Reset jumping state
                    jumpHeight = 18; // Reset jump height
                }
            }
            else
            {
                // Apply gravity if player is not jumping
                if (player.Top < groundHeight)
                {
                    player.Top += gravity + 3;
                }
            }

            // Move player based on input
            if (isGoingRight)
            {
                player.Left += 5; // Move player right
            }

            if (isGoingLeft)
            {
                player.Left -= 5; // Move player left
            }

            // Check if player is on platforms
            if (player.Bounds.IntersectsWith(platform1.Bounds))
            {
                //This checks if the bottom edge of the player is below the bottom edge of platform1.
                if (player.Bottom > platform1.Bottom)
                {
                    player.Top = player.Bottom + 1;
                }
                else
                {
                    player.Top = platform1.Top - player.Height;
                    isJumping = false;
                    jumpHeight = 18;
                }
              
            }
            else if (player.Bounds.IntersectsWith(platform2.Bounds))
            {
                if (player.Bottom > platform2.Bottom)
                {
                    player.Top = player.Bottom + 1;
                }
                else
                {
                    player.Top = platform2.Top - player.Height;
                    isJumping = false;
                    jumpHeight = 18;
                }
            }

            // Check if the player has landed on either platform1 or platform2
            if ((player.Top == player.Top - player.Height && (player.Left < platform1.Left || player.Right > platform1.Right)) || (player.Top == player.Top - player.Height && (player.Left < platform2.Left || player.Right > platform2.Right)))
            {
                isJumping = false; // If the player has landed, set isJumping to false
            }

            // Check for coin capture
            if (!isCoinCaptured[0] && player.Bounds.IntersectsWith(coin1.Bounds))
            {
                isCoinCaptured[0] = true;
                coin1.Visible = false;
                totalScore += 10;
            }
            if (!isCoinCaptured[1] && player.Bounds.IntersectsWith(coin2.Bounds))
            {
                isCoinCaptured[1] = true;
                coin2.Visible = false;
                totalScore += 10;
            }
            if (!isCoinCaptured[2] && player.Bounds.IntersectsWith(coin3.Bounds))
            {
                isCoinCaptured[2] = true;
                coin3.Visible = false;
                totalScore += 10;
            }
            if (!isCoinCaptured[3] && player.Bounds.IntersectsWith(coin4.Bounds))
            {
                isCoinCaptured[3] = true;
                coin4.Visible = false;
                totalScore += 10;
            }

            // Check for game over conditions
            if (player.Bounds.IntersectsWith(enemy1.Bounds) || player.Bounds.IntersectsWith(enemy2.Bounds) || player.Bounds.IntersectsWith(enemy3.Bounds))
            {
                gameOver("Game Over...");
            }

            // Check if player reached the goal
            if (player.Bounds.IntersectsWith(goal.Bounds))
            {
                gameOver("Congratulations! You reached the goal!");
            }
        }
        private void gameOver(string message)
        {
            DateTime endTime = DateTime.Now;

            timer.Stop();

            // Hide all objects
            player.Visible = false;
            coin1.Visible = false;
            coin2.Visible = false;
            coin3.Visible = false;
            coin4.Visible = false;
            platform1.Visible = false;
            platform2.Visible = false;
            enemy1.Visible = false;
            enemy2.Visible = false;
            enemy3.Visible = false;

            // Reset game state
            isJumping = false;
            isGoingRight = false;
            isGoingLeft = false;

            MessageBox.Show(message);
        }


    }
}
