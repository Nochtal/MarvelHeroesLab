namespace MarvelHeroesLab
{
    partial class SuperHeroes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listHeroes = new System.Windows.Forms.ListBox();
            this.heroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.powersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.listHeroes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 370);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Heroes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(6, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 153);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Powers";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.powersBindingSource;
            this.listBox1.DisplayMember = "Name";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(445, 134);
            this.listBox1.TabIndex = 2;
            this.listBox1.ValueMember = "Id";
            // 
            // listHeroes
            // 
            this.listHeroes.DataSource = this.heroBindingSource;
            this.listHeroes.DisplayMember = "Name";
            this.listHeroes.FormattingEnabled = true;
            this.listHeroes.Location = new System.Drawing.Point(6, 19);
            this.listHeroes.Name = "listHeroes";
            this.listHeroes.Size = new System.Drawing.Size(457, 186);
            this.listHeroes.TabIndex = 0;
            this.listHeroes.ValueMember = "Id";
            // 
            // heroBindingSource
            // 
            this.heroBindingSource.DataSource = typeof(MarvelHeroesLabLibrary.Hero);
            // 
            // powersBindingSource
            // 
            this.powersBindingSource.DataMember = "Powers";
            this.powersBindingSource.DataSource = this.heroBindingSource;
            // 
            // SuperHeroes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 391);
            this.Controls.Add(this.groupBox1);
            this.Name = "SuperHeroes";
            this.Text = "frmSuperHeroes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.heroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listHeroes;
        private System.Windows.Forms.BindingSource heroBindingSource;
        private System.Windows.Forms.BindingSource powersBindingSource;
    }
}