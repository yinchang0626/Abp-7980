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
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using YC.Students.Dtos;

namespace YC.Students
{
    public partial class GroupCrudAppService :  // auto-generated
        Volo.Abp.Application.Services.CrudAppService<YC.Students.Group, YC.Students.Dtos.GroupWithDetailsDto, Guid, YC.Students.Dtos.GroupGetListDto, YC.Students.Dtos.GroupCreateDto, YC.Students.Dtos.GroupUpdateDto>,
        IGroupCrudAppService
    {
        private readonly IGroupRepository _repository;

        public GroupCrudAppService(IGroupRepository repository) : base(repository)
        {
            this._repository = repository;
        }
        protected override async Task<IQueryable<Group>> CreateFilteredQueryAsync(GroupGetListDto input)
        {
            return await Repository.WithDetailsAsync();
        }
    }
}
