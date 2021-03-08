﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by YinChang.
// 4.0.0
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
using YC.Students.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace YC.Students
{
    public partial class StudentsApi //: IGroupCrudAppService //auto-generated 
    {
        [HttpGet]
        [Route("group/id")]
        [NonAction][RemoteService(false)]
        public Task<GroupWithDetailsDto> GetAsync([FromQuery] GroupPrimaryKeyDto GroupPrimaryKey)
        {
            return this.GroupCrudAppService.GetAsync(GroupPrimaryKey);
        }

        [HttpGet]
        [Route("group")]
        [RemoteService(true)]
        public Task<PagedResultDto<GroupWithDetailsDto>> GetListAsync(GroupGetListDto GroupGetList)
        {
            return this.GroupCrudAppService.GetListAsync(GroupGetList);
        }

        [HttpPost]
        [Route("group")]
        [NonAction][RemoteService(false)]
        public Task<GroupWithDetailsDto> CreateAsync(GroupCreateDto GroupCreate)
        {
            return this.GroupCrudAppService.CreateAsync(GroupCreate);
        }

        [HttpPut]
        [Route("group/id")]
        [NonAction][RemoteService(false)]
        public Task<GroupWithDetailsDto> UpdateAsync([FromQuery] GroupPrimaryKeyDto GroupPrimaryKey, GroupUpdateDto GroupUpdate)
        {
            return this.GroupCrudAppService.UpdateAsync(GroupPrimaryKey,GroupUpdate);
        }

        [HttpDelete]
        [Route("group/id")]
        [NonAction][RemoteService(false)]
        public Task DeleteAsync([FromQuery] GroupPrimaryKeyDto GroupPrimaryKey)
        {
            return this.GroupCrudAppService.DeleteAsync(GroupPrimaryKey);
        }
    }
}
