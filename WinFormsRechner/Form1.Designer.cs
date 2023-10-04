namespace WinFormsRechner
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
            btnBerechnen = new Button();
            btnBeenden = new Button();
            cboZahl1 = new ComboBox();
            cboRechenart = new ComboBox();
            cboZahl2 = new ComboBox();
            txtErgebnis = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnBerechnen
            // 
            btnBerechnen.BackColor = SystemColors.ControlDarkDark;
            btnBerechnen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBerechnen.ForeColor = Color.Cyan;
            btnBerechnen.Location = new Point(320, 247);
            btnBerechnen.Name = "btnBerechnen";
            btnBerechnen.Size = new Size(145, 30);
            btnBerechnen.TabIndex = 0;
            btnBerechnen.Text = "Berechnen";
            btnBerechnen.UseVisualStyleBackColor = false;
            btnBerechnen.Click += btnBerechnen_Click;
            // 
            // btnBeenden
            // 
            btnBeenden.BackColor = SystemColors.ControlDarkDark;
            btnBeenden.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBeenden.ForeColor = Color.Cyan;
            btnBeenden.Location = new Point(320, 301);
            btnBeenden.Name = "btnBeenden";
            btnBeenden.Size = new Size(145, 31);
            btnBeenden.TabIndex = 1;
            btnBeenden.Text = "Beenden";
            btnBeenden.UseVisualStyleBackColor = false;
            btnBeenden.Click += btnBeenden_Click;
            // 
            // cboZahl1
            // 
            cboZahl1.FormattingEnabled = true;
            cboZahl1.Location = new Point(73, 113);
            cboZahl1.Name = "cboZahl1";
            cboZahl1.Size = new Size(121, 23);
            cboZahl1.TabIndex = 2;
            cboZahl1.Text = "0";
            cboZahl1.SelectedIndexChanged += cboZahl1_SelectedIndexChanged;
            // 
            // cboRechenart
            // 
            cboRechenart.FormattingEnabled = true;
            cboRechenart.Items.AddRange(new object[] { "+", "-", "*", "/", "%" });
            cboRechenart.Location = new Point(73, 174);
            cboRechenart.Name = "cboRechenart";
            cboRechenart.Size = new Size(121, 23);
            cboRechenart.TabIndex = 3;
            cboRechenart.Text = "+";
            cboRechenart.SelectedIndexChanged += cboRechenart_SelectedIndexChanged;
            // 
            // cboZahl2
            // 
            cboZahl2.FormattingEnabled = true;
            cboZahl2.Location = new Point(73, 233);
            cboZahl2.Name = "cboZahl2";
            cboZahl2.Size = new Size(121, 23);
            cboZahl2.TabIndex = 4;
            cboZahl2.Text = "0";
            cboZahl2.SelectedIndexChanged += cboZahl2_SelectedIndexChanged;
            // 
            // txtErgebnis
            // 
            txtErgebnis.Location = new Point(73, 306);
            txtErgebnis.Name = "txtErgebnis";
            txtErgebnis.Size = new Size(121, 23);
            txtErgebnis.TabIndex = 5;
            txtErgebnis.Text = "0";
            txtErgebnis.TextChanged += textBox1_TextChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 95);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 6;
            label1.Text = "Zahl 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 156);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 7;
            label2.Text = "Rechenart";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 215);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 8;
            label3.Text = "Zahl 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 288);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 9;
            label4.Text = "Ergebnis";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtErgebnis);
            Controls.Add(cboZahl2);
            Controls.Add(cboRechenart);
            Controls.Add(cboZahl1);
            Controls.Add(btnBeenden);
            Controls.Add(btnBerechnen);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinFormsRechner";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBerechnen;
        private Button btnBeenden;
        private ComboBox cboZahl1;
        private ComboBox cboRechenart;
        private ComboBox cboZahl2;
        private TextBox txtErgebnis;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}