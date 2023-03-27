namespace convertor
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
            menuStrip1 = new MenuStrip();
            lungimeToolStripMenuItem = new ToolStripMenuItem();
            greutateToolStripMenuItem = new ToolStripMenuItem();
            temperaturaToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            lblUnit1 = new Label();
            lblUnit2 = new Label();
            label3 = new Label();
            lblrez = new Label();
            Combo1 = new ComboBox();
            Combo2 = new ComboBox();
            textBox1 = new TextBox();
            label4 = new Label();
            calcbtn = new Button();
            resetbtn = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { lungimeToolStripMenuItem, greutateToolStripMenuItem, temperaturaToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // lungimeToolStripMenuItem
            // 
            lungimeToolStripMenuItem.Font = new Font("High Tower Text", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lungimeToolStripMenuItem.Name = "lungimeToolStripMenuItem";
            lungimeToolStripMenuItem.Size = new Size(90, 27);
            lungimeToolStripMenuItem.Text = "Lungime";
            lungimeToolStripMenuItem.Click += lungimeToolStripMenuItem_Click;
            // 
            // greutateToolStripMenuItem
            // 
            greutateToolStripMenuItem.Font = new Font("High Tower Text", 12F, FontStyle.Italic, GraphicsUnit.Point);
            greutateToolStripMenuItem.Name = "greutateToolStripMenuItem";
            greutateToolStripMenuItem.Size = new Size(93, 27);
            greutateToolStripMenuItem.Text = "Greutate";
            greutateToolStripMenuItem.Click += greutateToolStripMenuItem_Click;
            // 
            // temperaturaToolStripMenuItem
            // 
            temperaturaToolStripMenuItem.Font = new Font("High Tower Text", 12F, FontStyle.Italic, GraphicsUnit.Point);
            temperaturaToolStripMenuItem.Name = "temperaturaToolStripMenuItem";
            temperaturaToolStripMenuItem.Size = new Size(125, 27);
            temperaturaToolStripMenuItem.Text = "Temperatura";
            temperaturaToolStripMenuItem.Click += temperaturaToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Font = new Font("High Tower Text", 12F, FontStyle.Italic, GraphicsUnit.Point);
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(56, 27);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // lblUnit1
            // 
            lblUnit1.AutoSize = true;
            lblUnit1.Font = new Font("High Tower Text", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblUnit1.Location = new Point(134, 94);
            lblUnit1.Name = "lblUnit1";
            lblUnit1.Size = new Size(0, 23);
            lblUnit1.TabIndex = 1;
            // 
            // lblUnit2
            // 
            lblUnit2.AutoSize = true;
            lblUnit2.Font = new Font("High Tower Text", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblUnit2.Location = new Point(444, 94);
            lblUnit2.Name = "lblUnit2";
            lblUnit2.Size = new Size(0, 23);
            lblUnit2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("High Tower Text", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(96, 318);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 3;
            label3.Text = "Rezultat: ";
            label3.Click += label3_Click;
            // 
            // lblrez
            // 
            lblrez.AutoSize = true;
            lblrez.Font = new Font("HoloLens MDL2 Assets", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblrez.Location = new Point(241, 318);
            lblrez.Name = "lblrez";
            lblrez.Size = new Size(0, 20);
            lblrez.TabIndex = 4;
            // 
            // Combo1
            // 
            Combo1.Font = new Font("High Tower Text", 12F, FontStyle.Italic, GraphicsUnit.Point);
            Combo1.FormattingEnabled = true;
            Combo1.Location = new Point(96, 117);
            Combo1.Name = "Combo1";
            Combo1.Size = new Size(151, 31);
            Combo1.TabIndex = 5;
            // 
            // Combo2
            // 
            Combo2.Font = new Font("High Tower Text", 12F, FontStyle.Italic, GraphicsUnit.Point);
            Combo2.FormattingEnabled = true;
            Combo2.Location = new Point(392, 117);
            Combo2.Name = "Combo2";
            Combo2.Size = new Size(151, 31);
            Combo2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(96, 262);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 27);
            textBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("High Tower Text", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(116, 233);
            label4.Name = "label4";
            label4.Size = new Size(195, 23);
            label4.TabIndex = 8;
            label4.Text = "Sa se introduca valoarea";
            // 
            // calcbtn
            // 
            calcbtn.BackColor = Color.Gainsboro;
            calcbtn.Font = new Font("High Tower Text", 9F, FontStyle.Italic, GraphicsUnit.Point);
            calcbtn.Location = new Point(587, 204);
            calcbtn.Name = "calcbtn";
            calcbtn.Size = new Size(108, 52);
            calcbtn.TabIndex = 9;
            calcbtn.Text = "Convertire";
            calcbtn.UseVisualStyleBackColor = false;
            calcbtn.Click += calcbtn_Click;
            // 
            // resetbtn
            // 
            resetbtn.BackColor = Color.Gainsboro;
            resetbtn.Font = new Font("High Tower Text", 9F, FontStyle.Italic, GraphicsUnit.Point);
            resetbtn.Location = new Point(587, 262);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(108, 61);
            resetbtn.TabIndex = 10;
            resetbtn.Text = "Resetare valori";
            resetbtn.UseVisualStyleBackColor = false;
            resetbtn.Click += resetbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(resetbtn);
            Controls.Add(calcbtn);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(Combo2);
            Controls.Add(Combo1);
            Controls.Add(lblrez);
            Controls.Add(label3);
            Controls.Add(lblUnit2);
            Controls.Add(lblUnit1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Convertor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem lungimeToolStripMenuItem;
        private ToolStripMenuItem greutateToolStripMenuItem;
        private ToolStripMenuItem temperaturaToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label lblUnit1;
        private Label lblUnit2;
        private Label label3;
        private Label lblrez;
        private ComboBox Combo1;
        private ComboBox Combo2;
        private TextBox textBox1;
        private Label label4;
        private Button calcbtn;
        private Button resetbtn;
    }
}