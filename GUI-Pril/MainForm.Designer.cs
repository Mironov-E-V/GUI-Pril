
namespace GUI_Pril
{
    partial class MainForm
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
            this.arrayGrid = new System.Windows.Forms.DataGridView();
            this.InsertTabControl = new System.Windows.Forms.TabControl();
            this.FirstTabPage = new System.Windows.Forms.TabPage();
            this.RandomСheck = new System.Windows.Forms.CheckBox();
            this.InizialButton = new System.Windows.Forms.Button();
            this.ColumnsTextBox = new System.Windows.Forms.TextBox();
            this.RowsTextBox = new System.Windows.Forms.TextBox();
            this.CountColumnsLabel = new System.Windows.Forms.Label();
            this.CountRowsLabel = new System.Windows.Forms.Label();
            this.SecondTabPage = new System.Windows.Forms.TabPage();
            this.SumMainDbutton = new System.Windows.Forms.Button();
            this.SumMainDtextBox = new System.Windows.Forms.TextBox();
            this.SumMainDLabel = new System.Windows.Forms.Label();
            this.TransButton = new System.Windows.Forms.Button();
            this.SumButton = new System.Windows.Forms.Button();
            this.MidButton = new System.Windows.Forms.Button();
            this.MinButton = new System.Windows.Forms.Button();
            this.MaxButton = new System.Windows.Forms.Button();
            this.SumVulueTextBox = new System.Windows.Forms.TextBox();
            this.MidleVulueTextBox = new System.Windows.Forms.TextBox();
            this.MinVulueTextBox = new System.Windows.Forms.TextBox();
            this.MaxVulueTextBox = new System.Windows.Forms.TextBox();
            this.SumVulueLabel = new System.Windows.Forms.Label();
            this.MidleVulueLabel = new System.Windows.Forms.Label();
            this.MinVulueLabel = new System.Windows.Forms.Label();
            this.MaxVulueLabel = new System.Windows.Forms.Label();
            this.SettingPage = new System.Windows.Forms.TabPage();
            this.Interface = new System.Windows.Forms.GroupBox();
            this.WhiteRadioButton = new System.Windows.Forms.RadioButton();
            this.DarkRadioButton = new System.Windows.Forms.RadioButton();
            this.BgColor = new System.Windows.Forms.GroupBox();
            this.BGColorWhiteRadioButton = new System.Windows.Forms.RadioButton();
            this.BGColorGreyRadioButton = new System.Windows.Forms.RadioButton();
            this.BGColorBlackRadioButton = new System.Windows.Forms.RadioButton();
            this.SettingColoreTextArray = new System.Windows.Forms.GroupBox();
            this.WhiteBGRadioButton = new System.Windows.Forms.RadioButton();
            this.GreenBGRadioButton = new System.Windows.Forms.RadioButton();
            this.BlackBGRadioButton = new System.Windows.Forms.RadioButton();
            this.BlurBGRadioButton = new System.Windows.Forms.RadioButton();
            this.CreatorPage = new System.Windows.Forms.TabPage();
            this.CreatorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.arrayGrid)).BeginInit();
            this.InsertTabControl.SuspendLayout();
            this.FirstTabPage.SuspendLayout();
            this.SecondTabPage.SuspendLayout();
            this.SettingPage.SuspendLayout();
            this.Interface.SuspendLayout();
            this.BgColor.SuspendLayout();
            this.SettingColoreTextArray.SuspendLayout();
            this.CreatorPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // arrayGrid
            // 
            this.arrayGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.arrayGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.arrayGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.arrayGrid.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.arrayGrid.Location = new System.Drawing.Point(0, 186);
            this.arrayGrid.Name = "arrayGrid";
            this.arrayGrid.Size = new System.Drawing.Size(800, 264);
            this.arrayGrid.TabIndex = 0;
            // 
            // InsertTabControl
            // 
            this.InsertTabControl.Controls.Add(this.FirstTabPage);
            this.InsertTabControl.Controls.Add(this.SecondTabPage);
            this.InsertTabControl.Controls.Add(this.SettingPage);
            this.InsertTabControl.Controls.Add(this.CreatorPage);
            this.InsertTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.InsertTabControl.Location = new System.Drawing.Point(0, 0);
            this.InsertTabControl.Name = "InsertTabControl";
            this.InsertTabControl.SelectedIndex = 0;
            this.InsertTabControl.Size = new System.Drawing.Size(800, 190);
            this.InsertTabControl.TabIndex = 1;
            // 
            // FirstTabPage
            // 
            this.FirstTabPage.Controls.Add(this.RandomСheck);
            this.FirstTabPage.Controls.Add(this.InizialButton);
            this.FirstTabPage.Controls.Add(this.ColumnsTextBox);
            this.FirstTabPage.Controls.Add(this.RowsTextBox);
            this.FirstTabPage.Controls.Add(this.CountColumnsLabel);
            this.FirstTabPage.Controls.Add(this.CountRowsLabel);
            this.FirstTabPage.Location = new System.Drawing.Point(4, 22);
            this.FirstTabPage.Name = "FirstTabPage";
            this.FirstTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.FirstTabPage.Size = new System.Drawing.Size(792, 164);
            this.FirstTabPage.TabIndex = 0;
            this.FirstTabPage.Text = "Инициализация массива";
            this.FirstTabPage.UseVisualStyleBackColor = true;
            // 
            // RandomСheck
            // 
            this.RandomСheck.AutoSize = true;
            this.RandomСheck.Location = new System.Drawing.Point(252, 44);
            this.RandomСheck.Name = "RandomСheck";
            this.RandomСheck.Size = new System.Drawing.Size(142, 17);
            this.RandomСheck.TabIndex = 5;
            this.RandomСheck.Text = "Случайное заполнение";
            this.RandomСheck.UseVisualStyleBackColor = true;
            // 
            // InizialButton
            // 
            this.InizialButton.Location = new System.Drawing.Point(252, 73);
            this.InizialButton.Name = "InizialButton";
            this.InizialButton.Size = new System.Drawing.Size(142, 41);
            this.InizialButton.TabIndex = 4;
            this.InizialButton.Text = "Инициализация массива";
            this.InizialButton.UseVisualStyleBackColor = true;
            this.InizialButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InizialButton_MouseClick);
            // 
            // ColumnsTextBox
            // 
            this.ColumnsTextBox.Location = new System.Drawing.Point(130, 80);
            this.ColumnsTextBox.Name = "ColumnsTextBox";
            this.ColumnsTextBox.Size = new System.Drawing.Size(100, 20);
            this.ColumnsTextBox.TabIndex = 3;
            this.ColumnsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RowsTextBox_KeyPress);
            // 
            // RowsTextBox
            // 
            this.RowsTextBox.Location = new System.Drawing.Point(130, 45);
            this.RowsTextBox.Name = "RowsTextBox";
            this.RowsTextBox.Size = new System.Drawing.Size(100, 20);
            this.RowsTextBox.TabIndex = 2;
            this.RowsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RowsTextBox_KeyPress);
            // 
            // CountColumnsLabel
            // 
            this.CountColumnsLabel.AutoSize = true;
            this.CountColumnsLabel.Location = new System.Drawing.Point(8, 83);
            this.CountColumnsLabel.Name = "CountColumnsLabel";
            this.CountColumnsLabel.Size = new System.Drawing.Size(116, 13);
            this.CountColumnsLabel.TabIndex = 1;
            this.CountColumnsLabel.Text = "Количество столбцов";
            // 
            // CountRowsLabel
            // 
            this.CountRowsLabel.AutoSize = true;
            this.CountRowsLabel.Location = new System.Drawing.Point(26, 45);
            this.CountRowsLabel.Name = "CountRowsLabel";
            this.CountRowsLabel.Size = new System.Drawing.Size(98, 13);
            this.CountRowsLabel.TabIndex = 0;
            this.CountRowsLabel.Text = "Количество строк";
            // 
            // SecondTabPage
            // 
            this.SecondTabPage.Controls.Add(this.SumMainDbutton);
            this.SecondTabPage.Controls.Add(this.SumMainDtextBox);
            this.SecondTabPage.Controls.Add(this.SumMainDLabel);
            this.SecondTabPage.Controls.Add(this.TransButton);
            this.SecondTabPage.Controls.Add(this.SumButton);
            this.SecondTabPage.Controls.Add(this.MidButton);
            this.SecondTabPage.Controls.Add(this.MinButton);
            this.SecondTabPage.Controls.Add(this.MaxButton);
            this.SecondTabPage.Controls.Add(this.SumVulueTextBox);
            this.SecondTabPage.Controls.Add(this.MidleVulueTextBox);
            this.SecondTabPage.Controls.Add(this.MinVulueTextBox);
            this.SecondTabPage.Controls.Add(this.MaxVulueTextBox);
            this.SecondTabPage.Controls.Add(this.SumVulueLabel);
            this.SecondTabPage.Controls.Add(this.MidleVulueLabel);
            this.SecondTabPage.Controls.Add(this.MinVulueLabel);
            this.SecondTabPage.Controls.Add(this.MaxVulueLabel);
            this.SecondTabPage.Location = new System.Drawing.Point(4, 22);
            this.SecondTabPage.Name = "SecondTabPage";
            this.SecondTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SecondTabPage.Size = new System.Drawing.Size(792, 164);
            this.SecondTabPage.TabIndex = 1;
            this.SecondTabPage.Text = "Вычисления";
            this.SecondTabPage.UseVisualStyleBackColor = true;
            // 
            // SumMainDbutton
            // 
            this.SumMainDbutton.Location = new System.Drawing.Point(339, 123);
            this.SumMainDbutton.Name = "SumMainDbutton";
            this.SumMainDbutton.Size = new System.Drawing.Size(193, 21);
            this.SumMainDbutton.TabIndex = 15;
            this.SumMainDbutton.Text = "Найти сумму главной диагонали";
            this.SumMainDbutton.UseVisualStyleBackColor = true;
            this.SumMainDbutton.Click += new System.EventHandler(this.SumMainDbutton_Click);
            // 
            // SumMainDtextBox
            // 
            this.SumMainDtextBox.Location = new System.Drawing.Point(221, 123);
            this.SumMainDtextBox.Name = "SumMainDtextBox";
            this.SumMainDtextBox.Size = new System.Drawing.Size(100, 20);
            this.SumMainDtextBox.TabIndex = 14;
            // 
            // SumMainDLabel
            // 
            this.SumMainDLabel.AutoSize = true;
            this.SumMainDLabel.Location = new System.Drawing.Point(14, 127);
            this.SumMainDLabel.Name = "SumMainDLabel";
            this.SumMainDLabel.Size = new System.Drawing.Size(141, 13);
            this.SumMainDLabel.TabIndex = 13;
            this.SumMainDLabel.Text = "Сумма главной диагонали";
            // 
            // TransButton
            // 
            this.TransButton.Location = new System.Drawing.Point(614, 6);
            this.TransButton.Name = "TransButton";
            this.TransButton.Size = new System.Drawing.Size(170, 23);
            this.TransButton.TabIndex = 12;
            this.TransButton.Text = "Транспониравать матрицу";
            this.TransButton.UseVisualStyleBackColor = true;
            this.TransButton.Click += new System.EventHandler(this.TransButton_Click);
            // 
            // SumButton
            // 
            this.SumButton.Location = new System.Drawing.Point(338, 96);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(191, 20);
            this.SumButton.TabIndex = 11;
            this.SumButton.Text = "Найти сумму значений массива";
            this.SumButton.UseVisualStyleBackColor = true;
            this.SumButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SumButton_MouseClick);
            // 
            // MidButton
            // 
            this.MidButton.Location = new System.Drawing.Point(339, 65);
            this.MidButton.Name = "MidButton";
            this.MidButton.Size = new System.Drawing.Size(190, 20);
            this.MidButton.TabIndex = 10;
            this.MidButton.Text = "Найти среднее значение";
            this.MidButton.UseVisualStyleBackColor = true;
            this.MidButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MidButton_MouseClick);
            // 
            // MinButton
            // 
            this.MinButton.Location = new System.Drawing.Point(338, 34);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(191, 20);
            this.MinButton.TabIndex = 9;
            this.MinButton.Text = "Найти минимальное значение";
            this.MinButton.UseVisualStyleBackColor = true;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            // 
            // MaxButton
            // 
            this.MaxButton.Location = new System.Drawing.Point(338, 4);
            this.MaxButton.Name = "MaxButton";
            this.MaxButton.Size = new System.Drawing.Size(191, 23);
            this.MaxButton.TabIndex = 8;
            this.MaxButton.Text = "Найти максимальное значение";
            this.MaxButton.UseVisualStyleBackColor = true;
            this.MaxButton.Click += new System.EventHandler(this.MaxButton_Click);
            // 
            // SumVulueTextBox
            // 
            this.SumVulueTextBox.Location = new System.Drawing.Point(220, 97);
            this.SumVulueTextBox.Name = "SumVulueTextBox";
            this.SumVulueTextBox.Size = new System.Drawing.Size(100, 20);
            this.SumVulueTextBox.TabIndex = 7;
            // 
            // MidleVulueTextBox
            // 
            this.MidleVulueTextBox.Location = new System.Drawing.Point(220, 65);
            this.MidleVulueTextBox.Name = "MidleVulueTextBox";
            this.MidleVulueTextBox.Size = new System.Drawing.Size(100, 20);
            this.MidleVulueTextBox.TabIndex = 6;
            // 
            // MinVulueTextBox
            // 
            this.MinVulueTextBox.Location = new System.Drawing.Point(221, 34);
            this.MinVulueTextBox.Name = "MinVulueTextBox";
            this.MinVulueTextBox.Size = new System.Drawing.Size(100, 20);
            this.MinVulueTextBox.TabIndex = 5;
            // 
            // MaxVulueTextBox
            // 
            this.MaxVulueTextBox.Location = new System.Drawing.Point(221, 6);
            this.MaxVulueTextBox.Name = "MaxVulueTextBox";
            this.MaxVulueTextBox.Size = new System.Drawing.Size(100, 20);
            this.MaxVulueTextBox.TabIndex = 4;
            // 
            // SumVulueLabel
            // 
            this.SumVulueLabel.AutoSize = true;
            this.SumVulueLabel.Location = new System.Drawing.Point(14, 97);
            this.SumVulueLabel.Name = "SumVulueLabel";
            this.SumVulueLabel.Size = new System.Drawing.Size(138, 13);
            this.SumVulueLabel.TabIndex = 3;
            this.SumVulueLabel.Text = "Сумма значений массива";
            // 
            // MidleVulueLabel
            // 
            this.MidleVulueLabel.AutoSize = true;
            this.MidleVulueLabel.Location = new System.Drawing.Point(14, 65);
            this.MidleVulueLabel.Name = "MidleVulueLabel";
            this.MidleVulueLabel.Size = new System.Drawing.Size(147, 13);
            this.MidleVulueLabel.TabIndex = 2;
            this.MidleVulueLabel.Text = "Среднее значение массива";
            // 
            // MinVulueLabel
            // 
            this.MinVulueLabel.AutoSize = true;
            this.MinVulueLabel.Location = new System.Drawing.Point(14, 34);
            this.MinVulueLabel.Name = "MinVulueLabel";
            this.MinVulueLabel.Size = new System.Drawing.Size(175, 13);
            this.MinVulueLabel.TabIndex = 1;
            this.MinVulueLabel.Text = "Минимальное значение массива";
            // 
            // MaxVulueLabel
            // 
            this.MaxVulueLabel.AutoSize = true;
            this.MaxVulueLabel.Location = new System.Drawing.Point(14, 6);
            this.MaxVulueLabel.Name = "MaxVulueLabel";
            this.MaxVulueLabel.Size = new System.Drawing.Size(181, 13);
            this.MaxVulueLabel.TabIndex = 0;
            this.MaxVulueLabel.Text = "Максимальное значение массива";
            // 
            // SettingPage
            // 
            this.SettingPage.Controls.Add(this.Interface);
            this.SettingPage.Controls.Add(this.BgColor);
            this.SettingPage.Controls.Add(this.SettingColoreTextArray);
            this.SettingPage.Location = new System.Drawing.Point(4, 22);
            this.SettingPage.Name = "SettingPage";
            this.SettingPage.Size = new System.Drawing.Size(792, 164);
            this.SettingPage.TabIndex = 2;
            this.SettingPage.Text = "Настройки";
            this.SettingPage.UseVisualStyleBackColor = true;
            // 
            // Interface
            // 
            this.Interface.Controls.Add(this.WhiteRadioButton);
            this.Interface.Controls.Add(this.DarkRadioButton);
            this.Interface.Location = new System.Drawing.Point(8, 117);
            this.Interface.Name = "Interface";
            this.Interface.Size = new System.Drawing.Size(334, 46);
            this.Interface.TabIndex = 4;
            this.Interface.TabStop = false;
            this.Interface.Text = "Выбор темы интерфейса";
            // 
            // WhiteRadioButton
            // 
            this.WhiteRadioButton.AutoSize = true;
            this.WhiteRadioButton.Location = new System.Drawing.Point(187, 19);
            this.WhiteRadioButton.Name = "WhiteRadioButton";
            this.WhiteRadioButton.Size = new System.Drawing.Size(95, 17);
            this.WhiteRadioButton.TabIndex = 1;
            this.WhiteRadioButton.TabStop = true;
            this.WhiteRadioButton.Text = "Светлая тема";
            this.WhiteRadioButton.UseVisualStyleBackColor = true;
            this.WhiteRadioButton.CheckedChanged += new System.EventHandler(this.WhiteRadioButton_CheckedChanged);
            // 
            // DarkRadioButton
            // 
            this.DarkRadioButton.AutoSize = true;
            this.DarkRadioButton.Location = new System.Drawing.Point(27, 19);
            this.DarkRadioButton.Name = "DarkRadioButton";
            this.DarkRadioButton.Size = new System.Drawing.Size(92, 17);
            this.DarkRadioButton.TabIndex = 0;
            this.DarkRadioButton.TabStop = true;
            this.DarkRadioButton.Text = "Тёмная тема";
            this.DarkRadioButton.UseVisualStyleBackColor = true;
            this.DarkRadioButton.CheckedChanged += new System.EventHandler(this.DarkRadioButton_CheckedChanged);
            // 
            // BgColor
            // 
            this.BgColor.Controls.Add(this.BGColorWhiteRadioButton);
            this.BgColor.Controls.Add(this.BGColorGreyRadioButton);
            this.BgColor.Controls.Add(this.BGColorBlackRadioButton);
            this.BgColor.Location = new System.Drawing.Point(8, 56);
            this.BgColor.Name = "BgColor";
            this.BgColor.Size = new System.Drawing.Size(335, 55);
            this.BgColor.TabIndex = 3;
            this.BgColor.TabStop = false;
            this.BgColor.Text = "Цвет фона массива";
            // 
            // BGColorWhiteRadioButton
            // 
            this.BGColorWhiteRadioButton.AutoSize = true;
            this.BGColorWhiteRadioButton.Location = new System.Drawing.Point(246, 19);
            this.BGColorWhiteRadioButton.Name = "BGColorWhiteRadioButton";
            this.BGColorWhiteRadioButton.Size = new System.Drawing.Size(58, 17);
            this.BGColorWhiteRadioButton.TabIndex = 2;
            this.BGColorWhiteRadioButton.TabStop = true;
            this.BGColorWhiteRadioButton.Text = "Белый";
            this.BGColorWhiteRadioButton.UseVisualStyleBackColor = true;
            this.BGColorWhiteRadioButton.CheckedChanged += new System.EventHandler(this.BGColorWhiteRadioButton_CheckedChanged);
            // 
            // BGColorGreyRadioButton
            // 
            this.BGColorGreyRadioButton.AutoSize = true;
            this.BGColorGreyRadioButton.Location = new System.Drawing.Point(27, 19);
            this.BGColorGreyRadioButton.Name = "BGColorGreyRadioButton";
            this.BGColorGreyRadioButton.Size = new System.Drawing.Size(58, 17);
            this.BGColorGreyRadioButton.TabIndex = 1;
            this.BGColorGreyRadioButton.TabStop = true;
            this.BGColorGreyRadioButton.Text = "Серый";
            this.BGColorGreyRadioButton.UseVisualStyleBackColor = true;
            this.BGColorGreyRadioButton.CheckedChanged += new System.EventHandler(this.BGColorGreyRadioButton_CheckedChanged);
            // 
            // BGColorBlackRadioButton
            // 
            this.BGColorBlackRadioButton.AutoSize = true;
            this.BGColorBlackRadioButton.Location = new System.Drawing.Point(125, 19);
            this.BGColorBlackRadioButton.Name = "BGColorBlackRadioButton";
            this.BGColorBlackRadioButton.Size = new System.Drawing.Size(65, 17);
            this.BGColorBlackRadioButton.TabIndex = 0;
            this.BGColorBlackRadioButton.TabStop = true;
            this.BGColorBlackRadioButton.Text = "Чёрный";
            this.BGColorBlackRadioButton.UseVisualStyleBackColor = true;
            this.BGColorBlackRadioButton.CheckedChanged += new System.EventHandler(this.BGColorBlackRadioButton_CheckedChanged);
            // 
            // SettingColoreTextArray
            // 
            this.SettingColoreTextArray.Controls.Add(this.WhiteBGRadioButton);
            this.SettingColoreTextArray.Controls.Add(this.GreenBGRadioButton);
            this.SettingColoreTextArray.Controls.Add(this.BlackBGRadioButton);
            this.SettingColoreTextArray.Controls.Add(this.BlurBGRadioButton);
            this.SettingColoreTextArray.Location = new System.Drawing.Point(8, 3);
            this.SettingColoreTextArray.Name = "SettingColoreTextArray";
            this.SettingColoreTextArray.Size = new System.Drawing.Size(459, 47);
            this.SettingColoreTextArray.TabIndex = 2;
            this.SettingColoreTextArray.TabStop = false;
            this.SettingColoreTextArray.Text = "Выбор цвета текста миссива";
            // 
            // WhiteBGRadioButton
            // 
            this.WhiteBGRadioButton.AutoSize = true;
            this.WhiteBGRadioButton.Location = new System.Drawing.Point(347, 17);
            this.WhiteBGRadioButton.Name = "WhiteBGRadioButton";
            this.WhiteBGRadioButton.Size = new System.Drawing.Size(58, 17);
            this.WhiteBGRadioButton.TabIndex = 4;
            this.WhiteBGRadioButton.TabStop = true;
            this.WhiteBGRadioButton.Text = "Белый";
            this.WhiteBGRadioButton.UseVisualStyleBackColor = true;
            this.WhiteBGRadioButton.CheckedChanged += new System.EventHandler(this.WhiteBGRadioButton_CheckedChanged);
            // 
            // GreenBGRadioButton
            // 
            this.GreenBGRadioButton.AutoSize = true;
            this.GreenBGRadioButton.Location = new System.Drawing.Point(248, 17);
            this.GreenBGRadioButton.Name = "GreenBGRadioButton";
            this.GreenBGRadioButton.Size = new System.Drawing.Size(71, 17);
            this.GreenBGRadioButton.TabIndex = 3;
            this.GreenBGRadioButton.TabStop = true;
            this.GreenBGRadioButton.Text = "ЗелЁный";
            this.GreenBGRadioButton.UseVisualStyleBackColor = true;
            this.GreenBGRadioButton.CheckedChanged += new System.EventHandler(this.GreenBGRadioButton_CheckedChanged);
            // 
            // BlackBGRadioButton
            // 
            this.BlackBGRadioButton.AutoSize = true;
            this.BlackBGRadioButton.Location = new System.Drawing.Point(125, 17);
            this.BlackBGRadioButton.Name = "BlackBGRadioButton";
            this.BlackBGRadioButton.Size = new System.Drawing.Size(65, 17);
            this.BlackBGRadioButton.TabIndex = 2;
            this.BlackBGRadioButton.TabStop = true;
            this.BlackBGRadioButton.Text = "Черный";
            this.BlackBGRadioButton.UseVisualStyleBackColor = true;
            this.BlackBGRadioButton.CheckedChanged += new System.EventHandler(this.BlackBGRadioButton_CheckedChanged_1);
            // 
            // BlurBGRadioButton
            // 
            this.BlurBGRadioButton.AutoSize = true;
            this.BlurBGRadioButton.Location = new System.Drawing.Point(29, 17);
            this.BlurBGRadioButton.Name = "BlurBGRadioButton";
            this.BlurBGRadioButton.Size = new System.Drawing.Size(56, 17);
            this.BlurBGRadioButton.TabIndex = 1;
            this.BlurBGRadioButton.TabStop = true;
            this.BlurBGRadioButton.Text = "Синий";
            this.BlurBGRadioButton.UseVisualStyleBackColor = true;
            this.BlurBGRadioButton.CheckedChanged += new System.EventHandler(this.BlurBGRadioButton_CheckedChanged);
            // 
            // CreatorPage
            // 
            this.CreatorPage.Controls.Add(this.CreatorLabel);
            this.CreatorPage.Location = new System.Drawing.Point(4, 22);
            this.CreatorPage.Name = "CreatorPage";
            this.CreatorPage.Size = new System.Drawing.Size(792, 164);
            this.CreatorPage.TabIndex = 3;
            this.CreatorPage.Text = "Справка";
            this.CreatorPage.UseVisualStyleBackColor = true;
            // 
            // CreatorLabel
            // 
            this.CreatorLabel.AutoSize = true;
            this.CreatorLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatorLabel.Location = new System.Drawing.Point(95, 70);
            this.CreatorLabel.Name = "CreatorLabel";
            this.CreatorLabel.Size = new System.Drawing.Size(566, 27);
            this.CreatorLabel.TabIndex = 0;
            this.CreatorLabel.Text = "Работу выполнил Миронов Е.В. студент 28-тп группы";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InsertTabControl);
            this.Controls.Add(this.arrayGrid);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно";
            ((System.ComponentModel.ISupportInitialize)(this.arrayGrid)).EndInit();
            this.InsertTabControl.ResumeLayout(false);
            this.FirstTabPage.ResumeLayout(false);
            this.FirstTabPage.PerformLayout();
            this.SecondTabPage.ResumeLayout(false);
            this.SecondTabPage.PerformLayout();
            this.SettingPage.ResumeLayout(false);
            this.Interface.ResumeLayout(false);
            this.Interface.PerformLayout();
            this.BgColor.ResumeLayout(false);
            this.BgColor.PerformLayout();
            this.SettingColoreTextArray.ResumeLayout(false);
            this.SettingColoreTextArray.PerformLayout();
            this.CreatorPage.ResumeLayout(false);
            this.CreatorPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView arrayGrid;
        private System.Windows.Forms.TabControl InsertTabControl;
        private System.Windows.Forms.TabPage FirstTabPage;
        private System.Windows.Forms.TabPage SecondTabPage;
        private System.Windows.Forms.Button InizialButton;
        private System.Windows.Forms.TextBox ColumnsTextBox;
        private System.Windows.Forms.TextBox RowsTextBox;
        private System.Windows.Forms.Label CountColumnsLabel;
        private System.Windows.Forms.Label CountRowsLabel;
        private System.Windows.Forms.CheckBox RandomСheck;
        private System.Windows.Forms.Label MidleVulueLabel;
        private System.Windows.Forms.Label MinVulueLabel;
        private System.Windows.Forms.Label MaxVulueLabel;
        private System.Windows.Forms.Label SumVulueLabel;
        private System.Windows.Forms.TextBox SumVulueTextBox;
        private System.Windows.Forms.TextBox MidleVulueTextBox;
        private System.Windows.Forms.TextBox MinVulueTextBox;
        private System.Windows.Forms.TextBox MaxVulueTextBox;
        private System.Windows.Forms.Button MaxButton;
        private System.Windows.Forms.Button SumButton;
        private System.Windows.Forms.Button MidButton;
        private System.Windows.Forms.Button MinButton;
        private System.Windows.Forms.TabPage SettingPage;
        private System.Windows.Forms.GroupBox SettingColoreTextArray;
        private System.Windows.Forms.RadioButton GreenBGRadioButton;
        private System.Windows.Forms.RadioButton BlackBGRadioButton;
        private System.Windows.Forms.RadioButton BlurBGRadioButton;
        private System.Windows.Forms.GroupBox BgColor;
        private System.Windows.Forms.RadioButton BGColorWhiteRadioButton;
        private System.Windows.Forms.RadioButton BGColorGreyRadioButton;
        private System.Windows.Forms.RadioButton BGColorBlackRadioButton;
        private System.Windows.Forms.TabPage CreatorPage;
        private System.Windows.Forms.Label CreatorLabel;
        private System.Windows.Forms.GroupBox Interface;
        private System.Windows.Forms.RadioButton DarkRadioButton;
        private System.Windows.Forms.RadioButton WhiteRadioButton;
        private System.Windows.Forms.RadioButton WhiteBGRadioButton;
        private System.Windows.Forms.Button TransButton;
        private System.Windows.Forms.Button SumMainDbutton;
        private System.Windows.Forms.TextBox SumMainDtextBox;
        private System.Windows.Forms.Label SumMainDLabel;
    }
}

