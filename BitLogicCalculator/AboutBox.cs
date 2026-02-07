using Krypton.Toolkit;

using NLog;

namespace BitLogicCalculator;

/// <summary>
/// AboutBox
/// </summary>
internal partial class AboutBox : KryptonForm
{
	/// <summary>
	/// Logger instance for logging messages and exceptions
	/// </summary>
	private static readonly Logger logger = LogManager.GetCurrentClassLogger();

	/// <summary>
	/// Constructor
	/// </summary>
	public AboutBox() => InitializeComponent();

	/// <summary>
	/// Load the form
	/// </summary>
	/// <param name="sender">object sender</param>
	/// <param name="e">event arguments</param>
	/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
	private void AboutBox_Load(object sender, EventArgs e)
	{
		Text = $"Info about {AssemblyInfo.AssemblyTitle}";
		labelProductName.Text = AssemblyInfo.AssemblyProduct;
		labelVersion.Text = $"Version {AssemblyInfo.AssemblyVersion}";
		labelCopyright.Text = AssemblyInfo.AssemblyCopyright;
		labelCompanyName.Text = AssemblyInfo.AssemblyCompany;
		textBoxDescription.Text = AssemblyInfo.AssemblyDescription;
	}

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
	/// Handles double-click events on the label showing the product name.
	/// Copies the label text to the clipboard.
	/// </summary>
	/// <param name="sender">Event source.</param>
	/// <param name="e">Event arguments.</param>
	/// <remarks>
	/// This method is called when the label is double-clicked.
	/// </remarks>
	private void LabelProductName_DoubleClick(object sender, EventArgs e)
		=> CopyToClipboard(text: labelProductName.Text);

	/// <summary>
	/// Handles click events on the label showing the version.
	/// Copies the label text to the clipboard.
	/// </summary>
	/// <param name="sender">Event source.</param>
	/// <param name="e">Event arguments.</param>
	/// <remarks>
	/// This method is called when the label is clicked.
	/// </remarks>
	private void LabelVersion_Click(object sender, EventArgs e)
		=> CopyToClipboard(text: labelVersion.Text);

	/// <summary>
	/// Handles click events on the label showing the copyright information.
	/// Copies the label text to the clipboard.
	/// </summary>
	/// <param name="sender">Event source.</param>
	/// <param name="e">Event arguments.</param>
	/// <remarks>
	/// This method is called when the label is clicked.
	/// </remarks>
	private void LabelCopyright_Click(object sender, EventArgs e)
		=> CopyToClipboard(text: labelCopyright.Text);

	/// <summary>
	/// Handles click events on the label showing the company name.
	/// Copies the label text to the clipboard.
	/// </summary>
	/// <param name="sender">Event source.</param>
	/// <param name="e">Event arguments.</param>
	/// <remarks>
	/// This method is called when the label is clicked.
	/// </remarks>
	private void LabelCompanyName_Click(object sender, EventArgs e)
		=> CopyToClipboard(text: labelCompanyName.Text);
}
