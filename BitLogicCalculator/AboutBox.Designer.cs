namespace BitLogicCalculator
{
	partial class AboutBox
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
			tableLayoutPanel = new Krypton.Toolkit.KryptonTableLayoutPanel();
			labelProductName = new Krypton.Toolkit.KryptonLabel();
			labelVersion = new Krypton.Toolkit.KryptonLabel();
			labelCopyright = new Krypton.Toolkit.KryptonLabel();
			labelCompanyName = new Krypton.Toolkit.KryptonLabel();
			textBoxDescription = new Krypton.Toolkit.KryptonTextBox();
			okButton = new Krypton.Toolkit.KryptonButton();
			kryptonStatusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			labelInformation = new ToolStripStatusLabel();
			toolStripContainer = new ToolStripContainer();
			toolTip = new ToolTip(components);
			kryptonManager = new Krypton.Toolkit.KryptonManager(components);
			tableLayoutPanel.SuspendLayout();
			kryptonStatusStrip.SuspendLayout();
			toolStripContainer.BottomToolStripPanel.SuspendLayout();
			toolStripContainer.ContentPanel.SuspendLayout();
			toolStripContainer.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			tableLayoutPanel.AccessibleDescription = "Groups the elements";
			tableLayoutPanel.AccessibleName = "grouping";
			tableLayoutPanel.AccessibleRole = AccessibleRole.Grouping;
			tableLayoutPanel.ColumnCount = 1;
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel.Controls.Add(labelProductName, 0, 0);
			tableLayoutPanel.Controls.Add(labelVersion, 0, 1);
			tableLayoutPanel.Controls.Add(labelCopyright, 0, 2);
			tableLayoutPanel.Controls.Add(labelCompanyName, 0, 3);
			tableLayoutPanel.Controls.Add(textBoxDescription, 0, 4);
			tableLayoutPanel.Controls.Add(okButton, 0, 5);
			tableLayoutPanel.Dock = DockStyle.Fill;
			tableLayoutPanel.Location = new Point(0, 0);
			tableLayoutPanel.Margin = new Padding(0);
			tableLayoutPanel.Name = "tableLayoutPanel";
			tableLayoutPanel.RowCount = 6;
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.Size = new Size(396, 209);
			tableLayoutPanel.TabIndex = 0;
			tableLayoutPanel.Enter += Control_Enter;
			tableLayoutPanel.Leave += Control_Leave;
			// 
			// labelProductName
			// 
			labelProductName.AccessibleDescription = "Shows the product name";
			labelProductName.AccessibleName = "product name";
			labelProductName.AccessibleRole = AccessibleRole.StaticText;
			labelProductName.Dock = DockStyle.Fill;
			labelProductName.Location = new Point(7, 0);
			labelProductName.Margin = new Padding(7, 0, 4, 0);
			labelProductName.MaximumSize = new Size(0, 20);
			labelProductName.Name = "labelProductName";
			labelProductName.Size = new Size(388, 20);
			labelProductName.TabIndex = 0;
			labelProductName.ToolTipValues.Description = "Shows the product name";
			labelProductName.ToolTipValues.EnableToolTips = true;
			labelProductName.ToolTipValues.Heading = "Product name";
			labelProductName.Values.Text = "product name";
			labelProductName.DoubleClick += LabelProductName_DoubleClick;
			labelProductName.Enter += Control_Enter;
			labelProductName.Leave += Control_Leave;
			labelProductName.MouseEnter += Control_Enter;
			labelProductName.MouseLeave += Control_Leave;
			// 
			// labelVersion
			// 
			labelVersion.AccessibleDescription = "Shows the version";
			labelVersion.AccessibleName = "version";
			labelVersion.AccessibleRole = AccessibleRole.StaticText;
			labelVersion.Dock = DockStyle.Fill;
			labelVersion.Location = new Point(7, 20);
			labelVersion.Margin = new Padding(7, 0, 4, 0);
			labelVersion.MaximumSize = new Size(0, 20);
			labelVersion.Name = "labelVersion";
			labelVersion.Size = new Size(388, 20);
			labelVersion.TabIndex = 1;
			labelVersion.ToolTipValues.Description = "Shows the version";
			labelVersion.ToolTipValues.EnableToolTips = true;
			labelVersion.ToolTipValues.Heading = "Version";
			labelVersion.Values.Text = "version";
			labelVersion.Click += LabelVersion_Click;
			labelVersion.Enter += Control_Enter;
			labelVersion.Leave += Control_Leave;
			labelVersion.MouseEnter += Control_Enter;
			labelVersion.MouseLeave += Control_Leave;
			// 
			// labelCopyright
			// 
			labelCopyright.AccessibleDescription = "Shows the copyright";
			labelCopyright.AccessibleName = "copyright";
			labelCopyright.AccessibleRole = AccessibleRole.StaticText;
			labelCopyright.Dock = DockStyle.Fill;
			labelCopyright.Location = new Point(7, 40);
			labelCopyright.Margin = new Padding(7, 0, 4, 0);
			labelCopyright.MaximumSize = new Size(0, 20);
			labelCopyright.Name = "labelCopyright";
			labelCopyright.Size = new Size(388, 20);
			labelCopyright.TabIndex = 2;
			labelCopyright.ToolTipValues.Description = "Shows the copyright";
			labelCopyright.ToolTipValues.EnableToolTips = true;
			labelCopyright.ToolTipValues.Heading = "Copyright";
			labelCopyright.Values.Text = "copyright";
			labelCopyright.Click += LabelCopyright_Click;
			labelCopyright.Enter += Control_Enter;
			labelCopyright.Leave += Control_Leave;
			labelCopyright.MouseEnter += Control_Enter;
			labelCopyright.MouseLeave += Control_Leave;
			// 
			// labelCompanyName
			// 
			labelCompanyName.AccessibleDescription = "Shows the company name";
			labelCompanyName.AccessibleName = "company name";
			labelCompanyName.AccessibleRole = AccessibleRole.StaticText;
			labelCompanyName.Dock = DockStyle.Fill;
			labelCompanyName.Location = new Point(7, 60);
			labelCompanyName.Margin = new Padding(7, 0, 4, 0);
			labelCompanyName.MaximumSize = new Size(0, 20);
			labelCompanyName.Name = "labelCompanyName";
			labelCompanyName.Size = new Size(388, 20);
			labelCompanyName.TabIndex = 3;
			labelCompanyName.ToolTipValues.Description = "Shows the company name";
			labelCompanyName.ToolTipValues.EnableToolTips = true;
			labelCompanyName.ToolTipValues.Heading = "Company name";
			labelCompanyName.Values.Text = "company name";
			labelCompanyName.Click += LabelCompanyName_Click;
			labelCompanyName.Enter += Control_Enter;
			labelCompanyName.Leave += Control_Leave;
			labelCompanyName.MouseEnter += Control_Enter;
			labelCompanyName.MouseLeave += Control_Leave;
			// 
			// textBoxDescription
			// 
			textBoxDescription.AccessibleDescription = "Shows the description";
			textBoxDescription.AccessibleName = "description";
			textBoxDescription.AccessibleRole = AccessibleRole.Text;
			textBoxDescription.Dock = DockStyle.Fill;
			textBoxDescription.Location = new Point(7, 83);
			textBoxDescription.Margin = new Padding(7, 3, 4, 3);
			textBoxDescription.Multiline = true;
			textBoxDescription.Name = "textBoxDescription";
			textBoxDescription.ReadOnly = true;
			textBoxDescription.ScrollBars = ScrollBars.Both;
			textBoxDescription.Size = new Size(388, 87);
			textBoxDescription.TabIndex = 4;
			textBoxDescription.TabStop = false;
			textBoxDescription.Text = "description";
			textBoxDescription.ToolTipValues.Description = "Shows the description";
			textBoxDescription.ToolTipValues.EnableToolTips = true;
			textBoxDescription.ToolTipValues.Heading = "Description";
			textBoxDescription.Enter += Control_Enter;
			textBoxDescription.Leave += Control_Leave;
			textBoxDescription.MouseEnter += Control_Enter;
			textBoxDescription.MouseLeave += Control_Leave;
			// 
			// okButton
			// 
			okButton.AccessibleDescription = "Closes the window";
			okButton.AccessibleName = "OK";
			okButton.AccessibleRole = AccessibleRole.PushButton;
			okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			okButton.DialogResult = DialogResult.OK;
			okButton.Location = new Point(307, 177);
			okButton.Margin = new Padding(4, 3, 4, 3);
			okButton.Name = "okButton";
			okButton.Size = new Size(88, 29);
			okButton.TabIndex = 5;
			okButton.ToolTipValues.Description = "Closes the window";
			okButton.ToolTipValues.EnableToolTips = true;
			okButton.ToolTipValues.Heading = "OK";
			okButton.Values.DropDownArrowColor = Color.Empty;
			okButton.Values.Text = "&OK";
			okButton.Enter += Control_Enter;
			okButton.Leave += Control_Leave;
			okButton.MouseEnter += Control_Enter;
			okButton.MouseLeave += Control_Leave;
			// 
			// kryptonStatusStrip
			// 
			kryptonStatusStrip.AccessibleDescription = "Shows the status bar";
			kryptonStatusStrip.AccessibleName = "status bar";
			kryptonStatusStrip.AccessibleRole = AccessibleRole.StatusBar;
			kryptonStatusStrip.AllowClickThrough = true;
			kryptonStatusStrip.AllowItemReorder = true;
			kryptonStatusStrip.AllowMerge = false;
			kryptonStatusStrip.Dock = DockStyle.None;
			kryptonStatusStrip.Font = new Font("Segoe UI", 9F);
			kryptonStatusStrip.Items.AddRange(new ToolStripItem[] { labelInformation });
			kryptonStatusStrip.Location = new Point(0, 0);
			kryptonStatusStrip.Name = "kryptonStatusStrip";
			kryptonStatusStrip.ProgressBars = null;
			kryptonStatusStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			kryptonStatusStrip.Size = new Size(396, 22);
			kryptonStatusStrip.SizingGrip = false;
			kryptonStatusStrip.TabIndex = 0;
			kryptonStatusStrip.TabStop = true;
			kryptonStatusStrip.Text = "kryptonStatusStrip";
			toolTip.SetToolTip(kryptonStatusStrip, "Status bar");
			kryptonStatusStrip.Enter += Control_Enter;
			kryptonStatusStrip.Leave += Control_Leave;
			kryptonStatusStrip.MouseEnter += Control_Enter;
			kryptonStatusStrip.MouseLeave += Control_Leave;
			// 
			// labelInformation
			// 
			labelInformation.AccessibleDescription = "Shows some information";
			labelInformation.AccessibleName = "information label";
			labelInformation.AccessibleRole = AccessibleRole.StaticText;
			labelInformation.AutoToolTip = true;
			labelInformation.Name = "labelInformation";
			labelInformation.Size = new Size(93, 17);
			labelInformation.Text = "information text";
			labelInformation.MouseEnter += Control_Enter;
			labelInformation.MouseLeave += Control_Leave;
			// 
			// toolStripContainer
			// 
			toolStripContainer.AccessibleDescription = "Groups the elements";
			toolStripContainer.AccessibleName = "grouping";
			toolStripContainer.AccessibleRole = AccessibleRole.Grouping;
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			toolStripContainer.BottomToolStripPanel.Controls.Add(kryptonStatusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			toolStripContainer.ContentPanel.Controls.Add(tableLayoutPanel);
			toolStripContainer.ContentPanel.Size = new Size(396, 209);
			toolStripContainer.Dock = DockStyle.Fill;
			toolStripContainer.Location = new Point(0, 0);
			toolStripContainer.Name = "toolStripContainer";
			toolStripContainer.Size = new Size(396, 231);
			toolStripContainer.TabIndex = 4;
			toolStripContainer.Text = "toolStripContainer";
			toolStripContainer.TopToolStripPanelVisible = false;
			toolStripContainer.Enter += Control_Enter;
			toolStripContainer.Leave += Control_Leave;
			toolStripContainer.MouseEnter += Control_Enter;
			toolStripContainer.MouseLeave += Control_Leave;
			// 
			// kryptonManager
			// 
			kryptonManager.ToolkitStrings.MessageBoxStrings.LessDetails = "L&ess Details...";
			kryptonManager.ToolkitStrings.MessageBoxStrings.MoreDetails = "&More Details...";
			// 
			// AboutBox
			// 
			AcceptButton = okButton;
			AccessibleDescription = "Shows the window";
			AccessibleName = "About box";
			AccessibleRole = AccessibleRole.Window;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(396, 231);
			Controls.Add(toolStripContainer);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Center;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "AboutBox";
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "About";
			Load += AboutBox_Load;
			Enter += Control_Enter;
			KeyDown += BaseKryptonForm_KeyDown;
			Leave += Control_Leave;
			MouseEnter += Control_Enter;
			MouseLeave += Control_Leave;
			tableLayoutPanel.ResumeLayout(false);
			tableLayoutPanel.PerformLayout();
			kryptonStatusStrip.ResumeLayout(false);
			kryptonStatusStrip.PerformLayout();
			toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			toolStripContainer.BottomToolStripPanel.PerformLayout();
			toolStripContainer.ContentPanel.ResumeLayout(false);
			toolStripContainer.ResumeLayout(false);
			toolStripContainer.PerformLayout();
			ResumeLayout(false);

		}

		#endregion

		private Krypton.Toolkit.KryptonTableLayoutPanel tableLayoutPanel;
		private Krypton.Toolkit.KryptonLabel labelProductName;
		private Krypton.Toolkit.KryptonLabel labelVersion;
		private Krypton.Toolkit.KryptonLabel labelCopyright;
		private Krypton.Toolkit.KryptonLabel labelCompanyName;
		private Krypton.Toolkit.KryptonTextBox textBoxDescription;
		private Krypton.Toolkit.KryptonButton okButton;
		private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip;
		private ToolStripContainer toolStripContainer;
		private ToolStripStatusLabel labelInformation;
		private ToolTip toolTip;
		private Krypton.Toolkit.KryptonManager kryptonManager;
	}
}
