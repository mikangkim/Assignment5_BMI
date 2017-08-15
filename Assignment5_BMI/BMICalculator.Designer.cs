/* Name : Mikang Kim
 * Student ID : 300921431
 * Date : August 14, 2017
 * Description : Assignment5 BMI Calculator
 * Version : 0.2 Design Changed
 */
namespace Assignment5_BMI
{
    partial class BMICalculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.BMIScaleTextBox = new System.Windows.Forms.TextBox();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RadioButton = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.BMIResultTextBox = new System.Windows.Forms.TextBox();
            this.TableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 420);
            this.button1.Margin = new System.Windows.Forms.Padding(7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BMIScaleTextBox
            // 
            this.BMIScaleTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.BMIScaleTextBox.Enabled = false;
            this.BMIScaleTextBox.Location = new System.Drawing.Point(12, 362);
            this.BMIScaleTextBox.Multiline = true;
            this.BMIScaleTextBox.Name = "BMIScaleTextBox";
            this.BMIScaleTextBox.Size = new System.Drawing.Size(287, 69);
            this.BMIScaleTextBox.TabIndex = 3;
            this.BMIScaleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BMIScaleTextBox.TextChanged += new System.EventHandler(this.BMIScaleTextBox_TextChanged);
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.Controls.Add(this.RadioButton, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.RadioButton1, 1, 0);
            this.TableLayoutPanel.Controls.Add(this.WeightLabel, 0, 3);
            this.TableLayoutPanel.Controls.Add(this.HeightTextBox, 0, 2);
            this.TableLayoutPanel.Controls.Add(this.WeightTextBox, 0, 4);
            this.TableLayoutPanel.Controls.Add(this.HeightLabel, 0, 1);
            this.TableLayoutPanel.Controls.Add(this.CalculateBMIButton, 0, 6);
            this.TableLayoutPanel.Controls.Add(this.ResetButton, 1, 6);
            this.TableLayoutPanel.Controls.Add(this.ResultLabel, 0, 5);
            this.TableLayoutPanel.Controls.Add(this.BMIResultTextBox, 1, 5);
            this.TableLayoutPanel.Location = new System.Drawing.Point(12, 16);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 7;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(287, 343);
            this.TableLayoutPanel.TabIndex = 4;
            // 
            // RadioButton
            // 
            this.RadioButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RadioButton.AutoSize = true;
            this.RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RadioButton.Location = new System.Drawing.Point(9, 12);
            this.RadioButton.Name = "RadioButton";
            this.RadioButton.Size = new System.Drawing.Size(124, 33);
            this.RadioButton.TabIndex = 0;
            this.RadioButton.Text = "Imperial";
            this.RadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RadioButton.UseVisualStyleBackColor = true;
            // 
            // RadioButton1
            // 
            this.RadioButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RadioButton1.Location = new System.Drawing.Point(163, 12);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(103, 33);
            this.RadioButton1.TabIndex = 1;
            this.RadioButton1.Text = "Metric";
            this.RadioButton1.UseVisualStyleBackColor = true;
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.TableLayoutPanel.SetColumnSpan(this.WeightLabel, 2);
            this.WeightLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WeightLabel.Location = new System.Drawing.Point(3, 153);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(281, 39);
            this.WeightLabel.TabIndex = 5;
            this.WeightLabel.Text = "My Weight";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TableLayoutPanel.SetColumnSpan(this.HeightTextBox, 2);
            this.HeightTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HeightTextBox.Location = new System.Drawing.Point(3, 99);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(281, 45);
            this.HeightTextBox.TabIndex = 3;
            this.HeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TableLayoutPanel.SetColumnSpan(this.WeightTextBox, 2);
            this.WeightTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WeightTextBox.Location = new System.Drawing.Point(3, 195);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(281, 45);
            this.WeightTextBox.TabIndex = 4;
            this.WeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.TableLayoutPanel.SetColumnSpan(this.HeightLabel, 2);
            this.HeightLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HeightLabel.Location = new System.Drawing.Point(3, 57);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(281, 39);
            this.HeightLabel.TabIndex = 2;
            this.HeightLabel.Text = "My Height";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.HeightLabel.Click += new System.EventHandler(this.HeightLabel_Click_1);
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.BackColor = System.Drawing.Color.Black;
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.CalculateBMIButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CalculateBMIButton.Location = new System.Drawing.Point(3, 291);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(134, 49);
            this.CalculateBMIButton.TabIndex = 6;
            this.CalculateBMIButton.TabStop = false;
            this.CalculateBMIButton.Text = "Cal";
            this.CalculateBMIButton.UseVisualStyleBackColor = false;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Crimson;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ResetButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ResetButton.Location = new System.Drawing.Point(146, 291);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(134, 49);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            // 
            // ResultLabel
            // 
            this.ResultLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ResultLabel.Location = new System.Drawing.Point(8, 240);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(132, 48);
            this.ResultLabel.TabIndex = 8;
            this.ResultLabel.Text = "BMI Result :";
            // 
            // BMIResultTextBox
            // 
            this.BMIResultTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BMIResultTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BMIResultTextBox.Enabled = false;
            this.BMIResultTextBox.Location = new System.Drawing.Point(146, 243);
            this.BMIResultTextBox.Name = "BMIResultTextBox";
            this.BMIResultTextBox.Size = new System.Drawing.Size(138, 45);
            this.BMIResultTextBox.TabIndex = 9;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.TableLayoutPanel);
            this.Controls.Add(this.BMIScaleTextBox);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.BMICalculator_Load_1);
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox BMIScaleTextBox;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.RadioButton RadioButton;
        private System.Windows.Forms.RadioButton RadioButton1;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox BMIResultTextBox;

       
    }
}

