using Krypton.Toolkit;

namespace BitLogicCalculator
{
	partial class MainForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			statusStrip = new KryptonStatusStrip();
			labelInformation = new ToolStripStatusLabel();
			toolTip = new ToolTip(components);
			toolStripContainer = new ToolStripContainer();
			kryptonPictureBoxAppBanner = new KryptonPictureBox();
			groupBoxDataConversion = new GroupBox();
			comboBoxDataConversionUnit = new KryptonComboBox();
			textBoxDataConversion = new KryptonTextBox();
			groupBoxApplicationSettings = new GroupBox();
			buttonAbout = new KryptonButton();
			checkBoxAlwaysOnTop = new KryptonCheckBox();
			groupBoxDataFormat = new GroupBox();
			buttonStatistics = new KryptonButton();
			buttonLsbSign = new KryptonButton();
			comboBoxDataSize = new KryptonComboBox();
			labelMsbRepresentation = new KryptonLabel();
			comboBoxMsbRepresentation = new KryptonComboBox();
			labelDataSize = new KryptonLabel();
			groupBoxOperations = new GroupBox();
			buttonRotateRightWithCarryA2 = new KryptonButton();
			buttonRotateLeftWithCarryA2 = new KryptonButton();
			buttonRotateRightWithCarryA1 = new KryptonButton();
			buttonRotateLeftWithCarryA1 = new KryptonButton();
			groupBoxShiftIndicator = new GroupBox();
			labelShiftIndicator = new KryptonLabel();
			numericUpDownShiftIndicator = new KryptonNumericUpDown();
			buttonBitSwapA2 = new KryptonButton();
			buttonLogicalNandA1AndA2 = new KryptonButton();
			buttonBitSwapA1 = new KryptonButton();
			buttonFormingTwosComponentA2 = new KryptonButton();
			buttonNibbleSwapA2 = new KryptonButton();
			buttonFormingTwosComponentA1 = new KryptonButton();
			buttonHalfSwapA2 = new KryptonButton();
			buttonSubjunctionA2A1 = new KryptonButton();
			buttonHalfSwapA1 = new KryptonButton();
			buttonSubjunctionA1A2 = new KryptonButton();
			buttonNibbleSwapA1 = new KryptonButton();
			buttonInhibitionA2A1 = new KryptonButton();
			buttonArithmeticShiftRightWithOneA2 = new KryptonButton();
			buttonInhibitionA1A2 = new KryptonButton();
			buttonRandomizeA2 = new KryptonButton();
			buttonArithmeticShiftRightWithOneA1 = new KryptonButton();
			buttonRandomizeA1 = new KryptonButton();
			buttonShiftRightWithOneA2 = new KryptonButton();
			buttonArithmeticShiftLeftWithOneA2 = new KryptonButton();
			buttonShiftRightWithOneA1 = new KryptonButton();
			buttonShiftLeftWithOneA2 = new KryptonButton();
			buttonArithmeticShiftLeftWithOneA1 = new KryptonButton();
			buttonShiftLeftWithOneA1 = new KryptonButton();
			buttonSwapA1A2 = new KryptonButton();
			buttonArithmeticShiftLeftWithZeroA2 = new KryptonButton();
			buttonFillA2 = new KryptonButton();
			buttonFillA1 = new KryptonButton();
			buttonArithmeticShiftRightWithZeroA2 = new KryptonButton();
			buttonClearA2 = new KryptonButton();
			buttonClearA1 = new KryptonButton();
			buttonArithmeticShiftLeftWithZeroA1 = new KryptonButton();
			buttonArithmeticShiftRightWithZeroA1 = new KryptonButton();
			buttonRevertA2 = new KryptonButton();
			buttonRevertA1 = new KryptonButton();
			buttonShiftLeftWithZeroA2 = new KryptonButton();
			buttonShiftRightWithZeroA2 = new KryptonButton();
			buttonRotateLeftA2 = new KryptonButton();
			buttonRotateRightA2 = new KryptonButton();
			buttonShiftLeftWithZeroA1 = new KryptonButton();
			buttonShiftRightWithZeroA1 = new KryptonButton();
			buttonRotateLeftA1 = new KryptonButton();
			buttonRotateRightA1 = new KryptonButton();
			buttonAdditionA1AndA2 = new KryptonButton();
			buttonCopyResultToA2 = new KryptonButton();
			buttonSubtractionA1AndA2 = new KryptonButton();
			buttonCopyResultToA1 = new KryptonButton();
			buttonMultiplicationA1AndA2 = new KryptonButton();
			buttonLogicalXnorA1AndA2 = new KryptonButton();
			buttonDivisionA1AndA2 = new KryptonButton();
			buttonLogicalNorA1AndA2 = new KryptonButton();
			buttonLogicalAndA1AndA2 = new KryptonButton();
			buttonLogicalOrA1AndA2 = new KryptonButton();
			buttonInvertA2 = new KryptonButton();
			buttonLogicalXorA1AndA2 = new KryptonButton();
			buttonInvertA1 = new KryptonButton();
			groupBoxResult = new GroupBox();
			textBoxResultOctal = new KryptonTextBox();
			labelResultOctal = new KryptonLabel();
			maskedTextBoxResultNetwork = new KryptonMaskedTextBox();
			labelResultNetwork = new KryptonLabel();
			textResultDecimal = new KryptonTextBox();
			textBoxResultHexadecimal = new KryptonTextBox();
			labelResultDecimal = new KryptonLabel();
			labelResultHexadecimal = new KryptonLabel();
			groupBoxResultByte4 = new GroupBox();
			labelResultBit31 = new KryptonLabel();
			checkBoxResultBit31 = new KryptonCheckBox();
			checkBoxResultBit24 = new KryptonCheckBox();
			labelResultBit24 = new KryptonLabel();
			checkBoxResultBit25 = new KryptonCheckBox();
			labelResultBit30 = new KryptonLabel();
			labelResultBit25 = new KryptonLabel();
			checkBoxResultBit26 = new KryptonCheckBox();
			checkBoxResultBit30 = new KryptonCheckBox();
			labelResultBit26 = new KryptonLabel();
			labelResultBit29 = new KryptonLabel();
			checkBoxResultBit27 = new KryptonCheckBox();
			checkBoxResultBit29 = new KryptonCheckBox();
			labelResultBit27 = new KryptonLabel();
			labelResultBit28 = new KryptonLabel();
			checkBoxResultBit28 = new KryptonCheckBox();
			groupBoxResultByte3 = new GroupBox();
			checkBoxResultBit23 = new KryptonCheckBox();
			checkBoxResultBit21 = new KryptonCheckBox();
			labelResultBit21 = new KryptonLabel();
			labelResultBit20 = new KryptonLabel();
			checkBoxResultBit22 = new KryptonCheckBox();
			checkBoxResultBit20 = new KryptonCheckBox();
			labelResultBit22 = new KryptonLabel();
			labelResultBit19 = new KryptonLabel();
			checkBoxResultBit16 = new KryptonCheckBox();
			checkBoxResultBit19 = new KryptonCheckBox();
			labelResultBit23 = new KryptonLabel();
			labelResultBit18 = new KryptonLabel();
			labelResultBit16 = new KryptonLabel();
			checkBoxResultBit18 = new KryptonCheckBox();
			labelResultBit17 = new KryptonLabel();
			checkBoxResultBit17 = new KryptonCheckBox();
			groupBoxResultByte2 = new GroupBox();
			checkBoxResultBit15 = new KryptonCheckBox();
			checkBoxResultBit10 = new KryptonCheckBox();
			labelResultBit10 = new KryptonLabel();
			labelResultBit09 = new KryptonLabel();
			checkBoxResultBit11 = new KryptonCheckBox();
			checkBoxResultBit09 = new KryptonCheckBox();
			labelResultBit11 = new KryptonLabel();
			labelResultBit15 = new KryptonLabel();
			labelResultBit08 = new KryptonLabel();
			checkBoxResultBit12 = new KryptonCheckBox();
			checkBoxResultBit08 = new KryptonCheckBox();
			labelResultBit12 = new KryptonLabel();
			checkBoxResultBit13 = new KryptonCheckBox();
			labelResultBit13 = new KryptonLabel();
			checkBoxResultBit14 = new KryptonCheckBox();
			labelResultBit14 = new KryptonLabel();
			groupBoxResultByte1 = new GroupBox();
			labelResultBit07 = new KryptonLabel();
			checkBoxResultBit07 = new KryptonCheckBox();
			labelResultBit06 = new KryptonLabel();
			checkBoxResultBit00 = new KryptonCheckBox();
			checkBoxResultBit06 = new KryptonCheckBox();
			labelResultBit00 = new KryptonLabel();
			labelResultBit05 = new KryptonLabel();
			checkBoxResultBit05 = new KryptonCheckBox();
			checkBoxResultBit01 = new KryptonCheckBox();
			labelResultBit04 = new KryptonLabel();
			checkBoxResultBit04 = new KryptonCheckBox();
			labelResultBit01 = new KryptonLabel();
			labelResultBit03 = new KryptonLabel();
			checkBoxResultBit03 = new KryptonCheckBox();
			checkBoxResultBit02 = new KryptonCheckBox();
			labelResultBit02 = new KryptonLabel();
			groupBoxAccumulator2 = new GroupBox();
			textBoxA2Octal = new KryptonTextBox();
			labelA2Octal = new KryptonLabel();
			maskedTextBoxA2Network = new KryptonMaskedTextBox();
			labelA2Network = new KryptonLabel();
			textBoxA2Decimal = new KryptonTextBox();
			textBoxA2Hexadecimal = new KryptonTextBox();
			labelA2Decimal = new KryptonLabel();
			labelA2Hexadecimal = new KryptonLabel();
			groupBoxA2Byte4 = new GroupBox();
			labelA2Bit31 = new KryptonLabel();
			checkBoxA2Bit31 = new KryptonCheckBox();
			checkBoxA2Bit24 = new KryptonCheckBox();
			labelA2Bit24 = new KryptonLabel();
			checkBoxA2Bit25 = new KryptonCheckBox();
			labelA2Bit30 = new KryptonLabel();
			labelA2Bit25 = new KryptonLabel();
			checkBoxA2Bit26 = new KryptonCheckBox();
			checkBoxA2Bit30 = new KryptonCheckBox();
			labelA2Bit26 = new KryptonLabel();
			labelA2Bit29 = new KryptonLabel();
			checkBoxA2Bit27 = new KryptonCheckBox();
			checkBoxA2Bit29 = new KryptonCheckBox();
			labelA2Bit27 = new KryptonLabel();
			labelA2Bit28 = new KryptonLabel();
			checkBoxA2Bit28 = new KryptonCheckBox();
			groupBoxA2Byte3 = new GroupBox();
			checkBoxA2Bit23 = new KryptonCheckBox();
			checkBoxA2Bit21 = new KryptonCheckBox();
			labelA2Bit21 = new KryptonLabel();
			labelA2Bit20 = new KryptonLabel();
			checkBoxA2Bit22 = new KryptonCheckBox();
			checkBoxA2Bit20 = new KryptonCheckBox();
			labelA2Bit22 = new KryptonLabel();
			labelA2Bit19 = new KryptonLabel();
			checkBoxA2Bit16 = new KryptonCheckBox();
			checkBoxA2Bit19 = new KryptonCheckBox();
			labelA2Bit23 = new KryptonLabel();
			labelA2Bit18 = new KryptonLabel();
			labelA2Bit16 = new KryptonLabel();
			checkBoxA2Bit18 = new KryptonCheckBox();
			labelA2Bit17 = new KryptonLabel();
			checkBoxA2Bit17 = new KryptonCheckBox();
			groupBoxA2Byte2 = new GroupBox();
			checkBoxA2Bit15 = new KryptonCheckBox();
			checkBoxA2Bit10 = new KryptonCheckBox();
			labelA2Bit10 = new KryptonLabel();
			labelA2Bit09 = new KryptonLabel();
			checkBoxA2Bit11 = new KryptonCheckBox();
			checkBoxA2Bit09 = new KryptonCheckBox();
			labelA2Bit11 = new KryptonLabel();
			labelA2Bit15 = new KryptonLabel();
			labelA2Bit08 = new KryptonLabel();
			checkBoxA2Bit12 = new KryptonCheckBox();
			checkBoxA2Bit08 = new KryptonCheckBox();
			labelA2Bit12 = new KryptonLabel();
			checkBoxA2Bit13 = new KryptonCheckBox();
			labelA2Bit13 = new KryptonLabel();
			checkBoxA2Bit14 = new KryptonCheckBox();
			labelA2Bit14 = new KryptonLabel();
			groupBoxA2Byte1 = new GroupBox();
			labelA2Bit07 = new KryptonLabel();
			checkBoxA2Bit07 = new KryptonCheckBox();
			labelA2Bit06 = new KryptonLabel();
			checkBoxA2Bit00 = new KryptonCheckBox();
			checkBoxA2Bit06 = new KryptonCheckBox();
			labelA2Bit00 = new KryptonLabel();
			labelA2Bit05 = new KryptonLabel();
			checkBoxA2Bit05 = new KryptonCheckBox();
			checkBoxA2Bit01 = new KryptonCheckBox();
			labelA2Bit04 = new KryptonLabel();
			checkBoxA2Bit04 = new KryptonCheckBox();
			labelA2Bit01 = new KryptonLabel();
			labelA2Bit03 = new KryptonLabel();
			checkBoxA2Bit03 = new KryptonCheckBox();
			checkBoxA2Bit02 = new KryptonCheckBox();
			labelA2Bit02 = new KryptonLabel();
			groupBoxAccumulator1 = new GroupBox();
			textBoxA1Octal = new KryptonTextBox();
			labelA1Octal = new KryptonLabel();
			maskedTextBoxA1Network = new KryptonMaskedTextBox();
			labelA1Network = new KryptonLabel();
			textBoxA1Decimal = new KryptonTextBox();
			textBoxA1Hexadecimal = new KryptonTextBox();
			labelA1Decimal = new KryptonLabel();
			labelA1Hexadecimal = new KryptonLabel();
			groupBoxA1Byte4 = new GroupBox();
			labelA1Bit31 = new KryptonLabel();
			checkBoxA1Bit31 = new KryptonCheckBox();
			checkBoxA1Bit24 = new KryptonCheckBox();
			labelA1Bit24 = new KryptonLabel();
			checkBoxA1Bit25 = new KryptonCheckBox();
			labelA1Bit30 = new KryptonLabel();
			labelA1Bit25 = new KryptonLabel();
			checkBoxA1Bit26 = new KryptonCheckBox();
			checkBoxA1Bit30 = new KryptonCheckBox();
			labelA1Bit26 = new KryptonLabel();
			labelA1Bit29 = new KryptonLabel();
			checkBoxA1Bit27 = new KryptonCheckBox();
			checkBoxA1Bit29 = new KryptonCheckBox();
			labelA1Bit27 = new KryptonLabel();
			labelA1Bit28 = new KryptonLabel();
			checkBoxA1Bit28 = new KryptonCheckBox();
			groupBoxA1Byte3 = new GroupBox();
			checkBoxA1Bit23 = new KryptonCheckBox();
			checkBoxA1Bit21 = new KryptonCheckBox();
			labelA1Bit21 = new KryptonLabel();
			labelA1Bit20 = new KryptonLabel();
			checkBoxA1Bit22 = new KryptonCheckBox();
			checkBoxA1Bit20 = new KryptonCheckBox();
			labelA1Bit22 = new KryptonLabel();
			labelA1Bit19 = new KryptonLabel();
			checkBoxA1Bit16 = new KryptonCheckBox();
			checkBoxA1Bit19 = new KryptonCheckBox();
			labelA1Bit23 = new KryptonLabel();
			labelA1Bit18 = new KryptonLabel();
			labelA1Bit16 = new KryptonLabel();
			checkBoxA1Bit18 = new KryptonCheckBox();
			labelA1Bit17 = new KryptonLabel();
			checkBoxA1Bit17 = new KryptonCheckBox();
			groupBoxA1Byte2 = new GroupBox();
			checkBoxA1Bit15 = new KryptonCheckBox();
			checkBoxA1Bit10 = new KryptonCheckBox();
			labelA1Bit10 = new KryptonLabel();
			labelA1Bit09 = new KryptonLabel();
			checkBoxA1Bit11 = new KryptonCheckBox();
			checkBoxA1Bit09 = new KryptonCheckBox();
			labelA1Bit11 = new KryptonLabel();
			labelA1Bit15 = new KryptonLabel();
			labelA1Bit08 = new KryptonLabel();
			checkBoxA1Bit12 = new KryptonCheckBox();
			checkBoxA1Bit08 = new KryptonCheckBox();
			labelA1Bit12 = new KryptonLabel();
			checkBoxA1Bit13 = new KryptonCheckBox();
			labelA1Bit13 = new KryptonLabel();
			checkBoxA1Bit14 = new KryptonCheckBox();
			labelA1Bit14 = new KryptonLabel();
			groupBoxA1Byte1 = new GroupBox();
			labelA1Bit07 = new KryptonLabel();
			checkBoxA1Bit07 = new KryptonCheckBox();
			labelA1Bit06 = new KryptonLabel();
			checkBoxA1Bit00 = new KryptonCheckBox();
			checkBoxA1Bit06 = new KryptonCheckBox();
			labelA1Bit00 = new KryptonLabel();
			labelA1Bit05 = new KryptonLabel();
			checkBoxA1Bit05 = new KryptonCheckBox();
			checkBoxA1Bit01 = new KryptonCheckBox();
			labelA1Bit04 = new KryptonLabel();
			checkBoxA1Bit04 = new KryptonCheckBox();
			labelA1Bit01 = new KryptonLabel();
			labelA1Bit03 = new KryptonLabel();
			checkBoxA1Bit03 = new KryptonCheckBox();
			checkBoxA1Bit02 = new KryptonCheckBox();
			labelA1Bit02 = new KryptonLabel();
			kryptonManager = new KryptonManager(components);
			statusStrip.SuspendLayout();
			toolStripContainer.BottomToolStripPanel.SuspendLayout();
			toolStripContainer.ContentPanel.SuspendLayout();
			toolStripContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)kryptonPictureBoxAppBanner).BeginInit();
			groupBoxDataConversion.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)comboBoxDataConversionUnit).BeginInit();
			groupBoxApplicationSettings.SuspendLayout();
			groupBoxDataFormat.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)comboBoxDataSize).BeginInit();
			((System.ComponentModel.ISupportInitialize)comboBoxMsbRepresentation).BeginInit();
			groupBoxOperations.SuspendLayout();
			groupBoxShiftIndicator.SuspendLayout();
			groupBoxResult.SuspendLayout();
			groupBoxResultByte4.SuspendLayout();
			groupBoxResultByte3.SuspendLayout();
			groupBoxResultByte2.SuspendLayout();
			groupBoxResultByte1.SuspendLayout();
			groupBoxAccumulator2.SuspendLayout();
			groupBoxA2Byte4.SuspendLayout();
			groupBoxA2Byte3.SuspendLayout();
			groupBoxA2Byte2.SuspendLayout();
			groupBoxA2Byte1.SuspendLayout();
			groupBoxAccumulator1.SuspendLayout();
			groupBoxA1Byte4.SuspendLayout();
			groupBoxA1Byte3.SuspendLayout();
			groupBoxA1Byte2.SuspendLayout();
			groupBoxA1Byte1.SuspendLayout();
			SuspendLayout();
			// 
			// statusStrip
			// 
			statusStrip.Dock = DockStyle.None;
			statusStrip.Font = new Font("Segoe UI", 9F);
			statusStrip.Items.AddRange(new ToolStripItem[] { labelInformation });
			statusStrip.Location = new Point(0, 0);
			statusStrip.Name = "statusStrip";
			statusStrip.ProgressBars = null;
			statusStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			statusStrip.Size = new Size(1356, 22);
			statusStrip.SizingGrip = false;
			statusStrip.TabIndex = 0;
			statusStrip.Text = "statusStrip";
			// 
			// labelInformation
			// 
			labelInformation.Name = "labelInformation";
			labelInformation.Size = new Size(93, 17);
			labelInformation.Text = "information text";
			// 
			// toolStripContainer
			// 
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			toolStripContainer.BottomToolStripPanel.Controls.Add(statusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			toolStripContainer.ContentPanel.BackColor = SystemColors.Control;
			toolStripContainer.ContentPanel.Controls.Add(kryptonPictureBoxAppBanner);
			toolStripContainer.ContentPanel.Controls.Add(groupBoxDataConversion);
			toolStripContainer.ContentPanel.Controls.Add(groupBoxApplicationSettings);
			toolStripContainer.ContentPanel.Controls.Add(groupBoxDataFormat);
			toolStripContainer.ContentPanel.Controls.Add(groupBoxOperations);
			toolStripContainer.ContentPanel.Controls.Add(groupBoxResult);
			toolStripContainer.ContentPanel.Controls.Add(groupBoxAccumulator2);
			toolStripContainer.ContentPanel.Controls.Add(groupBoxAccumulator1);
			toolStripContainer.ContentPanel.Margin = new Padding(4, 3, 4, 3);
			toolStripContainer.ContentPanel.Size = new Size(1356, 535);
			toolStripContainer.Dock = DockStyle.Fill;
			toolStripContainer.Location = new Point(0, 0);
			toolStripContainer.Name = "toolStripContainer";
			toolStripContainer.Size = new Size(1356, 557);
			toolStripContainer.TabIndex = 0;
			toolStripContainer.Text = "toolStripContainer";
			toolStripContainer.TopToolStripPanelVisible = false;
			// 
			// kryptonPictureBoxAppBanner
			// 
			kryptonPictureBoxAppBanner.AccessibleDescription = "Shows the application banner";
			kryptonPictureBoxAppBanner.AccessibleName = "Application banner";
			kryptonPictureBoxAppBanner.AccessibleRole = AccessibleRole.Graphic;
			kryptonPictureBoxAppBanner.Image = (Image)resources.GetObject("kryptonPictureBoxAppBanner.Image");
			kryptonPictureBoxAppBanner.Location = new Point(14, 439);
			kryptonPictureBoxAppBanner.Name = "kryptonPictureBoxAppBanner";
			kryptonPictureBoxAppBanner.Size = new Size(202, 79);
			kryptonPictureBoxAppBanner.SizeMode = PictureBoxSizeMode.Zoom;
			kryptonPictureBoxAppBanner.TabIndex = 92;
			kryptonPictureBoxAppBanner.TabStop = false;
			kryptonPictureBoxAppBanner.ToolTipValues.Description = "Shows the application banner";
			kryptonPictureBoxAppBanner.ToolTipValues.EnableToolTips = true;
			kryptonPictureBoxAppBanner.ToolTipValues.Heading = "Application banner";
			kryptonPictureBoxAppBanner.MouseEnter += Control_Enter;
			kryptonPictureBoxAppBanner.MouseLeave += Control_Leave;
			// 
			// groupBoxDataConversion
			// 
			groupBoxDataConversion.AccessibleDescription = "Groups the data conversion";
			groupBoxDataConversion.AccessibleName = "Data conversion";
			groupBoxDataConversion.AccessibleRole = AccessibleRole.Grouping;
			groupBoxDataConversion.Controls.Add(comboBoxDataConversionUnit);
			groupBoxDataConversion.Controls.Add(textBoxDataConversion);
			groupBoxDataConversion.Location = new Point(369, 440);
			groupBoxDataConversion.Name = "groupBoxDataConversion";
			groupBoxDataConversion.Size = new Size(192, 57);
			groupBoxDataConversion.TabIndex = 91;
			groupBoxDataConversion.TabStop = false;
			groupBoxDataConversion.Text = "Data conversion";
			// 
			// comboBoxDataConversionUnit
			// 
			comboBoxDataConversionUnit.AccessibleDescription = "Sets the data conversion unit";
			comboBoxDataConversionUnit.AccessibleName = "Data conversion unit";
			comboBoxDataConversionUnit.AccessibleRole = AccessibleRole.DropList;
			comboBoxDataConversionUnit.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxDataConversionUnit.DropDownWidth = 80;
			comboBoxDataConversionUnit.FormattingEnabled = true;
			comboBoxDataConversionUnit.Items.AddRange(new object[] { "byte", "kilobyte", "megabyte", "gigabyte", "terabyte" });
			comboBoxDataConversionUnit.Location = new Point(101, 22);
			comboBoxDataConversionUnit.Name = "comboBoxDataConversionUnit";
			comboBoxDataConversionUnit.Size = new Size(80, 22);
			comboBoxDataConversionUnit.TabIndex = 74;
			comboBoxDataConversionUnit.ToolTipValues.Description = "Sets the data conversion unit";
			comboBoxDataConversionUnit.ToolTipValues.EnableToolTips = true;
			comboBoxDataConversionUnit.ToolTipValues.Heading = "Data conversion unit";
			comboBoxDataConversionUnit.SelectedIndexChanged += ComboBoxDataConversionUnit_SelectedIndexChanged;
			comboBoxDataConversionUnit.Enter += Control_Enter;
			comboBoxDataConversionUnit.Leave += Control_Leave;
			comboBoxDataConversionUnit.MouseEnter += Control_Enter;
			comboBoxDataConversionUnit.MouseLeave += Control_Leave;
			// 
			// textBoxDataConversion
			// 
			textBoxDataConversion.AccessibleDescription = "Sets the data conversion value";
			textBoxDataConversion.AccessibleName = "Data conversion value";
			textBoxDataConversion.AccessibleRole = AccessibleRole.Text;
			textBoxDataConversion.Location = new Point(7, 21);
			textBoxDataConversion.Name = "textBoxDataConversion";
			textBoxDataConversion.Size = new Size(90, 23);
			textBoxDataConversion.TabIndex = 72;
			textBoxDataConversion.ToolTipValues.Description = "Sets the data conversion value";
			textBoxDataConversion.ToolTipValues.EnableToolTips = true;
			textBoxDataConversion.ToolTipValues.Heading = "Data conversion value";
			textBoxDataConversion.TextChanged += TextBoxDataConversion_TextChanged;
			textBoxDataConversion.Enter += Control_Enter;
			textBoxDataConversion.Leave += Control_Leave;
			textBoxDataConversion.MouseEnter += Control_Enter;
			textBoxDataConversion.MouseLeave += Control_Leave;
			// 
			// groupBoxApplicationSettings
			// 
			groupBoxApplicationSettings.AccessibleDescription = "Groups the application settings";
			groupBoxApplicationSettings.AccessibleName = "Application settings";
			groupBoxApplicationSettings.AccessibleRole = AccessibleRole.Grouping;
			groupBoxApplicationSettings.Controls.Add(buttonAbout);
			groupBoxApplicationSettings.Controls.Add(checkBoxAlwaysOnTop);
			groupBoxApplicationSettings.Location = new Point(230, 440);
			groupBoxApplicationSettings.Name = "groupBoxApplicationSettings";
			groupBoxApplicationSettings.Size = new Size(131, 78);
			groupBoxApplicationSettings.TabIndex = 90;
			groupBoxApplicationSettings.TabStop = false;
			groupBoxApplicationSettings.Text = "Application settings";
			// 
			// buttonAbout
			// 
			buttonAbout.AccessibleDescription = "Shows some application info";
			buttonAbout.AccessibleName = "About application info";
			buttonAbout.AccessibleRole = AccessibleRole.PushButton;
			buttonAbout.Location = new Point(25, 43);
			buttonAbout.Name = "buttonAbout";
			buttonAbout.Size = new Size(88, 24);
			buttonAbout.TabIndex = 92;
			buttonAbout.ToolTipValues.Description = "Shows some application info";
			buttonAbout.ToolTipValues.EnableToolTips = true;
			buttonAbout.ToolTipValues.Heading = "About application info";
			buttonAbout.Values.DropDownArrowColor = Color.Empty;
			buttonAbout.Values.Text = "About...";
			buttonAbout.Click += ButtonAbout_Click;
			buttonAbout.Enter += Control_Enter;
			buttonAbout.Leave += Control_Leave;
			buttonAbout.MouseEnter += Control_Enter;
			buttonAbout.MouseLeave += Control_Leave;
			// 
			// checkBoxAlwaysOnTop
			// 
			checkBoxAlwaysOnTop.AccessibleDescription = "Toggles always on to";
			checkBoxAlwaysOnTop.AccessibleName = "Always on top";
			checkBoxAlwaysOnTop.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxAlwaysOnTop.Location = new Point(11, 18);
			checkBoxAlwaysOnTop.Name = "checkBoxAlwaysOnTop";
			checkBoxAlwaysOnTop.Size = new Size(101, 20);
			checkBoxAlwaysOnTop.TabIndex = 2;
			checkBoxAlwaysOnTop.ToolTipValues.Description = "Toggles always on to";
			checkBoxAlwaysOnTop.ToolTipValues.EnableToolTips = true;
			checkBoxAlwaysOnTop.ToolTipValues.Heading = "Always on to";
			checkBoxAlwaysOnTop.Values.Text = "Always on top";
			checkBoxAlwaysOnTop.CheckedChanged += CheckBoxAlwaysOnTop_CheckedChanged;
			checkBoxAlwaysOnTop.Enter += Control_Enter;
			checkBoxAlwaysOnTop.Leave += Control_Leave;
			checkBoxAlwaysOnTop.MouseEnter += Control_Enter;
			checkBoxAlwaysOnTop.MouseLeave += Control_Leave;
			// 
			// groupBoxDataFormat
			// 
			groupBoxDataFormat.AccessibleDescription = "Groups the elements of the data format";
			groupBoxDataFormat.AccessibleName = "Elements of the data format";
			groupBoxDataFormat.AccessibleRole = AccessibleRole.Grouping;
			groupBoxDataFormat.BackColor = Color.Transparent;
			groupBoxDataFormat.Controls.Add(buttonStatistics);
			groupBoxDataFormat.Controls.Add(buttonLsbSign);
			groupBoxDataFormat.Controls.Add(comboBoxDataSize);
			groupBoxDataFormat.Controls.Add(labelMsbRepresentation);
			groupBoxDataFormat.Controls.Add(comboBoxMsbRepresentation);
			groupBoxDataFormat.Controls.Add(labelDataSize);
			groupBoxDataFormat.Location = new Point(568, 440);
			groupBoxDataFormat.Name = "groupBoxDataFormat";
			groupBoxDataFormat.Size = new Size(266, 78);
			groupBoxDataFormat.TabIndex = 88;
			groupBoxDataFormat.TabStop = false;
			groupBoxDataFormat.Text = "Data format";
			// 
			// buttonStatistics
			// 
			buttonStatistics.AccessibleDescription = "Shows some statistics";
			buttonStatistics.AccessibleName = "Statistics";
			buttonStatistics.AccessibleRole = AccessibleRole.PushButton;
			buttonStatistics.Location = new Point(192, 43);
			buttonStatistics.Name = "buttonStatistics";
			buttonStatistics.Size = new Size(66, 22);
			buttonStatistics.TabIndex = 10;
			buttonStatistics.ToolTipValues.Description = "Shows some statistics";
			buttonStatistics.ToolTipValues.EnableToolTips = true;
			buttonStatistics.ToolTipValues.Heading = "Statistics";
			buttonStatistics.Values.DropDownArrowColor = Color.Empty;
			buttonStatistics.Values.Text = "Statistics";
			buttonStatistics.Click += ButtonStatistics_Click;
			buttonStatistics.Enter += Control_Enter;
			buttonStatistics.Leave += Control_Leave;
			buttonStatistics.MouseEnter += Control_Enter;
			buttonStatistics.MouseLeave += Control_Leave;
			// 
			// buttonLsbSign
			// 
			buttonLsbSign.AccessibleDescription = "Set the last significat byte to 0 either 1";
			buttonLsbSign.AccessibleName = "Last significat byte";
			buttonLsbSign.AccessibleRole = AccessibleRole.PushButton;
			buttonLsbSign.Location = new Point(192, 15);
			buttonLsbSign.Name = "buttonLsbSign";
			buttonLsbSign.Size = new Size(66, 22);
			buttonLsbSign.TabIndex = 8;
			buttonLsbSign.ToolTipValues.Description = "Set the last significat byte to 0 either 1";
			buttonLsbSign.ToolTipValues.EnableToolTips = true;
			buttonLsbSign.ToolTipValues.Heading = "Last significat byte";
			buttonLsbSign.Values.DropDownArrowColor = Color.Empty;
			buttonLsbSign.Values.Text = "LSB: 0";
			buttonLsbSign.Click += ButtonLsbSign_Click;
			buttonLsbSign.Enter += Control_Enter;
			buttonLsbSign.Leave += Control_Leave;
			buttonLsbSign.MouseEnter += Control_Enter;
			buttonLsbSign.MouseLeave += Control_Leave;
			// 
			// comboBoxDataSize
			// 
			comboBoxDataSize.AccessibleDescription = "Sets the data size";
			comboBoxDataSize.AccessibleName = "Data size";
			comboBoxDataSize.AccessibleRole = AccessibleRole.DropList;
			comboBoxDataSize.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxDataSize.DropDownWidth = 98;
			comboBoxDataSize.FormattingEnabled = true;
			comboBoxDataSize.Items.AddRange(new object[] { "8 bit", "16 bit", "32 bit" });
			comboBoxDataSize.Location = new Point(86, 15);
			comboBoxDataSize.Name = "comboBoxDataSize";
			comboBoxDataSize.Size = new Size(98, 22);
			comboBoxDataSize.TabIndex = 9;
			comboBoxDataSize.ToolTipValues.Description = "Sets the data size";
			comboBoxDataSize.ToolTipValues.EnableToolTips = true;
			comboBoxDataSize.ToolTipValues.Heading = "Data size";
			comboBoxDataSize.SelectedIndexChanged += ComboBoxDataSize_SelectedIndexChanged;
			comboBoxDataSize.Enter += Control_Enter;
			comboBoxDataSize.Leave += Control_Leave;
			comboBoxDataSize.MouseEnter += Control_Enter;
			comboBoxDataSize.MouseLeave += Control_Leave;
			// 
			// labelMsbRepresentation
			// 
			labelMsbRepresentation.AccessibleDescription = "Shows the description of the most significant byte representation";
			labelMsbRepresentation.AccessibleName = "Description of the most significant byte representation";
			labelMsbRepresentation.AccessibleRole = AccessibleRole.StaticText;
			labelMsbRepresentation.Location = new Point(6, 46);
			labelMsbRepresentation.Name = "labelMsbRepresentation";
			labelMsbRepresentation.Size = new Size(69, 20);
			labelMsbRepresentation.TabIndex = 8;
			labelMsbRepresentation.Values.Text = "MSB Repr.:";
			labelMsbRepresentation.Enter += Control_Enter;
			labelMsbRepresentation.Leave += Control_Leave;
			labelMsbRepresentation.MouseEnter += Control_Enter;
			labelMsbRepresentation.MouseLeave += Control_Leave;
			// 
			// comboBoxMsbRepresentation
			// 
			comboBoxMsbRepresentation.AccessibleDescription = "Sets the most significant byte representation";
			comboBoxMsbRepresentation.AccessibleName = "Most significant byte representation";
			comboBoxMsbRepresentation.AccessibleRole = AccessibleRole.DropList;
			comboBoxMsbRepresentation.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxMsbRepresentation.DropDownWidth = 98;
			comboBoxMsbRepresentation.FormattingEnabled = true;
			comboBoxMsbRepresentation.Items.AddRange(new object[] { "unsigned", "signed" });
			comboBoxMsbRepresentation.Location = new Point(86, 43);
			comboBoxMsbRepresentation.Name = "comboBoxMsbRepresentation";
			comboBoxMsbRepresentation.Size = new Size(98, 22);
			comboBoxMsbRepresentation.TabIndex = 7;
			comboBoxMsbRepresentation.ToolTipValues.Description = "Sets the most significant byte representation";
			comboBoxMsbRepresentation.ToolTipValues.EnableToolTips = true;
			comboBoxMsbRepresentation.ToolTipValues.Heading = "Most significant byte representation";
			comboBoxMsbRepresentation.SelectedIndexChanged += ComboBoxMsbRepresentation_SelectedIndexChanged;
			comboBoxMsbRepresentation.Enter += Control_Enter;
			comboBoxMsbRepresentation.Leave += Control_Leave;
			comboBoxMsbRepresentation.MouseEnter += Control_Enter;
			comboBoxMsbRepresentation.MouseLeave += Control_Leave;
			// 
			// labelDataSize
			// 
			labelDataSize.AccessibleDescription = "Shows the description of the data size";
			labelDataSize.AccessibleName = "Description of the data size";
			labelDataSize.AccessibleRole = AccessibleRole.StaticText;
			labelDataSize.Location = new Point(6, 18);
			labelDataSize.Name = "labelDataSize";
			labelDataSize.Size = new Size(62, 20);
			labelDataSize.TabIndex = 6;
			labelDataSize.Values.Text = "Data size:";
			labelDataSize.Enter += Control_Enter;
			labelDataSize.Leave += Control_Leave;
			labelDataSize.MouseEnter += Control_Enter;
			labelDataSize.MouseLeave += Control_Leave;
			// 
			// groupBoxOperations
			// 
			groupBoxOperations.AccessibleDescription = "Groups the elements of the operations";
			groupBoxOperations.AccessibleName = "Elements of the operations";
			groupBoxOperations.AccessibleRole = AccessibleRole.Grouping;
			groupBoxOperations.BackColor = Color.Transparent;
			groupBoxOperations.Controls.Add(buttonRotateRightWithCarryA2);
			groupBoxOperations.Controls.Add(buttonRotateLeftWithCarryA2);
			groupBoxOperations.Controls.Add(buttonRotateRightWithCarryA1);
			groupBoxOperations.Controls.Add(buttonRotateLeftWithCarryA1);
			groupBoxOperations.Controls.Add(groupBoxShiftIndicator);
			groupBoxOperations.Controls.Add(buttonBitSwapA2);
			groupBoxOperations.Controls.Add(buttonLogicalNandA1AndA2);
			groupBoxOperations.Controls.Add(buttonBitSwapA1);
			groupBoxOperations.Controls.Add(buttonFormingTwosComponentA2);
			groupBoxOperations.Controls.Add(buttonNibbleSwapA2);
			groupBoxOperations.Controls.Add(buttonFormingTwosComponentA1);
			groupBoxOperations.Controls.Add(buttonHalfSwapA2);
			groupBoxOperations.Controls.Add(buttonSubjunctionA2A1);
			groupBoxOperations.Controls.Add(buttonHalfSwapA1);
			groupBoxOperations.Controls.Add(buttonSubjunctionA1A2);
			groupBoxOperations.Controls.Add(buttonNibbleSwapA1);
			groupBoxOperations.Controls.Add(buttonInhibitionA2A1);
			groupBoxOperations.Controls.Add(buttonArithmeticShiftRightWithOneA2);
			groupBoxOperations.Controls.Add(buttonInhibitionA1A2);
			groupBoxOperations.Controls.Add(buttonRandomizeA2);
			groupBoxOperations.Controls.Add(buttonArithmeticShiftRightWithOneA1);
			groupBoxOperations.Controls.Add(buttonRandomizeA1);
			groupBoxOperations.Controls.Add(buttonShiftRightWithOneA2);
			groupBoxOperations.Controls.Add(buttonArithmeticShiftLeftWithOneA2);
			groupBoxOperations.Controls.Add(buttonShiftRightWithOneA1);
			groupBoxOperations.Controls.Add(buttonShiftLeftWithOneA2);
			groupBoxOperations.Controls.Add(buttonArithmeticShiftLeftWithOneA1);
			groupBoxOperations.Controls.Add(buttonShiftLeftWithOneA1);
			groupBoxOperations.Controls.Add(buttonSwapA1A2);
			groupBoxOperations.Controls.Add(buttonArithmeticShiftLeftWithZeroA2);
			groupBoxOperations.Controls.Add(buttonFillA2);
			groupBoxOperations.Controls.Add(buttonFillA1);
			groupBoxOperations.Controls.Add(buttonArithmeticShiftRightWithZeroA2);
			groupBoxOperations.Controls.Add(buttonClearA2);
			groupBoxOperations.Controls.Add(buttonClearA1);
			groupBoxOperations.Controls.Add(buttonArithmeticShiftLeftWithZeroA1);
			groupBoxOperations.Controls.Add(buttonArithmeticShiftRightWithZeroA1);
			groupBoxOperations.Controls.Add(buttonRevertA2);
			groupBoxOperations.Controls.Add(buttonRevertA1);
			groupBoxOperations.Controls.Add(buttonShiftLeftWithZeroA2);
			groupBoxOperations.Controls.Add(buttonShiftRightWithZeroA2);
			groupBoxOperations.Controls.Add(buttonRotateLeftA2);
			groupBoxOperations.Controls.Add(buttonRotateRightA2);
			groupBoxOperations.Controls.Add(buttonShiftLeftWithZeroA1);
			groupBoxOperations.Controls.Add(buttonShiftRightWithZeroA1);
			groupBoxOperations.Controls.Add(buttonRotateLeftA1);
			groupBoxOperations.Controls.Add(buttonRotateRightA1);
			groupBoxOperations.Controls.Add(buttonAdditionA1AndA2);
			groupBoxOperations.Controls.Add(buttonCopyResultToA2);
			groupBoxOperations.Controls.Add(buttonSubtractionA1AndA2);
			groupBoxOperations.Controls.Add(buttonCopyResultToA1);
			groupBoxOperations.Controls.Add(buttonMultiplicationA1AndA2);
			groupBoxOperations.Controls.Add(buttonLogicalXnorA1AndA2);
			groupBoxOperations.Controls.Add(buttonDivisionA1AndA2);
			groupBoxOperations.Controls.Add(buttonLogicalNorA1AndA2);
			groupBoxOperations.Controls.Add(buttonLogicalAndA1AndA2);
			groupBoxOperations.Controls.Add(buttonLogicalOrA1AndA2);
			groupBoxOperations.Controls.Add(buttonInvertA2);
			groupBoxOperations.Controls.Add(buttonLogicalXorA1AndA2);
			groupBoxOperations.Controls.Add(buttonInvertA1);
			groupBoxOperations.Location = new Point(841, 14);
			groupBoxOperations.Name = "groupBoxOperations";
			groupBoxOperations.Size = new Size(502, 504);
			groupBoxOperations.TabIndex = 83;
			groupBoxOperations.TabStop = false;
			groupBoxOperations.Text = "Operations";
			// 
			// buttonRotateRightWithCarryA2
			// 
			buttonRotateRightWithCarryA2.AccessibleDescription = "Rotate the value of A2 with carry to the right";
			buttonRotateRightWithCarryA2.AccessibleName = "Right-rotation of A2 with carry";
			buttonRotateRightWithCarryA2.AccessibleRole = AccessibleRole.PushButton;
			buttonRotateRightWithCarryA2.Enabled = false;
			buttonRotateRightWithCarryA2.Location = new Point(401, 391);
			buttonRotateRightWithCarryA2.Name = "buttonRotateRightWithCarryA2";
			buttonRotateRightWithCarryA2.Size = new Size(91, 27);
			buttonRotateRightWithCarryA2.TabIndex = 134;
			buttonRotateRightWithCarryA2.ToolTipValues.Description = "Rotate the value of A2 with carry to the right";
			buttonRotateRightWithCarryA2.ToolTipValues.EnableToolTips = true;
			buttonRotateRightWithCarryA2.ToolTipValues.Heading = "Right-rotation of A2 with carry";
			buttonRotateRightWithCarryA2.Values.DropDownArrowColor = Color.Empty;
			buttonRotateRightWithCarryA2.Values.Text = "RORC1 A2";
			buttonRotateRightWithCarryA2.Click += ButtonRotateRightWithCarryA2_Click;
			buttonRotateRightWithCarryA2.Enter += Control_Enter;
			buttonRotateRightWithCarryA2.Leave += Control_Leave;
			buttonRotateRightWithCarryA2.MouseEnter += Control_Enter;
			buttonRotateRightWithCarryA2.MouseLeave += Control_Leave;
			// 
			// buttonRotateLeftWithCarryA2
			// 
			buttonRotateLeftWithCarryA2.AccessibleDescription = "Rotate the value of A2 with carry to the left";
			buttonRotateLeftWithCarryA2.AccessibleName = "Left-rotation of A2 with carry";
			buttonRotateLeftWithCarryA2.AccessibleRole = AccessibleRole.PushButton;
			buttonRotateLeftWithCarryA2.Enabled = false;
			buttonRotateLeftWithCarryA2.Location = new Point(401, 358);
			buttonRotateLeftWithCarryA2.Name = "buttonRotateLeftWithCarryA2";
			buttonRotateLeftWithCarryA2.Size = new Size(91, 27);
			buttonRotateLeftWithCarryA2.TabIndex = 132;
			buttonRotateLeftWithCarryA2.ToolTipValues.Description = "Rotate the value of A2 with carry to the left";
			buttonRotateLeftWithCarryA2.ToolTipValues.EnableToolTips = true;
			buttonRotateLeftWithCarryA2.ToolTipValues.Heading = "Left-rotation of A2 with carry";
			buttonRotateLeftWithCarryA2.Values.DropDownArrowColor = Color.Empty;
			buttonRotateLeftWithCarryA2.Values.Text = "ROLC1 A2";
			buttonRotateLeftWithCarryA2.Click += ButtonRotateLeftWithCarryA2_Click;
			buttonRotateLeftWithCarryA2.Enter += Control_Enter;
			buttonRotateLeftWithCarryA2.Leave += Control_Leave;
			buttonRotateLeftWithCarryA2.MouseEnter += Control_Enter;
			buttonRotateLeftWithCarryA2.MouseLeave += Control_Leave;
			// 
			// buttonRotateRightWithCarryA1
			// 
			buttonRotateRightWithCarryA1.AccessibleDescription = "Rotate the value of A1 with carry to the right";
			buttonRotateRightWithCarryA1.AccessibleName = "Right-rotation of A1 with carry";
			buttonRotateRightWithCarryA1.AccessibleRole = AccessibleRole.PushButton;
			buttonRotateRightWithCarryA1.Enabled = false;
			buttonRotateRightWithCarryA1.Location = new Point(303, 391);
			buttonRotateRightWithCarryA1.Name = "buttonRotateRightWithCarryA1";
			buttonRotateRightWithCarryA1.Size = new Size(91, 27);
			buttonRotateRightWithCarryA1.TabIndex = 130;
			buttonRotateRightWithCarryA1.ToolTipValues.Description = "Rotate the value of A1 with carry to the right";
			buttonRotateRightWithCarryA1.ToolTipValues.EnableToolTips = true;
			buttonRotateRightWithCarryA1.ToolTipValues.Heading = "Right-rotation of A1 with carry";
			buttonRotateRightWithCarryA1.Values.DropDownArrowColor = Color.Empty;
			buttonRotateRightWithCarryA1.Values.Text = "RORC1 A1";
			buttonRotateRightWithCarryA1.Click += ButtonRotateRightWithCarryA1_Click;
			buttonRotateRightWithCarryA1.Enter += Control_Enter;
			buttonRotateRightWithCarryA1.Leave += Control_Leave;
			buttonRotateRightWithCarryA1.MouseEnter += Control_Enter;
			buttonRotateRightWithCarryA1.MouseLeave += Control_Leave;
			// 
			// buttonRotateLeftWithCarryA1
			// 
			buttonRotateLeftWithCarryA1.AccessibleDescription = "Rotate the value of A1 with carry to the left";
			buttonRotateLeftWithCarryA1.AccessibleName = "Left-rotation of A1 with carry";
			buttonRotateLeftWithCarryA1.AccessibleRole = AccessibleRole.PushButton;
			buttonRotateLeftWithCarryA1.Enabled = false;
			buttonRotateLeftWithCarryA1.Location = new Point(303, 358);
			buttonRotateLeftWithCarryA1.Name = "buttonRotateLeftWithCarryA1";
			buttonRotateLeftWithCarryA1.Size = new Size(91, 27);
			buttonRotateLeftWithCarryA1.TabIndex = 128;
			buttonRotateLeftWithCarryA1.ToolTipValues.Description = "Rotate the value of A1 with carry to the left";
			buttonRotateLeftWithCarryA1.ToolTipValues.EnableToolTips = true;
			buttonRotateLeftWithCarryA1.ToolTipValues.Heading = "Left-rotation of A1 with carry";
			buttonRotateLeftWithCarryA1.Values.DropDownArrowColor = Color.Empty;
			buttonRotateLeftWithCarryA1.Values.Text = "ROLC1 A1";
			buttonRotateLeftWithCarryA1.Click += ButtonRotateLeftWithCarryA1_Click;
			buttonRotateLeftWithCarryA1.Enter += Control_Enter;
			buttonRotateLeftWithCarryA1.Leave += Control_Leave;
			buttonRotateLeftWithCarryA1.MouseEnter += Control_Enter;
			buttonRotateLeftWithCarryA1.MouseLeave += Control_Leave;
			// 
			// groupBoxShiftIndicator
			// 
			groupBoxShiftIndicator.AccessibleDescription = "Groups the elements of the shift indicator";
			groupBoxShiftIndicator.AccessibleName = "Elements of the shift indicator";
			groupBoxShiftIndicator.AccessibleRole = AccessibleRole.Grouping;
			groupBoxShiftIndicator.Controls.Add(labelShiftIndicator);
			groupBoxShiftIndicator.Controls.Add(numericUpDownShiftIndicator);
			groupBoxShiftIndicator.Location = new Point(303, 426);
			groupBoxShiftIndicator.Name = "groupBoxShiftIndicator";
			groupBoxShiftIndicator.Size = new Size(187, 60);
			groupBoxShiftIndicator.TabIndex = 126;
			groupBoxShiftIndicator.TabStop = false;
			groupBoxShiftIndicator.Text = "Shift indicator";
			groupBoxShiftIndicator.Enter += Control_Enter;
			groupBoxShiftIndicator.Leave += Control_Leave;
			// 
			// labelShiftIndicator
			// 
			labelShiftIndicator.AccessibleDescription = "Shows the sescription of the shift indicator";
			labelShiftIndicator.AccessibleName = "Description of the shift indicator";
			labelShiftIndicator.AccessibleRole = AccessibleRole.StaticText;
			labelShiftIndicator.Location = new Point(61, 12);
			labelShiftIndicator.Name = "labelShiftIndicator";
			labelShiftIndicator.Size = new Size(358, 45);
			labelShiftIndicator.TabIndex = 93;
			labelShiftIndicator.Values.Text = "Defines the number of bit positions for all shifting and rotations";
			labelShiftIndicator.Enter += Control_Enter;
			labelShiftIndicator.Leave += Control_Leave;
			labelShiftIndicator.MouseEnter += Control_Enter;
			labelShiftIndicator.MouseLeave += Control_Leave;
			// 
			// numericUpDownShiftIndicator
			// 
			numericUpDownShiftIndicator.AccessibleDescription = "Sets the value of the shift indicator";
			numericUpDownShiftIndicator.AccessibleName = "Value of the shift indicator";
			numericUpDownShiftIndicator.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownShiftIndicator.Increment = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownShiftIndicator.Location = new Point(7, 22);
			numericUpDownShiftIndicator.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
			numericUpDownShiftIndicator.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownShiftIndicator.Name = "numericUpDownShiftIndicator";
			numericUpDownShiftIndicator.Size = new Size(48, 22);
			numericUpDownShiftIndicator.StateCommon.Content.TextH = PaletteRelativeAlign.Far;
			numericUpDownShiftIndicator.TabIndex = 92;
			numericUpDownShiftIndicator.ToolTipValues.Description = "Sets the value of the shift indicator";
			numericUpDownShiftIndicator.ToolTipValues.EnableToolTips = true;
			numericUpDownShiftIndicator.ToolTipValues.Heading = "Value of the shift indicator";
			numericUpDownShiftIndicator.Value = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownShiftIndicator.MouseEnter += Control_Enter;
			numericUpDownShiftIndicator.MouseLeave += Control_Leave;
			// 
			// buttonBitSwapA2
			// 
			buttonBitSwapA2.AccessibleDescription = "Swaps two neighbour bits of A2";
			buttonBitSwapA2.AccessibleName = "Bit swap of A2";
			buttonBitSwapA2.AccessibleRole = AccessibleRole.PushButton;
			buttonBitSwapA2.Location = new Point(204, 91);
			buttonBitSwapA2.Name = "buttonBitSwapA2";
			buttonBitSwapA2.Size = new Size(91, 27);
			buttonBitSwapA2.TabIndex = 125;
			buttonBitSwapA2.ToolTipValues.Description = "Swaps two neighbour bits of A2";
			buttonBitSwapA2.ToolTipValues.EnableToolTips = true;
			buttonBitSwapA2.ToolTipValues.Heading = "Bit swap of A2";
			buttonBitSwapA2.Values.DropDownArrowColor = Color.Empty;
			buttonBitSwapA2.Values.Text = "BITSWP A2";
			buttonBitSwapA2.Click += ButtonBitSwapA2_Click;
			buttonBitSwapA2.Enter += Control_Enter;
			buttonBitSwapA2.Leave += Control_Leave;
			buttonBitSwapA2.MouseEnter += Control_Enter;
			buttonBitSwapA2.MouseLeave += Control_Leave;
			// 
			// buttonLogicalNandA1AndA2
			// 
			buttonLogicalNandA1AndA2.AccessibleDescription = "Calculates the logical NAND of A1 and A2";
			buttonLogicalNandA1AndA2.AccessibleName = "Logical NAND of A1 and A2";
			buttonLogicalNandA1AndA2.AccessibleRole = AccessibleRole.PushButton;
			buttonLogicalNandA1AndA2.Location = new Point(7, 258);
			buttonLogicalNandA1AndA2.Name = "buttonLogicalNandA1AndA2";
			buttonLogicalNandA1AndA2.Size = new Size(91, 27);
			buttonLogicalNandA1AndA2.TabIndex = 113;
			buttonLogicalNandA1AndA2.ToolTipValues.Description = "Calculates the logical NAND of A1 and A2";
			buttonLogicalNandA1AndA2.ToolTipValues.EnableToolTips = true;
			buttonLogicalNandA1AndA2.ToolTipValues.Heading = "Logical NAND of A1 and A2";
			buttonLogicalNandA1AndA2.Values.DropDownArrowColor = Color.Empty;
			buttonLogicalNandA1AndA2.Values.Text = "A1 NAND A2";
			buttonLogicalNandA1AndA2.Click += ButtonLogicalNandA1AndA2_Click_Click;
			buttonLogicalNandA1AndA2.Enter += Control_Enter;
			buttonLogicalNandA1AndA2.Leave += Control_Leave;
			buttonLogicalNandA1AndA2.MouseEnter += Control_Enter;
			buttonLogicalNandA1AndA2.MouseLeave += Control_Leave;
			// 
			// buttonBitSwapA1
			// 
			buttonBitSwapA1.AccessibleDescription = "Swaps two neighbour bits of A1";
			buttonBitSwapA1.AccessibleName = "Bit swap of A2";
			buttonBitSwapA1.AccessibleRole = AccessibleRole.PushButton;
			buttonBitSwapA1.Location = new Point(106, 91);
			buttonBitSwapA1.Name = "buttonBitSwapA1";
			buttonBitSwapA1.Size = new Size(91, 27);
			buttonBitSwapA1.TabIndex = 124;
			buttonBitSwapA1.ToolTipValues.Description = "Swaps two neighbour bits of A1";
			buttonBitSwapA1.ToolTipValues.EnableToolTips = true;
			buttonBitSwapA1.ToolTipValues.Heading = "Bit swap of A2";
			buttonBitSwapA1.Values.DropDownArrowColor = Color.Empty;
			buttonBitSwapA1.Values.Text = "BITSWP A1";
			buttonBitSwapA1.Click += ButtonBitSwapA1_Click;
			buttonBitSwapA1.Enter += Control_Enter;
			buttonBitSwapA1.Leave += Control_Leave;
			buttonBitSwapA1.MouseEnter += Control_Enter;
			buttonBitSwapA1.MouseLeave += Control_Leave;
			// 
			// buttonFormingTwosComponentA2
			// 
			buttonFormingTwosComponentA2.AccessibleDescription = "Forming the two's complement of A2";
			buttonFormingTwosComponentA2.AccessibleName = "Two's complement of A2";
			buttonFormingTwosComponentA2.AccessibleRole = AccessibleRole.PushButton;
			buttonFormingTwosComponentA2.Enabled = false;
			buttonFormingTwosComponentA2.Location = new Point(204, 325);
			buttonFormingTwosComponentA2.Name = "buttonFormingTwosComponentA2";
			buttonFormingTwosComponentA2.Size = new Size(91, 27);
			buttonFormingTwosComponentA2.TabIndex = 112;
			buttonFormingTwosComponentA2.ToolTipValues.Description = "Forming the two's complement of A2";
			buttonFormingTwosComponentA2.ToolTipValues.EnableToolTips = true;
			buttonFormingTwosComponentA2.ToolTipValues.Heading = "Two's complement of A2";
			buttonFormingTwosComponentA2.Values.DropDownArrowColor = Color.Empty;
			buttonFormingTwosComponentA2.Values.Text = "TC A2";
			buttonFormingTwosComponentA2.Click += ButtonFormingTwosComponentA2_Click;
			buttonFormingTwosComponentA2.Enter += Control_Enter;
			buttonFormingTwosComponentA2.Leave += Control_Leave;
			buttonFormingTwosComponentA2.MouseEnter += Control_Enter;
			buttonFormingTwosComponentA2.MouseLeave += Control_Leave;
			// 
			// buttonNibbleSwapA2
			// 
			buttonNibbleSwapA2.AccessibleDescription = "Swaps two nibbles of A2";
			buttonNibbleSwapA2.AccessibleName = "Nibble swap of A2";
			buttonNibbleSwapA2.AccessibleRole = AccessibleRole.PushButton;
			buttonNibbleSwapA2.Location = new Point(204, 58);
			buttonNibbleSwapA2.Name = "buttonNibbleSwapA2";
			buttonNibbleSwapA2.Size = new Size(91, 27);
			buttonNibbleSwapA2.TabIndex = 123;
			buttonNibbleSwapA2.ToolTipValues.Description = "Swaps two nibbles of A2";
			buttonNibbleSwapA2.ToolTipValues.EnableToolTips = true;
			buttonNibbleSwapA2.ToolTipValues.Heading = "Nibble swap of A2";
			buttonNibbleSwapA2.Values.DropDownArrowColor = Color.Empty;
			buttonNibbleSwapA2.Values.Text = "NBLSWP A2";
			buttonNibbleSwapA2.Click += ButtonNibbleSwapA2_Click;
			buttonNibbleSwapA2.Enter += Control_Enter;
			buttonNibbleSwapA2.Leave += Control_Leave;
			buttonNibbleSwapA2.MouseEnter += Control_Enter;
			buttonNibbleSwapA2.MouseLeave += Control_Leave;
			// 
			// buttonFormingTwosComponentA1
			// 
			buttonFormingTwosComponentA1.AccessibleDescription = "Forming the two's complement of A1";
			buttonFormingTwosComponentA1.AccessibleName = "Two's complement of A1";
			buttonFormingTwosComponentA1.AccessibleRole = AccessibleRole.PushButton;
			buttonFormingTwosComponentA1.Enabled = false;
			buttonFormingTwosComponentA1.Location = new Point(106, 325);
			buttonFormingTwosComponentA1.Name = "buttonFormingTwosComponentA1";
			buttonFormingTwosComponentA1.Size = new Size(91, 27);
			buttonFormingTwosComponentA1.TabIndex = 111;
			buttonFormingTwosComponentA1.ToolTipValues.Description = "Forming the two's complement of A1";
			buttonFormingTwosComponentA1.ToolTipValues.EnableToolTips = true;
			buttonFormingTwosComponentA1.ToolTipValues.Heading = "Two's complement of A1";
			buttonFormingTwosComponentA1.Values.DropDownArrowColor = Color.Empty;
			buttonFormingTwosComponentA1.Values.Text = "TC A1";
			buttonFormingTwosComponentA1.Click += ButtonFormingTwosComponentA1_Click;
			buttonFormingTwosComponentA1.Enter += Control_Enter;
			buttonFormingTwosComponentA1.Leave += Control_Leave;
			buttonFormingTwosComponentA1.MouseEnter += Control_Enter;
			buttonFormingTwosComponentA1.MouseLeave += Control_Leave;
			// 
			// buttonHalfSwapA2
			// 
			buttonHalfSwapA2.AccessibleDescription = "Swaps two data halves of A2";
			buttonHalfSwapA2.AccessibleName = "Data half swap of A2";
			buttonHalfSwapA2.AccessibleRole = AccessibleRole.PushButton;
			buttonHalfSwapA2.Location = new Point(204, 24);
			buttonHalfSwapA2.Name = "buttonHalfSwapA2";
			buttonHalfSwapA2.Size = new Size(91, 27);
			buttonHalfSwapA2.TabIndex = 110;
			buttonHalfSwapA2.ToolTipValues.Description = "Swaps two data halves of A2";
			buttonHalfSwapA2.ToolTipValues.EnableToolTips = true;
			buttonHalfSwapA2.ToolTipValues.Heading = "Data half swap of A2";
			buttonHalfSwapA2.Values.DropDownArrowColor = Color.Empty;
			buttonHalfSwapA2.Values.Text = "HLFSWP A2";
			buttonHalfSwapA2.Click += ButtonHalfSwapA2_Click;
			buttonHalfSwapA2.Enter += Control_Enter;
			buttonHalfSwapA2.Leave += Control_Leave;
			buttonHalfSwapA2.MouseEnter += Control_Enter;
			buttonHalfSwapA2.MouseLeave += Control_Leave;
			// 
			// buttonSubjunctionA2A1
			// 
			buttonSubjunctionA2A1.AccessibleDescription = "Calculates the subjunction of A2 and A1";
			buttonSubjunctionA2A1.AccessibleName = "Subjunction of A2 and A1";
			buttonSubjunctionA2A1.AccessibleRole = AccessibleRole.PushButton;
			buttonSubjunctionA2A1.Location = new Point(7, 458);
			buttonSubjunctionA2A1.Name = "buttonSubjunctionA2A1";
			buttonSubjunctionA2A1.Size = new Size(91, 27);
			buttonSubjunctionA2A1.TabIndex = 108;
			buttonSubjunctionA2A1.ToolTipValues.Description = "Calculates the subjunction of A2 and A1";
			buttonSubjunctionA2A1.ToolTipValues.EnableToolTips = true;
			buttonSubjunctionA2A1.ToolTipValues.Heading = "Subjunction of A2 and A1";
			buttonSubjunctionA2A1.Values.DropDownArrowColor = Color.Empty;
			buttonSubjunctionA2A1.Values.Text = "A2 SUBJ A1";
			buttonSubjunctionA2A1.Click += ButtonSubjunctionA2A1_Click;
			buttonSubjunctionA2A1.Enter += Control_Enter;
			buttonSubjunctionA2A1.Leave += Control_Leave;
			buttonSubjunctionA2A1.MouseEnter += Control_Enter;
			buttonSubjunctionA2A1.MouseLeave += Control_Leave;
			// 
			// buttonHalfSwapA1
			// 
			buttonHalfSwapA1.AccessibleDescription = "Swaps two data halves of A1";
			buttonHalfSwapA1.AccessibleName = "Data half swap of A1";
			buttonHalfSwapA1.AccessibleRole = AccessibleRole.PushButton;
			buttonHalfSwapA1.Location = new Point(106, 24);
			buttonHalfSwapA1.Name = "buttonHalfSwapA1";
			buttonHalfSwapA1.Size = new Size(91, 27);
			buttonHalfSwapA1.TabIndex = 109;
			buttonHalfSwapA1.ToolTipValues.Description = "Swaps two data halves of A1";
			buttonHalfSwapA1.ToolTipValues.EnableToolTips = true;
			buttonHalfSwapA1.ToolTipValues.Heading = "Data half swap of A1";
			buttonHalfSwapA1.Values.DropDownArrowColor = Color.Empty;
			buttonHalfSwapA1.Values.Text = "HLFSWP A1";
			buttonHalfSwapA1.Click += ButtonHalfSwapA1_Click;
			buttonHalfSwapA1.Enter += Control_Enter;
			buttonHalfSwapA1.Leave += Control_Leave;
			buttonHalfSwapA1.MouseEnter += Control_Enter;
			buttonHalfSwapA1.MouseLeave += Control_Leave;
			// 
			// buttonSubjunctionA1A2
			// 
			buttonSubjunctionA1A2.AccessibleDescription = "Calculates the subjunction of A1 and A2";
			buttonSubjunctionA1A2.AccessibleName = "Subjunction of A1 and A2";
			buttonSubjunctionA1A2.AccessibleRole = AccessibleRole.PushButton;
			buttonSubjunctionA1A2.Location = new Point(7, 425);
			buttonSubjunctionA1A2.Name = "buttonSubjunctionA1A2";
			buttonSubjunctionA1A2.Size = new Size(91, 27);
			buttonSubjunctionA1A2.TabIndex = 107;
			buttonSubjunctionA1A2.ToolTipValues.Description = "Calculates the subjunction of A1 and A2";
			buttonSubjunctionA1A2.ToolTipValues.EnableToolTips = true;
			buttonSubjunctionA1A2.ToolTipValues.Heading = "Subjunction of A1 and A2";
			buttonSubjunctionA1A2.Values.DropDownArrowColor = Color.Empty;
			buttonSubjunctionA1A2.Values.Text = "A1 SUBJ A2";
			buttonSubjunctionA1A2.Click += ButtonSubjunctionA1A2_Click;
			buttonSubjunctionA1A2.Enter += Control_Enter;
			buttonSubjunctionA1A2.Leave += Control_Leave;
			buttonSubjunctionA1A2.MouseEnter += Control_Enter;
			buttonSubjunctionA1A2.MouseLeave += Control_Leave;
			// 
			// buttonNibbleSwapA1
			// 
			buttonNibbleSwapA1.AccessibleDescription = "Swaps two nibbles of A1";
			buttonNibbleSwapA1.AccessibleName = "Nibble swap of A1";
			buttonNibbleSwapA1.AccessibleRole = AccessibleRole.PushButton;
			buttonNibbleSwapA1.Location = new Point(106, 58);
			buttonNibbleSwapA1.Name = "buttonNibbleSwapA1";
			buttonNibbleSwapA1.Size = new Size(91, 27);
			buttonNibbleSwapA1.TabIndex = 122;
			buttonNibbleSwapA1.ToolTipValues.Description = "Swaps two nibbles of A1";
			buttonNibbleSwapA1.ToolTipValues.EnableToolTips = true;
			buttonNibbleSwapA1.ToolTipValues.Heading = "Nibble swap of A1";
			buttonNibbleSwapA1.Values.DropDownArrowColor = Color.Empty;
			buttonNibbleSwapA1.Values.Text = "NBLSWP A1";
			buttonNibbleSwapA1.Click += ButtonNibbleSwapA1_Click;
			buttonNibbleSwapA1.Enter += Control_Enter;
			buttonNibbleSwapA1.Leave += Control_Leave;
			buttonNibbleSwapA1.MouseEnter += Control_Enter;
			buttonNibbleSwapA1.MouseLeave += Control_Leave;
			// 
			// buttonInhibitionA2A1
			// 
			buttonInhibitionA2A1.AccessibleDescription = "Calculates the inhibition of A2 and A1";
			buttonInhibitionA2A1.AccessibleName = "Inhibition of A2 and A1";
			buttonInhibitionA2A1.AccessibleRole = AccessibleRole.PushButton;
			buttonInhibitionA2A1.Location = new Point(7, 391);
			buttonInhibitionA2A1.Name = "buttonInhibitionA2A1";
			buttonInhibitionA2A1.Size = new Size(91, 27);
			buttonInhibitionA2A1.TabIndex = 106;
			buttonInhibitionA2A1.ToolTipValues.Description = "Calculates the inhibition of A2 and A1";
			buttonInhibitionA2A1.ToolTipValues.EnableToolTips = true;
			buttonInhibitionA2A1.ToolTipValues.Heading = "Inhibition of A2 and A1";
			buttonInhibitionA2A1.Values.DropDownArrowColor = Color.Empty;
			buttonInhibitionA2A1.Values.Text = "A2 INHB A1";
			buttonInhibitionA2A1.Click += ButtonInhibitionA2A1_Click;
			buttonInhibitionA2A1.Enter += Control_Enter;
			buttonInhibitionA2A1.Leave += Control_Leave;
			buttonInhibitionA2A1.MouseEnter += Control_Enter;
			buttonInhibitionA2A1.MouseLeave += Control_Leave;
			// 
			// buttonArithmeticShiftRightWithOneA2
			// 
			buttonArithmeticShiftRightWithOneA2.AccessibleDescription = "Shifts the value of A2 arithmetically to the right with ones";
			buttonArithmeticShiftRightWithOneA2.AccessibleName = "Arithmetic right-shifting of A2 with ones";
			buttonArithmeticShiftRightWithOneA2.AccessibleRole = AccessibleRole.PushButton;
			buttonArithmeticShiftRightWithOneA2.Location = new Point(401, 325);
			buttonArithmeticShiftRightWithOneA2.Name = "buttonArithmeticShiftRightWithOneA2";
			buttonArithmeticShiftRightWithOneA2.Size = new Size(91, 27);
			buttonArithmeticShiftRightWithOneA2.TabIndex = 121;
			buttonArithmeticShiftRightWithOneA2.ToolTipValues.Description = "Shifts the value of A2 arithmetically to the right with ones";
			buttonArithmeticShiftRightWithOneA2.ToolTipValues.EnableToolTips = true;
			buttonArithmeticShiftRightWithOneA2.ToolTipValues.Heading = "Arithmetic right-shifting of A2 with ones";
			buttonArithmeticShiftRightWithOneA2.Values.DropDownArrowColor = Color.Empty;
			buttonArithmeticShiftRightWithOneA2.Values.Text = "ASHR1 A2";
			buttonArithmeticShiftRightWithOneA2.Click += ButtonArithmeticShiftRightWithOneA2_Click;
			buttonArithmeticShiftRightWithOneA2.Enter += Control_Enter;
			buttonArithmeticShiftRightWithOneA2.Leave += Control_Leave;
			buttonArithmeticShiftRightWithOneA2.MouseEnter += Control_Enter;
			buttonArithmeticShiftRightWithOneA2.MouseLeave += Control_Leave;
			// 
			// buttonInhibitionA1A2
			// 
			buttonInhibitionA1A2.AccessibleDescription = "Calculates the inhibition of A1 and A2";
			buttonInhibitionA1A2.AccessibleName = "Inhibition of A1 and A2";
			buttonInhibitionA1A2.AccessibleRole = AccessibleRole.PushButton;
			buttonInhibitionA1A2.Location = new Point(7, 358);
			buttonInhibitionA1A2.Name = "buttonInhibitionA1A2";
			buttonInhibitionA1A2.Size = new Size(91, 27);
			buttonInhibitionA1A2.TabIndex = 105;
			buttonInhibitionA1A2.ToolTipValues.Description = "Calculates the inhibition of A1 and A2";
			buttonInhibitionA1A2.ToolTipValues.EnableToolTips = true;
			buttonInhibitionA1A2.ToolTipValues.Heading = "Inhibition of A1 and A2";
			buttonInhibitionA1A2.Values.DropDownArrowColor = Color.Empty;
			buttonInhibitionA1A2.Values.Text = "A1 INHB A2";
			buttonInhibitionA1A2.Click += ButtonInhibitionA1A2_Click;
			buttonInhibitionA1A2.Enter += Control_Enter;
			buttonInhibitionA1A2.Leave += Control_Leave;
			buttonInhibitionA1A2.MouseEnter += Control_Enter;
			buttonInhibitionA1A2.MouseLeave += Control_Leave;
			// 
			// buttonRandomizeA2
			// 
			buttonRandomizeA2.AccessibleDescription = "Randomize the value of A1";
			buttonRandomizeA2.AccessibleName = "A1 randomization";
			buttonRandomizeA2.AccessibleRole = AccessibleRole.PushButton;
			buttonRandomizeA2.Location = new Point(204, 292);
			buttonRandomizeA2.Name = "buttonRandomizeA2";
			buttonRandomizeA2.Size = new Size(91, 27);
			buttonRandomizeA2.TabIndex = 104;
			buttonRandomizeA2.ToolTipValues.Description = "Randomize the value of A1";
			buttonRandomizeA2.ToolTipValues.EnableToolTips = true;
			buttonRandomizeA2.ToolTipValues.Heading = "A2 randomization";
			buttonRandomizeA2.Values.DropDownArrowColor = Color.Empty;
			buttonRandomizeA2.Values.Text = "RND A2";
			buttonRandomizeA2.Click += ButtonRandomizeA2_Click;
			buttonRandomizeA2.Enter += Control_Enter;
			buttonRandomizeA2.Leave += Control_Leave;
			buttonRandomizeA2.MouseEnter += Control_Enter;
			buttonRandomizeA2.MouseLeave += Control_Leave;
			// 
			// buttonArithmeticShiftRightWithOneA1
			// 
			buttonArithmeticShiftRightWithOneA1.AccessibleDescription = "Shifts the value of A1 arithmetically to the right with ones";
			buttonArithmeticShiftRightWithOneA1.AccessibleName = "Arithmetic right-shifting of A1 with ones";
			buttonArithmeticShiftRightWithOneA1.AccessibleRole = AccessibleRole.PushButton;
			buttonArithmeticShiftRightWithOneA1.Location = new Point(303, 325);
			buttonArithmeticShiftRightWithOneA1.Name = "buttonArithmeticShiftRightWithOneA1";
			buttonArithmeticShiftRightWithOneA1.Size = new Size(91, 27);
			buttonArithmeticShiftRightWithOneA1.TabIndex = 120;
			buttonArithmeticShiftRightWithOneA1.ToolTipValues.Description = "Shifts the value of A1 arithmetically to the right with ones";
			buttonArithmeticShiftRightWithOneA1.ToolTipValues.EnableToolTips = true;
			buttonArithmeticShiftRightWithOneA1.ToolTipValues.Heading = "Arithmetic right-shifting of A1 with ones";
			buttonArithmeticShiftRightWithOneA1.Values.DropDownArrowColor = Color.Empty;
			buttonArithmeticShiftRightWithOneA1.Values.Text = "ASHR1 A1";
			buttonArithmeticShiftRightWithOneA1.Click += ButtonArithmeticShiftRightWithOneA1_Click;
			buttonArithmeticShiftRightWithOneA1.Enter += Control_Enter;
			buttonArithmeticShiftRightWithOneA1.Leave += Control_Leave;
			buttonArithmeticShiftRightWithOneA1.MouseEnter += Control_Enter;
			buttonArithmeticShiftRightWithOneA1.MouseLeave += Control_Leave;
			// 
			// buttonRandomizeA1
			// 
			buttonRandomizeA1.AccessibleDescription = "Randomize the value of A1";
			buttonRandomizeA1.AccessibleName = "A1 randomization";
			buttonRandomizeA1.AccessibleRole = AccessibleRole.PushButton;
			buttonRandomizeA1.Location = new Point(106, 292);
			buttonRandomizeA1.Name = "buttonRandomizeA1";
			buttonRandomizeA1.Size = new Size(91, 27);
			buttonRandomizeA1.TabIndex = 102;
			buttonRandomizeA1.ToolTipValues.Description = "Randomize the value of A1";
			buttonRandomizeA1.ToolTipValues.EnableToolTips = true;
			buttonRandomizeA1.ToolTipValues.Heading = "A1 randomization";
			buttonRandomizeA1.Values.DropDownArrowColor = Color.Empty;
			buttonRandomizeA1.Values.Text = "RND A1";
			buttonRandomizeA1.Click += ButtonRandomizeA1_Click;
			buttonRandomizeA1.Enter += Control_Enter;
			buttonRandomizeA1.Leave += Control_Leave;
			buttonRandomizeA1.MouseEnter += Control_Enter;
			buttonRandomizeA1.MouseLeave += Control_Leave;
			// 
			// buttonShiftRightWithOneA2
			// 
			buttonShiftRightWithOneA2.AccessibleDescription = "Shifts the value of A2 to the right with ones";
			buttonShiftRightWithOneA2.AccessibleName = "Right-shifting of A2 with ones";
			buttonShiftRightWithOneA2.AccessibleRole = AccessibleRole.PushButton;
			buttonShiftRightWithOneA2.Location = new Point(401, 125);
			buttonShiftRightWithOneA2.Name = "buttonShiftRightWithOneA2";
			buttonShiftRightWithOneA2.Size = new Size(91, 27);
			buttonShiftRightWithOneA2.TabIndex = 101;
			buttonShiftRightWithOneA2.ToolTipValues.Description = "Shifts the value of A2 to the right with ones";
			buttonShiftRightWithOneA2.ToolTipValues.EnableToolTips = true;
			buttonShiftRightWithOneA2.ToolTipValues.Heading = "Right-shifting of A2 with ones";
			buttonShiftRightWithOneA2.Values.DropDownArrowColor = Color.Empty;
			buttonShiftRightWithOneA2.Values.Text = "SHR1 A2";
			buttonShiftRightWithOneA2.Click += ButtonShiftRightWithOneA2_Click;
			buttonShiftRightWithOneA2.Enter += Control_Enter;
			buttonShiftRightWithOneA2.Leave += Control_Leave;
			buttonShiftRightWithOneA2.MouseEnter += Control_Enter;
			buttonShiftRightWithOneA2.MouseLeave += Control_Leave;
			// 
			// buttonArithmeticShiftLeftWithOneA2
			// 
			buttonArithmeticShiftLeftWithOneA2.AccessibleDescription = "Shifts the value of A2 arithmetically to the left with ones";
			buttonArithmeticShiftLeftWithOneA2.AccessibleName = "Arithmetic left-shifting of A2 with ones";
			buttonArithmeticShiftLeftWithOneA2.AccessibleRole = AccessibleRole.PushButton;
			buttonArithmeticShiftLeftWithOneA2.Location = new Point(401, 259);
			buttonArithmeticShiftLeftWithOneA2.Name = "buttonArithmeticShiftLeftWithOneA2";
			buttonArithmeticShiftLeftWithOneA2.Size = new Size(91, 27);
			buttonArithmeticShiftLeftWithOneA2.TabIndex = 119;
			buttonArithmeticShiftLeftWithOneA2.ToolTipValues.Description = "Shifts the value of A2 arithmetically to the left with ones";
			buttonArithmeticShiftLeftWithOneA2.ToolTipValues.EnableToolTips = true;
			buttonArithmeticShiftLeftWithOneA2.ToolTipValues.Heading = "Arithmetic left-shifting of A2 with ones";
			buttonArithmeticShiftLeftWithOneA2.Values.DropDownArrowColor = Color.Empty;
			buttonArithmeticShiftLeftWithOneA2.Values.Text = "ASHL1 A2";
			buttonArithmeticShiftLeftWithOneA2.Click += ButtonArithmeticShiftLeftWithOneA2_Click;
			buttonArithmeticShiftLeftWithOneA2.Enter += Control_Enter;
			buttonArithmeticShiftLeftWithOneA2.Leave += Control_Leave;
			buttonArithmeticShiftLeftWithOneA2.MouseEnter += Control_Enter;
			buttonArithmeticShiftLeftWithOneA2.MouseLeave += Control_Leave;
			// 
			// buttonShiftRightWithOneA1
			// 
			buttonShiftRightWithOneA1.AccessibleDescription = "Shifts the value of A1 to the right with ones";
			buttonShiftRightWithOneA1.AccessibleName = "Right-shifting of A1 with ones";
			buttonShiftRightWithOneA1.AccessibleRole = AccessibleRole.PushButton;
			buttonShiftRightWithOneA1.Location = new Point(303, 125);
			buttonShiftRightWithOneA1.Name = "buttonShiftRightWithOneA1";
			buttonShiftRightWithOneA1.Size = new Size(91, 27);
			buttonShiftRightWithOneA1.TabIndex = 100;
			buttonShiftRightWithOneA1.ToolTipValues.Description = "Shifts the value of A1 to the right with ones";
			buttonShiftRightWithOneA1.ToolTipValues.EnableToolTips = true;
			buttonShiftRightWithOneA1.ToolTipValues.Heading = "Right-shifting of A1 with ones";
			buttonShiftRightWithOneA1.Values.DropDownArrowColor = Color.Empty;
			buttonShiftRightWithOneA1.Values.Text = "SHR1 A1";
			buttonShiftRightWithOneA1.Click += ButtonShiftRightWithOneA1_Click;
			buttonShiftRightWithOneA1.Enter += Control_Enter;
			buttonShiftRightWithOneA1.Leave += Control_Leave;
			buttonShiftRightWithOneA1.MouseEnter += Control_Enter;
			buttonShiftRightWithOneA1.MouseLeave += Control_Leave;
			// 
			// buttonShiftLeftWithOneA2
			// 
			buttonShiftLeftWithOneA2.AccessibleDescription = "Shifts the value of A2 to the left with ones";
			buttonShiftLeftWithOneA2.AccessibleName = "Left-shifting of A2 with ones";
			buttonShiftLeftWithOneA2.AccessibleRole = AccessibleRole.PushButton;
			buttonShiftLeftWithOneA2.Location = new Point(401, 58);
			buttonShiftLeftWithOneA2.Name = "buttonShiftLeftWithOneA2";
			buttonShiftLeftWithOneA2.Size = new Size(91, 27);
			buttonShiftLeftWithOneA2.TabIndex = 99;
			buttonShiftLeftWithOneA2.ToolTipValues.Description = "Shifts the value of A2 to the left with ones";
			buttonShiftLeftWithOneA2.ToolTipValues.EnableToolTips = true;
			buttonShiftLeftWithOneA2.ToolTipValues.Heading = "Left-shifting of A2 with ones";
			buttonShiftLeftWithOneA2.Values.DropDownArrowColor = Color.Empty;
			buttonShiftLeftWithOneA2.Values.Text = "SHL1 A2";
			buttonShiftLeftWithOneA2.Click += ButtonShiftLeftWithOneA2_Click;
			buttonShiftLeftWithOneA2.Enter += Control_Enter;
			buttonShiftLeftWithOneA2.Leave += Control_Leave;
			buttonShiftLeftWithOneA2.MouseEnter += Control_Enter;
			buttonShiftLeftWithOneA2.MouseLeave += Control_Leave;
			// 
			// buttonArithmeticShiftLeftWithOneA1
			// 
			buttonArithmeticShiftLeftWithOneA1.AccessibleDescription = "Shifts the value of A1 arithmetically to the left with ones";
			buttonArithmeticShiftLeftWithOneA1.AccessibleName = "Arithmetic left-shifting of A1 with ones";
			buttonArithmeticShiftLeftWithOneA1.AccessibleRole = AccessibleRole.PushButton;
			buttonArithmeticShiftLeftWithOneA1.Location = new Point(303, 259);
			buttonArithmeticShiftLeftWithOneA1.Name = "buttonArithmeticShiftLeftWithOneA1";
			buttonArithmeticShiftLeftWithOneA1.Size = new Size(91, 27);
			buttonArithmeticShiftLeftWithOneA1.TabIndex = 118;
			buttonArithmeticShiftLeftWithOneA1.ToolTipValues.Description = "Shifts the value of A1 arithmetically to the left with ones";
			buttonArithmeticShiftLeftWithOneA1.ToolTipValues.EnableToolTips = true;
			buttonArithmeticShiftLeftWithOneA1.ToolTipValues.Heading = "Arithmetic left-shifting of A1 with ones";
			buttonArithmeticShiftLeftWithOneA1.Values.DropDownArrowColor = Color.Empty;
			buttonArithmeticShiftLeftWithOneA1.Values.Text = "ASHL1 A1";
			buttonArithmeticShiftLeftWithOneA1.Click += ButtonArithmeticShiftLeftWithOneA1_Click;
			buttonArithmeticShiftLeftWithOneA1.Enter += Control_Enter;
			buttonArithmeticShiftLeftWithOneA1.Leave += Control_Leave;
			buttonArithmeticShiftLeftWithOneA1.MouseEnter += Control_Enter;
			buttonArithmeticShiftLeftWithOneA1.MouseLeave += Control_Leave;
			// 
			// buttonShiftLeftWithOneA1
			// 
			buttonShiftLeftWithOneA1.AccessibleDescription = "Shifts the value of A1 to the left with ones";
			buttonShiftLeftWithOneA1.AccessibleName = "Left-shifting of A1 with ones";
			buttonShiftLeftWithOneA1.AccessibleRole = AccessibleRole.PushButton;
			buttonShiftLeftWithOneA1.Location = new Point(303, 58);
			buttonShiftLeftWithOneA1.Name = "buttonShiftLeftWithOneA1";
			buttonShiftLeftWithOneA1.Size = new Size(91, 27);
			buttonShiftLeftWithOneA1.TabIndex = 98;
			buttonShiftLeftWithOneA1.ToolTipValues.Description = "Shifts the value of A1 to the left with ones";
			buttonShiftLeftWithOneA1.ToolTipValues.EnableToolTips = true;
			buttonShiftLeftWithOneA1.ToolTipValues.Heading = "Left-shifting of A1 with ones";
			buttonShiftLeftWithOneA1.Values.DropDownArrowColor = Color.Empty;
			buttonShiftLeftWithOneA1.Values.Text = "SHL1 A1";
			buttonShiftLeftWithOneA1.Click += ButtonShiftLeftWithOneA1_Click;
			buttonShiftLeftWithOneA1.Enter += Control_Enter;
			buttonShiftLeftWithOneA1.Leave += Control_Leave;
			buttonShiftLeftWithOneA1.MouseEnter += Control_Enter;
			buttonShiftLeftWithOneA1.MouseLeave += Control_Leave;
			// 
			// buttonSwapA1A2
			// 
			buttonSwapA1A2.AccessibleDescription = "Swaps the value of A1 and A2";
			buttonSwapA1A2.AccessibleName = "Swap of A1 and A2";
			buttonSwapA1A2.AccessibleRole = AccessibleRole.PushButton;
			buttonSwapA1A2.Location = new Point(106, 358);
			buttonSwapA1A2.Name = "buttonSwapA1A2";
			buttonSwapA1A2.Size = new Size(91, 27);
			buttonSwapA1A2.TabIndex = 97;
			buttonSwapA1A2.ToolTipValues.Description = "Swaps the value of A1 and A2";
			buttonSwapA1A2.ToolTipValues.EnableToolTips = true;
			buttonSwapA1A2.ToolTipValues.Heading = "Swap of A1 and A2";
			buttonSwapA1A2.Values.DropDownArrowColor = Color.Empty;
			buttonSwapA1A2.Values.Text = "A1 <> A2";
			buttonSwapA1A2.Click += ButtonSwapA1A2_Click;
			buttonSwapA1A2.Enter += Control_Enter;
			buttonSwapA1A2.Leave += Control_Leave;
			buttonSwapA1A2.MouseEnter += Control_Enter;
			buttonSwapA1A2.MouseLeave += Control_Leave;
			// 
			// buttonArithmeticShiftLeftWithZeroA2
			// 
			buttonArithmeticShiftLeftWithZeroA2.AccessibleDescription = "Shifts the value of A2 arithmetically to the left with zeros";
			buttonArithmeticShiftLeftWithZeroA2.AccessibleName = "Arithemtic left-shifting of A2 with zeros";
			buttonArithmeticShiftLeftWithZeroA2.AccessibleRole = AccessibleRole.PushButton;
			buttonArithmeticShiftLeftWithZeroA2.Location = new Point(401, 225);
			buttonArithmeticShiftLeftWithZeroA2.Name = "buttonArithmeticShiftLeftWithZeroA2";
			buttonArithmeticShiftLeftWithZeroA2.Size = new Size(91, 27);
			buttonArithmeticShiftLeftWithZeroA2.TabIndex = 116;
			buttonArithmeticShiftLeftWithZeroA2.ToolTipValues.Description = "Shifts the value of A2 arithmetically to the left with zeros";
			buttonArithmeticShiftLeftWithZeroA2.ToolTipValues.EnableToolTips = true;
			buttonArithmeticShiftLeftWithZeroA2.ToolTipValues.Heading = "Arithemtic left-shifting of A2 with zeros";
			buttonArithmeticShiftLeftWithZeroA2.Values.DropDownArrowColor = Color.Empty;
			buttonArithmeticShiftLeftWithZeroA2.Values.Text = "ASHL0 A2";
			buttonArithmeticShiftLeftWithZeroA2.Click += ButtonArithmeticShiftLeftWithZeroA2_Click;
			buttonArithmeticShiftLeftWithZeroA2.Enter += Control_Enter;
			buttonArithmeticShiftLeftWithZeroA2.Leave += Control_Leave;
			buttonArithmeticShiftLeftWithZeroA2.MouseEnter += Control_Enter;
			buttonArithmeticShiftLeftWithZeroA2.MouseLeave += Control_Leave;
			// 
			// buttonFillA2
			// 
			buttonFillA2.AccessibleDescription = "Sets all bit of A2 to one";
			buttonFillA2.AccessibleName = "Filling of A2";
			buttonFillA2.AccessibleRole = AccessibleRole.PushButton;
			buttonFillA2.Location = new Point(204, 225);
			buttonFillA2.Name = "buttonFillA2";
			buttonFillA2.Size = new Size(91, 27);
			buttonFillA2.TabIndex = 96;
			buttonFillA2.ToolTipValues.Description = "Sets all bit of A2 to one";
			buttonFillA2.ToolTipValues.EnableToolTips = true;
			buttonFillA2.ToolTipValues.Heading = "Filling of A2";
			buttonFillA2.Values.DropDownArrowColor = Color.Empty;
			buttonFillA2.Values.Text = "A2 = 1";
			buttonFillA2.Click += ButtonFillA2_Click;
			buttonFillA2.Enter += Control_Enter;
			buttonFillA2.Leave += Control_Leave;
			buttonFillA2.MouseEnter += Control_Enter;
			buttonFillA2.MouseLeave += Control_Leave;
			// 
			// buttonFillA1
			// 
			buttonFillA1.AccessibleDescription = "Sets all bit of A1 to one";
			buttonFillA1.AccessibleName = "Filling of A1";
			buttonFillA1.AccessibleRole = AccessibleRole.PushButton;
			buttonFillA1.Location = new Point(106, 225);
			buttonFillA1.Name = "buttonFillA1";
			buttonFillA1.Size = new Size(91, 27);
			buttonFillA1.TabIndex = 95;
			buttonFillA1.ToolTipValues.Description = "Sets all bit of A1 to one";
			buttonFillA1.ToolTipValues.EnableToolTips = true;
			buttonFillA1.ToolTipValues.Heading = "Filling of A1";
			buttonFillA1.Values.DropDownArrowColor = Color.Empty;
			buttonFillA1.Values.Text = "A1 = 1";
			buttonFillA1.Click += ButtonFillA1_Click;
			buttonFillA1.Enter += Control_Enter;
			buttonFillA1.Leave += Control_Leave;
			buttonFillA1.MouseEnter += Control_Enter;
			buttonFillA1.MouseLeave += Control_Leave;
			// 
			// buttonArithmeticShiftRightWithZeroA2
			// 
			buttonArithmeticShiftRightWithZeroA2.AccessibleDescription = "Shifts the value of A2 arithmetically to the right with zeros";
			buttonArithmeticShiftRightWithZeroA2.AccessibleName = "Arithmetic right-shifting of A2 with zeros";
			buttonArithmeticShiftRightWithZeroA2.AccessibleRole = AccessibleRole.PushButton;
			buttonArithmeticShiftRightWithZeroA2.Location = new Point(401, 292);
			buttonArithmeticShiftRightWithZeroA2.Name = "buttonArithmeticShiftRightWithZeroA2";
			buttonArithmeticShiftRightWithZeroA2.Size = new Size(91, 27);
			buttonArithmeticShiftRightWithZeroA2.TabIndex = 117;
			buttonArithmeticShiftRightWithZeroA2.ToolTipValues.Description = "Shifts the value of A2 arithmetically to the right with zeros";
			buttonArithmeticShiftRightWithZeroA2.ToolTipValues.EnableToolTips = true;
			buttonArithmeticShiftRightWithZeroA2.ToolTipValues.Heading = "Arithmetic right-shifting of A2 with zeros";
			buttonArithmeticShiftRightWithZeroA2.Values.DropDownArrowColor = Color.Empty;
			buttonArithmeticShiftRightWithZeroA2.Values.Text = "ASHR0 A2";
			buttonArithmeticShiftRightWithZeroA2.Click += ButtonArithmeticShiftRightWithZeroA2_Click;
			buttonArithmeticShiftRightWithZeroA2.Enter += Control_Enter;
			buttonArithmeticShiftRightWithZeroA2.Leave += Control_Leave;
			buttonArithmeticShiftRightWithZeroA2.MouseEnter += Control_Enter;
			buttonArithmeticShiftRightWithZeroA2.MouseLeave += Control_Leave;
			// 
			// buttonClearA2
			// 
			buttonClearA2.AccessibleDescription = "Sets all bit of A2 to zero";
			buttonClearA2.AccessibleName = "Clearing of A2";
			buttonClearA2.AccessibleRole = AccessibleRole.PushButton;
			buttonClearA2.Location = new Point(204, 192);
			buttonClearA2.Name = "buttonClearA2";
			buttonClearA2.Size = new Size(91, 27);
			buttonClearA2.TabIndex = 94;
			buttonClearA2.ToolTipValues.Description = "Sets all bit of A2 to zero";
			buttonClearA2.ToolTipValues.EnableToolTips = true;
			buttonClearA2.ToolTipValues.Heading = "Clearing of A2";
			buttonClearA2.Values.DropDownArrowColor = Color.Empty;
			buttonClearA2.Values.Text = "A2 = 0";
			buttonClearA2.Click += ButtonClearA2_Click;
			buttonClearA2.Enter += Control_Enter;
			buttonClearA2.Leave += Control_Leave;
			buttonClearA2.MouseEnter += Control_Enter;
			buttonClearA2.MouseLeave += Control_Leave;
			// 
			// buttonClearA1
			// 
			buttonClearA1.AccessibleDescription = "Sets all bit of A1 to zero";
			buttonClearA1.AccessibleName = "Clearing of A1";
			buttonClearA1.AccessibleRole = AccessibleRole.PushButton;
			buttonClearA1.Location = new Point(106, 192);
			buttonClearA1.Name = "buttonClearA1";
			buttonClearA1.Size = new Size(91, 27);
			buttonClearA1.TabIndex = 93;
			buttonClearA1.ToolTipValues.Description = "Sets all bit of A1 to zero";
			buttonClearA1.ToolTipValues.EnableToolTips = true;
			buttonClearA1.ToolTipValues.Heading = "Clearing of A1";
			buttonClearA1.Values.DropDownArrowColor = Color.Empty;
			buttonClearA1.Values.Text = "A1 = 0";
			buttonClearA1.Click += ButtonClearA1_Click;
			buttonClearA1.Enter += Control_Enter;
			buttonClearA1.Leave += Control_Leave;
			buttonClearA1.MouseEnter += Control_Enter;
			buttonClearA1.MouseLeave += Control_Leave;
			// 
			// buttonArithmeticShiftLeftWithZeroA1
			// 
			buttonArithmeticShiftLeftWithZeroA1.AccessibleDescription = "Shifts the value of A1 arithmetically to the left with zeros";
			buttonArithmeticShiftLeftWithZeroA1.AccessibleName = "Arithmetic left-shifting of A1 with zeros";
			buttonArithmeticShiftLeftWithZeroA1.AccessibleRole = AccessibleRole.PushButton;
			buttonArithmeticShiftLeftWithZeroA1.Location = new Point(303, 225);
			buttonArithmeticShiftLeftWithZeroA1.Name = "buttonArithmeticShiftLeftWithZeroA1";
			buttonArithmeticShiftLeftWithZeroA1.Size = new Size(91, 27);
			buttonArithmeticShiftLeftWithZeroA1.TabIndex = 114;
			buttonArithmeticShiftLeftWithZeroA1.ToolTipValues.Description = "Shifts the value of A1 arithmetically to the left with zeros";
			buttonArithmeticShiftLeftWithZeroA1.ToolTipValues.EnableToolTips = true;
			buttonArithmeticShiftLeftWithZeroA1.ToolTipValues.Heading = "Arithmetic left-shifting of A1 with zeros";
			buttonArithmeticShiftLeftWithZeroA1.Values.DropDownArrowColor = Color.Empty;
			buttonArithmeticShiftLeftWithZeroA1.Values.Text = "ASHL0 A1";
			buttonArithmeticShiftLeftWithZeroA1.Click += ButtonArithmeticShiftLeftWithZeroA1_Click;
			buttonArithmeticShiftLeftWithZeroA1.Enter += Control_Enter;
			buttonArithmeticShiftLeftWithZeroA1.Leave += Control_Leave;
			buttonArithmeticShiftLeftWithZeroA1.MouseEnter += Control_Enter;
			buttonArithmeticShiftLeftWithZeroA1.MouseLeave += Control_Leave;
			// 
			// buttonArithmeticShiftRightWithZeroA1
			// 
			buttonArithmeticShiftRightWithZeroA1.AccessibleDescription = "Shifts the value of A1 arithmetically to the right with zeros";
			buttonArithmeticShiftRightWithZeroA1.AccessibleName = "Arithmetic right-shifting of A1 with zeros";
			buttonArithmeticShiftRightWithZeroA1.AccessibleRole = AccessibleRole.PushButton;
			buttonArithmeticShiftRightWithZeroA1.Location = new Point(303, 292);
			buttonArithmeticShiftRightWithZeroA1.Name = "buttonArithmeticShiftRightWithZeroA1";
			buttonArithmeticShiftRightWithZeroA1.Size = new Size(91, 27);
			buttonArithmeticShiftRightWithZeroA1.TabIndex = 115;
			buttonArithmeticShiftRightWithZeroA1.ToolTipValues.Description = "Shifts the value of A1 arithmetically to the right with zeros";
			buttonArithmeticShiftRightWithZeroA1.ToolTipValues.EnableToolTips = true;
			buttonArithmeticShiftRightWithZeroA1.ToolTipValues.Heading = "Arithmetic right-shifting of A1 with zeros";
			buttonArithmeticShiftRightWithZeroA1.Values.DropDownArrowColor = Color.Empty;
			buttonArithmeticShiftRightWithZeroA1.Values.Text = "ASHR0 A1";
			buttonArithmeticShiftRightWithZeroA1.Click += ButtonArithmeticShiftRightWithZeroA1_Click;
			buttonArithmeticShiftRightWithZeroA1.Enter += Control_Enter;
			buttonArithmeticShiftRightWithZeroA1.Leave += Control_Leave;
			buttonArithmeticShiftRightWithZeroA1.MouseEnter += Control_Enter;
			buttonArithmeticShiftRightWithZeroA1.MouseLeave += Control_Leave;
			// 
			// buttonRevertA2
			// 
			buttonRevertA2.AccessibleDescription = "Reverts the bits of A2";
			buttonRevertA2.AccessibleName = "Revertation of A2";
			buttonRevertA2.AccessibleRole = AccessibleRole.PushButton;
			buttonRevertA2.Location = new Point(204, 158);
			buttonRevertA2.Name = "buttonRevertA2";
			buttonRevertA2.Size = new Size(91, 27);
			buttonRevertA2.TabIndex = 92;
			buttonRevertA2.ToolTipValues.Description = "Reverts the bits of A2";
			buttonRevertA2.ToolTipValues.EnableToolTips = true;
			buttonRevertA2.ToolTipValues.Heading = "Revertation of A2";
			buttonRevertA2.Values.DropDownArrowColor = Color.Empty;
			buttonRevertA2.Values.Text = "REV A2";
			buttonRevertA2.Click += ButtonRevertA2_Click;
			buttonRevertA2.Enter += Control_Enter;
			buttonRevertA2.Leave += Control_Leave;
			buttonRevertA2.MouseEnter += Control_Enter;
			buttonRevertA2.MouseLeave += Control_Leave;
			// 
			// buttonRevertA1
			// 
			buttonRevertA1.AccessibleDescription = "Reverts the bits of A1";
			buttonRevertA1.AccessibleName = "Revertation of A1";
			buttonRevertA1.AccessibleRole = AccessibleRole.PushButton;
			buttonRevertA1.Location = new Point(106, 158);
			buttonRevertA1.Name = "buttonRevertA1";
			buttonRevertA1.Size = new Size(91, 27);
			buttonRevertA1.TabIndex = 91;
			buttonRevertA1.ToolTipValues.Description = "Reverts the bits of A1";
			buttonRevertA1.ToolTipValues.EnableToolTips = true;
			buttonRevertA1.ToolTipValues.Heading = "Revertation of A1";
			buttonRevertA1.Values.DropDownArrowColor = Color.Empty;
			buttonRevertA1.Values.Text = "REV A1";
			buttonRevertA1.Click += ButtonRevertA1_Click;
			buttonRevertA1.Enter += Control_Enter;
			buttonRevertA1.Leave += Control_Leave;
			buttonRevertA1.MouseEnter += Control_Enter;
			buttonRevertA1.MouseLeave += Control_Leave;
			// 
			// buttonShiftLeftWithZeroA2
			// 
			buttonShiftLeftWithZeroA2.AccessibleDescription = "Shifts the value of A2 to the left with zeros";
			buttonShiftLeftWithZeroA2.AccessibleName = "Left-shifting of A2 with zeros";
			buttonShiftLeftWithZeroA2.AccessibleRole = AccessibleRole.PushButton;
			buttonShiftLeftWithZeroA2.Location = new Point(401, 24);
			buttonShiftLeftWithZeroA2.Name = "buttonShiftLeftWithZeroA2";
			buttonShiftLeftWithZeroA2.Size = new Size(91, 27);
			buttonShiftLeftWithZeroA2.TabIndex = 87;
			buttonShiftLeftWithZeroA2.ToolTipValues.Description = "Shifts the value of A2 to the left with zeros";
			buttonShiftLeftWithZeroA2.ToolTipValues.EnableToolTips = true;
			buttonShiftLeftWithZeroA2.ToolTipValues.Heading = "Left-shifting of A2 with zeros";
			buttonShiftLeftWithZeroA2.Values.DropDownArrowColor = Color.Empty;
			buttonShiftLeftWithZeroA2.Values.Text = "SHL0 A2";
			buttonShiftLeftWithZeroA2.Click += ButtonShiftLeftWithZeroA2_Click;
			buttonShiftLeftWithZeroA2.Enter += Control_Enter;
			buttonShiftLeftWithZeroA2.Leave += Control_Leave;
			buttonShiftLeftWithZeroA2.MouseEnter += Control_Enter;
			buttonShiftLeftWithZeroA2.MouseLeave += Control_Leave;
			// 
			// buttonShiftRightWithZeroA2
			// 
			buttonShiftRightWithZeroA2.AccessibleDescription = "Shifts the value of A2 to the right with zeros";
			buttonShiftRightWithZeroA2.AccessibleName = "Right-shifting of A2 with zeros";
			buttonShiftRightWithZeroA2.AccessibleRole = AccessibleRole.PushButton;
			buttonShiftRightWithZeroA2.Location = new Point(401, 91);
			buttonShiftRightWithZeroA2.Name = "buttonShiftRightWithZeroA2";
			buttonShiftRightWithZeroA2.Size = new Size(91, 27);
			buttonShiftRightWithZeroA2.TabIndex = 88;
			buttonShiftRightWithZeroA2.ToolTipValues.Description = "Shifts the value of A2 to the right with zeros";
			buttonShiftRightWithZeroA2.ToolTipValues.EnableToolTips = true;
			buttonShiftRightWithZeroA2.ToolTipValues.Heading = "Right-shifting of A2 with zeros";
			buttonShiftRightWithZeroA2.Values.DropDownArrowColor = Color.Empty;
			buttonShiftRightWithZeroA2.Values.Text = "SHR0 A2";
			buttonShiftRightWithZeroA2.Click += ButtonShiftRightWithZeroA2_Click;
			buttonShiftRightWithZeroA2.Enter += Control_Enter;
			buttonShiftRightWithZeroA2.Leave += Control_Leave;
			buttonShiftRightWithZeroA2.MouseEnter += Control_Enter;
			buttonShiftRightWithZeroA2.MouseLeave += Control_Leave;
			// 
			// buttonRotateLeftA2
			// 
			buttonRotateLeftA2.AccessibleDescription = "Rotate the value of A2 to the left";
			buttonRotateLeftA2.AccessibleName = "Left-rotation of A2";
			buttonRotateLeftA2.AccessibleRole = AccessibleRole.PushButton;
			buttonRotateLeftA2.Location = new Point(401, 158);
			buttonRotateLeftA2.Name = "buttonRotateLeftA2";
			buttonRotateLeftA2.Size = new Size(91, 27);
			buttonRotateLeftA2.TabIndex = 89;
			buttonRotateLeftA2.ToolTipValues.Description = "Rotate the value of A2 to the left";
			buttonRotateLeftA2.ToolTipValues.EnableToolTips = true;
			buttonRotateLeftA2.ToolTipValues.Heading = "Left-rotation of A2";
			buttonRotateLeftA2.Values.DropDownArrowColor = Color.Empty;
			buttonRotateLeftA2.Values.Text = "ROL A2";
			buttonRotateLeftA2.Click += ButtonRotateLeftA2_Click;
			buttonRotateLeftA2.Enter += Control_Enter;
			buttonRotateLeftA2.Leave += Control_Leave;
			buttonRotateLeftA2.MouseEnter += Control_Enter;
			buttonRotateLeftA2.MouseLeave += Control_Leave;
			// 
			// buttonRotateRightA2
			// 
			buttonRotateRightA2.AccessibleDescription = "Rotate the value of A2 to the right";
			buttonRotateRightA2.AccessibleName = "Right-rotation of A2";
			buttonRotateRightA2.AccessibleRole = AccessibleRole.PushButton;
			buttonRotateRightA2.Location = new Point(401, 192);
			buttonRotateRightA2.Name = "buttonRotateRightA2";
			buttonRotateRightA2.Size = new Size(91, 27);
			buttonRotateRightA2.TabIndex = 90;
			buttonRotateRightA2.ToolTipValues.Description = "Rotate the value of A2 to the right";
			buttonRotateRightA2.ToolTipValues.EnableToolTips = true;
			buttonRotateRightA2.ToolTipValues.Heading = "Right-rotation of A2";
			buttonRotateRightA2.Values.DropDownArrowColor = Color.Empty;
			buttonRotateRightA2.Values.Text = "ROR A2";
			buttonRotateRightA2.Click += ButtonRotateRightA2_Click;
			buttonRotateRightA2.Enter += Control_Enter;
			buttonRotateRightA2.Leave += Control_Leave;
			buttonRotateRightA2.MouseEnter += Control_Enter;
			buttonRotateRightA2.MouseLeave += Control_Leave;
			// 
			// buttonShiftLeftWithZeroA1
			// 
			buttonShiftLeftWithZeroA1.AccessibleDescription = "Shifts the value of A1 to the left with zeros";
			buttonShiftLeftWithZeroA1.AccessibleName = "Left-shifting of A1 with zeros";
			buttonShiftLeftWithZeroA1.AccessibleRole = AccessibleRole.PushButton;
			buttonShiftLeftWithZeroA1.Location = new Point(303, 24);
			buttonShiftLeftWithZeroA1.Name = "buttonShiftLeftWithZeroA1";
			buttonShiftLeftWithZeroA1.Size = new Size(91, 27);
			buttonShiftLeftWithZeroA1.TabIndex = 83;
			buttonShiftLeftWithZeroA1.ToolTipValues.Description = "Shifts the value of A1 to the left with zeros";
			buttonShiftLeftWithZeroA1.ToolTipValues.EnableToolTips = true;
			buttonShiftLeftWithZeroA1.ToolTipValues.Heading = "Left-shifting of A1 with zeros";
			buttonShiftLeftWithZeroA1.Values.DropDownArrowColor = Color.Empty;
			buttonShiftLeftWithZeroA1.Values.Text = "SHL0 A1";
			buttonShiftLeftWithZeroA1.Click += ButtonShiftLeftWithZeroA1_Click;
			buttonShiftLeftWithZeroA1.Enter += Control_Enter;
			buttonShiftLeftWithZeroA1.Leave += Control_Leave;
			buttonShiftLeftWithZeroA1.MouseEnter += Control_Enter;
			buttonShiftLeftWithZeroA1.MouseLeave += Control_Leave;
			// 
			// buttonShiftRightWithZeroA1
			// 
			buttonShiftRightWithZeroA1.AccessibleDescription = "Shifts the value of A1 to the right with zeros";
			buttonShiftRightWithZeroA1.AccessibleName = "Right-shifting of A1 with zeros";
			buttonShiftRightWithZeroA1.AccessibleRole = AccessibleRole.PushButton;
			buttonShiftRightWithZeroA1.Location = new Point(303, 91);
			buttonShiftRightWithZeroA1.Name = "buttonShiftRightWithZeroA1";
			buttonShiftRightWithZeroA1.Size = new Size(91, 27);
			buttonShiftRightWithZeroA1.TabIndex = 84;
			buttonShiftRightWithZeroA1.ToolTipValues.Description = "Shifts the value of A1 to the right with zeros";
			buttonShiftRightWithZeroA1.ToolTipValues.EnableToolTips = true;
			buttonShiftRightWithZeroA1.ToolTipValues.Heading = "Right-shifting of A1 with zeros";
			buttonShiftRightWithZeroA1.Values.DropDownArrowColor = Color.Empty;
			buttonShiftRightWithZeroA1.Values.Text = "SHR0 A1";
			buttonShiftRightWithZeroA1.Click += ButtonShiftRightWithZeroA1_Click;
			buttonShiftRightWithZeroA1.Enter += Control_Enter;
			buttonShiftRightWithZeroA1.Leave += Control_Leave;
			buttonShiftRightWithZeroA1.MouseEnter += Control_Enter;
			buttonShiftRightWithZeroA1.MouseLeave += Control_Leave;
			// 
			// buttonRotateLeftA1
			// 
			buttonRotateLeftA1.AccessibleDescription = "Rotate the value of A1 to the left";
			buttonRotateLeftA1.AccessibleName = "Left-rotation of A1";
			buttonRotateLeftA1.AccessibleRole = AccessibleRole.PushButton;
			buttonRotateLeftA1.Location = new Point(303, 158);
			buttonRotateLeftA1.Name = "buttonRotateLeftA1";
			buttonRotateLeftA1.Size = new Size(91, 27);
			buttonRotateLeftA1.TabIndex = 85;
			buttonRotateLeftA1.ToolTipValues.Description = "Rotate the value of A1 to the left";
			buttonRotateLeftA1.ToolTipValues.EnableToolTips = true;
			buttonRotateLeftA1.ToolTipValues.Heading = "Left-rotation of A1";
			buttonRotateLeftA1.Values.DropDownArrowColor = Color.Empty;
			buttonRotateLeftA1.Values.Text = "ROL A1";
			buttonRotateLeftA1.Click += ButtonRotateLeftA1_Click;
			buttonRotateLeftA1.Enter += Control_Enter;
			buttonRotateLeftA1.Leave += Control_Leave;
			buttonRotateLeftA1.MouseEnter += Control_Enter;
			buttonRotateLeftA1.MouseLeave += Control_Leave;
			// 
			// buttonRotateRightA1
			// 
			buttonRotateRightA1.AccessibleDescription = "Rotate the value of A1 to the right";
			buttonRotateRightA1.AccessibleName = "Right-rotation of A1";
			buttonRotateRightA1.AccessibleRole = AccessibleRole.PushButton;
			buttonRotateRightA1.Location = new Point(303, 192);
			buttonRotateRightA1.Name = "buttonRotateRightA1";
			buttonRotateRightA1.Size = new Size(91, 27);
			buttonRotateRightA1.TabIndex = 86;
			buttonRotateRightA1.ToolTipValues.Description = "Rotate the value of A1 to the right";
			buttonRotateRightA1.ToolTipValues.EnableToolTips = true;
			buttonRotateRightA1.ToolTipValues.Heading = "Right-rotation of A1";
			buttonRotateRightA1.Values.DropDownArrowColor = Color.Empty;
			buttonRotateRightA1.Values.Text = "ROR A1";
			buttonRotateRightA1.Click += ButtonRotateRightA1_Click;
			buttonRotateRightA1.Enter += Control_Enter;
			buttonRotateRightA1.Leave += Control_Leave;
			buttonRotateRightA1.MouseEnter += Control_Enter;
			buttonRotateRightA1.MouseLeave += Control_Leave;
			// 
			// buttonAdditionA1AndA2
			// 
			buttonAdditionA1AndA2.AccessibleDescription = "Calculates the addition of A1 and A2";
			buttonAdditionA1AndA2.AccessibleName = "Addition of A1 and A2";
			buttonAdditionA1AndA2.AccessibleRole = AccessibleRole.PushButton;
			buttonAdditionA1AndA2.Location = new Point(7, 24);
			buttonAdditionA1AndA2.Name = "buttonAdditionA1AndA2";
			buttonAdditionA1AndA2.Size = new Size(91, 27);
			buttonAdditionA1AndA2.TabIndex = 69;
			buttonAdditionA1AndA2.ToolTipValues.Description = "Calculates the addition of A1 and A2";
			buttonAdditionA1AndA2.ToolTipValues.EnableToolTips = true;
			buttonAdditionA1AndA2.ToolTipValues.Heading = "Addition of A1 and A2";
			buttonAdditionA1AndA2.Values.DropDownArrowColor = Color.Empty;
			buttonAdditionA1AndA2.Values.Text = "A1 + A2";
			buttonAdditionA1AndA2.Click += ButtonAdditionA1AndA2_Click;
			buttonAdditionA1AndA2.Enter += Control_Enter;
			buttonAdditionA1AndA2.Leave += Control_Leave;
			buttonAdditionA1AndA2.MouseEnter += Control_Enter;
			buttonAdditionA1AndA2.MouseLeave += Control_Leave;
			// 
			// buttonCopyResultToA2
			// 
			buttonCopyResultToA2.AccessibleDescription = "Copies the value of R into A1";
			buttonCopyResultToA2.AccessibleName = "R to A2 copy";
			buttonCopyResultToA2.AccessibleRole = AccessibleRole.PushButton;
			buttonCopyResultToA2.Location = new Point(204, 258);
			buttonCopyResultToA2.Name = "buttonCopyResultToA2";
			buttonCopyResultToA2.Size = new Size(91, 27);
			buttonCopyResultToA2.TabIndex = 82;
			buttonCopyResultToA2.ToolTipValues.Description = "Copies the value of R into A2";
			buttonCopyResultToA2.ToolTipValues.EnableToolTips = true;
			buttonCopyResultToA2.ToolTipValues.Heading = "R to A2 copy";
			buttonCopyResultToA2.Values.DropDownArrowColor = Color.Empty;
			buttonCopyResultToA2.Values.Text = "R > A2";
			buttonCopyResultToA2.Click += ButtonCopyResultToA2_Click;
			buttonCopyResultToA2.Enter += Control_Enter;
			buttonCopyResultToA2.Leave += Control_Leave;
			buttonCopyResultToA2.MouseEnter += Control_Enter;
			buttonCopyResultToA2.MouseLeave += Control_Leave;
			// 
			// buttonSubtractionA1AndA2
			// 
			buttonSubtractionA1AndA2.AccessibleDescription = "Calculates the subtraction of A1 and A2";
			buttonSubtractionA1AndA2.AccessibleName = "Subtraction of A1 and A2";
			buttonSubtractionA1AndA2.AccessibleRole = AccessibleRole.PushButton;
			buttonSubtractionA1AndA2.Enabled = false;
			buttonSubtractionA1AndA2.Location = new Point(7, 58);
			buttonSubtractionA1AndA2.Name = "buttonSubtractionA1AndA2";
			buttonSubtractionA1AndA2.Size = new Size(91, 27);
			buttonSubtractionA1AndA2.TabIndex = 70;
			buttonSubtractionA1AndA2.ToolTipValues.Description = "Calculates the subtraction of A1 and A2";
			buttonSubtractionA1AndA2.ToolTipValues.EnableToolTips = true;
			buttonSubtractionA1AndA2.ToolTipValues.Heading = "Subtraction of A1 and A2";
			buttonSubtractionA1AndA2.Values.DropDownArrowColor = Color.Empty;
			buttonSubtractionA1AndA2.Values.Text = "A1 - A2";
			buttonSubtractionA1AndA2.Click += ButtonSubtractionA1AndA2_Click;
			buttonSubtractionA1AndA2.Enter += Control_Enter;
			buttonSubtractionA1AndA2.Leave += Control_Leave;
			buttonSubtractionA1AndA2.MouseEnter += Control_Enter;
			buttonSubtractionA1AndA2.MouseLeave += Control_Leave;
			// 
			// buttonCopyResultToA1
			// 
			buttonCopyResultToA1.AccessibleDescription = "Copies the value of R into A1";
			buttonCopyResultToA1.AccessibleName = "R to A1 copy";
			buttonCopyResultToA1.AccessibleRole = AccessibleRole.PushButton;
			buttonCopyResultToA1.Location = new Point(106, 258);
			buttonCopyResultToA1.Name = "buttonCopyResultToA1";
			buttonCopyResultToA1.Size = new Size(91, 27);
			buttonCopyResultToA1.TabIndex = 81;
			buttonCopyResultToA1.ToolTipValues.Description = "Copies the value of R into A1";
			buttonCopyResultToA1.ToolTipValues.EnableToolTips = true;
			buttonCopyResultToA1.ToolTipValues.Heading = "R to A1 copy";
			buttonCopyResultToA1.Values.DropDownArrowColor = Color.Empty;
			buttonCopyResultToA1.Values.Text = "R > A1";
			buttonCopyResultToA1.Click += ButtonCopyResultToA1_Click;
			buttonCopyResultToA1.Enter += Control_Enter;
			buttonCopyResultToA1.Leave += Control_Leave;
			buttonCopyResultToA1.MouseEnter += Control_Enter;
			buttonCopyResultToA1.MouseLeave += Control_Leave;
			// 
			// buttonMultiplicationA1AndA2
			// 
			buttonMultiplicationA1AndA2.AccessibleDescription = "Calculates the multiplication of A1 and A2";
			buttonMultiplicationA1AndA2.AccessibleName = "Multiplication of A1 and A2";
			buttonMultiplicationA1AndA2.AccessibleRole = AccessibleRole.PushButton;
			buttonMultiplicationA1AndA2.Enabled = false;
			buttonMultiplicationA1AndA2.Location = new Point(7, 91);
			buttonMultiplicationA1AndA2.Name = "buttonMultiplicationA1AndA2";
			buttonMultiplicationA1AndA2.Size = new Size(91, 27);
			buttonMultiplicationA1AndA2.TabIndex = 71;
			buttonMultiplicationA1AndA2.ToolTipValues.Description = "Calculates the multiplication of A1 and A2";
			buttonMultiplicationA1AndA2.ToolTipValues.EnableToolTips = true;
			buttonMultiplicationA1AndA2.ToolTipValues.Heading = "Multiplication of A1 and A2";
			buttonMultiplicationA1AndA2.Values.DropDownArrowColor = Color.Empty;
			buttonMultiplicationA1AndA2.Values.Text = "A1 × A2";
			buttonMultiplicationA1AndA2.Click += ButtonMultiplicationA1AndA2_Click;
			buttonMultiplicationA1AndA2.Enter += Control_Enter;
			buttonMultiplicationA1AndA2.Leave += Control_Leave;
			buttonMultiplicationA1AndA2.MouseEnter += Control_Enter;
			buttonMultiplicationA1AndA2.MouseLeave += Control_Leave;
			// 
			// buttonLogicalXnorA1AndA2
			// 
			buttonLogicalXnorA1AndA2.AccessibleDescription = "Calculates the logical XNOR of A1 and A2";
			buttonLogicalXnorA1AndA2.AccessibleName = "Logical XNOR of A1 and A2";
			buttonLogicalXnorA1AndA2.AccessibleRole = AccessibleRole.PushButton;
			buttonLogicalXnorA1AndA2.Location = new Point(7, 325);
			buttonLogicalXnorA1AndA2.Name = "buttonLogicalXnorA1AndA2";
			buttonLogicalXnorA1AndA2.Size = new Size(91, 27);
			buttonLogicalXnorA1AndA2.TabIndex = 80;
			buttonLogicalXnorA1AndA2.ToolTipValues.Description = "Calculates the logical XNOR of A1 and A2";
			buttonLogicalXnorA1AndA2.ToolTipValues.EnableToolTips = true;
			buttonLogicalXnorA1AndA2.ToolTipValues.Heading = "Logical XNOR of A1 and A2";
			buttonLogicalXnorA1AndA2.Values.DropDownArrowColor = Color.Empty;
			buttonLogicalXnorA1AndA2.Values.Text = "A1 XNOR A2";
			buttonLogicalXnorA1AndA2.Click += ButtonLogicalXnorA1AndA2_Click;
			buttonLogicalXnorA1AndA2.Enter += Control_Enter;
			buttonLogicalXnorA1AndA2.Leave += Control_Leave;
			buttonLogicalXnorA1AndA2.MouseEnter += Control_Enter;
			buttonLogicalXnorA1AndA2.MouseLeave += Control_Leave;
			// 
			// buttonDivisionA1AndA2
			// 
			buttonDivisionA1AndA2.AccessibleDescription = "Calculates the division of A1 and A2";
			buttonDivisionA1AndA2.AccessibleName = "Division of A1 and A2";
			buttonDivisionA1AndA2.AccessibleRole = AccessibleRole.PushButton;
			buttonDivisionA1AndA2.Enabled = false;
			buttonDivisionA1AndA2.Location = new Point(7, 125);
			buttonDivisionA1AndA2.Name = "buttonDivisionA1AndA2";
			buttonDivisionA1AndA2.Size = new Size(91, 27);
			buttonDivisionA1AndA2.TabIndex = 72;
			buttonDivisionA1AndA2.ToolTipValues.Description = "Calculates the division of A1 and A2";
			buttonDivisionA1AndA2.ToolTipValues.EnableToolTips = true;
			buttonDivisionA1AndA2.ToolTipValues.Heading = "Division of A1 and A2";
			buttonDivisionA1AndA2.Values.DropDownArrowColor = Color.Empty;
			buttonDivisionA1AndA2.Values.Text = "A1 / A2";
			buttonDivisionA1AndA2.Click += ButtonDivisionA1AndA2_Click;
			buttonDivisionA1AndA2.Enter += Control_Enter;
			buttonDivisionA1AndA2.Leave += Control_Leave;
			buttonDivisionA1AndA2.MouseEnter += Control_Enter;
			buttonDivisionA1AndA2.MouseLeave += Control_Leave;
			// 
			// buttonLogicalNorA1AndA2
			// 
			buttonLogicalNorA1AndA2.AccessibleDescription = "Calculates the logical NOR of A1 and A2";
			buttonLogicalNorA1AndA2.AccessibleName = "Logical NOR of A1 and A2";
			buttonLogicalNorA1AndA2.AccessibleRole = AccessibleRole.PushButton;
			buttonLogicalNorA1AndA2.Location = new Point(7, 292);
			buttonLogicalNorA1AndA2.Name = "buttonLogicalNorA1AndA2";
			buttonLogicalNorA1AndA2.Size = new Size(91, 27);
			buttonLogicalNorA1AndA2.TabIndex = 79;
			buttonLogicalNorA1AndA2.ToolTipValues.Description = "Calculates the logical NOR of A1 and A2";
			buttonLogicalNorA1AndA2.ToolTipValues.EnableToolTips = true;
			buttonLogicalNorA1AndA2.ToolTipValues.Heading = "Logical NOR of A1 and A2";
			buttonLogicalNorA1AndA2.Values.DropDownArrowColor = Color.Empty;
			buttonLogicalNorA1AndA2.Values.Text = "A1 NOR A2";
			buttonLogicalNorA1AndA2.Click += ButtonLogicalNorA1AndA2_Click;
			buttonLogicalNorA1AndA2.Enter += Control_Enter;
			buttonLogicalNorA1AndA2.Leave += Control_Leave;
			buttonLogicalNorA1AndA2.MouseEnter += Control_Enter;
			buttonLogicalNorA1AndA2.MouseLeave += Control_Leave;
			// 
			// buttonLogicalAndA1AndA2
			// 
			buttonLogicalAndA1AndA2.AccessibleDescription = "Calculates the logical AND of A1 and A2";
			buttonLogicalAndA1AndA2.AccessibleName = "Logical AND of A1 and A2";
			buttonLogicalAndA1AndA2.AccessibleRole = AccessibleRole.PushButton;
			buttonLogicalAndA1AndA2.Location = new Point(7, 158);
			buttonLogicalAndA1AndA2.Name = "buttonLogicalAndA1AndA2";
			buttonLogicalAndA1AndA2.Size = new Size(91, 27);
			buttonLogicalAndA1AndA2.TabIndex = 73;
			buttonLogicalAndA1AndA2.ToolTipValues.Description = "Calculates the logical AND of A1 and A2";
			buttonLogicalAndA1AndA2.ToolTipValues.EnableToolTips = true;
			buttonLogicalAndA1AndA2.ToolTipValues.Heading = "Logical AND of A1 and A2";
			buttonLogicalAndA1AndA2.Values.DropDownArrowColor = Color.Empty;
			buttonLogicalAndA1AndA2.Values.Text = "A1 AND A2";
			buttonLogicalAndA1AndA2.Click += ButtonLogicalAndA1AndA2_Click;
			buttonLogicalAndA1AndA2.Enter += Control_Enter;
			buttonLogicalAndA1AndA2.Leave += Control_Leave;
			buttonLogicalAndA1AndA2.MouseEnter += Control_Enter;
			buttonLogicalAndA1AndA2.MouseLeave += Control_Leave;
			// 
			// buttonLogicalOrA1AndA2
			// 
			buttonLogicalOrA1AndA2.AccessibleDescription = "Calculates the logical OR of A1 and A2";
			buttonLogicalOrA1AndA2.AccessibleName = "Logical OR of A1 and A2";
			buttonLogicalOrA1AndA2.AccessibleRole = AccessibleRole.PushButton;
			buttonLogicalOrA1AndA2.Location = new Point(7, 192);
			buttonLogicalOrA1AndA2.Name = "buttonLogicalOrA1AndA2";
			buttonLogicalOrA1AndA2.Size = new Size(91, 27);
			buttonLogicalOrA1AndA2.TabIndex = 74;
			buttonLogicalOrA1AndA2.ToolTipValues.Description = "Calculates the Logiocal OR of A1 and A2";
			buttonLogicalOrA1AndA2.ToolTipValues.EnableToolTips = true;
			buttonLogicalOrA1AndA2.ToolTipValues.Heading = "Logiocal OR of A1 and A2";
			buttonLogicalOrA1AndA2.Values.DropDownArrowColor = Color.Empty;
			buttonLogicalOrA1AndA2.Values.Text = "A1 OR A2";
			buttonLogicalOrA1AndA2.Click += ButtonLogicalOrA1AndA2_Click;
			buttonLogicalOrA1AndA2.Enter += Control_Enter;
			buttonLogicalOrA1AndA2.Leave += Control_Leave;
			buttonLogicalOrA1AndA2.MouseEnter += Control_Enter;
			buttonLogicalOrA1AndA2.MouseLeave += Control_Leave;
			// 
			// buttonInvertA2
			// 
			buttonInvertA2.AccessibleDescription = "Inverts the bits of A2";
			buttonInvertA2.AccessibleName = "Invertation of A2";
			buttonInvertA2.AccessibleRole = AccessibleRole.PushButton;
			buttonInvertA2.Location = new Point(204, 125);
			buttonInvertA2.Name = "buttonInvertA2";
			buttonInvertA2.Size = new Size(91, 27);
			buttonInvertA2.TabIndex = 77;
			buttonInvertA2.ToolTipValues.Description = "Inverts the bits of A2";
			buttonInvertA2.ToolTipValues.EnableToolTips = true;
			buttonInvertA2.ToolTipValues.Heading = "Invertation of A2";
			buttonInvertA2.Values.DropDownArrowColor = Color.Empty;
			buttonInvertA2.Values.Text = "NOT A2";
			buttonInvertA2.Click += ButtonInvertA2_Click;
			buttonInvertA2.Enter += Control_Enter;
			buttonInvertA2.Leave += Control_Leave;
			buttonInvertA2.MouseEnter += Control_Enter;
			buttonInvertA2.MouseLeave += Control_Leave;
			// 
			// buttonLogicalXorA1AndA2
			// 
			buttonLogicalXorA1AndA2.AccessibleDescription = "Calculates the logical XOR of A1 and A2";
			buttonLogicalXorA1AndA2.AccessibleName = "Logical XOR of A1 and A2";
			buttonLogicalXorA1AndA2.AccessibleRole = AccessibleRole.PushButton;
			buttonLogicalXorA1AndA2.Location = new Point(7, 225);
			buttonLogicalXorA1AndA2.Name = "buttonLogicalXorA1AndA2";
			buttonLogicalXorA1AndA2.Size = new Size(91, 27);
			buttonLogicalXorA1AndA2.TabIndex = 75;
			buttonLogicalXorA1AndA2.ToolTipValues.Description = "Calculates the Logical XOR of A1 and A2";
			buttonLogicalXorA1AndA2.ToolTipValues.EnableToolTips = true;
			buttonLogicalXorA1AndA2.ToolTipValues.Heading = "Logical XOR of A1 and A2";
			buttonLogicalXorA1AndA2.Values.DropDownArrowColor = Color.Empty;
			buttonLogicalXorA1AndA2.Values.Text = "A1 XOR A2";
			buttonLogicalXorA1AndA2.Click += ButtonLogicalXorA1AndA2_Click;
			buttonLogicalXorA1AndA2.Enter += Control_Enter;
			buttonLogicalXorA1AndA2.Leave += Control_Leave;
			buttonLogicalXorA1AndA2.MouseEnter += Control_Enter;
			buttonLogicalXorA1AndA2.MouseLeave += Control_Leave;
			// 
			// buttonInvertA1
			// 
			buttonInvertA1.AccessibleDescription = "Inverts the bits of A1";
			buttonInvertA1.AccessibleName = "Invertation of A1";
			buttonInvertA1.AccessibleRole = AccessibleRole.PushButton;
			buttonInvertA1.Location = new Point(106, 125);
			buttonInvertA1.Name = "buttonInvertA1";
			buttonInvertA1.Size = new Size(91, 27);
			buttonInvertA1.TabIndex = 76;
			buttonInvertA1.ToolTipValues.Description = "Inverts the bits of A1";
			buttonInvertA1.ToolTipValues.EnableToolTips = true;
			buttonInvertA1.ToolTipValues.Heading = "Invertation of A1";
			buttonInvertA1.Values.DropDownArrowColor = Color.Empty;
			buttonInvertA1.Values.Text = "NOT A1";
			buttonInvertA1.Click += ButtonInvertA1_Click;
			buttonInvertA1.Enter += Control_Enter;
			buttonInvertA1.Leave += Control_Leave;
			buttonInvertA1.MouseEnter += Control_Enter;
			buttonInvertA1.MouseLeave += Control_Leave;
			// 
			// groupBoxResult
			// 
			groupBoxResult.AccessibleDescription = "Groups the elements of R";
			groupBoxResult.AccessibleName = "Elements of R";
			groupBoxResult.AccessibleRole = AccessibleRole.Grouping;
			groupBoxResult.BackColor = Color.Transparent;
			groupBoxResult.Controls.Add(textBoxResultOctal);
			groupBoxResult.Controls.Add(labelResultOctal);
			groupBoxResult.Controls.Add(maskedTextBoxResultNetwork);
			groupBoxResult.Controls.Add(labelResultNetwork);
			groupBoxResult.Controls.Add(textResultDecimal);
			groupBoxResult.Controls.Add(textBoxResultHexadecimal);
			groupBoxResult.Controls.Add(labelResultDecimal);
			groupBoxResult.Controls.Add(labelResultHexadecimal);
			groupBoxResult.Controls.Add(groupBoxResultByte4);
			groupBoxResult.Controls.Add(groupBoxResultByte3);
			groupBoxResult.Controls.Add(groupBoxResultByte2);
			groupBoxResult.Controls.Add(groupBoxResultByte1);
			groupBoxResult.Location = new Point(13, 298);
			groupBoxResult.Name = "groupBoxResult";
			groupBoxResult.Size = new Size(820, 135);
			groupBoxResult.TabIndex = 68;
			groupBoxResult.TabStop = false;
			groupBoxResult.Text = "Result (R)";
			// 
			// textBoxResultOctal
			// 
			textBoxResultOctal.AccessibleDescription = "Shows the octal value of R";
			textBoxResultOctal.AccessibleName = "Octal value of R";
			textBoxResultOctal.AccessibleRole = AccessibleRole.Text;
			textBoxResultOctal.Location = new Point(457, 28);
			textBoxResultOctal.Name = "textBoxResultOctal";
			textBoxResultOctal.Size = new Size(116, 23);
			textBoxResultOctal.TabIndex = 71;
			textBoxResultOctal.ToolTipValues.Description = "Shows the octal value of R";
			textBoxResultOctal.ToolTipValues.EnableToolTips = true;
			textBoxResultOctal.ToolTipValues.Heading = "Octal value of R";
			textBoxResultOctal.Enter += Control_Enter;
			textBoxResultOctal.Leave += Control_Leave;
			textBoxResultOctal.MouseEnter += Control_Enter;
			textBoxResultOctal.MouseLeave += Control_Leave;
			// 
			// labelResultOctal
			// 
			labelResultOctal.AccessibleDescription = "Shows the description of octal value of R";
			labelResultOctal.AccessibleName = "Description of octal value of R";
			labelResultOctal.AccessibleRole = AccessibleRole.StaticText;
			labelResultOctal.Location = new Point(411, 31);
			labelResultOctal.Name = "labelResultOctal";
			labelResultOctal.Size = new Size(35, 20);
			labelResultOctal.TabIndex = 70;
			labelResultOctal.Values.Text = "Oct.:";
			labelResultOctal.Enter += Control_Enter;
			labelResultOctal.Leave += Control_Leave;
			labelResultOctal.MouseEnter += Control_Enter;
			labelResultOctal.MouseLeave += Control_Leave;
			// 
			// maskedTextBoxResultNetwork
			// 
			maskedTextBoxResultNetwork.AccessibleDescription = "Shows the network value of R";
			maskedTextBoxResultNetwork.AccessibleName = "Network value of R";
			maskedTextBoxResultNetwork.AccessibleRole = AccessibleRole.Text;
			maskedTextBoxResultNetwork.Location = new Point(667, 28);
			maskedTextBoxResultNetwork.Name = "maskedTextBoxResultNetwork";
			maskedTextBoxResultNetwork.Size = new Size(116, 23);
			maskedTextBoxResultNetwork.TabIndex = 67;
			maskedTextBoxResultNetwork.ToolTipValues.Description = "Shows the network value of R";
			maskedTextBoxResultNetwork.ToolTipValues.EnableToolTips = true;
			maskedTextBoxResultNetwork.ToolTipValues.Heading = "Network value of R";
			maskedTextBoxResultNetwork.Enter += Control_Enter;
			maskedTextBoxResultNetwork.Leave += Control_Leave;
			maskedTextBoxResultNetwork.MouseEnter += Control_Enter;
			maskedTextBoxResultNetwork.MouseLeave += Control_Leave;
			// 
			// labelResultNetwork
			// 
			labelResultNetwork.AccessibleDescription = "Shows the description of network value of R";
			labelResultNetwork.AccessibleName = "Description of network value of R";
			labelResultNetwork.AccessibleRole = AccessibleRole.StaticText;
			labelResultNetwork.Location = new Point(615, 31);
			labelResultNetwork.Name = "labelResultNetwork";
			labelResultNetwork.Size = new Size(45, 20);
			labelResultNetwork.TabIndex = 68;
			labelResultNetwork.Values.Text = "Netw.:";
			labelResultNetwork.Enter += Control_Enter;
			labelResultNetwork.Leave += Control_Leave;
			labelResultNetwork.MouseEnter += Control_Enter;
			labelResultNetwork.MouseLeave += Control_Leave;
			// 
			// textResultDecimal
			// 
			textResultDecimal.AccessibleDescription = "Shows the decimal value of R";
			textResultDecimal.AccessibleName = "Decimal value of R";
			textResultDecimal.AccessibleRole = AccessibleRole.Text;
			textResultDecimal.Location = new Point(253, 28);
			textResultDecimal.Name = "textResultDecimal";
			textResultDecimal.Size = new Size(116, 23);
			textResultDecimal.TabIndex = 68;
			textResultDecimal.ToolTipValues.Description = "Shows the decimal value of R";
			textResultDecimal.ToolTipValues.EnableToolTips = true;
			textResultDecimal.ToolTipValues.Heading = "Decimal value of R";
			textResultDecimal.Enter += Control_Enter;
			textResultDecimal.Leave += Control_Leave;
			textResultDecimal.MouseEnter += Control_Enter;
			textResultDecimal.MouseLeave += Control_Leave;
			// 
			// textBoxResultHexadecimal
			// 
			textBoxResultHexadecimal.AccessibleDescription = "Shows the hexadecimal value of A2";
			textBoxResultHexadecimal.AccessibleName = "Hexadecimal value of R";
			textBoxResultHexadecimal.AccessibleRole = AccessibleRole.Text;
			textBoxResultHexadecimal.Location = new Point(50, 28);
			textBoxResultHexadecimal.Name = "textBoxResultHexadecimal";
			textBoxResultHexadecimal.Size = new Size(116, 23);
			textBoxResultHexadecimal.TabIndex = 67;
			textBoxResultHexadecimal.ToolTipValues.Description = "Shows the hexadecimal value of R";
			textBoxResultHexadecimal.ToolTipValues.EnableToolTips = true;
			textBoxResultHexadecimal.ToolTipValues.Heading = "Hexadecimal value of R";
			textBoxResultHexadecimal.Enter += Control_Enter;
			textBoxResultHexadecimal.Leave += Control_Leave;
			textBoxResultHexadecimal.MouseEnter += Control_Enter;
			textBoxResultHexadecimal.MouseLeave += Control_Leave;
			// 
			// labelResultDecimal
			// 
			labelResultDecimal.AccessibleDescription = "Shows the description of decimal value of R";
			labelResultDecimal.AccessibleName = "Description of decimal value of R";
			labelResultDecimal.AccessibleRole = AccessibleRole.StaticText;
			labelResultDecimal.Location = new Point(207, 31);
			labelResultDecimal.Name = "labelResultDecimal";
			labelResultDecimal.Size = new Size(37, 20);
			labelResultDecimal.TabIndex = 69;
			labelResultDecimal.Values.Text = "Dec.:";
			labelResultDecimal.Enter += Control_Enter;
			labelResultDecimal.Leave += Control_Leave;
			labelResultDecimal.MouseEnter += Control_Enter;
			labelResultDecimal.MouseLeave += Control_Leave;
			// 
			// labelResultHexadecimal
			// 
			labelResultHexadecimal.AccessibleDescription = "Shows the description of hexadecimal value of A2";
			labelResultHexadecimal.AccessibleName = "Description of hexadecimal value of A2";
			labelResultHexadecimal.AccessibleRole = AccessibleRole.StaticText;
			labelResultHexadecimal.Location = new Point(5, 31);
			labelResultHexadecimal.Name = "labelResultHexadecimal";
			labelResultHexadecimal.Size = new Size(37, 20);
			labelResultHexadecimal.TabIndex = 67;
			labelResultHexadecimal.Values.Text = "Hex.:";
			labelResultHexadecimal.Enter += Control_Enter;
			labelResultHexadecimal.Leave += Control_Leave;
			labelResultHexadecimal.MouseEnter += Control_Enter;
			labelResultHexadecimal.MouseLeave += Control_Leave;
			// 
			// groupBoxResultByte4
			// 
			groupBoxResultByte4.AccessibleDescription = "Groups the elements of byte 4 in R";
			groupBoxResultByte4.AccessibleName = "Elements of byte 4 in R";
			groupBoxResultByte4.AccessibleRole = AccessibleRole.Grouping;
			groupBoxResultByte4.Controls.Add(labelResultBit31);
			groupBoxResultByte4.Controls.Add(checkBoxResultBit31);
			groupBoxResultByte4.Controls.Add(checkBoxResultBit24);
			groupBoxResultByte4.Controls.Add(labelResultBit24);
			groupBoxResultByte4.Controls.Add(checkBoxResultBit25);
			groupBoxResultByte4.Controls.Add(labelResultBit30);
			groupBoxResultByte4.Controls.Add(labelResultBit25);
			groupBoxResultByte4.Controls.Add(checkBoxResultBit26);
			groupBoxResultByte4.Controls.Add(checkBoxResultBit30);
			groupBoxResultByte4.Controls.Add(labelResultBit26);
			groupBoxResultByte4.Controls.Add(labelResultBit29);
			groupBoxResultByte4.Controls.Add(checkBoxResultBit27);
			groupBoxResultByte4.Controls.Add(checkBoxResultBit29);
			groupBoxResultByte4.Controls.Add(labelResultBit27);
			groupBoxResultByte4.Controls.Add(labelResultBit28);
			groupBoxResultByte4.Controls.Add(checkBoxResultBit28);
			groupBoxResultByte4.Location = new Point(7, 66);
			groupBoxResultByte4.Name = "groupBoxResultByte4";
			groupBoxResultByte4.Size = new Size(196, 62);
			groupBoxResultByte4.TabIndex = 69;
			groupBoxResultByte4.TabStop = false;
			groupBoxResultByte4.Text = "Byte 4";
			// 
			// labelResultBit31
			// 
			labelResultBit31.AccessibleDescription = "Shows bit 31 of byte 4 in R";
			labelResultBit31.AccessibleName = "Bit 31 of byte 4 in R";
			labelResultBit31.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit31.Location = new Point(-1, 18);
			labelResultBit31.Name = "labelResultBit31";
			labelResultBit31.Size = new Size(24, 20);
			labelResultBit31.TabIndex = 65;
			labelResultBit31.ToolTipValues.Description = "Shows bit 31 of byte 4 in R";
			labelResultBit31.ToolTipValues.EnableToolTips = true;
			labelResultBit31.ToolTipValues.Heading = "Bit 31 of byte 4 in R";
			labelResultBit31.Values.Text = "31";
			labelResultBit31.Enter += Control_Enter;
			labelResultBit31.Leave += Control_Leave;
			labelResultBit31.MouseEnter += Control_Enter;
			labelResultBit31.MouseLeave += Control_Leave;
			// 
			// checkBoxResultBit31
			// 
			checkBoxResultBit31.AccessibleDescription = "Shows bit 31 of byte 4 in R";
			checkBoxResultBit31.AccessibleName = "Bit 31 of byte 4 in R";
			checkBoxResultBit31.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit31.AutoCheck = false;
			checkBoxResultBit31.Location = new Point(4, 38);
			checkBoxResultBit31.Name = "checkBoxResultBit31";
			checkBoxResultBit31.Size = new Size(19, 14);
			checkBoxResultBit31.TabIndex = 64;
			checkBoxResultBit31.ToolTipValues.Description = "Shows bit 31 of byte 4 in R";
			checkBoxResultBit31.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit31.ToolTipValues.Heading = "Bit 31 of byte 4 in R";
			checkBoxResultBit31.Values.Text = "";
			checkBoxResultBit31.Enter += Control_Enter;
			checkBoxResultBit31.Leave += Control_Leave;
			checkBoxResultBit31.MouseEnter += Control_Enter;
			checkBoxResultBit31.MouseLeave += Control_Leave;
			// 
			// checkBoxResultBit24
			// 
			checkBoxResultBit24.AccessibleDescription = "Shows bit 24 of byte 4 in R";
			checkBoxResultBit24.AccessibleName = "Bit 24 of byte 4 in R";
			checkBoxResultBit24.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit24.AutoCheck = false;
			checkBoxResultBit24.Location = new Point(173, 38);
			checkBoxResultBit24.Name = "checkBoxResultBit24";
			checkBoxResultBit24.Size = new Size(19, 14);
			checkBoxResultBit24.TabIndex = 50;
			checkBoxResultBit24.ToolTipValues.Description = "Shows bit 24 of byte 4 in R";
			checkBoxResultBit24.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit24.ToolTipValues.Heading = "Bit 24 of byte 4 in R";
			checkBoxResultBit24.Values.Text = "";
			checkBoxResultBit24.Enter += Control_Enter;
			checkBoxResultBit24.Leave += Control_Leave;
			checkBoxResultBit24.MouseEnter += Control_Enter;
			checkBoxResultBit24.MouseLeave += Control_Leave;
			// 
			// labelResultBit24
			// 
			labelResultBit24.AccessibleDescription = "Shows bit 24 of byte 4 in R";
			labelResultBit24.AccessibleName = "Bit 24 of byte 4 in R";
			labelResultBit24.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit24.Location = new Point(167, 18);
			labelResultBit24.Name = "labelResultBit24";
			labelResultBit24.Size = new Size(24, 20);
			labelResultBit24.TabIndex = 51;
			labelResultBit24.ToolTipValues.Description = "Shows bit 24 of byte 4 in R";
			labelResultBit24.ToolTipValues.EnableToolTips = true;
			labelResultBit24.ToolTipValues.Heading = "Bit 24 of byte 4 in R";
			labelResultBit24.Values.Text = "24";
			labelResultBit24.Enter += Control_Enter;
			labelResultBit24.Leave += Control_Leave;
			labelResultBit24.MouseEnter += Control_Enter;
			labelResultBit24.MouseLeave += Control_Leave;
			// 
			// checkBoxResultBit25
			// 
			checkBoxResultBit25.AccessibleDescription = "Shows bit 25 of byte 4 in R";
			checkBoxResultBit25.AccessibleName = "Bit 25 of byte 4 in R";
			checkBoxResultBit25.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit25.AutoCheck = false;
			checkBoxResultBit25.Location = new Point(151, 38);
			checkBoxResultBit25.Name = "checkBoxResultBit25";
			checkBoxResultBit25.Size = new Size(19, 14);
			checkBoxResultBit25.TabIndex = 52;
			checkBoxResultBit25.ToolTipValues.Description = "Shows bit 25 of byte 4 in R";
			checkBoxResultBit25.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit25.ToolTipValues.Heading = "Bit 25 of byte 4 in R";
			checkBoxResultBit25.Values.Text = "";
			checkBoxResultBit25.Enter += Control_Enter;
			checkBoxResultBit25.Leave += Control_Leave;
			checkBoxResultBit25.MouseEnter += Control_Enter;
			checkBoxResultBit25.MouseLeave += Control_Leave;
			// 
			// labelResultBit30
			// 
			labelResultBit30.AccessibleDescription = "Shows bit 30 of byte 4 in R";
			labelResultBit30.AccessibleName = "Bit 30 of byte 4 in R";
			labelResultBit30.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit30.Location = new Point(21, 18);
			labelResultBit30.Name = "labelResultBit30";
			labelResultBit30.Size = new Size(24, 20);
			labelResultBit30.TabIndex = 63;
			labelResultBit30.ToolTipValues.Description = "Shows bit 30 of byte 4 in R";
			labelResultBit30.ToolTipValues.EnableToolTips = true;
			labelResultBit30.ToolTipValues.Heading = "Bit 30 of byte 4 in R";
			labelResultBit30.Values.Text = "30";
			labelResultBit30.Enter += Control_Enter;
			labelResultBit30.Leave += Control_Leave;
			labelResultBit30.MouseEnter += Control_Enter;
			labelResultBit30.MouseLeave += Control_Leave;
			// 
			// labelResultBit25
			// 
			labelResultBit25.AccessibleDescription = "Shows bit 25 of byte 4 in R";
			labelResultBit25.AccessibleName = "Bit 25 of byte 4 in R";
			labelResultBit25.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit25.Location = new Point(146, 18);
			labelResultBit25.Name = "labelResultBit25";
			labelResultBit25.Size = new Size(24, 20);
			labelResultBit25.TabIndex = 53;
			labelResultBit25.ToolTipValues.Description = "Shows bit 25 of byte 4 in R";
			labelResultBit25.ToolTipValues.EnableToolTips = true;
			labelResultBit25.ToolTipValues.Heading = "Bit 25 of byte 4 in R";
			labelResultBit25.Values.Text = "25";
			labelResultBit25.Enter += Control_Enter;
			labelResultBit25.Leave += Control_Leave;
			labelResultBit25.MouseEnter += Control_Enter;
			labelResultBit25.MouseLeave += Control_Leave;
			// 
			// checkBoxResultBit26
			// 
			checkBoxResultBit26.AccessibleDescription = "Shows bit 26 of byte 4 in R";
			checkBoxResultBit26.AccessibleName = "Bit 26 of byte 4 in R";
			checkBoxResultBit26.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit26.AutoCheck = false;
			checkBoxResultBit26.Location = new Point(129, 38);
			checkBoxResultBit26.Name = "checkBoxResultBit26";
			checkBoxResultBit26.Size = new Size(19, 14);
			checkBoxResultBit26.TabIndex = 54;
			checkBoxResultBit26.ToolTipValues.Description = "Shows bit 26 of byte 4 in R";
			checkBoxResultBit26.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit26.ToolTipValues.Heading = "Bit 26 of byte 4 in R";
			checkBoxResultBit26.Values.Text = "";
			checkBoxResultBit26.Enter += Control_Enter;
			checkBoxResultBit26.Leave += Control_Leave;
			checkBoxResultBit26.MouseEnter += Control_Enter;
			checkBoxResultBit26.MouseLeave += Control_Leave;
			// 
			// checkBoxResultBit30
			// 
			checkBoxResultBit30.AccessibleDescription = "Shows bit 30 of byte 4 in R";
			checkBoxResultBit30.AccessibleName = "Bit 30 of byte 4 in R";
			checkBoxResultBit30.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit30.AutoCheck = false;
			checkBoxResultBit30.Location = new Point(26, 38);
			checkBoxResultBit30.Name = "checkBoxResultBit30";
			checkBoxResultBit30.Size = new Size(19, 14);
			checkBoxResultBit30.TabIndex = 62;
			checkBoxResultBit30.ToolTipValues.Description = "Shows bit 30 of byte 4 in R";
			checkBoxResultBit30.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit30.ToolTipValues.Heading = "Bit 30 of byte 4 in R";
			checkBoxResultBit30.Values.Text = "";
			checkBoxResultBit30.Enter += Control_Enter;
			checkBoxResultBit30.Leave += Control_Leave;
			checkBoxResultBit30.MouseEnter += Control_Enter;
			checkBoxResultBit30.MouseLeave += Control_Leave;
			// 
			// labelResultBit26
			// 
			labelResultBit26.AccessibleDescription = "Shows bit 26 of byte 4 in R";
			labelResultBit26.AccessibleName = "Bit 26 of byte 4 in R";
			labelResultBit26.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit26.Location = new Point(124, 18);
			labelResultBit26.Name = "labelResultBit26";
			labelResultBit26.Size = new Size(24, 20);
			labelResultBit26.TabIndex = 55;
			labelResultBit26.ToolTipValues.Description = "Shows bit 26 of byte 4 in R";
			labelResultBit26.ToolTipValues.EnableToolTips = true;
			labelResultBit26.ToolTipValues.Heading = "Bit 26 of byte 4 in R";
			labelResultBit26.Values.Text = "26";
			labelResultBit26.Enter += Control_Enter;
			labelResultBit26.Leave += Control_Leave;
			labelResultBit26.MouseEnter += Control_Enter;
			labelResultBit26.MouseLeave += Control_Leave;
			// 
			// labelResultBit29
			// 
			labelResultBit29.AccessibleDescription = "Shows bit 29 of byte 4 in R";
			labelResultBit29.AccessibleName = "Bit 29 of byte 4 in R";
			labelResultBit29.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit29.Location = new Point(43, 18);
			labelResultBit29.Name = "labelResultBit29";
			labelResultBit29.Size = new Size(24, 20);
			labelResultBit29.TabIndex = 61;
			labelResultBit29.ToolTipValues.Description = "Shpws bit 29 of byte 4 in R";
			labelResultBit29.ToolTipValues.EnableToolTips = true;
			labelResultBit29.ToolTipValues.Heading = "Bit 29 of byte 4 in R";
			labelResultBit29.Values.Text = "29";
			labelResultBit29.Enter += Control_Enter;
			labelResultBit29.Leave += Control_Leave;
			labelResultBit29.MouseEnter += Control_Enter;
			labelResultBit29.MouseLeave += Control_Leave;
			// 
			// checkBoxResultBit27
			// 
			checkBoxResultBit27.AccessibleDescription = "Shows bit 27 of byte 4 in R";
			checkBoxResultBit27.AccessibleName = "Bit 27 of byte 4 in R";
			checkBoxResultBit27.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit27.AutoCheck = false;
			checkBoxResultBit27.Location = new Point(106, 38);
			checkBoxResultBit27.Name = "checkBoxResultBit27";
			checkBoxResultBit27.Size = new Size(19, 14);
			checkBoxResultBit27.TabIndex = 56;
			checkBoxResultBit27.ToolTipValues.Description = "Shows bit 27 of byte 4 in R";
			checkBoxResultBit27.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit27.ToolTipValues.Heading = "Bit 27 of byte 4 in R";
			checkBoxResultBit27.Values.Text = "";
			checkBoxResultBit27.Enter += Control_Enter;
			checkBoxResultBit27.Leave += Control_Leave;
			checkBoxResultBit27.MouseEnter += Control_Enter;
			checkBoxResultBit27.MouseLeave += Control_Leave;
			// 
			// checkBoxResultBit29
			// 
			checkBoxResultBit29.AccessibleDescription = "Shows bit 29 of byte 4 in R";
			checkBoxResultBit29.AccessibleName = "Bit 29 of byte 4 in R";
			checkBoxResultBit29.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit29.AutoCheck = false;
			checkBoxResultBit29.Location = new Point(48, 38);
			checkBoxResultBit29.Name = "checkBoxResultBit29";
			checkBoxResultBit29.Size = new Size(19, 14);
			checkBoxResultBit29.TabIndex = 60;
			checkBoxResultBit29.ToolTipValues.Description = "Shpws bit 29 of byte 4 in R";
			checkBoxResultBit29.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit29.ToolTipValues.Heading = "Bit 29 of byte 4 in R";
			checkBoxResultBit29.Values.Text = "";
			checkBoxResultBit29.Enter += Control_Enter;
			checkBoxResultBit29.Leave += Control_Leave;
			checkBoxResultBit29.MouseEnter += Control_Enter;
			checkBoxResultBit29.MouseLeave += Control_Leave;
			// 
			// labelResultBit27
			// 
			labelResultBit27.AccessibleDescription = "Shows bit 27 of byte 4 in R";
			labelResultBit27.AccessibleName = "Bit 27 of byte 4 in R";
			labelResultBit27.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit27.Location = new Point(100, 18);
			labelResultBit27.Name = "labelResultBit27";
			labelResultBit27.Size = new Size(24, 20);
			labelResultBit27.TabIndex = 57;
			labelResultBit27.ToolTipValues.Description = "Shows bit 27 of byte 4 in R";
			labelResultBit27.ToolTipValues.EnableToolTips = true;
			labelResultBit27.ToolTipValues.Heading = "Bit 27 of byte 4 in R";
			labelResultBit27.Values.Text = "27";
			labelResultBit27.Enter += Control_Enter;
			labelResultBit27.Leave += Control_Leave;
			labelResultBit27.MouseEnter += Control_Enter;
			labelResultBit27.MouseLeave += Control_Leave;
			// 
			// labelResultBit28
			// 
			labelResultBit28.AccessibleDescription = "Shows bit 28 of byte 4 in R";
			labelResultBit28.AccessibleName = "Bit 28 of byte 4 in R";
			labelResultBit28.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit28.Location = new Point(65, 18);
			labelResultBit28.Name = "labelResultBit28";
			labelResultBit28.Size = new Size(24, 20);
			labelResultBit28.TabIndex = 59;
			labelResultBit28.ToolTipValues.Description = "Shows bit 28 of byte 4 in R";
			labelResultBit28.ToolTipValues.EnableToolTips = true;
			labelResultBit28.ToolTipValues.Heading = "Bit 28 of byte 4 in R";
			labelResultBit28.Values.Text = "28";
			labelResultBit28.Enter += Control_Enter;
			labelResultBit28.Leave += Control_Leave;
			labelResultBit28.MouseEnter += Control_Enter;
			labelResultBit28.MouseLeave += Control_Leave;
			// 
			// checkBoxResultBit28
			// 
			checkBoxResultBit28.AccessibleDescription = "Shows bit 28 of byte 4 in R";
			checkBoxResultBit28.AccessibleName = "Bit 28 of byte 4 in R";
			checkBoxResultBit28.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit28.AutoCheck = false;
			checkBoxResultBit28.Location = new Point(70, 38);
			checkBoxResultBit28.Name = "checkBoxResultBit28";
			checkBoxResultBit28.Size = new Size(19, 14);
			checkBoxResultBit28.TabIndex = 58;
			checkBoxResultBit28.ToolTipValues.Description = "Shows bit 28 of byte 4 in R";
			checkBoxResultBit28.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit28.ToolTipValues.Heading = "Bit 28 of byte 4 in R";
			checkBoxResultBit28.Values.Text = "";
			checkBoxResultBit28.Enter += Control_Enter;
			checkBoxResultBit28.Leave += Control_Leave;
			checkBoxResultBit28.MouseEnter += Control_Enter;
			checkBoxResultBit28.MouseLeave += Control_Leave;
			// 
			// groupBoxResultByte3
			// 
			groupBoxResultByte3.AccessibleDescription = "Groups the elements of byte 3 in R";
			groupBoxResultByte3.AccessibleName = "Elements of byte 3 in R";
			groupBoxResultByte3.AccessibleRole = AccessibleRole.Grouping;
			groupBoxResultByte3.Controls.Add(checkBoxResultBit23);
			groupBoxResultByte3.Controls.Add(checkBoxResultBit21);
			groupBoxResultByte3.Controls.Add(labelResultBit21);
			groupBoxResultByte3.Controls.Add(labelResultBit20);
			groupBoxResultByte3.Controls.Add(checkBoxResultBit22);
			groupBoxResultByte3.Controls.Add(checkBoxResultBit20);
			groupBoxResultByte3.Controls.Add(labelResultBit22);
			groupBoxResultByte3.Controls.Add(labelResultBit19);
			groupBoxResultByte3.Controls.Add(checkBoxResultBit16);
			groupBoxResultByte3.Controls.Add(checkBoxResultBit19);
			groupBoxResultByte3.Controls.Add(labelResultBit23);
			groupBoxResultByte3.Controls.Add(labelResultBit18);
			groupBoxResultByte3.Controls.Add(labelResultBit16);
			groupBoxResultByte3.Controls.Add(checkBoxResultBit18);
			groupBoxResultByte3.Controls.Add(labelResultBit17);
			groupBoxResultByte3.Controls.Add(checkBoxResultBit17);
			groupBoxResultByte3.Location = new Point(212, 66);
			groupBoxResultByte3.Name = "groupBoxResultByte3";
			groupBoxResultByte3.Size = new Size(196, 62);
			groupBoxResultByte3.TabIndex = 68;
			groupBoxResultByte3.TabStop = false;
			groupBoxResultByte3.Text = "Byte 3";
			// 
			// checkBoxResultBit23
			// 
			checkBoxResultBit23.AccessibleDescription = "Shows bit 23 of byte 3 in R";
			checkBoxResultBit23.AccessibleName = "Bit 23 of byte 3 in R";
			checkBoxResultBit23.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit23.AutoCheck = false;
			checkBoxResultBit23.Location = new Point(4, 38);
			checkBoxResultBit23.Name = "checkBoxResultBit23";
			checkBoxResultBit23.Size = new Size(19, 14);
			checkBoxResultBit23.TabIndex = 48;
			checkBoxResultBit23.ToolTipValues.Description = "Shows bit 23 of byte 3 in R";
			checkBoxResultBit23.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit23.ToolTipValues.Heading = "Bit 23 of byte 3 in R";
			checkBoxResultBit23.Values.Text = "";
			checkBoxResultBit23.Enter += Control_Enter;
			checkBoxResultBit23.Leave += Control_Leave;
			checkBoxResultBit23.MouseEnter += Control_Enter;
			checkBoxResultBit23.MouseLeave += Control_Leave;
			// 
			// checkBoxResultBit21
			// 
			checkBoxResultBit21.AccessibleDescription = "Shows bit 21 of byte 3 in R";
			checkBoxResultBit21.AccessibleName = "Bit 21 of byte 3 in R";
			checkBoxResultBit21.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit21.AutoCheck = false;
			checkBoxResultBit21.Location = new Point(48, 38);
			checkBoxResultBit21.Name = "checkBoxResultBit21";
			checkBoxResultBit21.Size = new Size(19, 14);
			checkBoxResultBit21.TabIndex = 44;
			checkBoxResultBit21.ToolTipValues.Description = "Shows bit 21 of byte 3 in R";
			checkBoxResultBit21.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit21.ToolTipValues.Heading = "Bit 21 of byte 3 in R";
			checkBoxResultBit21.Values.Text = "";
			checkBoxResultBit21.Enter += Control_Enter;
			checkBoxResultBit21.Leave += Control_Leave;
			checkBoxResultBit21.MouseEnter += Control_Enter;
			checkBoxResultBit21.MouseLeave += Control_Leave;
			// 
			// labelResultBit21
			// 
			labelResultBit21.AccessibleDescription = "Shows bit 21 of byte 3 in R";
			labelResultBit21.AccessibleName = "Bit 21 of byte 3 in R";
			labelResultBit21.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit21.Location = new Point(43, 18);
			labelResultBit21.Name = "labelResultBit21";
			labelResultBit21.Size = new Size(24, 20);
			labelResultBit21.TabIndex = 45;
			labelResultBit21.ToolTipValues.Description = "Shows bit 21 of byte 3 in R";
			labelResultBit21.ToolTipValues.EnableToolTips = true;
			labelResultBit21.ToolTipValues.Heading = "Bit 21 of byte 3 in R";
			labelResultBit21.Values.Text = "21";
			labelResultBit21.Enter += Control_Enter;
			labelResultBit21.Leave += Control_Leave;
			labelResultBit21.MouseEnter += Control_Enter;
			labelResultBit21.MouseLeave += Control_Leave;
			// 
			// labelResultBit20
			// 
			labelResultBit20.AccessibleDescription = "Shows bit 20 of byte 3 in R";
			labelResultBit20.AccessibleName = "Bit 20 of byte 3 in R";
			labelResultBit20.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit20.Location = new Point(65, 18);
			labelResultBit20.Name = "labelResultBit20";
			labelResultBit20.Size = new Size(24, 20);
			labelResultBit20.TabIndex = 43;
			labelResultBit20.ToolTipValues.Description = "Shows bit 20 of byte 3 in R";
			labelResultBit20.ToolTipValues.EnableToolTips = true;
			labelResultBit20.ToolTipValues.Heading = "Bit 20 of byte 3 in R";
			labelResultBit20.Values.Text = "20";
			labelResultBit20.Enter += Control_Enter;
			labelResultBit20.Leave += Control_Leave;
			labelResultBit20.MouseEnter += Control_Enter;
			labelResultBit20.MouseLeave += Control_Leave;
			// 
			// checkBoxResultBit22
			// 
			checkBoxResultBit22.AccessibleDescription = "Shows bit 22 of byte 3 in R";
			checkBoxResultBit22.AccessibleName = "Bit 22 of byte 3 in R";
			checkBoxResultBit22.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit22.AutoCheck = false;
			checkBoxResultBit22.Location = new Point(26, 38);
			checkBoxResultBit22.Name = "checkBoxResultBit22";
			checkBoxResultBit22.Size = new Size(19, 14);
			checkBoxResultBit22.TabIndex = 46;
			checkBoxResultBit22.ToolTipValues.Description = "Shows bit 22 of byte 3 in R";
			checkBoxResultBit22.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit22.ToolTipValues.Heading = "Bit 22 of byte 3 in R";
			checkBoxResultBit22.Values.Text = "";
			checkBoxResultBit22.Enter += Control_Enter;
			checkBoxResultBit22.Leave += Control_Leave;
			checkBoxResultBit22.MouseEnter += Control_Enter;
			checkBoxResultBit22.MouseLeave += Control_Leave;
			// 
			// checkBoxResultBit20
			// 
			checkBoxResultBit20.AccessibleDescription = "Shows bit 20 of byte 3 in R";
			checkBoxResultBit20.AccessibleName = "Bit 20 of byte 3 in R";
			checkBoxResultBit20.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit20.AutoCheck = false;
			checkBoxResultBit20.Location = new Point(70, 38);
			checkBoxResultBit20.Name = "checkBoxResultBit20";
			checkBoxResultBit20.Size = new Size(19, 14);
			checkBoxResultBit20.TabIndex = 42;
			checkBoxResultBit20.ToolTipValues.Description = "Shows bit 20 of byte 3 in R";
			checkBoxResultBit20.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit20.ToolTipValues.Heading = "Bit 20 of byte 3 in R";
			checkBoxResultBit20.Values.Text = "";
			checkBoxResultBit20.Enter += Control_Enter;
			checkBoxResultBit20.Leave += Control_Leave;
			checkBoxResultBit20.MouseEnter += Control_Enter;
			checkBoxResultBit20.MouseLeave += Control_Leave;
			// 
			// labelResultBit22
			// 
			labelResultBit22.AccessibleDescription = "Shows bit 22 of byte 3 in R";
			labelResultBit22.AccessibleName = "Bit 22 of byte 3 in R";
			labelResultBit22.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit22.Location = new Point(21, 18);
			labelResultBit22.Name = "labelResultBit22";
			labelResultBit22.Size = new Size(24, 20);
			labelResultBit22.TabIndex = 47;
			labelResultBit22.ToolTipValues.Description = "Shows bit 22 of byte 3 in R";
			labelResultBit22.ToolTipValues.EnableToolTips = true;
			labelResultBit22.ToolTipValues.Heading = "Bit 22 of byte 3 in R";
			labelResultBit22.Values.Text = "22";
			labelResultBit22.Enter += Control_Enter;
			labelResultBit22.Leave += Control_Leave;
			labelResultBit22.MouseEnter += Control_Enter;
			labelResultBit22.MouseLeave += Control_Leave;
			// 
			// labelResultBit19
			// 
			labelResultBit19.AccessibleDescription = "Shows bit 19 of byte 3 in R";
			labelResultBit19.AccessibleName = "Bit 19 of byte 3 in R";
			labelResultBit19.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit19.Location = new Point(100, 18);
			labelResultBit19.Name = "labelResultBit19";
			labelResultBit19.Size = new Size(24, 20);
			labelResultBit19.TabIndex = 41;
			labelResultBit19.ToolTipValues.Description = "Shows bit 19 of byte 3 in R";
			labelResultBit19.ToolTipValues.EnableToolTips = true;
			labelResultBit19.ToolTipValues.Heading = "Bit 19 of byte 3 in R";
			labelResultBit19.Values.Text = "19";
			labelResultBit19.Enter += Control_Enter;
			labelResultBit19.Leave += Control_Leave;
			labelResultBit19.MouseEnter += Control_Enter;
			labelResultBit19.MouseLeave += Control_Leave;
			// 
			// checkBoxResultBit16
			// 
			checkBoxResultBit16.AccessibleDescription = "Shows bit 16 of byte 3 in R";
			checkBoxResultBit16.AccessibleName = "Bit 16 of byte 3 in R";
			checkBoxResultBit16.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit16.AutoCheck = false;
			checkBoxResultBit16.Location = new Point(173, 38);
			checkBoxResultBit16.Name = "checkBoxResultBit16";
			checkBoxResultBit16.Size = new Size(19, 14);
			checkBoxResultBit16.TabIndex = 34;
			checkBoxResultBit16.ToolTipValues.Description = "Shows bit 16 of byte 3 in R";
			checkBoxResultBit16.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit16.ToolTipValues.Heading = "Bit 16 of byte 3 in R";
			checkBoxResultBit16.Values.Text = "";
			checkBoxResultBit16.Enter += Control_Enter;
			checkBoxResultBit16.Leave += Control_Leave;
			checkBoxResultBit16.MouseEnter += Control_Enter;
			checkBoxResultBit16.MouseLeave += Control_Leave;
			// 
			// checkBoxResultBit19
			// 
			checkBoxResultBit19.AccessibleDescription = "Shows bit 19 of byte 3 in R";
			checkBoxResultBit19.AccessibleName = "Bit 19 of byte 3 in R";
			checkBoxResultBit19.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit19.AutoCheck = false;
			checkBoxResultBit19.Location = new Point(106, 38);
			checkBoxResultBit19.Name = "checkBoxResultBit19";
			checkBoxResultBit19.Size = new Size(19, 14);
			checkBoxResultBit19.TabIndex = 40;
			checkBoxResultBit19.ToolTipValues.Description = "Shows bit 19 of byte 3 in R";
			checkBoxResultBit19.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit19.ToolTipValues.Heading = "Bit 19 of byte 3 in R";
			checkBoxResultBit19.Values.Text = "";
			checkBoxResultBit19.Enter += Control_Enter;
			checkBoxResultBit19.Leave += Control_Leave;
			checkBoxResultBit19.MouseEnter += Control_Enter;
			checkBoxResultBit19.MouseLeave += Control_Leave;
			// 
			// labelResultBit23
			// 
			labelResultBit23.AccessibleDescription = "Shows bit 23 of byte 3 in R";
			labelResultBit23.AccessibleName = "Bit 23 of byte 3 in R";
			labelResultBit23.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit23.Location = new Point(-1, 18);
			labelResultBit23.Name = "labelResultBit23";
			labelResultBit23.Size = new Size(24, 20);
			labelResultBit23.TabIndex = 49;
			labelResultBit23.ToolTipValues.Description = "Shows bit 23 of byte 3 in R";
			labelResultBit23.ToolTipValues.EnableToolTips = true;
			labelResultBit23.ToolTipValues.Heading = "Bit 23 of byte 3 in R";
			labelResultBit23.Values.Text = "23";
			labelResultBit23.Enter += Control_Enter;
			labelResultBit23.Leave += Control_Leave;
			labelResultBit23.MouseEnter += Control_Enter;
			labelResultBit23.MouseLeave += Control_Leave;
			// 
			// labelResultBit18
			// 
			labelResultBit18.AccessibleDescription = "Shows bit 18 of byte 3 in R";
			labelResultBit18.AccessibleName = "Bit 18 of byte 3 in R";
			labelResultBit18.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit18.Location = new Point(124, 18);
			labelResultBit18.Name = "labelResultBit18";
			labelResultBit18.Size = new Size(24, 20);
			labelResultBit18.TabIndex = 39;
			labelResultBit18.ToolTipValues.Description = "Shows bit 18 of byte 3 in R";
			labelResultBit18.ToolTipValues.EnableToolTips = true;
			labelResultBit18.ToolTipValues.Heading = "Bit 18 of byte 3 in R";
			labelResultBit18.Values.Text = "18";
			labelResultBit18.Enter += Control_Enter;
			labelResultBit18.Leave += Control_Leave;
			labelResultBit18.MouseEnter += Control_Enter;
			labelResultBit18.MouseLeave += Control_Leave;
			// 
			// labelResultBit16
			// 
			labelResultBit16.AccessibleDescription = "Shows bit 16 of byte 3 in R";
			labelResultBit16.AccessibleName = "Bit 16 of byte 3 in R";
			labelResultBit16.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit16.Location = new Point(167, 18);
			labelResultBit16.Name = "labelResultBit16";
			labelResultBit16.Size = new Size(24, 20);
			labelResultBit16.TabIndex = 35;
			labelResultBit16.ToolTipValues.Description = "Shows bit 16 of byte 3 in R";
			labelResultBit16.ToolTipValues.EnableToolTips = true;
			labelResultBit16.ToolTipValues.Heading = "Bit 16 of byte 3 in R";
			labelResultBit16.Values.Text = "16";
			labelResultBit16.Enter += Control_Enter;
			labelResultBit16.Leave += Control_Leave;
			labelResultBit16.MouseEnter += Control_Enter;
			labelResultBit16.MouseLeave += Control_Leave;
			// 
			// checkBoxResultBit18
			// 
			checkBoxResultBit18.AccessibleDescription = "Shows bit 18 of byte 3 in R";
			checkBoxResultBit18.AccessibleName = "Bit 18 of byte 3 in R";
			checkBoxResultBit18.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit18.AutoCheck = false;
			checkBoxResultBit18.Location = new Point(129, 38);
			checkBoxResultBit18.Name = "checkBoxResultBit18";
			checkBoxResultBit18.Size = new Size(19, 14);
			checkBoxResultBit18.TabIndex = 38;
			checkBoxResultBit18.ToolTipValues.Description = "Shows bit 18 of byte 3 in R";
			checkBoxResultBit18.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit18.ToolTipValues.Heading = "Bit 18 of byte 3 in R";
			checkBoxResultBit18.Values.Text = "";
			checkBoxResultBit18.Enter += Control_Enter;
			checkBoxResultBit18.Leave += Control_Leave;
			checkBoxResultBit18.MouseEnter += Control_Enter;
			checkBoxResultBit18.MouseLeave += Control_Leave;
			// 
			// labelResultBit17
			// 
			labelResultBit17.AccessibleDescription = "Shows bit 17 of byte 3 in R";
			labelResultBit17.AccessibleName = "Bit 17 of byte 3 in R";
			labelResultBit17.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit17.Location = new Point(146, 18);
			labelResultBit17.Name = "labelResultBit17";
			labelResultBit17.Size = new Size(24, 20);
			labelResultBit17.TabIndex = 37;
			labelResultBit17.ToolTipValues.Description = "Shows bit 17 of byte 3 in R";
			labelResultBit17.ToolTipValues.EnableToolTips = true;
			labelResultBit17.ToolTipValues.Heading = "Bit 17 of byte 3 in R";
			labelResultBit17.Values.Text = "17";
			labelResultBit17.Enter += Control_Enter;
			labelResultBit17.Leave += Control_Leave;
			labelResultBit17.MouseEnter += Control_Enter;
			labelResultBit17.MouseLeave += Control_Leave;
			// 
			// checkBoxResultBit17
			// 
			checkBoxResultBit17.AccessibleDescription = "Shows bit 17 of byte 3 in R";
			checkBoxResultBit17.AccessibleName = "Bit 17 of byte 3 in R";
			checkBoxResultBit17.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit17.AutoCheck = false;
			checkBoxResultBit17.Location = new Point(151, 38);
			checkBoxResultBit17.Name = "checkBoxResultBit17";
			checkBoxResultBit17.Size = new Size(19, 14);
			checkBoxResultBit17.TabIndex = 36;
			checkBoxResultBit17.ToolTipValues.Description = "Shows bit 17 of byte 3 in R";
			checkBoxResultBit17.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit17.ToolTipValues.Heading = "Bit 17 of byte 3 in R";
			checkBoxResultBit17.Values.Text = "";
			checkBoxResultBit17.Enter += Control_Enter;
			checkBoxResultBit17.Leave += Control_Leave;
			checkBoxResultBit17.MouseEnter += Control_Enter;
			checkBoxResultBit17.MouseLeave += Control_Leave;
			// 
			// groupBoxResultByte2
			// 
			groupBoxResultByte2.AccessibleDescription = "Groups the elements of byte 2 in R";
			groupBoxResultByte2.AccessibleName = "Elements of byte 2 in R";
			groupBoxResultByte2.AccessibleRole = AccessibleRole.Grouping;
			groupBoxResultByte2.Controls.Add(checkBoxResultBit15);
			groupBoxResultByte2.Controls.Add(checkBoxResultBit10);
			groupBoxResultByte2.Controls.Add(labelResultBit10);
			groupBoxResultByte2.Controls.Add(labelResultBit09);
			groupBoxResultByte2.Controls.Add(checkBoxResultBit11);
			groupBoxResultByte2.Controls.Add(checkBoxResultBit09);
			groupBoxResultByte2.Controls.Add(labelResultBit11);
			groupBoxResultByte2.Controls.Add(labelResultBit15);
			groupBoxResultByte2.Controls.Add(labelResultBit08);
			groupBoxResultByte2.Controls.Add(checkBoxResultBit12);
			groupBoxResultByte2.Controls.Add(checkBoxResultBit08);
			groupBoxResultByte2.Controls.Add(labelResultBit12);
			groupBoxResultByte2.Controls.Add(checkBoxResultBit13);
			groupBoxResultByte2.Controls.Add(labelResultBit13);
			groupBoxResultByte2.Controls.Add(checkBoxResultBit14);
			groupBoxResultByte2.Controls.Add(labelResultBit14);
			groupBoxResultByte2.Location = new Point(415, 66);
			groupBoxResultByte2.Name = "groupBoxResultByte2";
			groupBoxResultByte2.Size = new Size(196, 62);
			groupBoxResultByte2.TabIndex = 67;
			groupBoxResultByte2.TabStop = false;
			groupBoxResultByte2.Text = "Byte 2";
			// 
			// checkBoxResultBit15
			// 
			checkBoxResultBit15.AccessibleDescription = "Shows bit 15 of byte 2 in R";
			checkBoxResultBit15.AccessibleName = "Bit 15 of byte 2 in R";
			checkBoxResultBit15.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit15.AutoCheck = false;
			checkBoxResultBit15.Location = new Point(4, 38);
			checkBoxResultBit15.Name = "checkBoxResultBit15";
			checkBoxResultBit15.Size = new Size(19, 14);
			checkBoxResultBit15.TabIndex = 32;
			checkBoxResultBit15.ToolTipValues.Description = "Shows bit 15 of byte 2 in R";
			checkBoxResultBit15.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit15.ToolTipValues.Heading = "Bit 15 of byte 2 in R";
			checkBoxResultBit15.Values.Text = "";
			checkBoxResultBit15.Enter += Control_Enter;
			checkBoxResultBit15.Leave += Control_Leave;
			checkBoxResultBit15.MouseEnter += Control_Enter;
			checkBoxResultBit15.MouseLeave += Control_Leave;
			// 
			// checkBoxResultBit10
			// 
			checkBoxResultBit10.AccessibleDescription = "Shows bit 10 of byte 2 in R";
			checkBoxResultBit10.AccessibleName = "Bit 10 of byte 2 in R";
			checkBoxResultBit10.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit10.AutoCheck = false;
			checkBoxResultBit10.Location = new Point(129, 38);
			checkBoxResultBit10.Name = "checkBoxResultBit10";
			checkBoxResultBit10.Size = new Size(19, 14);
			checkBoxResultBit10.TabIndex = 22;
			checkBoxResultBit10.ToolTipValues.Description = "Shows bit 10 of byte 2 in R";
			checkBoxResultBit10.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit10.ToolTipValues.Heading = "Bit 10 of byte 2 in R";
			checkBoxResultBit10.Values.Text = "";
			checkBoxResultBit10.Enter += Control_Enter;
			checkBoxResultBit10.Leave += Control_Leave;
			checkBoxResultBit10.MouseEnter += Control_Enter;
			checkBoxResultBit10.MouseLeave += Control_Leave;
			// 
			// labelResultBit10
			// 
			labelResultBit10.AccessibleDescription = "Shows bit 10 of byte 2 in R";
			labelResultBit10.AccessibleName = "Bit 10 of byte 2 in R";
			labelResultBit10.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit10.Location = new Point(124, 18);
			labelResultBit10.Name = "labelResultBit10";
			labelResultBit10.Size = new Size(24, 20);
			labelResultBit10.TabIndex = 23;
			labelResultBit10.ToolTipValues.Description = "Shows bit 10 of byte 2 in R";
			labelResultBit10.ToolTipValues.EnableToolTips = true;
			labelResultBit10.ToolTipValues.Heading = "Bit 10 of byte 2 in R";
			labelResultBit10.Values.Text = "10";
			labelResultBit10.Enter += Control_Enter;
			labelResultBit10.Leave += Control_Leave;
			labelResultBit10.MouseEnter += Control_Enter;
			labelResultBit10.MouseLeave += Control_Leave;
			// 
			// labelResultBit09
			// 
			labelResultBit09.AccessibleDescription = "Shows bit 09 of byte 2 in R";
			labelResultBit09.AccessibleName = "Bit 09 of byte 2 in R";
			labelResultBit09.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit09.Location = new Point(146, 18);
			labelResultBit09.Name = "labelResultBit09";
			labelResultBit09.Size = new Size(24, 20);
			labelResultBit09.TabIndex = 21;
			labelResultBit09.ToolTipValues.Description = "Shows bit 09 of byte 2 in R";
			labelResultBit09.ToolTipValues.EnableToolTips = true;
			labelResultBit09.ToolTipValues.Heading = "Bit 09 of byte 2 in R";
			labelResultBit09.Values.Text = "09";
			labelResultBit09.Enter += Control_Enter;
			labelResultBit09.Leave += Control_Leave;
			labelResultBit09.MouseEnter += Control_Enter;
			labelResultBit09.MouseLeave += Control_Leave;
			// 
			// checkBoxResultBit11
			// 
			checkBoxResultBit11.AccessibleDescription = "Shows bit 11 of byte 2 in R";
			checkBoxResultBit11.AccessibleName = "Bit 11 of byte 2 in R";
			checkBoxResultBit11.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit11.AutoCheck = false;
			checkBoxResultBit11.Location = new Point(106, 38);
			checkBoxResultBit11.Name = "checkBoxResultBit11";
			checkBoxResultBit11.Size = new Size(19, 14);
			checkBoxResultBit11.TabIndex = 24;
			checkBoxResultBit11.ToolTipValues.Description = "Shows bit 11 of byte 2 in R";
			checkBoxResultBit11.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit11.ToolTipValues.Heading = "Bit 11 of byte 2 in R";
			checkBoxResultBit11.Values.Text = "";
			checkBoxResultBit11.Enter += Control_Enter;
			checkBoxResultBit11.Leave += Control_Leave;
			checkBoxResultBit11.MouseEnter += Control_Enter;
			checkBoxResultBit11.MouseLeave += Control_Leave;
			// 
			// checkBoxResultBit09
			// 
			checkBoxResultBit09.AccessibleDescription = "Shows bit 09 of byte 2 in R";
			checkBoxResultBit09.AccessibleName = "Bit 09 of byte 2 in R";
			checkBoxResultBit09.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit09.AutoCheck = false;
			checkBoxResultBit09.Location = new Point(151, 38);
			checkBoxResultBit09.Name = "checkBoxResultBit09";
			checkBoxResultBit09.Size = new Size(19, 14);
			checkBoxResultBit09.TabIndex = 20;
			checkBoxResultBit09.ToolTipValues.Description = "Shows bit 09 of byte 2 in R";
			checkBoxResultBit09.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit09.ToolTipValues.Heading = "Bit 09 of byte 2 in R";
			checkBoxResultBit09.Values.Text = "";
			checkBoxResultBit09.Enter += Control_Enter;
			checkBoxResultBit09.Leave += Control_Leave;
			checkBoxResultBit09.MouseEnter += Control_Enter;
			checkBoxResultBit09.MouseLeave += Control_Leave;
			// 
			// labelResultBit11
			// 
			labelResultBit11.AccessibleDescription = "Shows bit 11 of byte 2 in R";
			labelResultBit11.AccessibleName = "Bit 11 of byte 2 in R";
			labelResultBit11.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit11.Location = new Point(100, 18);
			labelResultBit11.Name = "labelResultBit11";
			labelResultBit11.Size = new Size(24, 20);
			labelResultBit11.TabIndex = 25;
			labelResultBit11.ToolTipValues.Description = "Shows bit 11 of byte 2 in R";
			labelResultBit11.ToolTipValues.EnableToolTips = true;
			labelResultBit11.ToolTipValues.Heading = "Bit 11 of byte 2 in R";
			labelResultBit11.Values.Text = "11";
			labelResultBit11.Enter += Control_Enter;
			labelResultBit11.Leave += Control_Leave;
			labelResultBit11.MouseEnter += Control_Enter;
			labelResultBit11.MouseLeave += Control_Leave;
			// 
			// labelResultBit15
			// 
			labelResultBit15.AccessibleDescription = "Shows bit 15 of byte 2 in R";
			labelResultBit15.AccessibleName = "Bit 15 of byte 2 in R";
			labelResultBit15.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit15.Location = new Point(-1, 18);
			labelResultBit15.Name = "labelResultBit15";
			labelResultBit15.Size = new Size(24, 20);
			labelResultBit15.TabIndex = 33;
			labelResultBit15.ToolTipValues.Description = "Shows bit 15 of byte 2 in R";
			labelResultBit15.ToolTipValues.EnableToolTips = true;
			labelResultBit15.ToolTipValues.Heading = "Bit 15 of byte 2 in R";
			labelResultBit15.Values.Text = "15";
			labelResultBit15.Enter += Control_Enter;
			labelResultBit15.Leave += Control_Leave;
			labelResultBit15.MouseEnter += Control_Enter;
			labelResultBit15.MouseLeave += Control_Leave;
			// 
			// labelResultBit08
			// 
			labelResultBit08.AccessibleDescription = "Shows bit 08 of byte 2 in R";
			labelResultBit08.AccessibleName = "Bit 08 of byte 2 in R";
			labelResultBit08.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit08.Location = new Point(167, 18);
			labelResultBit08.Name = "labelResultBit08";
			labelResultBit08.Size = new Size(24, 20);
			labelResultBit08.TabIndex = 19;
			labelResultBit08.ToolTipValues.Description = "Shows bit 08 of byte 2 in R";
			labelResultBit08.ToolTipValues.EnableToolTips = true;
			labelResultBit08.ToolTipValues.Heading = "Bit 08 of byte 2 in R";
			labelResultBit08.Values.Text = "08";
			labelResultBit08.Enter += Control_Enter;
			labelResultBit08.Leave += Control_Leave;
			labelResultBit08.MouseEnter += Control_Enter;
			labelResultBit08.MouseLeave += Control_Leave;
			// 
			// checkBoxResultBit12
			// 
			checkBoxResultBit12.AccessibleDescription = "Shows bit 12 of byte 2 in R";
			checkBoxResultBit12.AccessibleName = "Bit 12 of byte 2 in R";
			checkBoxResultBit12.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit12.AutoCheck = false;
			checkBoxResultBit12.Location = new Point(70, 38);
			checkBoxResultBit12.Name = "checkBoxResultBit12";
			checkBoxResultBit12.Size = new Size(19, 14);
			checkBoxResultBit12.TabIndex = 26;
			checkBoxResultBit12.ToolTipValues.Description = "Shows bit 12 of byte 2 in R";
			checkBoxResultBit12.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit12.ToolTipValues.Heading = "Bit 12 of byte 2 in R";
			checkBoxResultBit12.Values.Text = "";
			checkBoxResultBit12.Enter += Control_Enter;
			checkBoxResultBit12.Leave += Control_Leave;
			checkBoxResultBit12.MouseEnter += Control_Enter;
			checkBoxResultBit12.MouseLeave += Control_Leave;
			// 
			// checkBoxResultBit08
			// 
			checkBoxResultBit08.AccessibleDescription = "Shows bit 08 of byte 2 in R";
			checkBoxResultBit08.AccessibleName = "Bit 08 of byte 2 in R";
			checkBoxResultBit08.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit08.AutoCheck = false;
			checkBoxResultBit08.Location = new Point(173, 38);
			checkBoxResultBit08.Name = "checkBoxResultBit08";
			checkBoxResultBit08.Size = new Size(19, 14);
			checkBoxResultBit08.TabIndex = 18;
			checkBoxResultBit08.ToolTipValues.Description = "Shows bit 08 of byte 2 in R";
			checkBoxResultBit08.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit08.ToolTipValues.Heading = "Bit 08 of byte 2 in R";
			checkBoxResultBit08.Values.Text = "";
			checkBoxResultBit08.Enter += Control_Enter;
			checkBoxResultBit08.Leave += Control_Leave;
			checkBoxResultBit08.MouseEnter += Control_Enter;
			checkBoxResultBit08.MouseLeave += Control_Leave;
			// 
			// labelResultBit12
			// 
			labelResultBit12.AccessibleDescription = "Shows bit 12 of byte 2 in R";
			labelResultBit12.AccessibleName = "Bit 12 of byte 2 in R";
			labelResultBit12.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit12.Location = new Point(65, 18);
			labelResultBit12.Name = "labelResultBit12";
			labelResultBit12.Size = new Size(24, 20);
			labelResultBit12.TabIndex = 27;
			labelResultBit12.ToolTipValues.Description = "Shows bit 12 of byte 2 in R";
			labelResultBit12.ToolTipValues.EnableToolTips = true;
			labelResultBit12.ToolTipValues.Heading = "Bit 12 of byte 2 in R";
			labelResultBit12.Values.Text = "12";
			labelResultBit12.Enter += Control_Enter;
			labelResultBit12.Leave += Control_Leave;
			labelResultBit12.MouseEnter += Control_Enter;
			labelResultBit12.MouseLeave += Control_Leave;
			// 
			// checkBoxResultBit13
			// 
			checkBoxResultBit13.AccessibleDescription = "Shows bit 13 of byte 2 in R";
			checkBoxResultBit13.AccessibleName = "Bit 13 of byte 2 in R";
			checkBoxResultBit13.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit13.AutoCheck = false;
			checkBoxResultBit13.Location = new Point(48, 38);
			checkBoxResultBit13.Name = "checkBoxResultBit13";
			checkBoxResultBit13.Size = new Size(19, 14);
			checkBoxResultBit13.TabIndex = 28;
			checkBoxResultBit13.ToolTipValues.Description = "Shows bit 13 of byte 2 in R";
			checkBoxResultBit13.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit13.ToolTipValues.Heading = "Bit 13 of byte 2 in R";
			checkBoxResultBit13.Values.Text = "";
			checkBoxResultBit13.Enter += Control_Enter;
			checkBoxResultBit13.Leave += Control_Leave;
			checkBoxResultBit13.MouseEnter += Control_Enter;
			checkBoxResultBit13.MouseLeave += Control_Leave;
			// 
			// labelResultBit13
			// 
			labelResultBit13.AccessibleDescription = "Shows bit 13 of byte 2 in R";
			labelResultBit13.AccessibleName = "Bit 13 of byte 2 in R";
			labelResultBit13.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit13.Location = new Point(43, 18);
			labelResultBit13.Name = "labelResultBit13";
			labelResultBit13.Size = new Size(24, 20);
			labelResultBit13.TabIndex = 29;
			labelResultBit13.ToolTipValues.Description = "Shows bit 13 of byte 2 in R";
			labelResultBit13.ToolTipValues.EnableToolTips = true;
			labelResultBit13.ToolTipValues.Heading = "Bit 13 of byte 2 in R";
			labelResultBit13.Values.Text = "13";
			labelResultBit13.Enter += Control_Enter;
			labelResultBit13.Leave += Control_Leave;
			labelResultBit13.MouseEnter += Control_Enter;
			labelResultBit13.MouseLeave += Control_Leave;
			// 
			// checkBoxResultBit14
			// 
			checkBoxResultBit14.AccessibleDescription = "Shows bit 14 of byte 2 in R";
			checkBoxResultBit14.AccessibleName = "Bit 14 of byte 2 in R";
			checkBoxResultBit14.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit14.AutoCheck = false;
			checkBoxResultBit14.Location = new Point(26, 38);
			checkBoxResultBit14.Name = "checkBoxResultBit14";
			checkBoxResultBit14.Size = new Size(19, 14);
			checkBoxResultBit14.TabIndex = 30;
			checkBoxResultBit14.ToolTipValues.Description = "Shows bit 14 of byte 2 in R";
			checkBoxResultBit14.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit14.ToolTipValues.Heading = "Bit 14 of byte 2 in R";
			checkBoxResultBit14.Values.Text = "";
			checkBoxResultBit14.Enter += Control_Enter;
			checkBoxResultBit14.Leave += Control_Leave;
			checkBoxResultBit14.MouseEnter += Control_Enter;
			checkBoxResultBit14.MouseLeave += Control_Leave;
			// 
			// labelResultBit14
			// 
			labelResultBit14.AccessibleDescription = "Shows bit 14 of byte 2 in R";
			labelResultBit14.AccessibleName = "Bit 14 of byte 2 in R";
			labelResultBit14.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit14.Location = new Point(21, 18);
			labelResultBit14.Name = "labelResultBit14";
			labelResultBit14.Size = new Size(24, 20);
			labelResultBit14.TabIndex = 31;
			labelResultBit14.ToolTipValues.Description = "Shows bit 14 of byte 2 in R";
			labelResultBit14.ToolTipValues.EnableToolTips = true;
			labelResultBit14.ToolTipValues.Heading = "Bit 14 of byte 2 in R";
			labelResultBit14.Values.Text = "14";
			labelResultBit14.Enter += Control_Enter;
			labelResultBit14.Leave += Control_Leave;
			labelResultBit14.MouseEnter += Control_Enter;
			labelResultBit14.MouseLeave += Control_Leave;
			// 
			// groupBoxResultByte1
			// 
			groupBoxResultByte1.AccessibleDescription = "Groups the elements of byte 1 in R";
			groupBoxResultByte1.AccessibleName = "Elements of byte 1 in R";
			groupBoxResultByte1.AccessibleRole = AccessibleRole.Grouping;
			groupBoxResultByte1.Controls.Add(labelResultBit07);
			groupBoxResultByte1.Controls.Add(checkBoxResultBit07);
			groupBoxResultByte1.Controls.Add(labelResultBit06);
			groupBoxResultByte1.Controls.Add(checkBoxResultBit00);
			groupBoxResultByte1.Controls.Add(checkBoxResultBit06);
			groupBoxResultByte1.Controls.Add(labelResultBit00);
			groupBoxResultByte1.Controls.Add(labelResultBit05);
			groupBoxResultByte1.Controls.Add(checkBoxResultBit05);
			groupBoxResultByte1.Controls.Add(checkBoxResultBit01);
			groupBoxResultByte1.Controls.Add(labelResultBit04);
			groupBoxResultByte1.Controls.Add(checkBoxResultBit04);
			groupBoxResultByte1.Controls.Add(labelResultBit01);
			groupBoxResultByte1.Controls.Add(labelResultBit03);
			groupBoxResultByte1.Controls.Add(checkBoxResultBit03);
			groupBoxResultByte1.Controls.Add(checkBoxResultBit02);
			groupBoxResultByte1.Controls.Add(labelResultBit02);
			groupBoxResultByte1.Location = new Point(618, 66);
			groupBoxResultByte1.Name = "groupBoxResultByte1";
			groupBoxResultByte1.Size = new Size(196, 62);
			groupBoxResultByte1.TabIndex = 66;
			groupBoxResultByte1.TabStop = false;
			groupBoxResultByte1.Text = "Byte 1";
			// 
			// labelResultBit07
			// 
			labelResultBit07.AccessibleDescription = "Shows bit 07 of byte 1 in R";
			labelResultBit07.AccessibleName = "Bit 07 of byte 1 in R";
			labelResultBit07.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit07.Location = new Point(-1, 18);
			labelResultBit07.Name = "labelResultBit07";
			labelResultBit07.Size = new Size(24, 20);
			labelResultBit07.TabIndex = 17;
			labelResultBit07.ToolTipValues.Description = "Shows bit 07 of byte 1 in R";
			labelResultBit07.ToolTipValues.EnableToolTips = true;
			labelResultBit07.ToolTipValues.Heading = "Bit 07 of byte 1 in R";
			labelResultBit07.Values.Text = "07";
			labelResultBit07.Enter += Control_Enter;
			labelResultBit07.Leave += Control_Leave;
			labelResultBit07.MouseEnter += Control_Enter;
			labelResultBit07.MouseLeave += Control_Leave;
			// 
			// checkBoxResultBit07
			// 
			checkBoxResultBit07.AccessibleDescription = "Shows bit 07 of byte 1 in R";
			checkBoxResultBit07.AccessibleName = "Bit 07 of byte 1 in R";
			checkBoxResultBit07.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit07.AutoCheck = false;
			checkBoxResultBit07.Location = new Point(4, 38);
			checkBoxResultBit07.Name = "checkBoxResultBit07";
			checkBoxResultBit07.Size = new Size(19, 14);
			checkBoxResultBit07.TabIndex = 16;
			checkBoxResultBit07.ToolTipValues.Description = "Shows bit 07 of byte 1 in R";
			checkBoxResultBit07.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit07.ToolTipValues.Heading = "Bit 07 of byte 1 in R";
			checkBoxResultBit07.Values.Text = "";
			checkBoxResultBit07.Enter += Control_Enter;
			checkBoxResultBit07.Leave += Control_Leave;
			checkBoxResultBit07.MouseEnter += Control_Enter;
			checkBoxResultBit07.MouseLeave += Control_Leave;
			// 
			// labelResultBit06
			// 
			labelResultBit06.AccessibleDescription = "Shows bit 06 of byte 1 in R";
			labelResultBit06.AccessibleName = "Bit 06 of byte 1 in R";
			labelResultBit06.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit06.Location = new Point(21, 18);
			labelResultBit06.Name = "labelResultBit06";
			labelResultBit06.Size = new Size(24, 20);
			labelResultBit06.TabIndex = 15;
			labelResultBit06.ToolTipValues.Description = "Shows bit 06 of byte 1 in R";
			labelResultBit06.ToolTipValues.EnableToolTips = true;
			labelResultBit06.ToolTipValues.Heading = "Bit 06 of byte 1 in R";
			labelResultBit06.Values.Text = "06";
			labelResultBit06.Enter += Control_Enter;
			labelResultBit06.Leave += Control_Leave;
			labelResultBit06.MouseEnter += Control_Enter;
			labelResultBit06.MouseLeave += Control_Leave;
			// 
			// checkBoxResultBit00
			// 
			checkBoxResultBit00.AccessibleDescription = "Shows bit 00 of byte 1 in R";
			checkBoxResultBit00.AccessibleName = "Bit 00 of byte 1 in R";
			checkBoxResultBit00.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit00.AutoCheck = false;
			checkBoxResultBit00.Location = new Point(173, 38);
			checkBoxResultBit00.Name = "checkBoxResultBit00";
			checkBoxResultBit00.Size = new Size(19, 14);
			checkBoxResultBit00.TabIndex = 0;
			checkBoxResultBit00.ToolTipValues.Description = "Shows bit 00 of byte 1 in R";
			checkBoxResultBit00.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit00.ToolTipValues.Heading = "Bit 00 of byte 1 in R";
			checkBoxResultBit00.Values.Text = "";
			checkBoxResultBit00.Enter += Control_Enter;
			checkBoxResultBit00.Leave += Control_Leave;
			checkBoxResultBit00.MouseEnter += Control_Enter;
			checkBoxResultBit00.MouseLeave += Control_Leave;
			// 
			// checkBoxResultBit06
			// 
			checkBoxResultBit06.AccessibleDescription = "Shows bit 06 of byte 1 in R";
			checkBoxResultBit06.AccessibleName = "Bit 06 of byte 1 in R";
			checkBoxResultBit06.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit06.AutoCheck = false;
			checkBoxResultBit06.Location = new Point(26, 38);
			checkBoxResultBit06.Name = "checkBoxResultBit06";
			checkBoxResultBit06.Size = new Size(19, 14);
			checkBoxResultBit06.TabIndex = 14;
			checkBoxResultBit06.ToolTipValues.Description = "Shows bit 06 of byte 1 in R";
			checkBoxResultBit06.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit06.ToolTipValues.Heading = "Bit 06 of byte 1 in R";
			checkBoxResultBit06.Values.Text = "";
			checkBoxResultBit06.Enter += Control_Enter;
			checkBoxResultBit06.Leave += Control_Leave;
			checkBoxResultBit06.MouseEnter += Control_Enter;
			checkBoxResultBit06.MouseLeave += Control_Leave;
			// 
			// labelResultBit00
			// 
			labelResultBit00.AccessibleDescription = "Shows bit 00 of byte 1 in R";
			labelResultBit00.AccessibleName = "Bit 00 of byte 1 in R";
			labelResultBit00.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit00.Location = new Point(167, 18);
			labelResultBit00.Name = "labelResultBit00";
			labelResultBit00.Size = new Size(24, 20);
			labelResultBit00.TabIndex = 1;
			labelResultBit00.ToolTipValues.Description = "Shows bit 00 of byte 1 in R";
			labelResultBit00.ToolTipValues.EnableToolTips = true;
			labelResultBit00.ToolTipValues.Heading = "Bit 00 of byte 1 in R";
			labelResultBit00.Values.Text = "00";
			labelResultBit00.Enter += Control_Enter;
			labelResultBit00.Leave += Control_Leave;
			labelResultBit00.MouseEnter += Control_Enter;
			labelResultBit00.MouseLeave += Control_Leave;
			// 
			// labelResultBit05
			// 
			labelResultBit05.AccessibleDescription = "Shows bit 05 of byte 1 in R";
			labelResultBit05.AccessibleName = "Bit 05 of byte 1 in R";
			labelResultBit05.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit05.Location = new Point(43, 18);
			labelResultBit05.Name = "labelResultBit05";
			labelResultBit05.Size = new Size(24, 20);
			labelResultBit05.TabIndex = 13;
			labelResultBit05.ToolTipValues.Description = "Shows bit 05 of byte 1 in R";
			labelResultBit05.ToolTipValues.EnableToolTips = true;
			labelResultBit05.ToolTipValues.Heading = "Bit 05 of byte 1 in R";
			labelResultBit05.Values.Text = "05";
			labelResultBit05.Enter += Control_Enter;
			labelResultBit05.Leave += Control_Leave;
			labelResultBit05.MouseEnter += Control_Enter;
			labelResultBit05.MouseLeave += Control_Leave;
			// 
			// checkBoxResultBit05
			// 
			checkBoxResultBit05.AccessibleDescription = "Shows bit 05 of byte 1 in R";
			checkBoxResultBit05.AccessibleName = "Bit 05 of byte 1 in R";
			checkBoxResultBit05.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit05.AutoCheck = false;
			checkBoxResultBit05.Location = new Point(48, 38);
			checkBoxResultBit05.Name = "checkBoxResultBit05";
			checkBoxResultBit05.Size = new Size(19, 14);
			checkBoxResultBit05.TabIndex = 12;
			checkBoxResultBit05.ToolTipValues.Description = "Shows bit 05 of byte 1 in R";
			checkBoxResultBit05.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit05.ToolTipValues.Heading = "Bit 05 of byte 1 in R";
			checkBoxResultBit05.Values.Text = "";
			checkBoxResultBit05.Enter += Control_Enter;
			checkBoxResultBit05.Leave += Control_Leave;
			checkBoxResultBit05.MouseEnter += Control_Enter;
			checkBoxResultBit05.MouseLeave += Control_Leave;
			// 
			// checkBoxResultBit01
			// 
			checkBoxResultBit01.AccessibleDescription = "Shows bit 01 of byte 1 in R";
			checkBoxResultBit01.AccessibleName = "Bit 01 of byte 1 in R";
			checkBoxResultBit01.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit01.AutoCheck = false;
			checkBoxResultBit01.Location = new Point(151, 38);
			checkBoxResultBit01.Name = "checkBoxResultBit01";
			checkBoxResultBit01.Size = new Size(19, 14);
			checkBoxResultBit01.TabIndex = 2;
			checkBoxResultBit01.ToolTipValues.Description = "Shows bit 01 of byte 1 in R";
			checkBoxResultBit01.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit01.ToolTipValues.Heading = "Bit 01 of byte 1 in R";
			checkBoxResultBit01.Values.Text = "";
			checkBoxResultBit01.Enter += Control_Enter;
			checkBoxResultBit01.Leave += Control_Leave;
			checkBoxResultBit01.MouseEnter += Control_Enter;
			checkBoxResultBit01.MouseLeave += Control_Leave;
			// 
			// labelResultBit04
			// 
			labelResultBit04.AccessibleDescription = "Shows bit 04 of byte 1 in R";
			labelResultBit04.AccessibleName = "Bit 04 of byte 1 in R";
			labelResultBit04.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit04.Location = new Point(65, 18);
			labelResultBit04.Name = "labelResultBit04";
			labelResultBit04.Size = new Size(24, 20);
			labelResultBit04.TabIndex = 11;
			labelResultBit04.ToolTipValues.Description = "Shows bit 04 of byte 1 in R";
			labelResultBit04.ToolTipValues.EnableToolTips = true;
			labelResultBit04.ToolTipValues.Heading = "Bit 04 of byte 1 in R";
			labelResultBit04.Values.Text = "04";
			labelResultBit04.Enter += Control_Enter;
			labelResultBit04.Leave += Control_Leave;
			labelResultBit04.MouseEnter += Control_Enter;
			labelResultBit04.MouseLeave += Control_Leave;
			// 
			// checkBoxResultBit04
			// 
			checkBoxResultBit04.AccessibleDescription = "Shows bit 04 of byte 1 in R";
			checkBoxResultBit04.AccessibleName = "Bit 04 of byte 1 in R";
			checkBoxResultBit04.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit04.AutoCheck = false;
			checkBoxResultBit04.Location = new Point(70, 38);
			checkBoxResultBit04.Name = "checkBoxResultBit04";
			checkBoxResultBit04.Size = new Size(19, 14);
			checkBoxResultBit04.TabIndex = 10;
			checkBoxResultBit04.ToolTipValues.Description = "Shows bit 04 of byte 1 in R";
			checkBoxResultBit04.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit04.ToolTipValues.Heading = "Bit 04 of byte 1 in R";
			checkBoxResultBit04.Values.Text = "";
			checkBoxResultBit04.Enter += Control_Enter;
			checkBoxResultBit04.Leave += Control_Leave;
			checkBoxResultBit04.MouseEnter += Control_Enter;
			checkBoxResultBit04.MouseLeave += Control_Leave;
			// 
			// labelResultBit01
			// 
			labelResultBit01.AccessibleDescription = "Shows bit 01 of byte 1 in R";
			labelResultBit01.AccessibleName = "Bit 01 of byte 1 in R";
			labelResultBit01.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit01.Location = new Point(146, 18);
			labelResultBit01.Name = "labelResultBit01";
			labelResultBit01.Size = new Size(24, 20);
			labelResultBit01.TabIndex = 3;
			labelResultBit01.ToolTipValues.Description = "Shows bit 01 of byte 1 in R";
			labelResultBit01.ToolTipValues.EnableToolTips = true;
			labelResultBit01.ToolTipValues.Heading = "Bit 01 of byte 1 in R";
			labelResultBit01.Values.Text = "01";
			labelResultBit01.Enter += Control_Enter;
			labelResultBit01.Leave += Control_Leave;
			labelResultBit01.MouseEnter += Control_Enter;
			labelResultBit01.MouseLeave += Control_Leave;
			// 
			// labelResultBit03
			// 
			labelResultBit03.AccessibleDescription = "Shows bit 03 of byte 1 in R";
			labelResultBit03.AccessibleName = "Bit 03 of byte 1 in R";
			labelResultBit03.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit03.Location = new Point(100, 18);
			labelResultBit03.Name = "labelResultBit03";
			labelResultBit03.Size = new Size(24, 20);
			labelResultBit03.TabIndex = 7;
			labelResultBit03.ToolTipValues.Description = "Shows bit 03 of byte 1 in R";
			labelResultBit03.ToolTipValues.EnableToolTips = true;
			labelResultBit03.ToolTipValues.Heading = "Bit 03 of byte 1 in R";
			labelResultBit03.Values.Text = "03";
			labelResultBit03.Enter += Control_Enter;
			labelResultBit03.Leave += Control_Leave;
			labelResultBit03.MouseEnter += Control_Enter;
			labelResultBit03.MouseLeave += Control_Leave;
			// 
			// checkBoxResultBit03
			// 
			checkBoxResultBit03.AccessibleDescription = "Shows bit 03 of byte 1 in R";
			checkBoxResultBit03.AccessibleName = "Bit 03 of byte 1 in R";
			checkBoxResultBit03.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit03.AutoCheck = false;
			checkBoxResultBit03.Location = new Point(106, 38);
			checkBoxResultBit03.Name = "checkBoxResultBit03";
			checkBoxResultBit03.Size = new Size(19, 14);
			checkBoxResultBit03.TabIndex = 6;
			checkBoxResultBit03.ToolTipValues.Description = "Shows bit 03 of byte 1 in R";
			checkBoxResultBit03.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit03.ToolTipValues.Heading = "Bit 03 of byte 1 in R";
			checkBoxResultBit03.Values.Text = "";
			checkBoxResultBit03.Enter += Control_Enter;
			checkBoxResultBit03.Leave += Control_Leave;
			checkBoxResultBit03.MouseEnter += Control_Enter;
			checkBoxResultBit03.MouseLeave += Control_Leave;
			// 
			// checkBoxResultBit02
			// 
			checkBoxResultBit02.AccessibleDescription = "Shows bit 02 of byte 1 in R";
			checkBoxResultBit02.AccessibleName = "Bit 02 of byte 1 in R";
			checkBoxResultBit02.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxResultBit02.AutoCheck = false;
			checkBoxResultBit02.Location = new Point(129, 38);
			checkBoxResultBit02.Name = "checkBoxResultBit02";
			checkBoxResultBit02.Size = new Size(19, 14);
			checkBoxResultBit02.TabIndex = 4;
			checkBoxResultBit02.ToolTipValues.Description = "Shows bit 02 of byte 1 in R";
			checkBoxResultBit02.ToolTipValues.EnableToolTips = true;
			checkBoxResultBit02.ToolTipValues.Heading = "Bit 02 of byte 1 in R";
			checkBoxResultBit02.Values.Text = "";
			checkBoxResultBit02.Enter += Control_Enter;
			checkBoxResultBit02.Leave += Control_Leave;
			checkBoxResultBit02.MouseEnter += Control_Enter;
			checkBoxResultBit02.MouseLeave += Control_Leave;
			// 
			// labelResultBit02
			// 
			labelResultBit02.AccessibleDescription = "Shows bit 02 of byte 1 in R";
			labelResultBit02.AccessibleName = "Bit 02 of byte 1 in R";
			labelResultBit02.AccessibleRole = AccessibleRole.StaticText;
			labelResultBit02.Location = new Point(124, 18);
			labelResultBit02.Name = "labelResultBit02";
			labelResultBit02.Size = new Size(24, 20);
			labelResultBit02.TabIndex = 5;
			labelResultBit02.ToolTipValues.Description = "Shows bit 02 of byte 1 in R";
			labelResultBit02.ToolTipValues.EnableToolTips = true;
			labelResultBit02.ToolTipValues.Heading = "Bit 02 of byte 1 in R";
			labelResultBit02.Values.Text = "02";
			labelResultBit02.Enter += Control_Enter;
			labelResultBit02.Leave += Control_Leave;
			labelResultBit02.MouseEnter += Control_Enter;
			labelResultBit02.MouseLeave += Control_Leave;
			// 
			// groupBoxAccumulator2
			// 
			groupBoxAccumulator2.AccessibleDescription = "Groups the elements of A2";
			groupBoxAccumulator2.AccessibleName = "Elements of A2";
			groupBoxAccumulator2.AccessibleRole = AccessibleRole.Grouping;
			groupBoxAccumulator2.BackColor = Color.Transparent;
			groupBoxAccumulator2.Controls.Add(textBoxA2Octal);
			groupBoxAccumulator2.Controls.Add(labelA2Octal);
			groupBoxAccumulator2.Controls.Add(maskedTextBoxA2Network);
			groupBoxAccumulator2.Controls.Add(labelA2Network);
			groupBoxAccumulator2.Controls.Add(textBoxA2Decimal);
			groupBoxAccumulator2.Controls.Add(textBoxA2Hexadecimal);
			groupBoxAccumulator2.Controls.Add(labelA2Decimal);
			groupBoxAccumulator2.Controls.Add(labelA2Hexadecimal);
			groupBoxAccumulator2.Controls.Add(groupBoxA2Byte4);
			groupBoxAccumulator2.Controls.Add(groupBoxA2Byte3);
			groupBoxAccumulator2.Controls.Add(groupBoxA2Byte2);
			groupBoxAccumulator2.Controls.Add(groupBoxA2Byte1);
			groupBoxAccumulator2.Location = new Point(14, 156);
			groupBoxAccumulator2.Name = "groupBoxAccumulator2";
			groupBoxAccumulator2.Size = new Size(820, 135);
			groupBoxAccumulator2.TabIndex = 67;
			groupBoxAccumulator2.TabStop = false;
			groupBoxAccumulator2.Text = "Accumulator 2 (A2)";
			// 
			// textBoxA2Octal
			// 
			textBoxA2Octal.AccessibleDescription = "Shows the octal value of A2";
			textBoxA2Octal.AccessibleName = "Octal value of A2";
			textBoxA2Octal.AccessibleRole = AccessibleRole.Text;
			textBoxA2Octal.Location = new Point(456, 28);
			textBoxA2Octal.Name = "textBoxA2Octal";
			textBoxA2Octal.Size = new Size(116, 23);
			textBoxA2Octal.TabIndex = 71;
			textBoxA2Octal.ToolTipValues.Description = "Shows the octal value of A2";
			textBoxA2Octal.ToolTipValues.EnableToolTips = true;
			textBoxA2Octal.ToolTipValues.Heading = "Octal value of A2";
			textBoxA2Octal.Enter += Control_Enter;
			textBoxA2Octal.Leave += Control_Leave;
			textBoxA2Octal.MouseEnter += Control_Enter;
			textBoxA2Octal.MouseLeave += Control_Leave;
			// 
			// labelA2Octal
			// 
			labelA2Octal.AccessibleDescription = "Shows the description of octal value of A2";
			labelA2Octal.AccessibleName = "Description of octal value of A2";
			labelA2Octal.AccessibleRole = AccessibleRole.StaticText;
			labelA2Octal.Location = new Point(410, 31);
			labelA2Octal.Name = "labelA2Octal";
			labelA2Octal.Size = new Size(35, 20);
			labelA2Octal.TabIndex = 70;
			labelA2Octal.Values.Text = "Oct.:";
			labelA2Octal.Enter += Control_Enter;
			labelA2Octal.Leave += Control_Leave;
			labelA2Octal.MouseEnter += Control_Enter;
			labelA2Octal.MouseLeave += Control_Leave;
			// 
			// maskedTextBoxA2Network
			// 
			maskedTextBoxA2Network.AccessibleDescription = "Shows the network value of A2";
			maskedTextBoxA2Network.AccessibleName = "Network value of A2";
			maskedTextBoxA2Network.AccessibleRole = AccessibleRole.Text;
			maskedTextBoxA2Network.Location = new Point(665, 28);
			maskedTextBoxA2Network.Name = "maskedTextBoxA2Network";
			maskedTextBoxA2Network.Size = new Size(116, 23);
			maskedTextBoxA2Network.TabIndex = 67;
			maskedTextBoxA2Network.ToolTipValues.Description = "Shows the network value of A2";
			maskedTextBoxA2Network.ToolTipValues.EnableToolTips = true;
			maskedTextBoxA2Network.ToolTipValues.Heading = "Network value of A2";
			maskedTextBoxA2Network.Enter += Control_Enter;
			maskedTextBoxA2Network.Leave += Control_Leave;
			maskedTextBoxA2Network.MouseEnter += Control_Enter;
			maskedTextBoxA2Network.MouseLeave += Control_Leave;
			// 
			// labelA2Network
			// 
			labelA2Network.AccessibleDescription = "Shows the description of network value of A2";
			labelA2Network.AccessibleName = "Description of network value of A2";
			labelA2Network.AccessibleRole = AccessibleRole.StaticText;
			labelA2Network.Location = new Point(613, 31);
			labelA2Network.Name = "labelA2Network";
			labelA2Network.Size = new Size(45, 20);
			labelA2Network.TabIndex = 68;
			labelA2Network.Values.Text = "Netw.:";
			labelA2Network.Enter += Control_Enter;
			labelA2Network.Leave += Control_Leave;
			labelA2Network.MouseEnter += Control_Enter;
			labelA2Network.MouseLeave += Control_Leave;
			// 
			// textBoxA2Decimal
			// 
			textBoxA2Decimal.AccessibleDescription = "Shows the decimal value of A2";
			textBoxA2Decimal.AccessibleName = "Decimal value of A2";
			textBoxA2Decimal.AccessibleRole = AccessibleRole.Text;
			textBoxA2Decimal.Location = new Point(253, 28);
			textBoxA2Decimal.Name = "textBoxA2Decimal";
			textBoxA2Decimal.Size = new Size(116, 23);
			textBoxA2Decimal.TabIndex = 68;
			textBoxA2Decimal.ToolTipValues.Description = "Shows the decimal value of A2";
			textBoxA2Decimal.ToolTipValues.EnableToolTips = true;
			textBoxA2Decimal.ToolTipValues.Heading = "Decimal value of A2";
			textBoxA2Decimal.Enter += Control_Enter;
			textBoxA2Decimal.Leave += Control_Leave;
			textBoxA2Decimal.MouseEnter += Control_Enter;
			textBoxA2Decimal.MouseLeave += Control_Leave;
			// 
			// textBoxA2Hexadecimal
			// 
			textBoxA2Hexadecimal.AccessibleDescription = "Shows the hexadecimal value of A2";
			textBoxA2Hexadecimal.AccessibleName = "Hexadecimal value of A2";
			textBoxA2Hexadecimal.AccessibleRole = AccessibleRole.Text;
			textBoxA2Hexadecimal.Location = new Point(50, 28);
			textBoxA2Hexadecimal.Name = "textBoxA2Hexadecimal";
			textBoxA2Hexadecimal.Size = new Size(116, 23);
			textBoxA2Hexadecimal.TabIndex = 67;
			textBoxA2Hexadecimal.ToolTipValues.Description = "Shows the hexadecimal value of A2";
			textBoxA2Hexadecimal.ToolTipValues.EnableToolTips = true;
			textBoxA2Hexadecimal.ToolTipValues.Heading = "Hexadecimal value of A2";
			textBoxA2Hexadecimal.Enter += Control_Enter;
			textBoxA2Hexadecimal.Leave += Control_Leave;
			textBoxA2Hexadecimal.MouseEnter += Control_Enter;
			textBoxA2Hexadecimal.MouseLeave += Control_Leave;
			// 
			// labelA2Decimal
			// 
			labelA2Decimal.AccessibleDescription = "Shows the description of decimal value of A2";
			labelA2Decimal.AccessibleName = "Description of decimal value of A2";
			labelA2Decimal.AccessibleRole = AccessibleRole.StaticText;
			labelA2Decimal.Location = new Point(207, 31);
			labelA2Decimal.Name = "labelA2Decimal";
			labelA2Decimal.Size = new Size(37, 20);
			labelA2Decimal.TabIndex = 69;
			labelA2Decimal.Values.Text = "Dec.:";
			labelA2Decimal.Enter += Control_Enter;
			labelA2Decimal.Leave += Control_Leave;
			labelA2Decimal.MouseEnter += Control_Enter;
			labelA2Decimal.MouseLeave += Control_Leave;
			// 
			// labelA2Hexadecimal
			// 
			labelA2Hexadecimal.AccessibleDescription = "Shows the description of hexadecimal value of A2";
			labelA2Hexadecimal.AccessibleName = "Description of hexadecimal value of A2";
			labelA2Hexadecimal.AccessibleRole = AccessibleRole.StaticText;
			labelA2Hexadecimal.Location = new Point(5, 31);
			labelA2Hexadecimal.Name = "labelA2Hexadecimal";
			labelA2Hexadecimal.Size = new Size(37, 20);
			labelA2Hexadecimal.TabIndex = 67;
			labelA2Hexadecimal.Values.Text = "Hex.:";
			labelA2Hexadecimal.Enter += Control_Enter;
			labelA2Hexadecimal.Leave += Control_Leave;
			labelA2Hexadecimal.MouseEnter += Control_Enter;
			labelA2Hexadecimal.MouseLeave += Control_Leave;
			// 
			// groupBoxA2Byte4
			// 
			groupBoxA2Byte4.AccessibleDescription = "Groups the elements of byte 4 in A2";
			groupBoxA2Byte4.AccessibleName = "Elements of byte 4 in A2";
			groupBoxA2Byte4.AccessibleRole = AccessibleRole.Grouping;
			groupBoxA2Byte4.Controls.Add(labelA2Bit31);
			groupBoxA2Byte4.Controls.Add(checkBoxA2Bit31);
			groupBoxA2Byte4.Controls.Add(checkBoxA2Bit24);
			groupBoxA2Byte4.Controls.Add(labelA2Bit24);
			groupBoxA2Byte4.Controls.Add(checkBoxA2Bit25);
			groupBoxA2Byte4.Controls.Add(labelA2Bit30);
			groupBoxA2Byte4.Controls.Add(labelA2Bit25);
			groupBoxA2Byte4.Controls.Add(checkBoxA2Bit26);
			groupBoxA2Byte4.Controls.Add(checkBoxA2Bit30);
			groupBoxA2Byte4.Controls.Add(labelA2Bit26);
			groupBoxA2Byte4.Controls.Add(labelA2Bit29);
			groupBoxA2Byte4.Controls.Add(checkBoxA2Bit27);
			groupBoxA2Byte4.Controls.Add(checkBoxA2Bit29);
			groupBoxA2Byte4.Controls.Add(labelA2Bit27);
			groupBoxA2Byte4.Controls.Add(labelA2Bit28);
			groupBoxA2Byte4.Controls.Add(checkBoxA2Bit28);
			groupBoxA2Byte4.Location = new Point(7, 66);
			groupBoxA2Byte4.Name = "groupBoxA2Byte4";
			groupBoxA2Byte4.Size = new Size(196, 62);
			groupBoxA2Byte4.TabIndex = 69;
			groupBoxA2Byte4.TabStop = false;
			groupBoxA2Byte4.Text = "Byte 4";
			// 
			// labelA2Bit31
			// 
			labelA2Bit31.AccessibleDescription = "Shows bit 31 of byte 4 in A2";
			labelA2Bit31.AccessibleName = "Bit 31 of byte 4 in A2";
			labelA2Bit31.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit31.Location = new Point(-1, 18);
			labelA2Bit31.Name = "labelA2Bit31";
			labelA2Bit31.Size = new Size(24, 20);
			labelA2Bit31.TabIndex = 65;
			labelA2Bit31.ToolTipValues.Description = "Shows bit 31 of byte 4 in A2";
			labelA2Bit31.ToolTipValues.EnableToolTips = true;
			labelA2Bit31.ToolTipValues.Heading = "Bit 31 of byte 4 in A2";
			labelA2Bit31.Values.Text = "31";
			labelA2Bit31.Click += LabelA2Bit31_Click;
			labelA2Bit31.Enter += Control_Enter;
			labelA2Bit31.Leave += Control_Leave;
			labelA2Bit31.MouseEnter += Control_Enter;
			labelA2Bit31.MouseLeave += Control_Leave;
			// 
			// checkBoxA2Bit31
			// 
			checkBoxA2Bit31.AccessibleDescription = "Shows bit 31 of byte 4 in A2";
			checkBoxA2Bit31.AccessibleName = "Bit 31 of byte 4 in A2";
			checkBoxA2Bit31.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit31.Location = new Point(4, 38);
			checkBoxA2Bit31.Name = "checkBoxA2Bit31";
			checkBoxA2Bit31.Size = new Size(19, 14);
			checkBoxA2Bit31.TabIndex = 64;
			checkBoxA2Bit31.ToolTipValues.Description = "Shows bit 31 of byte 4 in A2";
			checkBoxA2Bit31.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit31.ToolTipValues.Heading = "Bit 31 of byte 4 in A2";
			checkBoxA2Bit31.Values.Text = "";
			checkBoxA2Bit31.CheckedChanged += CheckBoxA2Bit31_CheckedChanged;
			checkBoxA2Bit31.Enter += Control_Enter;
			checkBoxA2Bit31.Leave += Control_Leave;
			checkBoxA2Bit31.MouseEnter += Control_Enter;
			checkBoxA2Bit31.MouseLeave += Control_Leave;
			// 
			// checkBoxA2Bit24
			// 
			checkBoxA2Bit24.AccessibleDescription = "Shows bit 24 of byte 4 in A2";
			checkBoxA2Bit24.AccessibleName = "Bit 24 of byte 4 in A2";
			checkBoxA2Bit24.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit24.Location = new Point(173, 38);
			checkBoxA2Bit24.Name = "checkBoxA2Bit24";
			checkBoxA2Bit24.Size = new Size(19, 14);
			checkBoxA2Bit24.TabIndex = 50;
			checkBoxA2Bit24.ToolTipValues.Description = "Shows bit 24 of byte 4 in A2";
			checkBoxA2Bit24.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit24.ToolTipValues.Heading = "Bit 24 of byte 4 in A2";
			checkBoxA2Bit24.Values.Text = "";
			checkBoxA2Bit24.CheckedChanged += CheckBoxA2Bit24_CheckedChanged;
			checkBoxA2Bit24.Enter += Control_Enter;
			checkBoxA2Bit24.Leave += Control_Leave;
			checkBoxA2Bit24.MouseEnter += Control_Enter;
			checkBoxA2Bit24.MouseLeave += Control_Leave;
			// 
			// labelA2Bit24
			// 
			labelA2Bit24.AccessibleDescription = "Shows bit 24 of byte 4 in A2";
			labelA2Bit24.AccessibleName = "Bit 24 of byte 4 in A2";
			labelA2Bit24.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit24.Location = new Point(167, 18);
			labelA2Bit24.Name = "labelA2Bit24";
			labelA2Bit24.Size = new Size(24, 20);
			labelA2Bit24.TabIndex = 51;
			labelA2Bit24.ToolTipValues.Description = "Shows bit 24 of byte 4 in A2";
			labelA2Bit24.ToolTipValues.EnableToolTips = true;
			labelA2Bit24.ToolTipValues.Heading = "Bit 24 of byte 4 in A2";
			labelA2Bit24.Values.Text = "24";
			labelA2Bit24.Click += LabelA2Bit24_Click;
			labelA2Bit24.Enter += Control_Enter;
			labelA2Bit24.Leave += Control_Leave;
			labelA2Bit24.MouseEnter += Control_Enter;
			labelA2Bit24.MouseLeave += Control_Leave;
			// 
			// checkBoxA2Bit25
			// 
			checkBoxA2Bit25.AccessibleDescription = "Shows bit 25 of byte 4 in A2";
			checkBoxA2Bit25.AccessibleName = "Bit 25 of byte 4 in A2";
			checkBoxA2Bit25.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit25.Location = new Point(151, 38);
			checkBoxA2Bit25.Name = "checkBoxA2Bit25";
			checkBoxA2Bit25.Size = new Size(19, 14);
			checkBoxA2Bit25.TabIndex = 52;
			checkBoxA2Bit25.ToolTipValues.Description = "Shows bit 25 of byte 4 in A2";
			checkBoxA2Bit25.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit25.ToolTipValues.Heading = "Bit 25 of byte 4 in A2";
			checkBoxA2Bit25.Values.Text = "";
			checkBoxA2Bit25.CheckedChanged += CheckBoxA2Bit25_CheckedChanged;
			checkBoxA2Bit25.Enter += Control_Enter;
			checkBoxA2Bit25.Leave += Control_Leave;
			checkBoxA2Bit25.MouseEnter += Control_Enter;
			checkBoxA2Bit25.MouseLeave += Control_Leave;
			// 
			// labelA2Bit30
			// 
			labelA2Bit30.AccessibleDescription = "Shows bit 30 of byte 4 in A2";
			labelA2Bit30.AccessibleName = "Bit 30 of byte 4 in A2";
			labelA2Bit30.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit30.Location = new Point(21, 18);
			labelA2Bit30.Name = "labelA2Bit30";
			labelA2Bit30.Size = new Size(24, 20);
			labelA2Bit30.TabIndex = 63;
			labelA2Bit30.ToolTipValues.Description = "Shows bit 30 of byte 4 in A2";
			labelA2Bit30.ToolTipValues.EnableToolTips = true;
			labelA2Bit30.ToolTipValues.Heading = "Bit 30 of byte 4 in A2";
			labelA2Bit30.Values.Text = "30";
			labelA2Bit30.Click += LabelA2Bit30_Click;
			labelA2Bit30.Enter += Control_Enter;
			labelA2Bit30.Leave += Control_Leave;
			labelA2Bit30.MouseEnter += Control_Enter;
			labelA2Bit30.MouseLeave += Control_Leave;
			// 
			// labelA2Bit25
			// 
			labelA2Bit25.AccessibleDescription = "Shows bit 25 of byte 4 in A2";
			labelA2Bit25.AccessibleName = "Bit 25 of byte 4 in A2";
			labelA2Bit25.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit25.Location = new Point(146, 18);
			labelA2Bit25.Name = "labelA2Bit25";
			labelA2Bit25.Size = new Size(24, 20);
			labelA2Bit25.TabIndex = 53;
			labelA2Bit25.ToolTipValues.Description = "Shows bit 25 of byte 4 in A2";
			labelA2Bit25.ToolTipValues.EnableToolTips = true;
			labelA2Bit25.ToolTipValues.Heading = "Bit 25 of byte 4 in A2";
			labelA2Bit25.Values.Text = "25";
			labelA2Bit25.Click += LabelA2Bit25_Click;
			labelA2Bit25.Enter += Control_Enter;
			labelA2Bit25.Leave += Control_Leave;
			labelA2Bit25.MouseEnter += Control_Enter;
			labelA2Bit25.MouseLeave += Control_Leave;
			// 
			// checkBoxA2Bit26
			// 
			checkBoxA2Bit26.AccessibleDescription = "Shows bit 26 of byte 4 in A2";
			checkBoxA2Bit26.AccessibleName = "Bit 26 of byte 4 in A2";
			checkBoxA2Bit26.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit26.Location = new Point(129, 38);
			checkBoxA2Bit26.Name = "checkBoxA2Bit26";
			checkBoxA2Bit26.Size = new Size(19, 14);
			checkBoxA2Bit26.TabIndex = 54;
			checkBoxA2Bit26.ToolTipValues.Description = "Shows bit 26 of byte 4 in A2";
			checkBoxA2Bit26.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit26.ToolTipValues.Heading = "Bit 26 of byte 4 in A2";
			checkBoxA2Bit26.Values.Text = "";
			checkBoxA2Bit26.CheckedChanged += CheckBoxA2Bit26_CheckedChanged;
			checkBoxA2Bit26.Enter += Control_Enter;
			checkBoxA2Bit26.Leave += Control_Leave;
			checkBoxA2Bit26.MouseEnter += Control_Enter;
			checkBoxA2Bit26.MouseLeave += Control_Leave;
			// 
			// checkBoxA2Bit30
			// 
			checkBoxA2Bit30.AccessibleDescription = "Shows bit 30 of byte 4 in A2";
			checkBoxA2Bit30.AccessibleName = "Bit 30 of byte 4 in A2";
			checkBoxA2Bit30.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit30.Location = new Point(26, 38);
			checkBoxA2Bit30.Name = "checkBoxA2Bit30";
			checkBoxA2Bit30.Size = new Size(19, 14);
			checkBoxA2Bit30.TabIndex = 62;
			checkBoxA2Bit30.ToolTipValues.Description = "Shows bit 30 of byte 4 in A2";
			checkBoxA2Bit30.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit30.ToolTipValues.Heading = "Bit 30 of byte 4 in A2";
			checkBoxA2Bit30.Values.Text = "";
			checkBoxA2Bit30.CheckedChanged += CheckBoxA2Bit30_CheckedChanged;
			checkBoxA2Bit30.Enter += Control_Enter;
			checkBoxA2Bit30.Leave += Control_Leave;
			checkBoxA2Bit30.MouseEnter += Control_Enter;
			checkBoxA2Bit30.MouseLeave += Control_Leave;
			// 
			// labelA2Bit26
			// 
			labelA2Bit26.AccessibleDescription = "Shows bit 26 of byte 4 in A2";
			labelA2Bit26.AccessibleName = "Bit 26 of byte 4 in A2";
			labelA2Bit26.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit26.Location = new Point(124, 18);
			labelA2Bit26.Name = "labelA2Bit26";
			labelA2Bit26.Size = new Size(24, 20);
			labelA2Bit26.TabIndex = 55;
			labelA2Bit26.ToolTipValues.Description = "Shows bit 26 of byte 4 in A2";
			labelA2Bit26.ToolTipValues.EnableToolTips = true;
			labelA2Bit26.ToolTipValues.Heading = "Bit 26 of byte 4 in A2";
			labelA2Bit26.Values.Text = "26";
			labelA2Bit26.Click += LabelA2Bit26_Click;
			labelA2Bit26.Enter += Control_Enter;
			labelA2Bit26.Leave += Control_Leave;
			labelA2Bit26.MouseEnter += Control_Enter;
			labelA2Bit26.MouseLeave += Control_Leave;
			// 
			// labelA2Bit29
			// 
			labelA2Bit29.AccessibleDescription = "Shows bit 29 of byte 4 in A2";
			labelA2Bit29.AccessibleName = "Bit 29 of byte 4 in A2";
			labelA2Bit29.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit29.Location = new Point(43, 18);
			labelA2Bit29.Name = "labelA2Bit29";
			labelA2Bit29.Size = new Size(24, 20);
			labelA2Bit29.TabIndex = 61;
			labelA2Bit29.ToolTipValues.Description = "Shows bit 29 of byte 4 in A2";
			labelA2Bit29.ToolTipValues.EnableToolTips = true;
			labelA2Bit29.ToolTipValues.Heading = "Bit 29 of byte 4 in A2";
			labelA2Bit29.Values.Text = "29";
			labelA2Bit29.Click += LabelA2Bit29_Click;
			labelA2Bit29.Enter += Control_Enter;
			labelA2Bit29.Leave += Control_Leave;
			labelA2Bit29.MouseEnter += Control_Enter;
			labelA2Bit29.MouseLeave += Control_Leave;
			// 
			// checkBoxA2Bit27
			// 
			checkBoxA2Bit27.AccessibleDescription = "Shows bit 27 of byte 4 in A2";
			checkBoxA2Bit27.AccessibleName = "Bit 27 of byte 4 in A2";
			checkBoxA2Bit27.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit27.Location = new Point(106, 38);
			checkBoxA2Bit27.Name = "checkBoxA2Bit27";
			checkBoxA2Bit27.Size = new Size(19, 14);
			checkBoxA2Bit27.TabIndex = 56;
			checkBoxA2Bit27.ToolTipValues.Description = "Shows bit 27 of byte 4 in A2";
			checkBoxA2Bit27.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit27.ToolTipValues.Heading = "Bit 27 of byte 4 in A2";
			checkBoxA2Bit27.Values.Text = "";
			checkBoxA2Bit27.CheckedChanged += CheckBoxA2Bit27_CheckedChanged;
			checkBoxA2Bit27.Enter += Control_Enter;
			checkBoxA2Bit27.Leave += Control_Leave;
			checkBoxA2Bit27.MouseEnter += Control_Enter;
			checkBoxA2Bit27.MouseLeave += Control_Leave;
			// 
			// checkBoxA2Bit29
			// 
			checkBoxA2Bit29.AccessibleDescription = "Shows bit 29 of byte 4 in A2";
			checkBoxA2Bit29.AccessibleName = "Bit 29 of byte 4 in A2";
			checkBoxA2Bit29.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit29.Location = new Point(48, 38);
			checkBoxA2Bit29.Name = "checkBoxA2Bit29";
			checkBoxA2Bit29.Size = new Size(19, 14);
			checkBoxA2Bit29.TabIndex = 60;
			checkBoxA2Bit29.ToolTipValues.Description = "Shows bit 29 of byte 4 in A2";
			checkBoxA2Bit29.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit29.ToolTipValues.Heading = "Bit 29 of byte 4 in A2";
			checkBoxA2Bit29.Values.Text = "";
			checkBoxA2Bit29.CheckedChanged += CheckBoxA2Bit29_CheckedChanged;
			checkBoxA2Bit29.Enter += Control_Enter;
			checkBoxA2Bit29.Leave += Control_Leave;
			checkBoxA2Bit29.MouseEnter += Control_Enter;
			checkBoxA2Bit29.MouseLeave += Control_Leave;
			// 
			// labelA2Bit27
			// 
			labelA2Bit27.AccessibleDescription = "Shows bit 27 of byte 4 in A2";
			labelA2Bit27.AccessibleName = "Bit 27 of byte 4 in A2";
			labelA2Bit27.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit27.Location = new Point(100, 18);
			labelA2Bit27.Name = "labelA2Bit27";
			labelA2Bit27.Size = new Size(24, 20);
			labelA2Bit27.TabIndex = 57;
			labelA2Bit27.ToolTipValues.Description = "Shows bit 27 of byte 4 in A2";
			labelA2Bit27.ToolTipValues.EnableToolTips = true;
			labelA2Bit27.ToolTipValues.Heading = "Bit 27 of byte 4 in A2";
			labelA2Bit27.Values.Text = "27";
			labelA2Bit27.Click += LabelA2Bit27_Click;
			labelA2Bit27.Enter += Control_Enter;
			labelA2Bit27.Leave += Control_Leave;
			labelA2Bit27.MouseEnter += Control_Enter;
			labelA2Bit27.MouseLeave += Control_Leave;
			// 
			// labelA2Bit28
			// 
			labelA2Bit28.AccessibleDescription = "Shows bit 28 of byte 4 in A2";
			labelA2Bit28.AccessibleName = "Bit 28 of byte 4 in A2";
			labelA2Bit28.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit28.Location = new Point(65, 18);
			labelA2Bit28.Name = "labelA2Bit28";
			labelA2Bit28.Size = new Size(24, 20);
			labelA2Bit28.TabIndex = 59;
			labelA2Bit28.ToolTipValues.Description = "Shows bit 28 of byte 4 in A2";
			labelA2Bit28.ToolTipValues.EnableToolTips = true;
			labelA2Bit28.ToolTipValues.Heading = "Bit 28 of byte 4 in A2";
			labelA2Bit28.Values.Text = "28";
			labelA2Bit28.Click += LabelA2Bit28_Click;
			labelA2Bit28.Enter += Control_Enter;
			labelA2Bit28.Leave += Control_Leave;
			labelA2Bit28.MouseEnter += Control_Enter;
			labelA2Bit28.MouseLeave += Control_Leave;
			// 
			// checkBoxA2Bit28
			// 
			checkBoxA2Bit28.AccessibleDescription = "Shows bit 28 of byte 4 in A2";
			checkBoxA2Bit28.AccessibleName = "Bit 28 of byte 4 in A2";
			checkBoxA2Bit28.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit28.Location = new Point(70, 38);
			checkBoxA2Bit28.Name = "checkBoxA2Bit28";
			checkBoxA2Bit28.Size = new Size(19, 14);
			checkBoxA2Bit28.TabIndex = 58;
			checkBoxA2Bit28.ToolTipValues.Description = "Shows bit 28 of byte 4 in A2";
			checkBoxA2Bit28.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit28.ToolTipValues.Heading = "Bit 28 of byte 4 in A2";
			checkBoxA2Bit28.Values.Text = "";
			checkBoxA2Bit28.CheckedChanged += CheckBoxA2Bit28_CheckedChanged;
			checkBoxA2Bit28.Enter += Control_Enter;
			checkBoxA2Bit28.Leave += Control_Leave;
			checkBoxA2Bit28.MouseEnter += Control_Enter;
			checkBoxA2Bit28.MouseLeave += Control_Leave;
			// 
			// groupBoxA2Byte3
			// 
			groupBoxA2Byte3.AccessibleDescription = "Groups the elements of byte 3 in A2";
			groupBoxA2Byte3.AccessibleName = "Elements of byte 3 in A2";
			groupBoxA2Byte3.AccessibleRole = AccessibleRole.Grouping;
			groupBoxA2Byte3.Controls.Add(checkBoxA2Bit23);
			groupBoxA2Byte3.Controls.Add(checkBoxA2Bit21);
			groupBoxA2Byte3.Controls.Add(labelA2Bit21);
			groupBoxA2Byte3.Controls.Add(labelA2Bit20);
			groupBoxA2Byte3.Controls.Add(checkBoxA2Bit22);
			groupBoxA2Byte3.Controls.Add(checkBoxA2Bit20);
			groupBoxA2Byte3.Controls.Add(labelA2Bit22);
			groupBoxA2Byte3.Controls.Add(labelA2Bit19);
			groupBoxA2Byte3.Controls.Add(checkBoxA2Bit16);
			groupBoxA2Byte3.Controls.Add(checkBoxA2Bit19);
			groupBoxA2Byte3.Controls.Add(labelA2Bit23);
			groupBoxA2Byte3.Controls.Add(labelA2Bit18);
			groupBoxA2Byte3.Controls.Add(labelA2Bit16);
			groupBoxA2Byte3.Controls.Add(checkBoxA2Bit18);
			groupBoxA2Byte3.Controls.Add(labelA2Bit17);
			groupBoxA2Byte3.Controls.Add(checkBoxA2Bit17);
			groupBoxA2Byte3.Location = new Point(212, 66);
			groupBoxA2Byte3.Name = "groupBoxA2Byte3";
			groupBoxA2Byte3.Size = new Size(196, 62);
			groupBoxA2Byte3.TabIndex = 68;
			groupBoxA2Byte3.TabStop = false;
			groupBoxA2Byte3.Text = "Byte 3";
			// 
			// checkBoxA2Bit23
			// 
			checkBoxA2Bit23.AccessibleDescription = "Shows bit 23 of byte 3 in A2";
			checkBoxA2Bit23.AccessibleName = "Bit 23 of byte 3 in A2";
			checkBoxA2Bit23.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit23.Location = new Point(4, 38);
			checkBoxA2Bit23.Name = "checkBoxA2Bit23";
			checkBoxA2Bit23.Size = new Size(19, 14);
			checkBoxA2Bit23.TabIndex = 48;
			checkBoxA2Bit23.ToolTipValues.Description = "Shows bit 23 of byte 3 in A2";
			checkBoxA2Bit23.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit23.ToolTipValues.Heading = "Bit 23 of byte 3 in A2";
			checkBoxA2Bit23.Values.Text = "";
			checkBoxA2Bit23.CheckedChanged += CheckBoxA2Bit23_CheckedChanged;
			checkBoxA2Bit23.Enter += Control_Enter;
			checkBoxA2Bit23.MouseEnter += Control_Enter;
			checkBoxA2Bit23.MouseLeave += Control_Leave;
			checkBoxA2Bit23.Validated += Control_Leave;
			// 
			// checkBoxA2Bit21
			// 
			checkBoxA2Bit21.AccessibleDescription = "Shows bit 21 of byte 3 in A2";
			checkBoxA2Bit21.AccessibleName = "Bit 21 of byte 3 in A2";
			checkBoxA2Bit21.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit21.Location = new Point(48, 38);
			checkBoxA2Bit21.Name = "checkBoxA2Bit21";
			checkBoxA2Bit21.Size = new Size(19, 14);
			checkBoxA2Bit21.TabIndex = 44;
			checkBoxA2Bit21.ToolTipValues.Description = "Shows bit 21 of byte 3 in A2";
			checkBoxA2Bit21.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit21.ToolTipValues.Heading = "Bit 21 of byte 3 in A2";
			checkBoxA2Bit21.Values.Text = "";
			checkBoxA2Bit21.CheckedChanged += CheckBoxA2Bit21_CheckedChanged;
			checkBoxA2Bit21.Enter += Control_Enter;
			checkBoxA2Bit21.MouseEnter += Control_Enter;
			checkBoxA2Bit21.MouseLeave += Control_Leave;
			checkBoxA2Bit21.Validated += Control_Leave;
			// 
			// labelA2Bit21
			// 
			labelA2Bit21.AccessibleDescription = "Shows bit 21 of byte 3 in A2";
			labelA2Bit21.AccessibleName = "Bit 21 of byte 3 in A2";
			labelA2Bit21.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit21.Location = new Point(43, 18);
			labelA2Bit21.Name = "labelA2Bit21";
			labelA2Bit21.Size = new Size(24, 20);
			labelA2Bit21.TabIndex = 45;
			labelA2Bit21.ToolTipValues.Description = "Shows bit 21 of byte 3 in A2";
			labelA2Bit21.ToolTipValues.EnableToolTips = true;
			labelA2Bit21.ToolTipValues.Heading = "Bit 21 of byte 3 in A2";
			labelA2Bit21.Values.Text = "21";
			labelA2Bit21.Click += LabelA2Bit21_Click;
			labelA2Bit21.Enter += Control_Enter;
			labelA2Bit21.MouseEnter += Control_Enter;
			labelA2Bit21.MouseLeave += Control_Leave;
			labelA2Bit21.Validated += Control_Leave;
			// 
			// labelA2Bit20
			// 
			labelA2Bit20.AccessibleDescription = "Shows bit 20 of byte 3 in A2";
			labelA2Bit20.AccessibleName = "Bit 20 of byte 3 in A2";
			labelA2Bit20.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit20.Location = new Point(65, 18);
			labelA2Bit20.Name = "labelA2Bit20";
			labelA2Bit20.Size = new Size(24, 20);
			labelA2Bit20.TabIndex = 43;
			labelA2Bit20.ToolTipValues.Description = "Shows bit 20 of byte 3 in A2";
			labelA2Bit20.ToolTipValues.EnableToolTips = true;
			labelA2Bit20.ToolTipValues.Heading = "Bit 20 of byte 3 in A2";
			labelA2Bit20.Values.Text = "20";
			labelA2Bit20.Click += LabelA2Bit20_Click;
			labelA2Bit20.Enter += Control_Enter;
			labelA2Bit20.MouseEnter += Control_Enter;
			labelA2Bit20.MouseLeave += Control_Leave;
			labelA2Bit20.Validated += Control_Leave;
			// 
			// checkBoxA2Bit22
			// 
			checkBoxA2Bit22.AccessibleDescription = "Shows bit 22 of byte 3 in A2";
			checkBoxA2Bit22.AccessibleName = "Bit 22 of byte 3 in A2";
			checkBoxA2Bit22.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit22.Location = new Point(26, 38);
			checkBoxA2Bit22.Name = "checkBoxA2Bit22";
			checkBoxA2Bit22.Size = new Size(19, 14);
			checkBoxA2Bit22.TabIndex = 46;
			checkBoxA2Bit22.ToolTipValues.Description = "Shows bit 22 of byte 3 in A2";
			checkBoxA2Bit22.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit22.ToolTipValues.Heading = "Bit 22 of byte 3 in A2";
			checkBoxA2Bit22.Values.Text = "";
			checkBoxA2Bit22.CheckedChanged += CheckBoxA2Bit22_CheckedChanged;
			checkBoxA2Bit22.Enter += Control_Enter;
			checkBoxA2Bit22.MouseEnter += Control_Enter;
			checkBoxA2Bit22.MouseLeave += Control_Leave;
			checkBoxA2Bit22.Validated += Control_Leave;
			// 
			// checkBoxA2Bit20
			// 
			checkBoxA2Bit20.AccessibleDescription = "Shows bit 20 of byte 3 in A2";
			checkBoxA2Bit20.AccessibleName = "Bit 20 of byte 3 in A2";
			checkBoxA2Bit20.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit20.Location = new Point(70, 38);
			checkBoxA2Bit20.Name = "checkBoxA2Bit20";
			checkBoxA2Bit20.Size = new Size(19, 14);
			checkBoxA2Bit20.TabIndex = 42;
			checkBoxA2Bit20.ToolTipValues.Description = "Shows bit 20 of byte 3 in A2";
			checkBoxA2Bit20.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit20.ToolTipValues.Heading = "Bit 20 of byte 3 in A2";
			checkBoxA2Bit20.Values.Text = "";
			checkBoxA2Bit20.CheckedChanged += CheckBoxA2Bit20_CheckedChanged;
			checkBoxA2Bit20.Enter += Control_Enter;
			checkBoxA2Bit20.MouseEnter += Control_Enter;
			checkBoxA2Bit20.MouseLeave += Control_Leave;
			checkBoxA2Bit20.Validated += Control_Leave;
			// 
			// labelA2Bit22
			// 
			labelA2Bit22.AccessibleDescription = "Shows bit XX of byte 3 in A2";
			labelA2Bit22.AccessibleName = "Bit XX of byte 3 in A2";
			labelA2Bit22.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit22.Location = new Point(21, 18);
			labelA2Bit22.Name = "labelA2Bit22";
			labelA2Bit22.Size = new Size(24, 20);
			labelA2Bit22.TabIndex = 47;
			labelA2Bit22.ToolTipValues.EnableToolTips = true;
			labelA2Bit22.Values.Text = "22";
			labelA2Bit22.Click += LabelA2Bit22_Click;
			labelA2Bit22.Enter += Control_Enter;
			labelA2Bit22.MouseEnter += Control_Enter;
			labelA2Bit22.MouseLeave += Control_Leave;
			labelA2Bit22.Validated += Control_Leave;
			// 
			// labelA2Bit19
			// 
			labelA2Bit19.AccessibleDescription = "Shows bit 19 of byte 3 in A2";
			labelA2Bit19.AccessibleName = "Bit 19 of byte 3 in A2";
			labelA2Bit19.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit19.Location = new Point(100, 18);
			labelA2Bit19.Name = "labelA2Bit19";
			labelA2Bit19.Size = new Size(24, 20);
			labelA2Bit19.TabIndex = 41;
			labelA2Bit19.ToolTipValues.Description = "Shows bit 19 of byte 3 in A2";
			labelA2Bit19.ToolTipValues.EnableToolTips = true;
			labelA2Bit19.ToolTipValues.Heading = "Bit 19 of byte 3 in A2";
			labelA2Bit19.Values.Text = "19";
			labelA2Bit19.Click += LabelA2Bit19_Click;
			labelA2Bit19.Enter += Control_Enter;
			labelA2Bit19.MouseEnter += Control_Enter;
			labelA2Bit19.MouseLeave += Control_Leave;
			labelA2Bit19.Validated += Control_Leave;
			// 
			// checkBoxA2Bit16
			// 
			checkBoxA2Bit16.AccessibleDescription = "Shows bit 16 of byte 3 in A2";
			checkBoxA2Bit16.AccessibleName = "Bit 16 of byte 3 in A2";
			checkBoxA2Bit16.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit16.Location = new Point(173, 38);
			checkBoxA2Bit16.Name = "checkBoxA2Bit16";
			checkBoxA2Bit16.Size = new Size(19, 14);
			checkBoxA2Bit16.TabIndex = 34;
			checkBoxA2Bit16.ToolTipValues.Description = "Shows bit 16 of byte 3 in A2";
			checkBoxA2Bit16.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit16.ToolTipValues.Heading = "Bit 16 of byte 3 in A2";
			checkBoxA2Bit16.Values.Text = "";
			checkBoxA2Bit16.CheckedChanged += CheckBoxA2Bit16_CheckedChanged;
			checkBoxA2Bit16.Enter += Control_Enter;
			checkBoxA2Bit16.MouseEnter += Control_Enter;
			checkBoxA2Bit16.MouseLeave += Control_Leave;
			checkBoxA2Bit16.Validated += Control_Leave;
			// 
			// checkBoxA2Bit19
			// 
			checkBoxA2Bit19.AccessibleDescription = "Shows bit 19 of byte 3 in A2";
			checkBoxA2Bit19.AccessibleName = "Bit 19 of byte 3 in A2";
			checkBoxA2Bit19.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit19.Location = new Point(106, 38);
			checkBoxA2Bit19.Name = "checkBoxA2Bit19";
			checkBoxA2Bit19.Size = new Size(19, 14);
			checkBoxA2Bit19.TabIndex = 40;
			checkBoxA2Bit19.ToolTipValues.Description = "Shows bit 19 of byte 3 in A2";
			checkBoxA2Bit19.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit19.ToolTipValues.Heading = "Bit 19 of byte 3 in A2";
			checkBoxA2Bit19.Values.Text = "";
			checkBoxA2Bit19.CheckedChanged += CheckBoxA2Bit19_CheckedChanged;
			checkBoxA2Bit19.Enter += Control_Enter;
			checkBoxA2Bit19.MouseEnter += Control_Enter;
			checkBoxA2Bit19.MouseLeave += Control_Leave;
			checkBoxA2Bit19.Validated += Control_Leave;
			// 
			// labelA2Bit23
			// 
			labelA2Bit23.AccessibleDescription = "Shows bit 23 of byte 3 in A2";
			labelA2Bit23.AccessibleName = "Bit 23 of byte 3 in A2";
			labelA2Bit23.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit23.Location = new Point(-1, 18);
			labelA2Bit23.Name = "labelA2Bit23";
			labelA2Bit23.Size = new Size(24, 20);
			labelA2Bit23.TabIndex = 49;
			labelA2Bit23.ToolTipValues.Description = "Shows bit 23 of byte 3 in A2";
			labelA2Bit23.ToolTipValues.EnableToolTips = true;
			labelA2Bit23.ToolTipValues.Heading = "Bit 23 of byte 3 in A2";
			labelA2Bit23.Values.Text = "23";
			labelA2Bit23.Click += LabelA2Bit23_Click;
			labelA2Bit23.Enter += Control_Enter;
			labelA2Bit23.MouseEnter += Control_Enter;
			labelA2Bit23.MouseLeave += Control_Leave;
			labelA2Bit23.Validated += Control_Leave;
			// 
			// labelA2Bit18
			// 
			labelA2Bit18.AccessibleDescription = "Shows bit 18 of byte 3 in A2";
			labelA2Bit18.AccessibleName = "Bit 18 of byte 3 in A2";
			labelA2Bit18.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit18.Location = new Point(124, 18);
			labelA2Bit18.Name = "labelA2Bit18";
			labelA2Bit18.Size = new Size(24, 20);
			labelA2Bit18.TabIndex = 39;
			labelA2Bit18.ToolTipValues.Description = "Shows bit 18 of byte 3 in A2";
			labelA2Bit18.ToolTipValues.EnableToolTips = true;
			labelA2Bit18.ToolTipValues.Heading = "Bit 18 of byte 3 in A2";
			labelA2Bit18.Values.Text = "18";
			labelA2Bit18.Click += LabelA2Bit18_Click;
			labelA2Bit18.Enter += Control_Enter;
			labelA2Bit18.MouseEnter += Control_Enter;
			labelA2Bit18.MouseLeave += Control_Leave;
			labelA2Bit18.Validated += Control_Leave;
			// 
			// labelA2Bit16
			// 
			labelA2Bit16.AccessibleDescription = "Shows bit 16 of byte 3 in A2";
			labelA2Bit16.AccessibleName = "Bit 16 of byte 3 in A2";
			labelA2Bit16.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit16.Location = new Point(167, 18);
			labelA2Bit16.Name = "labelA2Bit16";
			labelA2Bit16.Size = new Size(24, 20);
			labelA2Bit16.TabIndex = 35;
			labelA2Bit16.ToolTipValues.Description = "Shows bit 16 of byte 3 in A2";
			labelA2Bit16.ToolTipValues.EnableToolTips = true;
			labelA2Bit16.ToolTipValues.Heading = "Bit 16 of byte 3 in A2";
			labelA2Bit16.Values.Text = "16";
			labelA2Bit16.Click += LabelA2Bit16_Click;
			labelA2Bit16.Enter += Control_Enter;
			labelA2Bit16.MouseEnter += Control_Enter;
			labelA2Bit16.MouseLeave += Control_Leave;
			labelA2Bit16.Validated += Control_Leave;
			// 
			// checkBoxA2Bit18
			// 
			checkBoxA2Bit18.AccessibleDescription = "Shows bit 18 of byte 3 in A2";
			checkBoxA2Bit18.AccessibleName = "Bit 18 of byte 3 in A2";
			checkBoxA2Bit18.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit18.Location = new Point(129, 38);
			checkBoxA2Bit18.Name = "checkBoxA2Bit18";
			checkBoxA2Bit18.Size = new Size(19, 14);
			checkBoxA2Bit18.TabIndex = 38;
			checkBoxA2Bit18.ToolTipValues.Description = "Shows bit 18 of byte 3 in A2";
			checkBoxA2Bit18.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit18.ToolTipValues.Heading = "Bit 18 of byte 3 in A2";
			checkBoxA2Bit18.Values.Text = "";
			checkBoxA2Bit18.CheckedChanged += CheckBoxA2Bit18_CheckedChanged;
			checkBoxA2Bit18.Enter += Control_Enter;
			checkBoxA2Bit18.MouseEnter += Control_Enter;
			checkBoxA2Bit18.MouseLeave += Control_Leave;
			checkBoxA2Bit18.Validated += Control_Leave;
			// 
			// labelA2Bit17
			// 
			labelA2Bit17.AccessibleDescription = "Shows bit 17 of byte 3 in A2";
			labelA2Bit17.AccessibleName = "Bit 17 of byte 3 in A2";
			labelA2Bit17.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit17.Location = new Point(146, 18);
			labelA2Bit17.Name = "labelA2Bit17";
			labelA2Bit17.Size = new Size(24, 20);
			labelA2Bit17.TabIndex = 37;
			labelA2Bit17.ToolTipValues.Description = "Shows bit 17 of byte 3 in A2";
			labelA2Bit17.ToolTipValues.EnableToolTips = true;
			labelA2Bit17.ToolTipValues.Heading = "Bit 17 of byte 3 in A2";
			labelA2Bit17.Values.Text = "17";
			labelA2Bit17.Click += LabelA2Bit17_Click;
			labelA2Bit17.Enter += Control_Enter;
			labelA2Bit17.MouseEnter += Control_Enter;
			labelA2Bit17.MouseLeave += Control_Leave;
			labelA2Bit17.Validated += Control_Leave;
			// 
			// checkBoxA2Bit17
			// 
			checkBoxA2Bit17.AccessibleDescription = "Shows bit 17 of byte 3 in A2";
			checkBoxA2Bit17.AccessibleName = "Bit 17 of byte 3 in A2";
			checkBoxA2Bit17.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit17.Location = new Point(151, 38);
			checkBoxA2Bit17.Name = "checkBoxA2Bit17";
			checkBoxA2Bit17.Size = new Size(19, 14);
			checkBoxA2Bit17.TabIndex = 36;
			checkBoxA2Bit17.ToolTipValues.Description = "Shows bit 17 of byte 3 in A2";
			checkBoxA2Bit17.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit17.ToolTipValues.Heading = "Bit 17 of byte 3 in A2";
			checkBoxA2Bit17.Values.Text = "";
			checkBoxA2Bit17.CheckedChanged += CheckBoxA2Bit17_CheckedChanged;
			checkBoxA2Bit17.Enter += Control_Enter;
			checkBoxA2Bit17.MouseEnter += Control_Enter;
			checkBoxA2Bit17.MouseLeave += Control_Leave;
			checkBoxA2Bit17.Validated += Control_Leave;
			// 
			// groupBoxA2Byte2
			// 
			groupBoxA2Byte2.AccessibleDescription = "Groups the elements of byte 2 in A2";
			groupBoxA2Byte2.AccessibleName = "Elements of byte 2 in A2";
			groupBoxA2Byte2.AccessibleRole = AccessibleRole.Grouping;
			groupBoxA2Byte2.Controls.Add(checkBoxA2Bit15);
			groupBoxA2Byte2.Controls.Add(checkBoxA2Bit10);
			groupBoxA2Byte2.Controls.Add(labelA2Bit10);
			groupBoxA2Byte2.Controls.Add(labelA2Bit09);
			groupBoxA2Byte2.Controls.Add(checkBoxA2Bit11);
			groupBoxA2Byte2.Controls.Add(checkBoxA2Bit09);
			groupBoxA2Byte2.Controls.Add(labelA2Bit11);
			groupBoxA2Byte2.Controls.Add(labelA2Bit15);
			groupBoxA2Byte2.Controls.Add(labelA2Bit08);
			groupBoxA2Byte2.Controls.Add(checkBoxA2Bit12);
			groupBoxA2Byte2.Controls.Add(checkBoxA2Bit08);
			groupBoxA2Byte2.Controls.Add(labelA2Bit12);
			groupBoxA2Byte2.Controls.Add(checkBoxA2Bit13);
			groupBoxA2Byte2.Controls.Add(labelA2Bit13);
			groupBoxA2Byte2.Controls.Add(checkBoxA2Bit14);
			groupBoxA2Byte2.Controls.Add(labelA2Bit14);
			groupBoxA2Byte2.Location = new Point(415, 66);
			groupBoxA2Byte2.Name = "groupBoxA2Byte2";
			groupBoxA2Byte2.Size = new Size(196, 62);
			groupBoxA2Byte2.TabIndex = 67;
			groupBoxA2Byte2.TabStop = false;
			groupBoxA2Byte2.Text = "Byte 2";
			// 
			// checkBoxA2Bit15
			// 
			checkBoxA2Bit15.AccessibleDescription = "Shows bit 15 of byte 2 in A2";
			checkBoxA2Bit15.AccessibleName = "Bit 15 of byte 2 in A2";
			checkBoxA2Bit15.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit15.Location = new Point(4, 38);
			checkBoxA2Bit15.Name = "checkBoxA2Bit15";
			checkBoxA2Bit15.Size = new Size(19, 14);
			checkBoxA2Bit15.TabIndex = 32;
			checkBoxA2Bit15.ToolTipValues.Description = "Shows bit 15 of byte 2 in A2";
			checkBoxA2Bit15.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit15.ToolTipValues.Heading = "Bit 15 of byte 2 in A2";
			checkBoxA2Bit15.Values.Text = "";
			checkBoxA2Bit15.CheckedChanged += CheckBoxA2Bit15_CheckedChanged;
			checkBoxA2Bit15.Enter += Control_Enter;
			checkBoxA2Bit15.Leave += Control_Leave;
			checkBoxA2Bit15.MouseEnter += Control_Enter;
			checkBoxA2Bit15.MouseLeave += Control_Leave;
			// 
			// checkBoxA2Bit10
			// 
			checkBoxA2Bit10.AccessibleDescription = "Shows bit 10 of byte 2 in A2";
			checkBoxA2Bit10.AccessibleName = "Bit 10 of byte 2 in A2";
			checkBoxA2Bit10.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit10.Location = new Point(129, 38);
			checkBoxA2Bit10.Name = "checkBoxA2Bit10";
			checkBoxA2Bit10.Size = new Size(19, 14);
			checkBoxA2Bit10.TabIndex = 22;
			checkBoxA2Bit10.ToolTipValues.Description = "Shows bit 10 of byte 2 in A2";
			checkBoxA2Bit10.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit10.ToolTipValues.Heading = "Bit 10 of byte 2 in A2";
			checkBoxA2Bit10.Values.Text = "";
			checkBoxA2Bit10.CheckedChanged += CheckBoxA2Bit10_CheckedChanged;
			checkBoxA2Bit10.Enter += Control_Enter;
			checkBoxA2Bit10.Leave += Control_Leave;
			checkBoxA2Bit10.MouseEnter += Control_Enter;
			checkBoxA2Bit10.MouseLeave += Control_Leave;
			// 
			// labelA2Bit10
			// 
			labelA2Bit10.AccessibleDescription = "Shows bit 10 of byte 2 in A2";
			labelA2Bit10.AccessibleName = "Bit 10 of byte 2 in A2";
			labelA2Bit10.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit10.Location = new Point(124, 18);
			labelA2Bit10.Name = "labelA2Bit10";
			labelA2Bit10.Size = new Size(24, 20);
			labelA2Bit10.TabIndex = 23;
			labelA2Bit10.ToolTipValues.Description = "Shows bit 10 of byte 2 in A2";
			labelA2Bit10.ToolTipValues.EnableToolTips = true;
			labelA2Bit10.ToolTipValues.Heading = "Bit 10 of byte 2 in A2";
			labelA2Bit10.Values.Text = "10";
			labelA2Bit10.Click += LabelA2Bit10_Click;
			labelA2Bit10.Enter += Control_Enter;
			labelA2Bit10.Leave += Control_Leave;
			labelA2Bit10.MouseEnter += Control_Enter;
			labelA2Bit10.MouseLeave += Control_Leave;
			// 
			// labelA2Bit09
			// 
			labelA2Bit09.AccessibleDescription = "Shows bit 09 of byte 2 in A2";
			labelA2Bit09.AccessibleName = "Bit 09 of byte 2 in A2";
			labelA2Bit09.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit09.Location = new Point(146, 18);
			labelA2Bit09.Name = "labelA2Bit09";
			labelA2Bit09.Size = new Size(24, 20);
			labelA2Bit09.TabIndex = 21;
			labelA2Bit09.ToolTipValues.Description = "Shows bit 09 of byte 2 in A2";
			labelA2Bit09.ToolTipValues.EnableToolTips = true;
			labelA2Bit09.ToolTipValues.Heading = "Bit 09 of byte 2 in A2";
			labelA2Bit09.Values.Text = "09";
			labelA2Bit09.Click += LabelA2Bit09_Click;
			labelA2Bit09.Enter += Control_Enter;
			labelA2Bit09.Leave += Control_Leave;
			labelA2Bit09.MouseEnter += Control_Enter;
			labelA2Bit09.MouseLeave += Control_Leave;
			// 
			// checkBoxA2Bit11
			// 
			checkBoxA2Bit11.AccessibleDescription = "Shows bit 11 of byte 2 in A2";
			checkBoxA2Bit11.AccessibleName = "Bit 11 of byte 2 in A2";
			checkBoxA2Bit11.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit11.Location = new Point(106, 38);
			checkBoxA2Bit11.Name = "checkBoxA2Bit11";
			checkBoxA2Bit11.Size = new Size(19, 14);
			checkBoxA2Bit11.TabIndex = 24;
			checkBoxA2Bit11.ToolTipValues.Description = "Shows bit 11 of byte 2 in A2";
			checkBoxA2Bit11.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit11.ToolTipValues.Heading = "Bit 11 of byte 2 in A2";
			checkBoxA2Bit11.Values.Text = "";
			checkBoxA2Bit11.CheckedChanged += CheckBoxA2Bit11_CheckedChanged;
			checkBoxA2Bit11.Enter += Control_Enter;
			checkBoxA2Bit11.Leave += Control_Leave;
			checkBoxA2Bit11.MouseEnter += Control_Enter;
			checkBoxA2Bit11.MouseLeave += Control_Leave;
			// 
			// checkBoxA2Bit09
			// 
			checkBoxA2Bit09.AccessibleDescription = "Shows bit 09 of byte 2 in A2";
			checkBoxA2Bit09.AccessibleName = "Bit 09 of byte 2 in A2";
			checkBoxA2Bit09.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit09.Location = new Point(151, 38);
			checkBoxA2Bit09.Name = "checkBoxA2Bit09";
			checkBoxA2Bit09.Size = new Size(19, 14);
			checkBoxA2Bit09.TabIndex = 20;
			checkBoxA2Bit09.ToolTipValues.Description = "Shows bit 09 of byte 2 in A2";
			checkBoxA2Bit09.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit09.ToolTipValues.Heading = "Bit 09 of byte 2 in A2";
			checkBoxA2Bit09.Values.Text = "";
			checkBoxA2Bit09.CheckedChanged += CheckBoxA2Bit09_CheckedChanged;
			checkBoxA2Bit09.Enter += Control_Enter;
			checkBoxA2Bit09.Leave += Control_Leave;
			checkBoxA2Bit09.MouseEnter += Control_Enter;
			checkBoxA2Bit09.MouseLeave += Control_Leave;
			// 
			// labelA2Bit11
			// 
			labelA2Bit11.AccessibleDescription = "Shows bit 11 of byte 2 in A2";
			labelA2Bit11.AccessibleName = "Bit 11 of byte 2 in A2";
			labelA2Bit11.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit11.Location = new Point(100, 18);
			labelA2Bit11.Name = "labelA2Bit11";
			labelA2Bit11.Size = new Size(24, 20);
			labelA2Bit11.TabIndex = 25;
			labelA2Bit11.ToolTipValues.Description = "Shows bit 11 of byte 2 in A2";
			labelA2Bit11.ToolTipValues.EnableToolTips = true;
			labelA2Bit11.ToolTipValues.Heading = "Bit 11 of byte 2 in A2";
			labelA2Bit11.Values.Text = "11";
			labelA2Bit11.Click += LabelA2Bit11_Click;
			labelA2Bit11.Enter += Control_Enter;
			labelA2Bit11.Leave += Control_Leave;
			labelA2Bit11.MouseEnter += Control_Enter;
			labelA2Bit11.MouseLeave += Control_Leave;
			// 
			// labelA2Bit15
			// 
			labelA2Bit15.AccessibleDescription = "Shows bit 15 of byte 2 in A2";
			labelA2Bit15.AccessibleName = "Bit 15 of byte 2 in A2";
			labelA2Bit15.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit15.Location = new Point(-1, 18);
			labelA2Bit15.Name = "labelA2Bit15";
			labelA2Bit15.Size = new Size(24, 20);
			labelA2Bit15.TabIndex = 33;
			labelA2Bit15.ToolTipValues.Description = "Shows bit 15 of byte 2 in A2";
			labelA2Bit15.ToolTipValues.EnableToolTips = true;
			labelA2Bit15.ToolTipValues.Heading = "Bit 15 of byte 2 in A2";
			labelA2Bit15.Values.Text = "15";
			labelA2Bit15.Click += LabelA2Bit15_Click;
			labelA2Bit15.Enter += Control_Enter;
			labelA2Bit15.Leave += Control_Leave;
			labelA2Bit15.MouseEnter += Control_Enter;
			labelA2Bit15.MouseLeave += Control_Leave;
			// 
			// labelA2Bit08
			// 
			labelA2Bit08.AccessibleDescription = "Shows bit 08 of byte 2 in A2";
			labelA2Bit08.AccessibleName = "Bit 08 of byte 2 in A2";
			labelA2Bit08.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit08.Location = new Point(167, 18);
			labelA2Bit08.Name = "labelA2Bit08";
			labelA2Bit08.Size = new Size(24, 20);
			labelA2Bit08.TabIndex = 19;
			labelA2Bit08.ToolTipValues.Description = "Shows bit 08 of byte 2 in A2";
			labelA2Bit08.ToolTipValues.EnableToolTips = true;
			labelA2Bit08.ToolTipValues.Heading = "Bit 08 of byte 2 in A2";
			labelA2Bit08.Values.Text = "08";
			labelA2Bit08.Click += LabelA2Bit08_Click;
			labelA2Bit08.Enter += Control_Enter;
			labelA2Bit08.Leave += Control_Leave;
			labelA2Bit08.MouseEnter += Control_Enter;
			labelA2Bit08.MouseLeave += Control_Leave;
			// 
			// checkBoxA2Bit12
			// 
			checkBoxA2Bit12.AccessibleDescription = "Shows bit 12 of byte 2 in A2";
			checkBoxA2Bit12.AccessibleName = "Bit 12 of byte 2 in A2";
			checkBoxA2Bit12.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit12.Location = new Point(70, 38);
			checkBoxA2Bit12.Name = "checkBoxA2Bit12";
			checkBoxA2Bit12.Size = new Size(19, 14);
			checkBoxA2Bit12.TabIndex = 26;
			checkBoxA2Bit12.ToolTipValues.Description = "Shows bit 12 of byte 2 in A2";
			checkBoxA2Bit12.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit12.ToolTipValues.Heading = "Bit 12 of byte 2 in A2";
			checkBoxA2Bit12.Values.Text = "";
			checkBoxA2Bit12.CheckedChanged += CheckBoxA2Bit12_CheckedChanged;
			checkBoxA2Bit12.Enter += Control_Enter;
			checkBoxA2Bit12.Leave += Control_Leave;
			checkBoxA2Bit12.MouseEnter += Control_Enter;
			checkBoxA2Bit12.MouseLeave += Control_Leave;
			// 
			// checkBoxA2Bit08
			// 
			checkBoxA2Bit08.AccessibleDescription = "Shows bit 08 of byte 2 in A2";
			checkBoxA2Bit08.AccessibleName = "Bit 08 of byte 2 in A2";
			checkBoxA2Bit08.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit08.Location = new Point(173, 38);
			checkBoxA2Bit08.Name = "checkBoxA2Bit08";
			checkBoxA2Bit08.Size = new Size(19, 14);
			checkBoxA2Bit08.TabIndex = 18;
			checkBoxA2Bit08.ToolTipValues.Description = "Shows bit 08 of byte 2 in A2";
			checkBoxA2Bit08.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit08.ToolTipValues.Heading = "Bit 08 of byte 2 in A2";
			checkBoxA2Bit08.Values.Text = "";
			checkBoxA2Bit08.CheckedChanged += CheckBoxA2Bit08_CheckedChanged;
			checkBoxA2Bit08.Enter += Control_Enter;
			checkBoxA2Bit08.Leave += Control_Leave;
			checkBoxA2Bit08.MouseEnter += Control_Enter;
			checkBoxA2Bit08.MouseLeave += Control_Leave;
			// 
			// labelA2Bit12
			// 
			labelA2Bit12.AccessibleDescription = "Shows bit 12 of byte 2 in A2";
			labelA2Bit12.AccessibleName = "Bit 12 of byte 2 in A2";
			labelA2Bit12.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit12.Location = new Point(65, 18);
			labelA2Bit12.Name = "labelA2Bit12";
			labelA2Bit12.Size = new Size(24, 20);
			labelA2Bit12.TabIndex = 27;
			labelA2Bit12.ToolTipValues.Description = "Shows bit 12 of byte 2 in A2";
			labelA2Bit12.ToolTipValues.EnableToolTips = true;
			labelA2Bit12.ToolTipValues.Heading = "Bit 12 of byte 2 in A2";
			labelA2Bit12.Values.Text = "12";
			labelA2Bit12.Click += LabelA2Bit12_Click;
			labelA2Bit12.Enter += Control_Enter;
			labelA2Bit12.Leave += Control_Leave;
			labelA2Bit12.MouseEnter += Control_Enter;
			labelA2Bit12.MouseLeave += Control_Leave;
			// 
			// checkBoxA2Bit13
			// 
			checkBoxA2Bit13.AccessibleDescription = "Shows bit 13 of byte 2 in A2";
			checkBoxA2Bit13.AccessibleName = "Bit 13 of byte 2 in A2";
			checkBoxA2Bit13.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit13.Location = new Point(48, 38);
			checkBoxA2Bit13.Name = "checkBoxA2Bit13";
			checkBoxA2Bit13.Size = new Size(19, 14);
			checkBoxA2Bit13.TabIndex = 28;
			checkBoxA2Bit13.ToolTipValues.Description = "Shows bit 13 of byte 2 in A2";
			checkBoxA2Bit13.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit13.ToolTipValues.Heading = "Bit 13 of byte 2 in A2";
			checkBoxA2Bit13.Values.Text = "";
			checkBoxA2Bit13.CheckedChanged += CheckBoxA2Bit13_CheckedChanged;
			checkBoxA2Bit13.Enter += Control_Enter;
			checkBoxA2Bit13.Leave += Control_Leave;
			checkBoxA2Bit13.MouseEnter += Control_Enter;
			checkBoxA2Bit13.MouseLeave += Control_Leave;
			// 
			// labelA2Bit13
			// 
			labelA2Bit13.AccessibleDescription = "Shows bit 13 of byte 2 in A2";
			labelA2Bit13.AccessibleName = "Bit 13 of byte 2 in A2";
			labelA2Bit13.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit13.Location = new Point(43, 18);
			labelA2Bit13.Name = "labelA2Bit13";
			labelA2Bit13.Size = new Size(24, 20);
			labelA2Bit13.TabIndex = 29;
			labelA2Bit13.ToolTipValues.Description = "Shows bit 13 of byte 2 in A2";
			labelA2Bit13.ToolTipValues.EnableToolTips = true;
			labelA2Bit13.ToolTipValues.Heading = "Bit 13 of byte 2 in A2";
			labelA2Bit13.Values.Text = "13";
			labelA2Bit13.Click += LabelA2Bit13_Click;
			labelA2Bit13.Enter += Control_Enter;
			labelA2Bit13.Leave += Control_Leave;
			labelA2Bit13.MouseEnter += Control_Enter;
			labelA2Bit13.MouseLeave += Control_Leave;
			// 
			// checkBoxA2Bit14
			// 
			checkBoxA2Bit14.AccessibleDescription = "Shows bit 14 of byte 2 in A2";
			checkBoxA2Bit14.AccessibleName = "Bit 14 of byte 2 in A2";
			checkBoxA2Bit14.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit14.Location = new Point(26, 38);
			checkBoxA2Bit14.Name = "checkBoxA2Bit14";
			checkBoxA2Bit14.Size = new Size(19, 14);
			checkBoxA2Bit14.TabIndex = 30;
			checkBoxA2Bit14.ToolTipValues.Description = "Shows bit 14 of byte 2 in A2";
			checkBoxA2Bit14.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit14.ToolTipValues.Heading = "Bit 14 of byte 2 in A2";
			checkBoxA2Bit14.Values.Text = "";
			checkBoxA2Bit14.CheckedChanged += CheckBoxA2Bit14_CheckedChanged;
			checkBoxA2Bit14.Enter += Control_Enter;
			checkBoxA2Bit14.Leave += Control_Leave;
			checkBoxA2Bit14.MouseEnter += Control_Enter;
			checkBoxA2Bit14.MouseLeave += Control_Leave;
			// 
			// labelA2Bit14
			// 
			labelA2Bit14.AccessibleDescription = "Shows bit 14 of byte 2 in A2";
			labelA2Bit14.AccessibleName = "Bit 14 of byte 2 in A2";
			labelA2Bit14.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit14.Location = new Point(21, 18);
			labelA2Bit14.Name = "labelA2Bit14";
			labelA2Bit14.Size = new Size(24, 20);
			labelA2Bit14.TabIndex = 31;
			labelA2Bit14.ToolTipValues.Description = "Shows bit 14 of byte 2 in A2";
			labelA2Bit14.ToolTipValues.EnableToolTips = true;
			labelA2Bit14.ToolTipValues.Heading = "Bit 14 of byte 2 in A2";
			labelA2Bit14.Values.Text = "14";
			labelA2Bit14.Click += LabelA2Bit14_Click;
			labelA2Bit14.Enter += Control_Enter;
			labelA2Bit14.Leave += Control_Leave;
			labelA2Bit14.MouseEnter += Control_Enter;
			labelA2Bit14.MouseLeave += Control_Leave;
			// 
			// groupBoxA2Byte1
			// 
			groupBoxA2Byte1.AccessibleDescription = "Groups the elements of byte 1 in A2";
			groupBoxA2Byte1.AccessibleName = "Elements of byte 1 in A2";
			groupBoxA2Byte1.AccessibleRole = AccessibleRole.Grouping;
			groupBoxA2Byte1.Controls.Add(labelA2Bit07);
			groupBoxA2Byte1.Controls.Add(checkBoxA2Bit07);
			groupBoxA2Byte1.Controls.Add(labelA2Bit06);
			groupBoxA2Byte1.Controls.Add(checkBoxA2Bit00);
			groupBoxA2Byte1.Controls.Add(checkBoxA2Bit06);
			groupBoxA2Byte1.Controls.Add(labelA2Bit00);
			groupBoxA2Byte1.Controls.Add(labelA2Bit05);
			groupBoxA2Byte1.Controls.Add(checkBoxA2Bit05);
			groupBoxA2Byte1.Controls.Add(checkBoxA2Bit01);
			groupBoxA2Byte1.Controls.Add(labelA2Bit04);
			groupBoxA2Byte1.Controls.Add(checkBoxA2Bit04);
			groupBoxA2Byte1.Controls.Add(labelA2Bit01);
			groupBoxA2Byte1.Controls.Add(labelA2Bit03);
			groupBoxA2Byte1.Controls.Add(checkBoxA2Bit03);
			groupBoxA2Byte1.Controls.Add(checkBoxA2Bit02);
			groupBoxA2Byte1.Controls.Add(labelA2Bit02);
			groupBoxA2Byte1.Location = new Point(618, 66);
			groupBoxA2Byte1.Name = "groupBoxA2Byte1";
			groupBoxA2Byte1.Size = new Size(196, 62);
			groupBoxA2Byte1.TabIndex = 66;
			groupBoxA2Byte1.TabStop = false;
			groupBoxA2Byte1.Text = "Byte 1";
			// 
			// labelA2Bit07
			// 
			labelA2Bit07.AccessibleDescription = "Shows bit 07 of byte 1 in A2";
			labelA2Bit07.AccessibleName = "Bit 07 of byte 1 in A2";
			labelA2Bit07.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit07.Location = new Point(-1, 18);
			labelA2Bit07.Name = "labelA2Bit07";
			labelA2Bit07.Size = new Size(24, 20);
			labelA2Bit07.TabIndex = 17;
			labelA2Bit07.ToolTipValues.Description = "Shows bit 07 of byte 1 in A2";
			labelA2Bit07.ToolTipValues.EnableToolTips = true;
			labelA2Bit07.ToolTipValues.Heading = "Bit 07 of byte 1 in A2";
			labelA2Bit07.Values.Text = "07";
			labelA2Bit07.Click += LabelA2Bit07_Click;
			labelA2Bit07.Enter += Control_Enter;
			labelA2Bit07.Leave += Control_Leave;
			labelA2Bit07.MouseEnter += Control_Enter;
			labelA2Bit07.MouseLeave += Control_Leave;
			// 
			// checkBoxA2Bit07
			// 
			checkBoxA2Bit07.AccessibleDescription = "Shows bit 07 of byte 1 in A2";
			checkBoxA2Bit07.AccessibleName = "Bit 07 of byte 1 in A2";
			checkBoxA2Bit07.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit07.Location = new Point(4, 38);
			checkBoxA2Bit07.Name = "checkBoxA2Bit07";
			checkBoxA2Bit07.Size = new Size(19, 14);
			checkBoxA2Bit07.TabIndex = 16;
			checkBoxA2Bit07.ToolTipValues.Description = "Shows bit 07 of byte 1 in A2";
			checkBoxA2Bit07.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit07.ToolTipValues.Heading = "Bit 07 of byte 1 in A2";
			checkBoxA2Bit07.Values.Text = "";
			checkBoxA2Bit07.CheckedChanged += CheckBoxA2Bit07_CheckedChanged;
			checkBoxA2Bit07.Enter += Control_Enter;
			checkBoxA2Bit07.Leave += Control_Leave;
			checkBoxA2Bit07.MouseEnter += Control_Enter;
			checkBoxA2Bit07.MouseLeave += Control_Leave;
			// 
			// labelA2Bit06
			// 
			labelA2Bit06.AccessibleDescription = "Shows bit 06 of byte 1 in A2";
			labelA2Bit06.AccessibleName = "Bit 06 of byte 1 in A2";
			labelA2Bit06.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit06.Location = new Point(21, 18);
			labelA2Bit06.Name = "labelA2Bit06";
			labelA2Bit06.Size = new Size(24, 20);
			labelA2Bit06.TabIndex = 15;
			labelA2Bit06.ToolTipValues.Description = "Shows bit 06 of byte 1 in A2";
			labelA2Bit06.ToolTipValues.EnableToolTips = true;
			labelA2Bit06.ToolTipValues.Heading = "Bit 06 of byte 1 in A2";
			labelA2Bit06.Values.Text = "06";
			labelA2Bit06.Click += LabelA2Bit06_Click;
			labelA2Bit06.Enter += Control_Enter;
			labelA2Bit06.Leave += Control_Leave;
			labelA2Bit06.MouseEnter += Control_Enter;
			labelA2Bit06.MouseLeave += Control_Leave;
			// 
			// checkBoxA2Bit00
			// 
			checkBoxA2Bit00.AccessibleDescription = "Shows bit 00 of byte 1 in A2";
			checkBoxA2Bit00.AccessibleName = "Bit 00 of byte 1 in A2";
			checkBoxA2Bit00.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit00.Location = new Point(173, 38);
			checkBoxA2Bit00.Name = "checkBoxA2Bit00";
			checkBoxA2Bit00.Size = new Size(19, 14);
			checkBoxA2Bit00.TabIndex = 0;
			checkBoxA2Bit00.ToolTipValues.Description = "Shows bit 00 of byte 1 in A2";
			checkBoxA2Bit00.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit00.ToolTipValues.Heading = "Bit 00 of byte 1 in A2";
			checkBoxA2Bit00.Values.Text = "";
			checkBoxA2Bit00.CheckedChanged += CheckBoxA2Bit00_CheckedChanged;
			checkBoxA2Bit00.Enter += Control_Enter;
			checkBoxA2Bit00.Leave += Control_Leave;
			checkBoxA2Bit00.MouseEnter += Control_Enter;
			checkBoxA2Bit00.MouseLeave += Control_Leave;
			// 
			// checkBoxA2Bit06
			// 
			checkBoxA2Bit06.AccessibleDescription = "Shows bit 06 of byte 1 in A2";
			checkBoxA2Bit06.AccessibleName = "Bit 06 of byte 1 in A2";
			checkBoxA2Bit06.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit06.Location = new Point(26, 38);
			checkBoxA2Bit06.Name = "checkBoxA2Bit06";
			checkBoxA2Bit06.Size = new Size(19, 14);
			checkBoxA2Bit06.TabIndex = 14;
			checkBoxA2Bit06.ToolTipValues.Description = "Shows bit 06 of byte 1 in A2";
			checkBoxA2Bit06.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit06.ToolTipValues.Heading = "Bit 06 of byte 1 in A2";
			checkBoxA2Bit06.Values.Text = "";
			checkBoxA2Bit06.CheckedChanged += CheckBoxA2Bit06_CheckedChanged;
			checkBoxA2Bit06.Enter += Control_Enter;
			checkBoxA2Bit06.Leave += Control_Leave;
			checkBoxA2Bit06.MouseEnter += Control_Enter;
			checkBoxA2Bit06.MouseLeave += Control_Leave;
			// 
			// labelA2Bit00
			// 
			labelA2Bit00.AccessibleDescription = "Shows bit 00 of byte 1 in A2";
			labelA2Bit00.AccessibleName = "Bit 00 of byte 1 in A2";
			labelA2Bit00.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit00.Location = new Point(167, 18);
			labelA2Bit00.Name = "labelA2Bit00";
			labelA2Bit00.Size = new Size(24, 20);
			labelA2Bit00.TabIndex = 1;
			labelA2Bit00.ToolTipValues.Description = "Shows bit 00 of byte 1 in A2";
			labelA2Bit00.ToolTipValues.EnableToolTips = true;
			labelA2Bit00.ToolTipValues.Heading = "Bit 00 of byte 1 in A2";
			labelA2Bit00.Values.Text = "00";
			labelA2Bit00.Click += LabelA2Bit00_Click;
			labelA2Bit00.Enter += Control_Enter;
			labelA2Bit00.Leave += Control_Leave;
			labelA2Bit00.MouseEnter += Control_Enter;
			labelA2Bit00.MouseLeave += Control_Leave;
			// 
			// labelA2Bit05
			// 
			labelA2Bit05.AccessibleDescription = "Shows bit 05 of byte 1 in A2";
			labelA2Bit05.AccessibleName = "Bit 05 of byte 1 in A2";
			labelA2Bit05.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit05.Location = new Point(43, 18);
			labelA2Bit05.Name = "labelA2Bit05";
			labelA2Bit05.Size = new Size(24, 20);
			labelA2Bit05.TabIndex = 13;
			labelA2Bit05.ToolTipValues.Description = "Shows bit 05 of byte 1 in A2";
			labelA2Bit05.ToolTipValues.EnableToolTips = true;
			labelA2Bit05.ToolTipValues.Heading = "Bit 05 of byte 1 in A2";
			labelA2Bit05.Values.Text = "05";
			labelA2Bit05.Click += LabelA2Bit05_Click;
			labelA2Bit05.Enter += Control_Enter;
			labelA2Bit05.Leave += Control_Leave;
			labelA2Bit05.MouseEnter += Control_Enter;
			labelA2Bit05.MouseLeave += Control_Leave;
			// 
			// checkBoxA2Bit05
			// 
			checkBoxA2Bit05.AccessibleDescription = "Shows bit 05 of byte 1 in A2";
			checkBoxA2Bit05.AccessibleName = "Bit 05 of byte 1 in A2";
			checkBoxA2Bit05.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit05.Location = new Point(48, 38);
			checkBoxA2Bit05.Name = "checkBoxA2Bit05";
			checkBoxA2Bit05.Size = new Size(19, 14);
			checkBoxA2Bit05.TabIndex = 12;
			checkBoxA2Bit05.ToolTipValues.Description = "Shows bit 05 of byte 1 in A2";
			checkBoxA2Bit05.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit05.ToolTipValues.Heading = "Bit 05 of byte 1 in A2";
			checkBoxA2Bit05.Values.Text = "";
			checkBoxA2Bit05.CheckedChanged += CheckBoxA2Bit05_CheckedChanged;
			checkBoxA2Bit05.Enter += Control_Enter;
			checkBoxA2Bit05.Leave += Control_Leave;
			checkBoxA2Bit05.MouseEnter += Control_Enter;
			checkBoxA2Bit05.MouseLeave += Control_Leave;
			// 
			// checkBoxA2Bit01
			// 
			checkBoxA2Bit01.AccessibleDescription = "Shows bit 01 of byte 1 in A2";
			checkBoxA2Bit01.AccessibleName = "Bit 01 of byte 1 in A2";
			checkBoxA2Bit01.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit01.Location = new Point(151, 38);
			checkBoxA2Bit01.Name = "checkBoxA2Bit01";
			checkBoxA2Bit01.Size = new Size(19, 14);
			checkBoxA2Bit01.TabIndex = 2;
			checkBoxA2Bit01.ToolTipValues.Description = "Shows bit 01 of byte 1 in A2";
			checkBoxA2Bit01.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit01.ToolTipValues.Heading = "Bit 01 of byte 1 in A2";
			checkBoxA2Bit01.Values.Text = "";
			checkBoxA2Bit01.CheckedChanged += CheckBoxA2Bit01_CheckedChanged;
			checkBoxA2Bit01.Enter += Control_Enter;
			checkBoxA2Bit01.Leave += Control_Leave;
			checkBoxA2Bit01.MouseEnter += Control_Enter;
			checkBoxA2Bit01.MouseLeave += Control_Leave;
			// 
			// labelA2Bit04
			// 
			labelA2Bit04.AccessibleDescription = "Shows bit 04 of byte 1 in A2";
			labelA2Bit04.AccessibleName = "Bit 04 of byte 1 in A2";
			labelA2Bit04.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit04.Location = new Point(65, 18);
			labelA2Bit04.Name = "labelA2Bit04";
			labelA2Bit04.Size = new Size(24, 20);
			labelA2Bit04.TabIndex = 11;
			labelA2Bit04.ToolTipValues.Description = "Shows bit 04 of byte 1 in A2";
			labelA2Bit04.ToolTipValues.EnableToolTips = true;
			labelA2Bit04.ToolTipValues.Heading = "Bit 04 of byte 1 in A2";
			labelA2Bit04.Values.Text = "04";
			labelA2Bit04.Click += LabelA2Bit04_Click;
			labelA2Bit04.Enter += Control_Enter;
			labelA2Bit04.Leave += Control_Leave;
			labelA2Bit04.MouseEnter += Control_Enter;
			labelA2Bit04.MouseLeave += Control_Leave;
			// 
			// checkBoxA2Bit04
			// 
			checkBoxA2Bit04.AccessibleDescription = "Shows bit 04 of byte 1 in A2";
			checkBoxA2Bit04.AccessibleName = "Bit 04 of byte 1 in A2";
			checkBoxA2Bit04.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit04.Location = new Point(70, 38);
			checkBoxA2Bit04.Name = "checkBoxA2Bit04";
			checkBoxA2Bit04.Size = new Size(19, 14);
			checkBoxA2Bit04.TabIndex = 10;
			checkBoxA2Bit04.ToolTipValues.Description = "Shows bit 04 of byte 1 in A2";
			checkBoxA2Bit04.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit04.ToolTipValues.Heading = "Bit 04 of byte 1 in A2";
			checkBoxA2Bit04.Values.Text = "";
			checkBoxA2Bit04.CheckedChanged += CheckBoxA2Bit04_CheckedChanged;
			checkBoxA2Bit04.Enter += Control_Enter;
			checkBoxA2Bit04.Leave += Control_Leave;
			checkBoxA2Bit04.MouseEnter += Control_Enter;
			checkBoxA2Bit04.MouseLeave += Control_Leave;
			// 
			// labelA2Bit01
			// 
			labelA2Bit01.AccessibleDescription = "Shows bit 01 of byte 1 in A2";
			labelA2Bit01.AccessibleName = "Bit 01 of byte 1 in A2";
			labelA2Bit01.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit01.Location = new Point(146, 18);
			labelA2Bit01.Name = "labelA2Bit01";
			labelA2Bit01.Size = new Size(24, 20);
			labelA2Bit01.TabIndex = 3;
			labelA2Bit01.ToolTipValues.Description = "Shows bit 01 of byte 1 in A2";
			labelA2Bit01.ToolTipValues.EnableToolTips = true;
			labelA2Bit01.ToolTipValues.Heading = "Bit 01 of byte 1 in A2";
			labelA2Bit01.Values.Text = "01";
			labelA2Bit01.Click += LabelA2Bit01_Click;
			labelA2Bit01.Enter += Control_Enter;
			labelA2Bit01.Leave += Control_Leave;
			labelA2Bit01.MouseEnter += Control_Enter;
			labelA2Bit01.MouseLeave += Control_Leave;
			// 
			// labelA2Bit03
			// 
			labelA2Bit03.AccessibleDescription = "Shows bit 03 of byte 1 in A2";
			labelA2Bit03.AccessibleName = "Bit 03 of byte 1 in A2";
			labelA2Bit03.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit03.Location = new Point(100, 18);
			labelA2Bit03.Name = "labelA2Bit03";
			labelA2Bit03.Size = new Size(24, 20);
			labelA2Bit03.TabIndex = 7;
			labelA2Bit03.ToolTipValues.Description = "Shows bit 03 of byte 1 in A2";
			labelA2Bit03.ToolTipValues.EnableToolTips = true;
			labelA2Bit03.ToolTipValues.Heading = "Bit 03 of byte 1 in A2";
			labelA2Bit03.Values.Text = "03";
			labelA2Bit03.Click += LabelA2Bit03_Click;
			labelA2Bit03.Enter += Control_Enter;
			labelA2Bit03.Leave += Control_Leave;
			labelA2Bit03.MouseEnter += Control_Enter;
			labelA2Bit03.MouseLeave += Control_Leave;
			// 
			// checkBoxA2Bit03
			// 
			checkBoxA2Bit03.AccessibleDescription = "Shows bit 03 of byte 1 in A2";
			checkBoxA2Bit03.AccessibleName = "Bit 03 of byte 1 in A2";
			checkBoxA2Bit03.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit03.Location = new Point(106, 38);
			checkBoxA2Bit03.Name = "checkBoxA2Bit03";
			checkBoxA2Bit03.Size = new Size(19, 14);
			checkBoxA2Bit03.TabIndex = 6;
			checkBoxA2Bit03.ToolTipValues.Description = "Shows bit 03 of byte 1 in A2";
			checkBoxA2Bit03.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit03.ToolTipValues.Heading = "Bit 03 of byte 1 in A2";
			checkBoxA2Bit03.Values.Text = "";
			checkBoxA2Bit03.CheckedChanged += CheckBoxA2Bit03_CheckedChanged;
			checkBoxA2Bit03.Enter += Control_Enter;
			checkBoxA2Bit03.Leave += Control_Leave;
			checkBoxA2Bit03.MouseEnter += Control_Enter;
			checkBoxA2Bit03.MouseLeave += Control_Leave;
			// 
			// checkBoxA2Bit02
			// 
			checkBoxA2Bit02.AccessibleDescription = "Shows bit 02 of byte 1 in A2";
			checkBoxA2Bit02.AccessibleName = "Bit 02 of byte 1 in A2";
			checkBoxA2Bit02.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA2Bit02.Location = new Point(129, 38);
			checkBoxA2Bit02.Name = "checkBoxA2Bit02";
			checkBoxA2Bit02.Size = new Size(19, 14);
			checkBoxA2Bit02.TabIndex = 4;
			checkBoxA2Bit02.ToolTipValues.Description = "Shows bit 02 of byte 1 in A2";
			checkBoxA2Bit02.ToolTipValues.EnableToolTips = true;
			checkBoxA2Bit02.ToolTipValues.Heading = "Bit 02 of byte 1 in A2";
			checkBoxA2Bit02.Values.Text = "";
			checkBoxA2Bit02.CheckedChanged += CheckBoxA2Bit02_CheckedChanged;
			checkBoxA2Bit02.Enter += Control_Enter;
			checkBoxA2Bit02.Leave += Control_Leave;
			checkBoxA2Bit02.MouseEnter += Control_Enter;
			checkBoxA2Bit02.MouseLeave += Control_Leave;
			// 
			// labelA2Bit02
			// 
			labelA2Bit02.AccessibleDescription = "Shows bit 02 of byte 1 in A2";
			labelA2Bit02.AccessibleName = "Bit 02 of byte 1 in A2";
			labelA2Bit02.AccessibleRole = AccessibleRole.StaticText;
			labelA2Bit02.Location = new Point(124, 18);
			labelA2Bit02.Name = "labelA2Bit02";
			labelA2Bit02.Size = new Size(24, 20);
			labelA2Bit02.TabIndex = 5;
			labelA2Bit02.ToolTipValues.Description = "Shows bit 02 of byte 1 in A2";
			labelA2Bit02.ToolTipValues.EnableToolTips = true;
			labelA2Bit02.ToolTipValues.Heading = "Bit 02 of byte 1 in A2";
			labelA2Bit02.Values.Text = "02";
			labelA2Bit02.Click += LabelA2Bit02_Click;
			labelA2Bit02.Enter += Control_Enter;
			labelA2Bit02.Leave += Control_Leave;
			labelA2Bit02.MouseEnter += Control_Enter;
			labelA2Bit02.MouseLeave += Control_Leave;
			// 
			// groupBoxAccumulator1
			// 
			groupBoxAccumulator1.AccessibleDescription = "Groups the elements of A1";
			groupBoxAccumulator1.AccessibleName = "Elements of A1";
			groupBoxAccumulator1.AccessibleRole = AccessibleRole.Grouping;
			groupBoxAccumulator1.BackColor = Color.Transparent;
			groupBoxAccumulator1.Controls.Add(textBoxA1Octal);
			groupBoxAccumulator1.Controls.Add(labelA1Octal);
			groupBoxAccumulator1.Controls.Add(maskedTextBoxA1Network);
			groupBoxAccumulator1.Controls.Add(labelA1Network);
			groupBoxAccumulator1.Controls.Add(textBoxA1Decimal);
			groupBoxAccumulator1.Controls.Add(textBoxA1Hexadecimal);
			groupBoxAccumulator1.Controls.Add(labelA1Decimal);
			groupBoxAccumulator1.Controls.Add(labelA1Hexadecimal);
			groupBoxAccumulator1.Controls.Add(groupBoxA1Byte4);
			groupBoxAccumulator1.Controls.Add(groupBoxA1Byte3);
			groupBoxAccumulator1.Controls.Add(groupBoxA1Byte2);
			groupBoxAccumulator1.Controls.Add(groupBoxA1Byte1);
			groupBoxAccumulator1.Location = new Point(14, 14);
			groupBoxAccumulator1.Name = "groupBoxAccumulator1";
			groupBoxAccumulator1.Size = new Size(820, 135);
			groupBoxAccumulator1.TabIndex = 0;
			groupBoxAccumulator1.TabStop = false;
			groupBoxAccumulator1.Text = "Accumulator 1 (A1)";
			// 
			// textBoxA1Octal
			// 
			textBoxA1Octal.AccessibleDescription = "Shows the octal value of A1";
			textBoxA1Octal.AccessibleName = "Octal value of A1";
			textBoxA1Octal.AccessibleRole = AccessibleRole.Text;
			textBoxA1Octal.Location = new Point(457, 28);
			textBoxA1Octal.Name = "textBoxA1Octal";
			textBoxA1Octal.Size = new Size(116, 23);
			textBoxA1Octal.TabIndex = 14;
			textBoxA1Octal.ToolTipValues.Description = "Shows the octal value of A1";
			textBoxA1Octal.ToolTipValues.EnableToolTips = true;
			textBoxA1Octal.ToolTipValues.Heading = "Octal value of A1";
			textBoxA1Octal.Enter += Control_Enter;
			textBoxA1Octal.Leave += Control_Leave;
			textBoxA1Octal.MouseEnter += Control_Enter;
			textBoxA1Octal.MouseLeave += Control_Leave;
			// 
			// labelA1Octal
			// 
			labelA1Octal.AccessibleDescription = "Shows the description of octal value of A1";
			labelA1Octal.AccessibleName = "Description of octal value of A1";
			labelA1Octal.AccessibleRole = AccessibleRole.StaticText;
			labelA1Octal.Location = new Point(411, 31);
			labelA1Octal.Name = "labelA1Octal";
			labelA1Octal.Size = new Size(35, 20);
			labelA1Octal.TabIndex = 13;
			labelA1Octal.Values.Text = "Oct.:";
			labelA1Octal.Enter += Control_Enter;
			labelA1Octal.Leave += Control_Leave;
			labelA1Octal.MouseEnter += Control_Enter;
			labelA1Octal.MouseLeave += Control_Leave;
			// 
			// maskedTextBoxA1Network
			// 
			maskedTextBoxA1Network.AccessibleDescription = "Shows the network value of A1";
			maskedTextBoxA1Network.AccessibleName = "Network value of A1";
			maskedTextBoxA1Network.AccessibleRole = AccessibleRole.Text;
			maskedTextBoxA1Network.Location = new Point(665, 28);
			maskedTextBoxA1Network.Name = "maskedTextBoxA1Network";
			maskedTextBoxA1Network.Size = new Size(116, 23);
			maskedTextBoxA1Network.TabIndex = 5;
			maskedTextBoxA1Network.ToolTipValues.Description = "Shows the network value of A1";
			maskedTextBoxA1Network.ToolTipValues.EnableToolTips = true;
			maskedTextBoxA1Network.ToolTipValues.Heading = "Network value of A1";
			maskedTextBoxA1Network.Enter += Control_Enter;
			maskedTextBoxA1Network.Leave += Control_Leave;
			maskedTextBoxA1Network.MouseEnter += Control_Enter;
			maskedTextBoxA1Network.MouseLeave += Control_Leave;
			// 
			// labelA1Network
			// 
			labelA1Network.AccessibleDescription = "Shows the description of network value of A1";
			labelA1Network.AccessibleName = "Description of network value of A1";
			labelA1Network.AccessibleRole = AccessibleRole.StaticText;
			labelA1Network.Location = new Point(613, 31);
			labelA1Network.Name = "labelA1Network";
			labelA1Network.Size = new Size(45, 20);
			labelA1Network.TabIndex = 4;
			labelA1Network.Values.Text = "Netw.:";
			labelA1Network.Enter += Control_Enter;
			labelA1Network.Leave += Control_Leave;
			labelA1Network.MouseEnter += Control_Enter;
			labelA1Network.MouseLeave += Control_Leave;
			// 
			// textBoxA1Decimal
			// 
			textBoxA1Decimal.AccessibleDescription = "Shows the decimal value of A1";
			textBoxA1Decimal.AccessibleName = "Decimal value of A1";
			textBoxA1Decimal.AccessibleRole = AccessibleRole.Text;
			textBoxA1Decimal.Location = new Point(253, 28);
			textBoxA1Decimal.Name = "textBoxA1Decimal";
			textBoxA1Decimal.Size = new Size(116, 23);
			textBoxA1Decimal.TabIndex = 3;
			textBoxA1Decimal.ToolTipValues.Description = "Shows the decimal value of A1";
			textBoxA1Decimal.ToolTipValues.EnableToolTips = true;
			textBoxA1Decimal.ToolTipValues.Heading = "Decimal value of A1";
			textBoxA1Decimal.Enter += Control_Enter;
			textBoxA1Decimal.Leave += Control_Leave;
			textBoxA1Decimal.MouseEnter += Control_Enter;
			textBoxA1Decimal.MouseLeave += Control_Leave;
			// 
			// textBoxA1Hexadecimal
			// 
			textBoxA1Hexadecimal.AccessibleDescription = "Shows the hexadecimal value of A1";
			textBoxA1Hexadecimal.AccessibleName = "Hexadecimal value of A1";
			textBoxA1Hexadecimal.AccessibleRole = AccessibleRole.Text;
			textBoxA1Hexadecimal.Location = new Point(50, 28);
			textBoxA1Hexadecimal.Name = "textBoxA1Hexadecimal";
			textBoxA1Hexadecimal.Size = new Size(116, 23);
			textBoxA1Hexadecimal.TabIndex = 1;
			textBoxA1Hexadecimal.ToolTipValues.Description = "Shows the hexadecimal value of A1";
			textBoxA1Hexadecimal.ToolTipValues.EnableToolTips = true;
			textBoxA1Hexadecimal.ToolTipValues.Heading = "Hexadecimal value of A1";
			textBoxA1Hexadecimal.Enter += Control_Enter;
			textBoxA1Hexadecimal.Leave += Control_Leave;
			textBoxA1Hexadecimal.MouseEnter += Control_Enter;
			textBoxA1Hexadecimal.MouseLeave += Control_Leave;
			// 
			// labelA1Decimal
			// 
			labelA1Decimal.AccessibleDescription = "Shows the description of decimal value of A1";
			labelA1Decimal.AccessibleName = "Description of decimal value of A1";
			labelA1Decimal.AccessibleRole = AccessibleRole.StaticText;
			labelA1Decimal.Location = new Point(207, 31);
			labelA1Decimal.Name = "labelA1Decimal";
			labelA1Decimal.Size = new Size(37, 20);
			labelA1Decimal.TabIndex = 2;
			labelA1Decimal.Values.Text = "Dec.:";
			labelA1Decimal.Enter += Control_Enter;
			labelA1Decimal.Leave += Control_Leave;
			labelA1Decimal.MouseEnter += Control_Enter;
			labelA1Decimal.MouseLeave += Control_Leave;
			// 
			// labelA1Hexadecimal
			// 
			labelA1Hexadecimal.AccessibleDescription = "Shows the description of hexadecimal value of A1";
			labelA1Hexadecimal.AccessibleName = "Description of hexadecimal value of A1";
			labelA1Hexadecimal.AccessibleRole = AccessibleRole.StaticText;
			labelA1Hexadecimal.Location = new Point(5, 31);
			labelA1Hexadecimal.Name = "labelA1Hexadecimal";
			labelA1Hexadecimal.Size = new Size(37, 20);
			labelA1Hexadecimal.TabIndex = 0;
			labelA1Hexadecimal.Values.Text = "Hex.:";
			labelA1Hexadecimal.Enter += Control_Enter;
			labelA1Hexadecimal.Leave += Control_Leave;
			labelA1Hexadecimal.MouseEnter += Control_Enter;
			labelA1Hexadecimal.MouseLeave += Control_Leave;
			// 
			// groupBoxA1Byte4
			// 
			groupBoxA1Byte4.AccessibleDescription = "Groups the elements of byte 44 in A1";
			groupBoxA1Byte4.AccessibleName = "Elements of byte 4 in A1";
			groupBoxA1Byte4.AccessibleRole = AccessibleRole.Grouping;
			groupBoxA1Byte4.Controls.Add(labelA1Bit31);
			groupBoxA1Byte4.Controls.Add(checkBoxA1Bit31);
			groupBoxA1Byte4.Controls.Add(checkBoxA1Bit24);
			groupBoxA1Byte4.Controls.Add(labelA1Bit24);
			groupBoxA1Byte4.Controls.Add(checkBoxA1Bit25);
			groupBoxA1Byte4.Controls.Add(labelA1Bit30);
			groupBoxA1Byte4.Controls.Add(labelA1Bit25);
			groupBoxA1Byte4.Controls.Add(checkBoxA1Bit26);
			groupBoxA1Byte4.Controls.Add(checkBoxA1Bit30);
			groupBoxA1Byte4.Controls.Add(labelA1Bit26);
			groupBoxA1Byte4.Controls.Add(labelA1Bit29);
			groupBoxA1Byte4.Controls.Add(checkBoxA1Bit27);
			groupBoxA1Byte4.Controls.Add(checkBoxA1Bit29);
			groupBoxA1Byte4.Controls.Add(labelA1Bit27);
			groupBoxA1Byte4.Controls.Add(labelA1Bit28);
			groupBoxA1Byte4.Controls.Add(checkBoxA1Bit28);
			groupBoxA1Byte4.Location = new Point(7, 66);
			groupBoxA1Byte4.Name = "groupBoxA1Byte4";
			groupBoxA1Byte4.Size = new Size(196, 62);
			groupBoxA1Byte4.TabIndex = 9;
			groupBoxA1Byte4.TabStop = false;
			groupBoxA1Byte4.Text = "Byte 4";
			// 
			// labelA1Bit31
			// 
			labelA1Bit31.AccessibleDescription = "Shows bit 31 of byte 4 in A1";
			labelA1Bit31.AccessibleName = "Bit 31 of byte 4 in A1";
			labelA1Bit31.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit31.Location = new Point(-1, 18);
			labelA1Bit31.Name = "labelA1Bit31";
			labelA1Bit31.Size = new Size(24, 20);
			labelA1Bit31.TabIndex = 0;
			labelA1Bit31.ToolTipValues.Description = "Shows bit 31 of byte 4 in A1";
			labelA1Bit31.ToolTipValues.EnableToolTips = true;
			labelA1Bit31.ToolTipValues.Heading = "Bit 31 of byte 4 in A1";
			labelA1Bit31.Values.Text = "31";
			labelA1Bit31.Click += LabelA1Bit31_Click;
			labelA1Bit31.Enter += Control_Enter;
			labelA1Bit31.Leave += Control_Leave;
			labelA1Bit31.MouseEnter += Control_Enter;
			labelA1Bit31.MouseLeave += Control_Leave;
			// 
			// checkBoxA1Bit31
			// 
			checkBoxA1Bit31.AccessibleDescription = "Shows bit 31 of byte 4 in A1";
			checkBoxA1Bit31.AccessibleName = "Bit 31 of byte 4 in A1";
			checkBoxA1Bit31.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit31.Location = new Point(4, 38);
			checkBoxA1Bit31.Name = "checkBoxA1Bit31";
			checkBoxA1Bit31.Size = new Size(19, 14);
			checkBoxA1Bit31.TabIndex = 7;
			checkBoxA1Bit31.ToolTipValues.Description = "Shows bit 31 of byte 4 in A1";
			checkBoxA1Bit31.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit31.ToolTipValues.Heading = "Bit 31 of byte 4 in A1";
			checkBoxA1Bit31.Values.Text = "";
			checkBoxA1Bit31.CheckedChanged += CheckBoxA1Bit31_CheckedChanged;
			checkBoxA1Bit31.Enter += Control_Enter;
			checkBoxA1Bit31.Leave += Control_Leave;
			checkBoxA1Bit31.MouseEnter += Control_Enter;
			checkBoxA1Bit31.MouseLeave += Control_Leave;
			// 
			// checkBoxA1Bit24
			// 
			checkBoxA1Bit24.AccessibleDescription = "Shows bit 24 of byte 4 in A1";
			checkBoxA1Bit24.AccessibleName = "Bit 24 of byte 4 in A1";
			checkBoxA1Bit24.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit24.Location = new Point(173, 38);
			checkBoxA1Bit24.Name = "checkBoxA1Bit24";
			checkBoxA1Bit24.Size = new Size(19, 14);
			checkBoxA1Bit24.TabIndex = 13;
			checkBoxA1Bit24.ToolTipValues.Description = "Shows bit 24 of byte 4 in A1";
			checkBoxA1Bit24.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit24.ToolTipValues.Heading = "Bit 24 of byte 4 in A1";
			checkBoxA1Bit24.Values.Text = "";
			checkBoxA1Bit24.CheckedChanged += CheckBoxA1Bit24_CheckedChanged;
			checkBoxA1Bit24.Enter += Control_Enter;
			checkBoxA1Bit24.Leave += Control_Leave;
			checkBoxA1Bit24.MouseEnter += Control_Enter;
			checkBoxA1Bit24.MouseLeave += Control_Leave;
			// 
			// labelA1Bit24
			// 
			labelA1Bit24.AccessibleDescription = "Shows bit 24 of byte 4 in A1";
			labelA1Bit24.AccessibleName = "Bit 24 of byte 4 in A1";
			labelA1Bit24.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit24.Location = new Point(167, 18);
			labelA1Bit24.Name = "labelA1Bit24";
			labelA1Bit24.Size = new Size(24, 20);
			labelA1Bit24.TabIndex = 6;
			labelA1Bit24.ToolTipValues.Description = "Shows bit 24 of byte 4 in A1";
			labelA1Bit24.ToolTipValues.EnableToolTips = true;
			labelA1Bit24.ToolTipValues.Heading = "Bit 24 of byte 4 in A1";
			labelA1Bit24.Values.Text = "24";
			labelA1Bit24.Click += LabelA1Bit24_Click;
			labelA1Bit24.Enter += Control_Enter;
			labelA1Bit24.Leave += Control_Leave;
			labelA1Bit24.MouseEnter += Control_Enter;
			labelA1Bit24.MouseLeave += Control_Leave;
			// 
			// checkBoxA1Bit25
			// 
			checkBoxA1Bit25.AccessibleDescription = "Shows bit 25 of byte 4 in A1";
			checkBoxA1Bit25.AccessibleName = "Bit 25 of byte 4 in A1";
			checkBoxA1Bit25.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit25.Location = new Point(151, 38);
			checkBoxA1Bit25.Name = "checkBoxA1Bit25";
			checkBoxA1Bit25.Size = new Size(19, 14);
			checkBoxA1Bit25.TabIndex = 12;
			checkBoxA1Bit25.ToolTipValues.Description = "Shows bit 25 of byte 4 in A1";
			checkBoxA1Bit25.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit25.ToolTipValues.Heading = "Bit 25 of byte 4 in A1";
			checkBoxA1Bit25.Values.Text = "";
			checkBoxA1Bit25.CheckedChanged += CheckBoxA1Bit25_CheckedChanged;
			checkBoxA1Bit25.Enter += Control_Enter;
			checkBoxA1Bit25.Leave += Control_Leave;
			checkBoxA1Bit25.MouseEnter += Control_Enter;
			checkBoxA1Bit25.MouseLeave += Control_Leave;
			// 
			// labelA1Bit30
			// 
			labelA1Bit30.AccessibleDescription = "Shows bit 30 of byte 4 in A1";
			labelA1Bit30.AccessibleName = "Bit 30 of byte 4 in A1";
			labelA1Bit30.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit30.Location = new Point(21, 18);
			labelA1Bit30.Name = "labelA1Bit30";
			labelA1Bit30.Size = new Size(24, 20);
			labelA1Bit30.TabIndex = 1;
			labelA1Bit30.ToolTipValues.Description = "Shows bit 30 of byte 4 in A1";
			labelA1Bit30.ToolTipValues.EnableToolTips = true;
			labelA1Bit30.ToolTipValues.Heading = "Bit 30 of byte 4 in A1";
			labelA1Bit30.Values.Text = "30";
			labelA1Bit30.Click += LabelA1Bit30_Click;
			labelA1Bit30.Enter += Control_Enter;
			labelA1Bit30.Leave += Control_Leave;
			labelA1Bit30.MouseEnter += Control_Enter;
			labelA1Bit30.MouseLeave += Control_Leave;
			// 
			// labelA1Bit25
			// 
			labelA1Bit25.AccessibleDescription = "Shows bit 25 of byte 4 in A1";
			labelA1Bit25.AccessibleName = "Bit 25 of byte 4 in A1";
			labelA1Bit25.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit25.Location = new Point(146, 18);
			labelA1Bit25.Name = "labelA1Bit25";
			labelA1Bit25.Size = new Size(24, 20);
			labelA1Bit25.TabIndex = 5;
			labelA1Bit25.ToolTipValues.Description = "Shows bit 25 of byte 4 in A1";
			labelA1Bit25.ToolTipValues.EnableToolTips = true;
			labelA1Bit25.ToolTipValues.Heading = "Bit 25 of byte 4 in A1";
			labelA1Bit25.Values.Text = "25";
			labelA1Bit25.Click += LabelA1Bit25_Click;
			labelA1Bit25.Enter += Control_Enter;
			labelA1Bit25.Leave += Control_Leave;
			labelA1Bit25.MouseEnter += Control_Enter;
			labelA1Bit25.MouseLeave += Control_Leave;
			// 
			// checkBoxA1Bit26
			// 
			checkBoxA1Bit26.AccessibleDescription = "Shows bit 26 of byte 4 in A1";
			checkBoxA1Bit26.AccessibleName = "Bit 26 of byte 4 in A1";
			checkBoxA1Bit26.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit26.Location = new Point(129, 38);
			checkBoxA1Bit26.Name = "checkBoxA1Bit26";
			checkBoxA1Bit26.Size = new Size(19, 14);
			checkBoxA1Bit26.TabIndex = 11;
			checkBoxA1Bit26.ToolTipValues.Description = "Shows bit 26 of byte 4 in A1";
			checkBoxA1Bit26.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit26.ToolTipValues.Heading = "Bit 26 of byte 4 in A1";
			checkBoxA1Bit26.Values.Text = "";
			checkBoxA1Bit26.CheckedChanged += CheckBoxA1Bit26_CheckedChanged;
			checkBoxA1Bit26.Enter += Control_Enter;
			checkBoxA1Bit26.Leave += Control_Leave;
			checkBoxA1Bit26.MouseEnter += Control_Enter;
			checkBoxA1Bit26.MouseLeave += Control_Leave;
			// 
			// checkBoxA1Bit30
			// 
			checkBoxA1Bit30.AccessibleDescription = "Shows bit 30 of byte 4 in A1";
			checkBoxA1Bit30.AccessibleName = "Bit 30 of byte 4 in A1";
			checkBoxA1Bit30.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit30.Location = new Point(26, 38);
			checkBoxA1Bit30.Name = "checkBoxA1Bit30";
			checkBoxA1Bit30.Size = new Size(19, 14);
			checkBoxA1Bit30.TabIndex = 8;
			checkBoxA1Bit30.ToolTipValues.Description = "Shows bit 30 of byte 4 in A1";
			checkBoxA1Bit30.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit30.ToolTipValues.Heading = "Bit 30 of byte 4 in A1";
			checkBoxA1Bit30.Values.Text = "";
			checkBoxA1Bit30.CheckedChanged += CheckBoxA1Bit30_CheckedChanged;
			checkBoxA1Bit30.Enter += Control_Enter;
			checkBoxA1Bit30.Leave += Control_Leave;
			checkBoxA1Bit30.MouseEnter += Control_Enter;
			checkBoxA1Bit30.MouseLeave += Control_Leave;
			// 
			// labelA1Bit26
			// 
			labelA1Bit26.AccessibleDescription = "Shows bit 26 of byte 4 in A1";
			labelA1Bit26.AccessibleName = "Bit 26 of byte 4 in A1";
			labelA1Bit26.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit26.Location = new Point(124, 18);
			labelA1Bit26.Name = "labelA1Bit26";
			labelA1Bit26.Size = new Size(24, 20);
			labelA1Bit26.TabIndex = 4;
			labelA1Bit26.ToolTipValues.Description = "Shows bit 26 of byte 4 in A1";
			labelA1Bit26.ToolTipValues.EnableToolTips = true;
			labelA1Bit26.ToolTipValues.Heading = "Bit 26 of byte 4 in A1";
			labelA1Bit26.Values.Text = "26";
			labelA1Bit26.Click += LabelA1Bit26_Click;
			labelA1Bit26.Enter += Control_Enter;
			labelA1Bit26.Leave += Control_Leave;
			labelA1Bit26.MouseEnter += Control_Enter;
			labelA1Bit26.MouseLeave += Control_Leave;
			// 
			// labelA1Bit29
			// 
			labelA1Bit29.AccessibleDescription = "Shows bit 29 of byte 4 in A1";
			labelA1Bit29.AccessibleName = "Bit 29 of byte 4 in A1";
			labelA1Bit29.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit29.Location = new Point(43, 18);
			labelA1Bit29.Name = "labelA1Bit29";
			labelA1Bit29.Size = new Size(24, 20);
			labelA1Bit29.TabIndex = 2;
			labelA1Bit29.ToolTipValues.Description = "Shows bit 29 of byte 4 in A1";
			labelA1Bit29.ToolTipValues.EnableToolTips = true;
			labelA1Bit29.ToolTipValues.Heading = "Bit 29 of byte 4 in A1";
			labelA1Bit29.Values.Text = "29";
			labelA1Bit29.Click += LabelA1Bit29_Click;
			labelA1Bit29.Enter += Control_Enter;
			labelA1Bit29.Leave += Control_Leave;
			labelA1Bit29.MouseEnter += Control_Enter;
			labelA1Bit29.MouseLeave += Control_Leave;
			// 
			// checkBoxA1Bit27
			// 
			checkBoxA1Bit27.AccessibleDescription = "Shows bit 27 of byte 4 in A1";
			checkBoxA1Bit27.AccessibleName = "Bit 27 of byte 4 in A1";
			checkBoxA1Bit27.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit27.Location = new Point(106, 38);
			checkBoxA1Bit27.Name = "checkBoxA1Bit27";
			checkBoxA1Bit27.Size = new Size(19, 14);
			checkBoxA1Bit27.TabIndex = 10;
			checkBoxA1Bit27.ToolTipValues.Description = "Shows bit 27 of byte 4 in A1";
			checkBoxA1Bit27.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit27.ToolTipValues.Heading = "Bit 27 of byte 4 in A1";
			checkBoxA1Bit27.Values.Text = "";
			checkBoxA1Bit27.CheckedChanged += CheckBoxA1Bit27_CheckedChanged;
			checkBoxA1Bit27.Enter += Control_Enter;
			checkBoxA1Bit27.Leave += Control_Leave;
			checkBoxA1Bit27.MouseEnter += Control_Enter;
			checkBoxA1Bit27.MouseLeave += Control_Leave;
			// 
			// checkBoxA1Bit29
			// 
			checkBoxA1Bit29.AccessibleDescription = "Shows bit 29 of byte 4 in A1";
			checkBoxA1Bit29.AccessibleName = "Bit 29 of byte 4 in A1";
			checkBoxA1Bit29.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit29.Location = new Point(48, 38);
			checkBoxA1Bit29.Name = "checkBoxA1Bit29";
			checkBoxA1Bit29.Size = new Size(19, 14);
			checkBoxA1Bit29.TabIndex = 9;
			checkBoxA1Bit29.ToolTipValues.Description = "Shows bit 29 of byte 4 in A1";
			checkBoxA1Bit29.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit29.ToolTipValues.Heading = "Bit 29 of byte 4 in A1";
			checkBoxA1Bit29.Values.Text = "";
			checkBoxA1Bit29.CheckedChanged += CheckBoxA1Bit29_CheckedChanged;
			checkBoxA1Bit29.Enter += Control_Enter;
			checkBoxA1Bit29.Leave += Control_Leave;
			checkBoxA1Bit29.MouseEnter += Control_Enter;
			checkBoxA1Bit29.MouseLeave += Control_Leave;
			// 
			// labelA1Bit27
			// 
			labelA1Bit27.AccessibleDescription = "Shows bit 27 of byte 4 in A1";
			labelA1Bit27.AccessibleName = "Bit 27 of byte 4 in A1";
			labelA1Bit27.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit27.Location = new Point(100, 18);
			labelA1Bit27.Name = "labelA1Bit27";
			labelA1Bit27.Size = new Size(24, 20);
			labelA1Bit27.TabIndex = 3;
			labelA1Bit27.ToolTipValues.Description = "Shows bit 27 of byte 4 in A1";
			labelA1Bit27.ToolTipValues.EnableToolTips = true;
			labelA1Bit27.ToolTipValues.Heading = "Bit 27 of byte 4 in A1";
			labelA1Bit27.Values.Text = "27";
			labelA1Bit27.Click += LabelA1Bit27_Click;
			labelA1Bit27.Enter += Control_Enter;
			labelA1Bit27.Leave += Control_Leave;
			labelA1Bit27.MouseEnter += Control_Enter;
			labelA1Bit27.MouseLeave += Control_Leave;
			// 
			// labelA1Bit28
			// 
			labelA1Bit28.AccessibleDescription = "Shows bit 28 of byte 4 in A1";
			labelA1Bit28.AccessibleName = "Bit 28 of byte 4 in A1";
			labelA1Bit28.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit28.Location = new Point(65, 18);
			labelA1Bit28.Name = "labelA1Bit28";
			labelA1Bit28.Size = new Size(24, 20);
			labelA1Bit28.TabIndex = 59;
			labelA1Bit28.ToolTipValues.Description = "Shows bit 28 of byte 4 in A1";
			labelA1Bit28.ToolTipValues.EnableToolTips = true;
			labelA1Bit28.ToolTipValues.Heading = "Bit 28 of byte 4 in A1";
			labelA1Bit28.Values.Text = "28";
			labelA1Bit28.Click += LabelA1Bit28_Click;
			labelA1Bit28.Enter += Control_Enter;
			labelA1Bit28.Leave += Control_Leave;
			labelA1Bit28.MouseEnter += Control_Enter;
			labelA1Bit28.MouseLeave += Control_Leave;
			// 
			// checkBoxA1Bit28
			// 
			checkBoxA1Bit28.AccessibleDescription = "Shows bit 28 of byte 4 in A1";
			checkBoxA1Bit28.AccessibleName = "Bit 28 of byte 4 in A1";
			checkBoxA1Bit28.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit28.Location = new Point(70, 38);
			checkBoxA1Bit28.Name = "checkBoxA1Bit28";
			checkBoxA1Bit28.Size = new Size(19, 14);
			checkBoxA1Bit28.TabIndex = 58;
			checkBoxA1Bit28.ToolTipValues.Description = "Shows bit 28 of byte 4 in A1";
			checkBoxA1Bit28.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit28.ToolTipValues.Heading = "Bit 28 of byte 4 in A1";
			checkBoxA1Bit28.Values.Text = "";
			checkBoxA1Bit28.CheckedChanged += CheckBoxA1Bit28_CheckedChanged;
			checkBoxA1Bit28.Enter += Control_Enter;
			checkBoxA1Bit28.Leave += Control_Leave;
			checkBoxA1Bit28.MouseEnter += Control_Enter;
			checkBoxA1Bit28.MouseLeave += Control_Leave;
			// 
			// groupBoxA1Byte3
			// 
			groupBoxA1Byte3.AccessibleDescription = "Groups the elements of byte 3 in A1";
			groupBoxA1Byte3.AccessibleName = "Elements of byte 3 in A1";
			groupBoxA1Byte3.AccessibleRole = AccessibleRole.Grouping;
			groupBoxA1Byte3.Controls.Add(checkBoxA1Bit23);
			groupBoxA1Byte3.Controls.Add(checkBoxA1Bit21);
			groupBoxA1Byte3.Controls.Add(labelA1Bit21);
			groupBoxA1Byte3.Controls.Add(labelA1Bit20);
			groupBoxA1Byte3.Controls.Add(checkBoxA1Bit22);
			groupBoxA1Byte3.Controls.Add(checkBoxA1Bit20);
			groupBoxA1Byte3.Controls.Add(labelA1Bit22);
			groupBoxA1Byte3.Controls.Add(labelA1Bit19);
			groupBoxA1Byte3.Controls.Add(checkBoxA1Bit16);
			groupBoxA1Byte3.Controls.Add(checkBoxA1Bit19);
			groupBoxA1Byte3.Controls.Add(labelA1Bit23);
			groupBoxA1Byte3.Controls.Add(labelA1Bit18);
			groupBoxA1Byte3.Controls.Add(labelA1Bit16);
			groupBoxA1Byte3.Controls.Add(checkBoxA1Bit18);
			groupBoxA1Byte3.Controls.Add(labelA1Bit17);
			groupBoxA1Byte3.Controls.Add(checkBoxA1Bit17);
			groupBoxA1Byte3.Location = new Point(212, 66);
			groupBoxA1Byte3.Name = "groupBoxA1Byte3";
			groupBoxA1Byte3.Size = new Size(196, 62);
			groupBoxA1Byte3.TabIndex = 10;
			groupBoxA1Byte3.TabStop = false;
			groupBoxA1Byte3.Text = "Byte 3";
			// 
			// checkBoxA1Bit23
			// 
			checkBoxA1Bit23.AccessibleDescription = "Shows bit 23 of byte 3 in A1";
			checkBoxA1Bit23.AccessibleName = "Bit 23 of byte 3 in A1";
			checkBoxA1Bit23.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit23.Location = new Point(4, 38);
			checkBoxA1Bit23.Name = "checkBoxA1Bit23";
			checkBoxA1Bit23.Size = new Size(19, 14);
			checkBoxA1Bit23.TabIndex = 6;
			checkBoxA1Bit23.ToolTipValues.Description = "Shows bit 23 of byte 3 in A1";
			checkBoxA1Bit23.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit23.ToolTipValues.Heading = "Bit 23 of byte 3 in A1";
			checkBoxA1Bit23.Values.Text = "";
			checkBoxA1Bit23.CheckedChanged += CheckBoxA1Bit23_CheckedChanged;
			checkBoxA1Bit23.Enter += Control_Enter;
			checkBoxA1Bit23.Leave += Control_Leave;
			checkBoxA1Bit23.MouseEnter += Control_Enter;
			checkBoxA1Bit23.MouseLeave += Control_Leave;
			// 
			// checkBoxA1Bit21
			// 
			checkBoxA1Bit21.AccessibleDescription = "Shows bit 21 of byte 3 in A1";
			checkBoxA1Bit21.AccessibleName = "Bit 21 of byte 3 in A1";
			checkBoxA1Bit21.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit21.Location = new Point(48, 38);
			checkBoxA1Bit21.Name = "checkBoxA1Bit21";
			checkBoxA1Bit21.Size = new Size(19, 14);
			checkBoxA1Bit21.TabIndex = 7;
			checkBoxA1Bit21.ToolTipValues.Description = "Shows bit 21 of byte 3 in A1";
			checkBoxA1Bit21.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit21.ToolTipValues.Heading = "Bit 21 of byte 3 in A1";
			checkBoxA1Bit21.Values.Text = "";
			checkBoxA1Bit21.CheckedChanged += CheckBoxA1Bit21_CheckedChanged;
			checkBoxA1Bit21.Enter += Control_Enter;
			checkBoxA1Bit21.Leave += Control_Leave;
			checkBoxA1Bit21.MouseEnter += Control_Enter;
			checkBoxA1Bit21.MouseLeave += Control_Leave;
			// 
			// labelA1Bit21
			// 
			labelA1Bit21.AccessibleDescription = "Shows bit 21 of byte 3 in A1";
			labelA1Bit21.AccessibleName = "Bit 21 of byte 3 in A1";
			labelA1Bit21.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit21.Location = new Point(43, 18);
			labelA1Bit21.Name = "labelA1Bit21";
			labelA1Bit21.Size = new Size(24, 20);
			labelA1Bit21.TabIndex = 1;
			labelA1Bit21.ToolTipValues.Description = "Shows bit 21 of byte 3 in A1";
			labelA1Bit21.ToolTipValues.EnableToolTips = true;
			labelA1Bit21.ToolTipValues.Heading = "Bit 21 of byte 3 in A1";
			labelA1Bit21.Values.Text = "21";
			labelA1Bit21.Click += LabelA1Bit21_Click;
			labelA1Bit21.Enter += Control_Enter;
			labelA1Bit21.Leave += Control_Leave;
			labelA1Bit21.MouseEnter += Control_Enter;
			labelA1Bit21.MouseLeave += Control_Leave;
			// 
			// labelA1Bit20
			// 
			labelA1Bit20.AccessibleDescription = "Shows bit 20 of byte 3 in A1";
			labelA1Bit20.AccessibleName = "Bit 20 of byte 3 in A1";
			labelA1Bit20.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit20.Location = new Point(65, 18);
			labelA1Bit20.Name = "labelA1Bit20";
			labelA1Bit20.Size = new Size(24, 20);
			labelA1Bit20.TabIndex = 2;
			labelA1Bit20.ToolTipValues.Description = "Shows bit 20 of byte 3 in A1";
			labelA1Bit20.ToolTipValues.EnableToolTips = true;
			labelA1Bit20.ToolTipValues.Heading = "Bit 20 of byte 3 in A1";
			labelA1Bit20.Values.Text = "20";
			labelA1Bit20.Click += LabelA1Bit20_Click;
			labelA1Bit20.Enter += Control_Enter;
			labelA1Bit20.Leave += Control_Leave;
			labelA1Bit20.MouseEnter += Control_Enter;
			labelA1Bit20.MouseLeave += Control_Leave;
			// 
			// checkBoxA1Bit22
			// 
			checkBoxA1Bit22.AccessibleDescription = "Shows bit 2 of byte 3 in A1";
			checkBoxA1Bit22.AccessibleName = "Bit 22 of byte 3 in A1";
			checkBoxA1Bit22.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit22.Location = new Point(26, 38);
			checkBoxA1Bit22.Name = "checkBoxA1Bit22";
			checkBoxA1Bit22.Size = new Size(19, 14);
			checkBoxA1Bit22.TabIndex = 46;
			checkBoxA1Bit22.ToolTipValues.Description = "Shows bit 22 of byte 3 in A1";
			checkBoxA1Bit22.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit22.ToolTipValues.Heading = "Bit 22 of byte 3 in A1";
			checkBoxA1Bit22.Values.Text = "";
			checkBoxA1Bit22.CheckedChanged += CheckBoxA1Bit22_CheckedChanged;
			checkBoxA1Bit22.Enter += Control_Enter;
			checkBoxA1Bit22.Leave += Control_Leave;
			checkBoxA1Bit22.MouseEnter += Control_Enter;
			checkBoxA1Bit22.MouseLeave += Control_Leave;
			// 
			// checkBoxA1Bit20
			// 
			checkBoxA1Bit20.AccessibleDescription = "Shows bit 20 of byte 3 in A1";
			checkBoxA1Bit20.AccessibleName = "Bit 20 of byte 3 in A1";
			checkBoxA1Bit20.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit20.Location = new Point(70, 38);
			checkBoxA1Bit20.Name = "checkBoxA1Bit20";
			checkBoxA1Bit20.Size = new Size(19, 14);
			checkBoxA1Bit20.TabIndex = 8;
			checkBoxA1Bit20.ToolTipValues.Description = "Shows bit 20 of byte 3 in A1";
			checkBoxA1Bit20.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit20.ToolTipValues.Heading = "Bit 20 of byte 3 in A1";
			checkBoxA1Bit20.Values.Text = "";
			checkBoxA1Bit20.CheckedChanged += CheckBoxA1Bit20_CheckedChanged;
			checkBoxA1Bit20.Enter += Control_Enter;
			checkBoxA1Bit20.Leave += Control_Leave;
			checkBoxA1Bit20.MouseEnter += Control_Enter;
			checkBoxA1Bit20.MouseLeave += Control_Leave;
			// 
			// labelA1Bit22
			// 
			labelA1Bit22.AccessibleDescription = "Shows bit 2 of byte 3 in A1";
			labelA1Bit22.AccessibleName = "Bit 22 of byte 3 in A1";
			labelA1Bit22.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit22.Location = new Point(21, 18);
			labelA1Bit22.Name = "labelA1Bit22";
			labelA1Bit22.Size = new Size(24, 20);
			labelA1Bit22.TabIndex = 0;
			labelA1Bit22.ToolTipValues.Description = "Shows bit 22 of byte 3 in A1";
			labelA1Bit22.ToolTipValues.EnableToolTips = true;
			labelA1Bit22.ToolTipValues.Heading = "Bit 22 of byte 3 in A1";
			labelA1Bit22.Values.Text = "22";
			labelA1Bit22.Click += LabelA1Bit22_Click;
			labelA1Bit22.Enter += Control_Enter;
			labelA1Bit22.Leave += Control_Leave;
			labelA1Bit22.MouseEnter += Control_Enter;
			labelA1Bit22.MouseLeave += Control_Leave;
			// 
			// labelA1Bit19
			// 
			labelA1Bit19.AccessibleDescription = "Shows bit 19 of byte 3 in A1";
			labelA1Bit19.AccessibleName = "Bit 19 of byte 3 in A1";
			labelA1Bit19.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit19.Location = new Point(100, 18);
			labelA1Bit19.Name = "labelA1Bit19";
			labelA1Bit19.Size = new Size(24, 20);
			labelA1Bit19.TabIndex = 3;
			labelA1Bit19.ToolTipValues.Description = "Shows bit 19 of byte 3 in A1";
			labelA1Bit19.ToolTipValues.EnableToolTips = true;
			labelA1Bit19.ToolTipValues.Heading = "Bit 19 of byte 3 in A1";
			labelA1Bit19.Values.Text = "19";
			labelA1Bit19.Click += LabelA1Bit19_Click;
			labelA1Bit19.Enter += Control_Enter;
			labelA1Bit19.Leave += Control_Leave;
			labelA1Bit19.MouseEnter += Control_Enter;
			labelA1Bit19.MouseLeave += Control_Leave;
			// 
			// checkBoxA1Bit16
			// 
			checkBoxA1Bit16.AccessibleDescription = "Shows bit 16 of byte 3 in A1";
			checkBoxA1Bit16.AccessibleName = "Bit 16 of byte 3 in A1";
			checkBoxA1Bit16.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit16.Location = new Point(173, 38);
			checkBoxA1Bit16.Name = "checkBoxA1Bit16";
			checkBoxA1Bit16.Size = new Size(19, 14);
			checkBoxA1Bit16.TabIndex = 10;
			checkBoxA1Bit16.ToolTipValues.Description = "Shows bit 16 of byte 3 in A1";
			checkBoxA1Bit16.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit16.ToolTipValues.Heading = "Bit 16 of byte 3 in A1";
			checkBoxA1Bit16.Values.Text = "";
			checkBoxA1Bit16.CheckedChanged += CheckBoxA1Bit16_CheckedChanged;
			checkBoxA1Bit16.Enter += Control_Enter;
			checkBoxA1Bit16.Leave += Control_Leave;
			checkBoxA1Bit16.MouseEnter += Control_Enter;
			checkBoxA1Bit16.MouseLeave += Control_Leave;
			// 
			// checkBoxA1Bit19
			// 
			checkBoxA1Bit19.AccessibleDescription = "Shows bit 19 of byte 3 in A1";
			checkBoxA1Bit19.AccessibleName = "Bit 19 of byte 3 in A1";
			checkBoxA1Bit19.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit19.Location = new Point(106, 38);
			checkBoxA1Bit19.Name = "checkBoxA1Bit19";
			checkBoxA1Bit19.Size = new Size(19, 14);
			checkBoxA1Bit19.TabIndex = 9;
			checkBoxA1Bit19.ToolTipValues.Description = "Shows bit 19 of byte 3 in A1";
			checkBoxA1Bit19.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit19.ToolTipValues.Heading = "Bit 19 of byte 3 in A1";
			checkBoxA1Bit19.Values.Text = "";
			checkBoxA1Bit19.CheckedChanged += CheckBoxA1Bit19_CheckedChanged;
			checkBoxA1Bit19.Enter += Control_Enter;
			checkBoxA1Bit19.Leave += Control_Leave;
			checkBoxA1Bit19.MouseEnter += Control_Enter;
			checkBoxA1Bit19.MouseLeave += Control_Leave;
			// 
			// labelA1Bit23
			// 
			labelA1Bit23.AccessibleDescription = "Shows bit 23 of byte 3 in A1";
			labelA1Bit23.AccessibleName = "Bit 23 of byte 3 in A1";
			labelA1Bit23.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit23.Location = new Point(-1, 18);
			labelA1Bit23.Name = "labelA1Bit23";
			labelA1Bit23.Size = new Size(24, 20);
			labelA1Bit23.TabIndex = 49;
			labelA1Bit23.ToolTipValues.Description = "Shows bit 23 of byte 3 in A1";
			labelA1Bit23.ToolTipValues.EnableToolTips = true;
			labelA1Bit23.ToolTipValues.Heading = "Bit 23 of byte 3 in A1";
			labelA1Bit23.Values.Text = "23";
			labelA1Bit23.Click += LabelA1Bit23_Click;
			labelA1Bit23.Enter += Control_Enter;
			labelA1Bit23.Leave += Control_Leave;
			labelA1Bit23.MouseEnter += Control_Enter;
			labelA1Bit23.MouseLeave += Control_Leave;
			// 
			// labelA1Bit18
			// 
			labelA1Bit18.AccessibleDescription = "Shows bit 18 of byte 3 in A1";
			labelA1Bit18.AccessibleName = "Bit 18 of byte 3 in A1";
			labelA1Bit18.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit18.Location = new Point(124, 18);
			labelA1Bit18.Name = "labelA1Bit18";
			labelA1Bit18.Size = new Size(24, 20);
			labelA1Bit18.TabIndex = 4;
			labelA1Bit18.ToolTipValues.Description = "Shows bit 18 of byte 3 in A1";
			labelA1Bit18.ToolTipValues.EnableToolTips = true;
			labelA1Bit18.ToolTipValues.Heading = "Bit 18 of byte 3 in A1";
			labelA1Bit18.Values.Text = "18";
			labelA1Bit18.Click += LabelA1Bit18_Click;
			labelA1Bit18.Enter += Control_Enter;
			labelA1Bit18.Leave += Control_Leave;
			labelA1Bit18.MouseEnter += Control_Enter;
			labelA1Bit18.MouseLeave += Control_Leave;
			// 
			// labelA1Bit16
			// 
			labelA1Bit16.AccessibleDescription = "Shows bit 16 of byte 3 in A1";
			labelA1Bit16.AccessibleName = "Bit 16 of byte 3 in A1";
			labelA1Bit16.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit16.Location = new Point(167, 18);
			labelA1Bit16.Name = "labelA1Bit16";
			labelA1Bit16.Size = new Size(24, 20);
			labelA1Bit16.TabIndex = 5;
			labelA1Bit16.ToolTipValues.Description = "Shows bit 16 of byte 3 in A1";
			labelA1Bit16.ToolTipValues.EnableToolTips = true;
			labelA1Bit16.ToolTipValues.Heading = "Bit 16 of byte 3 in A1";
			labelA1Bit16.Values.Text = "16";
			labelA1Bit16.Click += LabelA1Bit16_Click;
			labelA1Bit16.Enter += Control_Enter;
			labelA1Bit16.Leave += Control_Leave;
			labelA1Bit16.MouseEnter += Control_Enter;
			labelA1Bit16.MouseLeave += Control_Leave;
			// 
			// checkBoxA1Bit18
			// 
			checkBoxA1Bit18.AccessibleDescription = "Shows bit 18 of byte 3 in A1";
			checkBoxA1Bit18.AccessibleName = "Bit 18 of byte 3 in A1";
			checkBoxA1Bit18.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit18.Location = new Point(129, 38);
			checkBoxA1Bit18.Name = "checkBoxA1Bit18";
			checkBoxA1Bit18.Size = new Size(19, 14);
			checkBoxA1Bit18.TabIndex = 38;
			checkBoxA1Bit18.ToolTipValues.Description = "Shows bit 18 of byte 3 in A1";
			checkBoxA1Bit18.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit18.ToolTipValues.Heading = "Bit 18 of byte 3 in A1";
			checkBoxA1Bit18.Values.Text = "";
			checkBoxA1Bit18.CheckedChanged += CheckBoxA1Bit18_CheckedChanged;
			checkBoxA1Bit18.Enter += Control_Enter;
			checkBoxA1Bit18.Leave += Control_Leave;
			checkBoxA1Bit18.MouseEnter += Control_Enter;
			checkBoxA1Bit18.MouseLeave += Control_Leave;
			// 
			// labelA1Bit17
			// 
			labelA1Bit17.AccessibleDescription = "Shows bit 17 of byte 3 in A1";
			labelA1Bit17.AccessibleName = "Bit 17 of byte 3 in A1";
			labelA1Bit17.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit17.Location = new Point(146, 18);
			labelA1Bit17.Name = "labelA1Bit17";
			labelA1Bit17.Size = new Size(24, 20);
			labelA1Bit17.TabIndex = 37;
			labelA1Bit17.ToolTipValues.Description = "Shows bit 17 of byte 3 in A1";
			labelA1Bit17.ToolTipValues.EnableToolTips = true;
			labelA1Bit17.ToolTipValues.Heading = "Bit 17 of byte 3 in A1";
			labelA1Bit17.Values.Text = "17";
			labelA1Bit17.Click += LabelA1Bit17_Click;
			labelA1Bit17.Enter += Control_Enter;
			labelA1Bit17.Leave += Control_Leave;
			labelA1Bit17.MouseEnter += Control_Enter;
			labelA1Bit17.MouseLeave += Control_Leave;
			// 
			// checkBoxA1Bit17
			// 
			checkBoxA1Bit17.AccessibleDescription = "Shows bit 17 of byte 3 in A1";
			checkBoxA1Bit17.AccessibleName = "Bit 17 of byte 3 in A1";
			checkBoxA1Bit17.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit17.Location = new Point(151, 38);
			checkBoxA1Bit17.Name = "checkBoxA1Bit17";
			checkBoxA1Bit17.Size = new Size(19, 14);
			checkBoxA1Bit17.TabIndex = 36;
			checkBoxA1Bit17.ToolTipValues.Description = "Shows bit 17 of byte 3 in A1";
			checkBoxA1Bit17.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit17.ToolTipValues.Heading = "Bit 17 of byte 3 in A1";
			checkBoxA1Bit17.Values.Text = "";
			checkBoxA1Bit17.CheckedChanged += CheckBoxA1Bit17_CheckedChanged;
			checkBoxA1Bit17.Enter += Control_Enter;
			checkBoxA1Bit17.Leave += Control_Leave;
			checkBoxA1Bit17.MouseEnter += Control_Enter;
			checkBoxA1Bit17.MouseLeave += Control_Leave;
			// 
			// groupBoxA1Byte2
			// 
			groupBoxA1Byte2.AccessibleDescription = "Groups the elements of byte 2 in A1";
			groupBoxA1Byte2.AccessibleName = "Elements of byte 2 in A1";
			groupBoxA1Byte2.AccessibleRole = AccessibleRole.Grouping;
			groupBoxA1Byte2.Controls.Add(checkBoxA1Bit15);
			groupBoxA1Byte2.Controls.Add(checkBoxA1Bit10);
			groupBoxA1Byte2.Controls.Add(labelA1Bit10);
			groupBoxA1Byte2.Controls.Add(labelA1Bit09);
			groupBoxA1Byte2.Controls.Add(checkBoxA1Bit11);
			groupBoxA1Byte2.Controls.Add(checkBoxA1Bit09);
			groupBoxA1Byte2.Controls.Add(labelA1Bit11);
			groupBoxA1Byte2.Controls.Add(labelA1Bit15);
			groupBoxA1Byte2.Controls.Add(labelA1Bit08);
			groupBoxA1Byte2.Controls.Add(checkBoxA1Bit12);
			groupBoxA1Byte2.Controls.Add(checkBoxA1Bit08);
			groupBoxA1Byte2.Controls.Add(labelA1Bit12);
			groupBoxA1Byte2.Controls.Add(checkBoxA1Bit13);
			groupBoxA1Byte2.Controls.Add(labelA1Bit13);
			groupBoxA1Byte2.Controls.Add(checkBoxA1Bit14);
			groupBoxA1Byte2.Controls.Add(labelA1Bit14);
			groupBoxA1Byte2.Location = new Point(415, 66);
			groupBoxA1Byte2.Name = "groupBoxA1Byte2";
			groupBoxA1Byte2.Size = new Size(196, 62);
			groupBoxA1Byte2.TabIndex = 11;
			groupBoxA1Byte2.TabStop = false;
			groupBoxA1Byte2.Text = "Byte 2";
			// 
			// checkBoxA1Bit15
			// 
			checkBoxA1Bit15.AccessibleDescription = "Shows bit 15 of byte 2 in A1";
			checkBoxA1Bit15.AccessibleName = "Bit 15 of byte 2 in A1";
			checkBoxA1Bit15.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit15.Location = new Point(4, 38);
			checkBoxA1Bit15.Name = "checkBoxA1Bit15";
			checkBoxA1Bit15.Size = new Size(19, 14);
			checkBoxA1Bit15.TabIndex = 6;
			checkBoxA1Bit15.ToolTipValues.Description = "Shows bit 15 of byte 2 in A1";
			checkBoxA1Bit15.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit15.ToolTipValues.Heading = "Bit 15 of byte 2 in A1";
			checkBoxA1Bit15.Values.Text = "";
			checkBoxA1Bit15.CheckedChanged += CheckBoxA1Bit15_CheckedChanged;
			checkBoxA1Bit15.Enter += Control_Enter;
			checkBoxA1Bit15.Leave += Control_Leave;
			checkBoxA1Bit15.MouseEnter += Control_Enter;
			checkBoxA1Bit15.MouseLeave += Control_Leave;
			// 
			// checkBoxA1Bit10
			// 
			checkBoxA1Bit10.AccessibleDescription = "Shows bit 10 of byte 2 in A1";
			checkBoxA1Bit10.AccessibleName = "Bit 10 of byte 2 in A1";
			checkBoxA1Bit10.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit10.Location = new Point(129, 38);
			checkBoxA1Bit10.Name = "checkBoxA1Bit10";
			checkBoxA1Bit10.Size = new Size(19, 14);
			checkBoxA1Bit10.TabIndex = 9;
			checkBoxA1Bit10.ToolTipValues.Description = "Shows bit 10 of byte 2 in A1";
			checkBoxA1Bit10.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit10.ToolTipValues.Heading = "Bit 10 of byte 2 in A1";
			checkBoxA1Bit10.Values.Text = "";
			checkBoxA1Bit10.CheckedChanged += CheckBoxA1Bit10_CheckedChanged;
			checkBoxA1Bit10.Enter += Control_Enter;
			checkBoxA1Bit10.Leave += Control_Leave;
			checkBoxA1Bit10.MouseEnter += Control_Enter;
			checkBoxA1Bit10.MouseLeave += Control_Leave;
			// 
			// labelA1Bit10
			// 
			labelA1Bit10.AccessibleDescription = "Shows bit 10 of byte 2 in A1";
			labelA1Bit10.AccessibleName = "Bit 10 of byte 2 in A1";
			labelA1Bit10.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit10.Location = new Point(124, 18);
			labelA1Bit10.Name = "labelA1Bit10";
			labelA1Bit10.Size = new Size(24, 20);
			labelA1Bit10.TabIndex = 3;
			labelA1Bit10.ToolTipValues.Description = "Shows bit 10 of byte 2 in A1";
			labelA1Bit10.ToolTipValues.EnableToolTips = true;
			labelA1Bit10.ToolTipValues.Heading = "Bit 10 of byte 2 in A1";
			labelA1Bit10.Values.Text = "10";
			labelA1Bit10.Click += LabelA1Bit10_Click;
			labelA1Bit10.Enter += Control_Enter;
			labelA1Bit10.Leave += Control_Leave;
			labelA1Bit10.MouseEnter += Control_Enter;
			labelA1Bit10.MouseLeave += Control_Leave;
			// 
			// labelA1Bit09
			// 
			labelA1Bit09.AccessibleDescription = "Shows bit 09 of byte 2 in A1";
			labelA1Bit09.AccessibleName = "Bit 09 of byte 2 in A1";
			labelA1Bit09.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit09.Location = new Point(146, 18);
			labelA1Bit09.Name = "labelA1Bit09";
			labelA1Bit09.Size = new Size(24, 20);
			labelA1Bit09.TabIndex = 4;
			labelA1Bit09.ToolTipValues.Description = "Shows bit 09 of byte 2 in A1";
			labelA1Bit09.ToolTipValues.EnableToolTips = true;
			labelA1Bit09.ToolTipValues.Heading = "Bit 09 of byte 2 in A1";
			labelA1Bit09.Values.Text = "09";
			labelA1Bit09.Click += LabelA1Bit09_Click;
			labelA1Bit09.Enter += Control_Enter;
			labelA1Bit09.Leave += Control_Leave;
			labelA1Bit09.MouseEnter += Control_Enter;
			labelA1Bit09.MouseLeave += Control_Leave;
			// 
			// checkBoxA1Bit11
			// 
			checkBoxA1Bit11.AccessibleDescription = "Shows bit 11 of byte 2 in A1";
			checkBoxA1Bit11.AccessibleName = "Bit 11 of byte 2 in A1";
			checkBoxA1Bit11.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit11.Location = new Point(106, 38);
			checkBoxA1Bit11.Name = "checkBoxA1Bit11";
			checkBoxA1Bit11.Size = new Size(19, 14);
			checkBoxA1Bit11.TabIndex = 8;
			checkBoxA1Bit11.ToolTipValues.Description = "Shows bit 11 of byte 2 in A1";
			checkBoxA1Bit11.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit11.ToolTipValues.Heading = "Bit 11 of byte 2 in A1";
			checkBoxA1Bit11.Values.Text = "";
			checkBoxA1Bit11.CheckedChanged += CheckBoxA1Bit11_CheckedChanged;
			checkBoxA1Bit11.Enter += Control_Enter;
			checkBoxA1Bit11.Leave += Control_Leave;
			checkBoxA1Bit11.MouseEnter += Control_Enter;
			checkBoxA1Bit11.MouseLeave += Control_Leave;
			// 
			// checkBoxA1Bit09
			// 
			checkBoxA1Bit09.AccessibleDescription = "Shows bit 09 of byte 2 in A1";
			checkBoxA1Bit09.AccessibleName = "Bit 09 of byte 2 in A1";
			checkBoxA1Bit09.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit09.Location = new Point(151, 38);
			checkBoxA1Bit09.Name = "checkBoxA1Bit09";
			checkBoxA1Bit09.Size = new Size(19, 14);
			checkBoxA1Bit09.TabIndex = 10;
			checkBoxA1Bit09.ToolTipValues.Description = "Shows bit 09 of byte 2 in A1";
			checkBoxA1Bit09.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit09.ToolTipValues.Heading = "Bit 09 of byte 2 in A1";
			checkBoxA1Bit09.Values.Text = "";
			checkBoxA1Bit09.CheckedChanged += CheckBoxA1Bit09_CheckedChanged;
			checkBoxA1Bit09.Enter += Control_Enter;
			checkBoxA1Bit09.Leave += Control_Leave;
			checkBoxA1Bit09.MouseEnter += Control_Enter;
			checkBoxA1Bit09.MouseLeave += Control_Leave;
			// 
			// labelA1Bit11
			// 
			labelA1Bit11.AccessibleDescription = "Shows bit 11 of byte 2 in A1";
			labelA1Bit11.AccessibleName = "Bit 11 of byte 2 in A1";
			labelA1Bit11.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit11.Location = new Point(100, 18);
			labelA1Bit11.Name = "labelA1Bit11";
			labelA1Bit11.Size = new Size(24, 20);
			labelA1Bit11.TabIndex = 2;
			labelA1Bit11.ToolTipValues.Description = "Shows bit 11 of byte 2 in A1";
			labelA1Bit11.ToolTipValues.EnableToolTips = true;
			labelA1Bit11.ToolTipValues.Heading = "Bit 11 of byte 2 in A1";
			labelA1Bit11.Values.Text = "11";
			labelA1Bit11.Click += LabelA1Bit11_Click;
			labelA1Bit11.Enter += Control_Enter;
			labelA1Bit11.Leave += Control_Leave;
			labelA1Bit11.MouseEnter += Control_Enter;
			labelA1Bit11.MouseLeave += Control_Leave;
			// 
			// labelA1Bit15
			// 
			labelA1Bit15.AccessibleDescription = "Shows bit 15 of byte 2 in A1";
			labelA1Bit15.AccessibleName = "Bit 15 of byte 2 in A1";
			labelA1Bit15.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit15.Location = new Point(-1, 18);
			labelA1Bit15.Name = "labelA1Bit15";
			labelA1Bit15.Size = new Size(24, 20);
			labelA1Bit15.TabIndex = 0;
			labelA1Bit15.ToolTipValues.Description = "Shows bit 15 of byte 2 in A1";
			labelA1Bit15.ToolTipValues.EnableToolTips = true;
			labelA1Bit15.ToolTipValues.Heading = "Bit 15 of byte 2 in A1";
			labelA1Bit15.Values.Text = "15";
			labelA1Bit15.Click += LabelA1Bit15_Click;
			labelA1Bit15.Enter += Control_Enter;
			labelA1Bit15.Leave += Control_Leave;
			labelA1Bit15.MouseEnter += Control_Enter;
			labelA1Bit15.MouseLeave += Control_Leave;
			// 
			// labelA1Bit08
			// 
			labelA1Bit08.AccessibleDescription = "Shows bit 08 of byte 2 in A1";
			labelA1Bit08.AccessibleName = "Bit 08 of byte 2 in A1";
			labelA1Bit08.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit08.Location = new Point(167, 18);
			labelA1Bit08.Name = "labelA1Bit08";
			labelA1Bit08.Size = new Size(24, 20);
			labelA1Bit08.TabIndex = 5;
			labelA1Bit08.ToolTipValues.Description = "Shows bit 08 of byte 2 in A1";
			labelA1Bit08.ToolTipValues.EnableToolTips = true;
			labelA1Bit08.ToolTipValues.Heading = "Bit 08 of byte 2 in A1";
			labelA1Bit08.Values.Text = "08";
			labelA1Bit08.Click += LabelA1Bit08_Click;
			labelA1Bit08.Enter += Control_Enter;
			labelA1Bit08.Leave += Control_Leave;
			labelA1Bit08.MouseEnter += Control_Enter;
			labelA1Bit08.MouseLeave += Control_Leave;
			// 
			// checkBoxA1Bit12
			// 
			checkBoxA1Bit12.AccessibleDescription = "Shows bit 12 of byte 2 in A1";
			checkBoxA1Bit12.AccessibleName = "Bit 12 of byte 2 in A1";
			checkBoxA1Bit12.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit12.Location = new Point(70, 38);
			checkBoxA1Bit12.Name = "checkBoxA1Bit12";
			checkBoxA1Bit12.Size = new Size(19, 14);
			checkBoxA1Bit12.TabIndex = 7;
			checkBoxA1Bit12.ToolTipValues.Description = "Shows bit 12 of byte 2 in A1";
			checkBoxA1Bit12.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit12.ToolTipValues.Heading = "Bit 12 of byte 2 in A1";
			checkBoxA1Bit12.Values.Text = "";
			checkBoxA1Bit12.CheckedChanged += CheckBoxA1Bit12_CheckedChanged;
			checkBoxA1Bit12.Enter += Control_Enter;
			checkBoxA1Bit12.Leave += Control_Leave;
			checkBoxA1Bit12.MouseEnter += Control_Enter;
			checkBoxA1Bit12.MouseLeave += Control_Leave;
			// 
			// checkBoxA1Bit08
			// 
			checkBoxA1Bit08.AccessibleDescription = "Shows bit 08 of byte 2 in A1";
			checkBoxA1Bit08.AccessibleName = "Bit 08 of byte 2 in A1";
			checkBoxA1Bit08.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit08.Location = new Point(173, 38);
			checkBoxA1Bit08.Name = "checkBoxA1Bit08";
			checkBoxA1Bit08.Size = new Size(19, 14);
			checkBoxA1Bit08.TabIndex = 11;
			checkBoxA1Bit08.ToolTipValues.Description = "Shows bit 08 of byte 2 in A1";
			checkBoxA1Bit08.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit08.ToolTipValues.Heading = "Bit 08 of byte 2 in A1";
			checkBoxA1Bit08.Values.Text = "";
			checkBoxA1Bit08.CheckedChanged += CheckBoxA1Bit08_CheckedChanged;
			checkBoxA1Bit08.Enter += Control_Enter;
			checkBoxA1Bit08.Leave += Control_Leave;
			checkBoxA1Bit08.MouseEnter += Control_Enter;
			checkBoxA1Bit08.MouseLeave += Control_Leave;
			// 
			// labelA1Bit12
			// 
			labelA1Bit12.AccessibleDescription = "Shows bit 12 of byte 2 in A1";
			labelA1Bit12.AccessibleName = "Bit 12 of byte 2 in A1";
			labelA1Bit12.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit12.Location = new Point(65, 18);
			labelA1Bit12.Name = "labelA1Bit12";
			labelA1Bit12.Size = new Size(24, 20);
			labelA1Bit12.TabIndex = 1;
			labelA1Bit12.ToolTipValues.Description = "Shows bit 12 of byte 2 in A1";
			labelA1Bit12.ToolTipValues.EnableToolTips = true;
			labelA1Bit12.ToolTipValues.Heading = "Bit 12 of byte 2 in A1";
			labelA1Bit12.Values.Text = "12";
			labelA1Bit12.Click += LabelA1Bit12_Click;
			labelA1Bit12.Enter += Control_Enter;
			labelA1Bit12.Leave += Control_Leave;
			labelA1Bit12.MouseEnter += Control_Enter;
			labelA1Bit12.MouseLeave += Control_Leave;
			// 
			// checkBoxA1Bit13
			// 
			checkBoxA1Bit13.AccessibleDescription = "Shows bit 13 of byte 2 in A1";
			checkBoxA1Bit13.AccessibleName = "Bit 13 of byte 2 in A1";
			checkBoxA1Bit13.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit13.Location = new Point(48, 38);
			checkBoxA1Bit13.Name = "checkBoxA1Bit13";
			checkBoxA1Bit13.Size = new Size(19, 14);
			checkBoxA1Bit13.TabIndex = 28;
			checkBoxA1Bit13.ToolTipValues.Description = "Shows bit 13 of byte 2 in A1";
			checkBoxA1Bit13.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit13.ToolTipValues.Heading = "Bit 13 of byte 2 in A1";
			checkBoxA1Bit13.Values.Text = "";
			checkBoxA1Bit13.CheckedChanged += CheckBoxA1Bit13_CheckedChanged;
			checkBoxA1Bit13.Enter += Control_Enter;
			checkBoxA1Bit13.Leave += Control_Leave;
			checkBoxA1Bit13.MouseEnter += Control_Enter;
			checkBoxA1Bit13.MouseLeave += Control_Leave;
			// 
			// labelA1Bit13
			// 
			labelA1Bit13.AccessibleDescription = "Shows bit 13 of byte 2 in A1";
			labelA1Bit13.AccessibleName = "Bit 13 of byte 2 in A1";
			labelA1Bit13.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit13.Location = new Point(43, 18);
			labelA1Bit13.Name = "labelA1Bit13";
			labelA1Bit13.Size = new Size(24, 20);
			labelA1Bit13.TabIndex = 29;
			labelA1Bit13.ToolTipValues.Description = "Shows bit 13 of byte 2 in A1";
			labelA1Bit13.ToolTipValues.EnableToolTips = true;
			labelA1Bit13.ToolTipValues.Heading = "Bit 13 of byte 2 in A1";
			labelA1Bit13.Values.Text = "13";
			labelA1Bit13.Click += LabelA1Bit13_Click;
			labelA1Bit13.Enter += Control_Enter;
			labelA1Bit13.Leave += Control_Leave;
			labelA1Bit13.MouseEnter += Control_Enter;
			labelA1Bit13.MouseLeave += Control_Leave;
			// 
			// checkBoxA1Bit14
			// 
			checkBoxA1Bit14.AccessibleDescription = "Shows bit 14 of byte 2 in A1";
			checkBoxA1Bit14.AccessibleName = "Bit 14 of byte 2 in A1";
			checkBoxA1Bit14.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit14.Location = new Point(26, 38);
			checkBoxA1Bit14.Name = "checkBoxA1Bit14";
			checkBoxA1Bit14.Size = new Size(19, 14);
			checkBoxA1Bit14.TabIndex = 30;
			checkBoxA1Bit14.ToolTipValues.Description = "Shows bit 14 of byte 2 in A1";
			checkBoxA1Bit14.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit14.ToolTipValues.Heading = "Bit 14 of byte 2 in A1";
			checkBoxA1Bit14.Values.Text = "";
			checkBoxA1Bit14.CheckedChanged += CheckBoxA1Bit14_CheckedChanged;
			checkBoxA1Bit14.Enter += Control_Enter;
			checkBoxA1Bit14.Leave += Control_Leave;
			checkBoxA1Bit14.MouseEnter += Control_Enter;
			checkBoxA1Bit14.MouseLeave += Control_Leave;
			// 
			// labelA1Bit14
			// 
			labelA1Bit14.AccessibleDescription = "Shows bit 14 of byte 2 in A1";
			labelA1Bit14.AccessibleName = "Bit 14 of byte 2 in A1";
			labelA1Bit14.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit14.Location = new Point(21, 18);
			labelA1Bit14.Name = "labelA1Bit14";
			labelA1Bit14.Size = new Size(24, 20);
			labelA1Bit14.TabIndex = 31;
			labelA1Bit14.ToolTipValues.Description = "Shows bit 14 of byte 2 in A1";
			labelA1Bit14.ToolTipValues.EnableToolTips = true;
			labelA1Bit14.ToolTipValues.Heading = "Bit 14 of byte 2 in A1";
			labelA1Bit14.Values.Text = "14";
			labelA1Bit14.Click += LabelA1Bit14_Click;
			labelA1Bit14.Enter += Control_Enter;
			labelA1Bit14.Leave += Control_Leave;
			labelA1Bit14.MouseEnter += Control_Enter;
			labelA1Bit14.MouseLeave += Control_Leave;
			// 
			// groupBoxA1Byte1
			// 
			groupBoxA1Byte1.AccessibleDescription = "Groups the elements of byte 1 in A1";
			groupBoxA1Byte1.AccessibleName = "Elements of byte 1 in A1";
			groupBoxA1Byte1.AccessibleRole = AccessibleRole.Grouping;
			groupBoxA1Byte1.Controls.Add(labelA1Bit07);
			groupBoxA1Byte1.Controls.Add(checkBoxA1Bit07);
			groupBoxA1Byte1.Controls.Add(labelA1Bit06);
			groupBoxA1Byte1.Controls.Add(checkBoxA1Bit00);
			groupBoxA1Byte1.Controls.Add(checkBoxA1Bit06);
			groupBoxA1Byte1.Controls.Add(labelA1Bit00);
			groupBoxA1Byte1.Controls.Add(labelA1Bit05);
			groupBoxA1Byte1.Controls.Add(checkBoxA1Bit05);
			groupBoxA1Byte1.Controls.Add(checkBoxA1Bit01);
			groupBoxA1Byte1.Controls.Add(labelA1Bit04);
			groupBoxA1Byte1.Controls.Add(checkBoxA1Bit04);
			groupBoxA1Byte1.Controls.Add(labelA1Bit01);
			groupBoxA1Byte1.Controls.Add(labelA1Bit03);
			groupBoxA1Byte1.Controls.Add(checkBoxA1Bit03);
			groupBoxA1Byte1.Controls.Add(checkBoxA1Bit02);
			groupBoxA1Byte1.Controls.Add(labelA1Bit02);
			groupBoxA1Byte1.Location = new Point(618, 66);
			groupBoxA1Byte1.Name = "groupBoxA1Byte1";
			groupBoxA1Byte1.Size = new Size(196, 62);
			groupBoxA1Byte1.TabIndex = 12;
			groupBoxA1Byte1.TabStop = false;
			groupBoxA1Byte1.Text = "Byte 1";
			// 
			// labelA1Bit07
			// 
			labelA1Bit07.AccessibleDescription = "Shows bit 07 of byte 1 in A1";
			labelA1Bit07.AccessibleName = "Bit 07 of byte 1 in A1";
			labelA1Bit07.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit07.Location = new Point(-1, 18);
			labelA1Bit07.Name = "labelA1Bit07";
			labelA1Bit07.Size = new Size(24, 20);
			labelA1Bit07.TabIndex = 0;
			labelA1Bit07.ToolTipValues.Description = "Shows bit 07 of byte 1 in A1";
			labelA1Bit07.ToolTipValues.EnableToolTips = true;
			labelA1Bit07.ToolTipValues.Heading = "Bit 07 of byte 1 in A1";
			labelA1Bit07.Values.Text = "07";
			labelA1Bit07.Click += LabelA1Bit07_Click;
			labelA1Bit07.Enter += Control_Enter;
			labelA1Bit07.Leave += Control_Leave;
			labelA1Bit07.MouseEnter += Control_Enter;
			labelA1Bit07.MouseLeave += Control_Leave;
			// 
			// checkBoxA1Bit07
			// 
			checkBoxA1Bit07.AccessibleDescription = "Shows bit 07 of byte 1 in A1";
			checkBoxA1Bit07.AccessibleName = "Bit 07 of byte 1 in A1";
			checkBoxA1Bit07.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit07.Location = new Point(4, 38);
			checkBoxA1Bit07.Name = "checkBoxA1Bit07";
			checkBoxA1Bit07.Size = new Size(19, 14);
			checkBoxA1Bit07.TabIndex = 7;
			checkBoxA1Bit07.ToolTipValues.Description = "Shows bit 07 of byte 1 in A1";
			checkBoxA1Bit07.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit07.ToolTipValues.Heading = "Bit 07 of byte 1 in A1";
			checkBoxA1Bit07.Values.Text = "";
			checkBoxA1Bit07.CheckedChanged += CheckBoxA1Bit07_CheckedChanged;
			checkBoxA1Bit07.Enter += Control_Enter;
			checkBoxA1Bit07.Leave += Control_Leave;
			checkBoxA1Bit07.MouseEnter += Control_Enter;
			checkBoxA1Bit07.MouseLeave += Control_Leave;
			// 
			// labelA1Bit06
			// 
			labelA1Bit06.AccessibleDescription = "Shows bit 06 of byte 1 in A1";
			labelA1Bit06.AccessibleName = "Bit 06 of byte 1 in A1";
			labelA1Bit06.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit06.Location = new Point(21, 18);
			labelA1Bit06.Name = "labelA1Bit06";
			labelA1Bit06.Size = new Size(24, 20);
			labelA1Bit06.TabIndex = 1;
			labelA1Bit06.ToolTipValues.Description = "Shows bit 06 of byte 1 in A1";
			labelA1Bit06.ToolTipValues.EnableToolTips = true;
			labelA1Bit06.ToolTipValues.Heading = "Bit 06 of byte 1 in A1";
			labelA1Bit06.Values.Text = "06";
			labelA1Bit06.Click += LabelA1Bit06_Click;
			labelA1Bit06.Enter += Control_Enter;
			labelA1Bit06.Leave += Control_Leave;
			labelA1Bit06.MouseEnter += Control_Enter;
			labelA1Bit06.MouseLeave += Control_Leave;
			// 
			// checkBoxA1Bit00
			// 
			checkBoxA1Bit00.AccessibleDescription = "Shows bit 00 of byte 1 in A1";
			checkBoxA1Bit00.AccessibleName = "Bit 00 of byte 1 in A1";
			checkBoxA1Bit00.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit00.Location = new Point(173, 38);
			checkBoxA1Bit00.Name = "checkBoxA1Bit00";
			checkBoxA1Bit00.Size = new Size(19, 14);
			checkBoxA1Bit00.TabIndex = 12;
			checkBoxA1Bit00.ToolTipValues.Description = "Shows bit 00 of byte 1 in A1";
			checkBoxA1Bit00.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit00.ToolTipValues.Heading = "Bit 00 of byte 1 in A1";
			checkBoxA1Bit00.Values.Text = "";
			checkBoxA1Bit00.CheckedChanged += CheckBoxA1Bit00_CheckedChanged;
			checkBoxA1Bit00.Enter += Control_Enter;
			checkBoxA1Bit00.Leave += Control_Leave;
			checkBoxA1Bit00.MouseEnter += Control_Enter;
			checkBoxA1Bit00.MouseLeave += Control_Leave;
			// 
			// checkBoxA1Bit06
			// 
			checkBoxA1Bit06.AccessibleDescription = "Shows bit 06 of byte 1 in A1";
			checkBoxA1Bit06.AccessibleName = "Bit 06 of byte 1 in A1";
			checkBoxA1Bit06.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit06.Location = new Point(26, 38);
			checkBoxA1Bit06.Name = "checkBoxA1Bit06";
			checkBoxA1Bit06.Size = new Size(19, 14);
			checkBoxA1Bit06.TabIndex = 8;
			checkBoxA1Bit06.ToolTipValues.Description = "Shows bit 06 of byte 1 in A1";
			checkBoxA1Bit06.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit06.ToolTipValues.Heading = "Bit 06 of byte 1 in A1";
			checkBoxA1Bit06.Values.Text = "";
			checkBoxA1Bit06.CheckedChanged += CheckBoxA1Bit06_CheckedChanged;
			checkBoxA1Bit06.Enter += Control_Enter;
			checkBoxA1Bit06.Leave += Control_Leave;
			checkBoxA1Bit06.MouseEnter += Control_Enter;
			checkBoxA1Bit06.MouseLeave += Control_Leave;
			// 
			// labelA1Bit00
			// 
			labelA1Bit00.AccessibleDescription = "Shows bit 00 of byte 1 in A1";
			labelA1Bit00.AccessibleName = "Bit 00 of byte 1 in A1";
			labelA1Bit00.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit00.Location = new Point(167, 18);
			labelA1Bit00.Name = "labelA1Bit00";
			labelA1Bit00.Size = new Size(24, 20);
			labelA1Bit00.TabIndex = 6;
			labelA1Bit00.ToolTipValues.Description = "Shows bit 00 of byte 1 in A1";
			labelA1Bit00.ToolTipValues.EnableToolTips = true;
			labelA1Bit00.ToolTipValues.Heading = "Bit 00 of byte 1 in A1";
			labelA1Bit00.Values.Text = "00";
			labelA1Bit00.Click += LabelA1Bit00_Click;
			labelA1Bit00.Enter += Control_Enter;
			labelA1Bit00.Leave += Control_Leave;
			labelA1Bit00.MouseEnter += Control_Enter;
			labelA1Bit00.MouseLeave += Control_Leave;
			// 
			// labelA1Bit05
			// 
			labelA1Bit05.AccessibleDescription = "Shows bit 05 of byte 1 in A1";
			labelA1Bit05.AccessibleName = "Bit 05 of byte 1 in A1";
			labelA1Bit05.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit05.Location = new Point(43, 18);
			labelA1Bit05.Name = "labelA1Bit05";
			labelA1Bit05.Size = new Size(24, 20);
			labelA1Bit05.TabIndex = 2;
			labelA1Bit05.ToolTipValues.Description = "Shows bit 05 of byte 1 in A1";
			labelA1Bit05.ToolTipValues.EnableToolTips = true;
			labelA1Bit05.ToolTipValues.Heading = "Bit 05 of byte 1 in A1";
			labelA1Bit05.Values.Text = "05";
			labelA1Bit05.Click += LabelA1Bit05_Click;
			labelA1Bit05.Enter += Control_Enter;
			labelA1Bit05.Leave += Control_Leave;
			labelA1Bit05.MouseEnter += Control_Enter;
			labelA1Bit05.MouseLeave += Control_Leave;
			// 
			// checkBoxA1Bit05
			// 
			checkBoxA1Bit05.AccessibleDescription = "Shows bit XX of byte 1 in A1";
			checkBoxA1Bit05.AccessibleName = "Bit XX of byte 1 in A1";
			checkBoxA1Bit05.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit05.Location = new Point(48, 38);
			checkBoxA1Bit05.Name = "checkBoxA1Bit05";
			checkBoxA1Bit05.Size = new Size(19, 14);
			checkBoxA1Bit05.TabIndex = 9;
			checkBoxA1Bit05.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit05.Values.Text = "";
			checkBoxA1Bit05.CheckedChanged += CheckBoxA1Bit05_CheckedChanged;
			checkBoxA1Bit05.Enter += Control_Enter;
			checkBoxA1Bit05.Leave += Control_Leave;
			checkBoxA1Bit05.MouseEnter += Control_Enter;
			checkBoxA1Bit05.MouseLeave += Control_Leave;
			// 
			// checkBoxA1Bit01
			// 
			checkBoxA1Bit01.AccessibleDescription = "Shows bit 01 of byte 1 in A1";
			checkBoxA1Bit01.AccessibleName = "Bit 01 of byte 1 in A1";
			checkBoxA1Bit01.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit01.Location = new Point(151, 38);
			checkBoxA1Bit01.Name = "checkBoxA1Bit01";
			checkBoxA1Bit01.Size = new Size(19, 14);
			checkBoxA1Bit01.TabIndex = 11;
			checkBoxA1Bit01.ToolTipValues.Description = "Shows bit 01 of byte 1 in A1";
			checkBoxA1Bit01.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit01.ToolTipValues.Heading = "Bit 01 of byte 1 in A1";
			checkBoxA1Bit01.Values.Text = "";
			checkBoxA1Bit01.CheckedChanged += CheckBoxA1Bit01_CheckedChanged;
			checkBoxA1Bit01.Enter += Control_Enter;
			checkBoxA1Bit01.Leave += Control_Leave;
			checkBoxA1Bit01.MouseEnter += Control_Enter;
			checkBoxA1Bit01.MouseLeave += Control_Leave;
			// 
			// labelA1Bit04
			// 
			labelA1Bit04.AccessibleDescription = "Shows bit 04 of byte 1 in A1";
			labelA1Bit04.AccessibleName = "Bit 04 of byte 1 in A1";
			labelA1Bit04.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit04.Location = new Point(65, 18);
			labelA1Bit04.Name = "labelA1Bit04";
			labelA1Bit04.Size = new Size(24, 20);
			labelA1Bit04.TabIndex = 3;
			labelA1Bit04.ToolTipValues.Description = "Shows bit 04 of byte 1 in A1";
			labelA1Bit04.ToolTipValues.EnableToolTips = true;
			labelA1Bit04.ToolTipValues.Heading = "Bit 04 of byte 1 in A1";
			labelA1Bit04.Values.Text = "04";
			labelA1Bit04.Click += LabelA1Bit04_Click;
			labelA1Bit04.Enter += Control_Enter;
			labelA1Bit04.Leave += Control_Leave;
			labelA1Bit04.MouseEnter += Control_Enter;
			labelA1Bit04.MouseLeave += Control_Leave;
			// 
			// checkBoxA1Bit04
			// 
			checkBoxA1Bit04.AccessibleDescription = "Shows bit 04 of byte 1 in A1";
			checkBoxA1Bit04.AccessibleName = "Bit 04 of byte 1 in A1";
			checkBoxA1Bit04.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit04.Location = new Point(70, 38);
			checkBoxA1Bit04.Name = "checkBoxA1Bit04";
			checkBoxA1Bit04.Size = new Size(19, 14);
			checkBoxA1Bit04.TabIndex = 10;
			checkBoxA1Bit04.ToolTipValues.Description = "Shows bit 04 of byte 1 in A1";
			checkBoxA1Bit04.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit04.ToolTipValues.Heading = "Bit 04 of byte 1 in A1";
			checkBoxA1Bit04.Values.Text = "";
			checkBoxA1Bit04.CheckedChanged += CheckBoxA1Bit04_CheckedChanged;
			checkBoxA1Bit04.Enter += Control_Enter;
			checkBoxA1Bit04.Leave += Control_Leave;
			checkBoxA1Bit04.MouseEnter += Control_Enter;
			checkBoxA1Bit04.MouseLeave += Control_Leave;
			// 
			// labelA1Bit01
			// 
			labelA1Bit01.AccessibleDescription = "Shows bit 01 of byte 1 in A1";
			labelA1Bit01.AccessibleName = "Bit 01 of byte 1 in A1";
			labelA1Bit01.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit01.Location = new Point(146, 18);
			labelA1Bit01.Name = "labelA1Bit01";
			labelA1Bit01.Size = new Size(24, 20);
			labelA1Bit01.TabIndex = 5;
			labelA1Bit01.ToolTipValues.Description = "Shows bit 01 of byte 1 in A1";
			labelA1Bit01.ToolTipValues.EnableToolTips = true;
			labelA1Bit01.ToolTipValues.Heading = "Bit 01 of byte 1 in A1";
			labelA1Bit01.Values.Text = "01";
			labelA1Bit01.Click += LabelA1Bit01_Click;
			labelA1Bit01.Enter += Control_Enter;
			labelA1Bit01.Leave += Control_Leave;
			labelA1Bit01.MouseEnter += Control_Enter;
			labelA1Bit01.MouseLeave += Control_Leave;
			// 
			// labelA1Bit03
			// 
			labelA1Bit03.AccessibleDescription = "Shows bit 03 of byte 1 in A1";
			labelA1Bit03.AccessibleName = "Bit 03 of byte 1 in A1";
			labelA1Bit03.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit03.Location = new Point(100, 18);
			labelA1Bit03.Name = "labelA1Bit03";
			labelA1Bit03.Size = new Size(24, 20);
			labelA1Bit03.TabIndex = 4;
			labelA1Bit03.ToolTipValues.Description = "Shows bit 03 of byte 1 in A1";
			labelA1Bit03.ToolTipValues.EnableToolTips = true;
			labelA1Bit03.ToolTipValues.Heading = "Bit 03 of byte 1 in A1";
			labelA1Bit03.Values.Text = "03";
			labelA1Bit03.Click += LabelA1Bit03_Click;
			labelA1Bit03.Enter += Control_Enter;
			labelA1Bit03.Leave += Control_Leave;
			labelA1Bit03.MouseEnter += Control_Enter;
			labelA1Bit03.MouseLeave += Control_Leave;
			// 
			// checkBoxA1Bit03
			// 
			checkBoxA1Bit03.AccessibleDescription = "Shows bit 03 of byte 1 in A1";
			checkBoxA1Bit03.AccessibleName = "Bit 03 of byte 1 in A1";
			checkBoxA1Bit03.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit03.Location = new Point(106, 38);
			checkBoxA1Bit03.Name = "checkBoxA1Bit03";
			checkBoxA1Bit03.Size = new Size(19, 14);
			checkBoxA1Bit03.TabIndex = 6;
			checkBoxA1Bit03.ToolTipValues.Description = "Shows bit 03 of byte 1 in A1";
			checkBoxA1Bit03.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit03.ToolTipValues.Heading = "Bit 03 of byte 1 in A1";
			checkBoxA1Bit03.Values.Text = "";
			checkBoxA1Bit03.CheckedChanged += CheckBoxA1Bit03_CheckedChanged;
			checkBoxA1Bit03.Enter += Control_Enter;
			checkBoxA1Bit03.Leave += Control_Leave;
			checkBoxA1Bit03.MouseEnter += Control_Enter;
			checkBoxA1Bit03.MouseLeave += Control_Leave;
			// 
			// checkBoxA1Bit02
			// 
			checkBoxA1Bit02.AccessibleDescription = "Shows bit 02 of byte 1 in A1";
			checkBoxA1Bit02.AccessibleName = "Bit 02 of byte 1 in A1";
			checkBoxA1Bit02.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxA1Bit02.Location = new Point(129, 38);
			checkBoxA1Bit02.Name = "checkBoxA1Bit02";
			checkBoxA1Bit02.Size = new Size(19, 14);
			checkBoxA1Bit02.TabIndex = 4;
			checkBoxA1Bit02.ToolTipValues.Description = "Shows bit 02 of byte 1 in A1";
			checkBoxA1Bit02.ToolTipValues.EnableToolTips = true;
			checkBoxA1Bit02.ToolTipValues.Heading = "Bit 02 of byte 1 in A1";
			checkBoxA1Bit02.Values.Text = "";
			checkBoxA1Bit02.CheckedChanged += CheckBoxA1Bit02_CheckedChanged;
			checkBoxA1Bit02.Enter += Control_Enter;
			checkBoxA1Bit02.Leave += Control_Leave;
			checkBoxA1Bit02.MouseEnter += Control_Enter;
			checkBoxA1Bit02.MouseLeave += Control_Leave;
			// 
			// labelA1Bit02
			// 
			labelA1Bit02.AccessibleDescription = "Shows bit 02 of byte 1 in A1";
			labelA1Bit02.AccessibleName = "Bit 02 of byte 1 in A1";
			labelA1Bit02.AccessibleRole = AccessibleRole.StaticText;
			labelA1Bit02.Location = new Point(124, 18);
			labelA1Bit02.Name = "labelA1Bit02";
			labelA1Bit02.Size = new Size(24, 20);
			labelA1Bit02.TabIndex = 5;
			labelA1Bit02.ToolTipValues.Description = "Shows bit 02 of byte 1 in A1";
			labelA1Bit02.ToolTipValues.EnableToolTips = true;
			labelA1Bit02.ToolTipValues.Heading = "Bit 02 of byte 1 in A1";
			labelA1Bit02.Values.Text = "02";
			labelA1Bit02.Click += LabelA1Bit02_Click;
			labelA1Bit02.Enter += Control_Enter;
			labelA1Bit02.Leave += Control_Leave;
			labelA1Bit02.MouseEnter += Control_Enter;
			labelA1Bit02.MouseLeave += Control_Leave;
			// 
			// kryptonManager
			// 
			kryptonManager.ToolkitStrings.MessageBoxStrings.LessDetails = "L&ess Details...";
			kryptonManager.ToolkitStrings.MessageBoxStrings.MoreDetails = "&More Details...";
			// 
			// MainForm
			// 
			AccessibleDescription = "Shows the application";
			AccessibleName = "application";
			AccessibleRole = AccessibleRole.Window;
			AllowButtonSpecToolTips = true;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1356, 557);
			Controls.Add(toolStripContainer);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			FormTitleAlign = PaletteRelativeAlign.Center;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Bit Logic Calculator (BLC)";
			Load += MainForm_Load;
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			toolStripContainer.BottomToolStripPanel.PerformLayout();
			toolStripContainer.ContentPanel.ResumeLayout(false);
			toolStripContainer.ResumeLayout(false);
			toolStripContainer.PerformLayout();
			((System.ComponentModel.ISupportInitialize)kryptonPictureBoxAppBanner).EndInit();
			groupBoxDataConversion.ResumeLayout(false);
			groupBoxDataConversion.PerformLayout();
			((System.ComponentModel.ISupportInitialize)comboBoxDataConversionUnit).EndInit();
			groupBoxApplicationSettings.ResumeLayout(false);
			groupBoxApplicationSettings.PerformLayout();
			groupBoxDataFormat.ResumeLayout(false);
			groupBoxDataFormat.PerformLayout();
			((System.ComponentModel.ISupportInitialize)comboBoxDataSize).EndInit();
			((System.ComponentModel.ISupportInitialize)comboBoxMsbRepresentation).EndInit();
			groupBoxOperations.ResumeLayout(false);
			groupBoxShiftIndicator.ResumeLayout(false);
			groupBoxShiftIndicator.PerformLayout();
			groupBoxResult.ResumeLayout(false);
			groupBoxResult.PerformLayout();
			groupBoxResultByte4.ResumeLayout(false);
			groupBoxResultByte4.PerformLayout();
			groupBoxResultByte3.ResumeLayout(false);
			groupBoxResultByte3.PerformLayout();
			groupBoxResultByte2.ResumeLayout(false);
			groupBoxResultByte2.PerformLayout();
			groupBoxResultByte1.ResumeLayout(false);
			groupBoxResultByte1.PerformLayout();
			groupBoxAccumulator2.ResumeLayout(false);
			groupBoxAccumulator2.PerformLayout();
			groupBoxA2Byte4.ResumeLayout(false);
			groupBoxA2Byte4.PerformLayout();
			groupBoxA2Byte3.ResumeLayout(false);
			groupBoxA2Byte3.PerformLayout();
			groupBoxA2Byte2.ResumeLayout(false);
			groupBoxA2Byte2.PerformLayout();
			groupBoxA2Byte1.ResumeLayout(false);
			groupBoxA2Byte1.PerformLayout();
			groupBoxAccumulator1.ResumeLayout(false);
			groupBoxAccumulator1.PerformLayout();
			groupBoxA1Byte4.ResumeLayout(false);
			groupBoxA1Byte4.PerformLayout();
			groupBoxA1Byte3.ResumeLayout(false);
			groupBoxA1Byte3.PerformLayout();
			groupBoxA1Byte2.ResumeLayout(false);
			groupBoxA1Byte2.PerformLayout();
			groupBoxA1Byte1.ResumeLayout(false);
			groupBoxA1Byte1.PerformLayout();
			ResumeLayout(false);

		}

		#endregion

		private Krypton.Toolkit.KryptonStatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel labelInformation;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private Krypton.Toolkit.KryptonMaskedTextBox maskedTextBoxA1Network;
		private System.Windows.Forms.GroupBox groupBoxAccumulator1;
		private Krypton.Toolkit.KryptonTextBox textBoxA1Decimal;
		private Krypton.Toolkit.KryptonTextBox textBoxA1Hexadecimal;
		private Krypton.Toolkit.KryptonLabel labelA1Decimal;
		private Krypton.Toolkit.KryptonLabel labelA1Hexadecimal;
		private System.Windows.Forms.GroupBox groupBoxA1Byte4;
		private Krypton.Toolkit.KryptonLabel labelA1Bit31;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit31;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit24;
		private Krypton.Toolkit.KryptonLabel labelA1Bit24;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit25;
		private Krypton.Toolkit.KryptonLabel labelA1Bit30;
		private Krypton.Toolkit.KryptonLabel labelA1Bit25;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit26;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit30;
		private Krypton.Toolkit.KryptonLabel labelA1Bit26;
		private Krypton.Toolkit.KryptonLabel labelA1Bit29;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit27;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit29;
		private Krypton.Toolkit.KryptonLabel labelA1Bit27;
		private Krypton.Toolkit.KryptonLabel labelA1Bit28;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit28;
		private System.Windows.Forms.GroupBox groupBoxA1Byte3;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit23;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit21;
		private Krypton.Toolkit.KryptonLabel labelA1Bit21;
		private Krypton.Toolkit.KryptonLabel labelA1Bit20;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit22;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit20;
		private Krypton.Toolkit.KryptonLabel labelA1Bit22;
		private Krypton.Toolkit.KryptonLabel labelA1Bit19;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit16;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit19;
		private Krypton.Toolkit.KryptonLabel labelA1Bit23;
		private Krypton.Toolkit.KryptonLabel labelA1Bit18;
		private Krypton.Toolkit.KryptonLabel labelA1Bit16;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit18;
		private Krypton.Toolkit.KryptonLabel labelA1Bit17;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit17;
		private System.Windows.Forms.GroupBox groupBoxA1Byte2;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit15;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit10;
		private Krypton.Toolkit.KryptonLabel labelA1Bit10;
		private Krypton.Toolkit.KryptonLabel labelA1Bit09;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit11;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit09;
		private Krypton.Toolkit.KryptonLabel labelA1Bit11;
		private Krypton.Toolkit.KryptonLabel labelA1Bit15;
		private Krypton.Toolkit.KryptonLabel labelA1Bit08;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit12;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit08;
		private Krypton.Toolkit.KryptonLabel labelA1Bit12;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit13;
		private Krypton.Toolkit.KryptonLabel labelA1Bit13;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit14;
		private Krypton.Toolkit.KryptonLabel labelA1Bit14;
		private System.Windows.Forms.GroupBox groupBoxA1Byte1;
		private Krypton.Toolkit.KryptonLabel labelA1Bit07;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit07;
		private Krypton.Toolkit.KryptonLabel labelA1Bit06;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit00;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit06;
		private Krypton.Toolkit.KryptonLabel labelA1Bit00;
		private Krypton.Toolkit.KryptonLabel labelA1Bit05;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit05;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit01;
		private Krypton.Toolkit.KryptonLabel labelA1Bit04;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit04;
		private Krypton.Toolkit.KryptonLabel labelA1Bit01;
		private Krypton.Toolkit.KryptonLabel labelA1Bit03;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit03;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA1Bit02;
		private Krypton.Toolkit.KryptonLabel labelA1Bit02;
		private Krypton.Toolkit.KryptonButton buttonLogicalXnorA1AndA2;
		private Krypton.Toolkit.KryptonButton buttonLogicalNorA1AndA2;
		private Krypton.Toolkit.KryptonButton buttonInvertA2;
		private Krypton.Toolkit.KryptonButton buttonInvertA1;
		private Krypton.Toolkit.KryptonButton buttonLogicalXorA1AndA2;
		private Krypton.Toolkit.KryptonButton buttonLogicalOrA1AndA2;
		private Krypton.Toolkit.KryptonButton buttonLogicalAndA1AndA2;
		private Krypton.Toolkit.KryptonButton buttonDivisionA1AndA2;
		private Krypton.Toolkit.KryptonButton buttonMultiplicationA1AndA2;
		private Krypton.Toolkit.KryptonButton buttonSubtractionA1AndA2;
		private Krypton.Toolkit.KryptonButton buttonAdditionA1AndA2;
		private System.Windows.Forms.GroupBox groupBoxResult;
		private Krypton.Toolkit.KryptonMaskedTextBox maskedTextBoxResultNetwork;
		private Krypton.Toolkit.KryptonLabel labelResultNetwork;
		private Krypton.Toolkit.KryptonTextBox textResultDecimal;
		private Krypton.Toolkit.KryptonTextBox textBoxResultHexadecimal;
		private Krypton.Toolkit.KryptonLabel labelResultDecimal;
		private Krypton.Toolkit.KryptonLabel labelResultHexadecimal;
		private System.Windows.Forms.GroupBox groupBoxResultByte4;
		private Krypton.Toolkit.KryptonLabel labelResultBit31;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit31;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit24;
		private Krypton.Toolkit.KryptonLabel labelResultBit24;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit25;
		private Krypton.Toolkit.KryptonLabel labelResultBit30;
		private Krypton.Toolkit.KryptonLabel labelResultBit25;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit26;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit30;
		private Krypton.Toolkit.KryptonLabel labelResultBit26;
		private Krypton.Toolkit.KryptonLabel labelResultBit29;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit27;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit29;
		private Krypton.Toolkit.KryptonLabel labelResultBit27;
		private Krypton.Toolkit.KryptonLabel labelResultBit28;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit28;
		private System.Windows.Forms.GroupBox groupBoxResultByte3;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit23;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit21;
		private Krypton.Toolkit.KryptonLabel labelResultBit21;
		private Krypton.Toolkit.KryptonLabel labelResultBit20;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit22;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit20;
		private Krypton.Toolkit.KryptonLabel labelResultBit22;
		private Krypton.Toolkit.KryptonLabel labelResultBit19;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit16;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit19;
		private Krypton.Toolkit.KryptonLabel labelResultBit23;
		private Krypton.Toolkit.KryptonLabel labelResultBit18;
		private Krypton.Toolkit.KryptonLabel labelResultBit16;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit18;
		private Krypton.Toolkit.KryptonLabel labelResultBit17;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit17;
		private System.Windows.Forms.GroupBox groupBoxResultByte2;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit15;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit10;
		private Krypton.Toolkit.KryptonLabel labelResultBit10;
		private Krypton.Toolkit.KryptonLabel labelResultBit09;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit11;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit09;
		private Krypton.Toolkit.KryptonLabel labelResultBit11;
		private Krypton.Toolkit.KryptonLabel labelResultBit15;
		private Krypton.Toolkit.KryptonLabel labelResultBit08;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit12;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit08;
		private Krypton.Toolkit.KryptonLabel labelResultBit12;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit13;
		private Krypton.Toolkit.KryptonLabel labelResultBit13;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit14;
		private Krypton.Toolkit.KryptonLabel labelResultBit14;
		private System.Windows.Forms.GroupBox groupBoxResultByte1;
		private Krypton.Toolkit.KryptonLabel labelResultBit07;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit07;
		private Krypton.Toolkit.KryptonLabel labelResultBit06;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit00;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit06;
		private Krypton.Toolkit.KryptonLabel labelResultBit00;
		private Krypton.Toolkit.KryptonLabel labelResultBit05;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit05;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit01;
		private Krypton.Toolkit.KryptonLabel labelResultBit04;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit04;
		private Krypton.Toolkit.KryptonLabel labelResultBit01;
		private Krypton.Toolkit.KryptonLabel labelResultBit03;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit03;
		private Krypton.Toolkit.KryptonCheckBox checkBoxResultBit02;
		private Krypton.Toolkit.KryptonLabel labelResultBit02;
		private System.Windows.Forms.GroupBox groupBoxAccumulator2;
		private Krypton.Toolkit.KryptonMaskedTextBox maskedTextBoxA2Network;
		private Krypton.Toolkit.KryptonLabel labelA2Network;
		private Krypton.Toolkit.KryptonTextBox textBoxA2Decimal;
		private Krypton.Toolkit.KryptonTextBox textBoxA2Hexadecimal;
		private Krypton.Toolkit.KryptonLabel labelA2Decimal;
		private Krypton.Toolkit.KryptonLabel labelA2Hexadecimal;
		private System.Windows.Forms.GroupBox groupBoxA2Byte4;
		private Krypton.Toolkit.KryptonLabel labelA2Bit31;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit31;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit24;
		private Krypton.Toolkit.KryptonLabel labelA2Bit24;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit25;
		private Krypton.Toolkit.KryptonLabel labelA2Bit30;
		private Krypton.Toolkit.KryptonLabel labelA2Bit25;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit26;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit30;
		private Krypton.Toolkit.KryptonLabel labelA2Bit26;
		private Krypton.Toolkit.KryptonLabel labelA2Bit29;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit27;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit29;
		private Krypton.Toolkit.KryptonLabel labelA2Bit27;
		private Krypton.Toolkit.KryptonLabel labelA2Bit28;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit28;
		private System.Windows.Forms.GroupBox groupBoxA2Byte3;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit23;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit21;
		private Krypton.Toolkit.KryptonLabel labelA2Bit21;
		private Krypton.Toolkit.KryptonLabel labelA2Bit20;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit22;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit20;
		private Krypton.Toolkit.KryptonLabel labelA2Bit22;
		private Krypton.Toolkit.KryptonLabel labelA2Bit19;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit16;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit19;
		private Krypton.Toolkit.KryptonLabel labelA2Bit23;
		private Krypton.Toolkit.KryptonLabel labelA2Bit18;
		private Krypton.Toolkit.KryptonLabel labelA2Bit16;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit18;
		private Krypton.Toolkit.KryptonLabel labelA2Bit17;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit17;
		private System.Windows.Forms.GroupBox groupBoxA2Byte2;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit15;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit10;
		private Krypton.Toolkit.KryptonLabel labelA2Bit10;
		private Krypton.Toolkit.KryptonLabel labelA2Bit09;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit11;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit09;
		private Krypton.Toolkit.KryptonLabel labelA2Bit11;
		private Krypton.Toolkit.KryptonLabel labelA2Bit15;
		private Krypton.Toolkit.KryptonLabel labelA2Bit08;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit12;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit08;
		private Krypton.Toolkit.KryptonLabel labelA2Bit12;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit13;
		private Krypton.Toolkit.KryptonLabel labelA2Bit13;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit14;
		private Krypton.Toolkit.KryptonLabel labelA2Bit14;
		private System.Windows.Forms.GroupBox groupBoxA2Byte1;
		private Krypton.Toolkit.KryptonLabel labelA2Bit07;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit07;
		private Krypton.Toolkit.KryptonLabel labelA2Bit06;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit00;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit06;
		private Krypton.Toolkit.KryptonLabel labelA2Bit00;
		private Krypton.Toolkit.KryptonLabel labelA2Bit05;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit05;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit01;
		private Krypton.Toolkit.KryptonLabel labelA2Bit04;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit04;
		private Krypton.Toolkit.KryptonLabel labelA2Bit01;
		private Krypton.Toolkit.KryptonLabel labelA2Bit03;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit03;
		private Krypton.Toolkit.KryptonCheckBox checkBoxA2Bit02;
		private Krypton.Toolkit.KryptonLabel labelA2Bit02;
		private Krypton.Toolkit.KryptonButton buttonLsbSign;
		private Krypton.Toolkit.KryptonLabel labelA1Network;
		private System.Windows.Forms.GroupBox groupBoxOperations;
		private Krypton.Toolkit.KryptonButton buttonShiftLeftWithZeroA2;
		private Krypton.Toolkit.KryptonButton buttonShiftRightWithZeroA2;
		private Krypton.Toolkit.KryptonButton buttonRotateLeftA2;
		private Krypton.Toolkit.KryptonButton buttonRotateRightA2;
		private Krypton.Toolkit.KryptonButton buttonShiftLeftWithZeroA1;
		private Krypton.Toolkit.KryptonButton buttonShiftRightWithZeroA1;
		private Krypton.Toolkit.KryptonButton buttonRotateLeftA1;
		private Krypton.Toolkit.KryptonButton buttonRotateRightA1;
		private Krypton.Toolkit.KryptonButton buttonCopyResultToA2;
		private Krypton.Toolkit.KryptonButton buttonCopyResultToA1;
		private Krypton.Toolkit.KryptonComboBox comboBoxMsbRepresentation;
		private Krypton.Toolkit.KryptonLabel labelDataSize;
		private System.Windows.Forms.GroupBox groupBoxDataFormat;
		private Krypton.Toolkit.KryptonComboBox comboBoxDataSize;
		private Krypton.Toolkit.KryptonLabel labelMsbRepresentation;
		private Krypton.Toolkit.KryptonButton buttonSwapA1A2;
		private Krypton.Toolkit.KryptonButton buttonFillA2;
		private Krypton.Toolkit.KryptonButton buttonFillA1;
		private Krypton.Toolkit.KryptonButton buttonClearA2;
		private Krypton.Toolkit.KryptonButton buttonClearA1;
		private Krypton.Toolkit.KryptonButton buttonRevertA2;
		private Krypton.Toolkit.KryptonButton buttonRevertA1;
		private Krypton.Toolkit.KryptonButton buttonShiftLeftWithOneA1;
		private Krypton.Toolkit.KryptonButton buttonShiftLeftWithOneA2;
		private System.Windows.Forms.GroupBox groupBoxApplicationSettings;
		private Krypton.Toolkit.KryptonButton buttonShiftRightWithOneA2;
		private Krypton.Toolkit.KryptonButton buttonShiftRightWithOneA1;
		private Krypton.Toolkit.KryptonCheckBox checkBoxAlwaysOnTop;
		private Krypton.Toolkit.KryptonButton buttonRandomizeA1;
		private Krypton.Toolkit.KryptonButton buttonRandomizeA2;
		private Krypton.Toolkit.KryptonButton buttonSubjunctionA2A1;
		private Krypton.Toolkit.KryptonButton buttonSubjunctionA1A2;
		private Krypton.Toolkit.KryptonButton buttonInhibitionA2A1;
		private Krypton.Toolkit.KryptonButton buttonInhibitionA1A2;
		private Krypton.Toolkit.KryptonTextBox textBoxResultOctal;
		private Krypton.Toolkit.KryptonLabel labelResultOctal;
		private Krypton.Toolkit.KryptonTextBox textBoxA2Octal;
		private Krypton.Toolkit.KryptonLabel labelA2Octal;
		private Krypton.Toolkit.KryptonTextBox textBoxA1Octal;
		private Krypton.Toolkit.KryptonLabel labelA1Octal;
		private Krypton.Toolkit.KryptonButton buttonHalfSwapA1;
		private Krypton.Toolkit.KryptonButton buttonHalfSwapA2;
		private System.Windows.Forms.GroupBox groupBoxDataConversion;
		private Krypton.Toolkit.KryptonComboBox comboBoxDataConversionUnit;
		private Krypton.Toolkit.KryptonTextBox textBoxDataConversion;
		private Krypton.Toolkit.KryptonButton buttonAbout;
		private Krypton.Toolkit.KryptonButton buttonFormingTwosComponentA2;
		private Krypton.Toolkit.KryptonButton buttonFormingTwosComponentA1;
		private Krypton.Toolkit.KryptonButton buttonLogicalNandA1AndA2;
		private Krypton.Toolkit.KryptonButton buttonStatistics;
		private System.Windows.Forms.GroupBox groupBoxShiftIndicator;
		private Krypton.Toolkit.KryptonLabel labelShiftIndicator;
		private Krypton.Toolkit.KryptonNumericUpDown numericUpDownShiftIndicator;
		private Krypton.Toolkit.KryptonButton buttonBitSwapA2;
		private Krypton.Toolkit.KryptonButton buttonBitSwapA1;
		private Krypton.Toolkit.KryptonButton buttonNibbleSwapA2;
		private Krypton.Toolkit.KryptonButton buttonNibbleSwapA1;
		private Krypton.Toolkit.KryptonButton buttonArithmeticShiftRightWithOneA2;
		private Krypton.Toolkit.KryptonButton buttonArithmeticShiftRightWithOneA1;
		private Krypton.Toolkit.KryptonButton buttonArithmeticShiftLeftWithOneA2;
		private Krypton.Toolkit.KryptonButton buttonArithmeticShiftLeftWithOneA1;
		private Krypton.Toolkit.KryptonButton buttonArithmeticShiftLeftWithZeroA2;
		private Krypton.Toolkit.KryptonButton buttonArithmeticShiftRightWithZeroA2;
		private Krypton.Toolkit.KryptonButton buttonArithmeticShiftLeftWithZeroA1;
		private Krypton.Toolkit.KryptonButton buttonArithmeticShiftRightWithZeroA1;
		private Krypton.Toolkit.KryptonButton buttonRotateRightWithCarryA2;
		private Krypton.Toolkit.KryptonButton buttonRotateLeftWithCarryA2;
		private Krypton.Toolkit.KryptonButton buttonRotateRightWithCarryA1;
		private Krypton.Toolkit.KryptonButton buttonRotateLeftWithCarryA1;
		private Krypton.Toolkit.KryptonManager kryptonManager;
		private KryptonPictureBox kryptonPictureBoxAppBanner;
	}
}

