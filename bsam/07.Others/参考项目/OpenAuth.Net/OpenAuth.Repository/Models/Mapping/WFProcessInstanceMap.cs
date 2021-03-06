﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace OpenAuth.Repository.Models.Mapping
{
    public partial class WFProcessInstanceMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<OpenAuth.Domain.WFProcessInstance>
    {
        public WFProcessInstanceMap()
        {
            // table
            ToTable("WF_ProcessInstance", "dbo");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("Id")
                .IsRequired();
            Property(t => t.Code)
                .HasColumnName("Code")
                .HasMaxLength(200)
                .IsRequired();
            Property(t => t.CustomName)
                .HasColumnName("CustomName")
                .HasMaxLength(200)
                .IsOptional();
            Property(t => t.ActivityId)
                .HasColumnName("ActivityId")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.ActivityType)
                .HasColumnName("ActivityType")
                .IsRequired();
            Property(t => t.ActivityName)
                .HasColumnName("ActivityName")
                .HasMaxLength(200)
                .IsRequired();
            Property(t => t.PreviousId)
                .HasColumnName("PreviousId")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.ProcessSchemeId)
                .HasColumnName("ProcessSchemeId")
                .IsRequired();
            Property(t => t.SchemeType)
                .HasColumnName("SchemeType")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.FrmType)
                .HasColumnName("FrmType")
                .IsOptional();
            Property(t => t.EnabledMark)
                .HasColumnName("EnabledMark")
                .IsRequired();
            Property(t => t.CreateDate)
                .HasColumnName("CreateDate")
                .IsRequired();
            Property(t => t.CreateUserId)
                .HasColumnName("CreateUserId")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.CreateUserName)
                .HasColumnName("CreateUserName")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.WfLevel)
                .HasColumnName("wfLevel")
                .IsOptional();
            Property(t => t.Description)
                .HasColumnName("Description")
                .HasMaxLength(200)
                .IsOptional();
            Property(t => t.IsFinish)
                .HasColumnName("isFinish")
                .IsOptional();
            Property(t => t.MakerList)
                .HasColumnName("MakerList")
                .HasMaxLength(1000)
                .IsOptional();

            // Relationships
        }
    }
}
