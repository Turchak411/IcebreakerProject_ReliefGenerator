namespace ReliefGenerator
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
            this.button_createField = new System.Windows.Forms.Button();
            this.groupBox_params = new System.Windows.Forms.GroupBox();
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.label_y_info = new System.Windows.Forms.Label();
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.label_x_info = new System.Windows.Forms.Label();
            this.panel_field = new System.Windows.Forms.Panel();
            this.label_depth_info = new System.Windows.Forms.Label();
            this.textBox_depth = new System.Windows.Forms.TextBox();
            this.button_saveMap = new System.Windows.Forms.Button();
            this.groupBox_params.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_createField
            // 
            this.button_createField.Location = new System.Drawing.Point(13, 71);
            this.button_createField.Name = "button_createField";
            this.button_createField.Size = new System.Drawing.Size(138, 23);
            this.button_createField.TabIndex = 0;
            this.button_createField.Text = "Create field";
            this.button_createField.UseVisualStyleBackColor = true;
            this.button_createField.Click += new System.EventHandler(this.button_createField_Click);
            // 
            // groupBox_params
            // 
            this.groupBox_params.Controls.Add(this.textBox_y);
            this.groupBox_params.Controls.Add(this.label_y_info);
            this.groupBox_params.Controls.Add(this.textBox_x);
            this.groupBox_params.Controls.Add(this.button_createField);
            this.groupBox_params.Controls.Add(this.label_x_info);
            this.groupBox_params.Location = new System.Drawing.Point(12, 12);
            this.groupBox_params.Name = "groupBox_params";
            this.groupBox_params.Size = new System.Drawing.Size(166, 106);
            this.groupBox_params.TabIndex = 1;
            this.groupBox_params.TabStop = false;
            this.groupBox_params.Text = "Input field options:";
            // 
            // textBox_y
            // 
            this.textBox_y.Location = new System.Drawing.Point(51, 45);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.Size = new System.Drawing.Size(100, 20);
            this.textBox_y.TabIndex = 3;
            // 
            // label_y_info
            // 
            this.label_y_info.AutoSize = true;
            this.label_y_info.Location = new System.Drawing.Point(10, 48);
            this.label_y_info.Name = "label_y_info";
            this.label_y_info.Size = new System.Drawing.Size(17, 13);
            this.label_y_info.TabIndex = 2;
            this.label_y_info.Text = "Y:";
            // 
            // textBox_x
            // 
            this.textBox_x.Location = new System.Drawing.Point(51, 19);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(100, 20);
            this.textBox_x.TabIndex = 1;
            // 
            // label_x_info
            // 
            this.label_x_info.AutoSize = true;
            this.label_x_info.Location = new System.Drawing.Point(10, 22);
            this.label_x_info.Name = "label_x_info";
            this.label_x_info.Size = new System.Drawing.Size(17, 13);
            this.label_x_info.TabIndex = 0;
            this.label_x_info.Text = "X:";
            // 
            // panel_field
            // 
            this.panel_field.AutoSize = true;
            this.panel_field.Location = new System.Drawing.Point(184, 18);
            this.panel_field.Name = "panel_field";
            this.panel_field.Size = new System.Drawing.Size(604, 420);
            this.panel_field.TabIndex = 2;
            // 
            // label_depth_info
            // 
            this.label_depth_info.AutoSize = true;
            this.label_depth_info.Location = new System.Drawing.Point(53, 127);
            this.label_depth_info.Name = "label_depth_info";
            this.label_depth_info.Size = new System.Drawing.Size(39, 13);
            this.label_depth_info.TabIndex = 4;
            this.label_depth_info.Text = "Depth:";
            // 
            // textBox_depth
            // 
            this.textBox_depth.Location = new System.Drawing.Point(93, 124);
            this.textBox_depth.Name = "textBox_depth";
            this.textBox_depth.Size = new System.Drawing.Size(35, 20);
            this.textBox_depth.TabIndex = 4;
            this.textBox_depth.Text = "10";
            // 
            // button_saveMap
            // 
            this.button_saveMap.Location = new System.Drawing.Point(12, 415);
            this.button_saveMap.Name = "button_saveMap";
            this.button_saveMap.Size = new System.Drawing.Size(166, 23);
            this.button_saveMap.TabIndex = 5;
            this.button_saveMap.Text = "Save map";
            this.button_saveMap.UseVisualStyleBackColor = true;
            this.button_saveMap.Click += new System.EventHandler(this.button_saveMap_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_saveMap);
            this.Controls.Add(this.textBox_depth);
            this.Controls.Add(this.label_depth_info);
            this.Controls.Add(this.panel_field);
            this.Controls.Add(this.groupBox_params);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Relief Generator v0.1";
            this.groupBox_params.ResumeLayout(false);
            this.groupBox_params.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_createField;
        private System.Windows.Forms.GroupBox groupBox_params;
        private System.Windows.Forms.TextBox textBox_y;
        private System.Windows.Forms.Label label_y_info;
        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.Label label_x_info;
        private System.Windows.Forms.Panel panel_field;
        private System.Windows.Forms.Label label_depth_info;
        private System.Windows.Forms.TextBox textBox_depth;
        private System.Windows.Forms.Button button_saveMap;
    }
}

