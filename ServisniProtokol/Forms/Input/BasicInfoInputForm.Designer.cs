namespace ServisniProtokol.Forms.Input
{
    partial class BasicInfoInputForm
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
            lCisloProduktu = new Label();
            lDatum = new Label();
            tCisloProduktu = new TextBox();
            dDatum = new DateTimePicker();
            bSubmit = new Button();
            bCancel = new Button();
            ErrorSetter = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)ErrorSetter).BeginInit();
            SuspendLayout();
            // 
            // lCisloProduktu
            // 
            lCisloProduktu.AutoSize = true;
            lCisloProduktu.Location = new Point(50, 30);
            lCisloProduktu.Name = "lCisloProduktu";
            lCisloProduktu.Size = new Size(88, 15);
            lCisloProduktu.TabIndex = 0;
            lCisloProduktu.Text = "Cislo produktu:";
            // 
            // lDatum
            // 
            lDatum.AutoSize = true;
            lDatum.Location = new Point(50, 60);
            lDatum.Name = "lDatum";
            lDatum.Size = new Size(86, 15);
            lDatum.TabIndex = 1;
            lDatum.Text = "Datum měření:";
            // 
            // tCisloProduktu
            // 
            tCisloProduktu.Location = new Point(142, 25);
            tCisloProduktu.Name = "tCisloProduktu";
            tCisloProduktu.Size = new Size(226, 23);
            tCisloProduktu.TabIndex = 2;
            // 
            // dDatum
            // 
            dDatum.Location = new Point(142, 54);
            dDatum.Name = "dDatum";
            dDatum.Size = new Size(226, 23);
            dDatum.TabIndex = 3;
            // 
            // bSubmit
            // 
            bSubmit.Location = new Point(212, 83);
            bSubmit.Name = "bSubmit";
            bSubmit.Size = new Size(75, 23);
            bSubmit.TabIndex = 4;
            bSubmit.Text = "Ok";
            bSubmit.UseVisualStyleBackColor = true;
            bSubmit.Click += bSubmit_Click;
            // 
            // bCancel
            // 
            bCancel.Location = new Point(293, 83);
            bCancel.Name = "bCancel";
            bCancel.Size = new Size(75, 23);
            bCancel.TabIndex = 5;
            bCancel.Text = "Cancel";
            bCancel.UseVisualStyleBackColor = true;
            bCancel.Click += bCancel_Click;
            // 
            // ErrorSetter
            // 
            ErrorSetter.ContainerControl = this;
            // 
            // BasicInfoInputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(401, 120);
            Controls.Add(bCancel);
            Controls.Add(bSubmit);
            Controls.Add(dDatum);
            Controls.Add(tCisloProduktu);
            Controls.Add(lDatum);
            Controls.Add(lCisloProduktu);
            Name = "BasicInfoInputForm";
            Text = "Základní informace";
            ((System.ComponentModel.ISupportInitialize)ErrorSetter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lCisloProduktu;
        private Label lDatum;
        private TextBox tCisloProduktu;
        private DateTimePicker dDatum;
        private Button bSubmit;
        private Button bCancel;
        private ErrorProvider ErrorSetter;
    }
}