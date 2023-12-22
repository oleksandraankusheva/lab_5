
namespace lab5
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
            this.SquareButton = new System.Windows.Forms.Button();
            this.RhombButton = new System.Windows.Forms.Button();
            this.CircleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SquareButton
            // 
            this.SquareButton.Location = new System.Drawing.Point(558, 162);
            this.SquareButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SquareButton.Name = "SquareButton";
            this.SquareButton.Size = new System.Drawing.Size(223, 60);
            this.SquareButton.TabIndex = 0;
            this.SquareButton.Text = "MoveSquare";
            this.SquareButton.UseVisualStyleBackColor = true;
            this.SquareButton.Click += new System.EventHandler(this.SquareButton_Click);
            // 
            // RhombButton
            // 
            this.RhombButton.Location = new System.Drawing.Point(558, 273);
            this.RhombButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RhombButton.Name = "RhombButton";
            this.RhombButton.Size = new System.Drawing.Size(223, 60);
            this.RhombButton.TabIndex = 1;
            this.RhombButton.Text = "MoveRhomb";
            this.RhombButton.UseVisualStyleBackColor = true;
            this.RhombButton.Click += new System.EventHandler(this.RhombButton_Click);
            // 
            // CircleButton
            // 
            this.CircleButton.Location = new System.Drawing.Point(558, 45);
            this.CircleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(223, 60);
            this.CircleButton.TabIndex = 2;
            this.CircleButton.Text = "MoveCircle";
            this.CircleButton.UseVisualStyleBackColor = true;
            this.CircleButton.Click += new System.EventHandler(this.CircleButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(794, 379);
            this.Controls.Add(this.CircleButton);
            this.Controls.Add(this.RhombButton);
            this.Controls.Add(this.SquareButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SquareButton;
        private System.Windows.Forms.Button RhombButton;
        private System.Windows.Forms.Button CircleButton;
    }
}

