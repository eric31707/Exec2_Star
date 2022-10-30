using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Star
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void leftbtn_Click(object sender, EventArgs e)
		{

			int? rows = Getrows();
			Inputby(rows);
			bool nullornot = rows.HasValue;
			if (nullornot)
			{
				string stars = Leftstar(rows.Value);
				resulttxt.Text = stars;
			}
		}

		private void Inputby(int? rows)
		{

			if (rows.HasValue == false)
			{
				MessageBox.Show("請輸入列數");

			}
			else if (rows.Value <= 0)
			{
				MessageBox.Show("列數必須是大於零");

			}
			else if (rows.Value > 10)
			{
				MessageBox.Show("列數必須介於1-10之間");

			}

		}

		private string Leftstar(int rows)
		{
			string resultleft = string.Empty;
			for (int i = 1; i <= rows; i++)
			{
				if (i > 10)
				{
					resultleft = " ";
					break;
				}
				resultleft += new string('*', i) + "\r\n";

			}

			return resultleft;
		}

		private int? Getrows()
		{
			string input = inputtxt.Text;
			bool isint = int.TryParse(input, out int rows);
			if (isint)
			{
				return rows;
			}
			else
			{
				return null;
			}
		}

		private void rightbtn_Click(object sender, EventArgs e)
		{
			int? rows = Getrows();
			Inputby(rows);
			bool nullornot = rows.HasValue;
			if (nullornot)
			{
				string rightstars = Rightstar(rows.Value);
				resulttxt.Text = rightstars;
			}

		}

		private string Rightstar(int rows)
		{
			string resultright = string.Empty;
			for (int k = 1; k <= rows; k++)
			{
				if (k > 10)
				{
					resultright = " ";
					break;
				}
				resultright += new string('*', k).PadLeft(10, ' ') + "\r\n";
			}
			return resultright;
		}

		private void equalbtn_Click(object sender, EventArgs e)
		{
			int? rows = Getrows();
			Inputby(rows);
			bool nullornot = rows.HasValue;
			if (nullornot)
			{
				string stars = Equalstar(rows.Value);
				resulttxt.Text = stars;
			}
		}

		private string Equalstar(int rows)
		{
			string resultequal = string.Empty;
			for (int j = 1; j <= rows; j++)
			{
				string lines = string.Empty;
				if (j > 10)
				{
					resultequal = " ";
					break;
				}
				if (j >1)
				{
					int add = (j - 1);
					lines = new string('*', add);
				}
				resultequal += new string('*', j).PadLeft(10, ' ') + lines+ "\r\n" ;
			}
			return resultequal;
		}
	}
}
