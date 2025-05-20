// 
// Copyright (c) 2025 Open Mail.dat
// 
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
// 
// This code was auto-generated on May 19th, 2025.
// by the Open Mail.dat Code Generator.
// 
// Author: Daniel M porrey
// Version 25.1.0.2
// 
using Diamond.Core.Repository.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Mail.dat
{
	/// <summary>
	/// Entity Framework Core database context for Mail.dat entities.
	/// </summary>
	public partial class MaildatContext : RepositoryContext<MaildatContext>
	{
		public MaildatContext()
			 : base()
		{
		}

		public MaildatContext(ILogger<MaildatContext> logger, DbContextOptions<MaildatContext> options)
			 : base(logger, options)
		{
			logger.LogDebug("Created {context}.", nameof(MaildatContext));
		}

		public DbSet<Cbr> Cbr { get; set; }
		public DbSet<Ccr> Ccr { get; set; }
		public DbSet<Cdr> Cdr { get; set; }
		public DbSet<Cfr> Cfr { get; set; }
		public DbSet<Chr> Chr { get; set; }
		public DbSet<Cpt> Cpt { get; set; }
		public DbSet<Cqt> Cqt { get; set; }
		public DbSet<Csm> Csm { get; set; }
		public DbSet<Epd> Epd { get; set; }
		public DbSet<Hdr> Hdr { get; set; }
		public DbSet<Icr> Icr { get; set; }
		public DbSet<Mcr> Mcr { get; set; }
		public DbSet<Mpa> Mpa { get; set; }
		public DbSet<Mpu> Mpu { get; set; }
		public DbSet<Oci> Oci { get; set; }
		public DbSet<Par> Par { get; set; }
		public DbSet<Pbc> Pbc { get; set; }
		public DbSet<Pdr> Pdr { get; set; }
		public DbSet<Pqt> Pqt { get; set; }
		public DbSet<Rmb> Rmb { get; set; }
		public DbSet<Rmr> Rmr { get; set; }
		public DbSet<Rms> Rms { get; set; }
		public DbSet<Seg> Seg { get; set; }
		public DbSet<Sfb> Sfb { get; set; }
		public DbSet<Sfr> Sfr { get; set; }
		public DbSet<Snr> Snr { get; set; }
		public DbSet<Upa> Upa { get; set; }
		public DbSet<Wsr> Wsr { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			this.Logger.LogDebug("OnModelCreating() called in {context}", nameof(MaildatContext));
		}
	}
}