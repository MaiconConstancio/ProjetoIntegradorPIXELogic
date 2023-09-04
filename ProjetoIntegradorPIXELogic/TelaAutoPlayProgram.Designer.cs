namespace ProjetoIntegradorPIXELogic
{
    partial class TelaAutoPlayProgram
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
            PainelPrincipalParaTelas = new Panel();
            SuspendLayout();
            // 
            // PainelPrincipalParaTelas
            // 
            PainelPrincipalParaTelas.Location = new Point(0, 0);
            PainelPrincipalParaTelas.Name = "PainelPrincipalParaTelas";
            PainelPrincipalParaTelas.Size = new Size(805, 455);
            PainelPrincipalParaTelas.TabIndex = 0;
            // 
            // TelaAutoPlayProgram
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 25, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(PainelPrincipalParaTelas);
            Name = "TelaAutoPlayProgram";
            Text = "PIXELogic - Sua visão, Nossa programação";
            ResumeLayout(false);
        }

        #endregion

        private Panel PainelPrincipalParaTelas;
    }
}