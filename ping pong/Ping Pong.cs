using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
//To do:
//Add vs. AI mode
//Fix keyboard controls so each key can be pressed independently
namespace ping_pong
{
    public partial class Ping : Form
    {
        public static int points=0;//tracks player 1's points
        public static int points_p2 = 0;//tracks player 2's points
        public static int speed_left = 10;//tracks the left or right momentum of the ball
        public static int speed_top = 10;//tracks the top or bottom momentum of the ball
        public static int minuites_left = 99999;//tracks the number of minuites left in a timed game (set to max value changed by user in the set form)
        public static int seconds_left = 60;//tracks the number of seconds left in a timed game (set to max value changed by user in the set form)
        public Ping()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ping_FormClosing);//adds the form closing event handler so that the event can be cancelled essencially bypassing alt+F4
            time_or_points_target_lbl.Visible = false;//sets the label showing the time left or points target to be invisible
            time_or_points_target_lbl.Enabled = false;//disables the label showing the time left or points target
            System.Windows.Forms.Cursor.Hide();//hides the cursour of the user in order  ot imporve games viewability
            delayp1.Enabled = true;//activates 60 fps timer to update position sand check colision
            this.Bounds = Screen.PrimaryScreen.Bounds; //sets the screen bounds to the screen
            playspace.Bounds = Screen.PrimaryScreen.Bounds;//sets the playspace bounds to the screen
            score_lbl.Left = playspace.Left;//moves p1 score label to its correct place
            racket.Left = playspace.Left+(playspace.Right/10); /// sets racket in accurate place
            p2points_lbl.Left=playspace.Right-(playspace.Right/8);//sets p2 score label in correct place
            racketp2.Left = playspace.Right- (playspace.Right/10);//sets p2 racket in correct place
            DoubleBuffered = true;//allows for images to be rendered with doublebuffering (partial fix to ghosting)
            points = 0;//sets/resets p1 points to 0
            points_p2 = 0;//sets/resets p2 points to 0
            score_lbl.Text = "P1 Points: " + points;//updates label for points
            p2points_lbl.Text = "P2 Points: " + points_p2;//updates label for points
            ball.Top = playspace.Size.Height/2;//makes the ball start in the middle of the screen
            ball.Left = playspace.Size.Width/2;
            speed_left = 10;//sets the base speed of the ball
            speed_top = 10;
            gameover_lbl.Top = playspace.Size.Height / 2;//sets gameover label to appear in the middle of the screen
            gameover_lbl.Left = playspace.Size.Width / 2;
            time_or_points_target_lbl.Top = 0;//attempts to set the time/points tracker to top centre of screen
            time_or_points_target_lbl.Left = playspace.Size.Width / 2;
            if (Start_screen.gamemode == "timed")//if the gamemode is timed
            {
                timed_game.Enabled = true;//enable timer that counts down time remaining in the game
                minuites_left = Set.pointtarget_or_time[0];//creates a copy of the original minuites left so that when F1 is pressed it can be reset to the coprrect original state
                seconds_left = Set.pointtarget_or_time[1];//creates a copy of the original seconds left so that when F1 is pressed it can be reset to the coprrect original state
                time_or_points_target_lbl.Visible = true;//makes the label visible and sets it up with the correct time
                time_or_points_target_lbl.Enabled = true;
                if (seconds_left < 10)//makes sure a 0 is added to the begining of seconds if it drops below 0 (HCI purposes)
                {
                    time_or_points_target_lbl.Text = "Time left: " + minuites_left + ":0" + seconds_left;
                }
                else
                {
                    time_or_points_target_lbl.Text = "Time left: " + minuites_left + ":" + seconds_left;
                }
            }
            else if (Start_screen.gamemode == "points")//if the gamemode is points
            {
                time_or_points_target_lbl.Visible = true;//makes target points visible and sets correct target
                time_or_points_target_lbl.Enabled = true;
                time_or_points_target_lbl.Text = "Points target: " + Set.pointtarget_or_time[0];
            }
        }
        private void delay_Tick(object sender, EventArgs e)
        {

            #region Checking for points game complete
            if (Start_screen.gamemode == "points")//if the user is playing points mode
            {
                if (points == Set.pointtarget_or_time[0])//if p1 has hit the point limit
                {
                    delayp1.Enabled = false;//game ends and it is announced that p1 has won!
                    gameover_lbl.Visible = true;
                    gameover_lbl.Enabled = true;
                    gameover_lbl.Text = "P1 Wins!!\r\n)-------------(\r\nF1- Retry\r\nESC- Quit";
                }
                else if (points_p2 == Set.pointtarget_or_time[0])//if p2 has hit the point limit
                {
                    delayp1.Enabled = false;//game ends and it is announced that p2 has won
                    gameover_lbl.Visible = true;
                    gameover_lbl.Enabled = true;
                    gameover_lbl.Text = "P2 Wins!!\r\n)-------------(\r\nF1- Retry\r\nESC- Quit";
                }
            }
            #endregion
            ball.Left += speed_left;//moves the ball interms of x 
            ball.Top += speed_top;// moves the ball in terms of y
            if (racket.Bounds.IntersectsWith(ball.Bounds))//checks for bat bounce p1
            {
                if (Start_screen.soundon)
                {
                    System.Media.SoundPlayer ping = new System.Media.SoundPlayer();//initialises system music player
                    ping.SoundLocation = Application.StartupPath + "\\ping.wav";//sets audio file target
                    ping.Play();//plays audio
                }
                if (Start_screen.flash)
                {
                    Random colourselector = new Random();//initialises random
                    this.BackColor = Color.FromArgb(colourselector.Next(0, 200), colourselector.Next(0, 200), colourselector.Next(0, 200));//sets backcolour randomly
                }
                speed_left = -speed_left;//inverses movement per hit
                if (speed_top != -26 || speed_top != 26)
                {
                    speed_left += 2;///increases speed
                    speed_top += 2;
                }

            }
            if (racketp2.Bounds.IntersectsWith(ball.Bounds))//checks for bat bounce p2
            {
                if (Start_screen.soundon == true)
                {
                    System.Media.SoundPlayer ping = new System.Media.SoundPlayer();//initialises system music player
                    ping.SoundLocation = Application.StartupPath + "\\ping.wav";//sets audio file target
                    ping.Play();//plays audio
                }
                if (Start_screen.flash)
                {
                    Random colourselector = new Random();//initialises random
                    this.BackColor = Color.FromArgb(colourselector.Next(0, 200), colourselector.Next(0, 200), colourselector.Next(0, 200));//sets backcolour randomly
                }
                speed_left = -speed_left;//inverses movement per hit
                if (speed_top != -26 || speed_top != 26)
                {
                    speed_left += 2;///increases speed
                    speed_top += 2;
                }

            }
            if (ball.Left <= playspace.Left)//if the ball hits the left of the playspace 
            {
                points_p2 += 1;//increases p2 points
                p2points_lbl.Text = "P2 Points: " + points_p2;//updates p2 label for points
                ball.Top = playspace.Size.Height / 2;//resets ball location
                ball.Left = playspace.Size.Width / 2;
                    if (speed_left < 0)
                    {
                        speed_left = 10;//resets ball speed
                        speed_top = 10;
                    }
                    else
                    {
                        speed_left = -10;
                        speed_top = -10;
                    }
            }
            if (ball.Right >= playspace.Right)//if the ball hits the right of the playspace
            {
                points += 1;//increases points
                score_lbl.Text = "P1 Points: " + points;//updates label for points
                ball.Top = playspace.Size.Height / 2;//resets ball location
                ball.Left = playspace.Size.Width / 2;
                    if (speed_left < 0)
                    {
                        speed_left = 10;//resets ball speed
                        speed_top = 10;
                    }
                    else
                    {
                        speed_left = -10;
                        speed_top = -10;
                    }
                
            }
            if (ball.Top <= playspace.Top)//if the ball hits the top of the playspace
            {
                speed_top = -speed_top;//inverses balls up/down momentum
            }
            if (ball.Bottom >= playspace.Bottom)//if the ball hits the bottom of the playspace
            {
                speed_top = -speed_top;//inverses balls up/down momentum
            }
        }

        private void Ping_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)//if the user presses a key
        {
            #region keyboard controls
            if (e.KeyCode == Keys.W && delayp1.Enabled == true)//if the user wants to move p1 bat upwards
            {
                if (racket.Top >= playspace.Top)// if the playspace boundary has not been reached
                {
                    racket.Top = racket.Top - 10;//moves bat
                }
            }
            if (e.KeyCode == Keys.S && delayp1.Enabled == true)//if the user wants to move p1 bat downwards
            {
                if (racket.Bottom <= playspace.Bottom)//if the playsapce boundary has not been reached
                {
                    racket.Top = racket.Top + 10;//moves bat
                }
            }
            if (e.KeyCode == Keys.Up && delayp1.Enabled == true)//if the user wants to move p2 bat upwards
            {
                if (racketp2.Top >= playspace.Top)//if the playspace boundary has not been reached
                {
                    racketp2.Top = racketp2.Top - 10;//moves bat
                }
            }
            if (e.KeyCode == Keys.Down && delayp1.Enabled == true)//if the user wants to move p2 bat downwards
            {
                if (racketp2.Bottom <= playspace.Bottom)//if the playspace boundary has not been met
                {
                    racketp2.Top = racketp2.Top + 10;//moves bat
                }
            }
            #endregion

            if (e.KeyCode==Keys.Escape)//closes when user presses esc
            {
                System.Windows.Forms.Cursor.Show();//renables user's cursor in forms
                Form start = new Start_screen();//starts a new instance of start screen and ends this instance of ping pong
                this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(this.Ping_FormClosing);
                this.Close();
                start.Show();
            }
            if (e.KeyCode==Keys.F1)//resets form when user presses f1
            {
                System.Windows.Forms.Cursor.Hide();//hides cursor
                ball.Top = playspace.Size.Height / 2;//resets ball position
                ball.Left = playspace.Size.Width / 2;
                speed_left = 10;//resets ball speed
                speed_top = 10;
                points = 0;//resets p1 points
                points_p2 = 0;//resets p2 points
                score_lbl.Text = "P1 Points: 0";//resets label for p1 points
                p2points_lbl.Text = "P2 Points: 0";//resets label for p2 points
                gameover_lbl.Visible = false;//gets rid of gameover screen
                delayp1.Enabled = true;//reenables gameplay
                if (Start_screen.gamemode == "timed")//if the gamemode is a timed match
                {
                    minuites_left = Set.pointtarget_or_time[0];//resets the timer using a base copy of the time limit
                    seconds_left = Set.pointtarget_or_time[1];
                    if (seconds_left < 10)//makes sure a 0 is added to the begining of seconds if it drops below 0 (HCI purposes)
                    {
                        time_or_points_target_lbl.Text = "Time left: " + minuites_left + ":0" + seconds_left;
                    }
                    else
                    {
                        time_or_points_target_lbl.Text = "Time left: " + minuites_left + ":" + seconds_left;
                    }
                }

            }
        }

        private void timed_game_Tick(object sender, EventArgs e)//in a timed game the game timer goes down using a c# timer on a 1000 milisecond delay
        {
            if (seconds_left != 0)//if there are seconds left to subtract
            {
                seconds_left -= 1;//subtracts a second
            }
            else if (seconds_left==0 && minuites_left != 0)//if there are no more seconds left to subtract but there are minuites left
            {
                minuites_left -= 1;//subtracts 1 minuite
                seconds_left += 59;//adds 59 seconds to the timer
            }
            else//if there is no time left
            {
                delayp1.Enabled = false;//the game is stopped and the gameover screen appears
                gameover_lbl.Visible = true;
                gameover_lbl.Enabled = true;
                if (points > points_p2)//checks who won the game
                {
                    gameover_lbl.Text = "P1 Wins!!\r\n)-------------(\r\nF1- Retry\r\nESC- Quit";
                }
                else if (points_p2>points)
                {
                    gameover_lbl.Text = "P2 Wins!!\r\n)-------------(\r\nF1- Retry\r\nESC- Quit";
                }
                else
                {
                    gameover_lbl.Text = "Draw!!!!!\r\n)-------------(\r\nF1- Retry\r\nESC- Quit";
                }
            }
            if (seconds_left < 10)//makes sure there is a 0 before seconds if it is only single digit (HCI purposes)
            {
                time_or_points_target_lbl.Text = "Time left: " + minuites_left + ":0" + seconds_left;
            }
            else
            {
                time_or_points_target_lbl.Text = "Time left: " + minuites_left + ":" + seconds_left;
            }
        }

        private void Ping_FormClosing(object sender, FormClosingEventArgs e)//if the form is closing
        {
            e.Cancel=true;//cancel closeing (this bypasses Alt+F4 therefore making the game impossible to close without this event being diabeld which is how esc mannages to close the form)
        }
    }
}
