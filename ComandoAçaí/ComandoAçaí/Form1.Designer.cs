namespace ComandoAçaí
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label1 = new Label();
            textBox1 = new TextBox();
            listBoxItensPedido = new ListBox();
            textBox2 = new TextBox();
            listBoxCorberturas = new ListBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            listBoxFrutas = new ListBox();
            button1 = new Button();
            label2 = new Label();
            radioButton300mL = new RadioButton();
            radioButton500mL = new RadioButton();
            radioButton700mL = new RadioButton();
            radioButton1L = new RadioButton();
            radioButtonLitroeMeio = new RadioButton();
            radioButton2L = new RadioButton();
            radioButtonChocolateBelga = new RadioButton();
            radioButtonMorango = new RadioButton();
            radioButtonUva = new RadioButton();
            radioButtonCaramelo = new RadioButton();
            radioButtonLeiteCond = new RadioButton();
            radioButtonAmora = new RadioButton();
            radioButtonMaracujá = new RadioButton();
            radioButtonMenta = new RadioButton();
            radioButtonFrutaMorango = new RadioButton();
            radioButtonFrutaAbacaxi = new RadioButton();
            radioButtonFrutaKiwi = new RadioButton();
            radioButtonFrutaUvaVerde = new RadioButton();
            radioButtonFrutaUvaRoxa = new RadioButton();
            radioButtonFrutaManga = new RadioButton();
            radioButtonFrutaMelão = new RadioButton();
            radioButtonFrutaBanana = new RadioButton();
            radioButtonFrutaPitaya = new RadioButton();
            listBoxComplementos = new ListBox();
            radioButton24 = new RadioButton();
            radioButton25 = new RadioButton();
            radioButton26 = new RadioButton();
            radioButton27 = new RadioButton();
            radioButton28 = new RadioButton();
            radioButton29 = new RadioButton();
            radioButton30 = new RadioButton();
            radioButton31 = new RadioButton();
            radioButton32 = new RadioButton();
            radioButton33 = new RadioButton();
            radioButton34 = new RadioButton();
            radioButton35 = new RadioButton();
            radioButton36 = new RadioButton();
            radioButton37 = new RadioButton();
            radioButton38 = new RadioButton();
            radioButton39 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(170, 78);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(88, 27);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "LOCAL:";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.Location = new Point(298, 78);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(100, 27);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "VIAGEM:";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Felix Titling", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(170, 12);
            label1.Name = "label1";
            label1.Size = new Size(186, 24);
            label1.TabIndex = 3;
            label1.Text = "AÇAÍ GOURMET";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Purple;
            textBox1.Font = new Font("Candara", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.Info;
            textBox1.Location = new Point(12, 186);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(351, 26);
            textBox1.TabIndex = 4;
            textBox1.Text = "TAMANHO:";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // listBoxItensPedido
            // 
            listBoxItensPedido.Font = new Font("Adobe Pi Std", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxItensPedido.FormattingEnabled = true;
            listBoxItensPedido.ItemHeight = 19;
            listBoxItensPedido.Location = new Point(12, 218);
            listBoxItensPedido.Name = "listBoxItensPedido";
            listBoxItensPedido.Size = new Size(351, 137);
            listBoxItensPedido.TabIndex = 5;
            listBoxItensPedido.SelectedIndexChanged += listBoxItensePedido_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Purple;
            textBox2.Font = new Font("Candara", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.Info;
            textBox2.Location = new Point(12, 377);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(351, 26);
            textBox2.TabIndex = 12;
            textBox2.Text = "CORBETURAS:";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // listBoxCorberturas
            // 
            listBoxCorberturas.FormattingEnabled = true;
            listBoxCorberturas.ItemHeight = 15;
            listBoxCorberturas.Location = new Point(12, 409);
            listBoxCorberturas.Name = "listBoxCorberturas";
            listBoxCorberturas.Size = new Size(351, 124);
            listBoxCorberturas.TabIndex = 13;
            listBoxCorberturas.SelectedIndexChanged += listBoxCorberturas_SelectedIndexChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Purple;
            textBox3.Font = new Font("Candara", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = SystemColors.Info;
            textBox3.Location = new Point(369, 186);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(371, 26);
            textBox3.TabIndex = 20;
            textBox3.Text = "COMPLEMENTOS:";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Purple;
            textBox4.Font = new Font("Candara", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ForeColor = SystemColors.Info;
            textBox4.Location = new Point(12, 539);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(351, 26);
            textBox4.TabIndex = 36;
            textBox4.Text = "FRUTAS:";
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // listBoxFrutas
            // 
            listBoxFrutas.FormattingEnabled = true;
            listBoxFrutas.ItemHeight = 15;
            listBoxFrutas.Location = new Point(12, 571);
            listBoxFrutas.Name = "listBoxFrutas";
            listBoxFrutas.Size = new Size(351, 124);
            listBoxFrutas.TabIndex = 37;
            // 
            // button1
            // 
            button1.Location = new Point(170, 39);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 41;
            button1.Text = "NOME:";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 108);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 42;
            label2.Text = "label2";
            // 
            // radioButton300mL
            // 
            radioButton300mL.AutoSize = true;
            radioButton300mL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton300mL.Location = new Point(25, 235);
            radioButton300mL.Name = "radioButton300mL";
            radioButton300mL.Size = new Size(153, 25);
            radioButton300mL.TabIndex = 51;
            radioButton300mL.TabStop = true;
            radioButton300mL.Text = "300mL - R$ 13,00";
            radioButton300mL.UseVisualStyleBackColor = true;
            // 
            // radioButton500mL
            // 
            radioButton500mL.AutoSize = true;
            radioButton500mL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton500mL.Location = new Point(25, 277);
            radioButton500mL.Name = "radioButton500mL";
            radioButton500mL.Size = new Size(153, 25);
            radioButton500mL.TabIndex = 52;
            radioButton500mL.TabStop = true;
            radioButton500mL.Text = "500mL - R$ 19,00";
            radioButton500mL.UseVisualStyleBackColor = true;
            // 
            // radioButton700mL
            // 
            radioButton700mL.AutoSize = true;
            radioButton700mL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton700mL.Location = new Point(25, 318);
            radioButton700mL.Name = "radioButton700mL";
            radioButton700mL.Size = new Size(153, 25);
            radioButton700mL.TabIndex = 53;
            radioButton700mL.TabStop = true;
            radioButton700mL.Text = "700mL - R$ 24,00";
            radioButton700mL.UseVisualStyleBackColor = true;
            // 
            // radioButton1L
            // 
            radioButton1L.AutoSize = true;
            radioButton1L.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1L.Location = new Point(189, 235);
            radioButton1L.Name = "radioButton1L";
            radioButton1L.Size = new Size(121, 25);
            radioButton1L.TabIndex = 54;
            radioButton1L.TabStop = true;
            radioButton1L.Text = "1L - R$ 32,00";
            radioButton1L.UseVisualStyleBackColor = true;
            // 
            // radioButtonLitroeMeio
            // 
            radioButtonLitroeMeio.AutoSize = true;
            radioButtonLitroeMeio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonLitroeMeio.Location = new Point(189, 277);
            radioButtonLitroeMeio.Name = "radioButtonLitroeMeio";
            radioButtonLitroeMeio.Size = new Size(124, 25);
            radioButtonLitroeMeio.TabIndex = 55;
            radioButtonLitroeMeio.TabStop = true;
            radioButtonLitroeMeio.Text = "1,5L - R$ 44,0";
            radioButtonLitroeMeio.UseVisualStyleBackColor = true;
            // 
            // radioButton2L
            // 
            radioButton2L.AutoSize = true;
            radioButton2L.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2L.Location = new Point(189, 316);
            radioButton2L.Name = "radioButton2L";
            radioButton2L.Size = new Size(121, 25);
            radioButton2L.TabIndex = 56;
            radioButton2L.TabStop = true;
            radioButton2L.Text = "2L - R$ 55,00";
            radioButton2L.UseVisualStyleBackColor = true;
            // 
            // radioButtonChocolateBelga
            // 
            radioButtonChocolateBelga.AutoSize = true;
            radioButtonChocolateBelga.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonChocolateBelga.Location = new Point(25, 431);
            radioButtonChocolateBelga.Name = "radioButtonChocolateBelga";
            radioButtonChocolateBelga.Size = new Size(139, 25);
            radioButtonChocolateBelga.TabIndex = 57;
            radioButtonChocolateBelga.TabStop = true;
            radioButtonChocolateBelga.Text = "Chocolate Belga";
            radioButtonChocolateBelga.UseVisualStyleBackColor = true;
            // 
            // radioButtonMorango
            // 
            radioButtonMorango.AutoSize = true;
            radioButtonMorango.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonMorango.Location = new Point(25, 462);
            radioButtonMorango.Name = "radioButtonMorango";
            radioButtonMorango.Size = new Size(92, 25);
            radioButtonMorango.TabIndex = 58;
            radioButtonMorango.TabStop = true;
            radioButtonMorango.Text = "Morango";
            radioButtonMorango.UseVisualStyleBackColor = true;
            // 
            // radioButtonUva
            // 
            radioButtonUva.AutoSize = true;
            radioButtonUva.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonUva.Location = new Point(25, 493);
            radioButtonUva.Name = "radioButtonUva";
            radioButtonUva.Size = new Size(55, 25);
            radioButtonUva.TabIndex = 59;
            radioButtonUva.TabStop = true;
            radioButtonUva.Text = "Uva";
            radioButtonUva.UseVisualStyleBackColor = true;
            // 
            // radioButtonCaramelo
            // 
            radioButtonCaramelo.AutoSize = true;
            radioButtonCaramelo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonCaramelo.Location = new Point(171, 431);
            radioButtonCaramelo.Name = "radioButtonCaramelo";
            radioButtonCaramelo.Size = new Size(95, 25);
            radioButtonCaramelo.TabIndex = 60;
            radioButtonCaramelo.TabStop = true;
            radioButtonCaramelo.Text = "Caramelo";
            radioButtonCaramelo.UseVisualStyleBackColor = true;
            // 
            // radioButtonLeiteCond
            // 
            radioButtonLeiteCond.AutoSize = true;
            radioButtonLeiteCond.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonLeiteCond.Location = new Point(123, 462);
            radioButtonLeiteCond.Name = "radioButtonLeiteCond";
            radioButtonLeiteCond.Size = new Size(105, 25);
            radioButtonLeiteCond.TabIndex = 61;
            radioButtonLeiteCond.TabStop = true;
            radioButtonLeiteCond.Text = "Leite Cond.";
            radioButtonLeiteCond.UseVisualStyleBackColor = true;
            // 
            // radioButtonAmora
            // 
            radioButtonAmora.AutoSize = true;
            radioButtonAmora.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonAmora.Location = new Point(89, 493);
            radioButtonAmora.Name = "radioButtonAmora";
            radioButtonAmora.Size = new Size(75, 25);
            radioButtonAmora.TabIndex = 62;
            radioButtonAmora.TabStop = true;
            radioButtonAmora.Text = "Amora";
            radioButtonAmora.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaracujá
            // 
            radioButtonMaracujá.AutoSize = true;
            radioButtonMaracujá.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonMaracujá.Location = new Point(170, 493);
            radioButtonMaracujá.Name = "radioButtonMaracujá";
            radioButtonMaracujá.Size = new Size(92, 25);
            radioButtonMaracujá.TabIndex = 64;
            radioButtonMaracujá.TabStop = true;
            radioButtonMaracujá.Text = "Maracujá";
            radioButtonMaracujá.UseVisualStyleBackColor = true;
            // 
            // radioButtonMenta
            // 
            radioButtonMenta.AutoSize = true;
            radioButtonMenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonMenta.Location = new Point(234, 462);
            radioButtonMenta.Name = "radioButtonMenta";
            radioButtonMenta.Size = new Size(72, 25);
            radioButtonMenta.TabIndex = 65;
            radioButtonMenta.TabStop = true;
            radioButtonMenta.Text = "Menta";
            radioButtonMenta.UseVisualStyleBackColor = true;
            // 
            // radioButtonFrutaMorango
            // 
            radioButtonFrutaMorango.AutoSize = true;
            radioButtonFrutaMorango.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonFrutaMorango.Location = new Point(25, 600);
            radioButtonFrutaMorango.Name = "radioButtonFrutaMorango";
            radioButtonFrutaMorango.Size = new Size(92, 25);
            radioButtonFrutaMorango.TabIndex = 66;
            radioButtonFrutaMorango.TabStop = true;
            radioButtonFrutaMorango.Text = "Morango";
            radioButtonFrutaMorango.UseVisualStyleBackColor = true;
            // 
            // radioButtonFrutaAbacaxi
            // 
            radioButtonFrutaAbacaxi.AutoSize = true;
            radioButtonFrutaAbacaxi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonFrutaAbacaxi.Location = new Point(25, 631);
            radioButtonFrutaAbacaxi.Name = "radioButtonFrutaAbacaxi";
            radioButtonFrutaAbacaxi.Size = new Size(81, 25);
            radioButtonFrutaAbacaxi.TabIndex = 67;
            radioButtonFrutaAbacaxi.TabStop = true;
            radioButtonFrutaAbacaxi.Text = "Abacaxi";
            radioButtonFrutaAbacaxi.UseVisualStyleBackColor = true;
            // 
            // radioButtonFrutaKiwi
            // 
            radioButtonFrutaKiwi.AutoSize = true;
            radioButtonFrutaKiwi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonFrutaKiwi.Location = new Point(25, 662);
            radioButtonFrutaKiwi.Name = "radioButtonFrutaKiwi";
            radioButtonFrutaKiwi.Size = new Size(57, 25);
            radioButtonFrutaKiwi.TabIndex = 68;
            radioButtonFrutaKiwi.TabStop = true;
            radioButtonFrutaKiwi.Text = "Kiwi";
            radioButtonFrutaKiwi.UseVisualStyleBackColor = true;
            // 
            // radioButtonFrutaUvaVerde
            // 
            radioButtonFrutaUvaVerde.AutoSize = true;
            radioButtonFrutaUvaVerde.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonFrutaUvaVerde.Location = new Point(123, 600);
            radioButtonFrutaUvaVerde.Name = "radioButtonFrutaUvaVerde";
            radioButtonFrutaUvaVerde.Size = new Size(99, 25);
            radioButtonFrutaUvaVerde.TabIndex = 69;
            radioButtonFrutaUvaVerde.TabStop = true;
            radioButtonFrutaUvaVerde.Text = "Uva Verde";
            radioButtonFrutaUvaVerde.UseVisualStyleBackColor = true;
            // 
            // radioButtonFrutaUvaRoxa
            // 
            radioButtonFrutaUvaRoxa.AutoSize = true;
            radioButtonFrutaUvaRoxa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonFrutaUvaRoxa.Location = new Point(112, 631);
            radioButtonFrutaUvaRoxa.Name = "radioButtonFrutaUvaRoxa";
            radioButtonFrutaUvaRoxa.Size = new Size(93, 25);
            radioButtonFrutaUvaRoxa.TabIndex = 70;
            radioButtonFrutaUvaRoxa.TabStop = true;
            radioButtonFrutaUvaRoxa.Text = "Uva Roxa";
            radioButtonFrutaUvaRoxa.UseVisualStyleBackColor = true;
            // 
            // radioButtonFrutaManga
            // 
            radioButtonFrutaManga.AutoSize = true;
            radioButtonFrutaManga.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonFrutaManga.Location = new Point(89, 662);
            radioButtonFrutaManga.Name = "radioButtonFrutaManga";
            radioButtonFrutaManga.Size = new Size(76, 25);
            radioButtonFrutaManga.TabIndex = 71;
            radioButtonFrutaManga.TabStop = true;
            radioButtonFrutaManga.Text = "Manga";
            radioButtonFrutaManga.UseVisualStyleBackColor = true;
            // 
            // radioButtonFrutaMelão
            // 
            radioButtonFrutaMelão.AutoSize = true;
            radioButtonFrutaMelão.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonFrutaMelão.Location = new Point(234, 600);
            radioButtonFrutaMelão.Name = "radioButtonFrutaMelão";
            radioButtonFrutaMelão.Size = new Size(71, 25);
            radioButtonFrutaMelão.TabIndex = 72;
            radioButtonFrutaMelão.TabStop = true;
            radioButtonFrutaMelão.Text = "Melão";
            radioButtonFrutaMelão.UseVisualStyleBackColor = true;
            // 
            // radioButtonFrutaBanana
            // 
            radioButtonFrutaBanana.AutoSize = true;
            radioButtonFrutaBanana.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonFrutaBanana.Location = new Point(218, 631);
            radioButtonFrutaBanana.Name = "radioButtonFrutaBanana";
            radioButtonFrutaBanana.Size = new Size(79, 25);
            radioButtonFrutaBanana.TabIndex = 73;
            radioButtonFrutaBanana.TabStop = true;
            radioButtonFrutaBanana.Text = "Banana";
            radioButtonFrutaBanana.UseVisualStyleBackColor = true;
            // 
            // radioButtonFrutaPitaya
            // 
            radioButtonFrutaPitaya.AutoSize = true;
            radioButtonFrutaPitaya.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonFrutaPitaya.Location = new Point(171, 662);
            radioButtonFrutaPitaya.Name = "radioButtonFrutaPitaya";
            radioButtonFrutaPitaya.Size = new Size(70, 25);
            radioButtonFrutaPitaya.TabIndex = 74;
            radioButtonFrutaPitaya.TabStop = true;
            radioButtonFrutaPitaya.Text = "Pitaya";
            radioButtonFrutaPitaya.UseVisualStyleBackColor = true;
            // 
            // listBoxComplementos
            // 
            listBoxComplementos.FormattingEnabled = true;
            listBoxComplementos.ItemHeight = 15;
            listBoxComplementos.Location = new Point(369, 218);
            listBoxComplementos.Name = "listBoxComplementos";
            listBoxComplementos.Size = new Size(371, 304);
            listBoxComplementos.TabIndex = 75;
            // 
            // radioButton24
            // 
            radioButton24.AutoSize = true;
            radioButton24.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton24.Location = new Point(381, 235);
            radioButton24.Name = "radioButton24";
            radioButton24.Size = new Size(127, 29);
            radioButton24.TabIndex = 76;
            radioButton24.TabStop = true;
            radioButton24.Text = "Leite em Pó";
            radioButton24.UseVisualStyleBackColor = true;
            // 
            // radioButton25
            // 
            radioButton25.AutoSize = true;
            radioButton25.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton25.Location = new Point(381, 270);
            radioButton25.Name = "radioButton25";
            radioButton25.Size = new Size(127, 29);
            radioButton25.TabIndex = 77;
            radioButton25.TabStop = true;
            radioButton25.Text = "Ovomaltine";
            radioButton25.UseVisualStyleBackColor = true;
            // 
            // radioButton26
            // 
            radioButton26.AutoSize = true;
            radioButton26.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton26.Location = new Point(381, 305);
            radioButton26.Name = "radioButton26";
            radioButton26.Size = new Size(89, 29);
            radioButton26.TabIndex = 78;
            radioButton26.TabStop = true;
            radioButton26.Text = "Paçoca";
            radioButton26.UseVisualStyleBackColor = true;
            // 
            // radioButton27
            // 
            radioButton27.AutoSize = true;
            radioButton27.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton27.Location = new Point(381, 340);
            radioButton27.Name = "radioButton27";
            radioButton27.Size = new Size(107, 29);
            radioButton27.TabIndex = 79;
            radioButton27.TabStop = true;
            radioButton27.Text = "Sucrilhos";
            radioButton27.UseVisualStyleBackColor = true;
            // 
            // radioButton28
            // 
            radioButton28.AutoSize = true;
            radioButton28.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton28.Location = new Point(514, 235);
            radioButton28.Name = "radioButton28";
            radioButton28.Size = new Size(116, 29);
            radioButton28.TabIndex = 80;
            radioButton28.TabStop = true;
            radioButton28.Text = "Chocoboll";
            radioButton28.UseVisualStyleBackColor = true;
            // 
            // radioButton29
            // 
            radioButton29.AutoSize = true;
            radioButton29.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton29.Location = new Point(514, 273);
            radioButton29.Name = "radioButton29";
            radioButton29.Size = new Size(104, 29);
            radioButton29.TabIndex = 81;
            radioButton29.TabStop = true;
            radioButton29.Text = "Confetes";
            radioButton29.UseVisualStyleBackColor = true;
            // 
            // radioButton30
            // 
            radioButton30.AutoSize = true;
            radioButton30.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton30.Location = new Point(476, 305);
            radioButton30.Name = "radioButton30";
            radioButton30.Size = new Size(167, 29);
            radioButton30.TabIndex = 82;
            radioButton30.TabStop = true;
            radioButton30.Text = "Gotas de Choco.";
            radioButton30.UseVisualStyleBackColor = true;
            // 
            // radioButton31
            // 
            radioButton31.AutoSize = true;
            radioButton31.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton31.Location = new Point(494, 340);
            radioButton31.Name = "radioButton31";
            radioButton31.Size = new Size(104, 29);
            radioButton31.TabIndex = 83;
            radioButton31.TabStop = true;
            radioButton31.Text = "Confetes";
            radioButton31.UseVisualStyleBackColor = true;
            // 
            // radioButton32
            // 
            radioButton32.AutoSize = true;
            radioButton32.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton32.Location = new Point(381, 375);
            radioButton32.Name = "radioButton32";
            radioButton32.Size = new Size(122, 29);
            radioButton32.TabIndex = 84;
            radioButton32.TabStop = true;
            radioButton32.Text = "Amendoim";
            radioButton32.UseVisualStyleBackColor = true;
            // 
            // radioButton33
            // 
            radioButton33.AutoSize = true;
            radioButton33.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton33.Location = new Point(509, 372);
            radioButton33.Name = "radioButton33";
            radioButton33.Size = new Size(154, 29);
            radioButton33.TabIndex = 85;
            radioButton33.TabStop = true;
            radioButton33.Text = "Ferrero Rocher";
            radioButton33.UseVisualStyleBackColor = true;
            // 
            // radioButton34
            // 
            radioButton34.AutoSize = true;
            radioButton34.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton34.Location = new Point(491, 410);
            radioButton34.Name = "radioButton34";
            radioButton34.Size = new Size(148, 29);
            radioButton34.TabIndex = 86;
            radioButton34.TabStop = true;
            radioButton34.Text = "Crme de Oreo";
            radioButton34.UseVisualStyleBackColor = true;
            // 
            // radioButton35
            // 
            radioButton35.AutoSize = true;
            radioButton35.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton35.Location = new Point(381, 410);
            radioButton35.Name = "radioButton35";
            radioButton35.Size = new Size(104, 29);
            radioButton35.TabIndex = 87;
            radioButton35.TabStop = true;
            radioButton35.Text = "Chantilly";
            radioButton35.UseVisualStyleBackColor = true;
            // 
            // radioButton36
            // 
            radioButton36.AutoSize = true;
            radioButton36.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton36.Location = new Point(381, 445);
            radioButton36.Name = "radioButton36";
            radioButton36.Size = new Size(194, 29);
            radioButton36.TabIndex = 88;
            radioButton36.TabStop = true;
            radioButton36.Text = "Creme de Morango";
            radioButton36.UseVisualStyleBackColor = true;
            // 
            // radioButton37
            // 
            radioButton37.AutoSize = true;
            radioButton37.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton37.Location = new Point(381, 480);
            radioButton37.Name = "radioButton37";
            radioButton37.Size = new Size(168, 29);
            radioButton37.TabIndex = 89;
            radioButton37.TabStop = true;
            radioButton37.Text = "Creme de Ninho";
            radioButton37.UseVisualStyleBackColor = true;
            // 
            // radioButton38
            // 
            radioButton38.AutoSize = true;
            radioButton38.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton38.Location = new Point(581, 445);
            radioButton38.Name = "radioButton38";
            radioButton38.Size = new Size(105, 29);
            radioButton38.TabIndex = 90;
            radioButton38.TabStop = true;
            radioButton38.Text = "Cupuaçú";
            radioButton38.UseVisualStyleBackColor = true;
            // 
            // radioButton39
            // 
            radioButton39.AutoSize = true;
            radioButton39.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton39.Location = new Point(555, 480);
            radioButton39.Name = "radioButton39";
            radioButton39.Size = new Size(54, 29);
            radioButton39.TabIndex = 91;
            radioButton39.TabStop = true;
            radioButton39.Text = "Bis";
            radioButton39.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(881, 758);
            Controls.Add(radioButton39);
            Controls.Add(radioButton38);
            Controls.Add(radioButton37);
            Controls.Add(radioButton36);
            Controls.Add(radioButton35);
            Controls.Add(radioButton34);
            Controls.Add(radioButton33);
            Controls.Add(radioButton32);
            Controls.Add(radioButton31);
            Controls.Add(radioButton30);
            Controls.Add(radioButton29);
            Controls.Add(radioButton28);
            Controls.Add(radioButton27);
            Controls.Add(radioButton26);
            Controls.Add(radioButton25);
            Controls.Add(radioButton24);
            Controls.Add(listBoxComplementos);
            Controls.Add(radioButtonFrutaPitaya);
            Controls.Add(radioButtonFrutaBanana);
            Controls.Add(radioButtonFrutaMelão);
            Controls.Add(radioButtonFrutaManga);
            Controls.Add(radioButtonFrutaUvaRoxa);
            Controls.Add(radioButtonFrutaUvaVerde);
            Controls.Add(radioButtonFrutaKiwi);
            Controls.Add(radioButtonFrutaAbacaxi);
            Controls.Add(radioButtonFrutaMorango);
            Controls.Add(radioButtonMenta);
            Controls.Add(radioButtonMaracujá);
            Controls.Add(radioButtonAmora);
            Controls.Add(radioButtonLeiteCond);
            Controls.Add(radioButtonCaramelo);
            Controls.Add(radioButtonUva);
            Controls.Add(radioButtonMorango);
            Controls.Add(radioButtonChocolateBelga);
            Controls.Add(radioButton2L);
            Controls.Add(radioButtonLitroeMeio);
            Controls.Add(radioButton1L);
            Controls.Add(radioButton700mL);
            Controls.Add(radioButton500mL);
            Controls.Add(radioButton300mL);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(listBoxFrutas);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(listBoxCorberturas);
            Controls.Add(textBox2);
            Controls.Add(listBoxItensPedido);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label1;
        private TextBox textBox1;
        private ListBox listBoxItensPedido;
        private TextBox textBox2;
        private ListBox listBoxCorberturas;
        private TextBox textBox3;
        private TextBox textBox4;
        private ListBox listBoxFrutas;
        private Button button1;
        private Label label2;
        private RadioButton radioButton300mL;
        private RadioButton radioButton500mL;
        private RadioButton radioButton700mL;
        private RadioButton radioButton1L;
        private RadioButton radioButtonLitroeMeio;
        private RadioButton radioButton2L;
        private RadioButton radioButtonChocolateBelga;
        private RadioButton radioButtonMorango;
        private RadioButton radioButtonUva;
        private RadioButton radioButtonCaramelo;
        private RadioButton radioButtonLeiteCond;
        private RadioButton radioButtonAmora;
        private RadioButton radioButtonMaracujá;
        private RadioButton radioButtonMenta;
        private RadioButton radioButtonFrutaMorango;
        private RadioButton radioButtonFrutaAbacaxi;
        private RadioButton radioButtonFrutaKiwi;
        private RadioButton radioButtonFrutaUvaVerde;
        private RadioButton radioButtonFrutaUvaRoxa;
        private RadioButton radioButtonFrutaManga;
        private RadioButton radioButtonFrutaMelão;
        private RadioButton radioButtonFrutaBanana;
        private RadioButton radioButtonFrutaPitaya;
        private ListBox listBoxComplementos;
        private RadioButton radioButton24;
        private RadioButton radioButton25;
        private RadioButton radioButton26;
        private RadioButton radioButton27;
        private RadioButton radioButton28;
        private RadioButton radioButton29;
        private RadioButton radioButton30;
        private RadioButton radioButton31;
        private RadioButton radioButton32;
        private RadioButton radioButton33;
        private RadioButton radioButton34;
        private RadioButton radioButton35;
        private RadioButton radioButton36;
        private RadioButton radioButton37;
        private RadioButton radioButton38;
        private RadioButton radioButton39;
    }
}