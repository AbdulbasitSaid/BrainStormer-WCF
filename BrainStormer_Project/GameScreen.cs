using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using BrainStormer_Project.BrainStormRef;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace BrainStormer_Project
{
    public partial class GameScreen : MaterialForm
    {
        List<string> questions = new List<string>();
        string[] options = new string[4];
        Random rand = new Random();
        public string userName;
       
       BrainStormRef.WCFBrainStormerClient proxy = new BrainStormRef.WCFBrainStormerClient();
        public GameScreen()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.LightGreen200, TextShade.WHITE);
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            lblUserName.Text = userName;
            min.Text = "4";
            sec.Text = "60";
            points.Text = score.ToString();
            this.MaximizeBox = false;
           //roxy.ListQuestions();
           List<string> q = proxy.ListQuestions();   
            foreach(var x in q)
            {
              questions.Add(x);
            }
            timeStarter();
            change_Questions();
        }
        public class ScorecDb : DbContext
        {
            public DbSet<Score> scdbs { get; set; }
        }
        public string Id;
      
        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            ScorecDb db = new ScorecDb();
            using (BrainStormerEntitiesS brdb = new BrainStormerEntitiesS())
            {
                var sc = new Score {UserID = userName,Scores = score,TimePlayed = DateTime.Now};
                try
                {
                    brdb.Entry(sc).State = EntityState.Added;
                    brdb.SaveChanges();
                }
                catch (Exception)
                {
                    brdb.Entry(sc).State = EntityState.Modified;
                    brdb.SaveChanges();
                }
            }
            Hide();
            var wc = new WelcomScreen();
            wc.userName = userName;
            wc.score = score.ToString();
            wc.Closed += (s, args) => this.Close();
            wc.Show();
        }
        string q;
        public void change_Questions()
        {
            Button[] btn = { btnA, btnB, btnC, btnD };
            foreach (var i in btn)
            {
                i.BackColor = Color.LemonChiffon;
            }
            //string[] aq = new string[4];
            int count = questions.Count;
            int index = rand.Next(questions.Count);
           // ClassQuestions d = d.Answer;
          // if()
            //wrightWrong();
            if (count > 0)
            {//settinu up random values of Questions
                
                int getIndex = index;
                q = questions.ElementAt(getIndex);
                //setting up random values of Options            
                //filling up Options
                //
                ClassQuestions cQ = proxy.getQuestion(q);
                List<string> opt = proxy.getOptions(q);
                string quetions = cQ.Question;
            
                txtQuestions.Text = quetions;
                btnA.Text = opt.ElementAt(0);
                btnB.Text = opt.ElementAt(1);
                btnC.Text = opt.ElementAt(2);
                btnD.Text = opt.ElementAt(3);
                questions.RemoveAt(getIndex);
            }
            else {
                MessageBox.Show("Game Completed","Congrats",MessageBoxButtons.OK);
                this.Hide();
                var score = new Scores();
                score.Closed += (s, args) => this.Close();
                score.Show();
            }
            
        }
         public  float score;
        public void wrightWrong(string btnV)
        {
            List<string> btntxt = new List<string>();
            btntxt.Add(btnA.Text);
            btntxt.Add(btnB.Text);
            btntxt.Add(btnC.Text);
            btntxt.Add(btnD.Text);
            Button[] btn = { btnA, btnB, btnC, btnD };
            
            if (btnV == proxy.getQuestion(q).Answer)
            {
                
                foreach(var n in btntxt)
                {
                    if (n==btnV)
                    {
                       int index = btntxt.IndexOf(n);
                        btn[index].BackColor = Color.Green;
                        score+=10;
                        points.Text = score.ToString();
                        MessageBox.Show("Good");
                    }
                }
                change_Questions();
            }
            else
            {
                int index = btntxt.IndexOf(btnV);
                btn[index].BackColor = Color.Red;
                if (score!=0) { score -= 2; }
                points.Text = score.ToString();
                MessageBox.Show("Wrong the Wright Answer is : "+proxy.getQuestion(q).Answer+"");
                if (score == 0)
                {
                    MessageBox.Show("Game Over");
                }
                change_Questions();
            }
           
        }
        public void timeStarter()
        {
            tickTime.Start();       
        }
        private void btnA_Click(object sender, EventArgs e)
        {
            wrightWrong(btnA.Text);
           // change_Questions();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            wrightWrong(btnC.Text);
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            wrightWrong(btnB.Text);
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            wrightWrong(btnD.Text);
        }
        int mm = 5,ss=60;
        int count = 0;
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
           // if(btnPausePlay.Text == "PAUSE")
            {
                tickTime.Stop();
                txtQuestions.Visible = false;
                btnA.Visible = false;
                btnB.Visible = false;
                btnC.Visible = false;
                btnD.Visible = false;
                MessageBox.Show("Game Paused","Pause",MessageBoxButtons.OK);
                tickTime.Start();
                txtQuestions.Visible = true;
                btnA.Visible = true;
                btnB.Visible = true;
                btnC.Visible = true;
                btnD.Visible =true;
            }        
        }

        private void tickTime_Tick(object sender, EventArgs e)
        {
            if(ss!=0)
            {
                ss--;
                sec.Text = ss.ToString();
            }
            else if(ss==0)
            {
                mm--;
                ss = 60;
                if(mm == 0)
                {
                    tickTime.Stop();
                    MessageBox.Show("Time Up GameOver");
                    this.Hide();
                    var wc = new WelcomScreen();
                    wc.Closed += (s, args) => this.Close();
                    wc.Show();
                }
                min.Text = mm.ToString();
            }
        }
    }
}
