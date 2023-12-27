namespace sdxl_turbo_0._1_beta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.promp = new System.Windows.Forms.TextBox();
            this.generate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.picture_result = new System.Windows.Forms.PictureBox();
            this.picture_input = new System.Windows.Forms.PictureBox();
            this.lb_u = new System.Windows.Forms.Label();
            this.lb_no_u = new System.Windows.Forms.Label();
            this.lb_warning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_input)).BeginInit();
            this.SuspendLayout();
            // 
            // promp
            // 
            this.promp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.promp.Location = new System.Drawing.Point(90, 441);
            this.promp.Name = "promp";
            this.promp.Size = new System.Drawing.Size(314, 24);
            this.promp.TabIndex = 0;
            // 
            // generate
            // 
            this.generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generate.Location = new System.Drawing.Point(481, 428);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(129, 47);
            this.generate.TabIndex = 3;
            this.generate.Text = "Генерировать";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Промп:";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_save.Location = new System.Drawing.Point(736, 428);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(120, 47);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_copy
            // 
            this.btn_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_copy.Location = new System.Drawing.Point(616, 428);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(114, 47);
            this.btn_copy.TabIndex = 3;
            this.btn_copy.Text = "Копировать";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // picture_result
            // 
            this.picture_result.Image = global::sdxl_turbo_0._1_beta.Properties.Resources.results;
            this.picture_result.Location = new System.Drawing.Point(481, 55);
            this.picture_result.Name = "picture_result";
            this.picture_result.Size = new System.Drawing.Size(375, 345);
            this.picture_result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_result.TabIndex = 2;
            this.picture_result.TabStop = false;
            // 
            // picture_input
            // 
            this.picture_input.Image = global::sdxl_turbo_0._1_beta.Properties.Resources.simple;
            this.picture_input.Location = new System.Drawing.Point(29, 55);
            this.picture_input.Name = "picture_input";
            this.picture_input.Size = new System.Drawing.Size(375, 345);
            this.picture_input.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_input.TabIndex = 2;
            this.picture_input.TabStop = false;
            this.picture_input.Click += new System.EventHandler(this.SelectPhoto);
            // 
            // lb_u
            // 
            this.lb_u.AutoSize = true;
            this.lb_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_u.Location = new System.Drawing.Point(26, 36);
            this.lb_u.Name = "lb_u";
            this.lb_u.Size = new System.Drawing.Size(81, 16);
            this.lb_u.TabIndex = 5;
            this.lb_u.Text = "Ваше фото:";
            // 
            // lb_no_u
            // 
            this.lb_no_u.AutoSize = true;
            this.lb_no_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_no_u.Location = new System.Drawing.Point(478, 36);
            this.lb_no_u.Name = "lb_no_u";
            this.lb_no_u.Size = new System.Drawing.Size(153, 16);
            this.lb_no_u.TabIndex = 5;
            this.lb_no_u.Text = "Результат обработки:";
            // 
            // lb_warning
            // 
            this.lb_warning.AutoSize = true;
            this.lb_warning.Location = new System.Drawing.Point(102, 468);
            this.lb_warning.Name = "lb_warning";
            this.lb_warning.Size = new System.Drawing.Size(269, 13);
            this.lb_warning.TabIndex = 6;
            this.lb_warning.Text = "Примечание: Пишите ваши промпы на английском!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 505);
            this.Controls.Add(this.lb_warning);
            this.Controls.Add(this.lb_no_u);
            this.Controls.Add(this.lb_u);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.picture_result);
            this.Controls.Add(this.picture_input);
            this.Controls.Add(this.promp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "sdxl turbo 1.0 beta";
            ((System.ComponentModel.ISupportInitialize)(this.picture_result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox promp;
        private System.Windows.Forms.PictureBox picture_input;
        private System.Windows.Forms.PictureBox picture_result;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Label lb_u;
        private System.Windows.Forms.Label lb_no_u;
        private System.Windows.Forms.Label lb_warning;
    }
}

