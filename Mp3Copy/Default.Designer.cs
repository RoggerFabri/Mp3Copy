namespace Mp3Copy
{
	partial class Default
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
			this.firstStep = new System.Windows.Forms.Panel();
			this.selectMp3List = new System.Windows.Forms.Button();
			this.toSecondStep = new System.Windows.Forms.Button();
			this.listFile = new System.Windows.Forms.OpenFileDialog();
			this.secondStep = new System.Windows.Forms.Panel();
			this.selectSourcePath = new System.Windows.Forms.Button();
			this.toThirdStep = new System.Windows.Forms.Button();
			this.thirdStep = new System.Windows.Forms.Panel();
			this.selectDestinationPath = new System.Windows.Forms.Button();
			this.toFourthStep = new System.Windows.Forms.Button();
			this.sourceFolder = new System.Windows.Forms.FolderBrowserDialog();
			this.destinationFolder = new System.Windows.Forms.FolderBrowserDialog();
			this.fourthStep = new System.Windows.Forms.Panel();
			this.copyMp3 = new System.Windows.Forms.Button();
			this.lastStep = new System.Windows.Forms.Panel();
			this.findingFilesLabel = new System.Windows.Forms.Label();
			this.copyingFilesLabel = new System.Windows.Forms.Label();
			this.findProgressBar = new System.Windows.Forms.ProgressBar();
			this.copyProgressBar = new System.Windows.Forms.ProgressBar();
			this.logViewer = new System.Windows.Forms.Button();
			this.logPanel = new System.Windows.Forms.Panel();
			this.log = new System.Windows.Forms.TextBox();
			this.firstStep.SuspendLayout();
			this.secondStep.SuspendLayout();
			this.thirdStep.SuspendLayout();
			this.fourthStep.SuspendLayout();
			this.lastStep.SuspendLayout();
			this.logPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// firstStep
			// 
			this.firstStep.Controls.Add(this.selectMp3List);
			this.firstStep.Controls.Add(this.toSecondStep);
			this.firstStep.Dock = System.Windows.Forms.DockStyle.Fill;
			this.firstStep.Location = new System.Drawing.Point(0, 0);
			this.firstStep.Name = "firstStep";
			this.firstStep.Size = new System.Drawing.Size(364, 86);
			this.firstStep.TabIndex = 0;
			// 
			// selectMp3List
			// 
			this.selectMp3List.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.selectMp3List.Location = new System.Drawing.Point(107, 31);
			this.selectMp3List.Name = "selectMp3List";
			this.selectMp3List.Size = new System.Drawing.Size(150, 25);
			this.selectMp3List.TabIndex = 1;
			this.selectMp3List.Text = "Select Mp3 File List...";
			this.selectMp3List.UseVisualStyleBackColor = true;
			this.selectMp3List.Click += new System.EventHandler(this.OpenMp3List_Click);
			// 
			// toSecondStep
			// 
			this.toSecondStep.Cursor = System.Windows.Forms.Cursors.Hand;
			this.toSecondStep.Dock = System.Windows.Forms.DockStyle.Right;
			this.toSecondStep.Enabled = false;
			this.toSecondStep.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.toSecondStep.Location = new System.Drawing.Point(295, 0);
			this.toSecondStep.Name = "toSecondStep";
			this.toSecondStep.Size = new System.Drawing.Size(69, 86);
			this.toSecondStep.TabIndex = 2;
			this.toSecondStep.Text = ">>";
			this.toSecondStep.UseVisualStyleBackColor = true;
			this.toSecondStep.Click += new System.EventHandler(this.toSecondStep_Click);
			// 
			// secondStep
			// 
			this.secondStep.Controls.Add(this.selectSourcePath);
			this.secondStep.Controls.Add(this.toThirdStep);
			this.secondStep.Dock = System.Windows.Forms.DockStyle.Fill;
			this.secondStep.Location = new System.Drawing.Point(0, 0);
			this.secondStep.Name = "secondStep";
			this.secondStep.Size = new System.Drawing.Size(364, 86);
			this.secondStep.TabIndex = 1;
			this.secondStep.Visible = false;
			// 
			// selectSourcePath
			// 
			this.selectSourcePath.Location = new System.Drawing.Point(107, 31);
			this.selectSourcePath.Name = "selectSourcePath";
			this.selectSourcePath.Size = new System.Drawing.Size(150, 25);
			this.selectSourcePath.TabIndex = 0;
			this.selectSourcePath.Text = "Select Mp3 Location...";
			this.selectSourcePath.UseVisualStyleBackColor = true;
			this.selectSourcePath.Click += new System.EventHandler(this.Mp3Path_Click);
			// 
			// toThirdStep
			// 
			this.toThirdStep.Cursor = System.Windows.Forms.Cursors.Hand;
			this.toThirdStep.Dock = System.Windows.Forms.DockStyle.Right;
			this.toThirdStep.Enabled = false;
			this.toThirdStep.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.toThirdStep.Location = new System.Drawing.Point(295, 0);
			this.toThirdStep.Name = "toThirdStep";
			this.toThirdStep.Size = new System.Drawing.Size(69, 86);
			this.toThirdStep.TabIndex = 3;
			this.toThirdStep.Text = ">>";
			this.toThirdStep.UseVisualStyleBackColor = true;
			this.toThirdStep.Click += new System.EventHandler(this.toThirdStep_Click);
			// 
			// thirdStep
			// 
			this.thirdStep.Controls.Add(this.selectDestinationPath);
			this.thirdStep.Controls.Add(this.toFourthStep);
			this.thirdStep.Dock = System.Windows.Forms.DockStyle.Fill;
			this.thirdStep.Location = new System.Drawing.Point(0, 0);
			this.thirdStep.Name = "thirdStep";
			this.thirdStep.Size = new System.Drawing.Size(364, 86);
			this.thirdStep.TabIndex = 2;
			this.thirdStep.Visible = false;
			// 
			// selectDestinationPath
			// 
			this.selectDestinationPath.Location = new System.Drawing.Point(107, 31);
			this.selectDestinationPath.Name = "selectDestinationPath";
			this.selectDestinationPath.Size = new System.Drawing.Size(150, 25);
			this.selectDestinationPath.TabIndex = 0;
			this.selectDestinationPath.Text = "Select Destination...";
			this.selectDestinationPath.UseVisualStyleBackColor = true;
			this.selectDestinationPath.Click += new System.EventHandler(this.DestinationPath_Click);
			// 
			// toFourthStep
			// 
			this.toFourthStep.Cursor = System.Windows.Forms.Cursors.Hand;
			this.toFourthStep.Dock = System.Windows.Forms.DockStyle.Right;
			this.toFourthStep.Enabled = false;
			this.toFourthStep.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.toFourthStep.Location = new System.Drawing.Point(295, 0);
			this.toFourthStep.Name = "toFourthStep";
			this.toFourthStep.Size = new System.Drawing.Size(69, 86);
			this.toFourthStep.TabIndex = 4;
			this.toFourthStep.Text = ">>";
			this.toFourthStep.UseVisualStyleBackColor = true;
			this.toFourthStep.Click += new System.EventHandler(this.toFourthStep_Click);
			// 
			// sourceFolder
			// 
			this.sourceFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
			this.sourceFolder.ShowNewFolderButton = false;
			// 
			// destinationFolder
			// 
			this.destinationFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
			// 
			// fourthStep
			// 
			this.fourthStep.Controls.Add(this.copyMp3);
			this.fourthStep.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fourthStep.Location = new System.Drawing.Point(0, 0);
			this.fourthStep.Name = "fourthStep";
			this.fourthStep.Size = new System.Drawing.Size(364, 86);
			this.fourthStep.TabIndex = 3;
			this.fourthStep.Visible = false;
			// 
			// copyMp3
			// 
			this.copyMp3.Location = new System.Drawing.Point(107, 31);
			this.copyMp3.Name = "copyMp3";
			this.copyMp3.Size = new System.Drawing.Size(150, 25);
			this.copyMp3.TabIndex = 0;
			this.copyMp3.Text = "Copy Mp3";
			this.copyMp3.UseVisualStyleBackColor = true;
			this.copyMp3.Click += new System.EventHandler(this.copyMp3_Click);
			// 
			// lastStep
			// 
			this.lastStep.Controls.Add(this.logViewer);
			this.lastStep.Controls.Add(this.findingFilesLabel);
			this.lastStep.Controls.Add(this.copyingFilesLabel);
			this.lastStep.Controls.Add(this.findProgressBar);
			this.lastStep.Controls.Add(this.copyProgressBar);
			this.lastStep.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lastStep.Location = new System.Drawing.Point(0, 0);
			this.lastStep.Name = "lastStep";
			this.lastStep.Size = new System.Drawing.Size(364, 86);
			this.lastStep.TabIndex = 4;
			this.lastStep.Visible = false;
			// 
			// findingFilesLabel
			// 
			this.findingFilesLabel.AutoSize = true;
			this.findingFilesLabel.Location = new System.Drawing.Point(3, 49);
			this.findingFilesLabel.Name = "findingFilesLabel";
			this.findingFilesLabel.Size = new System.Drawing.Size(78, 13);
			this.findingFilesLabel.TabIndex = 3;
			this.findingFilesLabel.Text = "Copying Files...";
			// 
			// copyingFilesLabel
			// 
			this.copyingFilesLabel.AutoSize = true;
			this.copyingFilesLabel.Location = new System.Drawing.Point(4, 4);
			this.copyingFilesLabel.Name = "copyingFilesLabel";
			this.copyingFilesLabel.Size = new System.Drawing.Size(74, 13);
			this.copyingFilesLabel.TabIndex = 2;
			this.copyingFilesLabel.Text = "Finding Files...";
			// 
			// findProgressBar
			// 
			this.findProgressBar.Location = new System.Drawing.Point(3, 20);
			this.findProgressBar.Name = "findProgressBar";
			this.findProgressBar.Size = new System.Drawing.Size(356, 18);
			this.findProgressBar.Step = 1;
			this.findProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.findProgressBar.TabIndex = 1;
			// 
			// copyProgressBar
			// 
			this.copyProgressBar.Location = new System.Drawing.Point(3, 65);
			this.copyProgressBar.Name = "copyProgressBar";
			this.copyProgressBar.Size = new System.Drawing.Size(356, 18);
			this.copyProgressBar.Step = 1;
			this.copyProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.copyProgressBar.TabIndex = 0;
			// 
			// logViewer
			// 
			this.logViewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.logViewer.Location = new System.Drawing.Point(326, 47);
			this.logViewer.Name = "logViewer";
			this.logViewer.Size = new System.Drawing.Size(34, 17);
			this.logViewer.TabIndex = 4;
			this.logViewer.Text = "LOG";
			this.logViewer.UseVisualStyleBackColor = true;
			this.logViewer.Visible = false;
			this.logViewer.Click += new System.EventHandler(this.logViewer_Click);
			// 
			// logPanel
			// 
			this.logPanel.Controls.Add(this.log);
			this.logPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.logPanel.Location = new System.Drawing.Point(0, 0);
			this.logPanel.Name = "logPanel";
			this.logPanel.Size = new System.Drawing.Size(364, 86);
			this.logPanel.TabIndex = 5;
			this.logPanel.Visible = false;
			// 
			// log
			// 
			this.log.Dock = System.Windows.Forms.DockStyle.Fill;
			this.log.Location = new System.Drawing.Point(0, 0);
			this.log.Multiline = true;
			this.log.Name = "log";
			this.log.ReadOnly = true;
			this.log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.log.Size = new System.Drawing.Size(364, 86);
			this.log.TabIndex = 0;
			// 
			// Default
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(364, 86);
			this.Controls.Add(this.lastStep);
			this.Controls.Add(this.logPanel);
			this.Controls.Add(this.fourthStep);
			this.Controls.Add(this.thirdStep);
			this.Controls.Add(this.secondStep);
			this.Controls.Add(this.firstStep);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Default";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mp3 Copy";
			this.firstStep.ResumeLayout(false);
			this.secondStep.ResumeLayout(false);
			this.thirdStep.ResumeLayout(false);
			this.fourthStep.ResumeLayout(false);
			this.lastStep.ResumeLayout(false);
			this.lastStep.PerformLayout();
			this.logPanel.ResumeLayout(false);
			this.logPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel firstStep;
		private System.Windows.Forms.OpenFileDialog listFile;
		private System.Windows.Forms.Button selectMp3List;
		private System.Windows.Forms.Panel secondStep;
		private System.Windows.Forms.Button selectSourcePath;
		private System.Windows.Forms.Panel thirdStep;
		private System.Windows.Forms.Button selectDestinationPath;
		private System.Windows.Forms.FolderBrowserDialog sourceFolder;
		private System.Windows.Forms.FolderBrowserDialog destinationFolder;
		private System.Windows.Forms.Panel fourthStep;
		private System.Windows.Forms.Button copyMp3;
		private System.Windows.Forms.Panel lastStep;
		private System.Windows.Forms.ProgressBar copyProgressBar;
		private System.Windows.Forms.ProgressBar findProgressBar;
		private System.Windows.Forms.Label findingFilesLabel;
		private System.Windows.Forms.Label copyingFilesLabel;
		private System.Windows.Forms.Button toSecondStep;
		private System.Windows.Forms.Button toThirdStep;
		private System.Windows.Forms.Button toFourthStep;
		private System.Windows.Forms.Button logViewer;
		private System.Windows.Forms.Panel logPanel;
		private System.Windows.Forms.TextBox log;
	}
}

