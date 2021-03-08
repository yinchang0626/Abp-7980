﻿//------------------------------------------------------------------------------
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
    public partial class StudentCrudAppService :  // auto-generated
        Volo.Abp.Application.Services.CrudAppService<YC.Students.Student, YC.Students.Dtos.StudentWithDetailsDto, Guid, YC.Students.Dtos.StudentGetListDto, YC.Students.Dtos.StudentCreateDto, YC.Students.Dtos.StudentUpdateDto>,
        IStudentCrudAppService
    {
        private readonly IStudentRepository _repository;

        public StudentCrudAppService(IStudentRepository repository) : base(repository)
        {
            this._repository = repository;
        }

        protected override async Task<IQueryable<Student>> CreateFilteredQueryAsync(StudentGetListDto input)
        {
            return await Repository.WithDetailsAsync();           
        }
    }
}