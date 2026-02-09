using BitLogicCalculator.Properties;

using Krypton.Toolkit;

using System.Collections;

namespace BitLogicCalculator;

/// <summary>
/// Main form for the Bit Logic Calculator application.
/// </summary>
public partial class MainForm : BaseKryptonForm
{
	#region Constants and variables

	private KryptonCheckBox[] _a1Bits = null!;
	private KryptonCheckBox[] _a2Bits = null!;
	private KryptonCheckBox[] _resultBits = null!;

	private void InitializeBitArrays()
	{
		_a1Bits =
		[
			checkBoxA1Bit00, checkBoxA1Bit01, checkBoxA1Bit02, checkBoxA1Bit03,
			checkBoxA1Bit04, checkBoxA1Bit05, checkBoxA1Bit06, checkBoxA1Bit07,
			checkBoxA1Bit08, checkBoxA1Bit09, checkBoxA1Bit10, checkBoxA1Bit11,
			checkBoxA1Bit12, checkBoxA1Bit13, checkBoxA1Bit14, checkBoxA1Bit15,
			checkBoxA1Bit16, checkBoxA1Bit17, checkBoxA1Bit18, checkBoxA1Bit19,
			checkBoxA1Bit20, checkBoxA1Bit21, checkBoxA1Bit22, checkBoxA1Bit23,
			checkBoxA1Bit24, checkBoxA1Bit25, checkBoxA1Bit26, checkBoxA1Bit27,
			checkBoxA1Bit28, checkBoxA1Bit29, checkBoxA1Bit30, checkBoxA1Bit31
		];

		_a2Bits =
		[
			checkBoxA2Bit00, checkBoxA2Bit01, checkBoxA2Bit02, checkBoxA2Bit03,
			checkBoxA2Bit04, checkBoxA2Bit05, checkBoxA2Bit06, checkBoxA2Bit07,
			checkBoxA2Bit08, checkBoxA2Bit09, checkBoxA2Bit10, checkBoxA2Bit11,
			checkBoxA2Bit12, checkBoxA2Bit13, checkBoxA2Bit14, checkBoxA2Bit15,
			checkBoxA2Bit16, checkBoxA2Bit17, checkBoxA2Bit18, checkBoxA2Bit19,
			checkBoxA2Bit20, checkBoxA2Bit21, checkBoxA2Bit22, checkBoxA2Bit23,
			checkBoxA2Bit24, checkBoxA2Bit25, checkBoxA2Bit26, checkBoxA2Bit27,
			checkBoxA2Bit28, checkBoxA2Bit29, checkBoxA2Bit30, checkBoxA2Bit31
		];

		_resultBits =
		[
			checkBoxResultBit00, checkBoxResultBit01, checkBoxResultBit02, checkBoxResultBit03,
			checkBoxResultBit04, checkBoxResultBit05, checkBoxResultBit06, checkBoxResultBit07,
			checkBoxResultBit08, checkBoxResultBit09, checkBoxResultBit10, checkBoxResultBit11,
			checkBoxResultBit12, checkBoxResultBit13, checkBoxResultBit14, checkBoxResultBit15,
			checkBoxResultBit16, checkBoxResultBit17, checkBoxResultBit18, checkBoxResultBit19,
			checkBoxResultBit20, checkBoxResultBit21, checkBoxResultBit22, checkBoxResultBit23,
			checkBoxResultBit24, checkBoxResultBit25, checkBoxResultBit26, checkBoxResultBit27,
			checkBoxResultBit28, checkBoxResultBit29, checkBoxResultBit30, checkBoxResultBit31
		];
	}

	private static void ShowBits(BitArray source, KryptonCheckBox[] targets, int visibleBits)
	{
		for (int i = 0; i < visibleBits; i++)
		{
			targets[i].Checked = source.Get(index: i);
		}
	}

	private int GetActiveBitCount() => comboBoxDataSize.SelectedIndex switch
	{
		0 => 8,
		1 => 16,
		_ => 32
	};






	/// <summary>
	/// Indicates whether the least significant bit (LSB) is set.
	/// </summary>
	private bool isLsbSignSet;

	/// <summary>
	/// Length of the bit arrays used in the calculator.
	/// </summary>
	private const int length = 32;

	/// <summary>
	/// BitArray to hold the first accumulator value. It is initialized with a length of 32 bits, which allows it to store values for operations on 32-bit data sizes.
	/// </summary>
	private BitArray accumulator1 = new(length: length);

	/// <summary>
	/// BitArray to hold the second accumulator value. It is initialized with a length of 32 bits, which allows it to store values for operations on 32-bit data sizes.
	/// </summary>
	private BitArray accumulator2 = new(length: length);

	/// <summary>
	/// BitArray to hold the result of operations performed on the accumulators. It is initialized with a length of 32 bits, which allows it to store results for operations on 32-bit data sizes.
	/// </summary>
	private BitArray result = new(length: length);

	/// <summary>
	/// Random number generator for generating random values.
	/// </summary>
	private readonly Random random = new();

	#endregion

	#region Helpers

	/// <summary>
	/// Sets the status bar text and enables the information label when text is provided.
	/// </summary>
	/// <param name="text">Main status text to display. If null or whitespace the method returns without changing the UI.</param>
	/// <param name="additionalInfo">Optional additional information appended to the main text, separated by " - ".</param>
	/// <remarks>
	/// This method is used to update the status bar with the specified text and additional information.
	/// </remarks>
	private void SetStatusBar(string text, string additionalInfo = "")
	{
		// Check if the text is not null or whitespace
		if (string.IsNullOrWhiteSpace(value: text))
		{
			return;
		}
		// Set the status bar text and enable it
		labelInformation.Enabled = true;
		labelInformation.Text = string.IsNullOrWhiteSpace(value: additionalInfo) ? text : $"{text} - {additionalInfo}";
	}

	/// <summary>
	/// Clears the status bar text and disables the information label.
	/// </summary>
	/// <remarks>
	/// Resets the UI state of the status area so that no message is shown.
	/// Use when there is no status to display or when leaving a control.
	/// </remarks>
	private void ClearStatusBar()
	{
		// Clear the status bar text and disable it
		labelInformation.Enabled = false;
		labelInformation.Text = string.Empty;
	}

	private bool RandomBit() => (byte)random.Next(maxValue: 2) == 1;

	private void SetAccumulator1RandomBits()
	{
		for (int i = 0; i < accumulator1.Length; i++)
		{
			accumulator1.Set(index: i, value: RandomBit());
		}
	}

	private void SetAccumulator2RandomBits()
	{
		for (int i = 0; i < accumulator2.Length; i++)
		{
			accumulator2.Set(index: i, value: RandomBit());
		}
	}

	private void ShiftRightA1(bool fillWithOne = false)
	{
		for (int i = 0; i < accumulator1.Length; i++)
		{
			if (i == accumulator1.Length - 1)
			{
				accumulator1.Set(index: i, value: fillWithOne);
			}
			else
			{
				accumulator1.Set(index: i, value: accumulator1.Get(index: i + 1));
			}
		}
	}

	private void ArithmeticShiftRightA1(bool fillWithOne = false)
	{
		for (int i = 0; i < accumulator1.Length - 1; i++)
		{
			if (i == accumulator1.Length - 2)
			{
				accumulator1.Set(index: i, value: fillWithOne);
			}
			else
			{
				accumulator1.Set(index: i, value: accumulator1.Get(index: i + 1));
			}
		}
	}

	private void ShiftRightA2(bool fillWithOne = false)
	{
		for (int i = 0; i < accumulator2.Length; i++)
		{
			if (i == accumulator2.Length - 1)
			{
				accumulator2.Set(index: i, value: fillWithOne);
			}
			else
			{
				accumulator2.Set(index: i, value: accumulator2.Get(index: i + 1));
			}
		}
	}

	private void ArithmeticShiftRightA2(bool fillWithOne = false)
	{
		for (int i = 0; i < accumulator2.Length - 1; i++)
		{
			if (i == accumulator2.Length - 2)
			{
				accumulator2.Set(index: i, value: fillWithOne);
			}
			else
			{
				accumulator2.Set(index: i, value: accumulator2.Get(index: i + 1));
			}
		}
	}

	private void ShiftLeftA1(bool fillWithOne = false)
	{
		for (int i = accumulator1.Length - 1; i >= 0; i--)
		{
			if (i == 0)
			{
				accumulator1.Set(index: 0, value: fillWithOne);
			}
			else
			{
				accumulator1.Set(index: i, value: accumulator1.Get(index: i - 1));
			}
		}
	}

	private void ArithmeticShiftLeftA1(bool fillWithOne = false)
	{
		for (int i = accumulator1.Length - 2; i >= 0; i--)
		{
			if (i == 0)
			{
				accumulator1.Set(index: 0, value: fillWithOne);
			}
			else
			{
				accumulator1.Set(index: i, value: accumulator1.Get(index: i - 1));
			}
		}
	}

	private void ShiftLeftA2(bool fillWithOne = false)
	{
		for (int i = accumulator2.Length - 1; i >= 0; i--)
		{
			if (i == 0)
			{
				accumulator2.Set(index: 0, value: fillWithOne);
			}
			else
			{
				accumulator2.Set(index: i, value: accumulator2.Get(index: i - 1));
			}
		}
	}

	private void ArithmeticShiftLeftA2(bool fillWithOne = false)
	{
		for (int i = accumulator2.Length - 2; i >= 0; i--)
		{
			if (i == 0)
			{
				accumulator2.Set(index: 0, value: fillWithOne);
			}
			else
			{
				accumulator2.Set(index: i, value: accumulator2.Get(index: i - 1));
			}
		}
	}

	private void RotateLeftA1()
	{
		bool stateLsb = accumulator1.Get(index: accumulator1.Length - 1);
		for (int i = accumulator1.Length - 1; i >= 0; i--)
		{
			if (i == 0)
			{
				accumulator1.Set(index: 0, value: stateLsb);
			}
			else
			{
				accumulator1.Set(index: i, value: accumulator1.Get(index: i - 1));
			}
		}
	}

	private void RotateLeftA2()
	{
		bool stateLsb = accumulator2.Get(index: accumulator2.Length - 1);
		for (int i = accumulator2.Length - 1; i >= 0; i--)
		{
			if (i == 0)
			{
				accumulator2.Set(index: 0, value: stateLsb);
			}
			else
			{
				accumulator2.Set(index: i, value: accumulator2.Get(index: i - 1));
			}
		}
	}

	private void RotateRightA1()
	{
		bool stateLsb = accumulator1.Get(index: 0);
		for (int i = 0; i < accumulator1.Length; i++)
		{
			if (i == accumulator1.Length - 1)
			{
				accumulator1.Set(index: i, value: stateLsb);
			}
			else
			{
				accumulator1.Set(index: i, value: accumulator1.Get(index: i + 1));
			}
		}
	}

	private void RotateRightA2()
	{
		bool stateLsb = accumulator2.Get(index: 0);
		for (int i = 0; i < accumulator2.Length; i++)
		{
			if (i == accumulator2.Length - 1)
			{
				accumulator2.Set(index: i, value: stateLsb);
			}
			else
			{
				accumulator2.Set(index: i, value: accumulator2.Get(index: i + 1));
			}
		}
	}

	private static bool Add(bool value1, bool value2, ref bool carry)
	{
		carry = false;
		if (value1 == value2)
		{
			if (value1)
			{
				carry = true;
			}
			return false;
		}
		return true;
	}

	#endregion

	#region Constructor

	public MainForm() => InitializeComponent();

	#endregion

	#region Form* event handlers

	private void MainForm_Load(object sender, EventArgs e)
	{
		comboBoxMsbRepresentation.SelectedIndex = 0;
		comboBoxDataSize.SelectedIndex = comboBoxDataSize.Items.Count - 1;
		textBoxDataConversion.Text = Resources.number00;
		comboBoxDataConversionUnit.SelectedIndex = 0;
		InitializeBitArrays();
		SetAccumulator1RandomBits();
		SetAccumulator2RandomBits();
		ShowBits(source: accumulator1, targets: _a1Bits, visibleBits: GetActiveBitCount());
		ShowBits(source: accumulator2, targets: _a2Bits, visibleBits: GetActiveBitCount());

		KryptonLabel[] a1Labels = [
			labelA1Bit00, labelA1Bit01, labelA1Bit02, labelA1Bit03, labelA1Bit04,
			labelA1Bit05, labelA1Bit06, labelA1Bit07, labelA1Bit08, labelA1Bit09,
			labelA1Bit10, labelA1Bit11, labelA1Bit12, labelA1Bit13, labelA1Bit14,
			labelA1Bit15, labelA1Bit16, labelA1Bit17, labelA1Bit18, labelA1Bit19,
			labelA1Bit20, labelA1Bit21, labelA1Bit22, labelA1Bit23, labelA1Bit24,
			labelA1Bit25, labelA1Bit26, labelA1Bit27, labelA1Bit28, labelA1Bit29,
			labelA1Bit30, labelA1Bit31
		];
		for (int i = 0; i < a1Labels.Length && i < _a1Bits.Length; i++)
		{
			a1Labels[i].Tag = _a1Bits[i];
		}

		KryptonLabel[] a2Labels = [
			labelA2Bit00, labelA2Bit01, labelA2Bit02, labelA2Bit03, labelA2Bit04,
			labelA2Bit05, labelA2Bit06, labelA2Bit07, labelA2Bit08, labelA2Bit09,
			labelA2Bit10, labelA2Bit11, labelA2Bit12, labelA2Bit13, labelA2Bit14,
			labelA2Bit15, labelA2Bit16, labelA2Bit17, labelA2Bit18, labelA2Bit19,
			labelA2Bit20, labelA2Bit21, labelA2Bit22, labelA2Bit23, labelA2Bit24,
			labelA2Bit25, labelA2Bit26, labelA2Bit27, labelA2Bit28, labelA2Bit29,
			labelA2Bit30, labelA2Bit31
		];

		for (int i = 0; i < a2Labels.Length && i < _a2Bits.Length; i++)
		{
			a2Labels[i].Tag = _a2Bits[i];
		}
	}

	#endregion

	#region SelectedIndexChanged event handlers

	private void ComboBoxMsbRepresentation_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void ComboBoxDataSize_SelectedIndexChanged(object sender, EventArgs e)
	{
		switch (comboBoxDataSize.SelectedIndex)
		{
			case 0:
				checkBoxA1Bit08.Checked = false;
				checkBoxA1Bit09.Checked = false;
				checkBoxA1Bit10.Checked = false;
				checkBoxA1Bit11.Checked = false;
				checkBoxA1Bit12.Checked = false;
				checkBoxA1Bit13.Checked = false;
				checkBoxA1Bit14.Checked = false;
				checkBoxA1Bit15.Checked = false;
				checkBoxA1Bit16.Checked = false;
				checkBoxA1Bit17.Checked = false;
				checkBoxA1Bit18.Checked = false;
				checkBoxA1Bit19.Checked = false;
				checkBoxA1Bit20.Checked = false;
				checkBoxA1Bit21.Checked = false;
				checkBoxA1Bit22.Checked = false;
				checkBoxA1Bit23.Checked = false;
				checkBoxA1Bit24.Checked = false;
				checkBoxA1Bit25.Checked = false;
				checkBoxA1Bit26.Checked = false;
				checkBoxA1Bit27.Checked = false;
				checkBoxA1Bit28.Checked = false;
				checkBoxA1Bit29.Checked = false;
				checkBoxA1Bit30.Checked = false;
				checkBoxA1Bit31.Checked = false;
				checkBoxA2Bit08.Checked = false;
				checkBoxA2Bit09.Checked = false;
				checkBoxA2Bit10.Checked = false;
				checkBoxA2Bit11.Checked = false;
				checkBoxA2Bit12.Checked = false;
				checkBoxA2Bit13.Checked = false;
				checkBoxA2Bit14.Checked = false;
				checkBoxA2Bit15.Checked = false;
				checkBoxA2Bit16.Checked = false;
				checkBoxA2Bit17.Checked = false;
				checkBoxA2Bit18.Checked = false;
				checkBoxA2Bit19.Checked = false;
				checkBoxA2Bit20.Checked = false;
				checkBoxA2Bit21.Checked = false;
				checkBoxA2Bit22.Checked = false;
				checkBoxA2Bit23.Checked = false;
				checkBoxA2Bit24.Checked = false;
				checkBoxA2Bit25.Checked = false;
				checkBoxA2Bit26.Checked = false;
				checkBoxA2Bit27.Checked = false;
				checkBoxA2Bit28.Checked = false;
				checkBoxA2Bit29.Checked = false;
				checkBoxA2Bit30.Checked = false;
				checkBoxA2Bit31.Checked = false;
				checkBoxResultBit08.Checked = false;
				checkBoxResultBit09.Checked = false;
				checkBoxResultBit10.Checked = false;
				checkBoxResultBit11.Checked = false;
				checkBoxResultBit12.Checked = false;
				checkBoxResultBit13.Checked = false;
				checkBoxResultBit14.Checked = false;
				checkBoxResultBit15.Checked = false;
				checkBoxResultBit16.Checked = false;
				checkBoxResultBit17.Checked = false;
				checkBoxResultBit18.Checked = false;
				checkBoxResultBit19.Checked = false;
				checkBoxResultBit20.Checked = false;
				checkBoxResultBit21.Checked = false;
				checkBoxResultBit22.Checked = false;
				checkBoxResultBit23.Checked = false;
				checkBoxResultBit24.Checked = false;
				checkBoxResultBit25.Checked = false;
				checkBoxResultBit26.Checked = false;
				checkBoxResultBit27.Checked = false;
				checkBoxResultBit28.Checked = false;
				checkBoxResultBit29.Checked = false;
				checkBoxResultBit30.Checked = false;
				checkBoxResultBit31.Checked = false;
				groupBoxA1Byte2.Enabled = false;
				groupBoxA1Byte3.Enabled = false;
				groupBoxA1Byte4.Enabled = false;
				groupBoxA2Byte2.Enabled = false;
				groupBoxA2Byte3.Enabled = false;
				groupBoxA2Byte4.Enabled = false;
				groupBoxResultByte2.Enabled = false;
				groupBoxResultByte3.Enabled = false;
				groupBoxResultByte4.Enabled = false;
				break;
			case 1:
				checkBoxA1Bit16.Checked = false;
				checkBoxA1Bit17.Checked = false;
				checkBoxA1Bit18.Checked = false;
				checkBoxA1Bit19.Checked = false;
				checkBoxA1Bit20.Checked = false;
				checkBoxA1Bit21.Checked = false;
				checkBoxA1Bit22.Checked = false;
				checkBoxA1Bit23.Checked = false;
				checkBoxA1Bit24.Checked = false;
				checkBoxA1Bit25.Checked = false;
				checkBoxA1Bit26.Checked = false;
				checkBoxA1Bit27.Checked = false;
				checkBoxA1Bit28.Checked = false;
				checkBoxA1Bit29.Checked = false;
				checkBoxA1Bit30.Checked = false;
				checkBoxA1Bit31.Checked = false;
				checkBoxA2Bit16.Checked = false;
				checkBoxA2Bit17.Checked = false;
				checkBoxA2Bit18.Checked = false;
				checkBoxA2Bit19.Checked = false;
				checkBoxA2Bit20.Checked = false;
				checkBoxA2Bit21.Checked = false;
				checkBoxA2Bit22.Checked = false;
				checkBoxA2Bit23.Checked = false;
				checkBoxA2Bit24.Checked = false;
				checkBoxA2Bit25.Checked = false;
				checkBoxA2Bit26.Checked = false;
				checkBoxA2Bit27.Checked = false;
				checkBoxA2Bit28.Checked = false;
				checkBoxA2Bit29.Checked = false;
				checkBoxA2Bit30.Checked = false;
				checkBoxA2Bit31.Checked = false;
				checkBoxResultBit16.Checked = false;
				checkBoxResultBit17.Checked = false;
				checkBoxResultBit18.Checked = false;
				checkBoxResultBit19.Checked = false;
				checkBoxResultBit20.Checked = false;
				checkBoxResultBit21.Checked = false;
				checkBoxResultBit22.Checked = false;
				checkBoxResultBit23.Checked = false;
				checkBoxResultBit24.Checked = false;
				checkBoxResultBit25.Checked = false;
				checkBoxResultBit26.Checked = false;
				checkBoxResultBit27.Checked = false;
				checkBoxResultBit28.Checked = false;
				checkBoxResultBit29.Checked = false;
				checkBoxResultBit30.Checked = false;
				checkBoxResultBit31.Checked = false;
				groupBoxA1Byte2.Enabled = true;
				groupBoxA1Byte3.Enabled = false;
				groupBoxA1Byte4.Enabled = false;
				groupBoxA2Byte2.Enabled = true;
				groupBoxA2Byte3.Enabled = false;
				groupBoxA2Byte4.Enabled = false;
				groupBoxResultByte2.Enabled = true;
				groupBoxResultByte3.Enabled = false;
				groupBoxResultByte4.Enabled = false;
				break;
			default:
				groupBoxA1Byte2.Enabled = true;
				groupBoxA1Byte3.Enabled = true;
				groupBoxA1Byte4.Enabled = true;
				groupBoxA2Byte2.Enabled = true;
				groupBoxA2Byte3.Enabled = true;
				groupBoxA2Byte4.Enabled = true;
				groupBoxResultByte2.Enabled = true;
				groupBoxResultByte3.Enabled = true;
				groupBoxResultByte4.Enabled = true;
				break;
		}
	}

	private void ComboBoxDataConversionUnit_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	#endregion

	#region TextChanged event handlers

	private void TextBoxDataConversion_TextChanged(object sender, EventArgs e)
	{
	}

	#endregion

	#region Click event handlers

	private void ButtonAbout_Click(object sender, EventArgs e)
	{
		using AboutBox aboutBox = new();
		aboutBox.ShowDialog();
	}

	private void ButtonLsbSign_Click(object sender, EventArgs e)
	{
		isLsbSignSet = !isLsbSignSet;
		if (!isLsbSignSet)
		{
			buttonLsbSign.Text = Resources.lsb0;
			labelA1Bit00.Text = Resources.number00;
			labelA1Bit01.Text = Resources.number01;
			labelA1Bit02.Text = Resources.number02;
			labelA1Bit03.Text = Resources.number03;
			labelA1Bit04.Text = Resources.number04;
			labelA1Bit05.Text = Resources.number05;
			labelA1Bit06.Text = Resources.number06;
			labelA1Bit07.Text = Resources.number07;
			labelA1Bit08.Text = Resources.number08;
			labelA1Bit09.Text = Resources.number09;
			labelA1Bit10.Text = Resources.number10;
			labelA1Bit11.Text = Resources.number11;
			labelA1Bit12.Text = Resources.number12;
			labelA1Bit13.Text = Resources.number13;
			labelA1Bit14.Text = Resources.number14;
			labelA1Bit15.Text = Resources.number15;
			labelA1Bit16.Text = Resources.number16;
			labelA1Bit17.Text = Resources.number17;
			labelA1Bit18.Text = Resources.number18;
			labelA1Bit19.Text = Resources.number19;
			labelA1Bit20.Text = Resources.number20;
			labelA1Bit21.Text = Resources.number21;
			labelA1Bit22.Text = Resources.number22;
			labelA1Bit23.Text = Resources.number23;
			labelA1Bit24.Text = Resources.number24;
			labelA1Bit25.Text = Resources.number25;
			labelA1Bit26.Text = Resources.number26;
			labelA1Bit27.Text = Resources.number27;
			labelA1Bit28.Text = Resources.number28;
			labelA1Bit29.Text = Resources.number29;
			labelA1Bit30.Text = Resources.number30;
			labelA1Bit31.Text = Resources.number31;
			labelA2Bit00.Text = Resources.number00;
			labelA2Bit01.Text = Resources.number01;
			labelA2Bit02.Text = Resources.number02;
			labelA2Bit03.Text = Resources.number03;
			labelA2Bit04.Text = Resources.number04;
			labelA2Bit05.Text = Resources.number05;
			labelA2Bit06.Text = Resources.number06;
			labelA2Bit07.Text = Resources.number07;
			labelA2Bit08.Text = Resources.number08;
			labelA2Bit09.Text = Resources.number09;
			labelA2Bit10.Text = Resources.number10;
			labelA2Bit11.Text = Resources.number11;
			labelA2Bit12.Text = Resources.number12;
			labelA2Bit13.Text = Resources.number13;
			labelA2Bit14.Text = Resources.number14;
			labelA2Bit15.Text = Resources.number15;
			labelA2Bit16.Text = Resources.number16;
			labelA2Bit17.Text = Resources.number17;
			labelA2Bit18.Text = Resources.number18;
			labelA2Bit19.Text = Resources.number19;
			labelA2Bit20.Text = Resources.number20;
			labelA2Bit21.Text = Resources.number21;
			labelA2Bit22.Text = Resources.number22;
			labelA2Bit23.Text = Resources.number23;
			labelA2Bit24.Text = Resources.number24;
			labelA2Bit25.Text = Resources.number25;
			labelA2Bit26.Text = Resources.number26;
			labelA2Bit27.Text = Resources.number27;
			labelA2Bit28.Text = Resources.number28;
			labelA2Bit29.Text = Resources.number29;
			labelA2Bit30.Text = Resources.number30;
			labelA2Bit31.Text = Resources.number31;
			labelResultBit00.Text = Resources.number00;
			labelResultBit01.Text = Resources.number01;
			labelResultBit02.Text = Resources.number02;
			labelResultBit03.Text = Resources.number03;
			labelResultBit04.Text = Resources.number04;
			labelResultBit05.Text = Resources.number05;
			labelResultBit06.Text = Resources.number06;
			labelResultBit07.Text = Resources.number07;
			labelResultBit08.Text = Resources.number08;
			labelResultBit09.Text = Resources.number09;
			labelResultBit10.Text = Resources.number10;
			labelResultBit11.Text = Resources.number11;
			labelResultBit12.Text = Resources.number12;
			labelResultBit13.Text = Resources.number13;
			labelResultBit14.Text = Resources.number14;
			labelResultBit15.Text = Resources.number15;
			labelResultBit16.Text = Resources.number16;
			labelResultBit17.Text = Resources.number17;
			labelResultBit18.Text = Resources.number18;
			labelResultBit19.Text = Resources.number19;
			labelResultBit20.Text = Resources.number20;
			labelResultBit21.Text = Resources.number21;
			labelResultBit22.Text = Resources.number22;
			labelResultBit23.Text = Resources.number23;
			labelResultBit24.Text = Resources.number24;
			labelResultBit25.Text = Resources.number25;
			labelResultBit26.Text = Resources.number26;
			labelResultBit27.Text = Resources.number27;
			labelResultBit28.Text = Resources.number28;
			labelResultBit29.Text = Resources.number29;
			labelResultBit30.Text = Resources.number30;
			labelResultBit31.Text = Resources.number31;
		}
		else
		{
			buttonLsbSign.Text = Resources.lsb1;
			labelA1Bit00.Text = Resources.number01;
			labelA1Bit01.Text = Resources.number02;
			labelA1Bit02.Text = Resources.number03;
			labelA1Bit03.Text = Resources.number04;
			labelA1Bit04.Text = Resources.number05;
			labelA1Bit05.Text = Resources.number06;
			labelA1Bit06.Text = Resources.number07;
			labelA1Bit07.Text = Resources.number08;
			labelA1Bit08.Text = Resources.number09;
			labelA1Bit09.Text = Resources.number10;
			labelA1Bit10.Text = Resources.number11;
			labelA1Bit11.Text = Resources.number12;
			labelA1Bit12.Text = Resources.number13;
			labelA1Bit13.Text = Resources.number14;
			labelA1Bit14.Text = Resources.number15;
			labelA1Bit15.Text = Resources.number16;
			labelA1Bit16.Text = Resources.number17;
			labelA1Bit17.Text = Resources.number18;
			labelA1Bit18.Text = Resources.number19;
			labelA1Bit19.Text = Resources.number20;
			labelA1Bit20.Text = Resources.number21;
			labelA1Bit21.Text = Resources.number22;
			labelA1Bit22.Text = Resources.number23;
			labelA1Bit23.Text = Resources.number24;
			labelA1Bit24.Text = Resources.number25;
			labelA1Bit25.Text = Resources.number26;
			labelA1Bit26.Text = Resources.number27;
			labelA1Bit27.Text = Resources.number28;
			labelA1Bit28.Text = Resources.number29;
			labelA1Bit29.Text = Resources.number30;
			labelA1Bit30.Text = Resources.number31;
			labelA1Bit31.Text = Resources.number32;
			labelA2Bit00.Text = Resources.number01;
			labelA2Bit01.Text = Resources.number02;
			labelA2Bit02.Text = Resources.number03;
			labelA2Bit03.Text = Resources.number04;
			labelA2Bit04.Text = Resources.number05;
			labelA2Bit05.Text = Resources.number06;
			labelA2Bit06.Text = Resources.number07;
			labelA2Bit07.Text = Resources.number08;
			labelA2Bit08.Text = Resources.number09;
			labelA2Bit09.Text = Resources.number10;
			labelA2Bit10.Text = Resources.number11;
			labelA2Bit11.Text = Resources.number12;
			labelA2Bit12.Text = Resources.number13;
			labelA2Bit13.Text = Resources.number14;
			labelA2Bit14.Text = Resources.number15;
			labelA2Bit15.Text = Resources.number16;
			labelA2Bit16.Text = Resources.number17;
			labelA2Bit17.Text = Resources.number18;
			labelA2Bit18.Text = Resources.number19;
			labelA2Bit19.Text = Resources.number20;
			labelA2Bit20.Text = Resources.number21;
			labelA2Bit21.Text = Resources.number22;
			labelA2Bit22.Text = Resources.number23;
			labelA2Bit23.Text = Resources.number24;
			labelA2Bit24.Text = Resources.number25;
			labelA2Bit25.Text = Resources.number26;
			labelA2Bit26.Text = Resources.number27;
			labelA2Bit27.Text = Resources.number28;
			labelA2Bit28.Text = Resources.number29;
			labelA2Bit29.Text = Resources.number30;
			labelA2Bit30.Text = Resources.number31;
			labelA2Bit31.Text = Resources.number32;
			labelResultBit00.Text = Resources.number01;
			labelResultBit01.Text = Resources.number02;
			labelResultBit02.Text = Resources.number03;
			labelResultBit03.Text = Resources.number04;
			labelResultBit04.Text = Resources.number05;
			labelResultBit05.Text = Resources.number06;
			labelResultBit06.Text = Resources.number07;
			labelResultBit07.Text = Resources.number08;
			labelResultBit08.Text = Resources.number09;
			labelResultBit09.Text = Resources.number10;
			labelResultBit10.Text = Resources.number11;
			labelResultBit11.Text = Resources.number12;
			labelResultBit12.Text = Resources.number13;
			labelResultBit13.Text = Resources.number14;
			labelResultBit14.Text = Resources.number15;
			labelResultBit15.Text = Resources.number16;
			labelResultBit16.Text = Resources.number17;
			labelResultBit17.Text = Resources.number18;
			labelResultBit18.Text = Resources.number19;
			labelResultBit19.Text = Resources.number20;
			labelResultBit20.Text = Resources.number21;
			labelResultBit21.Text = Resources.number22;
			labelResultBit22.Text = Resources.number23;
			labelResultBit23.Text = Resources.number24;
			labelResultBit24.Text = Resources.number25;
			labelResultBit25.Text = Resources.number26;
			labelResultBit26.Text = Resources.number27;
			labelResultBit27.Text = Resources.number28;
			labelResultBit28.Text = Resources.number29;
			labelResultBit29.Text = Resources.number30;
			labelResultBit30.Text = Resources.number31;
			labelResultBit31.Text = Resources.number32;
		}
	}

	private void ButtonAdditionA1AndA2_Click(object sender, EventArgs e)
	{
		bool carry = false;
		for (int i = 0; i < accumulator1.Length; i++)
		{
			if (!carry)
			{
				result.Set(index: i, value: Add(value1: accumulator1.Get(index: i), value2: accumulator2.Get(index: i), carry: ref carry));
			}
			else
			{
				result.Set(index: i, value: Add(value1: accumulator1.Get(index: i), value2: carry, carry: ref carry));
				result.Set(index: i, value: Add(value1: result.Get(index: i), value2: accumulator2.Get(index: i), carry: ref carry));
			}
		}
		ShowBits(result, _resultBits, GetActiveBitCount());
	}

	private void ButtonSubtractionA1AndA2_Click(object sender, EventArgs e)
	{
		ShowBits(result, _resultBits, GetActiveBitCount());
	}

	private void ButtonMultiplicationA1AndA2_Click(object sender, EventArgs e)
	{
		ShowBits(result, _resultBits, GetActiveBitCount());
	}

	private void ButtonDivisionA1AndA2_Click(object sender, EventArgs e)
	{
		ShowBits(result, _resultBits, GetActiveBitCount());
	}

	private void ButtonLogicalAndA1AndA2_Click(object sender, EventArgs e)
	{
		result = (BitArray)accumulator1.Clone();
		result.And(value: accumulator2);
		ShowBits(result, _resultBits, GetActiveBitCount());
	}

	private void ButtonLogicalOrA1AndA2_Click(object sender, EventArgs e)
	{
		result = (BitArray)accumulator1.Clone();
		result.Or(value: accumulator2);
		ShowBits(result, _resultBits, GetActiveBitCount());
	}

	private void ButtonLogicalXorA1AndA2_Click(object sender, EventArgs e)
	{
		result = (BitArray)accumulator1.Clone();
		result.Xor(value: accumulator2);
		ShowBits(result, _resultBits, GetActiveBitCount());
	}

	private void ButtonLogicalNandA1AndA2_Click_Click(object sender, EventArgs e)
	{
		result = (BitArray)accumulator1.Clone();
		result.And(value: accumulator2);
		result.Not();
		ShowBits(result, _resultBits, GetActiveBitCount());
	}

	private void ButtonLogicalNorA1AndA2_Click(object sender, EventArgs e)
	{
		result = (BitArray)accumulator1.Clone();
		result.Or(value: accumulator2);
		result.Not();
		ShowBits(result, _resultBits, GetActiveBitCount());
	}

	private void ButtonLogicalXnorA1AndA2_Click(object sender, EventArgs e)
	{
		result = (BitArray)accumulator1.Clone();
		result.Xor(value: accumulator2);
		result.Not();
		ShowBits(result, _resultBits, GetActiveBitCount());
	}

	private void ButtonInvertA1_Click(object sender, EventArgs e)
	{
		accumulator1.Not();
		ShowBits(accumulator1, _a1Bits, GetActiveBitCount());
	}

	private void ButtonInvertA2_Click(object sender, EventArgs e)
	{
		accumulator2.Not();
		ShowBits(accumulator2, _a2Bits, GetActiveBitCount());
	}

	private void ButtonCopyResultToA1_Click(object sender, EventArgs e)
	{
		accumulator1 = (BitArray)result.Clone();
		ShowBits(accumulator1, _a1Bits, GetActiveBitCount());
	}

	private void ButtonCopyResultToA2_Click(object sender, EventArgs e)
	{
		accumulator2 = (BitArray)result.Clone();
		ShowBits(accumulator2, _a2Bits, GetActiveBitCount());
	}

	private void ButtonShiftLeftWithZeroA1_Click(object sender, EventArgs e)
	{
		for (int i = 1; i <= (int)numericUpDownShiftIndicator.Value; i++)
		{
			ShiftLeftA1(fillWithOne: false);
		}
		ShowBits(accumulator1, _a1Bits, GetActiveBitCount());
	}

	private void ButtonShiftLeftWithZeroA2_Click(object sender, EventArgs e)
	{
		for (int i = 1; i <= (int)numericUpDownShiftIndicator.Value; i++)
		{
			ShiftLeftA2(fillWithOne: false);
		}
		ShowBits(accumulator2, _a2Bits, GetActiveBitCount());
	}

	private void ButtonShiftLeftWithOneA1_Click(object sender, EventArgs e)
	{
		for (int i = 1; i <= (int)numericUpDownShiftIndicator.Value; i++)
		{
			ShiftLeftA1(fillWithOne: true);
		}
		ShowBits(accumulator1, _a1Bits, GetActiveBitCount());
	}

	private void ButtonShiftLeftWithOneA2_Click(object sender, EventArgs e)
	{
		for (int i = 1; i <= (int)numericUpDownShiftIndicator.Value; i++)
		{
			ShiftLeftA2(fillWithOne: true);
		}
		ShowBits(accumulator2, _a2Bits, GetActiveBitCount());
	}

	private void ButtonShiftRightWithZeroA1_Click(object sender, EventArgs e)
	{
		for (int i = 1; i <= (int)numericUpDownShiftIndicator.Value; i++)
		{
			ShiftRightA1(fillWithOne: false);
		}
		ShowBits(accumulator1, _a1Bits, GetActiveBitCount());
	}

	private void ButtonShiftRightWithZeroA2_Click(object sender, EventArgs e)
	{
		for (int i = 1; i <= (int)numericUpDownShiftIndicator.Value; i++)
		{
			ShiftRightA2(fillWithOne: false);
		}
		ShowBits(accumulator2, _a2Bits, GetActiveBitCount());
	}

	private void ButtonShiftRightWithOneA1_Click(object sender, EventArgs e)
	{
		for (int i = 1; i <= (int)numericUpDownShiftIndicator.Value; i++)
		{
			ShiftRightA1(fillWithOne: true);
		}
		ShowBits(accumulator1, _a1Bits, GetActiveBitCount());
	}

	private void ButtonShiftRightWithOneA2_Click(object sender, EventArgs e)
	{
		for (int i = 1; i <= (int)numericUpDownShiftIndicator.Value; i++)
		{
			ShiftRightA2(fillWithOne: true);
		}
		ShowBits(accumulator2, _a2Bits, GetActiveBitCount());
	}

	private void ButtonArithmeticShiftLeftWithZeroA1_Click(object sender, EventArgs e)
	{
		for (int i = 1; i <= (int)numericUpDownShiftIndicator.Value; i++)
		{
			ArithmeticShiftLeftA1(fillWithOne: false);
		}
		ShowBits(accumulator1, _a1Bits, GetActiveBitCount());
	}

	private void ButtonArithmeticShiftLeftWithZeroA2_Click(object sender, EventArgs e)
	{
		for (int i = 1; i <= (int)numericUpDownShiftIndicator.Value; i++)
		{
			ArithmeticShiftLeftA2(fillWithOne: false);
		}
		ShowBits(accumulator2, _a2Bits, GetActiveBitCount());
	}

	private void ButtonArithmeticShiftLeftWithOneA1_Click(object sender, EventArgs e)
	{
		for (int i = 1; i <= (int)numericUpDownShiftIndicator.Value; i++)
		{
			ArithmeticShiftLeftA1(fillWithOne: true);
		}
		ShowBits(accumulator1, _a1Bits, GetActiveBitCount());
	}

	private void ButtonArithmeticShiftLeftWithOneA2_Click(object sender, EventArgs e)
	{
		for (int i = 1; i <= (int)numericUpDownShiftIndicator.Value; i++)
		{
			ArithmeticShiftLeftA2(fillWithOne: true);
		}
		ShowBits(accumulator2, _a2Bits, GetActiveBitCount());
	}

	private void ButtonArithmeticShiftRightWithZeroA1_Click(object sender, EventArgs e)
	{
		for (int i = 1; i <= (int)numericUpDownShiftIndicator.Value; i++)
		{
			ArithmeticShiftRightA1(fillWithOne: false);
		}
		ShowBits(accumulator1, _a1Bits, GetActiveBitCount());
	}

	private void ButtonArithmeticShiftRightWithZeroA2_Click(object sender, EventArgs e)
	{
		for (int i = 1; i <= (int)numericUpDownShiftIndicator.Value; i++)
		{
			ArithmeticShiftRightA2(fillWithOne: false);
		}
		ShowBits(accumulator2, _a2Bits, GetActiveBitCount());
	}

	private void ButtonArithmeticShiftRightWithOneA1_Click(object sender, EventArgs e)
	{
		for (int i = 1; i <= (int)numericUpDownShiftIndicator.Value; i++)
		{
			ArithmeticShiftRightA1(fillWithOne: true);
		}
		ShowBits(accumulator1, _a1Bits, GetActiveBitCount());
	}

	private void ButtonArithmeticShiftRightWithOneA2_Click(object sender, EventArgs e)
	{
		for (int i = 1; i <= (int)numericUpDownShiftIndicator.Value; i++)
		{
			ArithmeticShiftRightA2(fillWithOne: true);
		}
		ShowBits(accumulator2, _a2Bits, GetActiveBitCount());
	}

	private void ButtonRotateLeftA1_Click(object sender, EventArgs e)
	{
		for (int i = 1; i <= (int)numericUpDownShiftIndicator.Value; i++)
		{
			RotateLeftA1();
		}
		ShowBits(accumulator1, _a1Bits, GetActiveBitCount());
	}

	private void ButtonRotateLeftA2_Click(object sender, EventArgs e)
	{
		for (int i = 1; i <= (int)numericUpDownShiftIndicator.Value; i++)
		{
			RotateLeftA2();
		}
		ShowBits(accumulator2, _a2Bits, GetActiveBitCount());
	}

	private void ButtonRotateRightA1_Click(object sender, EventArgs e)
	{
		for (int i = 1; i <= (int)numericUpDownShiftIndicator.Value; i++)
		{
			RotateRightA1();
		}
		ShowBits(accumulator1, _a1Bits, GetActiveBitCount());
	}

	private void ButtonRotateRightA2_Click(object sender, EventArgs e)
	{
		for (int i = 1; i <= (int)numericUpDownShiftIndicator.Value; i++)
		{
			RotateRightA2();
		}
		ShowBits(accumulator2, _a2Bits, GetActiveBitCount());
	}

	private void ButtonRotateLeftWithCarryA1_Click(object sender, EventArgs e)
	{
		ShowBits(accumulator1, _a1Bits, GetActiveBitCount());
	}

	private void ButtonRotateLeftWithCarryA2_Click(object sender, EventArgs e)
	{
		ShowBits(accumulator2, _a2Bits, GetActiveBitCount());
	}

	private void ButtonRotateRightWithCarryA1_Click(object sender, EventArgs e)
	{
		ShowBits(accumulator1, _a1Bits, GetActiveBitCount());
	}

	private void ButtonRotateRightWithCarryA2_Click(object sender, EventArgs e)
	{
		ShowBits(accumulator2, _a2Bits, GetActiveBitCount());
	}

	private void ButtonRevertA1_Click(object sender, EventArgs e)
	{
		BitArray bitArray = (BitArray)accumulator1.Clone();
		if (groupBoxA1Byte4.Enabled)
		{
			bitArray.Set(index: 0, value: accumulator1.Get(index: 31));
			bitArray.Set(index: 1, value: accumulator1.Get(index: 30));
			bitArray.Set(index: 2, value: accumulator1.Get(index: 29));
			bitArray.Set(index: 3, value: accumulator1.Get(index: 28));
			bitArray.Set(index: 4, value: accumulator1.Get(index: 27));
			bitArray.Set(index: 5, value: accumulator1.Get(index: 26));
			bitArray.Set(index: 6, value: accumulator1.Get(index: 25));
			bitArray.Set(index: 7, value: accumulator1.Get(index: 24));
			bitArray.Set(index: 8, value: accumulator1.Get(index: 23));
			bitArray.Set(index: 9, value: accumulator1.Get(index: 22));
			bitArray.Set(index: 10, value: accumulator1.Get(index: 21));
			bitArray.Set(index: 11, value: accumulator1.Get(index: 20));
			bitArray.Set(index: 12, value: accumulator1.Get(index: 19));
			bitArray.Set(index: 13, value: accumulator1.Get(index: 18));
			bitArray.Set(index: 14, value: accumulator1.Get(index: 17));
			bitArray.Set(index: 15, value: accumulator1.Get(index: 16));
			bitArray.Set(index: 16, value: accumulator1.Get(index: 15));
			bitArray.Set(index: 17, value: accumulator1.Get(index: 14));
			bitArray.Set(index: 18, value: accumulator1.Get(index: 13));
			bitArray.Set(index: 19, value: accumulator1.Get(index: 12));
			bitArray.Set(index: 20, value: accumulator1.Get(index: 11));
			bitArray.Set(index: 21, value: accumulator1.Get(index: 10));
			bitArray.Set(index: 22, value: accumulator1.Get(index: 9));
			bitArray.Set(index: 23, value: accumulator1.Get(index: 8));
			bitArray.Set(index: 24, value: accumulator1.Get(index: 7));
			bitArray.Set(index: 25, value: accumulator1.Get(index: 6));
			bitArray.Set(index: 26, value: accumulator1.Get(index: 5));
			bitArray.Set(index: 27, value: accumulator1.Get(index: 4));
			bitArray.Set(index: 28, value: accumulator1.Get(index: 3));
			bitArray.Set(index: 29, value: accumulator1.Get(index: 2));
			bitArray.Set(index: 30, value: accumulator1.Get(index: 1));
			bitArray.Set(index: 31, value: accumulator1.Get(index: 0));
		}
		else if (groupBoxA1Byte2.Enabled)
		{
			bitArray.Set(index: 0, value: accumulator1.Get(index: 15));
			bitArray.Set(index: 1, value: accumulator1.Get(index: 14));
			bitArray.Set(index: 2, value: accumulator1.Get(index: 13));
			bitArray.Set(index: 3, value: accumulator1.Get(index: 12));
			bitArray.Set(index: 4, value: accumulator1.Get(index: 11));
			bitArray.Set(index: 5, value: accumulator1.Get(index: 10));
			bitArray.Set(index: 6, value: accumulator1.Get(index: 9));
			bitArray.Set(index: 7, value: accumulator1.Get(index: 8));
			bitArray.Set(index: 8, value: accumulator1.Get(index: 7));
			bitArray.Set(index: 9, value: accumulator1.Get(index: 6));
			bitArray.Set(index: 10, value: accumulator1.Get(index: 5));
			bitArray.Set(index: 11, value: accumulator1.Get(index: 4));
			bitArray.Set(index: 12, value: accumulator1.Get(index: 3));
			bitArray.Set(index: 13, value: accumulator1.Get(index: 2));
			bitArray.Set(index: 14, value: accumulator1.Get(index: 1));
			bitArray.Set(index: 15, value: accumulator1.Get(index: 0));
		}
		else
		{
			bitArray.Set(index: 0, value: accumulator1.Get(index: 7));
			bitArray.Set(index: 1, value: accumulator1.Get(index: 6));
			bitArray.Set(index: 2, value: accumulator1.Get(index: 5));
			bitArray.Set(index: 3, value: accumulator1.Get(index: 4));
			bitArray.Set(index: 4, value: accumulator1.Get(index: 3));
			bitArray.Set(index: 5, value: accumulator1.Get(index: 2));
			bitArray.Set(index: 6, value: accumulator1.Get(index: 1));
			bitArray.Set(index: 7, value: accumulator1.Get(index: 0));
		}
		accumulator1 = (BitArray)bitArray.Clone();
		ShowBits(accumulator1, _a1Bits, GetActiveBitCount());
	}

	private void ButtonRevertA2_Click(object sender, EventArgs e)
	{
		BitArray bitArray = (BitArray)accumulator2.Clone();
		if (groupBoxA2Byte4.Enabled)
		{
			bitArray.Set(index: 0, value: accumulator2.Get(index: 31));
			bitArray.Set(index: 1, value: accumulator2.Get(index: 30));
			bitArray.Set(index: 2, value: accumulator2.Get(index: 29));
			bitArray.Set(index: 3, value: accumulator2.Get(index: 28));
			bitArray.Set(index: 4, value: accumulator2.Get(index: 27));
			bitArray.Set(index: 5, value: accumulator2.Get(index: 26));
			bitArray.Set(index: 6, value: accumulator2.Get(index: 25));
			bitArray.Set(index: 7, value: accumulator2.Get(index: 24));
			bitArray.Set(index: 8, value: accumulator2.Get(index: 23));
			bitArray.Set(index: 9, value: accumulator2.Get(index: 22));
			bitArray.Set(index: 10, value: accumulator2.Get(index: 21));
			bitArray.Set(index: 11, value: accumulator2.Get(index: 20));
			bitArray.Set(index: 12, value: accumulator2.Get(index: 19));
			bitArray.Set(index: 13, value: accumulator2.Get(index: 18));
			bitArray.Set(index: 14, value: accumulator2.Get(index: 17));
			bitArray.Set(index: 15, value: accumulator2.Get(index: 16));
			bitArray.Set(index: 16, value: accumulator2.Get(index: 15));
			bitArray.Set(index: 17, value: accumulator2.Get(index: 14));
			bitArray.Set(index: 18, value: accumulator2.Get(index: 13));
			bitArray.Set(index: 19, value: accumulator2.Get(index: 12));
			bitArray.Set(index: 20, value: accumulator2.Get(index: 11));
			bitArray.Set(index: 21, value: accumulator2.Get(index: 10));
			bitArray.Set(index: 22, value: accumulator2.Get(index: 9));
			bitArray.Set(index: 23, value: accumulator2.Get(index: 8));
			bitArray.Set(index: 24, value: accumulator2.Get(index: 7));
			bitArray.Set(index: 25, value: accumulator2.Get(index: 6));
			bitArray.Set(index: 26, value: accumulator2.Get(index: 5));
			bitArray.Set(index: 27, value: accumulator2.Get(index: 4));
			bitArray.Set(index: 28, value: accumulator2.Get(index: 3));
			bitArray.Set(index: 29, value: accumulator2.Get(index: 2));
			bitArray.Set(index: 30, value: accumulator2.Get(index: 1));
			bitArray.Set(index: 31, value: accumulator2.Get(index: 0));
		}
		else if (groupBoxA2Byte2.Enabled)
		{
			bitArray.Set(index: 0, value: accumulator2.Get(index: 15));
			bitArray.Set(index: 1, value: accumulator2.Get(index: 14));
			bitArray.Set(index: 2, value: accumulator2.Get(index: 13));
			bitArray.Set(index: 3, value: accumulator2.Get(index: 12));
			bitArray.Set(index: 4, value: accumulator2.Get(index: 11));
			bitArray.Set(index: 5, value: accumulator2.Get(index: 10));
			bitArray.Set(index: 6, value: accumulator2.Get(index: 9));
			bitArray.Set(index: 7, value: accumulator2.Get(index: 8));
			bitArray.Set(index: 8, value: accumulator2.Get(index: 7));
			bitArray.Set(index: 9, value: accumulator2.Get(index: 6));
			bitArray.Set(index: 10, value: accumulator2.Get(index: 5));
			bitArray.Set(index: 11, value: accumulator2.Get(index: 4));
			bitArray.Set(index: 12, value: accumulator2.Get(index: 3));
			bitArray.Set(index: 13, value: accumulator2.Get(index: 2));
			bitArray.Set(index: 14, value: accumulator2.Get(index: 1));
			bitArray.Set(index: 15, value: accumulator2.Get(index: 0));
		}
		else
		{
			bitArray.Set(index: 0, value: accumulator2.Get(index: 7));
			bitArray.Set(index: 1, value: accumulator2.Get(index: 6));
			bitArray.Set(index: 2, value: accumulator2.Get(index: 5));
			bitArray.Set(index: 3, value: accumulator2.Get(index: 4));
			bitArray.Set(index: 4, value: accumulator2.Get(index: 3));
			bitArray.Set(index: 5, value: accumulator2.Get(index: 2));
			bitArray.Set(index: 6, value: accumulator2.Get(index: 1));
			bitArray.Set(index: 7, value: accumulator2.Get(index: 0));
		}
		accumulator2 = (BitArray)bitArray.Clone();
		ShowBits(accumulator2, _a2Bits, GetActiveBitCount());
	}

	private void ButtonClearA1_Click(object sender, EventArgs e)
	{
		accumulator1.SetAll(value: false);
		ShowBits(accumulator1, _a1Bits, GetActiveBitCount());
	}

	private void ButtonClearA2_Click(object sender, EventArgs e)
	{
		accumulator2.SetAll(value: false);
		ShowBits(accumulator2, _a2Bits, GetActiveBitCount());
	}

	private void ButtonFillA1_Click(object sender, EventArgs e)
	{
		accumulator1.SetAll(value: true);
		ShowBits(accumulator1, _a1Bits, GetActiveBitCount());
	}

	private void ButtonFillA2_Click(object sender, EventArgs e)
	{
		accumulator2.SetAll(value: true);
		ShowBits(accumulator2, _a2Bits, GetActiveBitCount());
	}

	private void ButtonSwapA1A2_Click(object sender, EventArgs e)
	{
		BitArray bitArray = (BitArray)accumulator1.Clone();
		accumulator1 = (BitArray)accumulator2.Clone();
		accumulator2 = (BitArray)bitArray.Clone();
		ShowBits(accumulator1, _a1Bits, GetActiveBitCount());
		ShowBits(accumulator2, _a2Bits, GetActiveBitCount());
	}

	private void ButtonRandomizeA1_Click(object sender, EventArgs e)
	{
		SetAccumulator1RandomBits();
		ShowBits(accumulator1, _a1Bits, GetActiveBitCount());
	}

	private void ButtonRandomizeA2_Click(object sender, EventArgs e)
	{
		SetAccumulator2RandomBits();
		ShowBits(accumulator2, _a2Bits, GetActiveBitCount());
	}

	private void ButtonInhibitionA1A2_Click(object sender, EventArgs e)
	{
		result = (BitArray)accumulator1.Clone();
		BitArray bitArray = (BitArray)accumulator2.Clone();
		bitArray.Not();
		result.And(value: bitArray);
		ShowBits(result, _resultBits, GetActiveBitCount());
	}

	private void ButtonInhibitionA2A1_Click(object sender, EventArgs e)
	{
		result = (BitArray)accumulator2.Clone();
		BitArray bitArray = (BitArray)accumulator1.Clone();
		bitArray.Not();
		result.And(value: bitArray);
		ShowBits(result, _resultBits, GetActiveBitCount());
	}

	private void ButtonSubjunctionA1A2_Click(object sender, EventArgs e)
	{
		result = (BitArray)accumulator1.Clone();
		BitArray bitArray = (BitArray)accumulator2.Clone();
		bitArray.Not();
		result.Or(value: bitArray);
		ShowBits(result, _resultBits, GetActiveBitCount());
	}

	private void ButtonSubjunctionA2A1_Click(object sender, EventArgs e)
	{
		result = (BitArray)accumulator2.Clone();
		BitArray bitArray = (BitArray)accumulator1.Clone();
		bitArray.Not();
		result.Or(value: bitArray);
		ShowBits(result, _resultBits, GetActiveBitCount());
	}

	private void ButtonHalfSwapA1_Click(object sender, EventArgs e)
	{
		BitArray bitArray = (BitArray)accumulator1.Clone();
		if (groupBoxA1Byte4.Enabled)
		{
			bitArray.Set(index: 0, value: accumulator1.Get(index: 16));
			bitArray.Set(index: 1, value: accumulator1.Get(index: 17));
			bitArray.Set(index: 2, value: accumulator1.Get(index: 18));
			bitArray.Set(index: 3, value: accumulator1.Get(index: 19));
			bitArray.Set(index: 4, value: accumulator1.Get(index: 20));
			bitArray.Set(index: 5, value: accumulator1.Get(index: 21));
			bitArray.Set(index: 6, value: accumulator1.Get(index: 22));
			bitArray.Set(index: 7, value: accumulator1.Get(index: 23));
			bitArray.Set(index: 8, value: accumulator1.Get(index: 24));
			bitArray.Set(index: 9, value: accumulator1.Get(index: 25));
			bitArray.Set(index: 10, value: accumulator1.Get(index: 26));
			bitArray.Set(index: 11, value: accumulator1.Get(index: 27));
			bitArray.Set(index: 12, value: accumulator1.Get(index: 28));
			bitArray.Set(index: 13, value: accumulator1.Get(index: 29));
			bitArray.Set(index: 14, value: accumulator1.Get(index: 30));
			bitArray.Set(index: 15, value: accumulator1.Get(index: 31));
			bitArray.Set(index: 16, value: accumulator1.Get(index: 0));
			bitArray.Set(index: 17, value: accumulator1.Get(index: 1));
			bitArray.Set(index: 18, value: accumulator1.Get(index: 2));
			bitArray.Set(index: 19, value: accumulator1.Get(index: 3));
			bitArray.Set(index: 20, value: accumulator1.Get(index: 4));
			bitArray.Set(index: 21, value: accumulator1.Get(index: 5));
			bitArray.Set(index: 22, value: accumulator1.Get(index: 6));
			bitArray.Set(index: 23, value: accumulator1.Get(index: 7));
			bitArray.Set(index: 24, value: accumulator1.Get(index: 8));
			bitArray.Set(index: 25, value: accumulator1.Get(index: 9));
			bitArray.Set(index: 26, value: accumulator1.Get(index: 10));
			bitArray.Set(index: 27, value: accumulator1.Get(index: 11));
			bitArray.Set(index: 28, value: accumulator1.Get(index: 12));
			bitArray.Set(index: 29, value: accumulator1.Get(index: 13));
			bitArray.Set(index: 30, value: accumulator1.Get(index: 14));
			bitArray.Set(index: 31, value: accumulator1.Get(index: 15));
		}
		else if (groupBoxA1Byte2.Enabled)
		{
			bitArray.Set(index: 0, value: accumulator1.Get(index: 8));
			bitArray.Set(index: 1, value: accumulator1.Get(index: 9));
			bitArray.Set(index: 2, value: accumulator1.Get(index: 10));
			bitArray.Set(index: 3, value: accumulator1.Get(index: 11));
			bitArray.Set(index: 4, value: accumulator1.Get(index: 12));
			bitArray.Set(index: 5, value: accumulator1.Get(index: 13));
			bitArray.Set(index: 6, value: accumulator1.Get(index: 14));
			bitArray.Set(index: 7, value: accumulator1.Get(index: 15));
			bitArray.Set(index: 8, value: accumulator1.Get(index: 0));
			bitArray.Set(index: 9, value: accumulator1.Get(index: 1));
			bitArray.Set(index: 10, value: accumulator1.Get(index: 2));
			bitArray.Set(index: 11, value: accumulator1.Get(index: 3));
			bitArray.Set(index: 12, value: accumulator1.Get(index: 4));
			bitArray.Set(index: 13, value: accumulator1.Get(index: 5));
			bitArray.Set(index: 14, value: accumulator1.Get(index: 6));
			bitArray.Set(index: 15, value: accumulator1.Get(index: 7));
		}
		else
		{
			bitArray.Set(index: 0, value: accumulator1.Get(index: 4));
			bitArray.Set(index: 1, value: accumulator1.Get(index: 5));
			bitArray.Set(index: 2, value: accumulator1.Get(index: 6));
			bitArray.Set(index: 3, value: accumulator1.Get(index: 7));
			bitArray.Set(index: 4, value: accumulator1.Get(index: 0));
			bitArray.Set(index: 5, value: accumulator1.Get(index: 1));
			bitArray.Set(index: 6, value: accumulator1.Get(index: 2));
			bitArray.Set(index: 7, value: accumulator1.Get(index: 3));
		}
		accumulator1 = (BitArray)bitArray.Clone();
		ShowBits(accumulator1, _a1Bits, GetActiveBitCount());
	}

	private void ButtonHalfSwapA2_Click(object sender, EventArgs e)
	{
		BitArray bitArray = (BitArray)accumulator2.Clone();
		if (groupBoxA2Byte4.Enabled)
		{
			bitArray.Set(index: 0, value: accumulator2.Get(index: 16));
			bitArray.Set(index: 1, value: accumulator2.Get(index: 17));
			bitArray.Set(index: 2, value: accumulator2.Get(index: 18));
			bitArray.Set(index: 3, value: accumulator2.Get(index: 19));
			bitArray.Set(index: 4, value: accumulator2.Get(index: 20));
			bitArray.Set(index: 5, value: accumulator2.Get(index: 21));
			bitArray.Set(index: 6, value: accumulator2.Get(index: 22));
			bitArray.Set(index: 7, value: accumulator2.Get(index: 23));
			bitArray.Set(index: 8, value: accumulator2.Get(index: 24));
			bitArray.Set(index: 9, value: accumulator2.Get(index: 25));
			bitArray.Set(index: 10, value: accumulator2.Get(index: 26));
			bitArray.Set(index: 11, value: accumulator2.Get(index: 27));
			bitArray.Set(index: 12, value: accumulator2.Get(index: 28));
			bitArray.Set(index: 13, value: accumulator2.Get(index: 29));
			bitArray.Set(index: 14, value: accumulator2.Get(index: 30));
			bitArray.Set(index: 15, value: accumulator2.Get(index: 31));
			bitArray.Set(index: 16, value: accumulator2.Get(index: 0));
			bitArray.Set(index: 17, value: accumulator2.Get(index: 1));
			bitArray.Set(index: 18, value: accumulator2.Get(index: 2));
			bitArray.Set(index: 19, value: accumulator2.Get(index: 3));
			bitArray.Set(index: 20, value: accumulator2.Get(index: 4));
			bitArray.Set(index: 21, value: accumulator2.Get(index: 5));
			bitArray.Set(index: 22, value: accumulator2.Get(index: 6));
			bitArray.Set(index: 23, value: accumulator2.Get(index: 7));
			bitArray.Set(index: 24, value: accumulator2.Get(index: 8));
			bitArray.Set(index: 25, value: accumulator2.Get(index: 9));
			bitArray.Set(index: 26, value: accumulator2.Get(index: 10));
			bitArray.Set(index: 27, value: accumulator2.Get(index: 11));
			bitArray.Set(index: 28, value: accumulator2.Get(index: 12));
			bitArray.Set(index: 29, value: accumulator2.Get(index: 13));
			bitArray.Set(index: 30, value: accumulator2.Get(index: 14));
			bitArray.Set(index: 31, value: accumulator2.Get(index: 15));
		}
		else if (groupBoxA2Byte2.Enabled)
		{
			bitArray.Set(index: 0, value: accumulator2.Get(index: 8));
			bitArray.Set(index: 1, value: accumulator2.Get(index: 9));
			bitArray.Set(index: 2, value: accumulator2.Get(index: 10));
			bitArray.Set(index: 3, value: accumulator2.Get(index: 11));
			bitArray.Set(index: 4, value: accumulator2.Get(index: 12));
			bitArray.Set(index: 5, value: accumulator2.Get(index: 13));
			bitArray.Set(index: 6, value: accumulator2.Get(index: 14));
			bitArray.Set(index: 7, value: accumulator2.Get(index: 15));
			bitArray.Set(index: 8, value: accumulator2.Get(index: 0));
			bitArray.Set(index: 9, value: accumulator2.Get(index: 1));
			bitArray.Set(index: 10, value: accumulator2.Get(index: 2));
			bitArray.Set(index: 11, value: accumulator2.Get(index: 3));
			bitArray.Set(index: 12, value: accumulator2.Get(index: 4));
			bitArray.Set(index: 13, value: accumulator2.Get(index: 5));
			bitArray.Set(index: 14, value: accumulator2.Get(index: 6));
			bitArray.Set(index: 15, value: accumulator2.Get(index: 7));
		}
		else
		{
			bitArray.Set(index: 0, value: accumulator2.Get(index: 4));
			bitArray.Set(index: 1, value: accumulator2.Get(index: 5));
			bitArray.Set(index: 2, value: accumulator2.Get(index: 6));
			bitArray.Set(index: 3, value: accumulator2.Get(index: 7));
			bitArray.Set(index: 4, value: accumulator2.Get(index: 0));
			bitArray.Set(index: 5, value: accumulator2.Get(index: 1));
			bitArray.Set(index: 6, value: accumulator2.Get(index: 2));
			bitArray.Set(index: 7, value: accumulator2.Get(index: 3));
		}
		accumulator2 = (BitArray)bitArray.Clone();
		ShowBits(accumulator2, _a2Bits, GetActiveBitCount());
	}

	private void ButtonNibbleSwapA1_Click(object sender, EventArgs e)
	{
		BitArray bitArray = (BitArray)accumulator1.Clone();
		bitArray.Set(index: 0, value: accumulator1.Get(index: 4));
		bitArray.Set(index: 1, value: accumulator1.Get(index: 5));
		bitArray.Set(index: 2, value: accumulator1.Get(index: 6));
		bitArray.Set(index: 3, value: accumulator1.Get(index: 7));
		bitArray.Set(index: 4, value: accumulator1.Get(index: 0));
		bitArray.Set(index: 5, value: accumulator1.Get(index: 1));
		bitArray.Set(index: 6, value: accumulator1.Get(index: 2));
		bitArray.Set(index: 7, value: accumulator1.Get(index: 3));
		if (groupBoxA1Byte2.Enabled)
		{
			bitArray.Set(index: 8, value: accumulator1.Get(index: 12));
			bitArray.Set(index: 9, value: accumulator1.Get(index: 13));
			bitArray.Set(index: 10, value: accumulator1.Get(index: 14));
			bitArray.Set(index: 11, value: accumulator1.Get(index: 15));
			bitArray.Set(index: 12, value: accumulator1.Get(index: 8));
			bitArray.Set(index: 13, value: accumulator1.Get(index: 9));
			bitArray.Set(index: 14, value: accumulator1.Get(index: 10));
			bitArray.Set(index: 15, value: accumulator1.Get(index: 11));
		}
		if (groupBoxA1Byte4.Enabled)
		{
			bitArray.Set(index: 16, value: accumulator1.Get(index: 20));
			bitArray.Set(index: 17, value: accumulator1.Get(index: 21));
			bitArray.Set(index: 18, value: accumulator1.Get(index: 22));
			bitArray.Set(index: 19, value: accumulator1.Get(index: 23));
			bitArray.Set(index: 20, value: accumulator1.Get(index: 16));
			bitArray.Set(index: 21, value: accumulator1.Get(index: 17));
			bitArray.Set(index: 22, value: accumulator1.Get(index: 18));
			bitArray.Set(index: 23, value: accumulator1.Get(index: 19));
			bitArray.Set(index: 24, value: accumulator1.Get(index: 28));
			bitArray.Set(index: 25, value: accumulator1.Get(index: 29));
			bitArray.Set(index: 26, value: accumulator1.Get(index: 30));
			bitArray.Set(index: 27, value: accumulator1.Get(index: 31));
			bitArray.Set(index: 28, value: accumulator1.Get(index: 24));
			bitArray.Set(index: 29, value: accumulator1.Get(index: 25));
			bitArray.Set(index: 30, value: accumulator1.Get(index: 26));
			bitArray.Set(index: 31, value: accumulator1.Get(index: 27));
		}
		accumulator1 = (BitArray)bitArray.Clone();
		ShowBits(accumulator1, _a1Bits, GetActiveBitCount());
	}

	private void ButtonNibbleSwapA2_Click(object sender, EventArgs e)
	{
		BitArray bitArray = (BitArray)accumulator2.Clone();
		bitArray.Set(index: 0, value: accumulator2.Get(index: 4));
		bitArray.Set(index: 1, value: accumulator2.Get(index: 5));
		bitArray.Set(index: 2, value: accumulator2.Get(index: 6));
		bitArray.Set(index: 3, value: accumulator2.Get(index: 7));
		bitArray.Set(index: 4, value: accumulator2.Get(index: 0));
		bitArray.Set(index: 5, value: accumulator2.Get(index: 1));
		bitArray.Set(index: 6, value: accumulator2.Get(index: 2));
		bitArray.Set(index: 7, value: accumulator2.Get(index: 3));
		if (groupBoxA2Byte2.Enabled)
		{
			bitArray.Set(index: 8, value: accumulator2.Get(index: 12));
			bitArray.Set(index: 9, value: accumulator2.Get(index: 13));
			bitArray.Set(index: 10, value: accumulator2.Get(index: 14));
			bitArray.Set(index: 11, value: accumulator2.Get(index: 15));
			bitArray.Set(index: 12, value: accumulator2.Get(index: 8));
			bitArray.Set(index: 13, value: accumulator2.Get(index: 9));
			bitArray.Set(index: 14, value: accumulator2.Get(index: 10));
			bitArray.Set(index: 15, value: accumulator2.Get(index: 11));
		}
		if (groupBoxA2Byte4.Enabled)
		{
			bitArray.Set(index: 16, value: accumulator2.Get(index: 20));
			bitArray.Set(index: 17, value: accumulator2.Get(index: 21));
			bitArray.Set(index: 18, value: accumulator2.Get(index: 22));
			bitArray.Set(index: 19, value: accumulator2.Get(index: 23));
			bitArray.Set(index: 20, value: accumulator2.Get(index: 16));
			bitArray.Set(index: 21, value: accumulator2.Get(index: 17));
			bitArray.Set(index: 22, value: accumulator2.Get(index: 18));
			bitArray.Set(index: 23, value: accumulator2.Get(index: 19));
			bitArray.Set(index: 24, value: accumulator2.Get(index: 28));
			bitArray.Set(index: 25, value: accumulator2.Get(index: 29));
			bitArray.Set(index: 26, value: accumulator2.Get(index: 30));
			bitArray.Set(index: 27, value: accumulator2.Get(index: 31));
			bitArray.Set(index: 28, value: accumulator2.Get(index: 24));
			bitArray.Set(index: 29, value: accumulator2.Get(index: 25));
			bitArray.Set(index: 30, value: accumulator2.Get(index: 26));
			bitArray.Set(index: 31, value: accumulator2.Get(index: 27));
		}
		accumulator2 = (BitArray)bitArray.Clone();
		ShowBits(accumulator2, _a2Bits, GetActiveBitCount());
	}

	private void ButtonBitSwapA1_Click(object sender, EventArgs e)
	{
		BitArray bitArray = (BitArray)accumulator1.Clone();
		bitArray.Set(index: 0, value: accumulator1.Get(index: 1));
		bitArray.Set(index: 1, value: accumulator1.Get(index: 0));
		bitArray.Set(index: 2, value: accumulator1.Get(index: 3));
		bitArray.Set(index: 3, value: accumulator1.Get(index: 2));
		bitArray.Set(index: 4, value: accumulator1.Get(index: 5));
		bitArray.Set(index: 5, value: accumulator1.Get(index: 4));
		bitArray.Set(index: 6, value: accumulator1.Get(index: 7));
		bitArray.Set(index: 7, value: accumulator1.Get(index: 6));
		if (groupBoxA1Byte2.Enabled)
		{
			bitArray.Set(index: 8, value: accumulator1.Get(index: 9));
			bitArray.Set(index: 9, value: accumulator1.Get(index: 8));
			bitArray.Set(index: 10, value: accumulator1.Get(index: 11));
			bitArray.Set(index: 11, value: accumulator1.Get(index: 10));
			bitArray.Set(index: 12, value: accumulator1.Get(index: 13));
			bitArray.Set(index: 13, value: accumulator1.Get(index: 12));
			bitArray.Set(index: 14, value: accumulator1.Get(index: 15));
			bitArray.Set(index: 15, value: accumulator1.Get(index: 14));
		}
		if (groupBoxA1Byte4.Enabled)
		{
			bitArray.Set(index: 16, value: accumulator1.Get(index: 17));
			bitArray.Set(index: 17, value: accumulator1.Get(index: 16));
			bitArray.Set(index: 18, value: accumulator1.Get(index: 19));
			bitArray.Set(index: 19, value: accumulator1.Get(index: 18));
			bitArray.Set(index: 20, value: accumulator1.Get(index: 21));
			bitArray.Set(index: 21, value: accumulator1.Get(index: 20));
			bitArray.Set(index: 22, value: accumulator1.Get(index: 23));
			bitArray.Set(index: 23, value: accumulator1.Get(index: 22));
			bitArray.Set(index: 24, value: accumulator1.Get(index: 25));
			bitArray.Set(index: 25, value: accumulator1.Get(index: 24));
			bitArray.Set(index: 26, value: accumulator1.Get(index: 27));
			bitArray.Set(index: 27, value: accumulator1.Get(index: 26));
			bitArray.Set(index: 28, value: accumulator1.Get(index: 29));
			bitArray.Set(index: 29, value: accumulator1.Get(index: 28));
			bitArray.Set(index: 30, value: accumulator1.Get(index: 31));
			bitArray.Set(index: 31, value: accumulator1.Get(index: 30));
		}
		accumulator1 = (BitArray)bitArray.Clone();
		ShowBits(accumulator1, _a1Bits, GetActiveBitCount());
	}

	private void ButtonBitSwapA2_Click(object sender, EventArgs e)
	{
		BitArray bitArray = (BitArray)accumulator2.Clone();
		bitArray.Set(index: 0, value: accumulator2.Get(index: 1));
		bitArray.Set(index: 1, value: accumulator2.Get(index: 0));
		bitArray.Set(index: 2, value: accumulator2.Get(index: 3));
		bitArray.Set(index: 3, value: accumulator2.Get(index: 2));
		bitArray.Set(index: 4, value: accumulator2.Get(index: 5));
		bitArray.Set(index: 5, value: accumulator2.Get(index: 4));
		bitArray.Set(index: 6, value: accumulator2.Get(index: 7));
		bitArray.Set(index: 7, value: accumulator2.Get(index: 6));
		if (groupBoxA2Byte2.Enabled)
		{
			bitArray.Set(index: 8, value: accumulator2.Get(index: 9));
			bitArray.Set(index: 9, value: accumulator2.Get(index: 8));
			bitArray.Set(index: 10, value: accumulator2.Get(index: 11));
			bitArray.Set(index: 11, value: accumulator2.Get(index: 10));
			bitArray.Set(index: 12, value: accumulator2.Get(index: 13));
			bitArray.Set(index: 13, value: accumulator2.Get(index: 12));
			bitArray.Set(index: 14, value: accumulator2.Get(index: 15));
			bitArray.Set(index: 15, value: accumulator2.Get(index: 14));
		}
		if (groupBoxA2Byte4.Enabled)
		{
			bitArray.Set(index: 16, value: accumulator2.Get(index: 17));
			bitArray.Set(index: 17, value: accumulator2.Get(index: 16));
			bitArray.Set(index: 18, value: accumulator2.Get(index: 19));
			bitArray.Set(index: 19, value: accumulator2.Get(index: 18));
			bitArray.Set(index: 20, value: accumulator2.Get(index: 21));
			bitArray.Set(index: 21, value: accumulator2.Get(index: 20));
			bitArray.Set(index: 22, value: accumulator2.Get(index: 23));
			bitArray.Set(index: 23, value: accumulator2.Get(index: 22));
			bitArray.Set(index: 24, value: accumulator2.Get(index: 25));
			bitArray.Set(index: 25, value: accumulator2.Get(index: 24));
			bitArray.Set(index: 26, value: accumulator2.Get(index: 27));
			bitArray.Set(index: 27, value: accumulator2.Get(index: 26));
			bitArray.Set(index: 28, value: accumulator2.Get(index: 29));
			bitArray.Set(index: 29, value: accumulator2.Get(index: 28));
			bitArray.Set(index: 30, value: accumulator2.Get(index: 31));
			bitArray.Set(index: 31, value: accumulator2.Get(index: 30));
		}
		accumulator2 = (BitArray)bitArray.Clone();
		ShowBits(accumulator2, _a2Bits, GetActiveBitCount());
	}

	private void ButtonFormingTwosComponentA1_Click(object sender, EventArgs e)
	{
		ShowBits(accumulator1, _a1Bits, GetActiveBitCount());
	}

	private void ButtonFormingTwosComponentA2_Click(object sender, EventArgs e)
	{
		ShowBits(accumulator2, _a2Bits, GetActiveBitCount());
	}

	private void ButtonStatistics_Click(object sender, EventArgs e)
	{
		int numberA1Bit0 = 0, numberA1Bit1 = 0, numberA2Bit0 = 0, numberA2Bit1 = 0, numberResultBit0 = 0, numberResultBit1 = 0;
		for (int i = 0; i < accumulator1.Length; i++)
		{
			if (accumulator1.Get(index: i))
			{
				numberA1Bit1++;
			}
			else
			{
				numberA1Bit0++;
			}
		}
		for (int i = 0; i < accumulator2.Length; i++)
		{
			if (accumulator2.Get(index: i))
			{
				numberA2Bit1++;
			}
			else
			{
				numberA2Bit0++;
			}
		}
		for (int i = 0; i < result.Length; i++)
		{
			if (result.Get(index: i))
			{
				numberResultBit1++;
			}
			else
			{
				numberResultBit0++;
			}
		}
		using StatisticsForm statisticsForm = new();
		statisticsForm.SetData(nA1Bit0: numberA1Bit0, nA1Bit1: numberA1Bit1, nA2Bit0: numberA2Bit0, nA2Bit1: numberA2Bit1, nResultBit0: numberResultBit0, nResultBit1: numberResultBit1);
		statisticsForm.ShowDialog();
	}

	#endregion

	#region CheckedChanged event handlers

	private void CheckBoxA1Bit00_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 0, value: checkBoxA1Bit00.Checked);

	private void CheckBoxA1Bit01_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 1, value: checkBoxA1Bit01.Checked);

	private void CheckBoxA1Bit02_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 2, value: checkBoxA1Bit02.Checked);

	private void CheckBoxA1Bit03_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 3, value: checkBoxA1Bit03.Checked);

	private void CheckBoxA1Bit04_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 4, value: checkBoxA1Bit04.Checked);

	private void CheckBoxA1Bit05_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 5, value: checkBoxA1Bit05.Checked);

	private void CheckBoxA1Bit06_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 6, value: checkBoxA1Bit06.Checked);

	private void CheckBoxA1Bit07_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 7, value: checkBoxA1Bit07.Checked);

	private void CheckBoxA1Bit08_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 8, value: checkBoxA1Bit08.Checked);

	private void CheckBoxA1Bit09_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 9, value: checkBoxA1Bit09.Checked);

	private void CheckBoxA1Bit10_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 10, value: checkBoxA1Bit10.Checked);

	private void CheckBoxA1Bit11_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 11, value: checkBoxA1Bit11.Checked);

	private void CheckBoxA1Bit12_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 12, value: checkBoxA1Bit12.Checked);

	private void CheckBoxA1Bit13_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 13, value: checkBoxA1Bit13.Checked);

	private void CheckBoxA1Bit14_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 14, value: checkBoxA1Bit14.Checked);

	private void CheckBoxA1Bit15_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 15, value: checkBoxA1Bit15.Checked);

	private void CheckBoxA1Bit16_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 16, value: checkBoxA1Bit16.Checked);

	private void CheckBoxA1Bit17_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 17, value: checkBoxA1Bit17.Checked);

	private void CheckBoxA1Bit18_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 18, value: checkBoxA1Bit18.Checked);

	private void CheckBoxA1Bit19_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 19, value: checkBoxA1Bit19.Checked);

	private void CheckBoxA1Bit20_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 20, value: checkBoxA1Bit20.Checked);

	private void CheckBoxA1Bit21_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 21, value: checkBoxA1Bit21.Checked);

	private void CheckBoxA1Bit22_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 22, value: checkBoxA1Bit22.Checked);

	private void CheckBoxA1Bit23_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 23, value: checkBoxA1Bit23.Checked);

	private void CheckBoxA1Bit24_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 24, value: checkBoxA1Bit24.Checked);

	private void CheckBoxA1Bit25_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 25, value: checkBoxA1Bit25.Checked);

	private void CheckBoxA1Bit26_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 26, value: checkBoxA1Bit26.Checked);

	private void CheckBoxA1Bit27_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 27, value: checkBoxA1Bit27.Checked);

	private void CheckBoxA1Bit28_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 28, value: checkBoxA1Bit28.Checked);

	private void CheckBoxA1Bit29_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 29, value: checkBoxA1Bit29.Checked);

	private void CheckBoxA1Bit30_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 30, value: checkBoxA1Bit30.Checked);

	private void CheckBoxA1Bit31_CheckedChanged(object sender, EventArgs e) => accumulator1.Set(index: 31, value: checkBoxA1Bit31.Checked);

	private void CheckBoxA2Bit00_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 0, value: checkBoxA2Bit00.Checked);

	private void CheckBoxA2Bit01_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 1, value: checkBoxA2Bit01.Checked);

	private void CheckBoxA2Bit02_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 2, value: checkBoxA2Bit02.Checked);

	private void CheckBoxA2Bit03_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 3, value: checkBoxA2Bit03.Checked);

	private void CheckBoxA2Bit04_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 4, value: checkBoxA2Bit04.Checked);

	private void CheckBoxA2Bit05_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 5, value: checkBoxA2Bit05.Checked);

	private void CheckBoxA2Bit06_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 6, value: checkBoxA2Bit06.Checked);

	private void CheckBoxA2Bit07_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 7, value: checkBoxA2Bit07.Checked);

	private void CheckBoxA2Bit08_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 8, value: checkBoxA2Bit08.Checked);

	private void CheckBoxA2Bit09_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 9, value: checkBoxA2Bit09.Checked);

	private void CheckBoxA2Bit10_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 10, value: checkBoxA2Bit10.Checked);

	private void CheckBoxA2Bit11_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 11, value: checkBoxA2Bit11.Checked);

	private void CheckBoxA2Bit12_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 12, value: checkBoxA2Bit12.Checked);

	private void CheckBoxA2Bit13_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 13, value: checkBoxA2Bit13.Checked);

	private void CheckBoxA2Bit14_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 14, value: checkBoxA2Bit14.Checked);

	private void CheckBoxA2Bit15_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 15, value: checkBoxA2Bit15.Checked);

	private void CheckBoxA2Bit16_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 16, value: checkBoxA2Bit16.Checked);

	private void CheckBoxA2Bit17_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 17, value: checkBoxA2Bit17.Checked);

	private void CheckBoxA2Bit18_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 18, value: checkBoxA2Bit18.Checked);

	private void CheckBoxA2Bit19_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 19, value: checkBoxA2Bit19.Checked);

	private void CheckBoxA2Bit20_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 20, value: checkBoxA2Bit20.Checked);

	private void CheckBoxA2Bit21_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 21, value: checkBoxA2Bit21.Checked);

	private void CheckBoxA2Bit22_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 22, value: checkBoxA2Bit22.Checked);

	private void CheckBoxA2Bit23_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 23, value: checkBoxA2Bit23.Checked);

	private void CheckBoxA2Bit24_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 24, value: checkBoxA2Bit24.Checked);

	private void CheckBoxA2Bit25_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 25, value: checkBoxA2Bit25.Checked);

	private void CheckBoxA2Bit26_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 26, value: checkBoxA2Bit26.Checked);

	private void CheckBoxA2Bit27_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 27, value: checkBoxA2Bit27.Checked);

	private void CheckBoxA2Bit28_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 28, value: checkBoxA2Bit28.Checked);

	private void CheckBoxA2Bit29_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 29, value: checkBoxA2Bit29.Checked);

	private void CheckBoxA2Bit30_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 30, value: checkBoxA2Bit30.Checked);

	private void CheckBoxA2Bit31_CheckedChanged(object sender, EventArgs e) => accumulator2.Set(index: 31, value: checkBoxA2Bit31.Checked);

	private void CheckBoxAlwaysOnTop_CheckedChanged(object sender, EventArgs e)
	{
	}

	#endregion

	/// <summary>
	/// Handles Enter (mouse over / focus) events for controls and ToolStrip items.
	/// If the sender provides a non-null <c>AccessibleDescription</c>, that text is shown in the status bar.
	/// </summary>
	/// <param name="sender">Event source — expected to be a <see cref="Control"/> or <see cref="ToolStripItem"/>.</param>
	/// <param name="e">Event arguments.</param>
	/// <remarks>
	/// This method is called when the mouse pointer enters a control or the control receives focus.
	/// </remarks>
	private void Control_Enter(object sender, EventArgs e)
	{
		// Check if the sender is null
		ArgumentNullException.ThrowIfNull(argument: sender);
		// Get the accessible description based on the sender type
		string? description = sender switch
		{
			Control c => c.AccessibleDescription,
			ToolStripItem t => t.AccessibleDescription,
			_ => null
		};
		// If a description is available, set it in the status bar
		if (description != null)
		{
			SetStatusBar(text: description);
		}
	}

	/// <summary>
	/// Called when the mouse pointer leaves a control or the control loses focus.
	/// Clears the status bar text (delegates to <see cref="ClearStatusBar"/>).
	/// </summary>
	/// <param name="sender">Event source.</param>
	/// <param name="e">Event arguments.</param>
	/// <remarks>
	/// This method is called when the mouse pointer leaves a control or the control loses focus.
	/// </remarks>
	private void Control_Leave(object? sender, EventArgs? e) => ClearStatusBar();
}
