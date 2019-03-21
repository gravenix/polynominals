namespace Polynomials
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.formulaBox = new System.Windows.Forms.TextBox();
            this.drawBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelDrawing = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // formulaBox
            // 
            this.formulaBox.Location = new System.Drawing.Point(53, 12);
            this.formulaBox.Name = "formulaBox";
            this.formulaBox.Size = new System.Drawing.Size(697, 20);
            this.formulaBox.TabIndex = 0;
            // 
            // drawBtn
            // 
            this.drawBtn.Location = new System.Drawing.Point(756, 12);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(53, 20);
            this.drawBtn.TabIndex = 1;
            this.drawBtn.Text = "Rysuj";
            this.drawBtn.UseVisualStyleBackColor = true;
            this.drawBtn.Click += new System.EventHandler(this.onDraw);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wzór:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PanelDrawing
            // 
            this.PanelDrawing.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PanelDrawing.Location = new System.Drawing.Point(15, 38);
            this.PanelDrawing.Name = "PanelDrawing";
            this.PanelDrawing.Size = new System.Drawing.Size(794, 508);
            this.PanelDrawing.TabIndex = 3;
            this.PanelDrawing.Paint += new System.Windows.Forms.PaintEventHandler(this.drawFunction);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 558);
            this.Controls.Add(this.PanelDrawing);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawBtn);
            this.Controls.Add(this.formulaBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Polynomials";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox formulaBox;
        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel PanelDrawing;
    }
}

