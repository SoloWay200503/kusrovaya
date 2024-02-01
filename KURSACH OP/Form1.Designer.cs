namespace KURSACH_OP
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonGeneration = new System.Windows.Forms.Button();
            this.buttonOtvet = new System.Windows.Forms.Button();
            this.pictureBoxGraphs = new System.Windows.Forms.PictureBox();
            this.textBoxOtvet = new System.Windows.Forms.TextBox();
            this.buttonGraphs2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraphs)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGeneration
            // 
            this.buttonGeneration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGeneration.Location = new System.Drawing.Point(72, 124);
            this.buttonGeneration.Name = "buttonGeneration";
            this.buttonGeneration.Size = new System.Drawing.Size(192, 32);
            this.buttonGeneration.TabIndex = 0;
            this.buttonGeneration.Text = "Выбор вершин";
            this.buttonGeneration.UseVisualStyleBackColor = true;
            this.buttonGeneration.Click += new System.EventHandler(this.buttonGeneration_Click_1);
            // 
            // buttonOtvet
            // 
            this.buttonOtvet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOtvet.Location = new System.Drawing.Point(72, 162);
            this.buttonOtvet.Name = "buttonOtvet";
            this.buttonOtvet.Size = new System.Drawing.Size(192, 32);
            this.buttonOtvet.TabIndex = 1;
            this.buttonOtvet.Text = "Поиск маршрута";
            this.buttonOtvet.UseVisualStyleBackColor = true;
            this.buttonOtvet.Click += new System.EventHandler(this.buttonOtvet_Click_1);
            // 
            // pictureBoxGraphs
            // 
            this.pictureBoxGraphs.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxGraphs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxGraphs.BackgroundImage")));
            this.pictureBoxGraphs.Location = new System.Drawing.Point(328, 12);
            this.pictureBoxGraphs.Name = "pictureBoxGraphs";
            this.pictureBoxGraphs.Size = new System.Drawing.Size(375, 375);
            this.pictureBoxGraphs.TabIndex = 2;
            this.pictureBoxGraphs.TabStop = false;
            this.pictureBoxGraphs.Click += new System.EventHandler(this.pictureBoxGraphs_Click_1);
            // 
            // textBoxOtvet
            // 
            this.textBoxOtvet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOtvet.Location = new System.Drawing.Point(22, 200);
            this.textBoxOtvet.Multiline = true;
            this.textBoxOtvet.Name = "textBoxOtvet";
            this.textBoxOtvet.Size = new System.Drawing.Size(291, 111);
            this.textBoxOtvet.TabIndex = 3;
            // 
            // buttonGraphs2
            // 
            this.buttonGraphs2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGraphs2.Location = new System.Drawing.Point(72, 317);
            this.buttonGraphs2.Name = "buttonGraphs2";
            this.buttonGraphs2.Size = new System.Drawing.Size(192, 32);
            this.buttonGraphs2.TabIndex = 4;
            this.buttonGraphs2.Text = "Построение маршрута";
            this.buttonGraphs2.UseVisualStyleBackColor = true;
            this.buttonGraphs2.Click += new System.EventHandler(this.buttonGraphs2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(50, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 100);
            this.label2.TabIndex = 6;
            this.label2.Text = "Алгоритм \r\nближайшего соседа \r\nв задаче \r\nкоммивояжера";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(72, 355);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(192, 32);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Сохранить рисунок";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click_1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 402);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.pictureBoxGraphs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGraphs2);
            this.Controls.Add(this.textBoxOtvet);
            this.Controls.Add(this.buttonOtvet);
            this.Controls.Add(this.buttonGeneration);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Решение задачи коммивояжера";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraphs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGeneration;
        private System.Windows.Forms.Button buttonOtvet;
        public System.Windows.Forms.PictureBox pictureBoxGraphs;
        private System.Windows.Forms.TextBox textBoxOtvet;
        private System.Windows.Forms.Button buttonGraphs2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSave;
    }
}

