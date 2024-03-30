namespace ServisniProtokol.Forms.Input
{
    partial class CustomerInputForm
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
            lNazev = new Label();
            lAdresa = new Label();
            lPsc = new Label();
            lIc = new Label();
            tIco = new TextBox();
            tPSC = new TextBox();
            tAdresa = new TextBox();
            tNazev = new TextBox();
            bCancel = new Button();
            bSubmit = new Button();
            SetError = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)SetError).BeginInit();
            SuspendLayout();
            // 
            // lNazev
            // 
            lNazev.AutoSize = true;
            lNazev.Location = new Point(12, 25);
            lNazev.Name = "lNazev";
            lNazev.Size = new Size(39, 15);
            lNazev.TabIndex = 0;
            lNazev.Text = "Název";
            // 
            // lAdresa
            // 
            lAdresa.AutoSize = true;
            lAdresa.Location = new Point(12, 59);
            lAdresa.Name = "lAdresa";
            lAdresa.Size = new Size(43, 15);
            lAdresa.TabIndex = 1;
            lAdresa.Text = "Adresa";
            // 
            // lPsc
            // 
            lPsc.AutoSize = true;
            lPsc.Location = new Point(12, 99);
            lPsc.Name = "lPsc";
            lPsc.Size = new Size(28, 15);
            lPsc.TabIndex = 2;
            lPsc.Text = "PSČ";
            // 
            // lIc
            // 
            lIc.AutoSize = true;
            lIc.Location = new Point(13, 135);
            lIc.Name = "lIc";
            lIc.Size = new Size(18, 15);
            lIc.TabIndex = 3;
            lIc.Text = "IC";
            // 
            // tIco
            // 
            tIco.Location = new Point(78, 132);
            tIco.Name = "tIco";
            tIco.Size = new Size(263, 23);
            tIco.TabIndex = 4;
            // 
            // tPSC
            // 
            tPSC.Location = new Point(78, 96);
            tPSC.Name = "tPSC";
            tPSC.Size = new Size(263, 23);
            tPSC.TabIndex = 5;
            // 
            // tAdresa
            // 
            tAdresa.Location = new Point(78, 56);
            tAdresa.Name = "tAdresa";
            tAdresa.Size = new Size(263, 23);
            tAdresa.TabIndex = 6;
            // 
            // tNazev
            // 
            tNazev.Location = new Point(78, 22);
            tNazev.Name = "tNazev";
            tNazev.Size = new Size(263, 23);
            tNazev.TabIndex = 7;
            // 
            // bCancel
            // 
            bCancel.Location = new Point(266, 161);
            bCancel.Name = "bCancel";
            bCancel.Size = new Size(75, 23);
            bCancel.TabIndex = 8;
            bCancel.Text = "Cancel";
            bCancel.UseVisualStyleBackColor = true;
            bCancel.Click += bCancel_Click;
            // 
            // bSubmit
            // 
            bSubmit.Location = new Point(185, 161);
            bSubmit.Name = "bSubmit";
            bSubmit.Size = new Size(75, 23);
            bSubmit.TabIndex = 9;
            bSubmit.Text = "Submit";
            bSubmit.UseVisualStyleBackColor = true;
            bSubmit.Click += bSubmit_Click;
            // 
            // SetError
            // 
            SetError.ContainerControl = this;
            // 
            // CustomerInputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 202);
            Controls.Add(bSubmit);
            Controls.Add(bCancel);
            Controls.Add(tNazev);
            Controls.Add(tAdresa);
            Controls.Add(tPSC);
            Controls.Add(tIco);
            Controls.Add(lIc);
            Controls.Add(lPsc);
            Controls.Add(lAdresa);
            Controls.Add(lNazev);
            Name = "CustomerInputForm";
            Text = "Zákazník";
            ((System.ComponentModel.ISupportInitialize)SetError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lNazev;
        private Label lAdresa;
        private Label lPsc;
        private Label lIc;
        private TextBox tIco;
        private TextBox tPSC;
        private TextBox tAdresa;
        private TextBox tNazev;
        private Button bCancel;
        private Button bSubmit;
        private ErrorProvider SetError;
    }
}