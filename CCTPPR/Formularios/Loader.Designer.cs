
namespace CCTPPR.Formularios
{
    partial class Loader
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.entrada = new System.Windows.Forms.Label();
            this.cir = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.lbltextos = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // entrada
            // 
            this.entrada.AutoSize = true;
            this.entrada.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrada.ForeColor = System.Drawing.Color.White;
            this.entrada.Location = new System.Drawing.Point(22, 271);
            this.entrada.Name = "entrada";
            this.entrada.Size = new System.Drawing.Size(0, 25);
            this.entrada.TabIndex = 0;
            // 
            // cir
            // 
            this.cir.Animated = true;
            this.cir.AnimationSpeed = 0.6F;
            this.cir.BackColor = System.Drawing.Color.Transparent;
            this.cir.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.cir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cir.IdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.cir.IdleOffset = 5;
            this.cir.IdleThickness = 5;
            this.cir.Image = null;
            this.cir.ImageSize = new System.Drawing.Size(52, 52);
            this.cir.LineEndCap = System.Drawing.Drawing2D.LineCap.Triangle;
            this.cir.LineStartCap = System.Drawing.Drawing2D.LineCap.Triangle;
            this.cir.Location = new System.Drawing.Point(539, 237);
            this.cir.Margin = new System.Windows.Forms.Padding(0);
            this.cir.Name = "cir";
            this.cir.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.cir.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.cir.ProgressOffset = 25;
            this.cir.ProgressThickness = 10;
            this.cir.Size = new System.Drawing.Size(188, 188);
            this.cir.TabIndex = 8;
            this.cir.UseProgressPercentText = true;
            // 
            // lbltextos
            // 
            this.lbltextos.AutoSize = true;
            this.lbltextos.BackColor = System.Drawing.Color.Transparent;
            this.lbltextos.Font = new System.Drawing.Font("Centaur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltextos.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbltextos.Location = new System.Drawing.Point(303, 100);
            this.lbltextos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltextos.Name = "lbltextos";
            this.lbltextos.Size = new System.Drawing.Size(72, 27);
            this.lbltextos.TabIndex = 9;
            this.lbltextos.Text = "Saludo";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.lbltextos);
            this.Controls.Add(this.cir);
            this.Controls.Add(this.entrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loader";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Loader_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label entrada;
        private Guna.UI.WinForms.GunaCircleProgressBar cir;
        public Guna.UI.WinForms.GunaLabel lbltextos;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}