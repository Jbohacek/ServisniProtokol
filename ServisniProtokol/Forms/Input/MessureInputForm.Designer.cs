namespace ServisniProtokol.Forms.Input
{
    partial class MessureInputForm
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
            components = new System.ComponentModel.Container();
            lParametr = new Label();
            lNamerenaHodnota = new Label();
            lJednotka = new Label();
            lVyhovuje = new Label();
            tParametr = new TextBox();
            tNamerenaJednotka = new TextBox();
            tJednotka = new TextBox();
            cVyhovuje = new CheckBox();
            bSubmit = new Button();
            bCancel = new Button();
            ErrorSetter = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)ErrorSetter).BeginInit();
            SuspendLayout();
            // 
            // lParametr
            // 
            lParametr.AutoSize = true;
            lParametr.Location = new Point(12, 36);
            lParametr.Name = "lParametr";
            lParametr.Size = new Size(58, 15);
            lParametr.TabIndex = 0;
            lParametr.Text = "Parametr:";
            // 
            // lNamerenaHodnota
            // 
            lNamerenaHodnota.AutoSize = true;
            lNamerenaHodnota.Location = new Point(12, 71);
            lNamerenaHodnota.Name = "lNamerenaHodnota";
            lNamerenaHodnota.Size = new Size(113, 15);
            lNamerenaHodnota.TabIndex = 1;
            lNamerenaHodnota.Text = "Naměřená hodnota:";
            // 
            // lJednotka
            // 
            lJednotka.AutoSize = true;
            lJednotka.Location = new Point(12, 107);
            lJednotka.Name = "lJednotka";
            lJednotka.Size = new Size(54, 15);
            lJednotka.TabIndex = 2;
            lJednotka.Text = "Jednotka";
            // 
            // lVyhovuje
            // 
            lVyhovuje.AutoSize = true;
            lVyhovuje.Location = new Point(12, 140);
            lVyhovuje.Name = "lVyhovuje";
            lVyhovuje.Size = new Size(56, 15);
            lVyhovuje.TabIndex = 3;
            lVyhovuje.Text = "Vyhovuje";
            // 
            // tParametr
            // 
            tParametr.Location = new Point(157, 33);
            tParametr.Name = "tParametr";
            tParametr.Size = new Size(100, 23);
            tParametr.TabIndex = 4;
            // 
            // tNamerenaJednotka
            // 
            tNamerenaJednotka.Location = new Point(157, 68);
            tNamerenaJednotka.Name = "tNamerenaJednotka";
            tNamerenaJednotka.Size = new Size(100, 23);
            tNamerenaJednotka.TabIndex = 5;
            // 
            // tJednotka
            // 
            tJednotka.Location = new Point(157, 104);
            tJednotka.Name = "tJednotka";
            tJednotka.Size = new Size(100, 23);
            tJednotka.TabIndex = 6;
            // 
            // cVyhovuje
            // 
            cVyhovuje.AutoSize = true;
            cVyhovuje.Location = new Point(157, 140);
            cVyhovuje.Name = "cVyhovuje";
            cVyhovuje.Size = new Size(15, 14);
            cVyhovuje.TabIndex = 7;
            cVyhovuje.UseVisualStyleBackColor = true;
            // 
            // bSubmit
            // 
            bSubmit.Location = new Point(103, 160);
            bSubmit.Name = "bSubmit";
            bSubmit.Size = new Size(75, 23);
            bSubmit.TabIndex = 8;
            bSubmit.Text = "Ok";
            bSubmit.UseVisualStyleBackColor = true;
            bSubmit.Click += bSubmit_Click;
            // 
            // bCancel
            // 
            bCancel.Location = new Point(182, 160);
            bCancel.Name = "bCancel";
            bCancel.Size = new Size(75, 23);
            bCancel.TabIndex = 9;
            bCancel.Text = "Cancel";
            bCancel.UseVisualStyleBackColor = true;
            bCancel.Click += bCancel_Click;
            // 
            // ErrorSetter
            // 
            ErrorSetter.ContainerControl = this;
            // 
            // MessureInputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 209);
            Controls.Add(bCancel);
            Controls.Add(bSubmit);
            Controls.Add(cVyhovuje);
            Controls.Add(tJednotka);
            Controls.Add(tNamerenaJednotka);
            Controls.Add(tParametr);
            Controls.Add(lVyhovuje);
            Controls.Add(lJednotka);
            Controls.Add(lNamerenaHodnota);
            Controls.Add(lParametr);
            Name = "MessureInputForm";
            Text = "MessureInputForm";
            ((System.ComponentModel.ISupportInitialize)ErrorSetter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lParametr;
        private Label lNamerenaHodnota;
        private Label lJednotka;
        private Label lVyhovuje;
        private TextBox tParametr;
        private TextBox tNamerenaJednotka;
        private TextBox tJednotka;
        private CheckBox cVyhovuje;
        private Button bSubmit;
        private Button bCancel;
        private ErrorProvider ErrorSetter;
    }
}