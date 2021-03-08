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
    public partial class StudentsApi //: IStudentCrudAppService //auto-generated 
    {
        [HttpGet]
        [Route("student/id")]
        [NonAction][RemoteService(false)]
        public Task<StudentWithDetailsDto> GetAsync([FromQuery] StudentPrimaryKeyDto StudentPrimaryKey)
        {
            return this.StudentCrudAppService.GetAsync(StudentPrimaryKey);
        }

        [HttpGet]
        [Route("student")]
        [RemoteService(true)]
        public Task<PagedResultDto<StudentWithDetailsDto>> GetListAsync(StudentGetListDto StudentGetList)
        {
            return this.StudentCrudAppService.GetListAsync(StudentGetList);
        }

        [HttpPost]
        [Route("student")]
        [NonAction][RemoteService(false)]
        public Task<StudentWithDetailsDto> CreateAsync(StudentCreateDto StudentCreate)
        {
            return this.StudentCrudAppService.CreateAsync(StudentCreate);
        }

        [HttpPut]
        [Route("student/id")]
        [NonAction][RemoteService(false)]
        public Task<StudentWithDetailsDto> UpdateAsync([FromQuery] StudentPrimaryKeyDto StudentPrimaryKey, StudentUpdateDto StudentUpdate)
        {
            return this.StudentCrudAppService.UpdateAsync(StudentPrimaryKey,StudentUpdate);
        }

        [HttpDelete]
        [Route("student/id")]
        [NonAction][RemoteService(false)]
        public Task DeleteAsync([FromQuery] StudentPrimaryKeyDto StudentPrimaryKey)
        {
            return this.StudentCrudAppService.DeleteAsync(StudentPrimaryKey);
        }
    }
}