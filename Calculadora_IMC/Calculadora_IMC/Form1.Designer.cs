namespace Calculadora_IMC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPeso = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtAltura = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox3 = new TextBox();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            Sete = new Button();
            Oito = new Button();
            Nove = new Button();
            Quatro = new Button();
            Cinco = new Button();
            Seis = new Button();
            Um = new Button();
            Dois = new Button();
            Três = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 54);
            label1.Name = "label1";
            label1.Size = new Size(162, 29);
            label1.TabIndex = 0;
            label1.Text = "Cálculo de IMC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(43, 83);
            label2.Name = "label2";
            label2.Size = new Size(184, 19);
            label2.TabIndex = 1;
            label2.Text = "Informe seu Peso e Altura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(5, 118);
            label3.Name = "label3";
            label3.Size = new Size(54, 37);
            label3.TabIndex = 2;
            label3.Text = "⚖";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(61, 135);
            label4.Name = "label4";
            label4.Size = new Size(55, 23);
            label4.TabIndex = 3;
            label4.Text = "Peso:";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(122, 133);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 4;
            txtPeso.Enter += enterPeso;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(228, 133);
            label5.Name = "label5";
            label5.Size = new Size(31, 23);
            label5.TabIndex = 5;
            label5.Text = "Kg";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(9, 155);
            label6.Name = "label6";
            label6.Size = new Size(47, 32);
            label6.TabIndex = 6;
            label6.Text = "📏";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(52, 158);
            label7.Name = "label7";
            label7.Size = new Size(64, 23);
            label7.TabIndex = 7;
            label7.Text = "Altura:";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(122, 162);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 8;
            txtAltura.Enter += enterAltura;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(228, 162);
            label8.Name = "label8";
            label8.Size = new Size(26, 23);
            label8.TabIndex = 9;
            label8.Text = "M";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(12, 187);
            label9.Name = "label9";
            label9.Size = new Size(45, 32);
            label9.TabIndex = 10;
            label9.Text = "📊";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(70, 181);
            label10.Name = "label10";
            label10.Size = new Size(46, 23);
            label10.TabIndex = 11;
            label10.Text = "IMC:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(122, 191);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(12, 243);
            label11.Name = "label11";
            label11.Size = new Size(79, 23);
            label11.TabIndex = 13;
            label11.Text = "Situação";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SaddleBrown;
            pictureBox1.Location = new Point(13, 279);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 344);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Sete
            // 
            Sete.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Sete.Location = new Point(25, 291);
            Sete.Name = "Sete";
            Sete.Size = new Size(75, 74);
            Sete.TabIndex = 15;
            Sete.Text = "7";
            Sete.UseVisualStyleBackColor = true;
            Sete.Click += gerarNumeros;
            // 
            // Oito
            // 
            Oito.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Oito.Location = new Point(106, 291);
            Oito.Name = "Oito";
            Oito.Size = new Size(75, 74);
            Oito.TabIndex = 16;
            Oito.Text = "8";
            Oito.UseVisualStyleBackColor = true;
            Oito.Click += gerarNumeros;
            // 
            // Nove
            // 
            Nove.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Nove.Location = new Point(187, 291);
            Nove.Name = "Nove";
            Nove.Size = new Size(75, 74);
            Nove.TabIndex = 17;
            Nove.Text = "9";
            Nove.UseVisualStyleBackColor = true;
            Nove.Click += gerarNumeros;
            // 
            // Quatro
            // 
            Quatro.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Quatro.Location = new Point(25, 371);
            Quatro.Name = "Quatro";
            Quatro.Size = new Size(75, 74);
            Quatro.TabIndex = 18;
            Quatro.Text = "4";
            Quatro.UseVisualStyleBackColor = true;
            Quatro.Click += gerarNumeros;
            // 
            // Cinco
            // 
            Cinco.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Cinco.Location = new Point(106, 371);
            Cinco.Name = "Cinco";
            Cinco.Size = new Size(75, 74);
            Cinco.TabIndex = 19;
            Cinco.Text = "5";
            Cinco.UseVisualStyleBackColor = true;
            Cinco.Click += gerarNumeros;
            // 
            // Seis
            // 
            Seis.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Seis.Location = new Point(187, 371);
            Seis.Name = "Seis";
            Seis.Size = new Size(75, 74);
            Seis.TabIndex = 20;
            Seis.Text = "6";
            Seis.UseVisualStyleBackColor = true;
            Seis.Click += gerarNumeros;
            // 
            // Um
            // 
            Um.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Um.Location = new Point(25, 451);
            Um.Name = "Um";
            Um.Size = new Size(75, 74);
            Um.TabIndex = 21;
            Um.Text = "1";
            Um.UseVisualStyleBackColor = true;
            Um.Click += gerarNumeros;
            // 
            // Dois
            // 
            Dois.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Dois.Location = new Point(106, 451);
            Dois.Name = "Dois";
            Dois.Size = new Size(75, 74);
            Dois.TabIndex = 22;
            Dois.Text = "2";
            Dois.UseVisualStyleBackColor = true;
            Dois.Click += gerarNumeros;
            // 
            // Três
            // 
            Três.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Três.Location = new Point(187, 451);
            Três.Name = "Três";
            Três.Size = new Size(75, 74);
            Três.TabIndex = 23;
            Três.Text = "3";
            Três.UseVisualStyleBackColor = true;
            Três.Click += gerarNumeros;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(25, 531);
            button10.Name = "button10";
            button10.Size = new Size(75, 74);
            button10.TabIndex = 24;
            button10.Text = ",";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button11.Location = new Point(106, 531);
            button11.Name = "button11";
            button11.Size = new Size(75, 74);
            button11.TabIndex = 25;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = true;
            button11.Click += gerarNumeros;
            // 
            // button12
            // 
            button12.Font = new Font("Candara", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button12.Location = new Point(187, 531);
            button12.Name = "button12";
            button12.Size = new Size(75, 74);
            button12.TabIndex = 26;
            button12.Text = "Del:";
            button12.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(377, 663);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(Três);
            Controls.Add(Dois);
            Controls.Add(Um);
            Controls.Add(Seis);
            Controls.Add(Cinco);
            Controls.Add(Quatro);
            Controls.Add(Nove);
            Controls.Add(Oito);
            Controls.Add(Sete);
            Controls.Add(pictureBox1);
            Controls.Add(label11);
            Controls.Add(textBox3);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtAltura);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtPeso);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPeso;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtAltura;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox3;
        private Label label11;
        private PictureBox pictureBox1;
        private Button Sete;
        private Button Oito;
        private Button Nove;
        private Button Quatro;
        private Button Cinco;
        private Button Seis;
        private Button Um;
        private Button Dois;
        private Button Três;
        private Button button10;
        private Button button11;
        private Button button12;
    }
}