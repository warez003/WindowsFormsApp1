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
            tb1.LostFocus += Tb1_LostFocus;

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

            Panel pn4 = Create_Panel(this, "pn4", pn3.Location, pn3.Size);
            pn4.AutoScroll = true;

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

            Label label = Create_Label(pn4, "label", "Редактирование теста: результаты", new Point(bt7.Location.X - lbl.Width / 2 + bt6.Width / 2, bt7.Location.Y + bt6.Size.Height + 10));
            label.Font = new Font("Times new roman", 20, FontStyle.Regular);
            label.ForeColor = Color.FromArgb(65, 105, 225);

            Panel pn5 = Create_Panel(this, "pn5", pn4.Location, pn4.Size);

            Label lb11 = Create_Label(pn5, "lb11", "Создание теста: название и описание", pn5.Location);
            lb11.Font = new Font("Times new roman", 20, FontStyle.Regular);
            lb11.ForeColor = Color.FromArgb(65, 105, 225);
            lb11.Dock = DockStyle.Top; lb11.Anchor = AnchorStyles.Left | AnchorStyles.Top;

            Label lb33 = Create_Label(pn5, "lb33", "Название теста: ", new Point(lb11.Location.X, Convert.ToInt32(lb11.Location.Y + lb11.Height / 1.5) + 10));

            TextBox tbt = Create_TextBox(pn5, "tbb", new Point(lb33.Location.X + lb33.Width + 5, lb33.Location.Y), new Size(Convert.ToInt32(lb11.Size.Width / 1.3), 20));
            tbt.LostFocus += Tb1_LostFocus;

            Label lb13 = Create_Label(pn5, "lb13", "Описание теста: ", new Point(lb33.Location.X, lb33.Location.Y + lb11.Height));

            TextBox tb9 = Create_TextBox(pn5, "tb9", new Point(lb13.Location.X + 35, lb13.Location.Y + 20), new Size(Convert.ToInt32(pn5.Width / 1.2), pn5.Height / 4));
            tb9.LostFocus += Tb1_LostFocus;

            Button bt10 = Create_Button(pn5, "bt_edit_questions", "Перейти к редактированию вопросов", new Point(tb9.Location.X + tb9.Width / 2, tb9.Location.Y + tb9.Size.Height + 10));
            bt.Add(bt10);
            bt10.Location = new Point(tb9.Location.X + tb9.Width / 2 - bt10.Width / 2, tb9.Location.Y + tb9.Size.Height + 10);
            bt10.BackColor = Color.FromArgb(65, 105, 225);

            Button bt11 = Create_Button(pn5, "btresults", "Перейти к редактированию результатов", new Point(bt10.Location.X - 5, bt10.Location.Y + bt10.Size.Height + 10));
            bt.Add(bt11);
            bt11.BackColor = Color.FromArgb(65, 105, 225);

            Button _save = Create_Button(pn5, "_save", "Сохранить данные", new Point(bt11.Location.X, bt11.Location.Y + bt11.Height));
            _save.Location = new Point(bt11.Location.X + _save.Width / 2, bt11.Location.Y + bt11.Height + 10);
            bt.Add(_save);

            for (int i = 0; i < bt.Count; i++)
            {
                bt[i].Click += Button_Click;
            }

            Gen_Panel(1);
            Edit_Results(1);
        }

        private void Tb1_LostFocus(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;

            if (t.Name != null)
            {
                _data.Text = t.Text;
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
            if (b.Name == "_save")
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*"; saveFile.CreatePrompt = true; saveFile.OverwritePrompt = true; saveFile.DefaultExt = ".txt"; saveFile.Title = "Сохранение данных программы"; saveFile.AddExtension = true; saveFile.DefaultExt = ".txt";

                if (saveFile.ShowDialog() == DialogResult.Cancel)
                    return;

                string filename = saveFile.FileName;
                System.IO.File.WriteAllText(filename, _data.Text);
                MessageBox.Show("Сохранение произошло успешно!");
            }


        }


        public void Edit_Results(int k = 0)
        {
            int h1 = k * 355;

            Panel p = this.Controls["pn4"] as Panel;
            Panel clone = Create_Panel(p, "clone", new Point(p.Width / 2 - 250, p.Height / 3 - 525 + h1), new Size(455, 355));
            clone.BorderStyle = BorderStyle.None;

            Label label = Create_Label(clone, "label", "Результат для суммы баллов от", new Point(clone.Width / 2 - 220, clone.Height / 3));

            TextBox textBox = Create_TextBox(clone, "textBox", new Point(label.Location.X + label.Size.Width, label.Location.Y), new Size(label.Size.Width / 4, 20));
            textBox.LostFocus += Tb1_LostFocus;

            Label label2 = Create_Label(clone, "label2", "до", new Point(textBox.Location.X + textBox.Size.Width, textBox.Location.Y));

            TextBox textBox1 = Create_TextBox(clone, "textBox1", new Point(label2.Location.X + label2.Width, label2.Location.Y), new Size(label.Size.Width / 4, 20));
            textBox1.LostFocus += Tb1_LostFocus;

            Label label3 = Create_Label(clone, "label3", "Заголовок:", new Point(label.Location.X, label.Location.Y + label.Size.Height + 10));

            TextBox textBox2 = Create_TextBox(clone, "textBox2", new Point(label3.Location.X + label3.Size.Width, label3.Location.Y), new Size(Convert.ToInt32(p.Size.Width / 1.6) - 35, 20));
            textBox2.LostFocus += Tb1_LostFocus;

            Label label4 = Create_Label(clone, "label4", "Описание:", new Point(label3.Location.X, label3.Location.Y + label3.Size.Height + 10));

            TextBox textBox3 = Create_TextBox(clone, "textBox3", new Point(label4.Location.X + 10, label4.Location.Y + label4.Height + 5), new Size(Convert.ToInt32(p.Size.Width / 1.2) - 35, p.Height / 6));
            textBox3.LostFocus += Tb1_LostFocus;

            Button button1 = Create_Button(clone, "bt_add_results", "Добавить еще результат", new Point(textBox3.Location.X, textBox3.Location.Y + textBox3.Height + 5));
            button1.Location = new Point(textBox3.Location.X - button1.Width / 2 + textBox3.Width / 2, textBox3.Location.Y + textBox3.Height + 5);
            button1.ForeColor = Color.FromArgb(65, 105, 225);
            button1.Click += Button_Clicked;

            Button button2 = Create_Button(clone, "btsave", "Сохранить тест", new Point(button1.Location.X, button1.Location.Y + button1.Height + 5));
            button2.Location = new Point(button1.Location.X + button2.Width - button1.Width / 2, button1.Location.Y + button1.Height + 5);
            button2.BackColor = Color.FromArgb(65, 105, 225);
            button2.Click += Button_Clicked;

            void Button_Clicked(object sender, EventArgs e)
            {
                Button b = (Button)sender;
                if (b.Name == "bt_add_results")
                {
                    progressBar1.Value++;
                    Edit_Results(progressBar1.Value);
                }
                if (b.Name == "btsave")
                {
                    p.Hide();
                    (this.Controls["pn5"] as Panel).Show();
                }
            }
        }

        public void Gen_Panel(int k = 0)
        {
            int h1 = k * 355;
            int h2 = k * 30;

            Panel p = this.Controls["pn3"] as Panel;
            Panel clone = Create_Panel(p, "clone", new Point(p.Width / 2 - 250, p.Height / 3 - 510 + h1), new Size(455, 355));
            clone.BorderStyle = BorderStyle.None;
            Label l = Create_Label(clone, "l", "Текст вопроса № " + k, new Point(clone.Width / 2 - 190, clone.Height / 3 - 100));
            TextBox tb = Create_TextBox(clone, "tb", new Point(l.Location.X, l.Location.Y + 20), new Size(375, 80));
            tb.LostFocus += Tb1_LostFocus;

            Button add = Create_Button(clone, "add", "Добавить вариант ответа", new Point(tb.Location.X + tb.Width / 2, tb.Location.Y + tb.Height + 10));
            add.Location = new Point(tb.Location.X + tb.Width / 2 - add.Width / 2, tb.Location.Y + tb.Height + 10);
            add.ForeColor = Color.FromArgb(65, 105, 225);

            for (int i = 10 * 3; i < 40 * 3; i += 10 * 3)
            {
                Panel panel = Create_Panel(clone, "panel", new Point(tb.Width / 2 - 150, tb.Height / 3 + 70 + i), new Size(tb.Width, add.Height + 5));
                panel.BorderStyle = BorderStyle.None;
                Label label = Create_Label(panel, "label" + k, "Вариант ответа:", new Point(panel.Width / 2 - 185, panel.Height / 3 - 5));
                TextBox textBox = Create_TextBox(panel, "textBox" + k, new Point(label.Location.X + label.Width, label.Location.Y), new Size(200, 20));
                textBox.LostFocus += Tb1_LostFocus;
                Label label2 = Create_Label(panel, "label2" + k, "Баллы", new Point(textBox.Location.X + textBox.Width, textBox.Location.Y));
                TextBox textBox2 = Create_TextBox(panel, "textBox2" + k, new Point(label2.Location.X + label2.Width, label2.Location.Y), new Size(label2.Width, 20));
                textBox2.LostFocus += Tb1_LostFocus;
            }
            add.Location = new Point(add.Location.X, add.Location.Y + 30 * 3);
            Button _add = Create_Button(clone, "_add", "Добавить вопрос", new Point(add.Location.X, add.Location.Y + add.Height));
            _add.Location = new Point(add.Location.X - _add.Width / 2 + add.Width / 2, add.Location.Y + add.Height + 5);
            _add.ForeColor = Color.FromArgb(65, 105, 225);
            _add.Click += _Add_Click;

            Button btresult = Create_Button(clone, "btresult", "Перейти к редактированию результатов", new Point(_add.Location.X, _add.Location.Y + _add.Height));
            btresult.Location = new Point(_add.Location.X - btresult.Width / 2 + _add.Width / 2, _add.Location.Y + _add.Height + 10);
            btresult.BackColor = Color.FromArgb(65, 105, 225);
            btresult.Click += _Add_Click;

            void _Add_Click(object sender, EventArgs e)
            {
                Button b = (Button)sender;
                if (b.Name == "_add")
                {
                    progressBar1.Value++;
                    Gen_Panel(progressBar1.Value);
                }
                if (b.Name == "btresult")
                {
                    p.Hide();
                    (this.Controls["pn4"] as Panel).Show();
                }
            }

            /*
			add.Click += Add_Click;

			void Add_Click(object sender, EventArgs e)
            {
				Button b = (Button)sender;

				if(b.Name == "add")
                {
					for(int i = 10 * 3; i < 40 * 3; i+=10*3)
                    {
						Panel panel = Create_Panel(clone, "panel", new Point(tb.Width / 2 - 150, tb.Height / 3 + 130 + i), new Size(tb.Width, add.Height + 5));
						panel.BorderStyle = BorderStyle.FixedSingle;
						Label label = Create_Label(panel, "label" + k, "Вариант ответа:", new Point(panel.Location.X - 5, panel.Location.Y + panel.Height + 10));
						TextBox textBox = Create_TextBox(panel, "textBox" + k, new Point(label.Location.X + label.Width, label.Location.Y), new Size(210, 20));
						Label label2 = Create_Label(panel, "label2" + k, "Баллы", new Point(textBox.Location.X + textBox.Width, textBox.Location.Y));
						TextBox textBox2 = Create_TextBox(panel, "textBox2" + k, new Point(label2.Location.X + label2.Width, label2.Location.Y), new Size(label2.Width, 20));
					}						
					add.Location = new Point(add.Location.X, add.Location.Y + 30 * 3);
					clone.Height += 35 * 3;
			
				}
            }
	*/
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