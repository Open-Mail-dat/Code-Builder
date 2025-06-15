//
// This file is part of Open Mail.dat.
// Copyright (c) 2025 Open Mail.dat. All rights reserved.
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
using Diamond.Core.CommandLine;
using Diamond.Core.Extensions.DependencyInjection;
using Diamond.Core.Extensions.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace Mail.dat.Cmd
{
	/// <summary>
	/// 
	/// </summary>
	public class Program
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="args"></param>
		/// <returns></returns>
		static Task<int> Main(string[] args) => Host.CreateDefaultBuilder(args)
							.AddRootCommand("Mail.dat Command Line Utility", args)
							.UseStartup<ConsoleStartup>()
							.UseSerilog()
							.ConfigureServicesFolder("Services")
							.UseConfiguredServices()
							.UseConsoleLifetime()
							.Build()
							.RunWithExitCodeAsync();
	}
}
