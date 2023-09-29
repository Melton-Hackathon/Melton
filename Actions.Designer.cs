﻿namespace Melton
{
    partial class Actions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actions));
            this.Attack_button = new System.Windows.Forms.Button();
            this.Ability_Button = new System.Windows.Forms.Button();
            this.Skip_Button = new System.Windows.Forms.Button();
            this.Fehler_label = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Attack_button
            // 
            this.Attack_button.BackColor = System.Drawing.Color.Transparent;
            this.Attack_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Attack_button.BackgroundImage")));
            this.Attack_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Attack_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Attack_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attack_button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Attack_button.Location = new System.Drawing.Point(118, 45);
            this.Attack_button.Name = "Attack_button";
            this.Attack_button.Size = new System.Drawing.Size(100, 50);
            this.Attack_button.TabIndex = 0;
            this.Attack_button.Text = "Angreifen";
            this.Attack_button.UseVisualStyleBackColor = false;
            this.Attack_button.Click += new System.EventHandler(this.Attack_button_Click);
            // 
            // Ability_Button
            // 
            this.Ability_Button.BackColor = System.Drawing.Color.Transparent;
            this.Ability_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ability_Button.BackgroundImage")));
            this.Ability_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ability_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ability_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ability_Button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Ability_Button.Location = new System.Drawing.Point(326, 45);
            this.Ability_Button.Name = "Ability_Button";
            this.Ability_Button.Size = new System.Drawing.Size(100, 50);
            this.Ability_Button.TabIndex = 1;
            this.Ability_Button.Text = "Fähigkeiten";
            this.Ability_Button.UseVisualStyleBackColor = false;
            this.Ability_Button.Click += new System.EventHandler(this.Ability_Button_Click);
            this.Ability_Button.MouseHover += new System.EventHandler(this.Ability_Button_MouseHover);
            // 
            // Skip_Button
            // 
            this.Skip_Button.BackColor = System.Drawing.Color.Transparent;
            this.Skip_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Skip_Button.BackgroundImage")));
            this.Skip_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Skip_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Skip_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Skip_Button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Skip_Button.Location = new System.Drawing.Point(523, 45);
            this.Skip_Button.Name = "Skip_Button";
            this.Skip_Button.Size = new System.Drawing.Size(100, 50);
            this.Skip_Button.TabIndex = 2;
            this.Skip_Button.Text = "Überspringen";
            this.Skip_Button.UseVisualStyleBackColor = false;
            this.Skip_Button.Click += new System.EventHandler(this.Skip_Button_Click);
            this.Skip_Button.MouseHover += new System.EventHandler(this.Skip_Button_MouseHover);
            // 
            // Fehler_label
            // 
            this.Fehler_label.AutoSize = true;
            this.Fehler_label.BackColor = System.Drawing.Color.Transparent;
            this.Fehler_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fehler_label.ForeColor = System.Drawing.Color.White;
            this.Fehler_label.Location = new System.Drawing.Point(268, 4);
            this.Fehler_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Fehler_label.Name = "Fehler_label";
            this.Fehler_label.Size = new System.Drawing.Size(230, 37);
            this.Fehler_label.TabIndex = 3;
            this.Fehler_label.Text = "Fehlermeldung";
            // 
            // Actions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(779, 145);
            this.Controls.Add(this.Fehler_label);
            this.Controls.Add(this.Skip_Button);
            this.Controls.Add(this.Ability_Button);
            this.Controls.Add(this.Attack_button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Actions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Actions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Attack_button;
        private System.Windows.Forms.Button Ability_Button;
        private System.Windows.Forms.Button Skip_Button;
        private System.Windows.Forms.Label Fehler_label;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}