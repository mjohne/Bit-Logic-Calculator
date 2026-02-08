namespace BitLogicCalculator
{
	partial class StatisticsForm
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsForm));
			tableLayoutPanel = new Krypton.Toolkit.KryptonTableLayoutPanel();
			labelA2Bit0Number = new Krypton.Toolkit.KryptonLabel();
			labelA1Bit0Number = new Krypton.Toolkit.KryptonLabel();
			labelTotal = new Krypton.Toolkit.KryptonLabel();
			labelBit0 = new Krypton.Toolkit.KryptonLabel();
			labelResult = new Krypton.Toolkit.KryptonLabel();
			labelAccumulator2 = new Krypton.Toolkit.KryptonLabel();
			labelAccumulator1 = new Krypton.Toolkit.KryptonLabel();
			labelBit1 = new Krypton.Toolkit.KryptonLabel();
			labelResultBit0Number = new Krypton.Toolkit.KryptonLabel();
			labelA1Bit1Number = new Krypton.Toolkit.KryptonLabel();
			labelA2Bit1Number = new Krypton.Toolkit.KryptonLabel();
			labelResultBit1Number = new Krypton.Toolkit.KryptonLabel();
			labelA1TotalNumber = new Krypton.Toolkit.KryptonLabel();
			labelA2TotalNumber = new Krypton.Toolkit.KryptonLabel();
			labelResultTotalNumber = new Krypton.Toolkit.KryptonLabel();
			toolTip = new ToolTip(components);
			kryptonStatusStrip = new Krypton.Toolkit.KryptonStatusStrip();
			labelInformation = new ToolStripStatusLabel();
			toolStripContainer = new ToolStripContainer();
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
			tableLayoutPanel.AccessibleDescription = "Groups the labels";
			tableLayoutPanel.AccessibleName = "label grouping";
			tableLayoutPanel.AccessibleRole = AccessibleRole.Grouping;
			tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
			tableLayoutPanel.ColumnCount = 4;
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel.Controls.Add(labelA2Bit0Number, 2, 1);
			tableLayoutPanel.Controls.Add(labelA1Bit0Number, 1, 1);
			tableLayoutPanel.Controls.Add(labelTotal, 0, 3);
			tableLayoutPanel.Controls.Add(labelBit0, 0, 1);
			tableLayoutPanel.Controls.Add(labelResult, 3, 0);
			tableLayoutPanel.Controls.Add(labelAccumulator2, 2, 0);
			tableLayoutPanel.Controls.Add(labelAccumulator1, 1, 0);
			tableLayoutPanel.Controls.Add(labelBit1, 0, 2);
			tableLayoutPanel.Controls.Add(labelResultBit0Number, 3, 1);
			tableLayoutPanel.Controls.Add(labelA1Bit1Number, 1, 2);
			tableLayoutPanel.Controls.Add(labelA2Bit1Number, 2, 2);
			tableLayoutPanel.Controls.Add(labelResultBit1Number, 3, 2);
			tableLayoutPanel.Controls.Add(labelA1TotalNumber, 1, 3);
			tableLayoutPanel.Controls.Add(labelA2TotalNumber, 2, 3);
			tableLayoutPanel.Controls.Add(labelResultTotalNumber, 3, 3);
			tableLayoutPanel.Dock = DockStyle.Fill;
			tableLayoutPanel.Location = new Point(0, 0);
			tableLayoutPanel.Margin = new Padding(4, 3, 4, 3);
			tableLayoutPanel.Name = "tableLayoutPanel";
			tableLayoutPanel.RowCount = 4;
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.Size = new Size(368, 89);
			tableLayoutPanel.TabIndex = 0;
			tableLayoutPanel.Enter += Control_Enter;
			tableLayoutPanel.Leave += Control_Leave;
			// 
			// labelA2Bit0Number
			// 
			labelA2Bit0Number.AccessibleDescription = "Shows the number of bit 0 in accumulator 2";
			labelA2Bit0Number.AccessibleName = "number of bit 0 in accumulator 2";
			labelA2Bit0Number.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit0Number.Dock = DockStyle.Fill;
			labelA2Bit0Number.Location = new Point(156, 24);
			labelA2Bit0Number.Margin = new Padding(4, 0, 4, 0);
			labelA2Bit0Number.Name = "labelA2Bit0Number";
			labelA2Bit0Number.Size = new Size(90, 20);
			labelA2Bit0Number.TabIndex = 5;
			labelA2Bit0Number.ToolTipValues.Description = "Shows the number of bit 0 in accumulator 2";
			labelA2Bit0Number.ToolTipValues.EnableToolTips = true;
			labelA2Bit0Number.ToolTipValues.Heading = "Number of bit 0 in accumulator 2";
			labelA2Bit0Number.Values.Text = "---";
			labelA2Bit0Number.DoubleClick += LabelA2Bit0Number_DoubleClick;
			labelA2Bit0Number.Enter += Control_Enter;
			labelA2Bit0Number.Leave += Control_Leave;
			labelA2Bit0Number.MouseEnter += Control_Enter;
			labelA2Bit0Number.MouseLeave += Control_Leave;
			// 
			// labelA1Bit0Number
			// 
			labelA1Bit0Number.AccessibleDescription = "Shows the number of bit 0 in accumulator 1";
			labelA1Bit0Number.AccessibleName = "number of bit 0 in accumulator 1";
			labelA1Bit0Number.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit0Number.Dock = DockStyle.Fill;
			labelA1Bit0Number.Location = new Point(56, 24);
			labelA1Bit0Number.Margin = new Padding(4, 0, 4, 0);
			labelA1Bit0Number.Name = "labelA1Bit0Number";
			labelA1Bit0Number.Size = new Size(90, 20);
			labelA1Bit0Number.TabIndex = 4;
			labelA1Bit0Number.ToolTipValues.Description = "Shows the number of bit 0 in accumulator 1";
			labelA1Bit0Number.ToolTipValues.EnableToolTips = true;
			labelA1Bit0Number.ToolTipValues.Heading = "Number of bit 0 in accumulator 1";
			labelA1Bit0Number.Values.Text = "---";
			labelA1Bit0Number.DoubleClick += LabelA1Bit0Number_DoubleClick;
			labelA1Bit0Number.Enter += Control_Enter;
			labelA1Bit0Number.Leave += Control_Leave;
			labelA1Bit0Number.MouseEnter += Control_Enter;
			labelA1Bit0Number.MouseLeave += Control_Leave;
			// 
			// labelTotal
			// 
			labelTotal.AccessibleDescription = "Shows the total";
			labelTotal.AccessibleName = "total";
			labelTotal.AccessibleRole = AccessibleRole.StaticText;
			labelTotal.Dock = DockStyle.Fill;
			labelTotal.Location = new Point(6, 68);
			labelTotal.Margin = new Padding(4, 0, 4, 0);
			labelTotal.Name = "labelTotal";
			labelTotal.Size = new Size(40, 20);
			labelTotal.TabIndex = 11;
			labelTotal.ToolTipValues.Description = "Shows the total";
			labelTotal.ToolTipValues.EnableToolTips = true;
			labelTotal.ToolTipValues.Heading = "Total";
			labelTotal.Values.Text = "Total:";
			labelTotal.Enter += Control_Enter;
			labelTotal.Leave += Control_Leave;
			labelTotal.MouseEnter += Control_Enter;
			labelTotal.MouseLeave += Control_Leave;
			// 
			// labelBit0
			// 
			labelBit0.AccessibleDescription = "Shows the bit 0";
			labelBit0.AccessibleName = "bit 0";
			labelBit0.AccessibleRole = AccessibleRole.StaticText;
			labelBit0.Dock = DockStyle.Fill;
			labelBit0.Location = new Point(6, 24);
			labelBit0.Margin = new Padding(4, 0, 4, 0);
			labelBit0.Name = "labelBit0";
			labelBit0.Size = new Size(40, 20);
			labelBit0.TabIndex = 3;
			labelBit0.ToolTipValues.Description = "Shows the bit 0";
			labelBit0.ToolTipValues.EnableToolTips = true;
			labelBit0.ToolTipValues.Heading = "Bit 0";
			labelBit0.Values.Text = "Bit 0:";
			labelBit0.Enter += Control_Enter;
			labelBit0.Leave += Control_Leave;
			labelBit0.MouseEnter += Control_Enter;
			labelBit0.MouseLeave += Control_Leave;
			// 
			// labelResult
			// 
			labelResult.AccessibleDescription = "Shows the result";
			labelResult.AccessibleName = "result";
			labelResult.AccessibleRole = AccessibleRole.StaticText;
			labelResult.Dock = DockStyle.Fill;
			labelResult.Location = new Point(256, 2);
			labelResult.Margin = new Padding(4, 0, 4, 0);
			labelResult.Name = "labelResult";
			labelResult.Size = new Size(107, 20);
			labelResult.TabIndex = 2;
			labelResult.ToolTipValues.Description = "Shows the result";
			labelResult.ToolTipValues.EnableToolTips = true;
			labelResult.ToolTipValues.Heading = "Result";
			labelResult.Values.Text = "Result";
			labelResult.Enter += Control_Enter;
			labelResult.Leave += Control_Leave;
			labelResult.MouseEnter += Control_Enter;
			labelResult.MouseLeave += Control_Leave;
			// 
			// labelAccumulator2
			// 
			labelAccumulator2.AccessibleDescription = "Shows the accumulator 2";
			labelAccumulator2.AccessibleName = "accumulator 2";
			labelAccumulator2.AccessibleRole = AccessibleRole.StaticText;
			labelAccumulator2.Dock = DockStyle.Fill;
			labelAccumulator2.Location = new Point(156, 2);
			labelAccumulator2.Margin = new Padding(4, 0, 4, 0);
			labelAccumulator2.Name = "labelAccumulator2";
			labelAccumulator2.Size = new Size(90, 20);
			labelAccumulator2.TabIndex = 1;
			labelAccumulator2.ToolTipValues.Description = "Shows the accumulator 2";
			labelAccumulator2.ToolTipValues.EnableToolTips = true;
			labelAccumulator2.ToolTipValues.Heading = "Accumulator 2";
			labelAccumulator2.Values.Text = "Accumulator 2";
			labelAccumulator2.Enter += Control_Enter;
			labelAccumulator2.Leave += Control_Leave;
			labelAccumulator2.MouseEnter += Control_Enter;
			labelAccumulator2.MouseLeave += Control_Leave;
			// 
			// labelAccumulator1
			// 
			labelAccumulator1.AccessibleDescription = "Shows the accumulator 1";
			labelAccumulator1.AccessibleName = "accumulator 1";
			labelAccumulator1.AccessibleRole = AccessibleRole.StaticText;
			labelAccumulator1.Dock = DockStyle.Fill;
			labelAccumulator1.Location = new Point(56, 2);
			labelAccumulator1.Margin = new Padding(4, 0, 4, 0);
			labelAccumulator1.Name = "labelAccumulator1";
			labelAccumulator1.Size = new Size(90, 20);
			labelAccumulator1.TabIndex = 0;
			labelAccumulator1.ToolTipValues.Description = "Shows the accumulator 1";
			labelAccumulator1.ToolTipValues.EnableToolTips = true;
			labelAccumulator1.ToolTipValues.Heading = "Accumulator 1";
			labelAccumulator1.Values.Text = "Accumulator 1";
			labelAccumulator1.Enter += Control_Enter;
			labelAccumulator1.Leave += Control_Leave;
			labelAccumulator1.MouseEnter += Control_Enter;
			labelAccumulator1.MouseLeave += Control_Leave;
			// 
			// labelBit1
			// 
			labelBit1.AccessibleDescription = "Shows the bit 1";
			labelBit1.AccessibleName = "bit 1";
			labelBit1.AccessibleRole = AccessibleRole.StaticText;
			labelBit1.Dock = DockStyle.Fill;
			labelBit1.Location = new Point(6, 46);
			labelBit1.Margin = new Padding(4, 0, 4, 0);
			labelBit1.Name = "labelBit1";
			labelBit1.Size = new Size(40, 20);
			labelBit1.TabIndex = 7;
			labelBit1.ToolTipValues.Description = "Shows the bit 1";
			labelBit1.ToolTipValues.EnableToolTips = true;
			labelBit1.ToolTipValues.Heading = "Bit 1";
			labelBit1.Values.Text = "Bit 1:";
			labelBit1.Enter += Control_Enter;
			labelBit1.Leave += Control_Leave;
			labelBit1.MouseEnter += Control_Enter;
			labelBit1.MouseLeave += Control_Leave;
			// 
			// labelResultBit0Number
			// 
			labelResultBit0Number.AccessibleDescription = "Shows the number of bit 0 in result";
			labelResultBit0Number.AccessibleName = "number of bit 0 in result";
			labelResultBit0Number.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit0Number.Dock = DockStyle.Fill;
			labelResultBit0Number.Location = new Point(256, 24);
			labelResultBit0Number.Margin = new Padding(4, 0, 4, 0);
			labelResultBit0Number.Name = "labelResultBit0Number";
			labelResultBit0Number.Size = new Size(107, 20);
			labelResultBit0Number.TabIndex = 6;
			labelResultBit0Number.ToolTipValues.Description = "Shows the number of bit 0 in result";
			labelResultBit0Number.ToolTipValues.EnableToolTips = true;
			labelResultBit0Number.ToolTipValues.Heading = "Number of bit 0 in result";
			labelResultBit0Number.Values.Text = "---";
			labelResultBit0Number.DoubleClick += LabelResultBit0Number_DoubleClick;
			labelResultBit0Number.Enter += Control_Enter;
			labelResultBit0Number.Leave += Control_Leave;
			labelResultBit0Number.MouseEnter += Control_Enter;
			labelResultBit0Number.MouseLeave += Control_Leave;
			// 
			// labelA1Bit1Number
			// 
			labelA1Bit1Number.AccessibleDescription = "Shows the number of bit 1 in accumulator 1";
			labelA1Bit1Number.AccessibleName = "number of bit 1 in accumulator 1";
			labelA1Bit1Number.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit1Number.Dock = DockStyle.Fill;
			labelA1Bit1Number.Location = new Point(56, 46);
			labelA1Bit1Number.Margin = new Padding(4, 0, 4, 0);
			labelA1Bit1Number.Name = "labelA1Bit1Number";
			labelA1Bit1Number.Size = new Size(90, 20);
			labelA1Bit1Number.TabIndex = 8;
			labelA1Bit1Number.ToolTipValues.Description = "Shows the number of bit 1 in accumulator 1";
			labelA1Bit1Number.ToolTipValues.EnableToolTips = true;
			labelA1Bit1Number.ToolTipValues.Heading = "Number of bit 1 in accumulator 1";
			labelA1Bit1Number.Values.Text = "---";
			labelA1Bit1Number.DoubleClick += LabelA1Bit1Number_DoubleClick;
			labelA1Bit1Number.Enter += Control_Enter;
			labelA1Bit1Number.Leave += Control_Leave;
			labelA1Bit1Number.MouseEnter += Control_Enter;
			labelA1Bit1Number.MouseLeave += Control_Leave;
			// 
			// labelA2Bit1Number
			// 
			labelA2Bit1Number.AccessibleDescription = "Shows the number of bit 1 in accumulator 2";
			labelA2Bit1Number.AccessibleName = "number of bit 1 in accumulator 2";
			labelA2Bit1Number.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit1Number.Dock = DockStyle.Fill;
			labelA2Bit1Number.Location = new Point(156, 46);
			labelA2Bit1Number.Margin = new Padding(4, 0, 4, 0);
			labelA2Bit1Number.Name = "labelA2Bit1Number";
			labelA2Bit1Number.Size = new Size(90, 20);
			labelA2Bit1Number.TabIndex = 9;
			labelA2Bit1Number.ToolTipValues.Description = "Shows the number of bit 1 in accumulator 2";
			labelA2Bit1Number.ToolTipValues.EnableToolTips = true;
			labelA2Bit1Number.ToolTipValues.Heading = "Number of bit 1 in accumulator 2";
			labelA2Bit1Number.Values.Text = "---";
			labelA2Bit1Number.DoubleClick += LabelA2Bit1Number_DoubleClick;
			labelA2Bit1Number.Enter += Control_Enter;
			labelA2Bit1Number.Leave += Control_Leave;
			labelA2Bit1Number.MouseEnter += Control_Enter;
			labelA2Bit1Number.MouseLeave += Control_Leave;
			// 
			// labelResultBit1Number
			// 
			labelResultBit1Number.AccessibleDescription = "Shows the number of bit 1 in result";
			labelResultBit1Number.AccessibleName = "number of bit 1 in result";
			labelResultBit1Number.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit1Number.Dock = DockStyle.Fill;
			labelResultBit1Number.Location = new Point(256, 46);
			labelResultBit1Number.Margin = new Padding(4, 0, 4, 0);
			labelResultBit1Number.Name = "labelResultBit1Number";
			labelResultBit1Number.Size = new Size(107, 20);
			labelResultBit1Number.TabIndex = 10;
			labelResultBit1Number.ToolTipValues.Description = "Shows the number of bit 1 in result";
			labelResultBit1Number.ToolTipValues.EnableToolTips = true;
			labelResultBit1Number.ToolTipValues.Heading = "Number of bit 0 in result";
			labelResultBit1Number.Values.Text = "---";
			labelResultBit1Number.DoubleClick += LabelResultBit1Number_DoubleClick;
			labelResultBit1Number.Enter += Control_Enter;
			labelResultBit1Number.Leave += Control_Leave;
			labelResultBit1Number.MouseEnter += Control_Enter;
			labelResultBit1Number.MouseLeave += Control_Leave;
			// 
			// labelA1TotalNumber
			// 
			labelA1TotalNumber.AccessibleDescription = "Shows the total number of bits in accumulator 1";
			labelA1TotalNumber.AccessibleName = "total number of bits in accumulator 1";
			labelA1TotalNumber.AccessibleRole = AccessibleRole.StaticText;
			labelA1TotalNumber.Dock = DockStyle.Fill;
			labelA1TotalNumber.Location = new Point(56, 68);
			labelA1TotalNumber.Margin = new Padding(4, 0, 4, 0);
			labelA1TotalNumber.Name = "labelA1TotalNumber";
			labelA1TotalNumber.Size = new Size(90, 20);
			labelA1TotalNumber.TabIndex = 12;
			labelA1TotalNumber.ToolTipValues.Description = "Shows the total number of bits in accumulator 1";
			labelA1TotalNumber.ToolTipValues.EnableToolTips = true;
			labelA1TotalNumber.ToolTipValues.Heading = "Total number of bits in accumulator 1";
			labelA1TotalNumber.Values.Text = "---";
			labelA1TotalNumber.DoubleClick += LabelA1TotalNumber_DoubleClick;
			labelA1TotalNumber.Enter += Control_Enter;
			labelA1TotalNumber.Leave += Control_Leave;
			labelA1TotalNumber.MouseEnter += Control_Enter;
			labelA1TotalNumber.MouseLeave += Control_Leave;
			// 
			// labelA2TotalNumber
			// 
			labelA2TotalNumber.AccessibleDescription = "Shows the total number of bits in accumulator 2";
			labelA2TotalNumber.AccessibleName = "total number of bits in accumulator 2";
			labelA2TotalNumber.AccessibleRole = AccessibleRole.StaticText;
			labelA2TotalNumber.Dock = DockStyle.Fill;
			labelA2TotalNumber.Location = new Point(156, 68);
			labelA2TotalNumber.Margin = new Padding(4, 0, 4, 0);
			labelA2TotalNumber.Name = "labelA2TotalNumber";
			labelA2TotalNumber.Size = new Size(90, 20);
			labelA2TotalNumber.TabIndex = 13;
			labelA2TotalNumber.ToolTipValues.Description = "Shows the total number of bits in accumulator 2";
			labelA2TotalNumber.ToolTipValues.EnableToolTips = true;
			labelA2TotalNumber.ToolTipValues.Heading = "Total number of bits in accumulator 2";
			labelA2TotalNumber.Values.Text = "---";
			labelA2TotalNumber.DoubleClick += LabelA2TotalNumber_DoubleClick;
			labelA2TotalNumber.Enter += Control_Enter;
			labelA2TotalNumber.Leave += Control_Leave;
			labelA2TotalNumber.MouseEnter += Control_Enter;
			labelA2TotalNumber.MouseLeave += Control_Leave;
			// 
			// labelResultTotalNumber
			// 
			labelResultTotalNumber.AccessibleDescription = "Shows the total number of bits in result";
			labelResultTotalNumber.AccessibleName = "total number of bits in result";
			labelResultTotalNumber.AccessibleRole = AccessibleRole.StaticText;
			labelResultTotalNumber.Dock = DockStyle.Fill;
			labelResultTotalNumber.Location = new Point(256, 68);
			labelResultTotalNumber.Margin = new Padding(4, 0, 4, 0);
			labelResultTotalNumber.Name = "labelResultTotalNumber";
			labelResultTotalNumber.Size = new Size(107, 20);
			labelResultTotalNumber.TabIndex = 14;
			labelResultTotalNumber.ToolTipValues.Description = "Shows the total number of bits in result";
			labelResultTotalNumber.ToolTipValues.EnableToolTips = true;
			labelResultTotalNumber.ToolTipValues.Heading = "Total number of bits in result";
			labelResultTotalNumber.Values.Text = "---";
			labelResultTotalNumber.DoubleClick += LabelResultTotalNumber_DoubleClick;
			labelResultTotalNumber.Enter += Control_Enter;
			labelResultTotalNumber.Leave += Control_Leave;
			labelResultTotalNumber.MouseEnter += Control_Enter;
			labelResultTotalNumber.MouseLeave += Control_Leave;
			// 
			// kryptonStatusStrip
			// 
			kryptonStatusStrip.AccessibleDescription = "Shows the status bar";
			kryptonStatusStrip.AccessibleName = "status bar";
			kryptonStatusStrip.AccessibleRole = AccessibleRole.StatusBar;
			kryptonStatusStrip.Dock = DockStyle.None;
			kryptonStatusStrip.Font = new Font("Segoe UI", 9F);
			kryptonStatusStrip.Items.AddRange(new ToolStripItem[] { labelInformation });
			kryptonStatusStrip.Location = new Point(0, 0);
			kryptonStatusStrip.Name = "kryptonStatusStrip";
			kryptonStatusStrip.ProgressBars = null;
			kryptonStatusStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			kryptonStatusStrip.ShowItemToolTips = true;
			kryptonStatusStrip.Size = new Size(368, 22);
			kryptonStatusStrip.SizingGrip = false;
			kryptonStatusStrip.TabIndex = 0;
			kryptonStatusStrip.TabStop = true;
			kryptonStatusStrip.Text = "kryptonStatusStrip";
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
			labelInformation.Name = "labelInformation";
			labelInformation.Size = new Size(93, 17);
			labelInformation.Text = "information text";
			labelInformation.MouseEnter += Control_Enter;
			labelInformation.MouseLeave += Control_Leave;
			// 
			// toolStripContainer
			// 
			toolStripContainer.AccessibleDescription = "Groups all inner elements";
			toolStripContainer.AccessibleName = "Grouping";
			toolStripContainer.AccessibleRole = AccessibleRole.Grouping;
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			toolStripContainer.BottomToolStripPanel.Controls.Add(kryptonStatusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			toolStripContainer.ContentPanel.AutoScroll = true;
			toolStripContainer.ContentPanel.Controls.Add(tableLayoutPanel);
			toolStripContainer.ContentPanel.Margin = new Padding(4, 3, 4, 3);
			toolStripContainer.ContentPanel.Size = new Size(368, 89);
			toolStripContainer.Dock = DockStyle.Fill;
			toolStripContainer.Location = new Point(0, 0);
			toolStripContainer.Margin = new Padding(4, 3, 4, 3);
			toolStripContainer.Name = "toolStripContainer";
			toolStripContainer.Size = new Size(368, 111);
			toolStripContainer.TabIndex = 2;
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
			// StatisticsForm
			// 
			AccessibleDescription = "Shows the statistic window";
			AccessibleName = "statistic window";
			AccessibleRole = AccessibleRole.Window;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(368, 111);
			ControlBox = false;
			Controls.Add(toolStripContainer);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Center;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "StatisticsForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Statistics";
			Load += StatisticsForm_Load;
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
		private System.Windows.Forms.ToolTip toolTip;
		private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip;
		private Krypton.Toolkit.KryptonLabel labelA2Bit0Number;
		private Krypton.Toolkit.KryptonLabel labelA1Bit0Number;
		private Krypton.Toolkit.KryptonLabel labelTotal;
		private Krypton.Toolkit.KryptonLabel labelBit0;
		private Krypton.Toolkit.KryptonLabel labelResult;
		private Krypton.Toolkit.KryptonLabel labelAccumulator2;
		private Krypton.Toolkit.KryptonLabel labelAccumulator1;
		private Krypton.Toolkit.KryptonLabel labelBit1;
		private Krypton.Toolkit.KryptonLabel labelResultBit0Number;
		private Krypton.Toolkit.KryptonLabel labelA1Bit1Number;
		private Krypton.Toolkit.KryptonLabel labelA2Bit1Number;
		private Krypton.Toolkit.KryptonLabel labelResultBit1Number;
		private Krypton.Toolkit.KryptonLabel labelA1TotalNumber;
		private Krypton.Toolkit.KryptonLabel labelA2TotalNumber;
		private Krypton.Toolkit.KryptonLabel labelResultTotalNumber;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private Krypton.Toolkit.KryptonManager kryptonManager;
	}
}