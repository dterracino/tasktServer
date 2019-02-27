﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tasktServer.Models;

namespace tasktServer.Migrations
{
    [DbContext(typeof(tasktDatabaseContext))]
    partial class tasktDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("tasktServer.Models.AssignedPoolWorker", b =>
                {
                    b.Property<Guid>("AssignedPoolWorkerItemID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("WorkerID");

                    b.Property<Guid?>("WorkerPoolID");

                    b.HasKey("AssignedPoolWorkerItemID");

                    b.HasIndex("WorkerPoolID");

                    b.ToTable("AssignedPoolWorker");
                });

            modelBuilder.Entity("tasktServer.Models.Assignment", b =>
                {
                    b.Property<Guid>("AssignmentID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AssignedWorker");

                    b.Property<string>("AssignmentName");

                    b.Property<bool>("Enabled");

                    b.Property<int>("Frequency");

                    b.Property<int>("Interval");

                    b.Property<DateTime>("NewTaskDue");

                    b.Property<Guid>("PublishedScriptID");

                    b.HasKey("AssignmentID");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("tasktServer.Models.BotStoreModel", b =>
                {
                    b.Property<Guid>("StoreID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BotStoreName");

                    b.Property<string>("BotStoreValue");

                    b.Property<Guid>("LastUpdatedBy");

                    b.Property<DateTime>("LastUpdatedOn");

                    b.HasKey("StoreID");

                    b.ToTable("BotStore");
                });

            modelBuilder.Entity("tasktServer.Models.PublishedScript", b =>
                {
                    b.Property<Guid>("PublishedScriptID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FriendlyName");

                    b.Property<DateTime>("PublishedOn");

                    b.Property<string>("ScriptData");

                    b.Property<int>("ScriptType");

                    b.Property<Guid>("WorkerID");

                    b.HasKey("PublishedScriptID");

                    b.ToTable("PublishedScripts");
                });

            modelBuilder.Entity("tasktServer.Models.Task", b =>
                {
                    b.Property<Guid>("TaskID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ExecutionType");

                    b.Property<string>("IPAddress");

                    b.Property<string>("MachineName");

                    b.Property<string>("Remark");

                    b.Property<string>("Script");

                    b.Property<string>("Status");

                    b.Property<DateTime>("TaskFinished");

                    b.Property<DateTime>("TaskStarted");

                    b.Property<string>("UserName");

                    b.Property<Guid>("WorkerID");

                    b.Property<string>("WorkerType");

                    b.HasKey("TaskID");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("tasktServer.Models.UserProfile", b =>
                {
                    b.Property<Guid>("LoginID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("LastSuccessfulLogin");

                    b.Property<string>("LoginName");

                    b.Property<string>("LoginPassword");

                    b.HasKey("LoginID");

                    b.ToTable("LoginProfiles");
                });

            modelBuilder.Entity("tasktServer.Models.Worker", b =>
                {
                    b.Property<Guid>("WorkerID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("LastCheckIn");

                    b.Property<string>("MachineName");

                    b.Property<int>("Status");

                    b.Property<string>("UserName");

                    b.HasKey("WorkerID");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("tasktServer.Models.WorkerPool", b =>
                {
                    b.Property<Guid>("WorkerPoolID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("WorkerPoolName");

                    b.HasKey("WorkerPoolID");

                    b.ToTable("WorkerPools");
                });

            modelBuilder.Entity("tasktServer.Models.AssignedPoolWorker", b =>
                {
                    b.HasOne("tasktServer.Models.WorkerPool")
                        .WithMany("PoolWorkers")
                        .HasForeignKey("WorkerPoolID");
                });
#pragma warning restore 612, 618
        }
    }
}
