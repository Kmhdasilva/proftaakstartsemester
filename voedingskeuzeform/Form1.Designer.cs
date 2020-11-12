namespace voedingskeuzeform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Tabs = new System.Windows.Forms.TabControl();
            this.LoginTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.RegisterTab = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.productNumber = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.product1button = new System.Windows.Forms.Button();
            this.productPage = new System.Windows.Forms.TabPage();
            this.productNaam = new System.Windows.Forms.Label();
            this.productPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.productBeschrijving = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productingredienten = new System.Windows.Forms.Label();
            this.alternatief = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tabs.SuspendLayout();
            this.LoginTab.SuspendLayout();
            this.RegisterTab.SuspendLayout();
            this.productNumber.SuspendLayout();
            this.productPage.SuspendLayout();
            this.productPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.LoginTab);
            this.Tabs.Controls.Add(this.RegisterTab);
            this.Tabs.Controls.Add(this.productNumber);
            this.Tabs.Controls.Add(this.productPage);
            this.Tabs.Location = new System.Drawing.Point(1, 3);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(479, 615);
            this.Tabs.TabIndex = 0;
            // 
            // LoginTab
            // 
            this.LoginTab.Controls.Add(this.label1);
            this.LoginTab.Controls.Add(this.textBox1);
            this.LoginTab.Controls.Add(this.label2);
            this.LoginTab.Controls.Add(this.button1);
            this.LoginTab.Controls.Add(this.label3);
            this.LoginTab.Controls.Add(this.label8);
            this.LoginTab.Controls.Add(this.textBox2);
            this.LoginTab.Controls.Add(this.textBox6);
            this.LoginTab.Location = new System.Drawing.Point(4, 22);
            this.LoginTab.Name = "LoginTab";
            this.LoginTab.Padding = new System.Windows.Forms.Padding(3);
            this.LoginTab.Size = new System.Drawing.Size(471, 589);
            this.LoginTab.TabIndex = 0;
            this.LoginTab.Text = "Login";
            this.LoginTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 39);
            this.label1.TabIndex = 26;
            this.label1.Text = "E-mail";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 234);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(453, 20);
            this.textBox1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label2.Location = new System.Drawing.Point(10, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 60);
            this.label2.TabIndex = 24;
            this.label2.Text = "Registreer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(453, 43);
            this.button1.TabIndex = 23;
            this.button1.Text = "Registreren";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(453, 39);
            this.label3.TabIndex = 22;
            this.label3.Text = "Gebruikersnaam";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(10, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(453, 39);
            this.label8.TabIndex = 21;
            this.label8.Text = "Wachtwoord";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(10, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(453, 20);
            this.textBox2.TabIndex = 20;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(10, 95);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(453, 20);
            this.textBox6.TabIndex = 19;
            // 
            // RegisterTab
            // 
            this.RegisterTab.Controls.Add(this.label7);
            this.RegisterTab.Controls.Add(this.textBox5);
            this.RegisterTab.Controls.Add(this.label4);
            this.RegisterTab.Controls.Add(this.button4);
            this.RegisterTab.Controls.Add(this.label5);
            this.RegisterTab.Controls.Add(this.label6);
            this.RegisterTab.Controls.Add(this.textBox3);
            this.RegisterTab.Controls.Add(this.textBox4);
            this.RegisterTab.Location = new System.Drawing.Point(4, 22);
            this.RegisterTab.Name = "RegisterTab";
            this.RegisterTab.Padding = new System.Windows.Forms.Padding(3);
            this.RegisterTab.Size = new System.Drawing.Size(471, 589);
            this.RegisterTab.TabIndex = 1;
            this.RegisterTab.Text = "Register";
            this.RegisterTab.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(10, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(453, 39);
            this.label7.TabIndex = 18;
            this.label7.Text = "E-mail";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(10, 233);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(453, 20);
            this.textBox5.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label4.Location = new System.Drawing.Point(10, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(453, 60);
            this.label4.TabIndex = 16;
            this.label4.Text = "Registreer";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(10, 272);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(453, 43);
            this.button4.TabIndex = 15;
            this.button4.Text = "Registreren";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(453, 39);
            this.label5.TabIndex = 12;
            this.label5.Text = "Gebruikersnaam";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(453, 39);
            this.label6.TabIndex = 11;
            this.label6.Text = "Wachtwoord";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(10, 159);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(453, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(10, 94);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(453, 20);
            this.textBox4.TabIndex = 9;
            // 
            // productNumber
            // 
            this.productNumber.Controls.Add(this.button9);
            this.productNumber.Controls.Add(this.button8);
            this.productNumber.Controls.Add(this.button5);
            this.productNumber.Controls.Add(this.button3);
            this.productNumber.Controls.Add(this.button2);
            this.productNumber.Controls.Add(this.button7);
            this.productNumber.Controls.Add(this.button6);
            this.productNumber.Controls.Add(this.product1button);
            this.productNumber.Location = new System.Drawing.Point(4, 22);
            this.productNumber.Margin = new System.Windows.Forms.Padding(2);
            this.productNumber.Name = "productNumber";
            this.productNumber.Padding = new System.Windows.Forms.Padding(2);
            this.productNumber.Size = new System.Drawing.Size(471, 589);
            this.productNumber.TabIndex = 4;
            this.productNumber.Text = "Product kiezen";
            this.productNumber.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(4, 114);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(460, 50);
            this.button7.TabIndex = 2;
            this.button7.Text = "product 3";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(4, 59);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(460, 50);
            this.button6.TabIndex = 1;
            this.button6.Text = "product 2";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // product1button
            // 
            this.product1button.Location = new System.Drawing.Point(4, 5);
            this.product1button.Margin = new System.Windows.Forms.Padding(2);
            this.product1button.Name = "product1button";
            this.product1button.Size = new System.Drawing.Size(460, 50);
            this.product1button.TabIndex = 0;
            this.product1button.Text = "product 1";
            this.product1button.UseVisualStyleBackColor = true;
            this.product1button.Click += new System.EventHandler(this.product1button_Click);
            // 
            // productPage
            // 
            this.productPage.AutoScroll = true;
            this.productPage.Controls.Add(this.productNaam);
            this.productPage.Controls.Add(this.productPanel);
            this.productPage.Location = new System.Drawing.Point(4, 22);
            this.productPage.Name = "productPage";
            this.productPage.Padding = new System.Windows.Forms.Padding(3);
            this.productPage.Size = new System.Drawing.Size(471, 589);
            this.productPage.TabIndex = 3;
            this.productPage.Text = "productPage";
            this.productPage.UseVisualStyleBackColor = true;
            // 
            // productNaam
            // 
            this.productNaam.Location = new System.Drawing.Point(10, 6);
            this.productNaam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productNaam.Name = "productNaam";
            this.productNaam.Size = new System.Drawing.Size(453, 46);
            this.productNaam.TabIndex = 1;
            this.productNaam.Text = "Producten";
            this.productNaam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productPanel
            // 
            this.productPanel.Controls.Add(this.productingredienten);
            this.productPanel.Controls.Add(this.panel1);
            this.productPanel.Controls.Add(this.productBeschrijving);
            this.productPanel.Controls.Add(this.pictureBox1);
            this.productPanel.Location = new System.Drawing.Point(10, 56);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(453, 525);
            this.productPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.alternatief);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(4, 414);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 108);
            this.panel1.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(4, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(439, 45);
            this.label9.TabIndex = 0;
            this.label9.Text = "Gezonder Alternatief";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productBeschrijving
            // 
            this.productBeschrijving.Location = new System.Drawing.Point(274, 4);
            this.productBeschrijving.Name = "productBeschrijving";
            this.productBeschrijving.Size = new System.Drawing.Size(176, 157);
            this.productBeschrijving.TabIndex = 2;
            this.productBeschrijving.Text = "label13";
            this.productBeschrijving.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 404);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // productingredienten
            // 
            this.productingredienten.AutoSize = true;
            this.productingredienten.Location = new System.Drawing.Point(277, 179);
            this.productingredienten.Name = "productingredienten";
            this.productingredienten.Size = new System.Drawing.Size(41, 13);
            this.productingredienten.TabIndex = 5;
            this.productingredienten.Text = "label10";
            // 
            // alternatief
            // 
            this.alternatief.Location = new System.Drawing.Point(4, 53);
            this.alternatief.Name = "alternatief";
            this.alternatief.Size = new System.Drawing.Size(439, 55);
            this.alternatief.TabIndex = 1;
            this.alternatief.Text = "label10";
            this.alternatief.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 168);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(460, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "product 4";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 222);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(460, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "product 5";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(4, 330);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(460, 50);
            this.button5.TabIndex = 5;
            this.button5.Text = "product 7";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(4, 276);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(460, 50);
            this.button8.TabIndex = 6;
            this.button8.Text = "product 6";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(4, 384);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(460, 50);
            this.button9.TabIndex = 7;
            this.button9.Text = "product 8";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(voedingskeuzeform.Program);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 618);
            this.Controls.Add(this.Tabs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Tabs.ResumeLayout(false);
            this.LoginTab.ResumeLayout(false);
            this.LoginTab.PerformLayout();
            this.RegisterTab.ResumeLayout(false);
            this.RegisterTab.PerformLayout();
            this.productNumber.ResumeLayout(false);
            this.productPage.ResumeLayout(false);
            this.productPanel.ResumeLayout(false);
            this.productPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage LoginTab;
        private System.Windows.Forms.TabPage RegisterTab;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TabPage productPage;
        private System.Windows.Forms.Panel productPanel;
        private System.Windows.Forms.Label productBeschrijving;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.Label productNaam;
        private System.Windows.Forms.TabPage productNumber;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button product1button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label productingredienten;
        private System.Windows.Forms.Label alternatief;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
    }
}

