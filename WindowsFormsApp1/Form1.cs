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

			Panel pn1 = Create_Panel(this, "pn1", new Point(139, 0), new Size(500, 561));

			List<Button> bt = new List<Button>();

			Label lb1 = Create_Label(pn1, "lb1", "Создавай тесты просто!", new Point(pn1.Location.X - 25, pn1.Location.Y + pn1.Height / 2 - 39));
			lb1.Font = new Font("Times new roman", 18, FontStyle.Regular);
			lb1.ForeColor = Color.FromArgb(65, 105, 225);

			Button bt1 = Create_Button(pn1, "bt1", "Создать текст", new Point(lb1.Location.X + lb1.Width / 2, lb1.Location.Y + lb1.Height + 10));
			bt1.Location = new Point(lb1.Location.X + lb1.Width / 2 - bt1.Width / 2, lb1.Location.Y + lb1.Height + 10);
			bt.Add(bt1);
			bt1.BackColor = Color.FromArgb(65, 105, 225);

			Panel pn2 = Create_Panel(this, "pn2", pn1.Location, pn1.Size);

			Label lb2 = Create_Label(pn2, "lb2", "Создание теста: название и описание", pn2.Location);
			lb2.Font = new Font("Times new roman", 20, FontStyle.Regular);
			lb2.ForeColor = Color.FromArgb(65, 105, 225);
			lb2.Dock = DockStyle.Top; lb2.Anchor = AnchorStyles.Left | AnchorStyles.Top;

			Label lb3 = Create_Label(pn2, "lb3", "Название теста: ", new Point(lb2.Location.X + 10, lb2.Location.Y + lb2.Height + 10));

			TextBox tb1 = Create_TextBox(pn2, "tb1", new Point(lb3.Location.X + 100, lb3.Location.Y), new Size(Convert.ToInt32(pn2.Width / 1.4), 20));

			Label lb4 = Create_Label(pn2, "lb4", "Описание теста: ", new Point(lb3.Location.X, lb3.Location.Y + lb3.Size.Height + 15));

			TextBox tb2 = Create_TextBox(pn2, "tb2", new Point(lb4.Location.X, lb4.Location.Y + 25), new Size(Convert.ToInt32(pn2.Width / 1.2), pn2.Height / 4));

			Button bt2 = Create_Button(pn2, "bt_edit_questions", "Перейти к редактированию вопросов", new Point(tb2.Location.X + tb2.Size.Width / 2 - bt1.Width, tb2.Location.Y + tb2.Size.Height + 10));
			bt.Add(bt2);
			bt2.BackColor = Color.FromArgb(65, 105, 225);

			Panel pn3 = Create_Panel(this, "pn3", pn2.Location, pn2.Size);
			pn3.AutoScroll = true;

			Label lb5 = Create_Label(pn3, "lb5", "Редактирование теста: вопросы и баллы за них", pn3.Location);
			lb5.Font = new Font("Times new roman", 16, FontStyle.Regular);
			lb5.ForeColor = Color.FromArgb(65, 105, 225);
			lb5.Dock = DockStyle.Top; lb5.Anchor = AnchorStyles.Left | AnchorStyles.Top;

			/* Control lbN = Create_Label(pn3, "lbN", "Текст вопроса № ", new Point(x, y + lb5.Height + 10));
			lbN.Text = lbN.Text + "1";
			x = Convert.ToInt32(lbN.Location.X); y = Convert.ToInt32(lbN.Location.Y);
			
			Control textBox3 = Create_TextBox(pn3, "tb3", new Point(x + 10, y + lbN.Size.Height + 10), new Size(Convert.ToInt32(pn3.Width / 1.2), pn3.Height / 6));
			x = Convert.ToInt32(textBox3.Location.X); y = Convert.ToInt32(textBox3.Location.Y);

			*/
			/* Тут начинается код, который нужно обернуть в цикл и создавать динамически эти элементы (несколько объектов)

			Control lbQ = Create_Label(pn3, "lbQ", "Вариант ответа: ", new Point(x, Convert.ToInt32(y + textBox3.Height + 10)));
			x = Convert.ToInt32(lbQ.Location.X); y = Convert.ToInt32(lbQ.Location.Y);

			Control tbQ = Create_TextBox(pn3, "tbQ", new Point(x + lbQ.Size.Width, y), new Size(textBox3.Size.Width / 2, 20));
			x = Convert.ToInt32(tbQ.Location.X); y = Convert.ToInt32(tbQ.Location.Y);

			Control lbQQ = Create_Label(pn3, "lbQQ", "Баллы", new Point(x + tbQ.Size.Width, y));
			x = Convert.ToInt32(lbQQ.Location.X); y = Convert.ToInt32(lbQQ.Location.Y);

			Control tbQQ = Create_TextBox(pn3, "tbQQ", new Point(x + lbQQ.Width, y), new Size(lbQQ.Width, 20));
			x = Convert.ToInt32(tbQQ.Location.X); y = Convert.ToInt32(tbQQ.Location.Y);

			*/ // Здесь код для обёртки заканчивается 

			Button bt3 = Create_Button(pn3, "bt_add_answer", "Добавить вариант ответа", new Point(lb5.Location.X + lb5.Width / 2, lb5.Location.Y + bt2.Size.Height + 10));
			bt3.Location = new Point(lb5.Location.X + lb5.Width / 2 - bt3.Width / 2, lb5.Location.Y + bt2.Size.Height + 10);
			bt.Add(bt3);
			bt3.BackColor = Color.FromArgb(255, 255, 255);

			Button bt4 = Create_Button(pn3, "bt_add_question", "Добавить вопрос", new Point(bt3.Location.X + bt3.Width / 2, bt3.Location.Y + bt3.Height + 10));
			bt4.Location = new Point(bt3.Location.X + bt3.Width / 2 - bt4.Width / 2, bt3.Location.Y + bt3.Height + 10);
			bt.Add(bt4);
			bt4.BackColor = Color.FromArgb(255, 255, 255);

			Button bt5 = Create_Button(pn3, "btresults", "Перейти к редактированию результатов", new Point(bt4.Location.X - bt4.Width / 2, bt4.Location.Y + bt4.Size.Height + 10));
			bt5.Location = new Point(bt4.Location.X - bt4.Width + bt5.Width / 4 - 10, bt4.Location.Y + bt4.Size.Height + 10);
			bt.Add(bt5);
			bt5.BackColor = Color.FromArgb(65, 105, 225);

			Panel pn4 = Create_Panel(this, "pn4", pn3.Location, pn3.Size);

			Label lbl = Create_Label(pn4, "lbl", "Создание теста: название и описание", pn4.Location);
			lbl.Font = new Font("Times new roman", 18, FontStyle.Regular);
			lbl.ForeColor = Color.FromArgb(65, 105, 225);
			lbl.Dock = DockStyle.Top; lbl.Anchor = AnchorStyles.Left | AnchorStyles.Top;
			lbl.Visible = false;

			Button bt6 = Create_Button(pn4, "bt6", "Перейти к редактированию описания", new Point(lbl.Location.X + lbl.Width / 2 - 25, lbl.Location.Y + lbl.Size.Height - 5));
			bt.Add(bt6);
			bt6.Location = new Point(lbl.Location.X + lbl.Width / 2 - bt6.Width / 2 + 25, lbl.Location.Y + lbl.Size.Height - 5);
			bt6.BackColor = Color.FromArgb(65, 105, 225);

			Button bt7 = Create_Button(pn4, "bt7", "Перейти к редактированию вопросов", new Point(bt6.Location.X, bt6.Location.Y + bt6.Size.Height + 10));
			bt.Add(bt7);
			bt7.BackColor = Color.FromArgb(65, 105, 225);

			Label lb6 = Create_Label(pn4, "lb6", "Редактирование теста: результаты", new Point(bt7.Location.X - lbl.Width / 2 + bt6.Width / 2, bt7.Location.Y + bt6.Size.Height + 10));
			lb6.Font = new Font("Times new roman", 20, FontStyle.Regular);
			lb6.ForeColor = Color.FromArgb(65, 105, 225);

			Label lb7 = Create_Label(pn4, "lb7", "Результат для суммы баллов от", new Point(lb6.Location.X, lb6.Location.Y + lb6.Size.Height + 20));

			TextBox tb4 = Create_TextBox(pn4, "tb4", new Point(lb7.Location.X + lb7.Size.Width, lb7.Location.Y), new Size(lb7.Size.Width / 4, 20));

			Label lb8 = Create_Label(pn4, "lb8", "до", new Point(tb4.Location.X + tb4.Size.Width, tb4.Location.Y));

			TextBox tb5 = Create_TextBox(pn4, "tb5", new Point(lb8.Location.X + lb8.Width + 5, lb8.Location.Y), new Size(lb7.Size.Width / 4, 20));

			Label lb9 = Create_Label(pn4, "lb9", "Заголовок:", new Point(lb7.Location.X, lb7.Location.Y + lb7.Size.Height + 10));

			TextBox tb6 = Create_TextBox(pn4, "tb6", new Point(lb9.Location.X + lb9.Size.Width, lb9.Location.Y), new Size(Convert.ToInt32(pn4.Size.Width / 1.2) - 35, 20));

			Label lb99 = Create_Label(pn4, "lb99", "Описание:", new Point(lb9.Location.X, lb9.Location.Y + lb9.Size.Height + 10));

			TextBox tb66 = Create_TextBox(pn4, "tb66", new Point(lb99.Location.X + 10, lb99.Location.Y + lb99.Height + 5), new Size(Convert.ToInt32(pn4.Size.Width / 1.2) - 35, pn4.Height / 3));

			Button bt9 = Create_Button(pn4, "btsave", "Сохранить тест", new Point(tb66.Location.X + tb66.Width / 2, tb66.Location.Y + tb66.Size.Height + 10));
			bt9.Location = new Point(tb66.Location.X + tb66.Width / 2 - bt9.Width / 2, tb66.Location.Y + tb66.Size.Height + 10);
			bt.Add(bt9);
			bt9.BackColor = Color.FromArgb(65, 105, 225);

			Panel pn5 = Create_Panel(this, "pn5", pn4.Location, pn4.Size);

			Label lb11 = Create_Label(pn5, "lb11", "Создание теста: название и описание", pn5.Location);
			lb11.Font = new Font("Times new roman", 20, FontStyle.Regular);
			lb11.ForeColor = Color.FromArgb(65, 105, 225);
			lb11.Dock = DockStyle.Top; lb11.Anchor = AnchorStyles.Left | AnchorStyles.Top;

			Label lb33 = Create_Label(pn5, "lb33", "Название теста: ", new Point(lb11.Location.X, Convert.ToInt32(lb11.Location.Y + lb11.Height / 1.5) + 10));

			TextBox tbt = Create_TextBox(pn5, "tbb", new Point(lb33.Location.X + lb33.Width + 5, lb33.Location.Y), new Size(Convert.ToInt32(lb11.Size.Width / 1.3), 14));

			Label lb13 = Create_Label(pn5, "lb13", "Описание теста: ", new Point(lb33.Location.X, lb33.Location.Y + lb11.Height));

			TextBox tb9 = Create_TextBox(pn5, "tb9", new Point(lb13.Location.X + 35, lb13.Location.Y + 20), new Size(Convert.ToInt32(pn5.Width / 1.2), pn5.Height / 4));

			Button bt10 = Create_Button(pn5, "bt_edit_questions", "Перейти к редактированию вопросов", new Point(tb9.Location.X + tb9.Width/2, tb9.Location.Y + tb9.Size.Height + 10));
			bt.Add(bt10);
			bt10.BackColor = Color.FromArgb(65, 105, 225);

			Button bt11 = Create_Button(pn5, "btresults", "Перейти к редактированию результатов", new Point(bt10.Location.X - 5, bt10.Location.Y + bt10.Size.Height + 10));
			bt.Add(bt11);
			bt11.BackColor = Color.FromArgb(65, 105, 225);

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
				progressBar1.Value++;
				Add_Question(progressBar1.Value);
			}
			if (b.Name == "bt_add_answer")
			{
				progressBar1.Value++;
				Add_Answer(progressBar1.Value);
			}

		}

		public void Add_Question(int k = 0)
        {
			int h1 = k * 130;
			int h2 = 50;

			Control c = this.Controls["pn3"] as Panel;

			Control lb = Create_Label(c, "lb" + k, "Текст вопроса № " + k, new Point(c.Width/2 - 245, c.Height / 3 - 190 + h1));

			int x = lb.Location.X; int y = lb.Location.Y;

			Control tb = Create_TextBox(c, "tb" + k, new Point(x + 10, y + lb.Size.Height + 10), new Size(Convert.ToInt32(c.Width / 1.2), c.Height / 6));
		}

        public void Add_Answer(int k = 0)
		{
			int h1 = k * 30;
			int h2 = 50;

			Control c = this.Controls["pn3"] as Panel;
			Control bt_add_question = c.Controls["bt_add_question"] as Button;
			Control bt_add_answer = c.Controls["bt_add_answer"] as Button;
			Control btresults = c.Controls["btresults"] as Button;

			c.Height += h2; this.Height += h2; bt_add_question.Location = new Point(bt_add_question.Location.X,bt_add_question.Location.Y + h2); bt_add_answer.Location = new Point(bt_add_answer.Location.X, bt_add_answer.Location.Y + h2); btresults.Location = new Point(btresults.Location.X, btresults.Location.Y + h2);
			Control panel = Create_Panel(c, "panel" + k, new Point(c.Size.Width / 2 - 240, c.Size.Height / 3 - 30 + h1), new Size(380, 22));
			int x = Convert.ToInt32(panel.Location.X); int y = Convert.ToInt32(panel.Location.Y);

			Control l = Create_Label(panel, "l" + k, "Вариант ответа:", new Point(0, 0));
			x = Convert.ToInt32(l.Location.X); y = Convert.ToInt32(l.Location.Y);

			Control t = Create_TextBox(panel, "t" + k, new Point(x + l.Width, y), new Size(210, 20));
			x = Convert.ToInt32(t.Location.X); y = Convert.ToInt32(t.Location.Y);

			Control l2 = Create_Label(panel, "l2" + k, "Баллы", new Point(x + t.Width, y));
			x = Convert.ToInt32(l2.Location.X); y = Convert.ToInt32(l2.Location.Y);

			Control t2 = Create_TextBox(panel, "t2" + k, new Point(x + l2.Width, y), new Size(l2.Width, 20));

		}

		public Panel Create_Panel(Control c, string name, Point pos, Size sz)
		{
			Panel p = new Panel();
			p.Name = name;
			p.Location = pos;
			p.BorderStyle = BorderStyle.None;
			p.Size = sz;
			c.Controls.Add(p);
			return p;
		}

		public Label Create_Label(Control c, string name, string text, Point pos)
		{
			Label lb = new Label();
			lb.Name = name;
			lb.Text = text;
			lb.Location = pos;
			lb.AutoSize = true;
			c.Controls.Add(lb);
			return lb;
		}

		public TextBox Create_TextBox(Control c, string name, Point pos, Size sz)
		{
			TextBox tb = new TextBox();
			tb.Name = name;
			tb.Location = pos;
			tb.Multiline = true;
			tb.Size = sz;
			c.Controls.Add(tb);
			return tb;

		}

		public Button Create_Button(Control c, string name, string text, Point pos)
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