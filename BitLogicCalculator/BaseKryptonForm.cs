using Krypton.Toolkit;

using NLog;

namespace BitLogicCalculator;

/// <summary>
/// Base class for all forms in the BitLogicCalculator application.
/// </summary>
public class BaseKryptonForm : KryptonForm
{
	/// <summary>
	/// Logger instance for logging messages and exceptions
	/// </summary>
	protected static readonly Logger logger = LogManager.GetCurrentClassLogger();

	/// <summary>
	/// Initializes a new instance of the <see cref="BaseKryptonForm"/> class.
	/// </summary>
	protected BaseKryptonForm()
	{
		// Ensure the form receives key events before child controls
		KeyPreview = true;
		KeyDown += BaseKryptonForm_KeyDown;
	}

	/// <summary>
	/// Handles exceptions by logging the error and showing a message box
	/// </summary>
	/// <param name="ex">The exception that occurred</param>
	/// <param name="message">The message to log and display</param>
	/// <param name="sender">The source of the event that caused the exception</param>
	/// <param name="e">The event data associated with the exception</param>
	protected static void HandleException(Exception ex, string message, object? sender = null, EventArgs? e = null)
	{
		// Structured logging; detailed information is in the log
		logger.Error(exception: ex, message: "Exception occurred. Message: {Message} | Sender: {Sender}", args: [message, sender]);
		// Show only a generic message to the user (details are in the log)
		_ = MessageBox.Show(text: message, caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
	}

	/// <summary>
	/// Copies the specified text to the clipboard and displays a confirmation message
	/// </summary>
	/// <param name="text">The text to be copied</param>
	protected static void CopyToClipboard(string text)
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

	/// <summary>
	/// Default KeyDown handler that closes the form when Escape is pressed.
	/// </summary>
	/// <param name="sender">Event source.</param>
	/// <param name="e">Key event args.</param>
	/// <remarks>
	/// This method is used to handle key down events for the form.
	/// </remarks>
	protected void BaseKryptonForm_KeyDown(object? sender, KeyEventArgs e)
	{
		// Close the form when Escape is pressed
		if (e.KeyCode == Keys.Escape && !this.InvokeRequired)
		{
			Close();
		}

		// jUST tESTING: Show help when F1 is pressed
		/*
		switch (e.KeyCode)
		{
			case Keys.F1:
				ShowHelp();
				e.Handled = true;
				break;
				case Keys.F2:
				ToggleAlwaysOnTop();
				e.Handled = true;
				break;
				case Keys.F3:
				ToggleFormOpacity();
				e.Handled = true;
				break;
				case Keys.F4:
				ToggleFormBorderStyle();
				e.Handled = true;
				break;
				case Keys.F5:
				ResetAccumulators();
				e.Handled = true;
				break;
				case Keys.F6:
				SwapAccumulators();
				e.Handled = true;
				break;
				case Keys.F7:
				PerformAddition();
				e.Handled = true;
				break;
				case Keys.F8:
				PerformSubtraction();
				e.Handled = true;
				break;
				case Keys.F9:
				PerformANDOperation();
				e.Handled = true;
				break;
				case Keys.F10:
				PerformOROperation();
				e.Handled = true;
				break;
				case Keys.F11:
				PerformXOROperation();
				e.Handled = true;
				break;
				case Keys.F12:
				PerformNOTOperation();
				e.Handled = true;
				break;
				case Keys.F13:
				PerformNANDOperation();
				e.Handled = true;
				break;
				case Keys.F14:
				PerformNOROperation();
				e.Handled = true;
				break;
				case Keys.F15:
				PerformXNOROperation();
				e.Handled = true;
				break;
				case Keys.F16:
				ShowStatistics();
				e.Handled = true;
				break;
				case Keys.F17:
				PerformCustomOperation();
				e.Handled = true;
				break;
				case Keys.F18:
				ShowAboutDialog();
				e.Handled = true;
				break;
				case Keys.F19:
				ShowUpdateChecker();
				e.Handled = true;
				break;
				case Keys.F20:
				ShowLicenseInfo();
				e.Handled = true;
				break;
				case Keys.F21:
				ShowPrivacyPolicy();
				e.Handled = true;
				break;
				case Keys.F22:
				ShowTermsOfService();
				e.Handled = true;
				break;
				case Keys.F23:
					ShowDocumentation();
				e.Handled = true;
				break;
				case Keys.F24:
					OpenSettingsDialog();
				e.Handled = true;
				break;
			default:
				break;
		}
		*/
	}
}