namespace ILMerge_vs_WpfMath
{
    partial class Renderer
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
            this.pictureBoxEquation = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEquation)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxEquation
            // 
            this.pictureBoxEquation.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxEquation.Name = "pictureBoxEquation";
            this.pictureBoxEquation.Size = new System.Drawing.Size(378, 131);
            this.pictureBoxEquation.TabIndex = 0;
            this.pictureBoxEquation.TabStop = false;
            // 
            // Renderer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 155);
            this.Controls.Add(this.pictureBoxEquation);
            this.Name = "Renderer";
            this.Text = "Renderer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEquation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEquation;
    }
}

