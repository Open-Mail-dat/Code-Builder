// 
// Copyright (c) 2025 Open Mail.dat
// 
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
// 
// This code was auto-generated on May 23rd, 2025.
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

		public DbSet<ImportError> ImportErrors { get; set; }
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
			
			//
			// Specify the Key properties
			//
			modelBuilder.Entity<Cbr>().HasKey(t => t.Id);
			modelBuilder.Entity<Ccr>().HasKey(t => t.Id);
			modelBuilder.Entity<Cdr>().HasKey(t => t.Id);
			modelBuilder.Entity<Cfr>().HasKey(t => t.Id);
			modelBuilder.Entity<Chr>().HasKey(t => t.Id);
			modelBuilder.Entity<Cpt>().HasKey(t => t.Id);
			modelBuilder.Entity<Cqt>().HasKey(t => t.Id);
			modelBuilder.Entity<Csm>().HasKey(t => t.Id);
			modelBuilder.Entity<Epd>().HasKey(t => t.Id);
			modelBuilder.Entity<Hdr>().HasKey(t => t.Id);
			modelBuilder.Entity<Icr>().HasKey(t => t.Id);
			modelBuilder.Entity<Mcr>().HasKey(t => t.Id);
			modelBuilder.Entity<Mpa>().HasKey(t => t.Id);
			modelBuilder.Entity<Mpu>().HasKey(t => t.Id);
			modelBuilder.Entity<Oci>().HasKey(t => t.Id);
			modelBuilder.Entity<Par>().HasKey(t => t.Id);
			modelBuilder.Entity<Pbc>().HasKey(t => t.Id);
			modelBuilder.Entity<Pdr>().HasKey(t => t.Id);
			modelBuilder.Entity<Pqt>().HasKey(t => t.Id);
			modelBuilder.Entity<Rmb>().HasKey(t => t.Id);
			modelBuilder.Entity<Rmr>().HasKey(t => t.Id);
			modelBuilder.Entity<Rms>().HasKey(t => t.Id);
			modelBuilder.Entity<Seg>().HasKey(t => t.Id);
			modelBuilder.Entity<Sfb>().HasKey(t => t.Id);
			modelBuilder.Entity<Sfr>().HasKey(t => t.Id);
			modelBuilder.Entity<Snr>().HasKey(t => t.Id);
			modelBuilder.Entity<Upa>().HasKey(t => t.Id);
			modelBuilder.Entity<Wsr>().HasKey(t => t.Id);
			
			//
			// Add indices for the Key properties.
			//
			modelBuilder.Entity<Cbr>().HasIndex(t => t.JobID);
			modelBuilder.Entity<Cbr>().HasIndex(t => t.CertificateOfMailingHeaderID);
			modelBuilder.Entity<Cbr>().HasIndex(t => t.BulkRecordID);
			modelBuilder.Entity<Ccr>().HasIndex(t => t.JobID);
			modelBuilder.Entity<Ccr>().HasIndex(t => t.ComponentID);
			modelBuilder.Entity<Ccr>().HasIndex(t => t.CharacteristicType);
			modelBuilder.Entity<Ccr>().HasIndex(t => t.Characteristic);
			modelBuilder.Entity<Cdr>().HasIndex(t => t.JobID);
			modelBuilder.Entity<Cdr>().HasIndex(t => t.CertificateOfMailingHeaderID);
			modelBuilder.Entity<Cdr>().HasIndex(t => t.COMPieceID);
			modelBuilder.Entity<Cfr>().HasIndex(t => t.JobID);
			modelBuilder.Entity<Cfr>().HasIndex(t => t.CertificateOfMailingHeaderID);
			modelBuilder.Entity<Cfr>().HasIndex(t => t.PieceID);
			modelBuilder.Entity<Cfr>().HasIndex(t => t.ServiceType);
			modelBuilder.Entity<Chr>().HasIndex(t => t.JobID);
			modelBuilder.Entity<Chr>().HasIndex(t => t.CertificateOfMailingHeaderID);
			modelBuilder.Entity<Cpt>().HasIndex(t => t.JobID);
			modelBuilder.Entity<Cpt>().HasIndex(t => t.ComponentID);
			modelBuilder.Entity<Cqt>().HasIndex(t => t.JobID);
			modelBuilder.Entity<Cqt>().HasIndex(t => t.CQTDatabaseID);
			modelBuilder.Entity<Csm>().HasIndex(t => t.JobID);
			modelBuilder.Entity<Csm>().HasIndex(t => t.ContainerID);
			modelBuilder.Entity<Epd>().HasIndex(t => t.JobID);
			modelBuilder.Entity<Epd>().HasIndex(t => t.PieceID);
			modelBuilder.Entity<Epd>().HasIndex(t => t.CRIDType);
			modelBuilder.Entity<Hdr>().HasIndex(t => t.JobID);
			modelBuilder.Entity<Hdr>().HasIndex(t => t.HeaderHistorySequenceNumber);
			modelBuilder.Entity<Icr>().HasIndex(t => t.JobID);
			modelBuilder.Entity<Icr>().HasIndex(t => t.ContainerID);
			modelBuilder.Entity<Mcr>().HasIndex(t => t.JobID);
			modelBuilder.Entity<Mcr>().HasIndex(t => t.SegmentID);
			modelBuilder.Entity<Mcr>().HasIndex(t => t.MailPieceUnitID);
			modelBuilder.Entity<Mcr>().HasIndex(t => t.ComponentID);
			modelBuilder.Entity<Mpa>().HasIndex(t => t.JobID);
			modelBuilder.Entity<Mpa>().HasIndex(t => t.MPAUniqueSequenceGroupingID);
			modelBuilder.Entity<Mpu>().HasIndex(t => t.JobID);
			modelBuilder.Entity<Mpu>().HasIndex(t => t.SegmentID);
			modelBuilder.Entity<Mpu>().HasIndex(t => t.MailPieceUnitID);
			modelBuilder.Entity<Oci>().HasIndex(t => t.JobID);
			modelBuilder.Entity<Oci>().HasIndex(t => t.ContainerID);
			modelBuilder.Entity<Par>().HasIndex(t => t.JobID);
			modelBuilder.Entity<Par>().HasIndex(t => t.SegmentID);
			modelBuilder.Entity<Par>().HasIndex(t => t.MailPieceUnitID);
			modelBuilder.Entity<Par>().HasIndex(t => t.ComponentID);
			modelBuilder.Entity<Par>().HasIndex(t => t.SequenceNumber);
			modelBuilder.Entity<Pbc>().HasIndex(t => t.JobID);
			modelBuilder.Entity<Pbc>().HasIndex(t => t.PBCUniqueID);
			modelBuilder.Entity<Pdr>().HasIndex(t => t.JobID);
			modelBuilder.Entity<Pdr>().HasIndex(t => t.PieceID);
			modelBuilder.Entity<Pqt>().HasIndex(t => t.JobID);
			modelBuilder.Entity<Pqt>().HasIndex(t => t.CQTDatabaseID);
			modelBuilder.Entity<Pqt>().HasIndex(t => t.PackageID);
			modelBuilder.Entity<Rmb>().HasIndex(t => t.JobID);
			modelBuilder.Entity<Rmb>().HasIndex(t => t.RMSID);
			modelBuilder.Entity<Rmb>().HasIndex(t => t.Barcode);
			modelBuilder.Entity<Rmb>().HasIndex(t => t.RMBContentType);
			modelBuilder.Entity<Rmr>().HasIndex(t => t.JobID);
			modelBuilder.Entity<Rmr>().HasIndex(t => t.RMRID);
			modelBuilder.Entity<Rmr>().HasIndex(t => t.RMRIDType);
			modelBuilder.Entity<Rmr>().HasIndex(t => t.RMRContentType);
			modelBuilder.Entity<Rms>().HasIndex(t => t.JobID);
			modelBuilder.Entity<Rms>().HasIndex(t => t.RMSID);
			modelBuilder.Entity<Seg>().HasIndex(t => t.JobID);
			modelBuilder.Entity<Seg>().HasIndex(t => t.SegmentID);
			modelBuilder.Entity<Sfb>().HasIndex(t => t.JobID);
			modelBuilder.Entity<Sfb>().HasIndex(t => t.PieceID);
			modelBuilder.Entity<Sfr>().HasIndex(t => t.JobID);
			modelBuilder.Entity<Sfr>().HasIndex(t => t.PieceID);
			modelBuilder.Entity<Sfr>().HasIndex(t => t.ServiceType);
			modelBuilder.Entity<Snr>().HasIndex(t => t.JobID);
			modelBuilder.Entity<Snr>().HasIndex(t => t.ContainerID);
			modelBuilder.Entity<Snr>().HasIndex(t => t.PackageID);
			modelBuilder.Entity<Snr>().HasIndex(t => t.MailPieceUnitID);
			modelBuilder.Entity<Snr>().HasIndex(t => t.SeedNameID);
			modelBuilder.Entity<Snr>().HasIndex(t => t.VersionKeyCode);
			modelBuilder.Entity<Upa>().HasIndex(t => t.JobID);
			modelBuilder.Entity<Upa>().HasIndex(t => t.PieceID);
			modelBuilder.Entity<Wsr>().HasIndex(t => t.JobID);
			modelBuilder.Entity<Wsr>().HasIndex(t => t.SegmentID);
			modelBuilder.Entity<Wsr>().HasIndex(t => t.PackageZIPCode);
			modelBuilder.Entity<Wsr>().HasIndex(t => t.PackageCRNumber);
			modelBuilder.Entity<Wsr>().HasIndex(t => t.CoPalletizationCode);
		}
	}
}