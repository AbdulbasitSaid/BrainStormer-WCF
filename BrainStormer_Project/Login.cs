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
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using BrainStormer_Project.BrainStormRef;

namespace BrainStormer_Project
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.LightGreen200, TextShade.WHITE);
        }
         Dictionary<string,string> logdb;
        WCFBrainStormerClient proxy;
        private void UserDetails_Load(object sender, EventArgs e)
        {
            proxy = new WCFBrainStormerClient();
            logdb = proxy.loginDb();
            this.MaximizeBox = false;
        }
        WCFBrainStormerClient client = new WCFBrainStormerClient();
        string id1;
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string userName = txtEmail.Text;

            string passWord = txtPassWord.Text;
            try
            {
                var un = logdb.First(r => r.Key == userName);
                if (un.Key == userName && un.Value == passWord)
                {
                    using (BrainStormerEntities2 br = new BrainStormerEntities2() )
                    {
                        var temp = br.playerLogins.First(p=>p.Email==userName);
                        id1 = temp.Id;
                    }
                  
                        MessageBox.Show("Login Successfull");
                    Hide();
                    var wc = new GameScreen();
                    try
                    {
                        using (BrainStormerEntitiesS br = new BrainStormerEntitiesS())
                        {
                            var temp = br.Scores.First(s => s.UserID == userName);
                            wc.score = (float)temp.Scores;
                        }
                    }
                    catch (Exception)
                    {

                        wc.score = 10;
                    }
                    wc.userName = userName;
                    wc.Id = id1;
                    wc.Closed += (s, args) => this.Close();
                    wc.userName = userName;
                    wc.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Email Or Password");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Email Or Password");
            }

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            materialRaisedButton1.Text = "";
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            materialRaisedButton1.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}
