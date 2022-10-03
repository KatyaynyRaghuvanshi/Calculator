using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculator_Application
{
    partial class Calculator
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
        private void InitializeComponent()
        {
            this.calculatorLayout = new System.Windows.Forms.TableLayoutPanel();
            this.displayKeyPanel = new System.Windows.Forms.TableLayoutPanel();
            this.operatorOperandKeyPanel = new System.Windows.Forms.TableLayoutPanel();
            this.memoryKeyPanel = new System.Windows.Forms.TableLayoutPanel();
            this.calculatorLayout.SuspendLayout();
            this.displayKeyPanel.SuspendLayout();
            this.SuspendLayout();
            this.calculatorLayout.BackColor = System.Drawing.SystemColors.Control;
            this.calculatorLayout.ColumnCount = 2;
            this.calculatorLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.calculatorLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.calculatorLayout.Controls.Add(this.displayKeyPanel, 0, 1);
            this.calculatorLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculatorLayout.Location = new System.Drawing.Point(0, 0);
            this.calculatorLayout.Margin = new System.Windows.Forms.Padding(2);
            this.calculatorLayout.Name = "calculatorLayout";
            this.calculatorLayout.RowCount = 2;
            this.calculatorLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.calculatorLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.calculatorLayout.Size = new System.Drawing.Size(572, 529);
            this.calculatorLayout.TabIndex = 0;
            this.displayKeyPanel.BackColor = System.Drawing.SystemColors.Control;
            this.displayKeyPanel.ColumnCount = 1;
            this.displayKeyPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.displayKeyPanel.Controls.Add(this.operatorOperandKeyPanel, 0, 3);
            this.displayKeyPanel.Controls.Add(this.memoryKeyPanel, 0, 2);
            this.displayKeyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayKeyPanel.Location = new System.Drawing.Point(2, 54);
            this.displayKeyPanel.Margin = new System.Windows.Forms.Padding(2);
            this.displayKeyPanel.Name = "displayKeyPanel";
            this.displayKeyPanel.RowCount = 4;
            this.displayKeyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.displayKeyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.05074F));
            this.displayKeyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.68499F));
            this.displayKeyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.displayKeyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.displayKeyPanel.Size = new System.Drawing.Size(339, 473);
            this.displayKeyPanel.TabIndex = 0;
            this.displayKeyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.displayKeyPanel_Paint);
            this.operatorOperandKeyPanel.BackColor = System.Drawing.Color.Azure;
            this.operatorOperandKeyPanel.ColumnCount = 4;
            this.operatorOperandKeyPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.operatorOperandKeyPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.operatorOperandKeyPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.operatorOperandKeyPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.operatorOperandKeyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operatorOperandKeyPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.operatorOperandKeyPanel.Location = new System.Drawing.Point(2, 190);
            this.operatorOperandKeyPanel.Margin = new System.Windows.Forms.Padding(2);
            this.operatorOperandKeyPanel.Name = "operatorOperandKeyPanel";
            this.operatorOperandKeyPanel.RowCount = 6;
            this.operatorOperandKeyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.operatorOperandKeyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.operatorOperandKeyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.operatorOperandKeyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.operatorOperandKeyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.operatorOperandKeyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.operatorOperandKeyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.operatorOperandKeyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.operatorOperandKeyPanel.Size = new System.Drawing.Size(335, 281);
            this.operatorOperandKeyPanel.TabIndex = 1;
            this.operatorOperandKeyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.operatorOperandKeyPanel_Paint);
            this.memoryKeyPanel.BackColor = System.Drawing.Color.LightBlue;
            this.memoryKeyPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.memoryKeyPanel.ColumnCount = 5;
            this.memoryKeyPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.memoryKeyPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.memoryKeyPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.memoryKeyPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.memoryKeyPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.memoryKeyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoryKeyPanel.Location = new System.Drawing.Point(2, 130);
            this.memoryKeyPanel.Margin = new System.Windows.Forms.Padding(2);
            this.memoryKeyPanel.Name = "memoryKeyPanel";
            this.memoryKeyPanel.RowCount = 1;
            this.memoryKeyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.memoryKeyPanel.Size = new System.Drawing.Size(335, 56);
            this.memoryKeyPanel.TabIndex = 0;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 529);
            this.Controls.Add(this.calculatorLayout);
            this.MinimumSize = new System.Drawing.Size(319, 568);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.TransparencyKey = System.Drawing.Color.White;
            this.calculatorLayout.ResumeLayout(false);
            this.displayKeyPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private TableLayoutPanel calculatorLayout;
        private TableLayoutPanel displayKeyPanel;
        private TableLayoutPanel memoryKeyPanel;
        private TableLayoutPanel operatorOperandKeyPanel;
    }
}
