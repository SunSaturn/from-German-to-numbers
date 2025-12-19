namespace Nem
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
            this.bt1 = new System.Windows.Forms.Button();
            this.numberWas = new System.Windows.Forms.TextBox();
            this.numberRes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt1.Location = new System.Drawing.Point(26, 84);
            this.bt1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(186, 53);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "Перевод";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // numberWas
            // 
            this.numberWas.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberWas.Location = new System.Drawing.Point(26, 31);
            this.numberWas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numberWas.Name = "numberWas";
            this.numberWas.Size = new System.Drawing.Size(513, 38);
            this.numberWas.TabIndex = 1;
            // 
            // numberRes
            // 
            this.numberRes.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberRes.Location = new System.Drawing.Point(462, 90);
            this.numberRes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numberRes.Name = "numberRes";
            this.numberRes.Size = new System.Drawing.Size(77, 38);
            this.numberRes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Число на немецком языке:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(339, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Результат:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(595, 283);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberRes);
            this.Controls.Add(this.numberWas);
            this.Controls.Add(this.bt1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "ДЗ1";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button bt1;
    private System.Windows.Forms.TextBox numberWas;
    private System.Windows.Forms.TextBox numberRes;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
  }
}

