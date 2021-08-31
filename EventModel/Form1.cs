using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EventModel
{
    public partial class Form1 : Form
    {
        int x = 340;
        int y = 385;
        private volatile Calendar _calendar;
        private bool isRun = false;
        Thread thr;
        private int _curTime = 0;
        private volatile int tick;
        Graphics g;//Создаём переменную g типа Graphics (холст для рисования)
        Dictionary<EventsModel, string> dictEv = new Dictionary<EventsModel, string>
        {
            { EventsModel.EV1,"Событие №1" },
            { EventsModel.EV2,"Событие №2" },
            { EventsModel.EV3,"Событие №3" },
            { EventsModel.EV4,"Событие №4" },
            { EventsModel.EV5,"Событие №5" },
            { EventsModel.NoEvent,"Не событие" }
        };

        Dictionary<Priorities, string> dictPr = new Dictionary<Priorities, string>
        {
            {Priorities.High,"Наивысший" },
            {Priorities.LessThanNormal,"Ниже нормального" },
            {Priorities.Low,"Самый низкий" },
            {Priorities.MoreThanNormal,"Высокий" },
            {Priorities.Normal,"Нормальный" },
            {Priorities.NoPriority,"Нет приоритета" },
        };
        public Form1()
        {
            InitializeComponent();
            //перебор GroupBox'ов
            foreach (GroupBox gBox in this.Controls.OfType<GroupBox>())
            {
                foreach (ComboBox cBox in gBox.Controls.OfType<ComboBox>())
                {
                    cBox.SelectedIndex = 0;
                    cBox.DropDownStyle = ComboBoxStyle.DropDownList;
                }
            }
            timeMs.Text = "100";
            calendarTable.ColumnCount = 3;
            calendarTable.Columns[0].Name = "Событие";
            calendarTable.Columns[0].Width = 90;
            calendarTable.Columns[1].Name = "Время";
            calendarTable.Columns[1].Width = 50;
            calendarTable.Columns[2].Name = "Приоритет";
            calendarTable.Columns[2].Width = 100;
            _calendar = new Calendar();
        }

        public void doubleNumTextHandler(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox)
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    return;
                }
                else if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if ((sender as TextBox).Text.Contains('.') || (sender as TextBox).Text.Contains(','))
                    {
                        e.Handled = true;
                    }
                    return;
                }
                else if (e.KeyChar == 8)
                {
                    return;
                }
                e.Handled = true;
            }
        }

        private void addEventTime_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length == 0)
                (sender as TextBox).Text = "0";
        }

        public void intNumTextHandler(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox)
            {
                if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                {
                    return;
                }
                e.Handled = true;
            }
        }
        //добавление события
        private void addOperation_Click(object sender, EventArgs e)
        {
            EventsModel ev = switchEvent(addEvent);
            Priorities pr = switchPriority(addEventPriority);  
            _calendar.AddEventLast("", ev, pr, Double.Parse(addEventTime.Text.Replace('.',',')));
            updateTable();
        }

        //генерация радомных событий 
        private void generateOperation_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0;i< Int32.Parse(countEvent.Text); i++)
            {
                int time = r.Next(2, 10);
                string label = "";
                EventsModel ev = (EventsModel)r.Next(6);
                Priorities pr = (Priorities)r.Next(5);
                _calendar.AddEventLast(label, ev, pr, time);
            }
            updateTable();
        }
        //обновление таблицы
        private void updateTable()
        {
            calendarTable.Invoke( new Action(() => { calendarTable.Rows.Clear(); }));
            CalendarNode head = _calendar.Head;
            while (head.Next != _calendar.Head)
            {
                head = head.Next;
                calendarTable.Invoke(new Action(() => { calendarTable.Rows.Add(dictEv[head.Ev], head.TimeAct, dictPr[head.Priority]); }));
            }
        }
        //включение после определённого события
        private void addAfterOperation_Click(object sender, EventArgs e)
        {
            EventsModel evAdded = switchEvent(addedAfter);
            EventsModel ev = switchEvent(addAfterThis);
            Priorities pr = switchPriority(addAfterPriority);
            double time = Double.Parse(addAfterTime.Text);
            _calendar.AddEventAfter("", evAdded, pr, time,ev);
            updateTable();
        }

        private EventsModel switchEvent(ComboBox sender)
        {
            EventsModel ev = EventsModel.NoEvent;
            switch (sender.SelectedIndex)
            {
                case 0:
                    {
                        ev = EventsModel.EV1;
                    }
                    break;
                case 1:
                    {
                        ev = EventsModel.EV2;
                    }
                    break;
                case 2:
                    {
                        ev = EventsModel.EV3;
                    }
                    break;
                case 3:
                    {
                        ev = EventsModel.EV4;
                    }
                    break;
                case 4:
                    {
                        ev = EventsModel.EV5;
                    }
                    break;
            }
            return ev;
        }

        private Priorities switchPriority(ComboBox sender)
        {
            Priorities pr = Priorities.NoPriority;
            switch (sender.SelectedIndex)
            {
                case 0:
                    {
                        pr = Priorities.High;
                    }
                    break;
                case 1:
                    {
                        pr = Priorities.LessThanNormal;
                    }
                    break;
                case 2:
                    {
                        pr = Priorities.Low;
                    }
                    break;
                case 3:
                    {
                        pr = Priorities.MoreThanNormal;
                    }
                    break;
                case 4:
                    {
                        pr = Priorities.Normal;
                    }
                    break;
                case 5: { pr = Priorities.NoPriority; }
                    break;
            }
            return pr;
        }
        //отмена события
        private void cancelOperation_Click(object sender, EventArgs e)
        {
           EventsModel ev = switchEvent(cancelEvent);
            _calendar.cancelByEvent(ev);
            updateTable();
        }
        //получение информации о событии 
        private void getOperation_Click(object sender, EventArgs e)
        {
            EventsModel ev = switchEvent(eventGet);
            Priorities pr = Priorities.NoPriority;
            timeLabel.Text = _calendar.getTimeAndPriority(ev, _curTime, out pr).ToString("0.000");
            priorityLabel.Text = dictPr[pr];
        }
        //изменение приоритета события
        private void changePriorityOperation_Click(object sender, EventArgs e)
        {
             EventsModel ev = switchEvent(eventChangePr);
             Priorities pr = switchPriority(priorityChange);
             Priorities prChange = switchPriority(priorityToChange);
             _calendar.changePriority(ev, pr, prChange);
             updateTable();
        }
       
       public void Tick(int ms)
        {
            Thread.Sleep(ms);
            _curTime++;//модельное время
            _calendar.Head.Next.TimeAct--;
            calendarTable.Invoke(new Action(() =>
            {
                calendarTable.Rows[0].Cells[1].Value = _calendar.Head.Next.TimeAct;
                }));
            if (_calendar.Head.Next.TimeAct <= 0)
            {
                EventsModel ev =  _calendar.Head.Next.Ev;
                switchDonald(_calendar.Head.Next.Ev);
                _calendar.cancelOne(_calendar.Head.Next);
                calendarTable.Invoke(new Action(() =>
                {
                    calendarTable.Rows.Remove(calendarTable.Rows[0]);
                }));
            }
            currentTime.Invoke(new Action(() => currentTime.Text = _curTime.ToString()));
        }
       
        private void switchDonald(EventsModel ev)
        {
           g = this.CreateGraphics();
            switch (ev)
            {
                case EventsModel.EV1:
                    {
                        g.FillEllipse(Brushes.GreenYellow, x, y, 20, 20);
                        x += 45;
                    }
                    break;
                case EventsModel.EV2:
                    {
                        g.FillRectangle(Brushes.DeepPink, x, y, 20, 20);
                        x += 45;
                    }
                    break;
                case EventsModel.EV3:
                    {
                        g.FillRectangle(Brushes.MediumOrchid, x, y, 40, 20);
                        x += 65;
                    }
                        break;
                case EventsModel.EV4:
                    {
                        g.FillEllipse(Brushes.Cyan, x, y, 30, 20);
                        x += 55;
                    }
                    break;
                case EventsModel.EV5:
                    {
                        g.DrawBezier(new Pen(Color.Red), x, y + 15, x + 10, y - 15, x + 20, y + 35, x + 35, y + 10);
                        x += 65;
                    }
                    break;
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void clearCalendar_Click(object sender, EventArgs e)
        {
            _calendar.Head = new CalendarNode();
            updateTable();
        }

        //демонстрация 
        private void demonstateOperation_Click_1(object sender, EventArgs e)
        {
            if (!isRun)
            {  
                tick = Int32.Parse(timeMs.Text);
                if (thr == null )
                {
                    isRun = true;
                    (sender as Button).Invoke(new Action(() => (sender as Button).Text = "Приостановить"));
                    currentTime.Text = "0";
                    _curTime = 0;
                    thr = new Thread(() =>
                    {
                        while (_calendar.Head.Next != _calendar.Head)
                        {
                            Tick(tick);
                        }
                         _curTime = 0;
                         isRun = false;
                         (sender as Button).Invoke(new Action(() => (sender as Button).Text = "Демонстрация"));
                    });
                    thr.Start();
                }
                else try
                    {
                        thr.Resume();
                        isRun = true;
                        (sender as Button).Invoke(new Action(() => (sender as Button).Text = "Приостановить"));
                    }
                    catch{}
            }
            else
            {
                if (thr != null && thr.IsAlive)
                {
                    thr.Suspend();
                }
                (sender as Button).Invoke(new Action(() => (sender as Button).Text = "Дeмонстрация"));
                isRun = false;
            }


        }
    
        private void addEventTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void calendarTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }   
}
