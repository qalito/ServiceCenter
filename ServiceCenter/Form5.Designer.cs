namespace ServiceCenter
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label описаниеLabel;
            System.Windows.Forms.Label дата_Label;
            System.Windows.Forms.Label приёмщикLabel;
            System.Windows.Forms.Label статусLabel;
            System.Windows.Forms.Label код_устройстваLabel1;
            System.Windows.Forms.Label типLabel;
            System.Windows.Forms.Label производительLabel;
            System.Windows.Forms.Label модельLabel;
            System.Windows.Forms.Label серийный_номерLabel;
            System.Windows.Forms.Label код_заказчикаLabel1;
            System.Windows.Forms.Label заказчикLabel;
            System.Windows.Forms.Label контактыLabel;
            System.Windows.Forms.Label статусыLabel;
            System.Windows.Forms.Label гарантийныйLabel;
            System.Windows.Forms.Label код_заказчикаLabel;
            System.Windows.Forms.Label код_устройстваLabel;
            System.Windows.Forms.Label актLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.актTextBox = new System.Windows.Forms.TextBox();
            this.receptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new ServiceCenter.Database1DataSet();
            this.код_устройстваTextBox = new System.Windows.Forms.TextBox();
            this.код_заказчикаTextBox = new System.Windows.Forms.TextBox();
            this.гарантийныйTextBox = new System.Windows.Forms.TextBox();
            this.описаниеTextBox = new System.Windows.Forms.TextBox();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.приёмщикTextBox = new System.Windows.Forms.TextBox();
            this.статусTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.код_заказчикаTextBox1 = new System.Windows.Forms.TextBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказчикTextBox = new System.Windows.Forms.TextBox();
            this.контактыTextBox = new System.Windows.Forms.TextBox();
            this.статусыTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.код_устройстваTextBox1 = new System.Windows.Forms.TextBox();
            this.deviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.типTextBox = new System.Windows.Forms.TextBox();
            this.производительTextBox = new System.Windows.Forms.TextBox();
            this.модельTextBox = new System.Windows.Forms.TextBox();
            this.серийный_номерTextBox = new System.Windows.Forms.TextBox();
            this.receptionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.tableAdapterManager = new ServiceCenter.Database1DataSetTableAdapters.TableAdapterManager();
            this.clientsTableAdapter = new ServiceCenter.Database1DataSetTableAdapters.ClientsTableAdapter();
            this.deviceTableAdapter = new ServiceCenter.Database1DataSetTableAdapters.DeviceTableAdapter();
            this.receptionTableAdapter = new ServiceCenter.Database1DataSetTableAdapters.ReceptionTableAdapter();
            this.button15 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиИзУчётнойЗаписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиИзПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            описаниеLabel = new System.Windows.Forms.Label();
            дата_Label = new System.Windows.Forms.Label();
            приёмщикLabel = new System.Windows.Forms.Label();
            статусLabel = new System.Windows.Forms.Label();
            код_устройстваLabel1 = new System.Windows.Forms.Label();
            типLabel = new System.Windows.Forms.Label();
            производительLabel = new System.Windows.Forms.Label();
            модельLabel = new System.Windows.Forms.Label();
            серийный_номерLabel = new System.Windows.Forms.Label();
            код_заказчикаLabel1 = new System.Windows.Forms.Label();
            заказчикLabel = new System.Windows.Forms.Label();
            контактыLabel = new System.Windows.Forms.Label();
            статусыLabel = new System.Windows.Forms.Label();
            гарантийныйLabel = new System.Windows.Forms.Label();
            код_заказчикаLabel = new System.Windows.Forms.Label();
            код_устройстваLabel = new System.Windows.Forms.Label();
            актLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // описаниеLabel
            // 
            описаниеLabel.AutoSize = true;
            описаниеLabel.Location = new System.Drawing.Point(22, 237);
            описаниеLabel.Name = "описаниеLabel";
            описаниеLabel.Size = new System.Drawing.Size(84, 19);
            описаниеLabel.TabIndex = 22;
            описаниеLabel.Text = "Описание:";
            // 
            // дата_Label
            // 
            дата_Label.AutoSize = true;
            дата_Label.Location = new System.Drawing.Point(22, 323);
            дата_Label.Name = "дата_Label";
            дата_Label.Size = new System.Drawing.Size(57, 19);
            дата_Label.TabIndex = 24;
            дата_Label.Text = "Дата :";
            // 
            // приёмщикLabel
            // 
            приёмщикLabel.AutoSize = true;
            приёмщикLabel.Location = new System.Drawing.Point(22, 354);
            приёмщикLabel.Name = "приёмщикLabel";
            приёмщикLabel.Size = new System.Drawing.Size(91, 19);
            приёмщикLabel.TabIndex = 26;
            приёмщикLabel.Text = "Приёмщик:";
            // 
            // статусLabel
            // 
            статусLabel.AutoSize = true;
            статусLabel.Location = new System.Drawing.Point(22, 386);
            статусLabel.Name = "статусLabel";
            статусLabel.Size = new System.Drawing.Size(71, 19);
            статусLabel.TabIndex = 28;
            статусLabel.Text = "Статус:";
            // 
            // код_устройстваLabel1
            // 
            код_устройстваLabel1.AutoSize = true;
            код_устройстваLabel1.Location = new System.Drawing.Point(6, 24);
            код_устройстваLabel1.Name = "код_устройстваLabel1";
            код_устройстваLabel1.Size = new System.Drawing.Size(117, 17);
            код_устройстваLabel1.TabIndex = 0;
            код_устройстваLabel1.Text = "Код устройства:";
            // 
            // типLabel
            // 
            типLabel.AutoSize = true;
            типLabel.Location = new System.Drawing.Point(9, 50);
            типLabel.Name = "типLabel";
            типLabel.Size = new System.Drawing.Size(38, 17);
            типLabel.TabIndex = 2;
            типLabel.Text = "Тип:";
            // 
            // производительLabel
            // 
            производительLabel.AutoSize = true;
            производительLabel.Location = new System.Drawing.Point(9, 79);
            производительLabel.Name = "производительLabel";
            производительLabel.Size = new System.Drawing.Size(110, 17);
            производительLabel.TabIndex = 4;
            производительLabel.Text = "Производитель:";
            // 
            // модельLabel
            // 
            модельLabel.AutoSize = true;
            модельLabel.Location = new System.Drawing.Point(9, 111);
            модельLabel.Name = "модельLabel";
            модельLabel.Size = new System.Drawing.Size(58, 17);
            модельLabel.TabIndex = 6;
            модельLabel.Text = "Модель:";
            // 
            // серийный_номерLabel
            // 
            серийный_номерLabel.AutoSize = true;
            серийный_номерLabel.Location = new System.Drawing.Point(9, 137);
            серийный_номерLabel.Name = "серийный_номерLabel";
            серийный_номерLabel.Size = new System.Drawing.Size(118, 17);
            серийный_номерLabel.TabIndex = 8;
            серийный_номерLabel.Text = "Серийный номер:";
            // 
            // код_заказчикаLabel1
            // 
            код_заказчикаLabel1.AutoSize = true;
            код_заказчикаLabel1.Location = new System.Drawing.Point(11, 21);
            код_заказчикаLabel1.Name = "код_заказчикаLabel1";
            код_заказчикаLabel1.Size = new System.Drawing.Size(100, 17);
            код_заказчикаLabel1.TabIndex = 0;
            код_заказчикаLabel1.Text = "Код заказчика:";
            // 
            // заказчикLabel
            // 
            заказчикLabel.AutoSize = true;
            заказчикLabel.Location = new System.Drawing.Point(11, 53);
            заказчикLabel.Name = "заказчикLabel";
            заказчикLabel.Size = new System.Drawing.Size(68, 17);
            заказчикLabel.TabIndex = 2;
            заказчикLabel.Text = "Заказчик:";
            // 
            // контактыLabel
            // 
            контактыLabel.AutoSize = true;
            контактыLabel.Location = new System.Drawing.Point(11, 82);
            контактыLabel.Name = "контактыLabel";
            контактыLabel.Size = new System.Drawing.Size(85, 17);
            контактыLabel.TabIndex = 4;
            контактыLabel.Text = "Контакты:";
            // 
            // статусыLabel
            // 
            статусыLabel.AutoSize = true;
            статусыLabel.Location = new System.Drawing.Point(11, 114);
            статусыLabel.Name = "статусыLabel";
            статусыLabel.Size = new System.Drawing.Size(75, 17);
            статусыLabel.TabIndex = 6;
            статусыLabel.Text = "Статусы:";
            // 
            // гарантийныйLabel
            // 
            гарантийныйLabel.AutoSize = true;
            гарантийныйLabel.Location = new System.Drawing.Point(22, 204);
            гарантийныйLabel.Name = "гарантийныйLabel";
            гарантийныйLabel.Size = new System.Drawing.Size(116, 19);
            гарантийныйLabel.TabIndex = 20;
            гарантийныйLabel.Text = "Гарантийный:";
            // 
            // код_заказчикаLabel
            // 
            код_заказчикаLabel.AutoSize = true;
            код_заказчикаLabel.Location = new System.Drawing.Point(22, 137);
            код_заказчикаLabel.Name = "код_заказчикаLabel";
            код_заказчикаLabel.Size = new System.Drawing.Size(77, 19);
            код_заказчикаLabel.TabIndex = 18;
            код_заказчикаLabel.Text = "Заказчик:";
            // 
            // код_устройстваLabel
            // 
            код_устройстваLabel.AutoSize = true;
            код_устройстваLabel.Location = new System.Drawing.Point(22, 64);
            код_устройстваLabel.Name = "код_устройстваLabel";
            код_устройстваLabel.Size = new System.Drawing.Size(102, 19);
            код_устройстваLabel.TabIndex = 16;
            код_устройстваLabel.Text = "Устройство:";
            // 
            // актLabel
            // 
            актLabel.AutoSize = true;
            актLabel.Location = new System.Drawing.Point(25, 30);
            актLabel.Name = "актLabel";
            актLabel.Size = new System.Drawing.Size(68, 19);
            актLabel.TabIndex = 39;
            актLabel.Text = "№Актa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вход выполнен!\r\nУчётная запись: ServiceWorker!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.актTextBox);
            this.groupBox1.Controls.Add(this.код_устройстваTextBox);
            this.groupBox1.Controls.Add(this.код_заказчикаTextBox);
            this.groupBox1.Controls.Add(this.гарантийныйTextBox);
            this.groupBox1.Controls.Add(this.описаниеTextBox);
            this.groupBox1.Controls.Add(this.датаDateTimePicker);
            this.groupBox1.Controls.Add(this.приёмщикTextBox);
            this.groupBox1.Controls.Add(this.статусTextBox);
            this.groupBox1.Controls.Add(актLabel);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(код_устройстваLabel);
            this.groupBox1.Controls.Add(код_заказчикаLabel);
            this.groupBox1.Controls.Add(гарантийныйLabel);
            this.groupBox1.Controls.Add(описаниеLabel);
            this.groupBox1.Controls.Add(дата_Label);
            this.groupBox1.Controls.Add(приёмщикLabel);
            this.groupBox1.Controls.Add(статусLabel);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(738, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 553);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите информацию...";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(121, 471);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(164, 26);
            this.button11.TabIndex = 57;
            this.button11.Text = "Отмена";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 56;
            this.label4.Text = "Заказ принят!";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(29, 439);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(164, 29);
            this.button10.TabIndex = 55;
            this.button10.Text = "Печать";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // актTextBox
            // 
            this.актTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receptionBindingSource, "Акт", true));
            this.актTextBox.Location = new System.Drawing.Point(157, 31);
            this.актTextBox.Name = "актTextBox";
            this.актTextBox.ReadOnly = true;
            this.актTextBox.Size = new System.Drawing.Size(200, 26);
            this.актTextBox.TabIndex = 40;
            // 
            // receptionBindingSource
            // 
            this.receptionBindingSource.DataMember = "Reception";
            this.receptionBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // код_устройстваTextBox
            // 
            this.код_устройстваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receptionBindingSource, "Код_устройства", true));
            this.код_устройстваTextBox.Location = new System.Drawing.Point(157, 63);
            this.код_устройстваTextBox.Name = "код_устройстваTextBox";
            this.код_устройстваTextBox.Size = new System.Drawing.Size(200, 26);
            this.код_устройстваTextBox.TabIndex = 42;
            // 
            // код_заказчикаTextBox
            // 
            this.код_заказчикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receptionBindingSource, "Код_заказчика", true));
            this.код_заказчикаTextBox.Location = new System.Drawing.Point(157, 130);
            this.код_заказчикаTextBox.Name = "код_заказчикаTextBox";
            this.код_заказчикаTextBox.Size = new System.Drawing.Size(200, 26);
            this.код_заказчикаTextBox.TabIndex = 44;
            // 
            // гарантийныйTextBox
            // 
            this.гарантийныйTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receptionBindingSource, "Гарантийный", true));
            this.гарантийныйTextBox.Location = new System.Drawing.Point(157, 202);
            this.гарантийныйTextBox.Name = "гарантийныйTextBox";
            this.гарантийныйTextBox.Size = new System.Drawing.Size(200, 26);
            this.гарантийныйTextBox.TabIndex = 46;
            // 
            // описаниеTextBox
            // 
            this.описаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receptionBindingSource, "Описание", true));
            this.описаниеTextBox.Location = new System.Drawing.Point(157, 234);
            this.описаниеTextBox.Multiline = true;
            this.описаниеTextBox.Name = "описаниеTextBox";
            this.описаниеTextBox.Size = new System.Drawing.Size(200, 77);
            this.описаниеTextBox.TabIndex = 48;
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.receptionBindingSource, "Дата", true));
            this.датаDateTimePicker.Location = new System.Drawing.Point(157, 317);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.датаDateTimePicker.TabIndex = 50;
            // 
            // приёмщикTextBox
            // 
            this.приёмщикTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receptionBindingSource, "Приёмщик", true));
            this.приёмщикTextBox.Location = new System.Drawing.Point(157, 351);
            this.приёмщикTextBox.Name = "приёмщикTextBox";
            this.приёмщикTextBox.ReadOnly = true;
            this.приёмщикTextBox.Size = new System.Drawing.Size(200, 26);
            this.приёмщикTextBox.TabIndex = 52;
            // 
            // статусTextBox
            // 
            this.статусTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receptionBindingSource, "Статус", true));
            this.статусTextBox.Location = new System.Drawing.Point(157, 383);
            this.статусTextBox.Name = "статусTextBox";
            this.статусTextBox.ReadOnly = true;
            this.статусTextBox.Size = new System.Drawing.Size(200, 26);
            this.статусTextBox.TabIndex = 54;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button4.Location = new System.Drawing.Point(157, 97);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 29);
            this.button4.TabIndex = 35;
            this.button4.Text = "Добавить/Просмотреть";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button3.Location = new System.Drawing.Point(157, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 29);
            this.button3.TabIndex = 34;
            this.button3.Text = "Добавить/Просмотреть";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Принять заказ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.Location = new System.Drawing.Point(6, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 26);
            this.button2.TabIndex = 4;
            this.button2.Text = "Оформить заказ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1134, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 44);
            this.label2.TabIndex = 5;
            this.label2.Text = "Вход выполнен!\r\nУчётная запись: ServiceWorker!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(86, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 22);
            this.label3.TabIndex = 6;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button13);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(код_заказчикаLabel1);
            this.groupBox2.Controls.Add(this.код_заказчикаTextBox1);
            this.groupBox2.Controls.Add(заказчикLabel);
            this.groupBox2.Controls.Add(this.заказчикTextBox);
            this.groupBox2.Controls.Add(контактыLabel);
            this.groupBox2.Controls.Add(this.контактыTextBox);
            this.groupBox2.Controls.Add(статусыLabel);
            this.groupBox2.Controls.Add(this.статусыTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox2.Location = new System.Drawing.Point(469, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 165);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Заказчик...";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(0, 134);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(96, 23);
            this.button13.TabIndex = 10;
            this.button13.Text = "Отмена";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(103, 134);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Внести изменения";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // код_заказчикаTextBox1
            // 
            this.код_заказчикаTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Код_заказчика", true));
            this.код_заказчикаTextBox1.Location = new System.Drawing.Point(130, 18);
            this.код_заказчикаTextBox1.Name = "код_заказчикаTextBox1";
            this.код_заказчикаTextBox1.ReadOnly = true;
            this.код_заказчикаTextBox1.Size = new System.Drawing.Size(118, 23);
            this.код_заказчикаTextBox1.TabIndex = 1;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.database1DataSet;
            // 
            // заказчикTextBox
            // 
            this.заказчикTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Заказчик", true));
            this.заказчикTextBox.Location = new System.Drawing.Point(130, 47);
            this.заказчикTextBox.Name = "заказчикTextBox";
            this.заказчикTextBox.Size = new System.Drawing.Size(118, 23);
            this.заказчикTextBox.TabIndex = 3;
            // 
            // контактыTextBox
            // 
            this.контактыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Контакты", true));
            this.контактыTextBox.Location = new System.Drawing.Point(130, 76);
            this.контактыTextBox.Name = "контактыTextBox";
            this.контактыTextBox.Size = new System.Drawing.Size(118, 23);
            this.контактыTextBox.TabIndex = 5;
            // 
            // статусыTextBox
            // 
            this.статусыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Статусы", true));
            this.статусыTextBox.Location = new System.Drawing.Point(130, 105);
            this.статусыTextBox.Name = "статусыTextBox";
            this.статусыTextBox.Size = new System.Drawing.Size(118, 23);
            this.статусыTextBox.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.button14);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(код_устройстваLabel1);
            this.groupBox3.Controls.Add(this.код_устройстваTextBox1);
            this.groupBox3.Controls.Add(типLabel);
            this.groupBox3.Controls.Add(this.типTextBox);
            this.groupBox3.Controls.Add(производительLabel);
            this.groupBox3.Controls.Add(this.производительTextBox);
            this.groupBox3.Controls.Add(модельLabel);
            this.groupBox3.Controls.Add(this.модельTextBox);
            this.groupBox3.Controls.Add(серийный_номерLabel);
            this.groupBox3.Controls.Add(this.серийный_номерTextBox);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox3.Location = new System.Drawing.Point(201, 336);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 192);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Устройство...";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(0, 162);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(96, 23);
            this.button14.TabIndex = 11;
            this.button14.Text = "Отмена";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(103, 163);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(145, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Внести изменения";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // код_устройстваTextBox1
            // 
            this.код_устройстваTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceBindingSource, "Код_устройства", true));
            this.код_устройстваTextBox1.Location = new System.Drawing.Point(130, 18);
            this.код_устройстваTextBox1.Name = "код_устройстваTextBox1";
            this.код_устройстваTextBox1.ReadOnly = true;
            this.код_устройстваTextBox1.Size = new System.Drawing.Size(118, 23);
            this.код_устройстваTextBox1.TabIndex = 1;
            // 
            // deviceBindingSource
            // 
            this.deviceBindingSource.DataMember = "Device";
            this.deviceBindingSource.DataSource = this.database1DataSet;
            // 
            // типTextBox
            // 
            this.типTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceBindingSource, "Тип", true));
            this.типTextBox.Location = new System.Drawing.Point(130, 47);
            this.типTextBox.Name = "типTextBox";
            this.типTextBox.Size = new System.Drawing.Size(118, 23);
            this.типTextBox.TabIndex = 3;
            // 
            // производительTextBox
            // 
            this.производительTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceBindingSource, "Производитель", true));
            this.производительTextBox.Location = new System.Drawing.Point(130, 76);
            this.производительTextBox.Name = "производительTextBox";
            this.производительTextBox.Size = new System.Drawing.Size(118, 23);
            this.производительTextBox.TabIndex = 5;
            // 
            // модельTextBox
            // 
            this.модельTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceBindingSource, "Модель", true));
            this.модельTextBox.Location = new System.Drawing.Point(130, 105);
            this.модельTextBox.Name = "модельTextBox";
            this.модельTextBox.Size = new System.Drawing.Size(118, 23);
            this.модельTextBox.TabIndex = 7;
            // 
            // серийный_номерTextBox
            // 
            this.серийный_номерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deviceBindingSource, "Серийный_номер", true));
            this.серийный_номерTextBox.Location = new System.Drawing.Point(130, 134);
            this.серийный_номерTextBox.Name = "серийный_номерTextBox";
            this.серийный_номерTextBox.Size = new System.Drawing.Size(118, 23);
            this.серийный_номерTextBox.TabIndex = 9;
            // 
            // receptionDataGridView
            // 
            this.receptionDataGridView.AutoGenerateColumns = false;
            this.receptionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receptionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.receptionDataGridView.DataSource = this.receptionBindingSource;
            this.receptionDataGridView.Location = new System.Drawing.Point(287, 189);
            this.receptionDataGridView.Name = "receptionDataGridView";
            this.receptionDataGridView.ReadOnly = true;
            this.receptionDataGridView.Size = new System.Drawing.Size(445, 98);
            this.receptionDataGridView.TabIndex = 9;
            this.receptionDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Акт";
            this.dataGridViewTextBoxColumn10.HeaderText = "Акт";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Код_устройства";
            this.dataGridViewTextBoxColumn11.HeaderText = "Код_устройства";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Код_заказчика";
            this.dataGridViewTextBoxColumn12.HeaderText = "Код_заказчика";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Гарантийный";
            this.dataGridViewTextBoxColumn13.HeaderText = "Гарантийный";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Описание";
            this.dataGridViewTextBoxColumn14.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn16.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Приёмщик";
            this.dataGridViewTextBoxColumn17.HeaderText = "Приёмщик";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Статус";
            this.dataGridViewTextBoxColumn18.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // deviceDataGridView
            // 
            this.deviceDataGridView.AutoGenerateColumns = false;
            this.deviceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deviceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.deviceDataGridView.DataSource = this.deviceBindingSource;
            this.deviceDataGridView.Location = new System.Drawing.Point(287, 27);
            this.deviceDataGridView.Name = "deviceDataGridView";
            this.deviceDataGridView.ReadOnly = true;
            this.deviceDataGridView.Size = new System.Drawing.Size(445, 87);
            this.deviceDataGridView.TabIndex = 9;
            this.deviceDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_устройства";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код_устройства";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Тип";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Производитель";
            this.dataGridViewTextBoxColumn3.HeaderText = "Производитель";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Модель";
            this.dataGridViewTextBoxColumn4.HeaderText = "Модель";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Серийный_номер";
            this.dataGridViewTextBoxColumn5.HeaderText = "Серийный_номер";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // clientsDataGridView
            // 
            this.clientsDataGridView.AutoGenerateColumns = false;
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.clientsDataGridView.DataSource = this.clientsBindingSource;
            this.clientsDataGridView.Location = new System.Drawing.Point(287, 113);
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.ReadOnly = true;
            this.clientsDataGridView.Size = new System.Drawing.Size(445, 80);
            this.clientsDataGridView.TabIndex = 9;
            this.clientsDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Код_заказчика";
            this.dataGridViewTextBoxColumn6.HeaderText = "Код_заказчика";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Заказчик";
            this.dataGridViewTextBoxColumn7.HeaderText = "Заказчик";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Контакты";
            this.dataGridViewTextBoxColumn8.HeaderText = "Контакты";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Статусы";
            this.dataGridViewTextBoxColumn9.HeaderText = "Статусы";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(12, 83);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(241, 250);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Действия...";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(6, 45);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(226, 26);
            this.button9.TabIndex = 7;
            this.button9.Text = "Заказы";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 103);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(226, 26);
            this.button8.TabIndex = 6;
            this.button8.Text = "Просмотреть устройства";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 74);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(226, 26);
            this.button7.TabIndex = 5;
            this.button7.Text = "Просмотреть заказчиков";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.button12);
            this.groupBox5.Location = new System.Drawing.Point(12, 126);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(209, 121);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Закрытие заказа... Введите №Акта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Заказ закрыт!";
            this.label5.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBox1.Location = new System.Drawing.Point(6, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 23);
            this.textBox1.TabIndex = 9;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(10, 88);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(187, 26);
            this.button12.TabIndex = 8;
            this.button12.Text = "Закрыть заказ";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorizationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DeviceTableAdapter = null;
            this.tableAdapterManager.ReceptionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ServiceCenter.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkTableAdapter = null;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // deviceTableAdapter
            // 
            this.deviceTableAdapter.ClearBeforeFill = true;
            // 
            // receptionTableAdapter
            // 
            this.receptionTableAdapter.ClearBeforeFill = true;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button15.Location = new System.Drawing.Point(6, 487);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(189, 30);
            this.button15.TabIndex = 24;
            this.button15.Text = "Выйти из учётной записи";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 340);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1114, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1114, 24);
            this.menuStrip2.TabIndex = 27;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкуToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.открытьToolStripMenuItem.Text = "Открыть...";
            // 
            // справкуToolStripMenuItem
            // 
            this.справкуToolStripMenuItem.Name = "справкуToolStripMenuItem";
            this.справкуToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.справкуToolStripMenuItem.Text = "Справку";
            this.справкуToolStripMenuItem.Click += new System.EventHandler(this.справкуToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиИзУчётнойЗаписиToolStripMenuItem,
            this.выйтиИзПрограммыToolStripMenuItem});
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            // 
            // выйтиИзУчётнойЗаписиToolStripMenuItem
            // 
            this.выйтиИзУчётнойЗаписиToolStripMenuItem.Name = "выйтиИзУчётнойЗаписиToolStripMenuItem";
            this.выйтиИзУчётнойЗаписиToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.выйтиИзУчётнойЗаписиToolStripMenuItem.Text = "Выйти из учётной записи";
            this.выйтиИзУчётнойЗаписиToolStripMenuItem.Click += new System.EventHandler(this.выйтиИзУчётнойЗаписиToolStripMenuItem_Click);
            // 
            // выйтиИзПрограммыToolStripMenuItem
            // 
            this.выйтиИзПрограммыToolStripMenuItem.Name = "выйтиИзПрограммыToolStripMenuItem";
            this.выйтиИзПрограммыToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.выйтиИзПрограммыToolStripMenuItem.Text = "Выйти из программы";
            this.выйтиИзПрограммыToolStripMenuItem.Click += new System.EventHandler(this.выйтиИзПрограммыToolStripMenuItem_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1114, 531);
            this.Controls.Add(this.receptionDataGridView);
            this.Controls.Add(this.clientsDataGridView);
            this.Controls.Add(this.deviceDataGridView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip2;
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сервис";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form5_FormClosing);
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource receptionBindingSource;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource deviceBindingSource;
        private System.Windows.Forms.TextBox код_устройстваTextBox1;
        private System.Windows.Forms.TextBox типTextBox;
        private System.Windows.Forms.TextBox производительTextBox;
        private System.Windows.Forms.TextBox модельTextBox;
        private System.Windows.Forms.TextBox серийный_номерTextBox;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private Database1DataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.TextBox заказчикTextBox;
        private System.Windows.Forms.TextBox контактыTextBox;
        private System.Windows.Forms.TextBox статусыTextBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox код_заказчикаTextBox1;
        private Database1DataSetTableAdapters.DeviceTableAdapter deviceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.TextBox актTextBox;
        private System.Windows.Forms.TextBox код_устройстваTextBox;
        private System.Windows.Forms.TextBox код_заказчикаTextBox;
        private System.Windows.Forms.TextBox гарантийныйTextBox;
        private System.Windows.Forms.TextBox описаниеTextBox;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private System.Windows.Forms.TextBox приёмщикTextBox;
        private System.Windows.Forms.TextBox статусTextBox;
        private Database1DataSetTableAdapters.ReceptionTableAdapter receptionTableAdapter;
        private System.Windows.Forms.DataGridView receptionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridView deviceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиИзУчётнойЗаписиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиИзПрограммыToolStripMenuItem;
    }
}