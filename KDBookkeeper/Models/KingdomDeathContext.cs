using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace KDBookkeeper.Models
{
	public partial class KingdomDeathContext : DbContext
	{
		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//{
		//    #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
		//    optionsBuilder.UseSqlServer(@"Server=JEREMYH;Database=KingdomDeath;Trusted_Connection=True;");
		//}

		public KingdomDeathContext(DbContextOptions<KingdomDeathContext> options)
				: base(options)
		{ }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<AppliesKeyword>(entity =>
			{
				entity.Property(e => e.Name)
									.IsRequired()
									.HasMaxLength(50);
			});

			modelBuilder.Entity<EventChart>(entity =>
			{
				entity.HasOne(d => d.LanternEvent)
					.WithMany(p => p.EventCharts)
					.OnDelete(DeleteBehavior.Restrict)
					.HasConstraintName("FK_EventChart_LanternEvent");
			});

			modelBuilder.Entity<EventConsequence>(entity =>
			{
				entity.HasOne(d => d.LanternEvent)
					.WithMany(p => p.EventConsequences)
					.OnDelete(DeleteBehavior.Restrict)
					.HasConstraintName("FK_EventConsequences_LanternEvent");
			});

			modelBuilder.Entity<GameEvents>(entity =>
			{
				entity.Property(e => e.IsRandom).HasColumnName("isRandom");

				entity.HasOne(d => d.GameType)
									.WithMany(p => p.GameEvents)
									.HasForeignKey(d => d.GameTypeId)
									.OnDelete(DeleteBehavior.Restrict)
									.HasConstraintName("FK_GameEvents_GameType");

				entity.HasOne(d => d.LaternEvent)
									.WithMany(p => p.GameEvents)
									.HasForeignKey(d => d.LaternEventId)
									.OnDelete(DeleteBehavior.Restrict)
									.HasConstraintName("FK_GameEvents_LanternEvent");
			});

			modelBuilder.Entity<GameStartingInnovation>(entity =>
			{
				entity.HasOne(d => d.GameType)
									.WithMany(p => p.GameStartingInnovation)
									.HasForeignKey(d => d.GameTypeId)
									.OnDelete(DeleteBehavior.Restrict)
									.HasConstraintName("FK_GameStartingInnovation_GameType");

				entity.HasOne(d => d.Innovation)
									.WithMany(p => p.GameStartingInnovation)
									.HasForeignKey(d => d.InnovationId)
									.OnDelete(DeleteBehavior.Restrict)
									.HasConstraintName("FK_GameStartingInnovation_Innovation");
			});

			modelBuilder.Entity<GameType>(entity =>
			{
				entity.Property(e => e.Description)
									.IsRequired()
									.HasMaxLength(150);

				entity.Property(e => e.Name)
									.IsRequired()
									.HasMaxLength(50);
			});

			modelBuilder.Entity<Innovation>(entity =>
			{
				entity.Property(e => e.Description)
									.IsRequired()
									.HasMaxLength(250);

				entity.Property(e => e.Expansion)
									.IsRequired()
									.HasMaxLength(50);

				entity.Property(e => e.Name)
									.IsRequired()
									.HasMaxLength(50);

				entity.Property(e => e.ParentWord).HasMaxLength(50);
			});

			modelBuilder.Entity<InnovationModifier>(entity =>
			{
				entity.Property(e => e.ModifiedItem)
									.IsRequired()
									.HasMaxLength(50);

				entity.HasOne(d => d.AppliesToNavigation)
									.WithMany(p => p.InnovationModifier)
									.HasForeignKey(d => d.AppliesTo)
									.OnDelete(DeleteBehavior.Restrict)
									.HasConstraintName("FK_InnovationModifier_AppliesKeyword");

				entity.HasOne(d => d.Innovation)
									.WithMany(p => p.InnovationModifier)
									.HasForeignKey(d => d.InnovationId)
									.OnDelete(DeleteBehavior.Restrict)
									.HasConstraintName("FK_InnovationModifier_Innovation");
			});

			modelBuilder.Entity<InnovationWords>(entity =>
			{
				entity.Property(e => e.Keyword)
									.IsRequired()
									.HasMaxLength(50);

				entity.HasOne(d => d.Innovation)
									.WithMany(p => p.InnovationWords)
									.HasForeignKey(d => d.InnovationId)
									.OnDelete(DeleteBehavior.Restrict)
									.HasConstraintName("FK_InnovationWords_Innovation");
			});

			modelBuilder.Entity<LanternEvent>(entity =>
			{
				entity.Property(e => e.Description)
									.IsRequired()
									.HasMaxLength(150);

				entity.Property(e => e.Expansion)
									.IsRequired()
									.HasMaxLength(50);

				entity.Property(e => e.IsRandom).HasColumnName("isRandom");

				entity.Property(e => e.Name)
									.IsRequired()
									.HasMaxLength(50);
			});

			modelBuilder.Entity<Location>(entity =>
			{
				entity.Property(e => e.Name)
									.IsRequired()
									.HasMaxLength(50);
			});

			modelBuilder.Entity<Monster>(entity =>
			{
				entity.Property(e => e.Name)
									.IsRequired()
									.HasMaxLength(50);
			});

			modelBuilder.Entity<Principle>(entity =>
			{
				entity.Property(e => e.Description)
									.IsRequired()
									.HasMaxLength(250);

				entity.Property(e => e.Name)
									.IsRequired()
									.HasMaxLength(50);
			});

			modelBuilder.Entity<PrincipleModifier>(entity =>
			{
				entity.Property(e => e.ModifiedAttribute)
									.IsRequired()
									.HasMaxLength(50);

				entity.HasOne(d => d.AppliesToNavigation)
									.WithMany(p => p.PrincipleModifier)
									.HasForeignKey(d => d.AppliesTo)
									.OnDelete(DeleteBehavior.Restrict)
									.HasConstraintName("FK_PrincipleModifier_AppliesKeyword");

				entity.HasOne(d => d.Principle)
									.WithMany(p => p.PrincipleModifier)
									.HasForeignKey(d => d.PrincipleId)
									.OnDelete(DeleteBehavior.Restrict)
									.HasConstraintName("FK_PrincipleModifier_Principle");
			});

			modelBuilder.Entity<ResourceItem>(entity =>
			{
				entity.Property(e => e.Name)
									.IsRequired()
									.HasMaxLength(50);
			});

			modelBuilder.Entity<Settlement>(entity =>
			{
				entity.Property(e => e.Name)
									.IsRequired()
									.HasMaxLength(150);

				entity.HasOne(d => d.GameType)
									.WithMany(p => p.Settlements)
									.HasForeignKey(d => d.GameTypeId)
									.OnDelete(DeleteBehavior.Restrict)
									.HasConstraintName("FK_Settlement_GameType");
			});

			modelBuilder.Entity<SettlementInnovation>(entity =>
			{
				entity.HasOne(d => d.Innovaton)
									.WithMany(p => p.SettlementInnovation)
									.HasForeignKey(d => d.InnovatonId)
									.OnDelete(DeleteBehavior.Restrict)
									.HasConstraintName("FK_SettlementInnovation_Innovation");

				entity.HasOne(d => d.Settlement)
									.WithMany(p => p.SettlementInnovation)
									.HasForeignKey(d => d.SettlementId)
									.OnDelete(DeleteBehavior.Restrict)
									.HasConstraintName("FK_SettlementInnovation_Settlement");
			});

			modelBuilder.Entity<SettlementLocation>(entity =>
			{
				entity.HasOne(d => d.Location)
									.WithMany(p => p.SettlementLocation)
									.HasForeignKey(d => d.LocationId)
									.OnDelete(DeleteBehavior.Restrict)
									.HasConstraintName("FK_SettlementLocation_Location");

				entity.HasOne(d => d.Settlement)
									.WithMany(p => p.SettlementLocation)
									.HasForeignKey(d => d.SettlementId)
									.OnDelete(DeleteBehavior.Restrict)
									.HasConstraintName("FK_SettlementLocation_Settlement");
			});

			modelBuilder.Entity<SettlementMileStones>(entity =>
			{
				entity.Property(e => e.Name)
									.IsRequired()
									.HasMaxLength(50);

				entity.HasOne(d => d.LaternEvent)
									.WithMany(p => p.SettlementMileStones)
									.HasForeignKey(d => d.LaternEventId)
									.OnDelete(DeleteBehavior.Restrict)
									.HasConstraintName("FK_SettlementMileStones_LanternEvent");

				entity.HasOne(d => d.Settlement)
									.WithMany(p => p.SettlementMileStones)
									.HasForeignKey(d => d.SettlementId)
									.OnDelete(DeleteBehavior.Restrict)
									.HasConstraintName("FK_SettlementMileStones_Settlement");
			});

			modelBuilder.Entity<SettlementMonster>(entity =>
			{
				entity.HasOne(d => d.Monster)
									.WithMany(p => p.SettlementMonster)
									.HasForeignKey(d => d.MonsterId)
									.OnDelete(DeleteBehavior.Restrict)
									.HasConstraintName("FK_SettlementMonster_Monster");

				entity.HasOne(d => d.Settlement)
									.WithMany(p => p.SettlementMonster)
									.HasForeignKey(d => d.MonsterId)
									.OnDelete(DeleteBehavior.Restrict)
									.HasConstraintName("FK_SettlementMonster_Settlement");
			});

			modelBuilder.Entity<SettlementNemisis>(entity =>
			{
				entity.HasOne(d => d.Monster)
									.WithMany(p => p.SettlementNemisis)
									.HasForeignKey(d => d.MonsterId)
									.OnDelete(DeleteBehavior.Restrict)
									.HasConstraintName("FK_SettlementNemisis_Monster");

				entity.HasOne(d => d.Settlement)
									.WithMany(p => p.SettlementNemisis)
									.HasForeignKey(d => d.SettlementId)
									.OnDelete(DeleteBehavior.Restrict)
									.HasConstraintName("FK_SettlementNemisis_Settlement");
			});

			modelBuilder.Entity<SettlementPrinciple>(entity =>
			{
				entity.HasOne(d => d.Principle)
									.WithMany(p => p.SettlementPrinciple)
									.HasForeignKey(d => d.PrincipleId)
									.OnDelete(DeleteBehavior.Restrict)
									.HasConstraintName("FK_SettlementPrinciple_Principle");

				entity.HasOne(d => d.Settlement)
									.WithMany(p => p.SettlementPrinciple)
									.HasForeignKey(d => d.SettlementId)
									.OnDelete(DeleteBehavior.Restrict)
									.HasConstraintName("FK_SettlementPrinciple_Settlement");
			});

			modelBuilder.Entity<SettlementQuarries>(entity =>
			{
				entity.HasOne(d => d.Monster)
									.WithMany(p => p.SettlementQuarries)
									.HasForeignKey(d => d.MonsterId)
									.OnDelete(DeleteBehavior.Restrict)
									.HasConstraintName("FK_SettlementQuarries_Monster");

				entity.HasOne(d => d.Settlement)
									.WithMany(p => p.SettlementQuarries)
									.HasForeignKey(d => d.SettlementId)
									.OnDelete(DeleteBehavior.Restrict)
									.HasConstraintName("FK_SettlementQuarries_Settlement");
			});

			modelBuilder.Entity<SettlementResource>(entity =>
			{
				entity.HasOne(d => d.Resource)
									.WithMany(p => p.SettlementResource)
									.HasForeignKey(d => d.ResourceId)
									.OnDelete(DeleteBehavior.Restrict)
									.HasConstraintName("FK_SettlementResource_ResourceItem");

				entity.HasOne(d => d.Settlement)
									.WithMany(p => p.SettlementResource)
									.HasForeignKey(d => d.SettlementId)
									.OnDelete(DeleteBehavior.Restrict)
									.HasConstraintName("FK_SettlementResource_Settlement");
			});

			modelBuilder.Entity<Survivor>(entity =>
			{
				entity.Property(e => e.Name)
									.IsRequired()
									.HasMaxLength(50);

				entity.HasOne(d => d.Settlement)
									.WithMany(p => p.Survivor)
									.HasForeignKey(d => d.SettlementId)
									.OnDelete(DeleteBehavior.Restrict)
									.HasConstraintName("FK_Survivor_Settlement");
			});
		}

		public virtual DbSet<AppliesKeyword> AppliesKeyword { get; set; }
		public virtual DbSet<GameEvents> GameEvents { get; set; }
		public virtual DbSet<GameStartingInnovation> GameStartingInnovation { get; set; }
		public virtual DbSet<GameType> GameType { get; set; }
		public virtual DbSet<Innovation> Innovation { get; set; }
		public virtual DbSet<InnovationModifier> InnovationModifier { get; set; }
		public virtual DbSet<InnovationWords> InnovationWords { get; set; }
		public virtual DbSet<LanternEvent> LanternEvent { get; set; }
		public virtual DbSet<Location> Location { get; set; }
		public virtual DbSet<Monster> Monster { get; set; }
		public virtual DbSet<Principle> Principle { get; set; }
		public virtual DbSet<PrincipleModifier> PrincipleModifier { get; set; }
		public virtual DbSet<ResourceItem> ResourceItem { get; set; }
		public virtual DbSet<Settlement> Settlement { get; set; }
		public virtual DbSet<SettlementInnovation> SettlementInnovation { get; set; }
		public virtual DbSet<SettlementLocation> SettlementLocation { get; set; }
		public virtual DbSet<SettlementMileStones> SettlementMileStones { get; set; }
		public virtual DbSet<SettlementMonster> SettlementMonster { get; set; }
		public virtual DbSet<SettlementNemisis> SettlementNemisis { get; set; }
		public virtual DbSet<SettlementPrinciple> SettlementPrinciple { get; set; }
		public virtual DbSet<SettlementQuarries> SettlementQuarries { get; set; }
		public virtual DbSet<SettlementResource> SettlementResource { get; set; }
		public virtual DbSet<Survivor> Survivor { get; set; }
		public virtual DbSet<EventConsequence> EventConsequence { get; set; }
		public virtual DbSet<SettlementHuntHistory>  SettlementHuntHistory { get; set; }
		public virtual DbSet<SurvivorHuntHistory> SurvivorHuntHistory { get; set; }
	}
}