//
// This file is part of Open Mail.dat.
// Copyright (c) 2025 Open Mail.dat
//
// ************************************************************************************************************************
// License Agreement:
//
// Open Mail.dat is free software: you can redistribute it and/or modify it under the terms of the
// GNU LESSER GENERAL PUBLIC LICENSE as published by the Free Software Foundation, either version 3
// of the License, or (at your option) any later version.
// Open Mail.dat is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without
// even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU LESSER GENERAL PUBLIC LICENSE for more details.
// You should have received three files as part of the license agreemen for Open Mail.dat.
//
// LICENSE (GNU Lesser General Public License)
// LICENSE.GPL3 (GNU General Public License)
// LICENSE-ADDENDUM.MD (Attribution and Public Use Addendum to the GNU Lesser General Public License v3.0 (LGPL-3.0))
//
// If not, see <https://www.gnu.org/licenses/>.
// ************************************************************************************************************************
//
// Author: Daniel M porrey
//
using System.Text;
using Microsoft.Extensions.Logging;

namespace Mail.dat.Io
{
	public class ExportOptions : IExportOptions
	{
		public string SourceFile { get; set; }
		public string TaregtVersion { get; set; }
		public IMaildatFile TargetFile { get; set; }
		public Encoding Encoding { get; set; } = Encoding.UTF8;
		public string LineTerminator { get; set; } = Environment.NewLine;
		public ILogger<IImportOptions> Logger { get; set; }
		public CancellationToken CancellationToken { get; set; }
	}
}
