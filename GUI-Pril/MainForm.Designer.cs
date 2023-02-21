
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GreenBGRadioButton = new System.Windows.Forms.RadioButton();
            this.BlackBGRadioButton = new System.Windows.Forms.RadioButton();
            this.BlurBGRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.arrayGrid)).BeginInit();
            this.InsertTabControl.SuspendLayout();
            this.FirstTabPage.SuspendLayout();
            this.SecondTabPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.InsertTabControl.Controls.Add(this.tabPage1);
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
            // SumButton
            // 
            this.SumButton.Location = new System.Drawing.Point(374, 126);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(191, 20);
            this.SumButton.TabIndex = 11;
            this.SumButton.Text = "Найти сумму значений массива";
            this.SumButton.UseVisualStyleBackColor = true;
            this.SumButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SumButton_MouseClick);
            // 
            // MidButton
            // 
            this.MidButton.Location = new System.Drawing.Point(375, 95);
            this.MidButton.Name = "MidButton";
            this.MidButton.Size = new System.Drawing.Size(190, 20);
            this.MidButton.TabIndex = 10;
            this.MidButton.Text = "Найти среднее значение";
            this.MidButton.UseVisualStyleBackColor = true;
            this.MidButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MidButton_MouseClick);
            // 
            // MinButton
            // 
            this.MinButton.Location = new System.Drawing.Point(374, 64);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(191, 20);
            this.MinButton.TabIndex = 9;
            this.MinButton.Text = "Найти минимальное значение";
            this.MinButton.UseVisualStyleBackColor = true;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            // 
            // MaxButton
            // 
            this.MaxButton.Location = new System.Drawing.Point(374, 34);
            this.MaxButton.Name = "MaxButton";
            this.MaxButton.Size = new System.Drawing.Size(191, 23);
            this.MaxButton.TabIndex = 8;
            this.MaxButton.Text = "Найти максимальное значение";
            this.MaxButton.UseVisualStyleBackColor = true;
            this.MaxButton.Click += new System.EventHandler(this.MaxButton_Click);
            // 
            // SumVulueTextBox
            // 
            this.SumVulueTextBox.Location = new System.Drawing.Point(256, 127);
            this.SumVulueTextBox.Name = "SumVulueTextBox";
            this.SumVulueTextBox.Size = new System.Drawing.Size(100, 20);
            this.SumVulueTextBox.TabIndex = 7;
            // 
            // MidleVulueTextBox
            // 
            this.MidleVulueTextBox.Location = new System.Drawing.Point(256, 95);
            this.MidleVulueTextBox.Name = "MidleVulueTextBox";
            this.MidleVulueTextBox.Size = new System.Drawing.Size(100, 20);
            this.MidleVulueTextBox.TabIndex = 6;
            // 
            // MinVulueTextBox
            // 
            this.MinVulueTextBox.Location = new System.Drawing.Point(257, 64);
            this.MinVulueTextBox.Name = "MinVulueTextBox";
            this.MinVulueTextBox.Size = new System.Drawing.Size(100, 20);
            this.MinVulueTextBox.TabIndex = 5;
            // 
            // MaxVulueTextBox
            // 
            this.MaxVulueTextBox.Location = new System.Drawing.Point(257, 36);
            this.MaxVulueTextBox.Name = "MaxVulueTextBox";
            this.MaxVulueTextBox.Size = new System.Drawing.Size(100, 20);
            this.MaxVulueTextBox.TabIndex = 4;
            this.MaxVulueTextBox.TextChanged += new System.EventHandler(this.MaxVulueTextBox_TextChanged);
            // 
            // SumVulueLabel
            // 
            this.SumVulueLabel.AutoSize = true;
            this.SumVulueLabel.Location = new System.Drawing.Point(50, 127);
            this.SumVulueLabel.Name = "SumVulueLabel";
            this.SumVulueLabel.Size = new System.Drawing.Size(138, 13);
            this.SumVulueLabel.TabIndex = 3;
            this.SumVulueLabel.Text = "Сумма значений массива";
            // 
            // MidleVulueLabel
            // 
            this.MidleVulueLabel.AutoSize = true;
            this.MidleVulueLabel.Location = new System.Drawing.Point(50, 95);
            this.MidleVulueLabel.Name = "MidleVulueLabel";
            this.MidleVulueLabel.Size = new System.Drawing.Size(147, 13);
            this.MidleVulueLabel.TabIndex = 2;
            this.MidleVulueLabel.Text = "Среднее значение массива";
            // 
            // MinVulueLabel
            // 
            this.MinVulueLabel.AutoSize = true;
            this.MinVulueLabel.Location = new System.Drawing.Point(50, 64);
            this.MinVulueLabel.Name = "MinVulueLabel";
            this.MinVulueLabel.Size = new System.Drawing.Size(175, 13);
            this.MinVulueLabel.TabIndex = 1;
            this.MinVulueLabel.Text = "Минимальное значение массива";
            // 
            // MaxVulueLabel
            // 
            this.MaxVulueLabel.AutoSize = true;
            this.MaxVulueLabel.Location = new System.Drawing.Point(50, 36);
            this.MaxVulueLabel.Name = "MaxVulueLabel";
            this.MaxVulueLabel.Size = new System.Drawing.Size(181, 13);
            this.MaxVulueLabel.TabIndex = 0;
            this.MaxVulueLabel.Text = "Максимальное значение массива";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(792, 164);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "r";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GreenBGRadioButton);
            this.groupBox1.Controls.Add(this.BlackBGRadioButton);
            this.groupBox1.Controls.Add(this.BlurBGRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 47);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор цвета текста миссива";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InsertTabControl);
            this.Controls.Add(this.arrayGrid);
            this.Name = "MainForm";
            this.Text = "Главное окно";
            ((System.ComponentModel.ISupportInitialize)(this.arrayGrid)).EndInit();
            this.InsertTabControl.ResumeLayout(false);
            this.FirstTabPage.ResumeLayout(false);
            this.FirstTabPage.PerformLayout();
            this.SecondTabPage.ResumeLayout(false);
            this.SecondTabPage.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton GreenBGRadioButton;
        private System.Windows.Forms.RadioButton BlackBGRadioButton;
        private System.Windows.Forms.RadioButton BlurBGRadioButton;
    }
}

