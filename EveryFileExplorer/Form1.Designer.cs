﻿namespace EveryFileExplorer
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.mainMenu1 = new LibEveryFileExplorer.UI.MainMenu(this.components);
			this.menuFile = new System.Windows.Forms.MenuItem();
			this.menuNew = new System.Windows.Forms.MenuItem();
			this.menuFileNew = new System.Windows.Forms.MenuItem();
			this.menuOpen = new System.Windows.Forms.MenuItem();
			this.menuClose = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuSave = new System.Windows.Forms.MenuItem();
			this.menuSaveAs = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuExit = new System.Windows.Forms.MenuItem();
			this.menuEdit = new System.Windows.Forms.MenuItem();
			this.menuTools = new System.Windows.Forms.MenuItem();
			this.menuCompression = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItemOptions = new System.Windows.Forms.MenuItem();
			this.menuWindow = new System.Windows.Forms.MenuItem();
			this.menuTile = new System.Windows.Forms.MenuItem();
			this.menuCascade = new System.Windows.Forms.MenuItem();
			this.menuHelp = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.panel1 = new System.Windows.Forms.Panel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.buttonOpen = new System.Windows.Forms.ToolStripButton();
			this.buttonSave = new System.Windows.Forms.ToolStripButton();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.panel1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuTools,
            this.menuWindow,
            this.menuHelp});
			// 
			// menuFile
			// 
			this.menuFile.Index = 0;
			this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuNew,
            this.menuFileNew,
            this.menuOpen,
            this.menuClose,
            this.menuItem5,
            this.menuSave,
            this.menuSaveAs,
            this.menuItem7,
            this.menuExit});
			this.menuFile.Text = "File";
			// 
			// menuNew
			// 
			this.menuNew.Index = 0;
			this.menuNew.Text = "New";
			// 
			// menuFileNew
			// 
			this.menuFileNew.Index = 1;
			this.menuFileNew.Text = "New from File";
			// 
			// menuOpen
			// 
			this.menuOpen.Index = 2;
			this.menuOpen.Text = "Open...";
			this.menuOpen.Click += new System.EventHandler(this.OpenFile);
			// 
			// menuClose
			// 
			this.menuClose.Enabled = false;
			this.menuClose.Index = 3;
			this.menuClose.Text = "Close";
			this.menuClose.Click += new System.EventHandler(this.menuClose_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 4;
			this.menuItem5.Text = "-";
			// 
			// menuSave
			// 
			this.menuSave.Enabled = false;
			this.menuSave.Index = 5;
			this.menuSave.Text = "Save";
			this.menuSave.Click += new System.EventHandler(this.SaveFile);
			// 
			// menuSaveAs
			// 
			this.menuSaveAs.Enabled = false;
			this.menuSaveAs.Index = 6;
			this.menuSaveAs.Text = "Save As...";
			this.menuSaveAs.Click += new System.EventHandler(this.menuSaveAs_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 7;
			this.menuItem7.Text = "-";
			// 
			// menuExit
			// 
			this.menuExit.Index = 8;
			this.menuExit.Text = "Exit";
			this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
			// 
			// menuEdit
			// 
			this.menuEdit.Index = 1;
			this.menuEdit.MergeOrder = 1;
			this.menuEdit.MergeType = System.Windows.Forms.MenuMerge.MergeItems;
			this.menuEdit.Text = "Edit";
			// 
			// menuTools
			// 
			this.menuTools.Index = 2;
			this.menuTools.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuCompression,
            this.menuItem2,
            this.menuItemOptions});
			this.menuTools.MergeOrder = 2;
			this.menuTools.MergeType = System.Windows.Forms.MenuMerge.MergeItems;
			this.menuTools.Text = "Tools";
			// 
			// menuCompression
			// 
			this.menuCompression.Index = 0;
			this.menuCompression.Text = "Compression";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.Text = "-";
			// 
			// menuItemOptions
			// 
			this.menuItemOptions.Index = 2;
			this.menuItemOptions.Text = "Options...";
			// 
			// menuWindow
			// 
			this.menuWindow.Index = 3;
			this.menuWindow.MdiList = true;
			this.menuWindow.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuTile,
            this.menuCascade});
			this.menuWindow.MergeOrder = 3;
			this.menuWindow.Text = "Window";
			// 
			// menuTile
			// 
			this.menuTile.Index = 0;
			this.menuTile.Text = "Tile";
			this.menuTile.Click += new System.EventHandler(this.menuTile_Click);
			// 
			// menuCascade
			// 
			this.menuCascade.Index = 1;
			this.menuCascade.Text = "Cascade";
			this.menuCascade.Click += new System.EventHandler(this.menuCascade_Click);
			// 
			// menuHelp
			// 
			this.menuHelp.Index = 4;
			this.menuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4});
			this.menuHelp.MergeOrder = 4;
			this.menuHelp.Text = "Help";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 0;
			this.menuItem4.Text = "About...";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.Controls.Add(this.toolStrip1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(804, 25);
			this.panel1.TabIndex = 3;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonOpen,
            this.buttonSave});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(804, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// buttonOpen
			// 
			this.buttonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonOpen.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen.Image")));
			this.buttonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonOpen.Name = "buttonOpen";
			this.buttonOpen.Size = new System.Drawing.Size(23, 22);
			this.buttonOpen.Text = "Open";
			this.buttonOpen.Click += new System.EventHandler(this.OpenFile);
			// 
			// buttonSave
			// 
			this.buttonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonSave.Enabled = false;
			this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
			this.buttonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(23, 22);
			this.buttonSave.Text = "Save";
			this.buttonSave.Click += new System.EventHandler(this.SaveFile);
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 443);
			this.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Every File Explorer";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.MdiChildActivate += new System.EventHandler(this.Form1_MdiChildActivate);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private LibEveryFileExplorer.UI.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuFile;
		private System.Windows.Forms.MenuItem menuEdit;
		private System.Windows.Forms.MenuItem menuTools;
		private System.Windows.Forms.MenuItem menuWindow;
		private System.Windows.Forms.MenuItem menuHelp;
		private System.Windows.Forms.MenuItem menuNew;
		private System.Windows.Forms.MenuItem menuOpen;
		private System.Windows.Forms.MenuItem menuItemOptions;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton buttonOpen;
		private System.Windows.Forms.ToolStripButton buttonSave;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuExit;
		private System.Windows.Forms.MenuItem menuTile;
		private System.Windows.Forms.MenuItem menuCascade;
		private System.Windows.Forms.MenuItem menuClose;
		private System.Windows.Forms.MenuItem menuSave;
		private System.Windows.Forms.MenuItem menuSaveAs;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.MenuItem menuFileNew;
		private System.Windows.Forms.MenuItem menuCompression;
		private System.Windows.Forms.MenuItem menuItem2;
	}
}
