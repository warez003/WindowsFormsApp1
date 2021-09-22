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

            Panel pn1 = new Panel();
            Create_Any(this, pn1, "pn1", 139, 0, BorderStyle.FixedSingle, 500, 561);
            int x = Convert.ToInt32(pn1.Location.X); int y = Convert.ToInt32(pn1.Location.Y);

            List<Button> bt = new List<Button>();

            Label lb1 = new Label();
            Create_Any(pn1, lb1, "Создавай тесты просто!", "Times new roman", 18, FontStyle.Regular, x - lb1.Width / 2 + 25, y + pn1.Height / 2 - 39, true, Color.FromArgb(65, 105, 225));
            x = Convert.ToInt32(lb1.Location.X); y = Convert.ToInt32(lb1.Location.Y);

            Button bt1 = new Button();
            bt.Add(bt1);
            Create_Any(pn1, bt[0], "bt1", "Создать текст", x + lb1.Width / 2 - bt[0].Width / 2 - 5, y + lb1.Height + 10, true, Color.FromArgb(65, 105, 225));

            Panel pn2 = new Panel();
            Create_Any(this, pn2, "pn2", 139, 0, BorderStyle.FixedSingle, 500, 561);

            Label lb2 = new Label();
            Create_Any(pn2, lb2, "Создание теста: название и описание", "Times new roman", 20, FontStyle.Regular, DockStyle.Top, AnchorStyles.Left | AnchorStyles.Top, true, Color.FromArgb(65, 105, 225));
            x = Convert.ToInt32(lb2.Location.X); y = Convert.ToInt32(lb2.Location.Y);

            Label lb3 = new Label();
            Create_Any(pn2, lb3, "Название теста: ", x + 10, y + lb2.Height + 10, true);
            x = Convert.ToInt32(lb3.Location.X); y = Convert.ToInt32(lb3.Location.Y);

            TextBox tb1 = new TextBox();
            Create_Any(pn2, tb1, x + 100, y, Convert.ToInt32(pn2.Width / 1.4));

            Label lb4 = new Label();
            Create_Any(pn2, lb4, "Описание теста: ", x, y + lb3.Height + 15, true);
            x = Convert.ToInt32(lb4.Location.X); y = Convert.ToInt32(lb4.Location.Y);

            TextBox tb2 = new TextBox();
            Create_Any(pn2, tb2, x, y + 25, Convert.ToInt32(pn2.Width / 1.2), pn2.Height / 4, true);
            x = Convert.ToInt32(tb2.Location.X); y = Convert.ToInt32(tb2.Location.Y);

            Button bt2 = new Button();
            bt.Add(bt2);
            Create_Any(pn2, bt[1], "bt_edit_questions", "Перейти к редактированию вопросов", x + tb2.Size.Width / 2 - bt[1].Size.Width / 2 - 65, y + tb2.Size.Height + 10, true, Color.FromArgb(65, 105, 225));

            Panel pn3 = new Panel();
            Create_Any(this, pn3, "pn3", 139, 0, BorderStyle.FixedSingle, 500, 561);

            Label lb5 = new Label();
            Create_Any(pn3, lb5, "Редактирование теста: вопросы и баллы за них", "Times new roman", 16, FontStyle.Regular, DockStyle.Top, AnchorStyles.Left | AnchorStyles.Top, true, Color.FromArgb(65, 105, 225));
            lb5.Name = "lb5";
            x = Convert.ToInt32(lb5.Location.X); y = Convert.ToInt32(lb5.Location.Y);

            Label lbN = new Label();
            int val = 1;
            lbN.Tag = val;
            lbN.Name = "lbN";
            Create_Any(pn3, lbN, "Текст вопроса № " + Convert.ToString(lbN.Tag) + ": ", x, y + lbN.Height + 10, true);
            x = Convert.ToInt32(lbN.Location.X); y = Convert.ToInt32(lbN.Location.Y);

            TextBox textBox3 = new TextBox();
            Create_Any(pn3, textBox3, x + 10, y + lbN.Size.Height + 10, Convert.ToInt32(pn3.Width / 1.2), pn3.Height / 6, true);
            x = Convert.ToInt32(textBox3.Location.X); y = Convert.ToInt32(textBox3.Location.Y);
            textBox3.Name = "tb3";

            // Тут начинается код, который нужно обернуть в цикл и создавать динамически эти элементы (несколько объектов)

            x = Convert.ToInt32(textBox3.Location.X); y = Convert.ToInt32(textBox3.Location.Y);

            Label lbQ = new Label();
            Create_Any(pn3, lbQ, "Вариант ответа: ", x, Convert.ToInt32(y + lbQ.Height * 4.6), true);
            x = Convert.ToInt32(lbQ.Location.X); y = Convert.ToInt32(lbQ.Location.Y);
            lbQ.Name = "lbQ";

            TextBox tbQ = new TextBox();
            Create_Any(pn3, tbQ, x + lbQ.Width, y, textBox3.Width / 2);
            x = Convert.ToInt32(tbQ.Location.X); y = Convert.ToInt32(tbQ.Location.Y);
            tbQ.Name = "tbQ";

            Label lbQQ = new Label();
            Create_Any(pn3, lbQQ, "Баллы", x + tbQ.Size.Width, y, true);
            x = Convert.ToInt32(lbQQ.Location.X); y = Convert.ToInt32(lbQQ.Location.Y);
            lbQQ.Name = "lbQQ";

            TextBox tbQQ = new TextBox();
            Create_Any(pn3, tbQQ, x + lbQQ.Width, y, lbQQ.Width);
            tbQQ.Name = "tbQQ";

            // Здесь код для обёртки заканчивается

            x = Convert.ToInt32(tbQ.Location.X); y = Convert.ToInt32(tbQ.Location.Y);

            Button bt3 = new Button();
            bt.Add(bt3);
            Create_Any(pn3, bt[2], "bt_add_answer", "Добавить вариант ответа", x + lb5.Width / 4 - bt[2].Width / 2 - 25, y + bt[2].Size.Height + 10, true, Color.FromArgb(225, 225, 225));
            x = Convert.ToInt32(bt[2].Location.X); y = Convert.ToInt32(bt[2].Location.Y);
            bt3.Tag = 7;

            Button bt4 = new Button();
            bt.Add(bt4);
            Create_Any(pn3, bt[3], "bt_add_question", "Добавить вопрос", x + bt[3].Width / 2 - 10, y + bt[3].Height + 10, true, Color.FromArgb(225, 225, 225));
            x = Convert.ToInt32(bt[3].Location.X); y = Convert.ToInt32(bt[3].Location.Y);
            bt[3].Visible = false;

            Button bt5 = new Button();
            bt.Add(bt5);
            Create_Any(pn3, bt[4], "btresults", "Перейти к редактированию результатов", x - bt[4].Width / 2 - 25, y + bt[4].Size.Height + 10, true, Color.FromArgb(65, 105, 225));
            bt[4].Visible = false;

            Panel pn4 = new Panel();
            Create_Any(this, pn4, "pn4", 139, 0, BorderStyle.FixedSingle, 500, 561);

            Label lbl = new Label();
            Create_Any(pn4, lbl, "Создание теста: название и описание", "Times new roman", 18, FontStyle.Regular, DockStyle.Top, AnchorStyles.Left | AnchorStyles.Top, true, Color.FromArgb(65, 105, 225));
            lbl.Visible = false;
            x = Convert.ToInt32(lbl.Location.X); y = Convert.ToInt32(lbl.Location.Y);

            Button bt6 = new Button();
            bt.Add(bt6);
            Create_Any(pn4, bt[5], "bt6", "Перейти к редактированию описания", x + lbl.Size.Width / 2 - bt[5].Size.Width / 2 - 25, y + lbl.Size.Height - 5, true, Color.FromArgb(65, 105, 225));
            x = Convert.ToInt32(bt[5].Location.X); y = Convert.ToInt32(bt[5].Location.Y);

            Button bt7 = new Button();
            bt.Add(bt7);
            Create_Any(pn4, bt[6], "bt7", "Перейти к редактированию вопросов", x, y + bt[5].Size.Height + 10, true, Color.FromArgb(65, 105, 225));
            x = Convert.ToInt32(bt[6].Location.X); y = Convert.ToInt32(bt[6].Location.Y);

            Label lb6 = new Label();
            Create_Any(pn4, lb6, "Редактирование теста: результаты", "Times new roman", 20, FontStyle.Regular, 10, y + bt[6].Size.Height + 10, true, Color.FromArgb(65, 105, 225));
            x = Convert.ToInt32(lb6.Location.X); y = Convert.ToInt32(lb6.Location.Y);

            Label lb7 = new Label();
            Create_Any(pn4, lb7, "Результат для суммы баллов от", x, y + lb6.Size.Height + 10, true);
            x = Convert.ToInt32(lb7.Location.X); y = Convert.ToInt32(lb7.Location.Y);

            TextBox tb4 = new TextBox();
            Create_Any(pn4, tb4, x + lb7.Size.Width, y, lb7.Size.Width / 4);
            x = Convert.ToInt32(tb4.Location.X); y = Convert.ToInt32(tb4.Location.Y);

            Label lb8 = new Label();
            Create_Any(pn4, lb8, "до", x + tb4.Size.Width, y, true);
            x = Convert.ToInt32(lb8.Location.X); y = Convert.ToInt32(lb8.Location.Y);

            TextBox tb5 = new TextBox();
            Create_Any(pn4, tb5, x + lb8.Width + 5, y, lb7.Size.Width / 4);
            x = Convert.ToInt32(lb7.Location.X); y = Convert.ToInt32(lb7.Location.Y);

            Label lb9 = new Label();
            Create_Any(pn4, lb9, "Заголовок:", x, y + lb7.Size.Height + 10, true);
            x = Convert.ToInt32(lb9.Location.X); y = Convert.ToInt32(lb9.Location.Y);

            TextBox tb6 = new TextBox();
            Create_Any(pn4, tb6, x + lb9.Size.Width, y, Convert.ToInt32(pn4.Size.Width / 1.5) - 35);

            Label lb10 = new Label();
            Create_Any(pn4, lb10, "Описание:", x, y + lb7.Size.Height + 10, true);
            x = Convert.ToInt32(lb10.Location.X); y = Convert.ToInt32(lb10.Location.Y);

            TextBox tb7 = new TextBox();
            Create_Any(pn4, tb7, x + lb10.Size.Height * 2, y + lb10.Size.Height + 10, Convert.ToInt32(pn4.Width / 1.2), pn3.Height / 6, true);
            x = Convert.ToInt32(tb7.Location.X); y = Convert.ToInt32(tb7.Location.Y);

            Button bt8 = new Button();
            bt.Add(bt8);
            Create_Any(pn4, bt[7], "bt8", "Добавить еще результат", x + tb7.Size.Width / 2 - bt[7].Size.Width + 10, y + tb7.Size.Height + 10, true, Color.FromArgb(225, 225, 225));
            x = Convert.ToInt32(bt[7].Location.X); y = Convert.ToInt32(bt[7].Location.Y);

            Button bt9 = new Button();
            bt.Add(bt9);
            Create_Any(pn4, bt[8], "btsave", "Сохранить тест", x + 25, y + bt[8].Size.Height + 10, true, Color.FromArgb(65, 105, 225));

            Panel pn5 = new Panel();
            Create_Any(this, pn5, "pn5", 139, 0, BorderStyle.FixedSingle, 500, 561);

            Label lb11 = new Label();
            Create_Any(pn5, lb11, "Сохранение теста: название и описание", "Times new roman", 20, FontStyle.Regular, DockStyle.Top, AnchorStyles.Left | AnchorStyles.Top, true, Color.FromArgb(65, 105, 225));
            x = Convert.ToInt32(lb11.Location.X); y = Convert.ToInt32(lb11.Location.Y);

            Label lb12 = new Label();
            Create_Any(pn5, lb12, "Название теста: ", x, y + 45, true);
            x = Convert.ToInt32(lb12.Location.X); y = Convert.ToInt32(lb12.Location.Y);

            TextBox tb8 = new TextBox();
            Create_Any(pn5, tb8, x + 100, y, pn5.Width - 200);

            Label lb13 = new Label();
            Create_Any(pn5, lb13, "Описание теста: ", x, y + 25, true);
            x = Convert.ToInt32(lb13.Location.X); y = Convert.ToInt32(lb13.Location.Y);

            TextBox tb9 = new TextBox();
            Create_Any(pn5, tb9, x + 35, y + 20, Convert.ToInt32(pn5.Width / 1.2), pn5.Height / 4, true);
            x = Convert.ToInt32(tb9.Location.X); y = Convert.ToInt32(tb9.Location.Y);

            Button bt10 = new Button();
            bt.Add(bt10);
            Create_Any(pn5, bt[9], "bt_edit_questions", "Перейти к редактированию вопросов", x + tb9.Size.Width / 2 - bt[9].Size.Width / 2 - 65, y + tb9.Size.Height + 10, true, Color.FromArgb(65, 105, 225));
            x = Convert.ToInt32(bt[9].Location.X); y = Convert.ToInt32(bt[9].Location.Y);

            Button bt11 = new Button();
            bt.Add(bt11);
            Create_Any(pn5, bt[10], "btresults", "Перейти к редактированию результатов", x - 5, y + bt[10].Size.Height + 10, true, Color.FromArgb(65, 105, 225));
            x = Convert.ToInt32(bt[10].Location.X); y = Convert.ToInt32(bt[10].Location.Y);

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

            }

        }


        public Control Create_Any(Control c, string name, Point pos, Size sz)
        {
            Panel p = new Panel();
            p.Name = name;
            p.Location = pos;
            p.BorderStyle = BorderStyle.FixedSingle;
            p.Size = sz;
            c.Controls.Add(p);
            return p;
        }

        public Control Create_Any(Control c, string text, Point pos)
        {
            Label lb = new Label();
            lb.Text = text;
            lb.Location = pos;
            lb.AutoSize = true;
            c.Controls.Add(lb);
            return lb;
        }

        public Control Create_Any(Control c, Point pos, Size sz)
        {
            TextBox tb = new TextBox();
            tb.Location = pos;
            tb.Multiline = true;
            tb.Size = sz;
            c.Controls.Add(tb);
            return tb;

        }

        public Control Create_Any(Control c, string name, string text, Point pos)
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
