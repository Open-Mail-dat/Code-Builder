using System.ComponentModel.DataAnnotations;

namespace Mail.dat.BuildCommand
{
	/// <summary>
	/// Represents the options required for executing a command, including input specification files and the output
	/// directory for generated files.
	/// </summary>
	/// <remarks>This class is used to define the required parameters for a command-line operation.  Both properties
	/// are mandatory and must be provided to ensure successful execution.</remarks>
	internal class CommandOptions
	{
		/// <summary>
		/// Gets or sets a comma-delimited list of file paths to Mail.dat JSON specification files.
		/// </summary>
		/// <remarks>This property is required and must be populated with valid file paths. Each file path should
		/// point to a  Mail.dat JSON specification file.</remarks>
		[Required]
		[Display(Order = 1, Name = "specification-files", ShortName = "s", Description = "A list of specification comma delimited files each containing the full or relative path to the Mail.dat JSON specification file.")]
		public string SpecificationFiles { get; set; }
		
		/// <summary>
		/// Gets or sets the output directory where files are written.
		/// </summary>
		/// <remarks>The directory specified must exist and be writable. Ensure that the application has the necessary
		/// permissions  to write to the specified directory.</remarks>
		[Required]
		[Display(Order = 2, Name = "models-directory", ShortName = "c", Description = "The full path to the Models project.")]
		public DirectoryInfo ModelsDirectory { get; set; }

		/// <summary>
		/// Gets or sets the output directory where files are written.
		/// </summary>
		/// <remarks>The directory specified must exist and be writable. Ensure that the application has the necessary
		/// permissions  to write to the specified directory.</remarks>
		[Required]
		[Display(Order = 2, Name = "hosting-directory", ShortName = "h", Description = "The full path to the Hosting project.")]
		public DirectoryInfo HostingDirectory { get; set; }
	}
}