﻿namespace Wangjianlong.functionality.Tools
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DefineProjectionButton = new System.Windows.Forms.Button();
            this.MergeTCMCButton = new System.Windows.Forms.Button();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.Projectionbutton = new System.Windows.Forms.Button();
            this.PolylineToPolygonbutton = new System.Windows.Forms.Button();
            this.ProgressBarButton = new System.Windows.Forms.Button();
            this.ExtractCADButton = new System.Windows.Forms.Button();
            this.Synthesisbutton = new System.Windows.Forms.Button();
            this.TxtToArcGISbutton = new System.Windows.Forms.Button();
            this.Provincebutton = new System.Windows.Forms.Button();
            this.MultiAccessbutton = new System.Windows.Forms.Button();
            this.MutipleSelectButton = new System.Windows.Forms.Button();
            this.MutipleClipbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // DefineProjectionButton
            // 
            this.DefineProjectionButton.Location = new System.Drawing.Point(12, 12);
            this.DefineProjectionButton.Name = "DefineProjectionButton";
            this.DefineProjectionButton.Size = new System.Drawing.Size(193, 23);
            this.DefineProjectionButton.TabIndex = 0;
            this.DefineProjectionButton.Text = "批量定义（Define Projection）";
            this.DefineProjectionButton.UseVisualStyleBackColor = true;
            this.DefineProjectionButton.Click += new System.EventHandler(this.DefineProjectionButton_Click);
            // 
            // MergeTCMCButton
            // 
            this.MergeTCMCButton.Location = new System.Drawing.Point(12, 43);
            this.MergeTCMCButton.Name = "MergeTCMCButton";
            this.MergeTCMCButton.Size = new System.Drawing.Size(193, 23);
            this.MergeTCMCButton.TabIndex = 1;
            this.MergeTCMCButton.Text = "合并（关联图层名）";
            this.MergeTCMCButton.UseVisualStyleBackColor = true;
            this.MergeTCMCButton.Click += new System.EventHandler(this.MergeTCMCButton_Click);
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(173, 407);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 2;
            // 
            // Projectionbutton
            // 
            this.Projectionbutton.Location = new System.Drawing.Point(12, 72);
            this.Projectionbutton.Name = "Projectionbutton";
            this.Projectionbutton.Size = new System.Drawing.Size(193, 23);
            this.Projectionbutton.TabIndex = 3;
            this.Projectionbutton.Text = "批量转坐标（Projection）";
            this.Projectionbutton.UseVisualStyleBackColor = true;
            this.Projectionbutton.Click += new System.EventHandler(this.Projectionbutton_Click);
            // 
            // PolylineToPolygonbutton
            // 
            this.PolylineToPolygonbutton.Location = new System.Drawing.Point(12, 101);
            this.PolylineToPolygonbutton.Name = "PolylineToPolygonbutton";
            this.PolylineToPolygonbutton.Size = new System.Drawing.Size(192, 23);
            this.PolylineToPolygonbutton.TabIndex = 4;
            this.PolylineToPolygonbutton.Text = "PolylineToPolygon";
            this.PolylineToPolygonbutton.UseVisualStyleBackColor = true;
            this.PolylineToPolygonbutton.Click += new System.EventHandler(this.PolylineToPolygonbutton_Click);
            // 
            // ProgressBarButton
            // 
            this.ProgressBarButton.Location = new System.Drawing.Point(13, 373);
            this.ProgressBarButton.Name = "ProgressBarButton";
            this.ProgressBarButton.Size = new System.Drawing.Size(192, 23);
            this.ProgressBarButton.TabIndex = 5;
            this.ProgressBarButton.Text = "ProgressBar";
            this.ProgressBarButton.UseVisualStyleBackColor = true;
            this.ProgressBarButton.Click += new System.EventHandler(this.ProgressBarButton_Click);
            // 
            // ExtractCADButton
            // 
            this.ExtractCADButton.Location = new System.Drawing.Point(12, 131);
            this.ExtractCADButton.Name = "ExtractCADButton";
            this.ExtractCADButton.Size = new System.Drawing.Size(192, 23);
            this.ExtractCADButton.TabIndex = 6;
            this.ExtractCADButton.Text = "提取CAD图层文件";
            this.ExtractCADButton.UseVisualStyleBackColor = true;
            this.ExtractCADButton.Click += new System.EventHandler(this.ExtractCADButton_Click);
            // 
            // Synthesisbutton
            // 
            this.Synthesisbutton.Location = new System.Drawing.Point(12, 160);
            this.Synthesisbutton.Name = "Synthesisbutton";
            this.Synthesisbutton.Size = new System.Drawing.Size(192, 23);
            this.Synthesisbutton.TabIndex = 7;
            this.Synthesisbutton.Text = "多线段合成";
            this.Synthesisbutton.UseVisualStyleBackColor = true;
            this.Synthesisbutton.Click += new System.EventHandler(this.Synthesisbutton_Click);
            // 
            // TxtToArcGISbutton
            // 
            this.TxtToArcGISbutton.Location = new System.Drawing.Point(12, 190);
            this.TxtToArcGISbutton.Name = "TxtToArcGISbutton";
            this.TxtToArcGISbutton.Size = new System.Drawing.Size(192, 23);
            this.TxtToArcGISbutton.TabIndex = 8;
            this.TxtToArcGISbutton.Text = "国土资源部文件转ArcGIS";
            this.TxtToArcGISbutton.UseVisualStyleBackColor = true;
            this.TxtToArcGISbutton.Click += new System.EventHandler(this.TxtToArcGISbutton_Click);
            // 
            // Provincebutton
            // 
            this.Provincebutton.Location = new System.Drawing.Point(12, 219);
            this.Provincebutton.Name = "Provincebutton";
            this.Provincebutton.Size = new System.Drawing.Size(191, 23);
            this.Provincebutton.TabIndex = 9;
            this.Provincebutton.Text = "省格式Txt转ArcGIS";
            this.Provincebutton.UseVisualStyleBackColor = true;
            this.Provincebutton.Click += new System.EventHandler(this.Provincebutton_Click);
            // 
            // MultiAccessbutton
            // 
            this.MultiAccessbutton.Location = new System.Drawing.Point(12, 249);
            this.MultiAccessbutton.Name = "MultiAccessbutton";
            this.MultiAccessbutton.Size = new System.Drawing.Size(191, 23);
            this.MultiAccessbutton.TabIndex = 10;
            this.MultiAccessbutton.Text = "多个Access合成一个Access";
            this.MultiAccessbutton.UseVisualStyleBackColor = true;
            this.MultiAccessbutton.Click += new System.EventHandler(this.MultiAccessbutton_Click);
            // 
            // MutipleSelectButton
            // 
            this.MutipleSelectButton.Location = new System.Drawing.Point(12, 279);
            this.MutipleSelectButton.Name = "MutipleSelectButton";
            this.MutipleSelectButton.Size = new System.Drawing.Size(190, 23);
            this.MutipleSelectButton.TabIndex = 11;
            this.MutipleSelectButton.Text = "批量Select";
            this.MutipleSelectButton.UseVisualStyleBackColor = true;
            this.MutipleSelectButton.Click += new System.EventHandler(this.MutipleSelectButton_Click);
            // 
            // MutipleClipbutton
            // 
            this.MutipleClipbutton.Location = new System.Drawing.Point(12, 308);
            this.MutipleClipbutton.Name = "MutipleClipbutton";
            this.MutipleClipbutton.Size = new System.Drawing.Size(190, 23);
            this.MutipleClipbutton.TabIndex = 12;
            this.MutipleClipbutton.Text = "批量Clip";
            this.MutipleClipbutton.UseVisualStyleBackColor = true;
            this.MutipleClipbutton.Click += new System.EventHandler(this.MutipleClipbutton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 449);
            this.Controls.Add(this.MutipleClipbutton);
            this.Controls.Add(this.MutipleSelectButton);
            this.Controls.Add(this.MultiAccessbutton);
            this.Controls.Add(this.Provincebutton);
            this.Controls.Add(this.TxtToArcGISbutton);
            this.Controls.Add(this.Synthesisbutton);
            this.Controls.Add(this.ExtractCADButton);
            this.Controls.Add(this.ProgressBarButton);
            this.Controls.Add(this.PolylineToPolygonbutton);
            this.Controls.Add(this.Projectionbutton);
            this.Controls.Add(this.axLicenseControl1);
            this.Controls.Add(this.MergeTCMCButton);
            this.Controls.Add(this.DefineProjectionButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主菜单";
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DefineProjectionButton;
        private System.Windows.Forms.Button MergeTCMCButton;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private System.Windows.Forms.Button Projectionbutton;
        private System.Windows.Forms.Button PolylineToPolygonbutton;
        private System.Windows.Forms.Button ProgressBarButton;
        private System.Windows.Forms.Button ExtractCADButton;
        private System.Windows.Forms.Button Synthesisbutton;
        private System.Windows.Forms.Button TxtToArcGISbutton;
        private System.Windows.Forms.Button Provincebutton;
        private System.Windows.Forms.Button MultiAccessbutton;
        private System.Windows.Forms.Button MutipleSelectButton;
        private System.Windows.Forms.Button MutipleClipbutton;
    }
}