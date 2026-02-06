using Krypton.Toolkit;

using NLog;

using System.Globalization;

namespace BitLogicCalculator;

/// <summary>
/// Statistics form for displaying bit logic operation results.
/// </summary>
public partial class StatisticsForm : KryptonForm
{
	/// <summary>
	/// A1 Bit 0
	/// </summary>
	private int numberA1Bit0;

	/// <summary>
	/// A1 Bit 1
	/// </summary>
	private int numberA1Bit1;

	/// <summary>
	/// A2 Bit 0
	/// </summary>
	private int numberA2Bit0;

	/// <summary>
	/// A2 Bit 1
	/// </summary>
	private int numberA2Bit1;

	/// <summary>
	/// Result Bit 0
	/// </summary>
	private int numberResultBit0;

	/// <summary>
	/// Result Bit 1
	/// </summary>
	private int numberResultBit1;

	/// <summary>
	/// Logger instance for logging messages and exceptions
	/// </summary>
	private static readonly Logger logger = LogManager.GetCurrentClassLogger();

	/// <summary>
	/// Culture info
	/// </summary>
	private static readonly CultureInfo culture = CultureInfo.CurrentUICulture;

	#region Constructor

	/// <summary>
	/// Initializes a new instance of the StatisticsForm class.
	/// </summary>
	/// <remarks>This constructor sets up the form and its controls for displaying statistical information. Use this
	/// constructor to create and display the statistics form in your application.</remarks>
	public StatisticsForm() => InitializeComponent();

	#endregion

	#region Helper Methods

	/// <summary>
	/// Handles exceptions by logging the error and showing a message box
	/// </summary>
	/// <param name="ex">The exception that occurred</param>
	/// <param name="message">The message to log and display</param>
	/// <param name="sender">The source of the event that caused the exception</param>
	/// <param name="e">The event data associated with the exception</param>
	private static void HandleException(Exception ex, string message, object? sender = null, EventArgs? e = null)
	{
		// Structured logging; detailed information is in the log
		logger.Error(exception: ex, message: "Exception occurred. Message: {Message} | Sender: {Sender}", args: [message, sender]);
		// Show only a generic message to the user (details are in the log)
		_ = MessageBox.Show(text: message, caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
	}

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

	/// <summary>
	/// Copies the specified text to the clipboard and displays a confirmation message
	/// </summary>
	/// <param name="text">The text to be copied</param>
	private static void CopyToClipboard(string text)
	{
		// Do not attempt to copy if the text is null, empty, or whitespace
		if (string.IsNullOrWhiteSpace(value: text))
		{
			return;
		}
		// Attempt to copy the text to the clipboard and handle any potential exceptions
		try
		{
			// Clipboard operations can fail if the clipboard is being used by another process, so we catch exceptions to prevent crashes
			Clipboard.SetText(text: text);
			MessageBox.Show(text: "Copied to clipboard.", caption: "Information", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
		}
		// Catching general exceptions here to prevent the application from crashing due to clipboard access issues
		catch (Exception ex)
		{
			// Log the exception and show a user-friendly message without exposing technical details
			HandleException(ex: ex, message: "An error occurred while copying to clipboard.");
		}
	}

	#endregion

	/// <summary>
	/// Sets the data for the statistics form.
	/// </summary>
	/// <param name="nA1Bit0">The value for A1 Bit 0.</param>
	/// <param name="nA1Bit1">The value for A1 Bit 1.</param>
	/// <param name="nA2Bit0">The value for A2 Bit 0.</param>
	/// <param name="nA2Bit1">The value for A2 Bit 1.</param>
	/// <param name="nResultBit0">The value for Result Bit 0.</param>
	/// <param name="nResultBit1">The value for Result Bit 1.</param>
	/// <remarks>This method is used to populate the statistics form with the relevant data for A1, A2, and Result bits. Call this method before displaying the form to ensure that the statistics are accurately represented.</remarks>
	public void SetData(int nA1Bit0, int nA1Bit1, int nA2Bit0, int nA2Bit1, int nResultBit0, int nResultBit1)
	{
		numberA1Bit0 = nA1Bit0;
		numberA1Bit1 = nA1Bit1;
		numberA2Bit0 = nA2Bit0;
		numberA2Bit1 = nA2Bit1;
		numberResultBit0 = nResultBit0;
		numberResultBit1 = nResultBit1;
	}

	/// <summary>
	/// Handles the Load event of the StatisticsForm, initializing and displaying statistical data in the form's labels.
	/// </summary>
	/// <param name="sender">The source of the event, typically the StatisticsForm instance.</param>
	/// <param name="e">An EventArgs object that contains the event data.</param>
	/// <remarks>This method populates the form's labels with the current statistical values and their corresponding
	/// percentages when the form is loaded. It is typically invoked automatically by the Windows Forms
	/// framework.</remarks>
	private void StatisticsForm_Load(object sender, EventArgs e)
	{
		labelA1Bit0Number.Text = $"{numberA1Bit0.ToString(provider: culture)}";
		labelA1Bit0Number.Values.ExtraText = $"{string.Format(provider: culture, format: " ({0:0.00}%)", args: 100.0 * numberA1Bit0 / (numberA1Bit0 + numberA1Bit1))}";
		labelA1Bit1Number.Text = $"{numberA1Bit1.ToString(provider: culture)}";
		labelA1Bit1Number.Values.ExtraText = $"{string.Format(provider: culture, format: " ({0:0.00}%)", args: 100.0 * numberA1Bit1 / (numberA1Bit0 + numberA1Bit1))}";
		labelA1TotalNumber.Text = $"{(numberA1Bit0 + numberA1Bit1).ToString(provider: culture)}";
		labelA1TotalNumber.Values.ExtraText = $"{string.Format(provider: culture, format: " ({0:0.00}%)", args: 100.0 * (numberA1Bit0 + numberA1Bit1) / (numberA1Bit0 + numberA1Bit1))}";
		labelA2Bit0Number.Text = $"{numberA2Bit0.ToString(provider: culture)}";
		labelA2Bit0Number.Values.ExtraText = $"{string.Format(provider: culture, format: " ({0:0.00}%)", args: 100.0 * numberA2Bit0 / (numberA2Bit0 + numberA2Bit1))}";
		labelA2Bit1Number.Text = $"{numberA2Bit1.ToString(provider: culture)}";
		labelA2Bit1Number.Values.ExtraText = $"{string.Format(provider: culture, format: " ({0:0.00}%)", args: 100.0 * numberA2Bit1 / (numberA2Bit0 + numberA2Bit1))}";
		labelA2TotalNumber.Text = $"{(numberA2Bit0 + numberA2Bit1).ToString(provider: culture)}";
		labelA2TotalNumber.Values.ExtraText = $"{string.Format(provider: culture, format: " ({0:0.00}%)", args: 100.0 * (numberA2Bit0 + numberA2Bit1) / (numberA2Bit0 + numberA2Bit1))}";
		labelResultBit0Number.Text = $"{numberResultBit0.ToString(provider: culture)}";
		labelResultBit0Number.Values.ExtraText = $"{string.Format(provider: culture, format: " ({0:0.00}%)", args: 100.0 * numberResultBit0 / (numberResultBit0 + numberResultBit1))}";
		labelResultBit1Number.Text = $"{numberResultBit1.ToString(provider: culture)}";
		labelResultBit1Number.Values.ExtraText = $"{string.Format(provider: culture, format: " ({0:0.00}%)", args: 100.0 * numberResultBit1 / (numberResultBit0 + numberResultBit1))}";
		labelResultTotalNumber.Text = $"{(numberResultBit0 + numberResultBit1).ToString(provider: culture)}";
		labelResultTotalNumber.Values.ExtraText = $"{string.Format(provider: culture, format: " ({0:0.00}%)", args: 100.0 * (numberResultBit0 + numberResultBit1) / (numberResultBit0 + numberResultBit1))}";
	}

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

	/// <summary>
	/// Handles double-click events on the label showing the number of bit 0 in accumulator 1.
	/// Copies the label text and its extra text to the clipboard.
	/// </summary>
	/// <param name="sender">Event source.</param>
	/// <param name="e">Event arguments.</param>
	/// <remarks>
	/// This method is called when the label is double-clicked.
	/// </remarks>
	private void LabelA1Bit0Number_DoubleClick(object sender, EventArgs e)
		=> CopyToClipboard(text: labelA1Bit0Number.Text + labelA1Bit0Number.Values.ExtraText);

	/// <summary>
	/// Handles double-click events on the label showing the number of bit 0 in accumulator 2.
	/// Copies the label text and its extra text to the clipboard.
	/// </summary>
	/// <param name="sender">Event source.</param>
	/// <param name="e">Event arguments.</param>
	/// <remarks>
	/// This method is called when the label is double-clicked.
	/// </remarks>
	private void LabelA2Bit0Number_DoubleClick(object sender, EventArgs e)
		=> CopyToClipboard(text: labelA2Bit0Number.Text + labelA2Bit0Number.Values.ExtraText);

	/// <summary>
	/// Handles double-click events on the label showing the number of bit 0 in the result.
	/// Copies the label text and its extra text to the clipboard.
	/// </summary>
	/// <param name="sender">Event source.</param>
	/// <param name="e">Event arguments.</param>
	/// <remarks>
	/// This method is called when the label is double-clicked.
	/// </remarks>
	private void LabelResultBit0Number_DoubleClick(object sender, EventArgs e)
		=> CopyToClipboard(text: labelResultBit0Number.Text + labelResultBit0Number.Values.ExtraText);

	/// <summary>
	/// Handles double-click events on the label showing the number of bit 1 in accumulator 1.
	/// Copies the label text and its extra text to the clipboard.
	/// </summary>
	/// <param name="sender">Event source.</param>
	/// <param name="e">Event arguments.</param>
	/// <remarks>
	/// This method is called when the label is double-clicked.
	/// </remarks>
	private void LabelA1Bit1Number_DoubleClick(object sender, EventArgs e)
		=> CopyToClipboard(text: labelA1Bit1Number.Text + labelA1Bit1Number.Values.ExtraText);

	/// <summary>
	/// Handles double-click events on the label showing the number of bit 1 in accumulator 2.
	/// Copies the label text and its extra text to the clipboard.
	/// </summary>
	/// <param name="sender">Event source.</param>
	/// <param name="e">Event arguments.</param>
	/// <remarks>
	/// This method is called when the label is double-clicked.
	/// </remarks>
	private void LabelA2Bit1Number_DoubleClick(object sender, EventArgs e)
		=> CopyToClipboard(text: labelA2Bit1Number.Text + labelA2Bit1Number.Values.ExtraText);

	/// <summary>
	/// Handles double-click events on the label showing the number of bit 1 in the result.
	/// Copies the label text and its extra text to the clipboard.
	/// </summary>
	/// <param name="sender">Event source.</param>
	/// <param name="e">Event arguments.</param>
	/// <remarks>
	/// This method is called when the label is double-clicked.
	/// </remarks>
	private void LabelResultBit1Number_DoubleClick(object sender, EventArgs e)
		=> CopyToClipboard(text: labelResultBit1Number.Text + labelResultBit1Number.Values.ExtraText);

	/// <summary>
	/// Handles double-click events on the label showing the total number in accumulator 1.
	/// Copies the label text and its extra text to the clipboard.
	/// </summary>
	/// <param name="sender">Event source.</param>
	/// <param name="e">Event arguments.</param>
	/// <remarks>
	/// This method is called when the label is double-clicked.
	/// </remarks>
	private void LabelA1TotalNumber_DoubleClick(object sender, EventArgs e)
		=> CopyToClipboard(text: labelA1TotalNumber.Text + labelA1TotalNumber.Values.ExtraText);

	/// <summary>
	/// Handles double-click events on the label showing the total number in accumulator 2.
	/// Copies the label text and its extra text to the clipboard.
	/// </summary>
	/// <param name="sender">Event source.</param>
	/// <param name="e">Event arguments.</param>
	/// <remarks>
	/// This method is called when the label is double-clicked.
	/// </remarks>
	private void LabelA2TotalNumber_DoubleClick(object sender, EventArgs e)
		=> CopyToClipboard(text: labelA2TotalNumber.Text + labelA2TotalNumber.Values.ExtraText);

	/// <summary>
	/// Handles double-click events on the label showing the total number in the result.
	/// Copies the label text and its extra text to the clipboard.
	/// </summary>
	/// <param name="sender">Event source.</param>
	/// <param name="e">Event arguments.</param>
	/// <remarks>
	/// This method is called when the label is double-clicked.
	/// </remarks>
	private void LabelResultTotalNumber_DoubleClick(object sender, EventArgs e)
		=> CopyToClipboard(text: labelResultTotalNumber.Text + labelResultTotalNumber.Values.ExtraText);
}
