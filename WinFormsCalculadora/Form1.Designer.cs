namespace WinFormsCalculadora
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
            textScreen = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonClear = new Button();
            buttonBack = new Button();
            buttonDivision = new Button();
            buttonX = new Button();
            buttonMenos = new Button();
            buttonMas = new Button();
            buttonIgual = new Button();
            buttonPunto = new Button();
            SuspendLayout();
            // 
            // textScreen
            // 
            textScreen.Font = new Font("Consolas", 20.25F);
            textScreen.Location = new Point(22, 68);
            textScreen.Multiline = true;
            textScreen.Name = "textScreen";
            textScreen.Size = new Size(223, 50);
            textScreen.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Consolas", 20.25F);
            button1.Location = new Point(22, 305);
            button1.Name = "button1";
            button1.Size = new Size(46, 37);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Consolas", 20.25F);
            button2.Location = new Point(83, 305);
            button2.Name = "button2";
            button2.Size = new Size(46, 37);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Consolas", 20.25F);
            button3.Location = new Point(135, 305);
            button3.Name = "button3";
            button3.Size = new Size(46, 37);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Consolas", 20.25F);
            button4.Location = new Point(22, 248);
            button4.Name = "button4";
            button4.Size = new Size(46, 37);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Consolas", 20.25F);
            button5.Location = new Point(83, 248);
            button5.Name = "button5";
            button5.Size = new Size(46, 37);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Consolas", 20.25F);
            button6.Location = new Point(135, 248);
            button6.Name = "button6";
            button6.Size = new Size(46, 37);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Consolas", 20.25F);
            button7.Location = new Point(22, 191);
            button7.Name = "button7";
            button7.Size = new Size(46, 37);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Consolas", 20.25F);
            button8.Location = new Point(83, 191);
            button8.Name = "button8";
            button8.Size = new Size(46, 37);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Consolas", 20.25F);
            button9.Location = new Point(135, 191);
            button9.Name = "button9";
            button9.Size = new Size(46, 37);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Consolas", 20.25F);
            button0.Location = new Point(22, 360);
            button0.Name = "button0";
            button0.Size = new Size(107, 37);
            button0.TabIndex = 10;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Consolas", 20.25F);
            buttonClear.Location = new Point(22, 133);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(46, 37);
            buttonClear.TabIndex = 11;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Consolas", 20.25F);
            buttonBack.Location = new Point(83, 133);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(46, 37);
            buttonBack.TabIndex = 12;
            buttonBack.Text = "%";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonDivision
            // 
            buttonDivision.Font = new Font("Consolas", 20.25F);
            buttonDivision.Location = new Point(135, 133);
            buttonDivision.Name = "buttonDivision";
            buttonDivision.Size = new Size(46, 37);
            buttonDivision.TabIndex = 13;
            buttonDivision.Text = "÷";
            buttonDivision.UseVisualStyleBackColor = true;
            buttonDivision.Click += buttonDivision_Click;
            // 
            // buttonX
            // 
            buttonX.Font = new Font("Consolas", 20.25F);
            buttonX.Location = new Point(199, 133);
            buttonX.Name = "buttonX";
            buttonX.Size = new Size(46, 37);
            buttonX.TabIndex = 14;
            buttonX.Text = "X";
            buttonX.UseVisualStyleBackColor = true;
            buttonX.Click += buttonX_Click;
            // 
            // buttonMenos
            // 
            buttonMenos.Font = new Font("Consolas", 20.25F);
            buttonMenos.Location = new Point(199, 191);
            buttonMenos.Name = "buttonMenos";
            buttonMenos.Size = new Size(46, 37);
            buttonMenos.TabIndex = 15;
            buttonMenos.Text = "-";
            buttonMenos.UseVisualStyleBackColor = true;
            buttonMenos.Click += buttonMenos_Click;
            // 
            // buttonMas
            // 
            buttonMas.Font = new Font("Consolas", 20.25F);
            buttonMas.Location = new Point(199, 248);
            buttonMas.Name = "buttonMas";
            buttonMas.Size = new Size(46, 37);
            buttonMas.TabIndex = 16;
            buttonMas.Text = "+";
            buttonMas.UseVisualStyleBackColor = true;
            buttonMas.Click += buttonMas_Click;
            // 
            // buttonIgual
            // 
            buttonIgual.Font = new Font("Consolas", 20.25F);
            buttonIgual.Location = new Point(199, 305);
            buttonIgual.Name = "buttonIgual";
            buttonIgual.Size = new Size(46, 92);
            buttonIgual.TabIndex = 17;
            buttonIgual.Text = "=";
            buttonIgual.UseVisualStyleBackColor = true;
            buttonIgual.Click += buttonIgual_Click;
            // 
            // buttonPunto
            // 
            buttonPunto.Font = new Font("Consolas", 20.25F);
            buttonPunto.Location = new Point(135, 360);
            buttonPunto.Name = "buttonPunto";
            buttonPunto.Size = new Size(46, 37);
            buttonPunto.TabIndex = 18;
            buttonPunto.Text = ".";
            buttonPunto.UseVisualStyleBackColor = true;
            buttonPunto.Click += buttonPunto_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Calculadora2;
            ClientSize = new Size(276, 431);
            Controls.Add(buttonPunto);
            Controls.Add(buttonIgual);
            Controls.Add(buttonMas);
            Controls.Add(buttonMenos);
            Controls.Add(buttonX);
            Controls.Add(buttonDivision);
            Controls.Add(buttonBack);
            Controls.Add(buttonClear);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textScreen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textScreen;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonClear;
        private Button buttonBack;
        private Button buttonDivision;
        private Button buttonX;
        private Button buttonMenos;
        private Button buttonMas;
        private Button buttonIgual;
        private Button buttonPunto;
    }
}
