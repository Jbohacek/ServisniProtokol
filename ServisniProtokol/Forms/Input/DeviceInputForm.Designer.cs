namespace ServisniProtokol.Forms.Input
{
    partial class DeviceInputForm
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
            lVyrobce = new Label();
            lModel = new Label();
            lSeriove = new Label();
            tVyrobce = new TextBox();
            tModel = new TextBox();
            tSerioveCislo = new TextBox();
            bCancel = new Button();
            bSubmit = new Button();
            ErrorSetter = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)ErrorSetter).BeginInit();
            SuspendLayout();
            // 
            // lVyrobce
            // 
            lVyrobce.AutoSize = true;
            lVyrobce.Location = new Point(12, 22);
            lVyrobce.Name = "lVyrobce";
            lVyrobce.Size = new Size(53, 15);
            lVyrobce.TabIndex = 0;
            lVyrobce.Text = "Výrobce:";
            // 
            // lModel
            // 
            lModel.AutoSize = true;
            lModel.Location = new Point(12, 49);
            lModel.Name = "lModel";
            lModel.Size = new Size(44, 15);
            lModel.TabIndex = 1;
            lModel.Text = "Model:";
            // 
            // lSeriove
            // 
            lSeriove.AutoSize = true;
            lSeriove.Location = new Point(12, 78);
            lSeriove.Name = "lSeriove";
            lSeriove.Size = new Size(72, 15);
            lSeriove.TabIndex = 2;
            lSeriove.Text = "Seriové číslo";
            // 
            // tVyrobce
            // 
            tVyrobce.Location = new Point(90, 19);
            tVyrobce.Name = "tVyrobce";
            tVyrobce.Size = new Size(145, 23);
            tVyrobce.TabIndex = 3;
            // 
            // tModel
            // 
            tModel.Location = new Point(90, 46);
            tModel.Name = "tModel";
            tModel.Size = new Size(145, 23);
            tModel.TabIndex = 4;
            // 
            // tSerioveCislo
            // 
            tSerioveCislo.Location = new Point(90, 75);
            tSerioveCislo.Name = "tSerioveCislo";
            tSerioveCislo.Size = new Size(145, 23);
            tSerioveCislo.TabIndex = 5;
            // 
            // bCancel
            // 
            bCancel.Location = new Point(160, 113);
            bCancel.Name = "bCancel";
            bCancel.Size = new Size(75, 23);
            bCancel.TabIndex = 6;
            bCancel.Text = "Cancel";
            bCancel.UseVisualStyleBackColor = true;
            bCancel.Click += bCancel_Click;
            // 
            // bSubmit
            // 
            bSubmit.Location = new Point(79, 113);
            bSubmit.Name = "bSubmit";
            bSubmit.Size = new Size(75, 23);
            bSubmit.TabIndex = 7;
            bSubmit.Text = "Ok";
            bSubmit.UseVisualStyleBackColor = true;
            bSubmit.Click += bSubmit_Click;
            // 
            // ErrorSetter
            // 
            ErrorSetter.ContainerControl = this;
            // 
            // DeviceInputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 148);
            Controls.Add(bSubmit);
            Controls.Add(bCancel);
            Controls.Add(tSerioveCislo);
            Controls.Add(tModel);
            Controls.Add(tVyrobce);
            Controls.Add(lSeriove);
            Controls.Add(lModel);
            Controls.Add(lVyrobce);
            Name = "DeviceInputForm";
            Text = "Zařízení";
            Shown += DeviceInputForm_Shown;
            ((System.ComponentModel.ISupportInitialize)ErrorSetter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lVyrobce;
        private Label lModel;
        private Label lSeriove;
        private TextBox tVyrobce;
        private TextBox tModel;
        private TextBox tSerioveCislo;
        private Button bCancel;
        private Button bSubmit;
        private ErrorProvider ErrorSetter;
    }
}