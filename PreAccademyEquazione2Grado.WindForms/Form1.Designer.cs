namespace PreAccademyEquazione2Grado.WindForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1a = new System.Windows.Forms.TextBox();
            this.textBox1b = new System.Windows.Forms.TextBox();
            this.textBox1c = new System.Windows.Forms.TextBox();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxRisultato = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(220, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Risoluzione Equazioni 2 Grado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(26, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inserisci i 3 Coefficenti";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "a=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "b=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(26, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "c=";
            // 
            // textBox1a
            // 
            this.textBox1a.Location = new System.Drawing.Point(110, 283);
            this.textBox1a.Name = "textBox1a";
            this.textBox1a.Size = new System.Drawing.Size(150, 31);
            this.textBox1a.TabIndex = 5;
            this.textBox1a.TextChanged += new System.EventHandler(this.textBox1a_TextChanged);
            // 
            // textBox1b
            // 
            this.textBox1b.Location = new System.Drawing.Point(110, 367);
            this.textBox1b.Name = "textBox1b";
            this.textBox1b.Size = new System.Drawing.Size(150, 31);
            this.textBox1b.TabIndex = 6;
            this.textBox1b.TextChanged += new System.EventHandler(this.textBox1b_TextChanged);
            // 
            // textBox1c
            // 
            this.textBox1c.Location = new System.Drawing.Point(110, 464);
            this.textBox1c.Name = "textBox1c";
            this.textBox1c.Size = new System.Drawing.Size(150, 31);
            this.textBox1c.TabIndex = 7;
            this.textBox1c.TextChanged += new System.EventHandler(this.textBox1c_TextChanged);
            // 
            // btnCalcola
            // 
            this.btnCalcola.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcola.Location = new System.Drawing.Point(255, 506);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(128, 38);
            this.btnCalcola.TabIndex = 8;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(348, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 289);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(156, 508);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 36);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(143, 592);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Risultato";
            // 
            // textBoxRisultato
            // 
            this.textBoxRisultato.Location = new System.Drawing.Point(255, 583);
            this.textBoxRisultato.Name = "textBoxRisultato";
            this.textBoxRisultato.Size = new System.Drawing.Size(150, 31);
            this.textBoxRisultato.TabIndex = 12;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(970, 687);
            this.Controls.Add(this.textBoxRisultato);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.textBox1c);
            this.Controls.Add(this.textBox1b);
            this.Controls.Add(this.textBox1a);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1a;
        private TextBox textBox1b;
        private TextBox textBox1c;
        private Button btnCalcola;
        private PictureBox pictureBox1;
        private Button btnReset;
        private Label label6;
        private TextBox textBoxRisultato;
    }
}