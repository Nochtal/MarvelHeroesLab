namespace MarvelHeroesLab
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btnOpenHeroes = new System.Windows.Forms.Button();
            this.btnOpenShieldAgents = new System.Windows.Forms.Button();
            this.btnOpenVillains = new System.Windows.Forms.Button();
            this.pboMarvelLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboMarvelLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenHeroes
            // 
            this.btnOpenHeroes.BackColor = System.Drawing.Color.Red;
            this.btnOpenHeroes.ForeColor = System.Drawing.Color.White;
            this.btnOpenHeroes.Location = new System.Drawing.Point(12, 148);
            this.btnOpenHeroes.Name = "btnOpenHeroes";
            this.btnOpenHeroes.Size = new System.Drawing.Size(101, 81);
            this.btnOpenHeroes.TabIndex = 0;
            this.btnOpenHeroes.Text = "Super Heroes";
            this.btnOpenHeroes.UseVisualStyleBackColor = false;
            this.btnOpenHeroes.Click += new System.EventHandler(this.btnOpenHeroes_Click);
            // 
            // btnOpenShieldAgents
            // 
            this.btnOpenShieldAgents.BackColor = System.Drawing.Color.Red;
            this.btnOpenShieldAgents.ForeColor = System.Drawing.Color.White;
            this.btnOpenShieldAgents.Location = new System.Drawing.Point(119, 148);
            this.btnOpenShieldAgents.Name = "btnOpenShieldAgents";
            this.btnOpenShieldAgents.Size = new System.Drawing.Size(101, 81);
            this.btnOpenShieldAgents.TabIndex = 1;
            this.btnOpenShieldAgents.Text = "SHIELD Agents";
            this.btnOpenShieldAgents.UseVisualStyleBackColor = false;
            this.btnOpenShieldAgents.Click += new System.EventHandler(this.btnOpenShieldAgents_Click);
            // 
            // btnOpenVillains
            // 
            this.btnOpenVillains.BackColor = System.Drawing.Color.Red;
            this.btnOpenVillains.ForeColor = System.Drawing.Color.White;
            this.btnOpenVillains.Location = new System.Drawing.Point(226, 148);
            this.btnOpenVillains.Name = "btnOpenVillains";
            this.btnOpenVillains.Size = new System.Drawing.Size(98, 81);
            this.btnOpenVillains.TabIndex = 2;
            this.btnOpenVillains.Text = "Villains";
            this.btnOpenVillains.UseVisualStyleBackColor = false;
            this.btnOpenVillains.Click += new System.EventHandler(this.btnOpenVillains_Click);
            // 
            // pboMarvelLogo
            // 
            this.pboMarvelLogo.Image = ((System.Drawing.Image)(resources.GetObject("pboMarvelLogo.Image")));
            this.pboMarvelLogo.Location = new System.Drawing.Point(12, 12);
            this.pboMarvelLogo.Name = "pboMarvelLogo";
            this.pboMarvelLogo.Size = new System.Drawing.Size(312, 130);
            this.pboMarvelLogo.TabIndex = 3;
            this.pboMarvelLogo.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(337, 240);
            this.Controls.Add(this.pboMarvelLogo);
            this.Controls.Add(this.btnOpenVillains);
            this.Controls.Add(this.btnOpenShieldAgents);
            this.Controls.Add(this.btnOpenHeroes);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Home";
            this.Text = "Marvel Heroes Lab";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboMarvelLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenHeroes;
        private System.Windows.Forms.Button btnOpenShieldAgents;
        private System.Windows.Forms.Button btnOpenVillains;
        private System.Windows.Forms.PictureBox pboMarvelLogo;
    }
}

