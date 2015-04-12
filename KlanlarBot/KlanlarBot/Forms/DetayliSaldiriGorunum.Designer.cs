using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace KlanlarBot
{
    partial class DetayliSaldiriGorunum
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
            this.dgvSaldiri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaldiri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSaldiri
            // 
            this.dgvSaldiri.AllowUserToAddRows = false;
            this.dgvSaldiri.AllowUserToDeleteRows = false;
            this.dgvSaldiri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSaldiri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaldiri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSaldiri.Location = new System.Drawing.Point(0, 0);
            this.dgvSaldiri.Name = "dgvSaldiri";
            this.dgvSaldiri.ReadOnly = true;
            this.dgvSaldiri.Size = new System.Drawing.Size(658, 319);
            this.dgvSaldiri.TabIndex = 41;
            // 
            // DetayliSaldiriGorunum
            // 
            this.ClientSize = new System.Drawing.Size(658, 319);
            this.Controls.Add(this.dgvSaldiri);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "DetayliSaldiriGorunum";
            this.Text = "Detayli Görünüm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaldiri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvSaldiri;

























    }
}