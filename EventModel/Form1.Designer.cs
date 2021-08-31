namespace EventModel
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
            this.calendarTable = new System.Windows.Forms.DataGridView();
            this.addOperation = new System.Windows.Forms.Button();
            this.addAfterOperation = new System.Windows.Forms.Button();
            this.cancelOperation = new System.Windows.Forms.Button();
            this.getOperation = new System.Windows.Forms.Button();
            this.changePriorityOperation = new System.Windows.Forms.Button();
            this.addBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addEventTime = new System.Windows.Forms.TextBox();
            this.addEventPriority = new System.Windows.Forms.ComboBox();
            this.addEvent = new System.Windows.Forms.ComboBox();
            this.addAfterBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.addAfterTime = new System.Windows.Forms.TextBox();
            this.addAfterThis = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addAfterPriority = new System.Windows.Forms.ComboBox();
            this.addedAfter = new System.Windows.Forms.ComboBox();
            this.cancelEventBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cancelEvent = new System.Windows.Forms.ComboBox();
            this.getTimeAndPriorityBox = new System.Windows.Forms.GroupBox();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.eventGet = new System.Windows.Forms.ComboBox();
            this.changePriorityBox = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.eventChangePr = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.priorityToChange = new System.Windows.Forms.ComboBox();
            this.priorityChange = new System.Windows.Forms.ComboBox();
            this.calendarInitialize = new System.Windows.Forms.GroupBox();
            this.countEvent = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.generateOperation = new System.Windows.Forms.Button();
            this.CurrentTimeBox = new System.Windows.Forms.GroupBox();
            this.timeMs = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Label();
            this.demonstateOperation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.calendarTable)).BeginInit();
            this.addBox.SuspendLayout();
            this.addAfterBox.SuspendLayout();
            this.cancelEventBox.SuspendLayout();
            this.getTimeAndPriorityBox.SuspendLayout();
            this.changePriorityBox.SuspendLayout();
            this.calendarInitialize.SuspendLayout();
            this.CurrentTimeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendarTable
            // 
            this.calendarTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.calendarTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calendarTable.Location = new System.Drawing.Point(13, 12);
            this.calendarTable.Margin = new System.Windows.Forms.Padding(4);
            this.calendarTable.Name = "calendarTable";
            this.calendarTable.RowHeadersWidth = 51;
            this.calendarTable.RowTemplate.Height = 23;
            this.calendarTable.Size = new System.Drawing.Size(375, 234);
            this.calendarTable.TabIndex = 0;
            this.calendarTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.calendarTable_CellContentClick);
            // 
            // addOperation
            // 
            this.addOperation.Location = new System.Drawing.Point(12, 206);
            this.addOperation.Margin = new System.Windows.Forms.Padding(4);
            this.addOperation.Name = "addOperation";
            this.addOperation.Size = new System.Drawing.Size(100, 48);
            this.addOperation.TabIndex = 1;
            this.addOperation.Text = "Включить в календарь";
            this.addOperation.UseVisualStyleBackColor = true;
            this.addOperation.Click += new System.EventHandler(this.addOperation_Click);
            // 
            // addAfterOperation
            // 
            this.addAfterOperation.Location = new System.Drawing.Point(8, 261);
            this.addAfterOperation.Margin = new System.Windows.Forms.Padding(4);
            this.addAfterOperation.Name = "addAfterOperation";
            this.addAfterOperation.Size = new System.Drawing.Size(145, 48);
            this.addAfterOperation.TabIndex = 1;
            this.addAfterOperation.Text = "Включить в календарь после";
            this.addAfterOperation.UseVisualStyleBackColor = true;
            this.addAfterOperation.Click += new System.EventHandler(this.addAfterOperation_Click);
            // 
            // cancelOperation
            // 
            this.cancelOperation.Location = new System.Drawing.Point(47, 70);
            this.cancelOperation.Margin = new System.Windows.Forms.Padding(4);
            this.cancelOperation.Name = "cancelOperation";
            this.cancelOperation.Size = new System.Drawing.Size(100, 28);
            this.cancelOperation.TabIndex = 1;
            this.cancelOperation.Text = "Отменить";
            this.cancelOperation.UseVisualStyleBackColor = true;
            this.cancelOperation.Click += new System.EventHandler(this.cancelOperation_Click);
            // 
            // getOperation
            // 
            this.getOperation.Location = new System.Drawing.Point(30, 229);
            this.getOperation.Margin = new System.Windows.Forms.Padding(4);
            this.getOperation.Name = "getOperation";
            this.getOperation.Size = new System.Drawing.Size(120, 29);
            this.getOperation.TabIndex = 1;
            this.getOperation.Text = "Определить";
            this.getOperation.UseVisualStyleBackColor = true;
            this.getOperation.Click += new System.EventHandler(this.getOperation_Click);
            // 
            // changePriorityOperation
            // 
            this.changePriorityOperation.Location = new System.Drawing.Point(12, 192);
            this.changePriorityOperation.Margin = new System.Windows.Forms.Padding(4);
            this.changePriorityOperation.Name = "changePriorityOperation";
            this.changePriorityOperation.Size = new System.Drawing.Size(100, 28);
            this.changePriorityOperation.TabIndex = 1;
            this.changePriorityOperation.Text = "Изменить";
            this.changePriorityOperation.UseVisualStyleBackColor = true;
            this.changePriorityOperation.Click += new System.EventHandler(this.changePriorityOperation_Click);
            // 
            // addBox
            // 
            this.addBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addBox.Controls.Add(this.label3);
            this.addBox.Controls.Add(this.label2);
            this.addBox.Controls.Add(this.label1);
            this.addBox.Controls.Add(this.addEventTime);
            this.addBox.Controls.Add(this.addEventPriority);
            this.addBox.Controls.Add(this.addOperation);
            this.addBox.Controls.Add(this.addEvent);
            this.addBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBox.Location = new System.Drawing.Point(396, 13);
            this.addBox.Margin = new System.Windows.Forms.Padding(4);
            this.addBox.Name = "addBox";
            this.addBox.Padding = new System.Windows.Forms.Padding(4);
            this.addBox.Size = new System.Drawing.Size(189, 283);
            this.addBox.TabIndex = 2;
            this.addBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Приоритет события:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Относительное \r\nвремя события:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добавить событие:";
            // 
            // addEventTime
            // 
            this.addEventTime.Location = new System.Drawing.Point(8, 112);
            this.addEventTime.Margin = new System.Windows.Forms.Padding(4);
            this.addEventTime.Name = "addEventTime";
            this.addEventTime.Size = new System.Drawing.Size(175, 22);
            this.addEventTime.TabIndex = 1;
            this.addEventTime.Text = "0";
            this.addEventTime.TextChanged += new System.EventHandler(this.addEventTime_TextChanged);
            this.addEventTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.doubleNumTextHandler);
            this.addEventTime.Leave += new System.EventHandler(this.addEventTime_Leave);
            // 
            // addEventPriority
            // 
            this.addEventPriority.FormattingEnabled = true;
            this.addEventPriority.Items.AddRange(new object[] {
            "Наивысший",
            "Ниже нормального",
            "Самый низкий",
            "Высокий",
            "Нормальный",
            "Нет приоритета"});
            this.addEventPriority.Location = new System.Drawing.Point(5, 166);
            this.addEventPriority.Margin = new System.Windows.Forms.Padding(4);
            this.addEventPriority.Name = "addEventPriority";
            this.addEventPriority.Size = new System.Drawing.Size(175, 24);
            this.addEventPriority.TabIndex = 0;
            // 
            // addEvent
            // 
            this.addEvent.FormattingEnabled = true;
            this.addEvent.Items.AddRange(new object[] {
            "Событие №1",
            "Событие №2",
            "Событие №3",
            "Событие №4",
            "Событие №5"});
            this.addEvent.Location = new System.Drawing.Point(8, 39);
            this.addEvent.Margin = new System.Windows.Forms.Padding(4);
            this.addEvent.Name = "addEvent";
            this.addEvent.Size = new System.Drawing.Size(175, 24);
            this.addEvent.TabIndex = 0;
            // 
            // addAfterBox
            // 
            this.addAfterBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addAfterBox.Controls.Add(this.label6);
            this.addAfterBox.Controls.Add(this.label16);
            this.addAfterBox.Controls.Add(this.addAfterOperation);
            this.addAfterBox.Controls.Add(this.addAfterTime);
            this.addAfterBox.Controls.Add(this.addAfterThis);
            this.addAfterBox.Controls.Add(this.label5);
            this.addAfterBox.Controls.Add(this.label4);
            this.addAfterBox.Controls.Add(this.addAfterPriority);
            this.addAfterBox.Controls.Add(this.addedAfter);
            this.addAfterBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAfterBox.Location = new System.Drawing.Point(593, 13);
            this.addAfterBox.Margin = new System.Windows.Forms.Padding(4);
            this.addAfterBox.Name = "addAfterBox";
            this.addAfterBox.Padding = new System.Windows.Forms.Padding(4);
            this.addAfterBox.Size = new System.Drawing.Size(195, 311);
            this.addAfterBox.TabIndex = 3;
            this.addAfterBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Приоритет события:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 190);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 34);
            this.label16.TabIndex = 2;
            this.label16.Text = "Относительное \r\nвремя события:";
            // 
            // addAfterTime
            // 
            this.addAfterTime.Location = new System.Drawing.Point(8, 229);
            this.addAfterTime.Margin = new System.Windows.Forms.Padding(4);
            this.addAfterTime.Name = "addAfterTime";
            this.addAfterTime.Size = new System.Drawing.Size(175, 22);
            this.addAfterTime.TabIndex = 1;
            this.addAfterTime.Text = "0";
            this.addAfterTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.doubleNumTextHandler);
            this.addAfterTime.Leave += new System.EventHandler(this.addEventTime_Leave);
            // 
            // addAfterThis
            // 
            this.addAfterThis.FormattingEnabled = true;
            this.addAfterThis.Items.AddRange(new object[] {
            "Событие №1",
            "Событие №2",
            "Событие №3",
            "Событие №4",
            "Событие №5"});
            this.addAfterThis.Location = new System.Drawing.Point(11, 107);
            this.addAfterThis.Margin = new System.Windows.Forms.Padding(4);
            this.addAfterThis.Name = "addAfterThis";
            this.addAfterThis.Size = new System.Drawing.Size(175, 24);
            this.addAfterThis.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 34);
            this.label5.TabIndex = 2;
            this.label5.Text = "Событие, после\r\nкоторого добавляется:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Добавляемое событие:";
            // 
            // addAfterPriority
            // 
            this.addAfterPriority.FormattingEnabled = true;
            this.addAfterPriority.Items.AddRange(new object[] {
            "Наивысший",
            "Ниже нормального",
            "Самый низкий",
            "Высокий",
            "Нормальный",
            "Нет приоритета"});
            this.addAfterPriority.Location = new System.Drawing.Point(8, 160);
            this.addAfterPriority.Margin = new System.Windows.Forms.Padding(4);
            this.addAfterPriority.Name = "addAfterPriority";
            this.addAfterPriority.Size = new System.Drawing.Size(175, 24);
            this.addAfterPriority.TabIndex = 0;
            // 
            // addedAfter
            // 
            this.addedAfter.FormattingEnabled = true;
            this.addedAfter.Items.AddRange(new object[] {
            "Событие №1",
            "Событие №2",
            "Событие №3",
            "Событие №4",
            "Событие №5"});
            this.addedAfter.Location = new System.Drawing.Point(8, 39);
            this.addedAfter.Margin = new System.Windows.Forms.Padding(4);
            this.addedAfter.Name = "addedAfter";
            this.addedAfter.Size = new System.Drawing.Size(175, 24);
            this.addedAfter.TabIndex = 0;
            // 
            // cancelEventBox
            // 
            this.cancelEventBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancelEventBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelEventBox.Controls.Add(this.label7);
            this.cancelEventBox.Controls.Add(this.cancelEvent);
            this.cancelEventBox.Controls.Add(this.cancelOperation);
            this.cancelEventBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelEventBox.Location = new System.Drawing.Point(803, 13);
            this.cancelEventBox.Margin = new System.Windows.Forms.Padding(4);
            this.cancelEventBox.Name = "cancelEventBox";
            this.cancelEventBox.Padding = new System.Windows.Forms.Padding(4);
            this.cancelEventBox.Size = new System.Drawing.Size(198, 114);
            this.cancelEventBox.TabIndex = 4;
            this.cancelEventBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Отменить событие:";
            // 
            // cancelEvent
            // 
            this.cancelEvent.FormattingEnabled = true;
            this.cancelEvent.Items.AddRange(new object[] {
            "Событие №1",
            "Событие №2",
            "Событие №3",
            "Событие №4",
            "Событие №5"});
            this.cancelEvent.Location = new System.Drawing.Point(14, 39);
            this.cancelEvent.Margin = new System.Windows.Forms.Padding(4);
            this.cancelEvent.Name = "cancelEvent";
            this.cancelEvent.Size = new System.Drawing.Size(175, 24);
            this.cancelEvent.TabIndex = 0;
            // 
            // getTimeAndPriorityBox
            // 
            this.getTimeAndPriorityBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.getTimeAndPriorityBox.Controls.Add(this.priorityLabel);
            this.getTimeAndPriorityBox.Controls.Add(this.label10);
            this.getTimeAndPriorityBox.Controls.Add(this.timeLabel);
            this.getTimeAndPriorityBox.Controls.Add(this.label9);
            this.getTimeAndPriorityBox.Controls.Add(this.label8);
            this.getTimeAndPriorityBox.Controls.Add(this.eventGet);
            this.getTimeAndPriorityBox.Controls.Add(this.getOperation);
            this.getTimeAndPriorityBox.Location = new System.Drawing.Point(13, 394);
            this.getTimeAndPriorityBox.Margin = new System.Windows.Forms.Padding(4);
            this.getTimeAndPriorityBox.Name = "getTimeAndPriorityBox";
            this.getTimeAndPriorityBox.Padding = new System.Windows.Forms.Padding(4);
            this.getTimeAndPriorityBox.Size = new System.Drawing.Size(190, 267);
            this.getTimeAndPriorityBox.TabIndex = 5;
            this.getTimeAndPriorityBox.TabStop = false;
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Location = new System.Drawing.Point(8, 190);
            this.priorityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(0, 17);
            this.priorityLabel.TabIndex = 3;
            this.priorityLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 168);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Приоритет:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(9, 135);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 17);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 81);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Время наступления: ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Событие:";
            // 
            // eventGet
            // 
            this.eventGet.FormattingEnabled = true;
            this.eventGet.Items.AddRange(new object[] {
            "Событие №1",
            "Событие №2",
            "Событие №3",
            "Событие №4",
            "Событие №5"});
            this.eventGet.Location = new System.Drawing.Point(0, 36);
            this.eventGet.Margin = new System.Windows.Forms.Padding(4);
            this.eventGet.Name = "eventGet";
            this.eventGet.Size = new System.Drawing.Size(175, 24);
            this.eventGet.TabIndex = 0;
            // 
            // changePriorityBox
            // 
            this.changePriorityBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.changePriorityBox.Controls.Add(this.label13);
            this.changePriorityBox.Controls.Add(this.label12);
            this.changePriorityBox.Controls.Add(this.eventChangePr);
            this.changePriorityBox.Controls.Add(this.label11);
            this.changePriorityBox.Controls.Add(this.changePriorityOperation);
            this.changePriorityBox.Controls.Add(this.priorityToChange);
            this.changePriorityBox.Controls.Add(this.priorityChange);
            this.changePriorityBox.Location = new System.Drawing.Point(211, 394);
            this.changePriorityBox.Margin = new System.Windows.Forms.Padding(4);
            this.changePriorityBox.Name = "changePriorityBox";
            this.changePriorityBox.Padding = new System.Windows.Forms.Padding(4);
            this.changePriorityBox.Size = new System.Drawing.Size(195, 267);
            this.changePriorityBox.TabIndex = 6;
            this.changePriorityBox.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 135);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(170, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Изменить на приоритет:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 68);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 34);
            this.label12.TabIndex = 2;
            this.label12.Text = "Приоритет изменяемого \r\nсобытия:";
            // 
            // eventChangePr
            // 
            this.eventChangePr.FormattingEnabled = true;
            this.eventChangePr.Items.AddRange(new object[] {
            "Событие №1",
            "Событие №2",
            "Событие №3",
            "Событие №4",
            "Событие №5"});
            this.eventChangePr.Location = new System.Drawing.Point(8, 36);
            this.eventChangePr.Margin = new System.Windows.Forms.Padding(4);
            this.eventChangePr.Name = "eventChangePr";
            this.eventChangePr.Size = new System.Drawing.Size(175, 24);
            this.eventChangePr.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 16);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Событие:";
            // 
            // priorityToChange
            // 
            this.priorityToChange.FormattingEnabled = true;
            this.priorityToChange.Items.AddRange(new object[] {
            "Наивысший",
            "Ниже нормального",
            "Самый низкий",
            "Высокий",
            "Нормальный",
            "Нет приоритета"});
            this.priorityToChange.Location = new System.Drawing.Point(11, 159);
            this.priorityToChange.Margin = new System.Windows.Forms.Padding(4);
            this.priorityToChange.Name = "priorityToChange";
            this.priorityToChange.Size = new System.Drawing.Size(175, 24);
            this.priorityToChange.TabIndex = 0;
            // 
            // priorityChange
            // 
            this.priorityChange.FormattingEnabled = true;
            this.priorityChange.Items.AddRange(new object[] {
            "Наивысший",
            "Ниже нормального",
            "Самый низкий",
            "Высокий",
            "Нормальный",
            "Нет приоритета"});
            this.priorityChange.Location = new System.Drawing.Point(8, 103);
            this.priorityChange.Margin = new System.Windows.Forms.Padding(4);
            this.priorityChange.Name = "priorityChange";
            this.priorityChange.Size = new System.Drawing.Size(175, 24);
            this.priorityChange.TabIndex = 0;
            // 
            // calendarInitialize
            // 
            this.calendarInitialize.Controls.Add(this.countEvent);
            this.calendarInitialize.Controls.Add(this.label14);
            this.calendarInitialize.Controls.Add(this.generateOperation);
            this.calendarInitialize.Location = new System.Drawing.Point(13, 254);
            this.calendarInitialize.Margin = new System.Windows.Forms.Padding(4);
            this.calendarInitialize.Name = "calendarInitialize";
            this.calendarInitialize.Padding = new System.Windows.Forms.Padding(4);
            this.calendarInitialize.Size = new System.Drawing.Size(349, 122);
            this.calendarInitialize.TabIndex = 7;
            this.calendarInitialize.TabStop = false;
            // 
            // countEvent
            // 
            this.countEvent.Location = new System.Drawing.Point(234, 37);
            this.countEvent.Margin = new System.Windows.Forms.Padding(4);
            this.countEvent.Name = "countEvent";
            this.countEvent.Size = new System.Drawing.Size(63, 22);
            this.countEvent.TabIndex = 1;
            this.countEvent.Text = "0";
            this.countEvent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.intNumTextHandler);
            this.countEvent.Leave += new System.EventHandler(this.addEventTime_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 37);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "Количество событий:\r\n";
            // 
            // generateOperation
            // 
            this.generateOperation.Location = new System.Drawing.Point(8, 86);
            this.generateOperation.Margin = new System.Windows.Forms.Padding(4);
            this.generateOperation.Name = "generateOperation";
            this.generateOperation.Size = new System.Drawing.Size(125, 28);
            this.generateOperation.TabIndex = 1;
            this.generateOperation.Text = "Сгенерировать";
            this.generateOperation.UseVisualStyleBackColor = true;
            this.generateOperation.Click += new System.EventHandler(this.generateOperation_Click);
            // 
            // CurrentTimeBox
            // 
            this.CurrentTimeBox.Controls.Add(this.timeMs);
            this.CurrentTimeBox.Controls.Add(this.label17);
            this.CurrentTimeBox.Controls.Add(this.label15);
            this.CurrentTimeBox.Controls.Add(this.currentTime);
            this.CurrentTimeBox.Location = new System.Drawing.Point(803, 135);
            this.CurrentTimeBox.Margin = new System.Windows.Forms.Padding(4);
            this.CurrentTimeBox.Name = "CurrentTimeBox";
            this.CurrentTimeBox.Padding = new System.Windows.Forms.Padding(4);
            this.CurrentTimeBox.Size = new System.Drawing.Size(391, 192);
            this.CurrentTimeBox.TabIndex = 8;
            this.CurrentTimeBox.TabStop = false;
            this.CurrentTimeBox.Text = "Время";
            // 
            // timeMs
            // 
            this.timeMs.Location = new System.Drawing.Point(209, 130);
            this.timeMs.Margin = new System.Windows.Forms.Padding(4);
            this.timeMs.Name = "timeMs";
            this.timeMs.Size = new System.Drawing.Size(63, 22);
            this.timeMs.TabIndex = 1;
            this.timeMs.Text = "100";
            this.timeMs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.intNumTextHandler);
            this.timeMs.Leave += new System.EventHandler(this.addEventTime_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 119);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(179, 34);
            this.label17.TabIndex = 2;
            this.label17.Text = "Единица модельного \r\nвремени в миллисекундах\r\n";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label15.Location = new System.Drawing.Point(13, 58);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(158, 34);
            this.label15.TabIndex = 0;
            this.label15.Text = "Текущее модельное\r\n время:";
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.currentTime.Location = new System.Drawing.Point(205, 65);
            this.currentTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(20, 22);
            this.currentTime.TabIndex = 0;
            this.currentTime.Text = "0";
            this.currentTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // demonstateOperation
            // 
            this.demonstateOperation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.demonstateOperation.Location = new System.Drawing.Point(1021, 13);
            this.demonstateOperation.Margin = new System.Windows.Forms.Padding(4);
            this.demonstateOperation.Name = "demonstateOperation";
            this.demonstateOperation.Size = new System.Drawing.Size(173, 81);
            this.demonstateOperation.TabIndex = 1;
            this.demonstateOperation.Text = "Показать";
            this.demonstateOperation.UseVisualStyleBackColor = false;
            this.demonstateOperation.Click += new System.EventHandler(this.demonstateOperation_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1232, 665);
            this.Controls.Add(this.demonstateOperation);
            this.Controls.Add(this.CurrentTimeBox);
            this.Controls.Add(this.calendarInitialize);
            this.Controls.Add(this.addAfterBox);
            this.Controls.Add(this.changePriorityBox);
            this.Controls.Add(this.getTimeAndPriorityBox);
            this.Controls.Add(this.cancelEventBox);
            this.Controls.Add(this.addBox);
            this.Controls.Add(this.calendarTable);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calendarTable)).EndInit();
            this.addBox.ResumeLayout(false);
            this.addBox.PerformLayout();
            this.addAfterBox.ResumeLayout(false);
            this.addAfterBox.PerformLayout();
            this.cancelEventBox.ResumeLayout(false);
            this.cancelEventBox.PerformLayout();
            this.getTimeAndPriorityBox.ResumeLayout(false);
            this.getTimeAndPriorityBox.PerformLayout();
            this.changePriorityBox.ResumeLayout(false);
            this.changePriorityBox.PerformLayout();
            this.calendarInitialize.ResumeLayout(false);
            this.calendarInitialize.PerformLayout();
            this.CurrentTimeBox.ResumeLayout(false);
            this.CurrentTimeBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView calendarTable;
        private System.Windows.Forms.Button addOperation;
        private System.Windows.Forms.Button addAfterOperation;
        private System.Windows.Forms.Button cancelOperation;
        private System.Windows.Forms.Button getOperation;
        private System.Windows.Forms.Button changePriorityOperation;
        private System.Windows.Forms.GroupBox addBox;
        private System.Windows.Forms.TextBox addEventTime;
        private System.Windows.Forms.ComboBox addEventPriority;
        private System.Windows.Forms.ComboBox addEvent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox addAfterBox;
        private System.Windows.Forms.ComboBox addAfterThis;
        private System.Windows.Forms.ComboBox addedAfter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox addAfterPriority;
        private System.Windows.Forms.GroupBox cancelEventBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cancelEvent;
        private System.Windows.Forms.GroupBox getTimeAndPriorityBox;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox eventGet;
        private System.Windows.Forms.GroupBox changePriorityBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox eventChangePr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox priorityChange;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox priorityToChange;
        private System.Windows.Forms.GroupBox calendarInitialize;
        private System.Windows.Forms.TextBox countEvent;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button generateOperation;
        private System.Windows.Forms.GroupBox CurrentTimeBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label currentTime;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox addAfterTime;
        private System.Windows.Forms.TextBox timeMs;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button demonstateOperation;
    }
}

