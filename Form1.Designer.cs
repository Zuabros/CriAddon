namespace CriAddon
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
	 tabControl1 = new TabControl();
	 tabPage1 = new TabPage();
	 button8 = new Button();
	 tb_log = new TextBox();
	 bt_save_default = new Button();
	 button7 = new Button();
	 button6 = new Button();
	 button5 = new Button();
	 tb_result = new TextBox();
	 button3 = new Button();
	 button2 = new Button();
	 button1 = new Button();
	 checkBox9 = new CheckBox();
	 checkBox8 = new CheckBox();
	 checkBox4 = new CheckBox();
	 checkBox7 = new CheckBox();
	 label3 = new Label();
	 textBox3 = new TextBox();
	 checkBox6 = new CheckBox();
	 label2 = new Label();
	 textBox2 = new TextBox();
	 checkBox3 = new CheckBox();
	 checkBox2 = new CheckBox();
	 checkBox1 = new CheckBox();
	 label1 = new Label();
	 textBox1 = new TextBox();
	 Prompt = new TabPage();
	 textBox7 = new TextBox();
	 tabPage2 = new TabPage();
	 textBox4 = new TextBox();
	 Exemplos = new TabPage();
	 textBox5 = new TextBox();
	 tabPage3 = new TabPage();
	 textBox6 = new TextBox();
	 tabPage4 = new TabPage();
	 tabPage5 = new TabPage();
	 textBox8 = new TextBox();
	 textBox9 = new TextBox();
	 tabPage6 = new TabPage();
	 textBox10 = new TextBox();
	 tabControl1.SuspendLayout();
	 tabPage1.SuspendLayout();
	 Prompt.SuspendLayout();
	 tabPage2.SuspendLayout();
	 Exemplos.SuspendLayout();
	 tabPage3.SuspendLayout();
	 tabPage4.SuspendLayout();
	 tabPage5.SuspendLayout();
	 tabPage6.SuspendLayout();
	 SuspendLayout();
	 // 
	 // tabControl1
	 // 
	 tabControl1.Controls.Add(tabPage1);
	 tabControl1.Controls.Add(Prompt);
	 tabControl1.Controls.Add(tabPage2);
	 tabControl1.Controls.Add(Exemplos);
	 tabControl1.Controls.Add(tabPage3);
	 tabControl1.Controls.Add(tabPage4);
	 tabControl1.Controls.Add(tabPage5);
	 tabControl1.Controls.Add(tabPage6);
	 tabControl1.Location = new Point(4, 1);
	 tabControl1.Name = "tabControl1";
	 tabControl1.SelectedIndex = 0;
	 tabControl1.Size = new Size(869, 559);
	 tabControl1.TabIndex = 0;
	 // 
	 // tabPage1
	 // 
	 tabPage1.BackColor = Color.DarkGray;
	 tabPage1.Controls.Add(button8);
	 tabPage1.Controls.Add(tb_log);
	 tabPage1.Controls.Add(bt_save_default);
	 tabPage1.Controls.Add(button7);
	 tabPage1.Controls.Add(button6);
	 tabPage1.Controls.Add(button5);
	 tabPage1.Controls.Add(tb_result);
	 tabPage1.Controls.Add(button3);
	 tabPage1.Controls.Add(button2);
	 tabPage1.Controls.Add(button1);
	 tabPage1.Controls.Add(checkBox9);
	 tabPage1.Controls.Add(checkBox8);
	 tabPage1.Controls.Add(checkBox4);
	 tabPage1.Controls.Add(checkBox7);
	 tabPage1.Controls.Add(label3);
	 tabPage1.Controls.Add(textBox3);
	 tabPage1.Controls.Add(checkBox6);
	 tabPage1.Controls.Add(label2);
	 tabPage1.Controls.Add(textBox2);
	 tabPage1.Controls.Add(checkBox3);
	 tabPage1.Controls.Add(checkBox2);
	 tabPage1.Controls.Add(checkBox1);
	 tabPage1.Controls.Add(label1);
	 tabPage1.Controls.Add(textBox1);
	 tabPage1.ForeColor = SystemColors.ActiveCaptionText;
	 tabPage1.Location = new Point(4, 24);
	 tabPage1.Name = "tabPage1";
	 tabPage1.Padding = new Padding(3);
	 tabPage1.Size = new Size(861, 531);
	 tabPage1.TabIndex = 0;
	 tabPage1.Text = "Classe";
	 // 
	 // button8
	 // 
	 button8.Location = new Point(168, 481);
	 button8.Name = "button8";
	 button8.Size = new Size(84, 23);
	 button8.TabIndex = 26;
	 button8.Text = "Save Config";
	 button8.UseVisualStyleBackColor = true;
	 button8.Click += button8_Click;
	 // 
	 // tb_log
	 // 
	 tb_log.Location = new Point(456, 484);
	 tb_log.Multiline = true;
	 tb_log.Name = "tb_log";
	 tb_log.Size = new Size(389, 40);
	 tb_log.TabIndex = 25;
	 // 
	 // bt_save_default
	 // 
	 bt_save_default.Location = new Point(165, 452);
	 bt_save_default.Name = "bt_save_default";
	 bt_save_default.Size = new Size(87, 23);
	 bt_save_default.TabIndex = 24;
	 bt_save_default.Text = "Save Default";
	 bt_save_default.UseVisualStyleBackColor = true;
	 bt_save_default.Click += bt_save_default_Click;
	 // 
	 // button7
	 // 
	 button7.Location = new Point(6, 481);
	 button7.Name = "button7";
	 button7.Size = new Size(75, 23);
	 button7.TabIndex = 23;
	 button7.Text = "Load";
	 button7.UseVisualStyleBackColor = true;
	 // 
	 // button6
	 // 
	 button6.Location = new Point(84, 452);
	 button6.Name = "button6";
	 button6.Size = new Size(75, 23);
	 button6.TabIndex = 22;
	 button6.Text = "Save As";
	 button6.UseVisualStyleBackColor = true;
	 // 
	 // button5
	 // 
	 button5.Location = new Point(6, 452);
	 button5.Name = "button5";
	 button5.Size = new Size(75, 23);
	 button5.TabIndex = 21;
	 button5.Text = "Save";
	 button5.UseVisualStyleBackColor = true;
	 // 
	 // tb_result
	 // 
	 tb_result.Location = new Point(456, 12);
	 tb_result.Multiline = true;
	 tb_result.Name = "tb_result";
	 tb_result.Size = new Size(389, 463);
	 tb_result.TabIndex = 20;
	 tb_result.Text = resources.GetString("tb_result.Text");
	 // 
	 // button3
	 // 
	 button3.Location = new Point(6, 260);
	 button3.Name = "button3";
	 button3.Size = new Size(75, 23);
	 button3.TabIndex = 18;
	 button3.Text = "Add";
	 button3.UseVisualStyleBackColor = true;
	 // 
	 // button2
	 // 
	 button2.Location = new Point(6, 154);
	 button2.Name = "button2";
	 button2.Size = new Size(75, 23);
	 button2.TabIndex = 17;
	 button2.Text = "Add";
	 button2.UseVisualStyleBackColor = true;
	 // 
	 // button1
	 // 
	 button1.Location = new Point(10, 30);
	 button1.Name = "button1";
	 button1.Size = new Size(75, 23);
	 button1.TabIndex = 16;
	 button1.Text = "Add";
	 button1.UseVisualStyleBackColor = true;
	 // 
	 // checkBox9
	 // 
	 checkBox9.AutoSize = true;
	 checkBox9.Enabled = false;
	 checkBox9.Location = new Point(160, 331);
	 checkBox9.Name = "checkBox9";
	 checkBox9.Size = new Size(58, 19);
	 checkBox9.TabIndex = 14;
	 checkBox9.Text = "Player";
	 checkBox9.UseVisualStyleBackColor = true;
	 // 
	 // checkBox8
	 // 
	 checkBox8.AutoSize = true;
	 checkBox8.Checked = true;
	 checkBox8.CheckState = CheckState.Checked;
	 checkBox8.Enabled = false;
	 checkBox8.Location = new Point(96, 331);
	 checkBox8.Name = "checkBox8";
	 checkBox8.Size = new Size(58, 19);
	 checkBox8.TabIndex = 13;
	 checkBox8.Text = "Target";
	 checkBox8.UseVisualStyleBackColor = true;
	 // 
	 // checkBox4
	 // 
	 checkBox4.AutoSize = true;
	 checkBox4.Location = new Point(96, 308);
	 checkBox4.Name = "checkBox4";
	 checkBox4.Size = new Size(59, 19);
	 checkBox4.TabIndex = 12;
	 checkBox4.Text = "Stacks";
	 checkBox4.UseVisualStyleBackColor = true;
	 // 
	 // checkBox7
	 // 
	 checkBox7.AutoSize = true;
	 checkBox7.Checked = true;
	 checkBox7.CheckState = CheckState.Checked;
	 checkBox7.Enabled = false;
	 checkBox7.Location = new Point(97, 291);
	 checkBox7.Name = "checkBox7";
	 checkBox7.Size = new Size(46, 19);
	 checkBox7.TabIndex = 11;
	 checkBox7.Text = "Has";
	 checkBox7.UseVisualStyleBackColor = true;
	 // 
	 // label3
	 // 
	 label3.AutoSize = true;
	 label3.Location = new Point(97, 240);
	 label3.Name = "label3";
	 label3.Size = new Size(43, 15);
	 label3.TabIndex = 10;
	 label3.Text = "Debuff";
	 // 
	 // textBox3
	 // 
	 textBox3.Location = new Point(97, 260);
	 textBox3.Name = "textBox3";
	 textBox3.Size = new Size(247, 23);
	 textBox3.TabIndex = 9;
	 // 
	 // checkBox6
	 // 
	 checkBox6.AutoSize = true;
	 checkBox6.Checked = true;
	 checkBox6.CheckState = CheckState.Checked;
	 checkBox6.Enabled = false;
	 checkBox6.Location = new Point(97, 186);
	 checkBox6.Name = "checkBox6";
	 checkBox6.Size = new Size(46, 19);
	 checkBox6.TabIndex = 7;
	 checkBox6.Text = "Has";
	 checkBox6.UseVisualStyleBackColor = true;
	 // 
	 // label2
	 // 
	 label2.AutoSize = true;
	 label2.Location = new Point(97, 135);
	 label2.Name = "label2";
	 label2.Size = new Size(29, 15);
	 label2.TabIndex = 6;
	 label2.Text = "Buff";
	 // 
	 // textBox2
	 // 
	 textBox2.Location = new Point(97, 155);
	 textBox2.Name = "textBox2";
	 textBox2.Size = new Size(247, 23);
	 textBox2.TabIndex = 5;
	 // 
	 // checkBox3
	 // 
	 checkBox3.AutoSize = true;
	 checkBox3.Location = new Point(96, 96);
	 checkBox3.Name = "checkBox3";
	 checkBox3.Size = new Size(63, 19);
	 checkBox3.TabIndex = 4;
	 checkBox3.Text = "Known";
	 checkBox3.UseVisualStyleBackColor = true;
	 // 
	 // checkBox2
	 // 
	 checkBox2.AutoSize = true;
	 checkBox2.Location = new Point(96, 76);
	 checkBox2.Name = "checkBox2";
	 checkBox2.Size = new Size(58, 19);
	 checkBox2.TabIndex = 3;
	 checkBox2.Text = "Ready";
	 checkBox2.UseVisualStyleBackColor = true;
	 // 
	 // checkBox1
	 // 
	 checkBox1.AutoSize = true;
	 checkBox1.Location = new Point(97, 59);
	 checkBox1.Name = "checkBox1";
	 checkBox1.Size = new Size(59, 19);
	 checkBox1.TabIndex = 2;
	 checkBox1.Text = "Range";
	 checkBox1.UseVisualStyleBackColor = true;
	 // 
	 // label1
	 // 
	 label1.AutoSize = true;
	 label1.Location = new Point(97, 8);
	 label1.Name = "label1";
	 label1.Size = new Size(32, 15);
	 label1.TabIndex = 1;
	 label1.Text = "Spell";
	 // 
	 // textBox1
	 // 
	 textBox1.Location = new Point(97, 28);
	 textBox1.Name = "textBox1";
	 textBox1.Size = new Size(247, 23);
	 textBox1.TabIndex = 0;
	 // 
	 // Prompt
	 // 
	 Prompt.Controls.Add(textBox7);
	 Prompt.Location = new Point(4, 24);
	 Prompt.Name = "Prompt";
	 Prompt.Size = new Size(861, 531);
	 Prompt.TabIndex = 4;
	 Prompt.Text = "Prompt";
	 Prompt.UseVisualStyleBackColor = true;
	 // 
	 // textBox7
	 // 
	 textBox7.Location = new Point(118, 3);
	 textBox7.Multiline = true;
	 textBox7.Name = "textBox7";
	 textBox7.Size = new Size(736, 518);
	 textBox7.TabIndex = 3;
	 textBox7.Text = resources.GetString("textBox7.Text");
	 // 
	 // tabPage2
	 // 
	 tabPage2.BackColor = Color.DarkGray;
	 tabPage2.Controls.Add(textBox4);
	 tabPage2.Location = new Point(4, 24);
	 tabPage2.Name = "tabPage2";
	 tabPage2.Padding = new Padding(3);
	 tabPage2.Size = new Size(861, 531);
	 tabPage2.TabIndex = 1;
	 tabPage2.Text = "Base";
	 // 
	 // textBox4
	 // 
	 textBox4.Location = new Point(129, 6);
	 textBox4.Multiline = true;
	 textBox4.Name = "textBox4";
	 textBox4.Size = new Size(619, 518);
	 textBox4.TabIndex = 0;
	 textBox4.Text = resources.GetString("textBox4.Text");
	 // 
	 // Exemplos
	 // 
	 Exemplos.Controls.Add(textBox5);
	 Exemplos.Location = new Point(4, 24);
	 Exemplos.Name = "Exemplos";
	 Exemplos.Size = new Size(861, 531);
	 Exemplos.TabIndex = 2;
	 Exemplos.Text = "Exemplos";
	 Exemplos.UseVisualStyleBackColor = true;
	 // 
	 // textBox5
	 // 
	 textBox5.Location = new Point(121, 6);
	 textBox5.Multiline = true;
	 textBox5.Name = "textBox5";
	 textBox5.Size = new Size(619, 518);
	 textBox5.TabIndex = 1;
	 textBox5.Text = resources.GetString("textBox5.Text");
	 // 
	 // tabPage3
	 // 
	 tabPage3.Controls.Add(textBox6);
	 tabPage3.Location = new Point(4, 24);
	 tabPage3.Name = "tabPage3";
	 tabPage3.Size = new Size(861, 531);
	 tabPage3.TabIndex = 3;
	 tabPage3.Text = "Funções";
	 tabPage3.UseVisualStyleBackColor = true;
	 // 
	 // textBox6
	 // 
	 textBox6.Location = new Point(122, 13);
	 textBox6.Multiline = true;
	 textBox6.Name = "textBox6";
	 textBox6.Size = new Size(736, 518);
	 textBox6.TabIndex = 2;
	 textBox6.Text = resources.GetString("textBox6.Text");
	 // 
	 // tabPage4
	 // 
	 tabPage4.Controls.Add(textBox9);
	 tabPage4.Location = new Point(4, 24);
	 tabPage4.Name = "tabPage4";
	 tabPage4.Size = new Size(861, 531);
	 tabPage4.TabIndex = 5;
	 tabPage4.Text = "Element";
	 tabPage4.UseVisualStyleBackColor = true;
	 // 
	 // tabPage5
	 // 
	 tabPage5.Controls.Add(textBox8);
	 tabPage5.Location = new Point(4, 24);
	 tabPage5.Name = "tabPage5";
	 tabPage5.Size = new Size(861, 531);
	 tabPage5.TabIndex = 6;
	 tabPage5.Text = "Class Table";
	 tabPage5.UseVisualStyleBackColor = true;
	 // 
	 // textBox8
	 // 
	 textBox8.Location = new Point(118, 6);
	 textBox8.Multiline = true;
	 textBox8.Name = "textBox8";
	 textBox8.Size = new Size(736, 518);
	 textBox8.TabIndex = 3;
	 textBox8.Text = resources.GetString("textBox8.Text");
	 // 
	 // textBox9
	 // 
	 textBox9.Location = new Point(62, 6);
	 textBox9.Multiline = true;
	 textBox9.Name = "textBox9";
	 textBox9.Size = new Size(736, 518);
	 textBox9.TabIndex = 4;
	 textBox9.Text = resources.GetString("textBox9.Text");
	 // 
	 // tabPage6
	 // 
	 tabPage6.Controls.Add(textBox10);
	 tabPage6.Location = new Point(4, 24);
	 tabPage6.Name = "tabPage6";
	 tabPage6.Size = new Size(861, 531);
	 tabPage6.TabIndex = 7;
	 tabPage6.Text = "C# Reader";
	 tabPage6.UseVisualStyleBackColor = true;
	 // 
	 // textBox10
	 // 
	 textBox10.Location = new Point(63, 7);
	 textBox10.Multiline = true;
	 textBox10.Name = "textBox10";
	 textBox10.Size = new Size(736, 518);
	 textBox10.TabIndex = 4;
	 textBox10.Text = resources.GetString("textBox10.Text");
	 // 
	 // Form1
	 // 
	 AutoScaleDimensions = new SizeF(7F, 15F);
	 AutoScaleMode = AutoScaleMode.Font;
	 ClientSize = new Size(874, 561);
	 Controls.Add(tabControl1);
	 Name = "Form1";
	 Text = "Form1";
	 tabControl1.ResumeLayout(false);
	 tabPage1.ResumeLayout(false);
	 tabPage1.PerformLayout();
	 Prompt.ResumeLayout(false);
	 Prompt.PerformLayout();
	 tabPage2.ResumeLayout(false);
	 tabPage2.PerformLayout();
	 Exemplos.ResumeLayout(false);
	 Exemplos.PerformLayout();
	 tabPage3.ResumeLayout(false);
	 tabPage3.PerformLayout();
	 tabPage4.ResumeLayout(false);
	 tabPage4.PerformLayout();
	 tabPage5.ResumeLayout(false);
	 tabPage5.PerformLayout();
	 tabPage6.ResumeLayout(false);
	 tabPage6.PerformLayout();
	 ResumeLayout(false);
	}

	#endregion

	private TabControl tabControl1;
	private TabPage tabPage1;
	private TabPage tabPage2;
	private CheckBox checkBox3;
	private CheckBox checkBox2;
	private CheckBox checkBox1;
	private Label label1;
	private TextBox textBox1;
	private CheckBox checkBox6;
	private Label label2;
	private TextBox textBox2;
	private CheckBox checkBox9;
	private CheckBox checkBox8;
	private CheckBox checkBox4;
	private CheckBox checkBox7;
	private Label label3;
	private TextBox textBox3;
	private Button button3;
	private Button button2;
	private Button button1;
	private TextBox tb_result;
	private Button bt_save_default;
	private Button button7;
	private Button button6;
	private Button button5;
	private TextBox tb_log;
	private Button button8;
	private TextBox textBox4;
	private TabPage Exemplos;
	private TextBox textBox5;
	private TabPage tabPage3;
	private TextBox textBox6;
	private TabPage Prompt;
	private TextBox textBox7;
	private TabPage tabPage4;
	private TabPage tabPage5;
	private TextBox textBox8;
	private TextBox textBox9;
	private TabPage tabPage6;
	private TextBox textBox10;
 }
}
