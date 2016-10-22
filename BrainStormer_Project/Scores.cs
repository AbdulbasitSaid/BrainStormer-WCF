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
using System.Collections.Specialized;
namespace BrainStormer_Project
{
    public partial class Scores : MaterialForm
    {
        public Scores()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.LightGreen200, TextShade.WHITE);
        }
        SortedDictionary<float, string> highscores = new SortedDictionary<float, string>();
     
        private void Scores_Load(object sender, EventArgs e)
        {
            

            using (BrainStormerEntitiesS br = new BrainStormerEntitiesS())
            {
               foreach(var i in br.Scores)
                {
                  highscores.Add((float)i.Scores,i.UserID);
                }
            }
                  
            try
            {
                var p1 = highscores.ElementAt(0);
                lblScore.Text = p1.Key.ToString();
                lblUserName.Text = p1.Value;
            }
            catch (Exception)
            {
                lblScore.Text = "NULL";
                lblUserName.Text = "NULL";
            }
            try
            {
                var p2 = highscores.ElementAt(1);
                lblScore1.Text = p2.Key.ToString();
                lblUserName1.Text = p2.Value;
            }
            catch (Exception)
            {
                lblScore1.Text = "NULL";
                lblUserName1.Text = "NULL";
            }
            try
            {
                var p3 = highscores.ElementAt(3);
                lblScore2.Text = p3.Key.ToString();
                lblUserName2.Text = p3.Value;
            }
            catch (Exception)
            {

                lblScore2.Text = "NULL";
                lblUserName2.Text = "NULL";
            }

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
