using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Mp3Copy
{
	public partial class Default : Form
	{
		public int mp3Count;
		public string[] mp3Names;
		public IList<FileInfo> mp3Files;
		public string listFileName = string.Empty;
		public string sourcePath = string.Empty;
		public string destinationPath = string.Empty;
		public Stopwatch copyTime;

		private BackgroundWorker findBackgroundWorker;

		public Default()
		{
			InitializeComponent();
		}

		private void OpenMp3List_Click(object sender, EventArgs e)
		{
			if (listFile.ShowDialog() == DialogResult.OK)
			{
				listFileName = listFile.FileName;
				mp3Count = File.ReadLines(listFileName).Count();
				mp3Names = File.ReadLines(listFileName).Distinct().ToArray();

				toSecondStep.Enabled = true;
			}
			else
			{
				toSecondStep.Enabled = false;
			}
		}

		private void Mp3Path_Click(object sender, EventArgs e)
		{
			if (sourceFolder.ShowDialog() == DialogResult.OK)
			{
				sourcePath = sourceFolder.SelectedPath;

				toThirdStep.Enabled = true;
			}
			else
			{
				toThirdStep.Enabled = false;
			}
		}

		private void DestinationPath_Click(object sender, EventArgs e)
		{
			if (destinationFolder.ShowDialog() == DialogResult.OK && destinationFolder.SelectedPath != sourcePath)
			{
				destinationPath = destinationFolder.SelectedPath;

				toFourthStep.Enabled = true;
			}
			else
			{
				toFourthStep.Enabled = false;
			}
		}

		private void copyMp3_Click(object sender, EventArgs e)
		{
			copyTime = Stopwatch.StartNew();

			fourthStep.Visible = false;
			lastStep.Visible = true;

			findProgressBar.Value = 0;
			copyProgressBar.Value = 0;

			var foundMp3 = 0;
			var totalFound = mp3Names.Length;

			ProgressBarBackgroundWorker(findProgressBar, CopyFiles);
			findBackgroundWorker.RunWorkerAsync(new MethodInvoker(() =>
			{
				findProgressBar.BeginInvoke(new MethodInvoker(() => findProgressBar.Visible = true));
				mp3Files = new List<FileInfo>();
				foreach (var mp3 in mp3Names)
				{
					var directories = new DirectoryInfo(sourcePath).GetDirectories();

					foreach (var directory in directories)
					{
						if ((directory.Attributes & FileAttributes.System) == FileAttributes.System)
							continue;

						try
						{
							var fileMatches = directory.GetFiles(string.Format(@"*{0}*", CleanFileName(mp3)), SearchOption.AllDirectories);
							foreach (var fileInfo in fileMatches)
							{
								mp3Files.Add(fileInfo);
								foundMp3 += 1;

								if (mp3Files.Count > totalFound)
									totalFound = mp3Count;

								var progress = (int)Math.Truncate((double)foundMp3 / totalFound * 100);

								if (progress > 100)
									progress = 100;

								findBackgroundWorker.ReportProgress(progress);
							}
						}
						catch (Exception ex)
						{
							if (ex is UnauthorizedAccessException)
							{
								log.AppendText(string.Format("{0}: Access Denied!", directory));
								log.AppendText(Environment.NewLine);
							}
							else
							{
								log.AppendText(ex.Message);
								log.AppendText(Environment.NewLine);
							}
						}
					}
				}
			}));
		}

		private static string CleanFileName(string fileName)
		{
			return Path.GetInvalidFileNameChars().Aggregate(fileName, (current, c) => current.Replace(c.ToString(), string.Empty));
		}

		private void CopyFiles()
		{
			var copiedMp3 = 0;

			ProgressBarBackgroundWorker(copyProgressBar, Complete);
			findBackgroundWorker.RunWorkerAsync(new MethodInvoker(() =>
			{
				copyProgressBar.BeginInvoke(new MethodInvoker(() => copyProgressBar.Visible = true));
				foreach (var file in mp3Files)
				{
					try
					{
						if (!File.Exists(Path.Combine(destinationPath, file.Name)))
							File.Copy(file.FullName, Path.Combine(destinationPath, file.Name));

						copiedMp3 += 1;
						var progress = (double)copiedMp3 / mp3Files.Count * 100;
						findBackgroundWorker.ReportProgress((int)Math.Truncate(progress));
					}
					catch (Exception ex)
					{
						if (ex is UnauthorizedAccessException)
						{
							log.AppendText(string.Format("{0}: Access Denied!", destinationPath));
							log.AppendText(Environment.NewLine);
						}
						else
						{
							log.AppendText(ex.Message);
							log.AppendText(Environment.NewLine);
						}
					}
				}
			}));
		}

		private void Complete()
		{
			copyTime.Stop();
			logViewer.Visible = true;

			log.AppendText(string.Format("Total of {0} files copied in {1}min and {2}sec.", mp3Files.Count, copyTime.Elapsed.Minutes, copyTime.Elapsed.Seconds));
			log.AppendText(Environment.NewLine);
		}

		private void ProgressBarBackgroundWorker(ProgressBar progressBar, Action callBack)
		{
			findBackgroundWorker = new BackgroundWorker();
			findBackgroundWorker.WorkerReportsProgress = true;
			findBackgroundWorker.DoWork += (sender, e) => ((MethodInvoker)e.Argument).Invoke();
			findBackgroundWorker.ProgressChanged += (sender, e) =>
			{
				progressBar.Style = ProgressBarStyle.Continuous;
				progressBar.Value = e.ProgressPercentage;
			};
			findBackgroundWorker.RunWorkerCompleted += (sender, e) =>
			{
				callBack();
			};
		}

		private void toSecondStep_Click(object sender, EventArgs e)
		{
			firstStep.Visible = false;
			secondStep.Visible = true;
		}

		private void toThirdStep_Click(object sender, EventArgs e)
		{
			secondStep.Visible = false;
			thirdStep.Visible = true;
		}

		private void toFourthStep_Click(object sender, EventArgs e)
		{
			thirdStep.Visible = false;
			fourthStep.Visible = true;
		}

		private void logViewer_Click(object sender, EventArgs e)
		{
			lastStep.Visible = false;
			logPanel.Visible = true;
		}
	}
}