namespace ServisniProtokol.Forms
{
    partial class PreviewForm
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
            pPaintBox = new PictureBox();
            bBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pPaintBox).BeginInit();
            SuspendLayout();
            // 
            // pPaintBox
            // 
            pPaintBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pPaintBox.Location = new Point(12, 33);
            pPaintBox.Name = "pPaintBox";
            pPaintBox.Size = new Size(743, 619);
            pPaintBox.TabIndex = 0;
            pPaintBox.TabStop = false;
            pPaintBox.Paint += pPaintBox_Paint;
            pPaintBox.Resize += pPaintBox_Resize;
            // 
            // bBack
            // 
            bBack.Location = new Point(12, 4);
            bBack.Name = "bBack";
            bBack.Size = new Size(75, 23);
            bBack.TabIndex = 1;
            bBack.Text = "Zpět";
            bBack.UseVisualStyleBackColor = true;
            bBack.Click += bBack_Click;
            // 
            // PreviewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 664);
            Controls.Add(bBack);
            Controls.Add(pPaintBox);
            MinimumSize = new Size(600, 550);
            Name = "PreviewForm";
            Text = "PreviewForm";
            ((System.ComponentModel.ISupportInitialize)pPaintBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pPaintBox;
        private Button bBack;
    }
}