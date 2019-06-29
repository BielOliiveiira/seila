namespace Fahrenheit
{
    partial class Form1
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
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.rdbCelsiuspfahr = new System.Windows.Forms.RadioButton();
            this.rdbFahrenheitpCelsius = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(36, 26);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(100, 20);
            this.txtCelsius.TabIndex = 0;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(48, 141);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(75, 23);
            this.btnConverter.TabIndex = 1;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cº";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fº";
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(36, 52);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.txtFahrenheit.TabIndex = 4;
            // 
            // rdbCelsiuspfahr
            // 
            this.rdbCelsiuspfahr.AutoSize = true;
            this.rdbCelsiuspfahr.Location = new System.Drawing.Point(15, 84);
            this.rdbCelsiuspfahr.Name = "rdbCelsiuspfahr";
            this.rdbCelsiuspfahr.Size = new System.Drawing.Size(135, 17);
            this.rdbCelsiuspfahr.TabIndex = 5;
            this.rdbCelsiuspfahr.TabStop = true;
            this.rdbCelsiuspfahr.Text = "Celsius para Fahrenheit";
            this.rdbCelsiuspfahr.UseVisualStyleBackColor = true;
            this.rdbCelsiuspfahr.CheckedChanged += new System.EventHandler(this.rdbCelsiuspfahr_CheckedChanged);
            // 
            // rdbFahrenheitpCelsius
            // 
            this.rdbFahrenheitpCelsius.AutoSize = true;
            this.rdbFahrenheitpCelsius.Location = new System.Drawing.Point(16, 107);
            this.rdbFahrenheitpCelsius.Name = "rdbFahrenheitpCelsius";
            this.rdbFahrenheitpCelsius.Size = new System.Drawing.Size(135, 17);
            this.rdbFahrenheitpCelsius.TabIndex = 6;
            this.rdbFahrenheitpCelsius.TabStop = true;
            this.rdbFahrenheitpCelsius.Text = "Fahrenheit para Celsius";
            this.rdbFahrenheitpCelsius.UseVisualStyleBackColor = true;
            this.rdbFahrenheitpCelsius.CheckedChanged += new System.EventHandler(this.rdbFahrenheitpCelsius_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 201);
            this.Controls.Add(this.rdbFahrenheitpCelsius);
            this.Controls.Add(this.rdbCelsiuspfahr);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtCelsius);
            this.Name = "Form1";
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.RadioButton rdbCelsiuspfahr;
        private System.Windows.Forms.RadioButton rdbFahrenheitpCelsius;
    }
}

