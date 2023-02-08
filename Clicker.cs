using System.Media;
using System.Runtime.ExceptionServices;

namespace Cookie_Clicker
{
    public partial class Clicker : Form
    {
        public Clicker()
        {
            InitializeComponent();
        }

        int click = 0;


        private void cookie_Click(object sender, EventArgs e)
        {
            ClickCount.Text = click.ToString();

            Random rnd = new Random();
            int rand = rnd.Next(1, 51);

            if (rand == 4)
            {
                click+=2;
            }
            else
            {
                click++;
            }


            ClickCount.Text = click.ToString();

            if (click == 1)
            {
                SoundPlayer player = new SoundPlayer("https://cdn.discordapp.com/attachments/1068922417612861530/1072708140736466994/eating-a-biscuit-97250.wav");
                player.Play();
            }

            else
            {

            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            click = 0;
            ClickCount.Text = "0";
        }
    }
}