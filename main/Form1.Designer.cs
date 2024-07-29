namespace ahorcado
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LetraTextBox = new TextBox();
            PalabraLabel = new Label();
            IntentosLabel = new Label();
            AhorcadoTextBox = new TextBox();
            IntentoPalabraTextBox = new TextBox();
            IntentarPalabraButton = new Button();
            letras_usadas = new TextBox();
            SuspendLayout();
            // 
            // LetraTextBox
            // 
            LetraTextBox.Location = new Point(55, 92);
            LetraTextBox.Margin = new Padding(4, 3, 4, 3);
            LetraTextBox.Name = "LetraTextBox";
            LetraTextBox.Size = new Size(116, 23);
            LetraTextBox.TabIndex = 0;
            LetraTextBox.KeyPress += LetraTextBox_KeyPress;
            // 
            // PalabraLabel
            // 
            PalabraLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            PalabraLabel.Location = new Point(61, 24);
            PalabraLabel.Margin = new Padding(4, 0, 4, 0);
            PalabraLabel.Name = "PalabraLabel";
            PalabraLabel.Size = new Size(351, 55);
            PalabraLabel.TabIndex = 1;
            // 
            // IntentosLabel
            // 
            IntentosLabel.Location = new Point(60, 161);
            IntentosLabel.Margin = new Padding(4, 0, 4, 0);
            IntentosLabel.Name = "IntentosLabel";
            IntentosLabel.Size = new Size(199, 27);
            IntentosLabel.TabIndex = 2;
            // 
            // AhorcadoTextBox
            // 
            AhorcadoTextBox.Location = new Point(60, 185);
            AhorcadoTextBox.Margin = new Padding(4, 3, 4, 3);
            AhorcadoTextBox.Multiline = true;
            AhorcadoTextBox.Name = "AhorcadoTextBox";
            AhorcadoTextBox.ReadOnly = true;
            AhorcadoTextBox.Size = new Size(233, 115);
            AhorcadoTextBox.TabIndex = 3;
            // 
            // IntentoPalabraTextBox
            // 
            IntentoPalabraTextBox.Location = new Point(61, 310);
            IntentoPalabraTextBox.Margin = new Padding(4, 3, 4, 3);
            IntentoPalabraTextBox.Name = "IntentoPalabraTextBox";
            IntentoPalabraTextBox.Size = new Size(116, 23);
            IntentoPalabraTextBox.TabIndex = 4;
            // 
            // IntentarPalabraButton
            // 
            IntentarPalabraButton.Location = new Point(184, 306);
            IntentarPalabraButton.Margin = new Padding(4, 3, 4, 3);
            IntentarPalabraButton.Name = "IntentarPalabraButton";
            IntentarPalabraButton.Size = new Size(117, 27);
            IntentarPalabraButton.TabIndex = 5;
            IntentarPalabraButton.Text = "Intentar Palabra";
            IntentarPalabraButton.UseVisualStyleBackColor = true;
            IntentarPalabraButton.Click += IntentoPalabraButton_Click;
            // 
            // letras_usadas
            // 
            letras_usadas.Location = new Point(179, 92);
            letras_usadas.Margin = new Padding(4, 3, 4, 3);
            letras_usadas.Multiline = true;
            letras_usadas.Name = "letras_usadas";
            letras_usadas.ReadOnly = true;
            letras_usadas.Size = new Size(233, 66);
            letras_usadas.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 368);
            Controls.Add(letras_usadas);
            Controls.Add(IntentarPalabraButton);
            Controls.Add(IntentoPalabraTextBox);
            Controls.Add(AhorcadoTextBox);
            Controls.Add(IntentosLabel);
            Controls.Add(PalabraLabel);
            Controls.Add(LetraTextBox);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Ahorcado";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox LetraTextBox;
        private System.Windows.Forms.Label PalabraLabel;
        private System.Windows.Forms.Label IntentosLabel;
        private System.Windows.Forms.TextBox AhorcadoTextBox;
        private System.Windows.Forms.TextBox IntentoPalabraTextBox;
        private System.Windows.Forms.Button IntentarPalabraButton;
        #endregion

        private TextBox letras_usadas;
    }
}