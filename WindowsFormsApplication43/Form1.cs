using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication43
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

			this.Text = "Panelka";
			this.Width = 800; this.Height = 600;
			Label lb1 = new Label();
			lb1.Text = "Создание теста: название и описание";
			lb1.Location = new Point(this.Width / 2, this.Height / 2);
		}
	}
}
