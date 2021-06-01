
namespace GUI
{
    partial class frmQltyCtrl
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
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblWithdrawalReason = new MetroSet_UI.Controls.MetroSetLabel();
            this.rtbWhitdrawalDescription = new MetroSet_UI.Controls.MetroSetRichTextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(294, 304);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(261, 27);
            this.btnCancel.TabIndex = 52;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(12, 304);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(261, 27);
            this.materialRaisedButton1.TabIndex = 53;
            this.materialRaisedButton1.Text = "CONFIRMAR BAJA";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // lblWithdrawalReason
            // 
            this.lblWithdrawalReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblWithdrawalReason.IsDerivedStyle = true;
            this.lblWithdrawalReason.Location = new System.Drawing.Point(12, 80);
            this.lblWithdrawalReason.Name = "lblWithdrawalReason";
            this.lblWithdrawalReason.Size = new System.Drawing.Size(448, 19);
            this.lblWithdrawalReason.Style = MetroSet_UI.Enums.Style.Light;
            this.lblWithdrawalReason.StyleManager = null;
            this.lblWithdrawalReason.TabIndex = 54;
            this.lblWithdrawalReason.Text = "DESCRIBA BREVEMENTE LA RAZON DE LA BAJA DEL ELEMENTO:";
            this.lblWithdrawalReason.ThemeAuthor = "Narwin";
            this.lblWithdrawalReason.ThemeName = "MetroLite";
            // 
            // rtbWhitdrawalDescription
            // 
            this.rtbWhitdrawalDescription.AutoWordSelection = false;
            this.rtbWhitdrawalDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.rtbWhitdrawalDescription.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.rtbWhitdrawalDescription.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.rtbWhitdrawalDescription.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.rtbWhitdrawalDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtbWhitdrawalDescription.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.rtbWhitdrawalDescription.IsDerivedStyle = true;
            this.rtbWhitdrawalDescription.Lines = null;
            this.rtbWhitdrawalDescription.Location = new System.Drawing.Point(12, 102);
            this.rtbWhitdrawalDescription.MaxLength = 32767;
            this.rtbWhitdrawalDescription.Name = "rtbWhitdrawalDescription";
            this.rtbWhitdrawalDescription.ReadOnly = false;
            this.rtbWhitdrawalDescription.Size = new System.Drawing.Size(543, 196);
            this.rtbWhitdrawalDescription.Style = MetroSet_UI.Enums.Style.Light;
            this.rtbWhitdrawalDescription.StyleManager = null;
            this.rtbWhitdrawalDescription.TabIndex = 55;
            this.rtbWhitdrawalDescription.ThemeAuthor = "Narwin";
            this.rtbWhitdrawalDescription.ThemeName = "MetroLite";
            this.rtbWhitdrawalDescription.WordWrap = true;
            // 
            // frmQltyCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(567, 344);
            this.ControlBox = false;
            this.Controls.Add(this.rtbWhitdrawalDescription);
            this.Controls.Add(this.lblWithdrawalReason);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.btnCancel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmQltyCtrl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BAJA DE ELEMENTO";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MetroSet_UI.Controls.MetroSetLabel lblWithdrawalReason;
        private MetroSet_UI.Controls.MetroSetRichTextBox rtbWhitdrawalDescription;
    }
}