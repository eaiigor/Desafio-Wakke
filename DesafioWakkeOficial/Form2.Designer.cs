namespace DesafioWakkeOficial
{
    partial class Form2
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
            this.altura_box = new System.Windows.Forms.NumericUpDown();
            this.nascimento_box = new System.Windows.Forms.DateTimePicker();
            this.id_box = new System.Windows.Forms.Label();
            this.radioInativo = new System.Windows.Forms.RadioButton();
            this.radioAtivo = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sobrenome_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nome_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.altura_box)).BeginInit();
            this.SuspendLayout();
            // 
            // altura_box
            // 
            this.altura_box.DecimalPlaces = 2;
            this.altura_box.Location = new System.Drawing.Point(346, 237);
            this.altura_box.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.altura_box.Name = "altura_box";
            this.altura_box.Size = new System.Drawing.Size(120, 23);
            this.altura_box.TabIndex = 63;
            // 
            // nascimento_box
            // 
            this.nascimento_box.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nascimento_box.Location = new System.Drawing.Point(30, 237);
            this.nascimento_box.Name = "nascimento_box";
            this.nascimento_box.Size = new System.Drawing.Size(280, 23);
            this.nascimento_box.TabIndex = 62;
            // 
            // id_box
            // 
            this.id_box.BackColor = System.Drawing.SystemColors.ControlLight;
            this.id_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_box.Location = new System.Drawing.Point(30, 121);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(100, 23);
            this.id_box.TabIndex = 61;
            // 
            // radioInativo
            // 
            this.radioInativo.AutoSize = true;
            this.radioInativo.Location = new System.Drawing.Point(585, 237);
            this.radioInativo.Name = "radioInativo";
            this.radioInativo.Size = new System.Drawing.Size(61, 19);
            this.radioInativo.TabIndex = 60;
            this.radioInativo.TabStop = true;
            this.radioInativo.Text = "Inativo";
            this.radioInativo.UseVisualStyleBackColor = true;
            // 
            // radioAtivo
            // 
            this.radioAtivo.AutoSize = true;
            this.radioAtivo.Location = new System.Drawing.Point(526, 238);
            this.radioAtivo.Name = "radioAtivo";
            this.radioAtivo.Size = new System.Drawing.Size(53, 19);
            this.radioAtivo.TabIndex = 59;
            this.radioAtivo.TabStop = true;
            this.radioAtivo.Text = "Ativo";
            this.radioAtivo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(526, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 19);
            this.label7.TabIndex = 58;
            this.label7.Text = "Situação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(30, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 19);
            this.label6.TabIndex = 57;
            this.label6.Text = "Data nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(348, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 56;
            this.label5.Text = "Altura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(347, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 55;
            this.label4.Text = "Sobrenome";
            // 
            // sobrenome_box
            // 
            this.sobrenome_box.Location = new System.Drawing.Point(346, 175);
            this.sobrenome_box.Name = "sobrenome_box";
            this.sobrenome_box.Size = new System.Drawing.Size(397, 23);
            this.sobrenome_box.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 53;
            this.label3.Text = "Nome";
            // 
            // nome_box
            // 
            this.nome_box.Location = new System.Drawing.Point(30, 175);
            this.nome_box.Name = "nome_box";
            this.nome_box.Size = new System.Drawing.Size(280, 23);
            this.nome_box.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 19);
            this.label2.TabIndex = 51;
            this.label2.Text = "ID";
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(668, 305);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 50;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Informações pessoais";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(781, 351);
            this.Controls.Add(this.altura_box);
            this.Controls.Add(this.nascimento_box);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.radioInativo);
            this.Controls.Add(this.radioAtivo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sobrenome_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nome_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.altura_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown altura_box;
        private DateTimePicker nascimento_box;
        private Label id_box;
        private RadioButton radioInativo;
        private RadioButton radioAtivo;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox sobrenome_box;
        private Label label3;
        private TextBox nome_box;
        private Label label2;
        private Button btn_salvar;
        private Label label1;
    }
}