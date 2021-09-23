using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			this.Load += Load_Event;
		}

		unsafe private void Load_Event(object sender, EventArgs e)
		{
			this.Text = "Test_Editor3000";
			this.Width = 800; this.Height = 600;
			this.CenterToScreen();
			this.StartPosition = FormStartPosition.CenterScreen;

			Control pn1 = Create_Panel(this, "pn1", new Point(139, 0), new Size(500, 561));
			int x = Convert.ToInt32(pn1.Location.X); int y = Convert.ToInt32(pn1.Location.Y);

			List<Button> bt = new List<Button>();

			Control c2 = Create_Label(pn1, "lb1", "Создавай тесты просто!", new Point(x - 25, y + pn1.Height / 2 - 39));
			c2.Font = new Font("Times new roman", 18, FontStyle.Regular);
			c2.ForeColor = Color.FromArgb(65, 105, 225);
			x = Convert.ToInt32(c2.Location.X); y = Convert.ToInt32(c2.Location.Y);

			Control c3 = Create_Button(pn1, "bt1", "Создать текст", new Point(x + c2.Width / 2, y + c2.Height + 10));
			c3.Location = new Point(x + c2.Width / 2 - c3.Width / 2, y + c2.Height + 10);
			bt.Add((pn1.Controls["bt1"] as Button));
			(pn1.Controls["bt1"] as Button).BackColor = Color.FromArgb(65, 105, 225);

			Control pn2 = Create_Panel(this, "pn2", pn1.Location, pn1.Size);
			x = Convert.ToInt32(pn2.Location.X); y = Convert.ToInt32(pn2.Location.Y);

			Control c4 = Create_Label(pn2, "lb2", "Создание теста: название и описание", pn2.Location);
			(pn2.Controls["lb2"] as Label).Font = new Font("Times new roman", 20, FontStyle.Regular);
			(pn2.Controls["lb2"] as Label).ForeColor = Color.FromArgb(65, 105, 225);
			(pn2.Controls["lb2"] as Label).Dock = DockStyle.Top; (pn2.Controls["lb2"] as Label).Anchor = AnchorStyles.Left | AnchorStyles.Top;
			x = Convert.ToInt32(c4.Location.X); y = Convert.ToInt32(c4.Location.Y);

			Control c5 = Create_Label(pn2, "lb3", "Название теста: ", new Point(x + 10, y + c4.Height + 10));
			x = Convert.ToInt32(c5.Location.X); y = Convert.ToInt32(c5.Location.Y);

			Control tb1 = Create_TextBox(pn2, "tb1", new Point(x + 100, y), new Size(Convert.ToInt32(pn2.Width / 1.4), 25));

			Control lb4 = Create_Label(pn2, "lb4", "Описание теста: ", new Point(x, y + c5.Size.Height + 15));
			x = Convert.ToInt32(lb4.Location.X); y = Convert.ToInt32(lb4.Location.Y);

			Control tb2 = Create_TextBox(pn2, "tb2", new Point(x, y + 25), new Size(Convert.ToInt32(pn2.Width / 1.2), pn2.Height / 4));
			x = Convert.ToInt32(tb2.Location.X); y = Convert.ToInt32(tb2.Location.Y);

			Control bt2 = Create_Button(pn2, "bt_edit_questions", "Перейти к редактированию вопросов", new Point(x + tb2.Size.Width / 2 - c3.Size.Width / 2 - 65, y + tb2.Size.Height + 10));
			bt.Add((pn2.Controls["bt_edit_questions"] as Button));
			(pn2.Controls["bt_edit_questions"] as Button).BackColor = Color.FromArgb(65, 105, 225);

			Control pn3 = Create_Panel(this, "pn3", pn2.Location, pn2.Size);

			Control lb5 = Create_Label(pn3, "lb5", "Редактирование теста: вопросы и баллы за них", pn3.Location);
			(pn3.Controls["lb5"] as Label).Font = new Font("Times new roman", 16, FontStyle.Regular);
			(pn3.Controls["lb5"] as Label).ForeColor = Color.FromArgb(65, 105, 225);
			(pn3.Controls["lb5"] as Label).Dock = DockStyle.Top; (pn3.Controls["lb5"] as Label).Anchor = AnchorStyles.Left | AnchorStyles.Top;
			x = Convert.ToInt32(lb5.Location.X); y = Convert.ToInt32(lb5.Location.Y);

			Control lbN = Create_Label(pn3, "lbN", "Текст вопроса № ", new Point(x, y + lb5.Height + 10));
			lbN.Text = lbN.Text + "1";
			x = Convert.ToInt32(lbN.Location.X); y = Convert.ToInt32(lbN.Location.Y);

			Control textBox3 = Create_TextBox(pn3, "tb3", new Point(x + 10, y + lbN.Size.Height + 10), new Size(Convert.ToInt32(pn3.Width / 1.2), pn3.Height / 6));
			x = Convert.ToInt32(textBox3.Location.X); y = Convert.ToInt32(textBox3.Location.Y);

			// Тут начинается код, который нужно обернуть в цикл и создавать динамически эти элементы (несколько объектов)

			Control lbQ = Create_Label(pn3, "lbQ", "Вариант ответа: ", new Point(x, Convert.ToInt32(y + textBox3.Height + 10)));
			x = Convert.ToInt32(lbQ.Location.X); y = Convert.ToInt32(lbQ.Location.Y);

			Control tbQ = Create_TextBox(pn3, "tbQ", new Point(x + lbQ.Size.Width, y), new Size(textBox3.Size.Width / 2, 20));
			x = Convert.ToInt32(tbQ.Location.X); y = Convert.ToInt32(tbQ.Location.Y);

			Control lbQQ = Create_Label(pn3, "lbQQ", "Баллы", new Point(x + tbQ.Size.Width, y));
			x = Convert.ToInt32(lbQQ.Location.X); y = Convert.ToInt32(lbQQ.Location.Y);

			Control tbQQ = Create_TextBox(pn3, "tbQQ", new Point(x + lbQQ.Width, y), new Size(lbQQ.Width, 20));
			x = Convert.ToInt32(tbQQ.Location.X); y = Convert.ToInt32(tbQQ.Location.Y);

			// Здесь код для обёртки заканчивается

			x = Convert.ToInt32(tbQ.Location.X); y = Convert.ToInt32(tbQ.Location.Y);

			Control bt3 = Create_Button(pn3, "bt_add_answer", "Добавить вариант ответа", new Point(x + tbQ.Width / 2, y + bt2.Size.Height + 10));
			bt3.Location = new Point(x + tbQ.Width / 2 - bt3.Width / 2, y + bt2.Size.Height + 10);
			bt.Add((pn3.Controls["bt_add_answer"] as Button));
			(pn3.Controls["bt_add_answer"] as Button).BackColor = Color.FromArgb(255, 255, 255);
			x = Convert.ToInt32(bt3.Location.X); y = Convert.ToInt32(bt3.Location.Y);

			Control bt4 = Create_Button(pn3, "bt_add_question", "Добавить вопрос", new Point(x + bt3.Width / 2, y + bt3.Height + 10));
			bt4.Location = new Point(x + bt3.Width / 2 - bt4.Width / 2, y + bt3.Height + 10);
			bt.Add((pn3.Controls["bt_add_question"] as Button));
			(pn3.Controls["bt_add_question"] as Button).BackColor = Color.FromArgb(255, 255, 255);
			x = Convert.ToInt32(bt4.Location.X); y = Convert.ToInt32(bt4.Location.Y);

			Control bt5 = Create_Button(pn3, "btresults", "Перейти к редактированию результатов", new Point(x - bt4.Width / 2, y + bt4.Size.Height + 10));
			bt5.Location = new Point(x - bt4.Width + bt5.Width / 4 - 10, y + bt4.Size.Height + 10);
			bt.Add((pn3.Controls["btresults"] as Button));
			(pn3.Controls["btresults"] as Button).BackColor = Color.FromArgb(65, 105, 225);
			x = Convert.ToInt32(bt5.Location.X); y = Convert.ToInt32(bt5.Location.Y);

			Control pn4 = Create_Panel(this, "pn4", pn3.Location, pn3.Size);

			Control lbl = Create_Label(pn4, "lbl", "Создание теста: название и описание", pn4.Location);
			(pn4.Controls["lbl"] as Label).Font = new Font("Times new roman", 18, FontStyle.Regular);
			(pn4.Controls["lbl"] as Label).ForeColor = Color.FromArgb(65, 105, 225);
			(pn4.Controls["lbl"] as Label).Dock = DockStyle.Top; (pn4.Controls["lbl"] as Label).Anchor = AnchorStyles.Left | AnchorStyles.Top;
			lbl.Visible = false;
			x = Convert.ToInt32(lbl.Location.X); y = Convert.ToInt32(lbl.Location.Y);

			Control bt6 = Create_Button(pn4, "bt6", "Перейти к редактированию описания", new Point(x + lbl.Width / 2 - 25, y + lbl.Size.Height - 5));
			bt.Add((pn4.Controls["bt6"] as Button));
			bt6.Location = new Point(x + lbl.Width / 2 - bt6.Width / 2 + 25, y + lbl.Size.Height - 5);
			(pn4.Controls["bt6"] as Button).BackColor = Color.FromArgb(65, 105, 225);
			x = Convert.ToInt32(bt6.Location.X); y = Convert.ToInt32(bt6.Location.Y);

			Control bt7 = Create_Button(pn4, "bt7", "Перейти к редактированию вопросов", new Point(x, y + bt6.Size.Height + 10));
			bt.Add((pn4.Controls["bt7"] as Button));
			(pn4.Controls["bt7"] as Button).BackColor = Color.FromArgb(65, 105, 225);
			x = Convert.ToInt32(bt7.Location.X); y = Convert.ToInt32(bt7.Location.Y);

			Control lb6 = Create_Label(pn4, "lb6", "Редактирование теста: результаты", new Point(x - lbl.Width / 2 + bt6.Width / 2, y + bt6.Size.Height + 10));
			(pn4.Controls["lb6"] as Label).Font = new Font("Times new roman", 20, FontStyle.Regular);
			(pn4.Controls["lb6"] as Label).ForeColor = Color.FromArgb(65, 105, 225);
			x = Convert.ToInt32(lb6.Location.X); y = Convert.ToInt32(lb6.Location.Y);

			Control lb7 = Create_Label(pn4, "lb7", "Результат для суммы баллов от", new Point(x, y + lb6.Size.Height + 20));
			x = Convert.ToInt32(lb7.Location.X); y = Convert.ToInt32(lb7.Location.Y);

			Control tb4 = Create_TextBox(pn4, "tb4", new Point(x + lb7.Size.Width, y), new Size(lb7.Size.Width / 4, 20));
			x = Convert.ToInt32(tb4.Location.X); y = Convert.ToInt32(tb4.Location.Y);

			Control lb8 = Create_Label(pn4, "lb8", "до", new Point(x + tb4.Size.Width, y));
			x = Convert.ToInt32(lb8.Location.X); y = Convert.ToInt32(lb8.Location.Y);

			Control tb5 = Create_TextBox(pn4, "tb5", new Point(x + lb8.Width + 5, y), new Size(lb7.Size.Width / 4, 20));
			x = Convert.ToInt32(lb7.Location.X); y = Convert.ToInt32(lb7.Location.Y);

			Control lb9 = Create_Label(pn4, "lb9", "Заголовок:", new Point(x, y + lb7.Size.Height + 10));
			x = Convert.ToInt32(lb9.Location.X); y = Convert.ToInt32(lb9.Location.Y);

			Control tb6 = Create_TextBox(pn4, "tb6", new Point(x + lb9.Size.Width, y), new Size(Convert.ToInt32(pn4.Size.Width / 1.2) - 35, 20));
			x = Convert.ToInt32(lb9.Location.X); y = Convert.ToInt32(lb9.Location.Y);

			Control lb99 = Create_Label(pn4, "lb99", "Описание:", new Point(x, y + lb9.Size.Height + 10));
			x = Convert.ToInt32(lb99.Location.X); y = Convert.ToInt32(lb99.Location.Y);

			Control tb66 = Create_TextBox(pn4, "tb66", new Point(x + 10, y + lb99.Height + 5), new Size(Convert.ToInt32(pn4.Size.Width / 1.2) - 35, pn4.Height / 3));
			x = Convert.ToInt32(tb66.Location.X); y = Convert.ToInt32(tb66.Location.Y);

			Control bt9 = Create_Button(pn4, "btsave", "Сохранить тест", new Point(x + tb66.Width / 2, y + tb66.Size.Height + 10));
			bt9.Location = new Point(x + tb66.Width / 2 - bt9.Width / 2, y + tb66.Size.Height + 10);
			bt.Add((pn4.Controls["btsave"] as Button));
			(pn4.Controls["btsave"] as Button).BackColor = Color.FromArgb(65, 105, 225);
			x = Convert.ToInt32(bt9.Location.X); y = Convert.ToInt32(bt9.Location.Y);

			Control pn5 = Create_Panel(this, "pn5", pn4.Location, pn4.Size);

			Control lb11 = Create_Label(pn5, "lb11", "Создание теста: название и описание", pn5.Location);
			(pn5.Controls["lb11"] as Label).Font = new Font("Times new roman", 20, FontStyle.Regular);
			(pn5.Controls["lb11"] as Label).ForeColor = Color.FromArgb(65, 105, 225);
			(pn5.Controls["lb11"] as Label).Dock = DockStyle.Top; (pn5.Controls["lb11"] as Label).Anchor = AnchorStyles.Left | AnchorStyles.Top;
			x = Convert.ToInt32(lb11.Location.X); y = Convert.ToInt32(lb11.Location.Y);

			Control lb33 = Create_Label(pn5, "lb33", "Название теста: ", new Point(x, Convert.ToInt32(y + lb11.Height / 1.5) + 10));
			x = Convert.ToInt32(lb33.Location.X); y = Convert.ToInt32(lb33.Location.Y);

			Control tbt = Create_TextBox(pn5, "tbb", new Point(x + lb33.Width + 5, y), new Size(Convert.ToInt32(lb11.Size.Width / 1.3), 20));

			/*

			Control lb12 = Create_Label(pn5, "lb12", "Результат для суммы баллов от", new Point(x + 10, y + 45));
			x = Convert.ToInt32(lb12.Location.X); y = Convert.ToInt32(lb12.Location.Y);

			Control tbb = Create_TextBox(pn5, "tbb", new Point(x + lb12.Width + 5, y), new Size(lb12.Size.Width / 5, 20));
			x = Convert.ToInt32(tbb.Location.X); y = Convert.ToInt32(tbb.Location.Y);

			Control lb14 = Create_Label(pn5, "lb14", "до", new Point(x + tbb.Size.Width + 10, y));
			x = Convert.ToInt32(lb14.Location.X); y = Convert.ToInt32(lb14.Location.Y);

			Control tb8 = Create_TextBox(pn5, "tb8", new Point(x + lb14.Width + 10, y), new Size(lb14.Width*2, 20));
			x = Convert.ToInt32(lb12.Location.X); y = Convert.ToInt32(lb12.Location.Y);

			 */
			Control lb13 = Create_Label(pn5, "lb13", "Описание теста: ", new Point(x, y + lb11.Height));
			x = Convert.ToInt32(lb13.Location.X); y = Convert.ToInt32(lb13.Location.Y);

			Control tb9 = Create_TextBox(pn5, "tb9", new Point(x + 35, y + 20), new Size(Convert.ToInt32(pn5.Width / 1.2), pn5.Height / 4));
			x = Convert.ToInt32(tb9.Location.X); y = Convert.ToInt32(tb9.Location.Y);

			Control bt10 = Create_Button(pn5, "bt_edit_questions", "Перейти к редактированию вопросов", new Point(x + tb9.Size.Width / 2 - bt9.Size.Width / 2 - 65, y + tb9.Size.Height + 10));
			bt.Add((pn5.Controls["bt_edit_questions"] as Button));
			(pn5.Controls["bt_edit_questions"] as Button).BackColor = Color.FromArgb(65, 105, 225);
			x = Convert.ToInt32(bt10.Location.X); y = Convert.ToInt32(bt10.Location.Y);

			Control bt11 = Create_Button(pn5, "btresults", "Перейти к редактированию результатов", new Point(x - 5, y + bt10.Size.Height + 10));
			bt.Add((pn5.Controls["btresults"] as Button));
			(pn5.Controls["btresults"] as Button).BackColor = Color.FromArgb(65, 105, 225);
			x = Convert.ToInt32(bt11.Location.X); y = Convert.ToInt32(bt11.Location.Y);

			for (int i = 0; i < bt.Count; i++)
			{
				bt[i].Click += Button_Click;
			}
		}

		private void Button_Click(object sender, EventArgs e)
		{
			Button b = (Button)sender;

			if (b.Name == "bt1")
			{
				(this.Controls["pn1"] as Panel).Hide();
			}
			if (b.Name == "bt2")
			{
				(this.Controls["pn2"] as Panel).Hide();
			}
			if (b.Name == "bt_edit_questions")
			{
				(this.Controls["pn2"] as Panel).Hide();
				(this.Controls["pn3"] as Panel).Show();
			}
			if (b.Name == "btsave")
			{
				(this.Controls["pn4"] as Panel).Hide();
				(this.Controls["pn5"] as Panel).Show();
			}
			if (b.Name == "btresults")
			{
				(this.Controls["pn3"] as Panel).Hide();
				(this.Controls["pn4"] as Panel).Show();
			}
			if (b.Name == "bt6")
			{
				(this.Controls["pn4"] as Panel).Hide();
				(this.Controls["pn2"] as Panel).Show();
			}
			if (b.Name == "bt7")
			{
				(this.Controls["pn4"] as Panel).Hide();
				(this.Controls["pn3"] as Panel).Show();
			}
			if (b.Name == "bt9")
			{
				(this.Controls["pn4"] as Panel).Hide();
			}
			if (b.Name == "bt_add_question")
			{

			}
			if (b.Name == "bt_add_answer")
			{
				progressBar1.Value++;
				ans(progressBar1.Value);
			}

		}

		public void ans(int k = 0)
		{
			int h1 = k * 40;
			int h2 = k * 40;

			Control panel = Create_Panel((this.Controls["pn3"] as Panel), "panel" + k, new Point((this.Controls["pn3"] as Panel).Size.Width / 2 - 170, (this.Controls["pn3"] as Panel).Size.Height / 3 + h1), new Size(300, 22));
			int x = Convert.ToInt32(panel.Location.X); int y = Convert.ToInt32(panel.Location.Y);

			Control l = Create_Label(panel, "l" + k, "Вариант ответа: ", new Point(0, 0));
			x = Convert.ToInt32(l.Location.X); y = Convert.ToInt32(l.Location.Y);

			Control t = Create_TextBox(panel, "t" + k, new Point(x + l.Width, y), new Size(l.Width, 20));
			x = Convert.ToInt32(t.Location.X); y = Convert.ToInt32(t.Location.Y);

			Control l2 = Create_Label(panel, "l2" + k, "Баллы", new Point(x + t.Width, y));
			x = Convert.ToInt32(l2.Location.X); y = Convert.ToInt32(l2.Location.Y);

			Control t2 = Create_TextBox(panel, "t2" + k, new Point(x + l2.Width, y), new Size(l2.Width, 20));

		}

		public Control Create_Panel(Control c, string name, Point pos, Size sz)
		{
			Panel p = new Panel();
			p.Name = name;
			p.Location = pos;
			p.BorderStyle = BorderStyle.None;
			p.Size = sz;
			c.Controls.Add(p);
			return p;
		}

		public Control Create_Label(Control c, string name, string text, Point pos)
		{
			Label lb = new Label();
			lb.Name = name;
			lb.Text = text;
			lb.Location = pos;
			lb.AutoSize = true;
			c.Controls.Add(lb);
			return lb;
		}

		public Control Create_TextBox(Control c, string name, Point pos, Size sz)
		{
			TextBox tb = new TextBox();
			tb.Name = name;
			tb.Location = pos;
			tb.Multiline = true;
			tb.Size = sz;
			c.Controls.Add(tb);
			return tb;

		}

		public Control Create_Button(Control c, string name, string text, Point pos)
		{
			Button bt = new Button();
			bt.Text = text;
			bt.Name = name;
			bt.Location = pos;
			bt.AutoSize = true;
			c.Controls.Add(bt);
			return bt;
		}


	}
}