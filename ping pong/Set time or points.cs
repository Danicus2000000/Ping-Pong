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
    public partial class Set : Form
    {
        public Set()
        {
            InitializeComponent();
        }
        public static List<int> pointtarget_or_time= new List<int>();//creates a list that will either store the points limit or the two halfs of the time limit mm and ss
        public static bool complete=false;//used to check whether all processes and outputs performed by the form are correct (form cannot close until true)
        private void Set_Load(object sender, EventArgs e)//when the form loads
        {
            pointtarget_or_time.Clear();//empties the list of values in case this form has benn used before
            if (Start_screen.gamemode == "points")//sets the function of this form based on the gamemode that is selected
            {
                this.Text = "Set points target";//sets title
                title_lbl.Text = "Please enter a points limit.";//sets description text
            }
            else if (Start_screen.gamemode == "timed")
            {
                this.Text = "set playtime counter";//sets title
                title_lbl.Text = "Please enter a time limit.";//sets description text
            }
        }

        private void confrim_btn_Click(object sender, EventArgs e)//when the confirm button is pressed
        {
            if (Start_screen.gamemode == "points")//if the game is based on points
            {
                if (entry_txt.Text != "")//if the text box isnt empty
                {
                    complete = true;//checks if an error has occured
                    try//attempts to convert to int and catches the error if this cannot be done
                    {
                        pointtarget_or_time.Add(Convert.ToInt32(entry_txt.Text));
                    }
                    catch (Exception)
                    {
                        complete = false;//sets to false if error occurs
                    }
                    if (complete==false)//notifies user of probabal cause of error
                    {
                        MessageBox.Show("Points must be a whole number!", "invalid points!");
                        pointtarget_or_time.Clear();//clears list of values
                    }
                }
                else//catches textbox being empty
                {
                    MessageBox.Show("Please enter a umber of points to play up to!", "No point target set!");
                }
            }
            else if (Start_screen.gamemode == "timed")//if the user picks a timed game
            {
                if (entry_txt.Text != "")//checks to make sure textbox isn't empty
                {
                    int count = 0;//counts number of values in the list
                    complete = true;//defaults complete to true
                    foreach (string element in entry_txt.Text.Split(':'))//loops through every value in the textbox spliced by : (creates mm and ss)
                    {
                        try//attempts to convert mm or ss to an integer catches error if it fails
                        {
                            pointtarget_or_time.Add(Convert.ToInt32(element));

                        }
                        catch (Exception)
                        {
                            complete = false;//triggers failsafes
                        }
                        count += 1;//increments count by 1
                    }
                    if (count>=3 || count == 1 || pointtarget_or_time[1]>60)//this ensures that the length of the list is correctand that seconds is not more than 60
                    {
                        complete = false;
                    }
                    if (complete == false)//notifies user of probable causes
                    { 
                        MessageBox.Show("Invalid format must be in mm:ss format!\nAnother cause of error could be seconds being more than 60!", "Format failure.");
                        pointtarget_or_time.Clear();//empties list
                    }
                }
                else//catches empty textbox
                {
                    MessageBox.Show("Please enter a time limit!","No time limit set.");
                }
            }
            if (complete == true)//checks if complete is true and if it is the game begins
            {
                Form ping = new Ping();//intialises ping pong form to begin the game
                ping.Show();
                this.Hide();
            }
        }
        private void Set_FormClosed(object sender, FormClosedEventArgs e)//when the form closes it will loop back to the main menu
        {
            Form menu = new Start_screen();//reinitialises main menu
            menu.Show();
        }
    }
}
