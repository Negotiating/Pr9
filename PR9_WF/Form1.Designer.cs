namespace PR9_WF
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.task1_page = new System.Windows.Forms.TabPage();
			this.execute_button = new System.Windows.Forms.Button();
			this.letter_box = new System.Windows.Forms.ComboBox();
			this.letter_label = new System.Windows.Forms.Label();
			this.words_box = new System.Windows.Forms.RichTextBox();
			this.words_label = new System.Windows.Forms.Label();
			this.text_box = new System.Windows.Forms.RichTextBox();
			this.text_label = new System.Windows.Forms.Label();
			this.task2_page = new System.Windows.Forms.TabPage();
			this.execute2_button = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.task1_page.SuspendLayout();
			this.task2_page.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.task1_page);
			this.tabControl1.Controls.Add(this.task2_page);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(367, 267);
			this.tabControl1.TabIndex = 0;
			// 
			// task1_page
			// 
			this.task1_page.Controls.Add(this.execute_button);
			this.task1_page.Controls.Add(this.letter_box);
			this.task1_page.Controls.Add(this.letter_label);
			this.task1_page.Controls.Add(this.words_box);
			this.task1_page.Controls.Add(this.words_label);
			this.task1_page.Controls.Add(this.text_box);
			this.task1_page.Controls.Add(this.text_label);
			this.task1_page.Location = new System.Drawing.Point(4, 25);
			this.task1_page.Name = "task1_page";
			this.task1_page.Padding = new System.Windows.Forms.Padding(3);
			this.task1_page.Size = new System.Drawing.Size(359, 238);
			this.task1_page.TabIndex = 0;
			this.task1_page.Text = "Задание 1";
			this.task1_page.UseVisualStyleBackColor = true;
			// 
			// execute_button
			// 
			this.execute_button.Location = new System.Drawing.Point(6, 192);
			this.execute_button.Name = "execute_button";
			this.execute_button.Size = new System.Drawing.Size(347, 40);
			this.execute_button.TabIndex = 6;
			this.execute_button.Text = "Выполнить";
			this.execute_button.UseVisualStyleBackColor = true;
			this.execute_button.Click += new System.EventHandler(this.execute_button_Click);
			// 
			// letter_box
			// 
			this.letter_box.FormattingEnabled = true;
			this.letter_box.Items.AddRange(new object[] {
            "а",
            "б",
            "в",
            "г",
            "д",
            "е",
            "ё",
            "ж",
            "з",
            "и",
            "й",
            "к",
            "л",
            "м",
            "н",
            "о",
            "п",
            "р",
            "с",
            "т",
            "у",
            "ф",
            "х",
            "ц",
            "ш",
            "щ",
            "ъ",
            "ы",
            "ь",
            "э",
            "ю",
            "я"});
			this.letter_box.Location = new System.Drawing.Point(64, 16);
			this.letter_box.Name = "letter_box";
			this.letter_box.Size = new System.Drawing.Size(41, 24);
			this.letter_box.TabIndex = 5;
			// 
			// letter_label
			// 
			this.letter_label.AutoSize = true;
			this.letter_label.Location = new System.Drawing.Point(8, 16);
			this.letter_label.Name = "letter_label";
			this.letter_label.Size = new System.Drawing.Size(50, 17);
			this.letter_label.TabIndex = 4;
			this.letter_label.Text = "Буква:";
			// 
			// words_box
			// 
			this.words_box.Location = new System.Drawing.Point(64, 124);
			this.words_box.Name = "words_box";
			this.words_box.Size = new System.Drawing.Size(256, 62);
			this.words_box.TabIndex = 3;
			this.words_box.Text = "";
			// 
			// words_label
			// 
			this.words_label.AutoSize = true;
			this.words_label.Location = new System.Drawing.Point(6, 124);
			this.words_label.Name = "words_label";
			this.words_label.Size = new System.Drawing.Size(52, 17);
			this.words_label.TabIndex = 2;
			this.words_label.Text = "Слова:";
			// 
			// text_box
			// 
			this.text_box.Location = new System.Drawing.Point(64, 51);
			this.text_box.Name = "text_box";
			this.text_box.Size = new System.Drawing.Size(258, 57);
			this.text_box.TabIndex = 1;
			this.text_box.Text = "";
			// 
			// text_label
			// 
			this.text_label.AutoSize = true;
			this.text_label.Location = new System.Drawing.Point(8, 48);
			this.text_label.Name = "text_label";
			this.text_label.Size = new System.Drawing.Size(50, 17);
			this.text_label.TabIndex = 0;
			this.text_label.Text = "Текст:";
			// 
			// task2_page
			// 
			this.task2_page.Controls.Add(this.execute2_button);
			this.task2_page.Location = new System.Drawing.Point(4, 25);
			this.task2_page.Name = "task2_page";
			this.task2_page.Padding = new System.Windows.Forms.Padding(3);
			this.task2_page.Size = new System.Drawing.Size(359, 238);
			this.task2_page.TabIndex = 1;
			this.task2_page.Text = "Задание 2";
			this.task2_page.UseVisualStyleBackColor = true;
			// 
			// execute2_button
			// 
			this.execute2_button.Location = new System.Drawing.Point(6, 6);
			this.execute2_button.Name = "execute2_button";
			this.execute2_button.Size = new System.Drawing.Size(347, 226);
			this.execute2_button.TabIndex = 0;
			this.execute2_button.Text = "Выполнить";
			this.execute2_button.UseVisualStyleBackColor = true;
			this.execute2_button.Click += new System.EventHandler(this.execute2_button_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(391, 291);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Практика 9";
			this.tabControl1.ResumeLayout(false);
			this.task1_page.ResumeLayout(false);
			this.task1_page.PerformLayout();
			this.task2_page.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage task1_page;
		private System.Windows.Forms.TabPage task2_page;
		private System.Windows.Forms.ComboBox letter_box;
		private System.Windows.Forms.Label letter_label;
		private System.Windows.Forms.RichTextBox words_box;
		private System.Windows.Forms.Label words_label;
		private System.Windows.Forms.RichTextBox text_box;
		private System.Windows.Forms.Label text_label;
		private System.Windows.Forms.Button execute_button;
		private System.Windows.Forms.Button execute2_button;
	}
}

