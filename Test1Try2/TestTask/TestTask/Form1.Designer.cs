﻿namespace TestTask
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
            this.TrollingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TrollingButton
            // 
            this.TrollingButton.BackColor = System.Drawing.Color.Red;
            this.TrollingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrollingButton.ForeColor = System.Drawing.Color.White;
            this.TrollingButton.Location = new System.Drawing.Point(0, 1);
            this.TrollingButton.Name = "TrollingButton";
            this.TrollingButton.Size = new System.Drawing.Size(400, 553);
            this.TrollingButton.TabIndex = 0;
            this.TrollingButton.Text = "Press Me";
            this.TrollingButton.UseVisualStyleBackColor = false;
            this.TrollingButton.Click += new System.EventHandler(this.RunningButton_Click);
            this.TrollingButton.MouseEnter += new System.EventHandler(this.RunningButton_MouseEnter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.TrollingButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TrollingButton;
    }
}

