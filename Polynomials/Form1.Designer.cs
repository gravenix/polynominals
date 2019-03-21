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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.formulaBox = new System.Windows.Forms.TextBox();
            this.drawBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelDrawing = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.scaleInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.scaleInput)).BeginInit();
            this.SuspendLayout();
            // 
            // formulaBox
            // 
            this.formulaBox.Location = new System.Drawing.Point(53, 12);
            this.formulaBox.Name = "formulaBox";
            this.formulaBox.Size = new System.Drawing.Size(827, 20);
            this.formulaBox.TabIndex = 0;
            this.formulaBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // drawBtn
            // 
            this.drawBtn.Location = new System.Drawing.Point(886, 12);
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
            this.PanelDrawing.Size = new System.Drawing.Size(924, 564);
            this.PanelDrawing.TabIndex = 3;
            this.PanelDrawing.Paint += new System.Windows.Forms.PaintEventHandler(this.drawFunction);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(843, 610);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Scale:";
            // 
            // scaleInput
            // 
            this.scaleInput.Location = new System.Drawing.Point(886, 608);
            this.scaleInput.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.scaleInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.scaleInput.Name = "scaleInput";
            this.scaleInput.Size = new System.Drawing.Size(53, 20);
            this.scaleInput.TabIndex = 5;
            this.scaleInput.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.scaleInput.ValueChanged += new System.EventHandler(this.scaleChange);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 640);
            this.Controls.Add(this.scaleInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PanelDrawing);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawBtn);
            this.Controls.Add(this.formulaBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Polynomials";
            ((System.ComponentModel.ISupportInitialize)(this.scaleInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox formulaBox;
        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel PanelDrawing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown scaleInput;
    }
}

