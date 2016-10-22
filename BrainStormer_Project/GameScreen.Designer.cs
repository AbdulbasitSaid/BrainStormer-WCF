namespace BrainStormer_Project
{
    partial class GameScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.sec = new MaterialSkin.Controls.MaterialLabel();
            this.points = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtQuestions = new MaterialSkin.Controls.MaterialLabel();
            this.btnPausePlay = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnD = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.tickTime = new System.Windows.Forms.Timer(this.components);
            this.min = new MaterialSkin.Controls.MaterialLabel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 35);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(43, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Time";
            // 
            // sec
            // 
            this.sec.AutoSize = true;
            this.sec.BackColor = System.Drawing.Color.Transparent;
            this.sec.Depth = 0;
            this.sec.Font = new System.Drawing.Font("Roboto", 11F);
            this.sec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sec.Location = new System.Drawing.Point(84, 35);
            this.sec.MouseState = MaterialSkin.MouseState.HOVER;
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(0, 19);
            this.sec.TabIndex = 1;
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.BackColor = System.Drawing.Color.Transparent;
            this.points.Depth = 0;
            this.points.Font = new System.Drawing.Font("Roboto", 11F);
            this.points.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.points.Location = new System.Drawing.Point(466, 35);
            this.points.MouseState = MaterialSkin.MouseState.HOVER;
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(0, 19);
            this.points.TabIndex = 3;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(368, 35);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(48, 19);
            this.materialLabel4.TabIndex = 2;
            this.materialLabel4.Text = "Score";
            // 
            // txtQuestions
            // 
            this.txtQuestions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuestions.Depth = 0;
            this.txtQuestions.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtQuestions.Location = new System.Drawing.Point(12, 100);
            this.txtQuestions.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtQuestions.Name = "txtQuestions";
            this.txtQuestions.Size = new System.Drawing.Size(476, 138);
            this.txtQuestions.TabIndex = 4;
            this.txtQuestions.Text = "materialLabel5";
            this.txtQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPausePlay
            // 
            this.btnPausePlay.AutoSize = true;
            this.btnPausePlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPausePlay.Depth = 0;
            this.btnPausePlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnPausePlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPausePlay.Location = new System.Drawing.Point(42, 364);
            this.btnPausePlay.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPausePlay.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPausePlay.Name = "btnPausePlay";
            this.btnPausePlay.Primary = false;
            this.btnPausePlay.Size = new System.Drawing.Size(55, 36);
            this.btnPausePlay.TabIndex = 10;
            this.btnPausePlay.Text = "Pause";
            this.btnPausePlay.UseVisualStyleBackColor = true;
            this.btnPausePlay.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(405, 364);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(54, 36);
            this.materialFlatButton2.TabIndex = 11;
            this.materialFlatButton2.Text = "Close";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(215, 26);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(33, 34);
            this.materialLabel6.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnD);
            this.panel1.Controls.Add(this.btnC);
            this.panel1.Controls.Add(this.btnB);
            this.panel1.Controls.Add(this.btnA);
            this.panel1.Location = new System.Drawing.Point(42, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 100);
            this.panel1.TabIndex = 9;
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnD.Location = new System.Drawing.Point(210, 58);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(202, 37);
            this.btnD.TabIndex = 3;
            this.btnD.Text = "button4";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnC.Location = new System.Drawing.Point(210, 3);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(202, 37);
            this.btnC.TabIndex = 2;
            this.btnC.Text = "button3";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnB.Location = new System.Drawing.Point(3, 58);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(201, 37);
            this.btnB.TabIndex = 1;
            this.btnB.Text = "button2";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnA.Location = new System.Drawing.Point(3, 3);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(201, 37);
            this.btnA.TabIndex = 0;
            this.btnA.Text = "button1";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // tickTime
            // 
            this.tickTime.Interval = 1000;
            this.tickTime.Tick += new System.EventHandler(this.tickTime_Tick);
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.BackColor = System.Drawing.Color.Transparent;
            this.min.Depth = 0;
            this.min.Font = new System.Drawing.Font("Roboto", 11F);
            this.min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.min.Location = new System.Drawing.Point(53, 35);
            this.min.MouseState = MaterialSkin.MouseState.HOVER;
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(0, 19);
            this.min.TabIndex = 13;
            // 
            // lblUserName
            // 
            this.lblUserName.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(12, 77);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(52, 13);
            this.lblUserName.TabIndex = 14;
            this.lblUserName.Text = "Welcome";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 402);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.min);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.btnPausePlay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtQuestions);
            this.Controls.Add(this.points);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.sec);
            this.Controls.Add(this.materialLabel1);
            this.Name = "GameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel sec;
        private MaterialSkin.Controls.MaterialLabel points;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel txtQuestions;
        private MaterialSkin.Controls.MaterialFlatButton btnPausePlay;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Timer tickTime;
        private MaterialSkin.Controls.MaterialLabel min;
        private System.Windows.Forms.Label lblUserName;
    }
}