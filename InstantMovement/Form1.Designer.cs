
namespace InstantMovement
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
            this.buttonDesignUI1 = new InstantMovement.Models.ButtonDesignUI();
            this.buttonDesignUI2 = new InstantMovement.Models.ButtonDesignUI();
            this.buttonDesignUI3 = new InstantMovement.Models.ButtonDesignUI();
            this.SuspendLayout();
            // 
            // buttonDesignUI1
            // 
            this.buttonDesignUI1.BackColor = System.Drawing.Color.Tomato;
            this.buttonDesignUI1.ForeColor = System.Drawing.Color.White;
            this.buttonDesignUI1.Location = new System.Drawing.Point(187, 76);
            this.buttonDesignUI1.Name = "buttonDesignUI1";
            this.buttonDesignUI1.Size = new System.Drawing.Size(150, 40);
            this.buttonDesignUI1.TabIndex = 3;
            this.buttonDesignUI1.Text = "Кликни на цель";
            this.buttonDesignUI1.Click += new System.EventHandler(this.ButtonDesignUI1_Click);
            // 
            // buttonDesignUI2
            // 
            this.buttonDesignUI2.BackColor = System.Drawing.Color.Tomato;
            this.buttonDesignUI2.ForeColor = System.Drawing.Color.White;
            this.buttonDesignUI2.Location = new System.Drawing.Point(187, 135);
            this.buttonDesignUI2.Name = "buttonDesignUI2";
            this.buttonDesignUI2.Size = new System.Drawing.Size(150, 40);
            this.buttonDesignUI2.TabIndex = 4;
            this.buttonDesignUI2.Text = "Сопоставь карточки";
            this.buttonDesignUI2.Click += new System.EventHandler(this.ButtonDesignUI2_Click);
            // 
            // buttonDesignUI3
            // 
            this.buttonDesignUI3.BackColor = System.Drawing.Color.Tomato;
            this.buttonDesignUI3.ForeColor = System.Drawing.Color.White;
            this.buttonDesignUI3.Location = new System.Drawing.Point(187, 193);
            this.buttonDesignUI3.Name = "buttonDesignUI3";
            this.buttonDesignUI3.Size = new System.Drawing.Size(150, 40);
            this.buttonDesignUI3.TabIndex = 5;
            this.buttonDesignUI3.Text = "Сломай фрукт";
            this.buttonDesignUI3.Click += new System.EventHandler(this.ButtonDesignUI3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDesignUI3);
            this.Controls.Add(this.buttonDesignUI2);
            this.Controls.Add(this.buttonDesignUI1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Models.ButtonDesignUI buttonDesignUI1;
        private Models.ButtonDesignUI buttonDesignUI2;
        private Models.ButtonDesignUI buttonDesignUI3;
    }
}

