//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by YinChang.
// 4.0.0
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace YC.Students.Dtos
{
    public partial class MetaData
    {
        public GroupPrimaryKeyDto GroupPrimaryKeyDto => new GroupPrimaryKeyDto();
        public GroupDto GroupDto => new GroupDto();
        public GroupCreateDto GroupCreateDto => new GroupCreateDto();
        public GroupUpdateDto GroupUpdateDto => new GroupUpdateDto();
        public GroupGetListDto GroupGetListDto => new GroupGetListDto();
        public GroupWithDetailsDto GroupWithDetailsDto => new GroupWithDetailsDto();
    }

    public partial class GroupPrimaryKeyDto : EntityDto<Guid>
    {
    }

    public partial class GroupDto : Volo.Abp.Application.Dtos.AuditedEntityDto<Guid>
    {
        public virtual string Name { get; set; }

        public virtual bool IsActive { get; set; }

    }

    public partial class GroupCreateDto
    {
        public virtual string Name { get; set; }

        public virtual bool IsActive { get; set; }

    }

    public partial class GroupUpdateDto
    {
        public virtual string Name { get; set; }

        public virtual bool IsActive { get; set; }

    }

    public partial class GroupGetListDto : PagedAndSortedResultRequestDto
    {
    }

    public partial class GroupWithDetailsDto : GroupDto
    {
        public List<StudentDto> Students { get; set; }

    }
}
