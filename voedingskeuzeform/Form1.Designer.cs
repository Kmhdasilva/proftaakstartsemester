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
            this.Tabs = new System.Windows.Forms.TabControl();
            this.LoginTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.productPage = new System.Windows.Forms.TabPage();
            this.productNaam = new System.Windows.Forms.Label();
            this.productPanel = new System.Windows.Forms.Panel();
            this.productingredienten = new System.Windows.Forms.ListBox();
            this.productbeschrijving = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.product1button = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tabs.SuspendLayout();
            this.LoginTab.SuspendLayout();
            this.RegisterTab.SuspendLayout();
            this.productNumber.SuspendLayout();
            this.productPage.SuspendLayout();
            this.productPanel.SuspendLayout();
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
            this.Tabs.Location = new System.Drawing.Point(16, 15);
            this.Tabs.Margin = new System.Windows.Forms.Padding(4);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(607, 721);
            this.Tabs.TabIndex = 0;
            // 
            // LoginTab
            // 
            this.LoginTab.Controls.Add(this.label1);
            this.LoginTab.Controls.Add(this.button3);
            this.LoginTab.Controls.Add(this.button2);
            this.LoginTab.Controls.Add(this.button1);
            this.LoginTab.Controls.Add(this.label3);
            this.LoginTab.Controls.Add(this.label2);
            this.LoginTab.Controls.Add(this.textBox2);
            this.LoginTab.Controls.Add(this.textBox1);
            this.LoginTab.Location = new System.Drawing.Point(4, 25);
            this.LoginTab.Margin = new System.Windows.Forms.Padding(4);
            this.LoginTab.Name = "LoginTab";
            this.LoginTab.Padding = new System.Windows.Forms.Padding(4);
            this.LoginTab.Size = new System.Drawing.Size(599, 692);
            this.LoginTab.TabIndex = 0;
            this.LoginTab.Text = "Login";
            this.LoginTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 74);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 316);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(559, 53);
            this.button3.TabIndex = 7;
            this.button3.Text = "Registreren";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 242);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(271, 53);
            this.button2.TabIndex = 6;
            this.button2.Text = "Wachtwoord vergeten";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 242);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(567, 48);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gebruikersnaam";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(567, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wachtwoord";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 197);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(557, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 117);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(557, 22);
            this.textBox1.TabIndex = 0;
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
            this.RegisterTab.Location = new System.Drawing.Point(4, 25);
            this.RegisterTab.Margin = new System.Windows.Forms.Padding(4);
            this.RegisterTab.Name = "RegisterTab";
            this.RegisterTab.Padding = new System.Windows.Forms.Padding(4);
            this.RegisterTab.Size = new System.Drawing.Size(599, 692);
            this.RegisterTab.TabIndex = 1;
            this.RegisterTab.Text = "Register";
            this.RegisterTab.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(5, 235);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(567, 48);
            this.label7.TabIndex = 18;
            this.label7.Text = "E-mail";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(5, 287);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(557, 22);
            this.textBox5.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label4.Location = new System.Drawing.Point(5, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(559, 74);
            this.label4.TabIndex = 16;
            this.label4.Text = "Registreer";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(5, 335);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(559, 53);
            this.button4.TabIndex = 15;
            this.button4.Text = "Registreren";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(1, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(567, 48);
            this.label5.TabIndex = 12;
            this.label5.Text = "Gebruikersnaam";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(5, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(567, 48);
            this.label6.TabIndex = 11;
            this.label6.Text = "Wachtwoord";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(5, 196);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(557, 22);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(5, 116);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(557, 22);
            this.textBox4.TabIndex = 9;
            // 
            // productNumber
            // 
            this.productNumber.Controls.Add(this.button7);
            this.productNumber.Controls.Add(this.button6);
            this.productNumber.Controls.Add(this.product1button);
            this.productNumber.Location = new System.Drawing.Point(4, 25);
            this.productNumber.Name = "productNumber";
            this.productNumber.Padding = new System.Windows.Forms.Padding(3);
            this.productNumber.Size = new System.Drawing.Size(599, 692);
            this.productNumber.TabIndex = 4;
            this.productNumber.Text = "Product kiezen";
            this.productNumber.UseVisualStyleBackColor = true;
            // 
            // productPage
            // 
            this.productPage.AutoScroll = true;
            this.productPage.Controls.Add(this.productNaam);
            this.productPage.Controls.Add(this.productPanel);
            this.productPage.Location = new System.Drawing.Point(4, 25);
            this.productPage.Margin = new System.Windows.Forms.Padding(4);
            this.productPage.Name = "productPage";
            this.productPage.Padding = new System.Windows.Forms.Padding(4);
            this.productPage.Size = new System.Drawing.Size(599, 692);
            this.productPage.TabIndex = 3;
            this.productPage.Text = "productPage";
            this.productPage.UseVisualStyleBackColor = true;
            // 
            // productNaam
            // 
            this.productNaam.Location = new System.Drawing.Point(13, 8);
            this.productNaam.Name = "productNaam";
            this.productNaam.Size = new System.Drawing.Size(559, 57);
            this.productNaam.TabIndex = 1;
            this.productNaam.Text = "Producten";
            this.productNaam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productPanel
            // 
            this.productPanel.Controls.Add(this.productingredienten);
            this.productPanel.Controls.Add(this.productbeschrijving);
            this.productPanel.Controls.Add(this.pictureBox1);
            this.productPanel.Location = new System.Drawing.Point(13, 69);
            this.productPanel.Margin = new System.Windows.Forms.Padding(4);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(559, 364);
            this.productPanel.TabIndex = 0;
            // 
            // productingredienten
            // 
            this.productingredienten.FormattingEnabled = true;
            this.productingredienten.ItemHeight = 16;
            this.productingredienten.Location = new System.Drawing.Point(265, 65);
            this.productingredienten.Margin = new System.Windows.Forms.Padding(4);
            this.productingredienten.Name = "productingredienten";
            this.productingredienten.Size = new System.Drawing.Size(290, 276);
            this.productingredienten.TabIndex = 3;
            // 
            // productbeschrijving
            // 
            this.productbeschrijving.Location = new System.Drawing.Point(265, 5);
            this.productbeschrijving.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productbeschrijving.Name = "productbeschrijving";
            this.productbeschrijving.Size = new System.Drawing.Size(290, 56);
            this.productbeschrijving.TabIndex = 2;
            this.productbeschrijving.Text = "label13";
            this.productbeschrijving.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 336);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // product1button
            // 
            this.product1button.Location = new System.Drawing.Point(6, 6);
            this.product1button.Name = "product1button";
            this.product1button.Size = new System.Drawing.Size(587, 61);
            this.product1button.TabIndex = 0;
            this.product1button.Text = "product 1";
            this.product1button.UseVisualStyleBackColor = true;
            this.product1button.Click += new System.EventHandler(this.product1button_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 73);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(587, 61);
            this.button6.TabIndex = 1;
            this.button6.Text = "product 2";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 140);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(587, 61);
            this.button7.TabIndex = 2;
            this.button7.Text = "product 3";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(voedingskeuzeform.Program);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 760);
            this.Controls.Add(this.Tabs);
            this.Margin = new System.Windows.Forms.Padding(4);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage LoginTab;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage RegisterTab;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.ListBox productingredienten;
        private System.Windows.Forms.Label productbeschrijving;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.Label productNaam;
        private System.Windows.Forms.TabPage productNumber;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button product1button;
    }
}

