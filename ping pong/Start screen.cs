using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ping_pong
{
    public partial class Start_screen : Form
    {
        public Start_screen()
        {
            InitializeComponent();
            flashing_light_tick(this,new EventArgs());//changes text to be random multi colour only ONCE
        }
        public static string gamemode = string.Empty;//stores the gamemode the user has chosen to play
        public static bool soundon { get { return false; } set {  } }//is used to check whether sound is on
        public static bool flash = false;
        private void infinitemode_btn_Click(object sender, EventArgs e)//if the user presses the button to play infinitely
        {
            gamemode = "infinite";//sets gamemode to infinite
            Form PingPong = new Ping();//initialises the ping pong form
            PingPong.Show();
            this.Hide();
        }
        private void timedmode_btn_Click(object sender, EventArgs e)//if the user presses the button to play timed mode
        {
            gamemode = "timed";//sets gamemode to timed
            Form data = new Set();//initalises the data entry form to gather the time limit
            data.Show();
            this.Hide();
        }

        private void pointsmode_btn_Click(object sender, EventArgs e)//if the user presses the button to play points mode
        {
            gamemode = "points";//sets gamemode to points
            Form data = new Set();//initilises the data entry form to gather the point limit
            data.Show();
            this.Hide();
        }

        private void Start_screen_FormClosed(object sender, FormClosedEventArgs e)//if the user closes the form
        {
            Application.Exit();//closes all background and forground processes associated with the app
        }

        private void settings_btn_Click(object sender, EventArgs e)//if the user presses the settings button
        {
             DialogResult result= MessageBox.Show("Would you like sound turned on?", "Sound", MessageBoxButtons.YesNo);//enaable and disable sound as requested
             if (result == DialogResult.Yes)
             {
                 soundon = true;
                 soundon_lbl.Text = "Sound: On";
             }
             else if (result == DialogResult.No)
             {
                 soundon = false;
                 soundon_lbl.Text = "Sound: Off";
             }
            result = MessageBox.Show("Would you like sound turned background colour change on hit?", "Epilepsy Warning", MessageBoxButtons.YesNo);//enable and disable flashing lights as requested
            if (result == DialogResult.Yes)
            {
                if (!flash) 
                {
                    flashing_light.Tick += flashing_light_tick;
                }
                flash = true;
                bgflash_lbl.Text = "BG Flash: On";
            }
            else if (result == DialogResult.No)
            {
                flash = false;
                bgflash_lbl.Text = "BG Flash: Off";
                flashing_light.Tick -= flashing_light_tick;
            }
        }
        private void flashing_light_tick(object sender, EventArgs e)
        {
            Random colourselector = new Random();
            for (int i = 0; i < epilepsy_warning.Text.Length; i++)
            {
                epilepsy_warning.SelectionStart = i;
                epilepsy_warning.SelectionLength = 1;
                epilepsy_warning.SelectionColor = Color.FromArgb(colourselector.Next(0, 200), colourselector.Next(0, 200), colourselector.Next(0, 200));//sets backcolour randomly

            }
        }
    }
}
