using System;
using System.IO;
using System.Windows.Forms;

namespace PR9_WF
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		
		private void execute_button_Click(object sender, EventArgs e)
		{
			try
			{
				string str = Convert.ToString(text_box.Text);
				FileStream file = new FileStream(@"C:\Users\User\Desktop\file.dat", FileMode.Open);
				BinaryWriter file_write = new BinaryWriter(file);
				file_write.Write(str);
				file_write.Close();
				file = new FileStream(@"C:\Users\User\Desktop\file.dat", FileMode.Open);
				BinaryReader file_read = new BinaryReader(file);
				str = file_read.ReadString().ToLower();
				file_read.Close();
				file.Close();
				char letter = Convert.ToChar(letter_box.Text);
				char[] splitters = { ' ', ',', '.', '!', ';', ':', '?' };
				string[] array = str.Split(splitters);
				int count = 0;
				string rez = "";
				foreach (string var in array)
				{
					if (var[0] == letter)
					{
						count++;
						rez += var + " ";
					}
				}
				words_box.Text = rez;
				if (count == 0) words_box.Text = "Нет подходящих слов";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void execute2_button_Click(object sender, EventArgs e)
		{

			try
			{
				using (StreamReader sr = File.OpenText(@"C:\Users\User\Desktop\input.txt"))
				using (StreamWriter sw = new StreamWriter(@"C:\Users\User\Desktop\output.txt"))
					for (int i = 0; i < System.IO.File.ReadAllLines(@"C:\Users\User\Desktop\input.txt").Length; i++)
					{
						int count = 0;
						string s = sr.ReadLine();
						char[] chars = s.ToCharArray();
						foreach (char ch in chars)
							count++;
						sw.WriteLine(s + " " + count);
					}
				System.Diagnostics.Process.Start(@"C:\Users\User\Desktop\input.txt");
				System.Diagnostics.Process.Start(@"C:\Users\User\Desktop\output.txt");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
