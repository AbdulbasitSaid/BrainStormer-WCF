using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;

namespace BrainStormer_Project
{
    public partial class WelcomScreen : MaterialForm
    {
        public string score;
        public string userName;
        public WelcomScreen()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.LightGreen200, TextShade.WHITE);
        }

        private void WelcomScreen_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            var GameScreen = new GameScreen();
            GameScreen.score = Convert.ToInt32(score);
            GameScreen.userName = userName;
            GameScreen.Closed += (s, args) => this.Close();
            GameScreen.Show();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Instruction ins = new Instruction();
            ins.ShowDialog();
        }

        private void btnHighScore_Click(object sender, EventArgs e)
        {
            Scores sc = new Scores();
            sc.ShowDialog();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
